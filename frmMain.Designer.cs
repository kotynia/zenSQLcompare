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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.butLoadModelSchema = new System.Windows.Forms.Button();
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
            this.tab.Location = new System.Drawing.Point(0, 39);
            this.tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1104, 637);
            this.tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1096, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings & Connections properties";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.butLoadModelSchema);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.GroupBox4);
            this.panel4.Controls.Add(this.butSwitch);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.GroupModel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1088, 640);
            this.panel4.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtarguments);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.txtExternalTool);
            this.groupBox2.Location = new System.Drawing.Point(7, 359);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(957, 155);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External command Line Tool";
            // 
            // txtarguments
            // 
            this.txtarguments.Location = new System.Drawing.Point(15, 63);
            this.txtarguments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtarguments.Name = "txtarguments";
            this.txtarguments.Size = new System.Drawing.Size(825, 22);
            this.txtarguments.TabIndex = 94;
            this.txtarguments.Text = "\"%Model\" \"%Target\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 93;
            this.label2.Text = "% Model , % Target ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 121);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 17);
            this.linkLabel1.TabIndex = 90;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://winmerge.org/";
            // 
            // txtExternalTool
            // 
            this.txtExternalTool.Location = new System.Drawing.Point(15, 31);
            this.txtExternalTool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExternalTool.Name = "txtExternalTool";
            this.txtExternalTool.Size = new System.Drawing.Size(828, 22);
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
            this.GroupBox4.Location = new System.Drawing.Point(7, 196);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox4.Size = new System.Drawing.Size(957, 156);
            this.GroupBox4.TabIndex = 84;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Target Database";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(768, 137);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 15);
            this.label16.TabIndex = 81;
            this.label16.Text = "connectionString on focus";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(352, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(352, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 66;
            this.label7.Text = "Login";
            // 
            // slogin
            // 
            this.slogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.slogin.Location = new System.Drawing.Point(444, 86);
            this.slogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slogin.Name = "slogin";
            this.slogin.Size = new System.Drawing.Size(127, 26);
            this.slogin.TabIndex = 59;
            // 
            // sdatabase
            // 
            this.sdatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sdatabase.Location = new System.Drawing.Point(149, 49);
            this.sdatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdatabase.Name = "sdatabase";
            this.sdatabase.Size = new System.Drawing.Size(421, 26);
            this.sdatabase.TabIndex = 58;
            // 
            // sserver
            // 
            this.sserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sserver.Location = new System.Drawing.Point(149, 20);
            this.sserver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sserver.Name = "sserver";
            this.sserver.Size = new System.Drawing.Size(421, 26);
            this.sserver.TabIndex = 57;
            // 
            // txtSlave
            // 
            this.txtSlave.BackColor = System.Drawing.Color.White;
            this.txtSlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSlave.ForeColor = System.Drawing.Color.White;
            this.txtSlave.Location = new System.Drawing.Point(595, 21);
            this.txtSlave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSlave.Multiline = true;
            this.txtSlave.Name = "txtSlave";
            this.txtSlave.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSlave.Size = new System.Drawing.Size(343, 111);
            this.txtSlave.TabIndex = 3;
            this.txtSlave.Enter += new System.EventHandler(this.txtSlave_Enter);
            this.txtSlave.Leave += new System.EventHandler(this.txtSlave_Leave);
            // 
            // sssi
            // 
            this.sssi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sssi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sssi.Location = new System.Drawing.Point(15, 103);
            this.sssi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sssi.Name = "sssi";
            this.sssi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sssi.Size = new System.Drawing.Size(263, 39);
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
            this.spassword.Location = new System.Drawing.Point(444, 116);
            this.spassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spassword.Name = "spassword";
            this.spassword.PasswordChar = '*';
            this.spassword.Size = new System.Drawing.Size(127, 26);
            this.spassword.TabIndex = 64;
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label9.Location = new System.Drawing.Point(11, 49);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(235, 28);
            this.Label9.TabIndex = 61;
            this.Label9.Text = "Database...........................";
            // 
            // Label10
            // 
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label10.Location = new System.Drawing.Point(11, 20);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(213, 28);
            this.Label10.TabIndex = 60;
            this.Label10.Text = "Server...............................";
            // 
            // RefreshSlave
            // 
            this.RefreshSlave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RefreshSlave.Location = new System.Drawing.Point(107, 217);
            this.RefreshSlave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RefreshSlave.Name = "RefreshSlave";
            this.RefreshSlave.Size = new System.Drawing.Size(171, 39);
            this.RefreshSlave.TabIndex = 4;
            // 
            // butSwitch
            // 
            this.butSwitch.Location = new System.Drawing.Point(805, 165);
            this.butSwitch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butSwitch.Name = "butSwitch";
            this.butSwitch.Size = new System.Drawing.Size(157, 28);
            this.butSwitch.TabIndex = 85;
            this.butSwitch.Text = "Model <> Target";
            this.butSwitch.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(17, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 28);
            this.label11.TabIndex = 79;
            this.label11.Text = "Database...........................";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(17, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 28);
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
            this.GroupModel.Location = new System.Drawing.Point(7, 11);
            this.GroupModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupModel.Name = "GroupModel";
            this.GroupModel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupModel.Size = new System.Drawing.Size(957, 151);
            this.GroupModel.TabIndex = 81;
            this.GroupModel.TabStop = false;
            this.GroupModel.Text = "Model Database";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(768, 132);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 15);
            this.label15.TabIndex = 80;
            this.label15.Text = "connectionString on focus";
            // 
            // mdatabase
            // 
            this.mdatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mdatabase.Location = new System.Drawing.Point(149, 47);
            this.mdatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mdatabase.Name = "mdatabase";
            this.mdatabase.Size = new System.Drawing.Size(421, 26);
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
            this.mserver.Location = new System.Drawing.Point(149, 17);
            this.mserver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mserver.Name = "mserver";
            this.mserver.Size = new System.Drawing.Size(421, 26);
            this.mserver.TabIndex = 78;
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(23, 144);
            this.lblfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(0, 20);
            this.lblfile.TabIndex = 52;
            // 
            // mlogin
            // 
            this.mlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mlogin.Location = new System.Drawing.Point(444, 80);
            this.mlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mlogin.Name = "mlogin";
            this.mlogin.Size = new System.Drawing.Size(127, 26);
            this.mlogin.TabIndex = 41;
            // 
            // mpassword
            // 
            this.mpassword.AccessibleName = "main";
            this.mpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mpassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mpassword.Location = new System.Drawing.Point(444, 111);
            this.mpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mpassword.Name = "mpassword";
            this.mpassword.PasswordChar = '*';
            this.mpassword.Size = new System.Drawing.Size(127, 26);
            this.mpassword.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(352, 118);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Password";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(352, 84);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 21);
            this.label14.TabIndex = 44;
            this.label14.Text = "Login";
            // 
            // mSSI
            // 
            this.mSSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mSSI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mSSI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mSSI.Location = new System.Drawing.Point(15, 96);
            this.mSSI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mSSI.Name = "mSSI";
            this.mSSI.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mSSI.Size = new System.Drawing.Size(267, 39);
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
            this.txtMaster.Location = new System.Drawing.Point(595, 17);
            this.txtMaster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaster.Multiline = true;
            this.txtMaster.Name = "txtMaster";
            this.txtMaster.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMaster.Size = new System.Drawing.Size(343, 110);
            this.txtMaster.TabIndex = 2;
            this.txtMaster.Enter += new System.EventHandler(this.txtMaster_Enter);
            this.txtMaster.Leave += new System.EventHandler(this.txtMaster_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1096, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compare Database Schema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 319F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 600);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnStartCompare
            // 
            this.btnStartCompare.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStartCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartCompare.Location = new System.Drawing.Point(204, 4);
            this.btnStartCompare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartCompare.Name = "btnStartCompare";
            this.btnStartCompare.Size = new System.Drawing.Size(452, 41);
            this.btnStartCompare.TabIndex = 96;
            this.btnStartCompare.Text = "Start Compare!";
            this.btnStartCompare.UseVisualStyleBackColor = false;
            this.btnStartCompare.Click += new System.EventHandler(this.btnStartCompare_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 566);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Script: copy and paste to your favourite SQL editor";
            // 
            // toolLog
            // 
            this.toolLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolLog.Location = new System.Drawing.Point(204, 53);
            this.toolLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolLog.Name = "toolLog";
            this.toolLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.toolLog.Size = new System.Drawing.Size(1149, 26);
            this.toolLog.TabIndex = 95;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 49);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 99;
            this.label18.Text = "Log";
            // 
            // dgResult
            // 
            this.dgResult.AllowUserToAddRows = false;
            this.dgResult.AllowUserToDeleteRows = false;
            this.dgResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.Type,
            this.Object,
            this.Details,
            this.Action,
            this.ScriptModel,
            this.ScriptTarget});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgResult.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResult.Location = new System.Drawing.Point(204, 153);
            this.dgResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgResult.Name = "dgResult";
            this.dgResult.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResult.ShowEditingIcon = false;
            this.dgResult.Size = new System.Drawing.Size(1149, 311);
            this.dgResult.TabIndex = 98;
            // 
            // Source
            // 
            this.Source.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Source.DefaultCellStyle = dataGridViewCellStyle27;
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            this.Source.Width = 82;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Type.DefaultCellStyle = dataGridViewCellStyle28;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 69;
            // 
            // Object
            // 
            this.Object.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Object.DefaultCellStyle = dataGridViewCellStyle29;
            this.Object.HeaderText = "Object";
            this.Object.Name = "Object";
            this.Object.ReadOnly = true;
            this.Object.Width = 78;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 80;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Action.DefaultCellStyle = dataGridViewCellStyle30;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 76;
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
            this.result.Location = new System.Drawing.Point(204, 570);
            this.result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(1149, 200);
            this.result.TabIndex = 100;
            this.result.Text = "";
            // 
            // btnShowDiff
            // 
            this.btnShowDiff.Location = new System.Drawing.Point(204, 521);
            this.btnShowDiff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowDiff.Name = "btnShowDiff";
            this.btnShowDiff.Size = new System.Drawing.Size(452, 41);
            this.btnShowDiff.TabIndex = 94;
            this.btnShowDiff.Text = "Show changes in external tool";
            this.btnShowDiff.UseVisualStyleBackColor = true;
            // 
            // btnGridToScript
            // 
            this.btnGridToScript.Location = new System.Drawing.Point(204, 472);
            this.btnGridToScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGridToScript.Name = "btnGridToScript";
            this.btnGridToScript.Size = new System.Drawing.Size(452, 41);
            this.btnGridToScript.TabIndex = 91;
            this.btnGridToScript.Text = "Generate Script for selected rows";
            this.btnGridToScript.UseVisualStyleBackColor = true;
            this.btnGridToScript.Click += new System.EventHandler(this.btnGridToScript_Click);
            // 
            // txtexclude
            // 
            this.txtexclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtexclude.Location = new System.Drawing.Point(204, 99);
            this.txtexclude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtexclude.Multiline = true;
            this.txtexclude.Name = "txtexclude";
            this.txtexclude.Size = new System.Drawing.Size(1149, 46);
            this.txtexclude.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 103;
            this.label1.Text = "Exclude objects (CSV)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 149);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 17);
            this.label19.TabIndex = 104;
            this.label19.Text = "Result";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLoad,
            this.toolSave,
            this.toolAbout,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1104, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolLoad
            // 
            this.toolLoad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolLoad.Image")));
            this.toolLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLoad.Name = "toolLoad";
            this.toolLoad.Size = new System.Drawing.Size(240, 31);
            this.toolLoad.Text = "Load Configuration";
            this.toolLoad.Click += new System.EventHandler(this.toolLoad_Click);
            // 
            // toolSave
            // 
            this.toolSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(240, 31);
            this.toolSave.Text = "Save Configuration";
            // 
            // toolAbout
            // 
            this.toolAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAbout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolAbout.Image")));
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(79, 31);
            this.toolAbout.Text = "About";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 39);
            this.panel1.TabIndex = 0;
            // 
            // butLoadModelSchema
            // 
            this.butLoadModelSchema.Location = new System.Drawing.Point(640, 165);
            this.butLoadModelSchema.Margin = new System.Windows.Forms.Padding(4);
            this.butLoadModelSchema.Name = "butLoadModelSchema";
            this.butLoadModelSchema.Size = new System.Drawing.Size(157, 28);
            this.butLoadModelSchema.TabIndex = 91;
            this.butLoadModelSchema.Text = "Load model schema";
            this.butLoadModelSchema.UseVisualStyleBackColor = true;
            this.butLoadModelSchema.Click += new System.EventHandler(this.butLoadModelSchema_Click);
            this.butLoadModelSchema.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butLoadModelSchema_MouseClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1104, 676);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button butLoadModelSchema;
    }
}

