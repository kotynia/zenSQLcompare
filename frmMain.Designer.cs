namespace zenComparer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtarguments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtExternalTool = new System.Windows.Forms.TextBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.slogin = new System.Windows.Forms.TextBox();
            this.sdatabase = new System.Windows.Forms.TextBox();
            this.sserver = new System.Windows.Forms.TextBox();
            this.txtSlave = new System.Windows.Forms.TextBox();
            this.sssi = new System.Windows.Forms.CheckBox();
            this.spassword = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.RefreshSlave = new System.Windows.Forms.Label();
            this.butSwitch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GroupModel = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mdatabase = new System.Windows.Forms.TextBox();
            this.mserver = new System.Windows.Forms.TextBox();
            this.lblfile = new System.Windows.Forms.Label();
            this.mlogin = new System.Windows.Forms.TextBox();
            this.mpassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mSSI = new System.Windows.Forms.CheckBox();
            this.txtMaster = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartCompare = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toolLog = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Object = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScriptModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScriptTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.RichTextBox();
            this.btnShowDiff = new System.Windows.Forms.Button();
            this.btnGridToScript = new System.Windows.Forms.Button();
            this.txtexclude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolLoad = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupModel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 61);
            this.tab.Margin = new System.Windows.Forms.Padding(6);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1656, 1017);
            this.tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1648, 979);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings & Connections properties";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.GroupBox4);
            this.panel4.Controls.Add(this.butSwitch);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.GroupModel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1636, 1000);
            this.panel4.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtarguments);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.txtExternalTool);
            this.groupBox2.Location = new System.Drawing.Point(10, 561);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1436, 242);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External command Line Tool";
            // 
            // txtarguments
            // 
            this.txtarguments.Location = new System.Drawing.Point(22, 98);
            this.txtarguments.Margin = new System.Windows.Forms.Padding(6);
            this.txtarguments.Name = "txtarguments";
            this.txtarguments.Size = new System.Drawing.Size(1236, 31);
            this.txtarguments.TabIndex = 94;
            this.txtarguments.Text = "\"%Model\" \"%Target\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "% Model , % Target ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(22, 189);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(201, 25);
            this.linkLabel1.TabIndex = 90;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://winmerge.org/";
            // 
            // txtExternalTool
            // 
            this.txtExternalTool.Location = new System.Drawing.Point(22, 48);
            this.txtExternalTool.Margin = new System.Windows.Forms.Padding(6);
            this.txtExternalTool.Name = "txtExternalTool";
            this.txtExternalTool.Size = new System.Drawing.Size(1240, 31);
            this.txtExternalTool.TabIndex = 91;
            this.txtExternalTool.Text = "\"c:\\Program Files (x86)\\WinMerge\\Winmergeu.exe\"";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.label16);
            this.GroupBox4.Controls.Add(this.label8);
            this.GroupBox4.Controls.Add(this.label7);
            this.GroupBox4.Controls.Add(this.slogin);
            this.GroupBox4.Controls.Add(this.sdatabase);
            this.GroupBox4.Controls.Add(this.sserver);
            this.GroupBox4.Controls.Add(this.txtSlave);
            this.GroupBox4.Controls.Add(this.sssi);
            this.GroupBox4.Controls.Add(this.spassword);
            this.GroupBox4.Controls.Add(this.Label9);
            this.GroupBox4.Controls.Add(this.Label10);
            this.GroupBox4.Controls.Add(this.RefreshSlave);
            this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupBox4.Location = new System.Drawing.Point(10, 306);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.GroupBox4.Size = new System.Drawing.Size(1436, 244);
            this.GroupBox4.TabIndex = 84;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Target Database";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(1152, 214);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(229, 24);
            this.label16.TabIndex = 81;
            this.label16.Text = "connectionString on focus";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(528, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 27);
            this.label8.TabIndex = 67;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(528, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 33);
            this.label7.TabIndex = 66;
            this.label7.Text = "Login";
            // 
            // slogin
            // 
            this.slogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.slogin.Location = new System.Drawing.Point(666, 134);
            this.slogin.Margin = new System.Windows.Forms.Padding(6);
            this.slogin.Name = "slogin";
            this.slogin.Size = new System.Drawing.Size(188, 37);
            this.slogin.TabIndex = 59;
            // 
            // sdatabase
            // 
            this.sdatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sdatabase.Location = new System.Drawing.Point(224, 77);
            this.sdatabase.Margin = new System.Windows.Forms.Padding(6);
            this.sdatabase.Name = "sdatabase";
            this.sdatabase.Size = new System.Drawing.Size(630, 37);
            this.sdatabase.TabIndex = 58;
            // 
            // sserver
            // 
            this.sserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sserver.Location = new System.Drawing.Point(224, 31);
            this.sserver.Margin = new System.Windows.Forms.Padding(6);
            this.sserver.Name = "sserver";
            this.sserver.Size = new System.Drawing.Size(630, 37);
            this.sserver.TabIndex = 57;
            // 
            // txtSlave
            // 
            this.txtSlave.BackColor = System.Drawing.Color.White;
            this.txtSlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSlave.ForeColor = System.Drawing.Color.White;
            this.txtSlave.Location = new System.Drawing.Point(892, 33);
            this.txtSlave.Margin = new System.Windows.Forms.Padding(6);
            this.txtSlave.Multiline = true;
            this.txtSlave.Name = "txtSlave";
            this.txtSlave.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSlave.Size = new System.Drawing.Size(512, 171);
            this.txtSlave.TabIndex = 3;
            this.txtSlave.Enter += new System.EventHandler(this.txtSlave_Enter);
            this.txtSlave.Leave += new System.EventHandler(this.txtSlave_Leave);
            // 
            // sssi
            // 
            this.sssi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sssi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sssi.Location = new System.Drawing.Point(22, 161);
            this.sssi.Margin = new System.Windows.Forms.Padding(6);
            this.sssi.Name = "sssi";
            this.sssi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sssi.Size = new System.Drawing.Size(394, 61);
            this.sssi.TabIndex = 65;
            this.sssi.Text = "Integrated Security (SSI), Windows Authentication ";
            this.sssi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sssi.UseVisualStyleBackColor = false;
            this.sssi.CheckedChanged += new System.EventHandler(this.sssi_CheckedChanged);
            // 
            // spassword
            // 
            this.spassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.spassword.Location = new System.Drawing.Point(666, 181);
            this.spassword.Margin = new System.Windows.Forms.Padding(6);
            this.spassword.Name = "spassword";
            this.spassword.PasswordChar = '*';
            this.spassword.Size = new System.Drawing.Size(188, 37);
            this.spassword.TabIndex = 64;
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label9.Location = new System.Drawing.Point(16, 77);
            this.Label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(352, 44);
            this.Label9.TabIndex = 61;
            this.Label9.Text = "Database...........................";
            // 
            // Label10
            // 
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label10.Location = new System.Drawing.Point(16, 31);
            this.Label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(320, 44);
            this.Label10.TabIndex = 60;
            this.Label10.Text = "Server...............................";
            // 
            // RefreshSlave
            // 
            this.RefreshSlave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RefreshSlave.Location = new System.Drawing.Point(160, 339);
            this.RefreshSlave.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RefreshSlave.Name = "RefreshSlave";
            this.RefreshSlave.Size = new System.Drawing.Size(256, 61);
            this.RefreshSlave.TabIndex = 4;
            // 
            // butSwitch
            // 
            this.butSwitch.Location = new System.Drawing.Point(1208, 258);
            this.butSwitch.Margin = new System.Windows.Forms.Padding(6);
            this.butSwitch.Name = "butSwitch";
            this.butSwitch.Size = new System.Drawing.Size(236, 44);
            this.butSwitch.TabIndex = 85;
            this.butSwitch.Text = "Model <> Target";
            this.butSwitch.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(26, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 44);
            this.label11.TabIndex = 79;
            this.label11.Text = "Database...........................";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(26, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 44);
            this.label12.TabIndex = 78;
            this.label12.Text = "Server...............................";
            // 
            // GroupModel
            // 
            this.GroupModel.Controls.Add(this.label15);
            this.GroupModel.Controls.Add(this.mdatabase);
            this.GroupModel.Controls.Add(this.mserver);
            this.GroupModel.Controls.Add(this.lblfile);
            this.GroupModel.Controls.Add(this.mlogin);
            this.GroupModel.Controls.Add(this.mpassword);
            this.GroupModel.Controls.Add(this.label13);
            this.GroupModel.Controls.Add(this.label14);
            this.GroupModel.Controls.Add(this.mSSI);
            this.GroupModel.Controls.Add(this.txtMaster);
            this.GroupModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.GroupModel.Location = new System.Drawing.Point(10, 17);
            this.GroupModel.Margin = new System.Windows.Forms.Padding(6);
            this.GroupModel.Name = "GroupModel";
            this.GroupModel.Padding = new System.Windows.Forms.Padding(6);
            this.GroupModel.Size = new System.Drawing.Size(1436, 236);
            this.GroupModel.TabIndex = 81;
            this.GroupModel.TabStop = false;
            this.GroupModel.Text = "Model Database";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(1152, 206);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(229, 24);
            this.label15.TabIndex = 80;
            this.label15.Text = "connectionString on focus";
            // 
            // mdatabase
            // 
            this.mdatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mdatabase.Location = new System.Drawing.Point(224, 73);
            this.mdatabase.Margin = new System.Windows.Forms.Padding(6);
            this.mdatabase.Name = "mdatabase";
            this.mdatabase.Size = new System.Drawing.Size(630, 37);
            this.mdatabase.TabIndex = 79;
            // 
            // mserver
            // 
            this.mserver.AccessibleName = "mserver";
            this.mserver.AutoCompleteCustomSource.AddRange(new string[] {
            "test",
            "test1",
            "test2"});
            this.mserver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.mserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mserver.Location = new System.Drawing.Point(224, 27);
            this.mserver.Margin = new System.Windows.Forms.Padding(6);
            this.mserver.Name = "mserver";
            this.mserver.Size = new System.Drawing.Size(630, 37);
            this.mserver.TabIndex = 78;
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(34, 225);
            this.lblfile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(0, 29);
            this.lblfile.TabIndex = 52;
            // 
            // mlogin
            // 
            this.mlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mlogin.Location = new System.Drawing.Point(666, 125);
            this.mlogin.Margin = new System.Windows.Forms.Padding(6);
            this.mlogin.Name = "mlogin";
            this.mlogin.Size = new System.Drawing.Size(188, 37);
            this.mlogin.TabIndex = 41;
            // 
            // mpassword
            // 
            this.mpassword.AccessibleName = "main";
            this.mpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mpassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mpassword.Location = new System.Drawing.Point(666, 173);
            this.mpassword.Margin = new System.Windows.Forms.Padding(6);
            this.mpassword.Name = "mpassword";
            this.mpassword.PasswordChar = '*';
            this.mpassword.Size = new System.Drawing.Size(188, 37);
            this.mpassword.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(528, 184);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 27);
            this.label13.TabIndex = 45;
            this.label13.Text = "Password";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(528, 131);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 33);
            this.label14.TabIndex = 44;
            this.label14.Text = "Login";
            // 
            // mSSI
            // 
            this.mSSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mSSI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mSSI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mSSI.Location = new System.Drawing.Point(22, 150);
            this.mSSI.Margin = new System.Windows.Forms.Padding(6);
            this.mSSI.Name = "mSSI";
            this.mSSI.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mSSI.Size = new System.Drawing.Size(400, 61);
            this.mSSI.TabIndex = 47;
            this.mSSI.Text = "Integrated Security (SSI), Windows Authentication ";
            this.mSSI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mSSI.UseVisualStyleBackColor = false;
            this.mSSI.CheckedChanged += new System.EventHandler(this.mSSI_CheckedChanged);
            // 
            // txtMaster
            // 
            this.txtMaster.BackColor = System.Drawing.Color.White;
            this.txtMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMaster.ForeColor = System.Drawing.Color.White;
            this.txtMaster.Location = new System.Drawing.Point(892, 27);
            this.txtMaster.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaster.Multiline = true;
            this.txtMaster.Name = "txtMaster";
            this.txtMaster.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMaster.Size = new System.Drawing.Size(512, 170);
            this.txtMaster.TabIndex = 2;
            this.txtMaster.Enter += new System.EventHandler(this.txtMaster_Enter);
            this.txtMaster.Leave += new System.EventHandler(this.txtMaster_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(2046, 1220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compare Database Schema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnStartCompare, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.toolLog, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgResult, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.result, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnShowDiff, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnGridToScript, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtexclude, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 498F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2034, 1208);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnStartCompare
            // 
            this.btnStartCompare.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStartCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartCompare.Location = new System.Drawing.Point(306, 6);
            this.btnStartCompare.Margin = new System.Windows.Forms.Padding(6);
            this.btnStartCompare.Name = "btnStartCompare";
            this.btnStartCompare.Size = new System.Drawing.Size(678, 64);
            this.btnStartCompare.TabIndex = 96;
            this.btnStartCompare.Text = "Start Compare!";
            this.btnStartCompare.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 885);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Script: copy and paste to your favourite SQL editor";
            // 
            // toolLog
            // 
            this.toolLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolLog.Location = new System.Drawing.Point(306, 83);
            this.toolLog.Margin = new System.Windows.Forms.Padding(6);
            this.toolLog.Name = "toolLog";
            this.toolLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.toolLog.Size = new System.Drawing.Size(1722, 37);
            this.toolLog.TabIndex = 95;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 77);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 25);
            this.label18.TabIndex = 99;
            this.label18.Text = "Log";
            // 
            // dgResult
            // 
            this.dgResult.AllowUserToAddRows = false;
            this.dgResult.AllowUserToDeleteRows = false;
            this.dgResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.Type,
            this.Object,
            this.Details,
            this.Action,
            this.ScriptModel,
            this.ScriptTarget});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgResult.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResult.Location = new System.Drawing.Point(306, 239);
            this.dgResult.Margin = new System.Windows.Forms.Padding(6);
            this.dgResult.Name = "dgResult";
            this.dgResult.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResult.ShowEditingIcon = false;
            this.dgResult.Size = new System.Drawing.Size(1722, 486);
            this.dgResult.TabIndex = 98;
            // 
            // Source
            // 
            this.Source.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Source.DefaultCellStyle = dataGridViewCellStyle19;
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            this.Source.Width = 106;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Type.DefaultCellStyle = dataGridViewCellStyle20;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 84;
            // 
            // Object
            // 
            this.Object.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Object.DefaultCellStyle = dataGridViewCellStyle21;
            this.Object.HeaderText = "Object";
            this.Object.Name = "Object";
            this.Object.ReadOnly = true;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 104;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Action.DefaultCellStyle = dataGridViewCellStyle22;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 98;
            // 
            // ScriptModel
            // 
            this.ScriptModel.HeaderText = "ScriptModel";
            this.ScriptModel.MaxInputLength = 9000000;
            this.ScriptModel.Name = "ScriptModel";
            this.ScriptModel.ReadOnly = true;
            this.ScriptModel.Visible = false;
            this.ScriptModel.Width = 88;
            // 
            // ScriptTarget
            // 
            this.ScriptTarget.HeaderText = "ScriptTarget";
            this.ScriptTarget.MaxInputLength = 9000000;
            this.ScriptTarget.Name = "ScriptTarget";
            this.ScriptTarget.ReadOnly = true;
            this.ScriptTarget.Visible = false;
            this.ScriptTarget.Width = 90;
            // 
            // result
            // 
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result.Location = new System.Drawing.Point(306, 891);
            this.result.Margin = new System.Windows.Forms.Padding(6);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(1722, 311);
            this.result.TabIndex = 100;
            this.result.Text = "";
            // 
            // btnShowDiff
            // 
            this.btnShowDiff.Location = new System.Drawing.Point(306, 814);
            this.btnShowDiff.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowDiff.Name = "btnShowDiff";
            this.btnShowDiff.Size = new System.Drawing.Size(678, 64);
            this.btnShowDiff.TabIndex = 94;
            this.btnShowDiff.Text = "Show changes in external tool";
            this.btnShowDiff.UseVisualStyleBackColor = true;
            // 
            // btnGridToScript
            // 
            this.btnGridToScript.Location = new System.Drawing.Point(306, 737);
            this.btnGridToScript.Margin = new System.Windows.Forms.Padding(6);
            this.btnGridToScript.Name = "btnGridToScript";
            this.btnGridToScript.Size = new System.Drawing.Size(678, 64);
            this.btnGridToScript.TabIndex = 91;
            this.btnGridToScript.Text = "Generate Script for selected rows";
            this.btnGridToScript.UseVisualStyleBackColor = true;
            this.btnGridToScript.Click += new System.EventHandler(this.btnGridToScript_Click);
            // 
            // txtexclude
            // 
            this.txtexclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtexclude.Location = new System.Drawing.Point(306, 155);
            this.txtexclude.Margin = new System.Windows.Forms.Padding(6);
            this.txtexclude.Multiline = true;
            this.txtexclude.Name = "txtexclude";
            this.txtexclude.Size = new System.Drawing.Size(1722, 72);
            this.txtexclude.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 103;
            this.label1.Text = "Exclude objects (CSV)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 233);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 25);
            this.label19.TabIndex = 104;
            this.label19.Text = "Result";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLoad,
            this.toolSave,
            this.toolAbout,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1656, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolLoad
            // 
            this.toolLoad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolLoad.Image")));
            this.toolLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLoad.Name = "toolLoad";
            this.toolLoad.Size = new System.Drawing.Size(361, 47);
            this.toolLoad.Text = "Load Configuration";
            this.toolLoad.Click += new System.EventHandler(this.toolLoad_Click);
            // 
            // toolSave
            // 
            this.toolSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(362, 47);
            this.toolSave.Text = "Save Configuration";
            // 
            // toolAbout
            // 
            this.toolAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAbout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolAbout.Image")));
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(122, 47);
            this.toolAbout.Text = "About";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 61);
            this.panel1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1656, 1078);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupModel.ResumeLayout(false);
            this.GroupModel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMaster;
        private System.Windows.Forms.TextBox txtSlave;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox slogin;
        internal System.Windows.Forms.TextBox sdatabase;
        internal System.Windows.Forms.TextBox sserver;
        internal System.Windows.Forms.CheckBox sssi;
        internal System.Windows.Forms.TextBox spassword;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label RefreshSlave;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.GroupBox GroupModel;
        internal System.Windows.Forms.TextBox mlogin;
        internal System.Windows.Forms.TextBox mpassword;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.CheckBox mSSI;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button butSwitch;
        private System.Windows.Forms.Label lblfile;
        internal System.Windows.Forms.TextBox mdatabase;
        internal System.Windows.Forms.TextBox mserver;
        private System.Windows.Forms.ToolStripButton toolLoad;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox toolLog;
        private System.Windows.Forms.Button btnShowDiff;
        private System.Windows.Forms.Button btnGridToScript;
        private System.Windows.Forms.Button btnStartCompare;
        internal System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Object;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScriptModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScriptTarget;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.TextBox txtarguments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtExternalTool;
        private System.Windows.Forms.TextBox txtexclude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;

    }
}

