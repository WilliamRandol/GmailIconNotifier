namespace Gmail_Icon_Notifier
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
//        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.apply_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.ok_Button = new System.Windows.Forms.Button();
            this.accountSettings_TabControl = new System.Windows.Forms.TabControl();
            this.accountInfo_TabPage = new System.Windows.Forms.TabPage();
            this.addNewAccount_Button = new System.Windows.Forms.Button();
            this.account_ComboBox = new System.Windows.Forms.ComboBox();
            this.settings_DataSet = new System.Data.DataSet();
            this.accounts_Table = new System.Data.DataTable();
            this.accountsID_Column = new System.Data.DataColumn();
            this.accountsEmail_Column = new System.Data.DataColumn();
            this.accountsPassword_Column = new System.Data.DataColumn();
            this.accountsDefault_Column = new System.Data.DataColumn();
            this.accountsName_Column = new System.Data.DataColumn();
            this.accountsCheckFreq_Column = new System.Data.DataColumn();
            this.accountsFadeIn_Column = new System.Data.DataColumn();
            this.accountsFadeOut_Column = new System.Data.DataColumn();
            this.accountsGrowIn_Column = new System.Data.DataColumn();
            this.accounts_GrowOut_Column = new System.Data.DataColumn();
            this.accountGrowOut_Column = new System.Data.DataColumn();
            this.accountsTop_Column = new System.Data.DataColumn();
            this.accountsLeft_Column = new System.Data.DataColumn();
            this.accountsLocation_Column = new System.Data.DataColumn();
            this.accountsLocCheck_Column = new System.Data.DataColumn();
            this.deleteAccount_Button = new System.Windows.Forms.Button();
            this.account_Label = new System.Windows.Forms.Label();
            this.useAsDefault_CheckBox = new System.Windows.Forms.CheckBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.password_Label = new System.Windows.Forms.Label();
            this.emailAddress_TextBox = new System.Windows.Forms.TextBox();
            this.emailAccount_Label = new System.Windows.Forms.Label();
            this.settings_TabPage = new System.Windows.Forms.TabPage();
            this.animationEffects_GroupBox = new System.Windows.Forms.GroupBox();
            this.growFrom_Label = new System.Windows.Forms.Label();
            this.growFrom_ComboBox = new System.Windows.Forms.ComboBox();
            this.growOut_CheckBox = new System.Windows.Forms.CheckBox();
            this.growIn_CheckBox = new System.Windows.Forms.CheckBox();
            this.fadeOut_CheckBox = new System.Windows.Forms.CheckBox();
            this.fadeIn_CheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeBetween_TrackBar = new System.Windows.Forms.TrackBar();
            this.location_GroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.manual_CheckBox = new System.Windows.Forms.CheckBox();
            this.defaults_Button = new System.Windows.Forms.Button();
            this.timeBetween_Label = new System.Windows.Forms.Label();
            this.useLoginPage_CheckBox = new System.Windows.Forms.CheckBox();
            this.useIf_Label = new System.Windows.Forms.Label();
            this.usePrevVer_CheckBox = new System.Windows.Forms.CheckBox();
            this.startWithWindows_CheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.accountSettings_TabControl.SuspendLayout();
            this.accountInfo_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_Table)).BeginInit();
            this.settings_TabPage.SuspendLayout();
            this.animationEffects_GroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeBetween_TrackBar)).BeginInit();
            this.location_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // apply_Button
            // 
            this.apply_Button.Enabled = false;
            this.apply_Button.Location = new System.Drawing.Point(416, 334);
            this.apply_Button.Name = "apply_Button";
            this.apply_Button.Size = new System.Drawing.Size(75, 23);
            this.apply_Button.TabIndex = 8;
            this.apply_Button.Text = "Apply";
            this.apply_Button.UseVisualStyleBackColor = true;
            this.apply_Button.Click += new System.EventHandler(this.apply_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Button.Location = new System.Drawing.Point(335, 334);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.cancel_Button.TabIndex = 7;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // ok_Button
            // 
            this.ok_Button.Location = new System.Drawing.Point(254, 334);
            this.ok_Button.Name = "ok_Button";
            this.ok_Button.Size = new System.Drawing.Size(75, 23);
            this.ok_Button.TabIndex = 6;
            this.ok_Button.Text = "OK";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(this.ok_Button_Click);
            // 
            // accountSettings_TabControl
            // 
            this.accountSettings_TabControl.Controls.Add(this.accountInfo_TabPage);
            this.accountSettings_TabControl.Controls.Add(this.settings_TabPage);
            this.accountSettings_TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountSettings_TabControl.Location = new System.Drawing.Point(0, 0);
            this.accountSettings_TabControl.Name = "accountSettings_TabControl";
            this.accountSettings_TabControl.SelectedIndex = 0;
            this.accountSettings_TabControl.Size = new System.Drawing.Size(497, 252);
            this.accountSettings_TabControl.TabIndex = 3;
            this.accountSettings_TabControl.Click += new System.EventHandler(this.accountSettings_TabControl_Click);
            // 
            // accountInfo_TabPage
            // 
            this.accountInfo_TabPage.Controls.Add(this.addNewAccount_Button);
            this.accountInfo_TabPage.Controls.Add(this.account_ComboBox);
            this.accountInfo_TabPage.Controls.Add(this.deleteAccount_Button);
            this.accountInfo_TabPage.Controls.Add(this.account_Label);
            this.accountInfo_TabPage.Controls.Add(this.useAsDefault_CheckBox);
            this.accountInfo_TabPage.Controls.Add(this.password_TextBox);
            this.accountInfo_TabPage.Controls.Add(this.password_Label);
            this.accountInfo_TabPage.Controls.Add(this.emailAddress_TextBox);
            this.accountInfo_TabPage.Controls.Add(this.emailAccount_Label);
            this.accountInfo_TabPage.Location = new System.Drawing.Point(4, 22);
            this.accountInfo_TabPage.Name = "accountInfo_TabPage";
            this.accountInfo_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountInfo_TabPage.Size = new System.Drawing.Size(489, 226);
            this.accountInfo_TabPage.TabIndex = 0;
            this.accountInfo_TabPage.Text = "Account Information";
            this.accountInfo_TabPage.UseVisualStyleBackColor = true;
            // 
            // addNewAccount_Button
            // 
            this.addNewAccount_Button.Location = new System.Drawing.Point(167, 35);
            this.addNewAccount_Button.Name = "addNewAccount_Button";
            this.addNewAccount_Button.Size = new System.Drawing.Size(105, 23);
            this.addNewAccount_Button.TabIndex = 12;
            this.addNewAccount_Button.Text = "Add New Account";
            this.addNewAccount_Button.UseVisualStyleBackColor = true;
            this.addNewAccount_Button.Click += new System.EventHandler(this.addNewAccount_Button_Click);
            // 
            // account_ComboBox
            // 
            this.account_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.account_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.account_ComboBox.DataSource = this.settings_DataSet;
            this.account_ComboBox.DisplayMember = "Accounts.Name";
            this.account_ComboBox.Location = new System.Drawing.Point(11, 37);
            this.account_ComboBox.Name = "account_ComboBox";
            this.account_ComboBox.Size = new System.Drawing.Size(153, 21);
            this.account_ComboBox.TabIndex = 11;
            this.account_ComboBox.SelectedIndexChanged += new System.EventHandler(this.account_ComboBox_SelectedIndexChanged);
            // 
            // settings_DataSet
            // 
            this.settings_DataSet.DataSetName = "NewDataSet";
            this.settings_DataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.accounts_Table});
            // 
            // accounts_Table
            // 
            this.accounts_Table.Columns.AddRange(new System.Data.DataColumn[] {
            this.accountsID_Column,
            this.accountsEmail_Column,
            this.accountsPassword_Column,
            this.accountsDefault_Column,
            this.accountsName_Column,
            this.accountsCheckFreq_Column,
            this.accountsFadeIn_Column,
            this.accountsFadeOut_Column,
            this.accountsGrowIn_Column,
            this.accounts_GrowOut_Column,
            this.accountGrowOut_Column,
            this.accountsTop_Column,
            this.accountsLeft_Column,
            this.accountsLocation_Column,
            this.accountsLocCheck_Column});
            this.accounts_Table.TableName = "Accounts";
            // 
            // accountsID_Column
            // 
            this.accountsID_Column.AutoIncrement = true;
            this.accountsID_Column.ColumnName = "ID";
            this.accountsID_Column.DataType = typeof(int);
            // 
            // accountsEmail_Column
            // 
            this.accountsEmail_Column.ColumnName = "Email";
            // 
            // accountsPassword_Column
            // 
            this.accountsPassword_Column.ColumnName = "Password";
            // 
            // accountsDefault_Column
            // 
            this.accountsDefault_Column.ColumnName = "Default";
            this.accountsDefault_Column.DefaultValue = "Unchecked";
            // 
            // accountsName_Column
            // 
            this.accountsName_Column.ColumnName = "Name";
            // 
            // accountsCheckFreq_Column
            // 
            this.accountsCheckFreq_Column.AllowDBNull = false;
            this.accountsCheckFreq_Column.ColumnName = "CheckFreq";
            this.accountsCheckFreq_Column.DataType = typeof(int);
            this.accountsCheckFreq_Column.DefaultValue = 300000;
            // 
            // accountsFadeIn_Column
            // 
            this.accountsFadeIn_Column.ColumnName = "FadeIn";
            this.accountsFadeIn_Column.DataType = typeof(bool);
            // 
            // accountsFadeOut_Column
            // 
            this.accountsFadeOut_Column.ColumnName = "FadeOut";
            this.accountsFadeOut_Column.DataType = typeof(bool);
            // 
            // accountsGrowIn_Column
            // 
            this.accountsGrowIn_Column.ColumnName = "GrowIn";
            this.accountsGrowIn_Column.DataType = typeof(bool);
            // 
            // accounts_GrowOut_Column
            // 
            this.accounts_GrowOut_Column.ColumnName = "GrowOut";
            this.accounts_GrowOut_Column.DataType = typeof(bool);
            // 
            // accountGrowOut_Column
            // 
            this.accountGrowOut_Column.ColumnName = "GrowFrom";
            // 
            // accountsTop_Column
            // 
            this.accountsTop_Column.ColumnName = "Top";
            this.accountsTop_Column.DataType = typeof(int);
            // 
            // accountsLeft_Column
            // 
            this.accountsLeft_Column.ColumnName = "Left";
            this.accountsLeft_Column.DataType = typeof(int);
            // 
            // accountsLocation_Column
            // 
            this.accountsLocation_Column.Caption = "Location";
            this.accountsLocation_Column.ColumnName = "Location";
            // 
            // accountsLocCheck_Column
            // 
            this.accountsLocCheck_Column.ColumnName = "LocCheck";
            // 
            // deleteAccount_Button
            // 
            this.deleteAccount_Button.Location = new System.Drawing.Point(167, 64);
            this.deleteAccount_Button.Name = "deleteAccount_Button";
            this.deleteAccount_Button.Size = new System.Drawing.Size(105, 23);
            this.deleteAccount_Button.TabIndex = 6;
            this.deleteAccount_Button.Tag = "0";
            this.deleteAccount_Button.Text = "Delete Account";
            this.deleteAccount_Button.UseVisualStyleBackColor = true;
            this.deleteAccount_Button.Click += new System.EventHandler(this.deleteAccount_Button_Click);
            // 
            // account_Label
            // 
            this.account_Label.AutoSize = true;
            this.account_Label.BackColor = System.Drawing.Color.Transparent;
            this.account_Label.Location = new System.Drawing.Point(8, 19);
            this.account_Label.Name = "account_Label";
            this.account_Label.Size = new System.Drawing.Size(47, 13);
            this.account_Label.TabIndex = 10;
            this.account_Label.Text = "Account";
            // 
            // useAsDefault_CheckBox
            // 
            this.useAsDefault_CheckBox.AutoSize = true;
            this.useAsDefault_CheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.useAsDefault_CheckBox.Location = new System.Drawing.Point(11, 72);
            this.useAsDefault_CheckBox.Name = "useAsDefault_CheckBox";
            this.useAsDefault_CheckBox.Size = new System.Drawing.Size(139, 17);
            this.useAsDefault_CheckBox.TabIndex = 5;
            this.useAsDefault_CheckBox.Tag = "0";
            this.useAsDefault_CheckBox.Text = "Use as Default Account";
            this.useAsDefault_CheckBox.UseVisualStyleBackColor = true;
            this.useAsDefault_CheckBox.Click += new System.EventHandler(this.useAsDefault_CheckBox_Click);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_TextBox.Location = new System.Drawing.Point(11, 186);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(261, 20);
            this.password_TextBox.TabIndex = 4;
            this.password_TextBox.UseSystemPasswordChar = true;
            this.password_TextBox.TextChanged += new System.EventHandler(this.password_TextBox_TextChanged);
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Location = new System.Drawing.Point(8, 170);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(53, 13);
            this.password_Label.TabIndex = 4;
            this.password_Label.Text = "Password";
            // 
            // emailAddress_TextBox
            // 
            this.emailAddress_TextBox.Location = new System.Drawing.Point(11, 143);
            this.emailAddress_TextBox.Name = "emailAddress_TextBox";
            this.emailAddress_TextBox.Size = new System.Drawing.Size(261, 20);
            this.emailAddress_TextBox.TabIndex = 3;
            this.emailAddress_TextBox.TextChanged += new System.EventHandler(this.email_TextBox_TextChanged);
            // 
            // emailAccount_Label
            // 
            this.emailAccount_Label.AutoSize = true;
            this.emailAccount_Label.Location = new System.Drawing.Point(8, 128);
            this.emailAccount_Label.Name = "emailAccount_Label";
            this.emailAccount_Label.Size = new System.Drawing.Size(73, 13);
            this.emailAccount_Label.TabIndex = 2;
            this.emailAccount_Label.Text = "Email Address";
            // 
            // settings_TabPage
            // 
            this.settings_TabPage.Controls.Add(this.animationEffects_GroupBox);
            this.settings_TabPage.Controls.Add(this.panel1);
            this.settings_TabPage.Controls.Add(this.location_GroupBox);
            this.settings_TabPage.Controls.Add(this.defaults_Button);
            this.settings_TabPage.Controls.Add(this.timeBetween_Label);
            this.settings_TabPage.Location = new System.Drawing.Point(4, 22);
            this.settings_TabPage.Name = "settings_TabPage";
            this.settings_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settings_TabPage.Size = new System.Drawing.Size(489, 226);
            this.settings_TabPage.TabIndex = 1;
            this.settings_TabPage.Text = "Settings";
            this.settings_TabPage.UseVisualStyleBackColor = true;
            // 
            // animationEffects_GroupBox
            // 
            this.animationEffects_GroupBox.Controls.Add(this.growFrom_Label);
            this.animationEffects_GroupBox.Controls.Add(this.growFrom_ComboBox);
            this.animationEffects_GroupBox.Controls.Add(this.growOut_CheckBox);
            this.animationEffects_GroupBox.Controls.Add(this.growIn_CheckBox);
            this.animationEffects_GroupBox.Controls.Add(this.fadeOut_CheckBox);
            this.animationEffects_GroupBox.Controls.Add(this.fadeIn_CheckBox);
            this.animationEffects_GroupBox.Location = new System.Drawing.Point(8, 6);
            this.animationEffects_GroupBox.Name = "animationEffects_GroupBox";
            this.animationEffects_GroupBox.Size = new System.Drawing.Size(289, 109);
            this.animationEffects_GroupBox.TabIndex = 15;
            this.animationEffects_GroupBox.TabStop = false;
            this.animationEffects_GroupBox.Text = "Animation Effects";
            this.animationEffects_GroupBox.Visible = false;
            // 
            // growFrom_Label
            // 
            this.growFrom_Label.AutoSize = true;
            this.growFrom_Label.Enabled = false;
            this.growFrom_Label.Location = new System.Drawing.Point(100, 65);
            this.growFrom_Label.Name = "growFrom_Label";
            this.growFrom_Label.Size = new System.Drawing.Size(58, 13);
            this.growFrom_Label.TabIndex = 11;
            this.growFrom_Label.Text = "Grow From";
            // 
            // growFrom_ComboBox
            // 
            this.growFrom_ComboBox.Enabled = false;
            this.growFrom_ComboBox.FormattingEnabled = true;
            this.growFrom_ComboBox.Items.AddRange(new object[] {
            "Bottom",
            "Top",
            "Left",
            "Right"});
            this.growFrom_ComboBox.Location = new System.Drawing.Point(103, 80);
            this.growFrom_ComboBox.Name = "growFrom_ComboBox";
            this.growFrom_ComboBox.Size = new System.Drawing.Size(180, 21);
            this.growFrom_ComboBox.TabIndex = 10;
            // 
            // growOut_CheckBox
            // 
            this.growOut_CheckBox.AutoSize = true;
            this.growOut_CheckBox.Enabled = false;
            this.growOut_CheckBox.Location = new System.Drawing.Point(6, 87);
            this.growOut_CheckBox.Name = "growOut_CheckBox";
            this.growOut_CheckBox.Size = new System.Drawing.Size(71, 17);
            this.growOut_CheckBox.TabIndex = 9;
            this.growOut_CheckBox.Text = "Grow Out";
            this.growOut_CheckBox.UseVisualStyleBackColor = true;
            // 
            // growIn_CheckBox
            // 
            this.growIn_CheckBox.AutoSize = true;
            this.growIn_CheckBox.Enabled = false;
            this.growIn_CheckBox.Location = new System.Drawing.Point(6, 64);
            this.growIn_CheckBox.Name = "growIn_CheckBox";
            this.growIn_CheckBox.Size = new System.Drawing.Size(63, 17);
            this.growIn_CheckBox.TabIndex = 8;
            this.growIn_CheckBox.Text = "Grow In";
            this.growIn_CheckBox.UseVisualStyleBackColor = true;
            // 
            // fadeOut_CheckBox
            // 
            this.fadeOut_CheckBox.AutoSize = true;
            this.fadeOut_CheckBox.Enabled = false;
            this.fadeOut_CheckBox.Location = new System.Drawing.Point(6, 41);
            this.fadeOut_CheckBox.Name = "fadeOut_CheckBox";
            this.fadeOut_CheckBox.Size = new System.Drawing.Size(70, 17);
            this.fadeOut_CheckBox.TabIndex = 7;
            this.fadeOut_CheckBox.Text = "Fade Out";
            this.fadeOut_CheckBox.UseVisualStyleBackColor = true;
            // 
            // fadeIn_CheckBox
            // 
            this.fadeIn_CheckBox.AutoSize = true;
            this.fadeIn_CheckBox.Enabled = false;
            this.fadeIn_CheckBox.Location = new System.Drawing.Point(6, 20);
            this.fadeIn_CheckBox.Name = "fadeIn_CheckBox";
            this.fadeIn_CheckBox.Size = new System.Drawing.Size(62, 17);
            this.fadeIn_CheckBox.TabIndex = 6;
            this.fadeIn_CheckBox.Text = "Fade In";
            this.fadeIn_CheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.timeBetween_TrackBar);
            this.panel1.Location = new System.Drawing.Point(8, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 44);
            this.panel1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(225, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "30";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(449, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "60";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(1, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Off";
            // 
            // timeBetween_TrackBar
            // 
            this.timeBetween_TrackBar.BackColor = System.Drawing.SystemColors.Window;
            this.timeBetween_TrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeBetween_TrackBar.LargeChange = 10;
            this.timeBetween_TrackBar.Location = new System.Drawing.Point(0, 0);
            this.timeBetween_TrackBar.Maximum = 60;
            this.timeBetween_TrackBar.Name = "timeBetween_TrackBar";
            this.timeBetween_TrackBar.Size = new System.Drawing.Size(471, 45);
            this.timeBetween_TrackBar.TabIndex = 6;
            this.timeBetween_TrackBar.TickFrequency = 2;
            this.timeBetween_TrackBar.Value = 5;
            this.timeBetween_TrackBar.Scroll += new System.EventHandler(this.timeBetween_TrackBar_Scroll);
            // 
            // location_GroupBox
            // 
            this.location_GroupBox.Controls.Add(this.label10);
            this.location_GroupBox.Controls.Add(this.comboBox3);
            this.location_GroupBox.Controls.Add(this.manual_CheckBox);
            this.location_GroupBox.Enabled = false;
            this.location_GroupBox.Location = new System.Drawing.Point(303, 6);
            this.location_GroupBox.Name = "location_GroupBox";
            this.location_GroupBox.Size = new System.Drawing.Size(178, 109);
            this.location_GroupBox.TabIndex = 13;
            this.location_GroupBox.TabStop = false;
            this.location_GroupBox.Text = "Location";
            this.location_GroupBox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Default Locations";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Bottom Right",
            "Top Right",
            "Bottom Left",
            "Top Left"});
            this.comboBox3.Location = new System.Drawing.Point(7, 80);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(165, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // manual_CheckBox
            // 
            this.manual_CheckBox.AutoSize = true;
            this.manual_CheckBox.Enabled = false;
            this.manual_CheckBox.Location = new System.Drawing.Point(7, 20);
            this.manual_CheckBox.Name = "manual_CheckBox";
            this.manual_CheckBox.Size = new System.Drawing.Size(61, 17);
            this.manual_CheckBox.TabIndex = 0;
            this.manual_CheckBox.Text = "Manual";
            this.manual_CheckBox.UseVisualStyleBackColor = true;
            // 
            // defaults_Button
            // 
            this.defaults_Button.Enabled = false;
            this.defaults_Button.Location = new System.Drawing.Point(408, 200);
            this.defaults_Button.Name = "defaults_Button";
            this.defaults_Button.Size = new System.Drawing.Size(75, 23);
            this.defaults_Button.TabIndex = 12;
            this.defaults_Button.Text = "Defaults";
            this.defaults_Button.UseVisualStyleBackColor = true;
            // 
            // timeBetween_Label
            // 
            this.timeBetween_Label.AutoSize = true;
            this.timeBetween_Label.Location = new System.Drawing.Point(9, 127);
            this.timeBetween_Label.Name = "timeBetween_Label";
            this.timeBetween_Label.Size = new System.Drawing.Size(155, 13);
            this.timeBetween_Label.TabIndex = 2;
            this.timeBetween_Label.Text = "Time Betwen Notifications (min)";
            // 
            // useLoginPage_CheckBox
            // 
            this.useLoginPage_CheckBox.AutoSize = true;
            this.useLoginPage_CheckBox.Location = new System.Drawing.Point(383, 288);
            this.useLoginPage_CheckBox.Name = "useLoginPage_CheckBox";
            this.useLoginPage_CheckBox.Size = new System.Drawing.Size(102, 17);
            this.useLoginPage_CheckBox.TabIndex = 13;
            this.useLoginPage_CheckBox.Text = "Use Login Page";
            this.useLoginPage_CheckBox.UseVisualStyleBackColor = true;
            this.useLoginPage_CheckBox.CheckedChanged += new System.EventHandler(this.useLoginPage_CheckBox_CheckedChanged);
            // 
            // useIf_Label
            // 
            this.useIf_Label.AutoSize = true;
            this.useIf_Label.Location = new System.Drawing.Point(7, 275);
            this.useIf_Label.Name = "useIf_Label";
            this.useIf_Label.Size = new System.Drawing.Size(259, 13);
            this.useIf_Label.TabIndex = 2;
            this.useIf_Label.Text = "(Use if Your Browser is Having Trouble  Sending Mail)";
            // 
            // usePrevVer_CheckBox
            // 
            this.usePrevVer_CheckBox.AutoSize = true;
            this.usePrevVer_CheckBox.Location = new System.Drawing.Point(9, 260);
            this.usePrevVer_CheckBox.Name = "usePrevVer_CheckBox";
            this.usePrevVer_CheckBox.Size = new System.Drawing.Size(214, 17);
            this.usePrevVer_CheckBox.TabIndex = 1;
            this.usePrevVer_CheckBox.Text = "Use Previous Version of Gmail for Mailto";
            this.usePrevVer_CheckBox.UseVisualStyleBackColor = true;
            // 
            // startWithWindows_CheckBox
            // 
            this.startWithWindows_CheckBox.AutoSize = true;
            this.startWithWindows_CheckBox.Location = new System.Drawing.Point(9, 301);
            this.startWithWindows_CheckBox.Name = "startWithWindows_CheckBox";
            this.startWithWindows_CheckBox.Size = new System.Drawing.Size(243, 17);
            this.startWithWindows_CheckBox.TabIndex = 9;
            this.startWithWindows_CheckBox.Text = "Start Gmail Icon Notifier when Windows Starts";
            this.startWithWindows_CheckBox.UseVisualStyleBackColor = true;
            this.startWithWindows_CheckBox.Click += new System.EventHandler(this.startWithWindows_CheckBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(290, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 43);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Check this if you often switch between Gmail accounts.";
            // 
            // Settings
            // 
            this.AcceptButton = this.ok_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cancel_Button;
            this.ClientSize = new System.Drawing.Size(497, 362);
            this.Controls.Add(this.useLoginPage_CheckBox);
            this.Controls.Add(this.useIf_Label);
            this.Controls.Add(this.startWithWindows_CheckBox);
            this.Controls.Add(this.usePrevVer_CheckBox);
            this.Controls.Add(this.accountSettings_TabControl);
            this.Controls.Add(this.ok_Button);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.apply_Button);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Gmail_Icon_Notifier.Properties.Resources.Gmail;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts and Settings";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Activated += new System.EventHandler(this.settings_Enter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.accountSettings_TabControl.ResumeLayout(false);
            this.accountInfo_TabPage.ResumeLayout(false);
            this.accountInfo_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_Table)).EndInit();
            this.settings_TabPage.ResumeLayout(false);
            this.settings_TabPage.PerformLayout();
            this.animationEffects_GroupBox.ResumeLayout(false);
            this.animationEffects_GroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeBetween_TrackBar)).EndInit();
            this.location_GroupBox.ResumeLayout(false);
            this.location_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apply_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button ok_Button;
        private System.Windows.Forms.TabControl accountSettings_TabControl;
        private System.Windows.Forms.TabPage accountInfo_TabPage;
        private System.Windows.Forms.TabPage settings_TabPage;
        private System.Windows.Forms.CheckBox useAsDefault_CheckBox;
        private System.Windows.Forms.Label emailAccount_Label;
        private System.Windows.Forms.Label password_Label;
        private System.Data.DataSet settings_DataSet;
        private System.Data.DataTable accounts_Table;
        private System.Data.DataColumn accountsID_Column;
        private System.Data.DataColumn accountsEmail_Column;
        private System.Data.DataColumn accountsPassword_Column;
        private System.Data.DataColumn accountsDefault_Column;
        private System.Data.DataColumn accountsName_Column;
//        private System.Data.DataTable dataTable2;
//        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn accountsCheckFreq_Column;
        private System.Data.DataColumn accountsFadeIn_Column;
        private System.Data.DataColumn accountsFadeOut_Column;
        private System.Data.DataColumn accountsGrowIn_Column;
        private System.Data.DataColumn accounts_GrowOut_Column;
        private System.Data.DataColumn accountGrowOut_Column;
        private System.Data.DataColumn accountsTop_Column;
        private System.Data.DataColumn accountsLeft_Column;
        private System.Windows.Forms.TextBox emailAddress_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
//        private System.Data.DataTable dataTable4;
        //        private System.Data.DataColumn dataColumn20;
        private System.Windows.Forms.Button deleteAccount_Button;
        private System.Windows.Forms.CheckBox startWithWindows_CheckBox;
        private System.Windows.Forms.CheckBox usePrevVer_CheckBox;
        private System.Windows.Forms.Label useIf_Label;
        private System.Windows.Forms.Label timeBetween_Label;
        private System.Windows.Forms.CheckBox fadeIn_CheckBox;
        private System.Windows.Forms.Label growFrom_Label;
        private System.Windows.Forms.ComboBox growFrom_ComboBox;
        private System.Windows.Forms.CheckBox growOut_CheckBox;
        private System.Windows.Forms.CheckBox growIn_CheckBox;
        private System.Windows.Forms.CheckBox fadeOut_CheckBox;
        private System.Windows.Forms.GroupBox location_GroupBox;
        private System.Windows.Forms.Button defaults_Button;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox manual_CheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar timeBetween_TrackBar;
        private System.Data.DataColumn accountsLocation_Column;
        private System.Data.DataColumn accountsLocCheck_Column;
        private System.Windows.Forms.GroupBox animationEffects_GroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addNewAccount_Button;
        private System.Windows.Forms.ComboBox account_ComboBox;
        private System.Windows.Forms.Label account_Label;
        private System.Windows.Forms.CheckBox useLoginPage_CheckBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}