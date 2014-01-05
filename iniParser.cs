using System;
using System.IO;
using System.Collections;


public class iniParser
{
    private Hashtable keyPairs = new Hashtable();
    private String _parameters;

    private struct SectionPair
    {
        public String Section;
        public String Key;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public iniParser(String parameters)
    {
        _parameters = parameters;
        String strLine = null;
        String currentRoot = null;
        String[] keyPair = null;
        try
        {
            //  iniFile = new StreamReader(parameters);
            StringReader reader = new StringReader(parameters);

            while ((strLine = reader.ReadLine()) != null)
            {
                strLine = strLine.Trim();

                if (strLine != "")
                {
                    if (strLine.StartsWith("[") && strLine.EndsWith("]"))
                        currentRoot = strLine.Substring(1, strLine.Length - 2);
                    else if (strLine.Contains("="))  //tylko linijki gdzie jest =
                    {
                        keyPair = strLine.Split(new char[] { '=' }, 2);

                        SectionPair sectionPair;
                        String value = null;

                        if (currentRoot == null)
                            currentRoot = "ROOT";

                        sectionPair.Section = currentRoot;
                        sectionPair.Key = keyPair[0];

                        if (keyPair.Length > 1)
                            value = keyPair[1];

                        keyPairs.Add(sectionPair, value);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }
        // }
        // else
        //     throw new FileNotFoundException("Unable to locate " + iniPath);

    }


    /// <summary>
    /// Pobierz cala sekcje podaje sie sama nazwe sekcji np [SQL]
    /// </summary>
    /// <param name="sectionName">Bez nawiasow kwadratowych nazwa sekcji np SQL</param>
    public string getSectionString(String sectionName)
    {
        StringReader reader = new StringReader(_parameters);
        String strLine = null;
        String currentRoot = null;
        string retval = "";
        while ((strLine = reader.ReadLine()) != null)
        {
            strLine = strLine.Trim();
            if (strLine != "")
            {
                if (strLine.StartsWith("[") && strLine.EndsWith("]")) //znaleziono zapis sekcji
                    currentRoot = strLine.Substring(1, strLine.Length - 2); //bez nawiasow kwadratowych

                if (currentRoot == sectionName && string.Format("[{0}]", currentRoot) != strLine) //sekcja = sekcji podanej pobierz wartosci ale samej sekcji nei bierz
                    retval += strLine + "\n";
            }
        }
        return retval;
    }


    /// <summary>
    /// Returns the value for the given section, key pair.
    /// </summary>
    /// <param name="sectionName">Section name. np SQL (bez nawiasow kwadratowych)</param>
    /// <param name="settingName">Key name. np dupa</param>
    public String GetSetting(String sectionName, String settingName)
    {
        SectionPair sectionPair;
        sectionPair.Section = sectionName;
        sectionPair.Key = settingName;

        return (String)keyPairs[sectionPair];
    }

    /// <summary>
    /// Enumerates all lines for given section.
    /// </summary>
    /// <param name="sectionName">Section to enum.</param>
    public String[] EnumSection(String sectionName)
    {
        ArrayList tmpArray = new ArrayList();

        foreach (SectionPair pair in keyPairs.Keys)
        {
            if (pair.Section == sectionName.ToUpper())
                tmpArray.Add(pair.Key);
        }

        return (String[])tmpArray.ToArray(typeof(String));
    }



    /// <summary>
    /// Iteracja parametrów @
    /// </summary>
    /// <param name="sectionName"></param>
    /// <returns></returns>
    public ArrayList EnumParameters()
    {
        ArrayList tmpArray = new ArrayList();

        foreach (SectionPair pair in keyPairs.Keys)
        {
            if (pair.Section.StartsWith("@"))
                tmpArray.Add(pair.Section);
        }

        return tmpArray;
    }

    /// <summary>
    /// Adds or replaces a setting to the table to be saved.
    /// </summary>
    /// <param name="sectionName">Section to add under. np [SQL]</param>
    /// <param name="settingName">Key name to add.</param>
    /// <param name="settingValue">Value of key.</param>
    public void AddSetting(String sectionName, String settingName, String settingValue)
    {
        SectionPair sectionPair;
        sectionPair.Section = sectionName.ToUpper();
        sectionPair.Key = settingName.ToUpper();

        if (keyPairs.ContainsKey(sectionPair))
            keyPairs.Remove(sectionPair);

        keyPairs.Add(sectionPair, settingValue);
    }

    /// <summary>
    /// Adds or replaces a setting to the table to be saved with a null value.
    /// </summary>
    /// <param name="sectionName">Section to add under.</param>
    /// <param name="settingName">Key name to add.</param>
    public void AddSetting(String sectionName, String settingName)
    {
        AddSetting(sectionName, settingName, null);
    }

    /// <summary>
    /// Remove a setting.
    /// </summary>
    /// <param name="sectionName">Section to add under.</param>
    /// <param name="settingName">Key name to add.</param>
    public void DeleteSetting(String sectionName, String settingName)
    {
        SectionPair sectionPair;
        sectionPair.Section = sectionName.ToUpper();
        sectionPair.Key = settingName.ToUpper();

        if (keyPairs.ContainsKey(sectionPair))
            keyPairs.Remove(sectionPair);
    }

    /// <summary>
    /// Nieobsluzone Save settings to new file.
    /// </summary>
    /// <param name="newFilePath">New file path.</param>
    public void SaveSettings(String newFilePath)
    {
        ArrayList sections = new ArrayList();
        String tmpValue = "";
        String strToSave = "";

        foreach (SectionPair sectionPair in keyPairs.Keys)
        {
            if (!sections.Contains(sectionPair.Section))
                sections.Add(sectionPair.Section);
        }

        foreach (String section in sections)
        {
            strToSave += ("[" + section + "]\r\n");

            foreach (SectionPair sectionPair in keyPairs.Keys)
            {
                if (sectionPair.Section == section)
                {
                    tmpValue = (String)keyPairs[sectionPair];

                    if (tmpValue != null)
                        tmpValue = "=" + tmpValue;

                    strToSave += (sectionPair.Key + tmpValue + "\r\n");
                }
            }

            strToSave += "\r\n";
        }

        try
        {
            TextWriter tw = new StreamWriter(newFilePath);
            tw.Write(strToSave);
            tw.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Nieobsluzone Save settings back to ini file.
    /// </summary>
    public void SaveSettings()
    {
        //  SaveSettings(iniFilePath);
    }
}
