namespace Customer_Database
{
    partial class Form1
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
            this.MainDisplay = new System.Windows.Forms.TabControl();
            this.customerInformationTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.address1Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.zipCodeBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.stateSelectBox = new System.Windows.Forms.ComboBox();
            this.stateZipLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lookupTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.queryTab = new System.Windows.Forms.TabPage();
            this.sqlQueryTabSplit = new System.Windows.Forms.SplitContainer();
            this.sqlQueryTopPanelSplit = new System.Windows.Forms.SplitContainer();
            this.sqlQueryTextbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.datagridForQuery = new System.Windows.Forms.DataGridView();
            this.tabQueryBuilder = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.topText = new System.Windows.Forms.TextBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.MainDisplay.SuspendLayout();
            this.customerInformationTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.lookupTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.queryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlQueryTabSplit)).BeginInit();
            this.sqlQueryTabSplit.Panel1.SuspendLayout();
            this.sqlQueryTabSplit.Panel2.SuspendLayout();
            this.sqlQueryTabSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlQueryTopPanelSplit)).BeginInit();
            this.sqlQueryTopPanelSplit.Panel1.SuspendLayout();
            this.sqlQueryTopPanelSplit.Panel2.SuspendLayout();
            this.sqlQueryTopPanelSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridForQuery)).BeginInit();
            this.tabQueryBuilder.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDisplay
            // 
            this.MainDisplay.Controls.Add(this.customerInformationTab);
            this.MainDisplay.Controls.Add(this.lookupTab);
            this.MainDisplay.Controls.Add(this.queryTab);
            this.MainDisplay.Controls.Add(this.tabQueryBuilder);
            this.MainDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDisplay.Location = new System.Drawing.Point(0, 24);
            this.MainDisplay.Multiline = true;
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.SelectedIndex = 0;
            this.MainDisplay.Size = new System.Drawing.Size(719, 496);
            this.MainDisplay.TabIndex = 0;
            // 
            // customerInformationTab
            // 
            this.customerInformationTab.BackColor = System.Drawing.SystemColors.Control;
            this.customerInformationTab.Controls.Add(this.groupBox1);
            this.customerInformationTab.Location = new System.Drawing.Point(4, 22);
            this.customerInformationTab.Name = "customerInformationTab";
            this.customerInformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerInformationTab.Size = new System.Drawing.Size(711, 470);
            this.customerInformationTab.TabIndex = 0;
            this.customerInformationTab.Text = "Customer Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.firstNameBox);
            this.groupBox1.Controls.Add(this.phoneTextbox);
            this.groupBox1.Controls.Add(this.lastNameBox);
            this.groupBox1.Controls.Add(this.emailTextbox);
            this.groupBox1.Controls.Add(this.address1Box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cityBox);
            this.groupBox1.Controls.Add(this.phoneLabel);
            this.groupBox1.Controls.Add(this.zipCodeBox);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.stateSelectBox);
            this.groupBox1.Controls.Add(this.stateZipLabel);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.cityLabel);
            this.groupBox1.Controls.Add(this.addressLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 281);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 35);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(69, 32);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(215, 20);
            this.firstNameBox.TabIndex = 0;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(69, 206);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(215, 20);
            this.phoneTextbox.TabIndex = 16;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(69, 58);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(215, 20);
            this.lastNameBox.TabIndex = 1;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(69, 181);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(215, 20);
            this.emailTextbox.TabIndex = 15;
            // 
            // address1Box
            // 
            this.address1Box.Location = new System.Drawing.Point(69, 84);
            this.address1Box.Name = "address1Box";
            this.address1Box.Size = new System.Drawing.Size(215, 20);
            this.address1Box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(9, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 2);
            this.label1.TabIndex = 14;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(69, 109);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(215, 20);
            this.cityBox.TabIndex = 3;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(6, 210);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Phone";
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Location = new System.Drawing.Point(196, 135);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(88, 20);
            this.zipCodeBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 184);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email";
            // 
            // stateSelectBox
            // 
            this.stateSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateSelectBox.FormattingEnabled = true;
            this.stateSelectBox.Items.AddRange(new object[] {
            "",
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California ",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii ",
            "Idaho ",
            "Illinois Indiana ",
            "Iowa ",
            "Kansas ",
            "Kentucky ",
            "Louisiana ",
            "Maine ",
            "Maryland ",
            "Massachusetts ",
            "Michigan ",
            "Minnesota ",
            "Mississippi ",
            "Missouri ",
            "Montana Nebraska ",
            "Nevada ",
            "New Hampshire ",
            "New Jersey ",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming"});
            this.stateSelectBox.Location = new System.Drawing.Point(69, 134);
            this.stateSelectBox.Name = "stateSelectBox";
            this.stateSelectBox.Size = new System.Drawing.Size(121, 21);
            this.stateSelectBox.Sorted = true;
            this.stateSelectBox.TabIndex = 4;
            // 
            // stateZipLabel
            // 
            this.stateZipLabel.AutoSize = true;
            this.stateZipLabel.Location = new System.Drawing.Point(6, 138);
            this.stateZipLabel.Name = "stateZipLabel";
            this.stateZipLabel.Size = new System.Drawing.Size(58, 13);
            this.stateZipLabel.TabIndex = 10;
            this.stateZipLabel.Text = "State / Zip";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 61);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(6, 112);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(6, 87);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address";
            // 
            // lookupTab
            // 
            this.lookupTab.BackColor = System.Drawing.SystemColors.Control;
            this.lookupTab.Controls.Add(this.splitContainer2);
            this.lookupTab.Location = new System.Drawing.Point(4, 22);
            this.lookupTab.Name = "lookupTab";
            this.lookupTab.Padding = new System.Windows.Forms.Padding(3);
            this.lookupTab.Size = new System.Drawing.Size(711, 470);
            this.lookupTab.TabIndex = 1;
            this.lookupTab.Text = "Customer Lookup";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(705, 464);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.searchTerm);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button1);
            this.splitContainer3.Size = new System.Drawing.Size(705, 25);
            this.splitContainer3.SplitterDistance = 622;
            this.splitContainer3.TabIndex = 0;
            // 
            // searchTerm
            // 
            this.searchTerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTerm.Location = new System.Drawing.Point(0, 0);
            this.searchTerm.Multiline = true;
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(622, 25);
            this.searchTerm.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // queryTab
            // 
            this.queryTab.Controls.Add(this.sqlQueryTabSplit);
            this.queryTab.Location = new System.Drawing.Point(4, 22);
            this.queryTab.Name = "queryTab";
            this.queryTab.Padding = new System.Windows.Forms.Padding(3);
            this.queryTab.Size = new System.Drawing.Size(711, 470);
            this.queryTab.TabIndex = 2;
            this.queryTab.Text = "SQL Query";
            this.queryTab.UseVisualStyleBackColor = true;
            // 
            // sqlQueryTabSplit
            // 
            this.sqlQueryTabSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlQueryTabSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sqlQueryTabSplit.Location = new System.Drawing.Point(3, 3);
            this.sqlQueryTabSplit.Name = "sqlQueryTabSplit";
            this.sqlQueryTabSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sqlQueryTabSplit.Panel1
            // 
            this.sqlQueryTabSplit.Panel1.Controls.Add(this.sqlQueryTopPanelSplit);
            // 
            // sqlQueryTabSplit.Panel2
            // 
            this.sqlQueryTabSplit.Panel2.Controls.Add(this.datagridForQuery);
            this.sqlQueryTabSplit.Size = new System.Drawing.Size(705, 464);
            this.sqlQueryTabSplit.SplitterDistance = 48;
            this.sqlQueryTabSplit.TabIndex = 0;
            // 
            // sqlQueryTopPanelSplit
            // 
            this.sqlQueryTopPanelSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlQueryTopPanelSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sqlQueryTopPanelSplit.Location = new System.Drawing.Point(0, 0);
            this.sqlQueryTopPanelSplit.Name = "sqlQueryTopPanelSplit";
            // 
            // sqlQueryTopPanelSplit.Panel1
            // 
            this.sqlQueryTopPanelSplit.Panel1.Controls.Add(this.sqlQueryTextbox);
            // 
            // sqlQueryTopPanelSplit.Panel2
            // 
            this.sqlQueryTopPanelSplit.Panel2.Controls.Add(this.button3);
            this.sqlQueryTopPanelSplit.Size = new System.Drawing.Size(705, 48);
            this.sqlQueryTopPanelSplit.SplitterDistance = 597;
            this.sqlQueryTopPanelSplit.TabIndex = 0;
            // 
            // sqlQueryTextbox
            // 
            this.sqlQueryTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlQueryTextbox.Location = new System.Drawing.Point(0, 0);
            this.sqlQueryTextbox.Multiline = true;
            this.sqlQueryTextbox.Name = "sqlQueryTextbox";
            this.sqlQueryTextbox.Size = new System.Drawing.Size(597, 48);
            this.sqlQueryTextbox.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 48);
            this.button3.TabIndex = 0;
            this.button3.Text = "Run Query";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // datagridForQuery
            // 
            this.datagridForQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridForQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridForQuery.Location = new System.Drawing.Point(0, 0);
            this.datagridForQuery.Name = "datagridForQuery";
            this.datagridForQuery.Size = new System.Drawing.Size(705, 412);
            this.datagridForQuery.TabIndex = 0;
            // 
            // tabQueryBuilder
            // 
            this.tabQueryBuilder.BackColor = System.Drawing.SystemColors.Control;
            this.tabQueryBuilder.Controls.Add(this.comboBox4);
            this.tabQueryBuilder.Controls.Add(this.label4);
            this.tabQueryBuilder.Controls.Add(this.textBox1);
            this.tabQueryBuilder.Controls.Add(this.comboBox3);
            this.tabQueryBuilder.Controls.Add(this.comboBox2);
            this.tabQueryBuilder.Controls.Add(this.topText);
            this.tabQueryBuilder.Controls.Add(this.topLabel);
            this.tabQueryBuilder.Controls.Add(this.label3);
            this.tabQueryBuilder.Controls.Add(this.comboBox1);
            this.tabQueryBuilder.Controls.Add(this.label2);
            this.tabQueryBuilder.Location = new System.Drawing.Point(4, 22);
            this.tabQueryBuilder.Name = "tabQueryBuilder";
            this.tabQueryBuilder.Padding = new System.Windows.Forms.Padding(3);
            this.tabQueryBuilder.Size = new System.Drawing.Size(711, 470);
            this.tabQueryBuilder.TabIndex = 3;
            this.tabQueryBuilder.Text = "Query Builder";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "is",
            "is not",
            "contains",
            "does not contain",
            "equals",
            "does not equal"});
            this.comboBox3.Location = new System.Drawing.Point(203, 38);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "TBD - Will pull column list from database"});
            this.comboBox2.Location = new System.Drawing.Point(76, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // topText
            // 
            this.topText.Location = new System.Drawing.Point(310, 8);
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(100, 20);
            this.topText.TabIndex = 5;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(264, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(40, 20);
            this.topLabel.TabIndex = 4;
            this.topLabel.Text = "TOP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "WHERE";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Top ____ Items"});
            this.comboBox1.Location = new System.Drawing.Point(76, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "SELECT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "FROM";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "TBD - Will pull table list from database"});
            this.comboBox4.Location = new System.Drawing.Point(76, 71);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 520);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainDisplay.ResumeLayout(false);
            this.customerInformationTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lookupTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.queryTab.ResumeLayout(false);
            this.sqlQueryTabSplit.Panel1.ResumeLayout(false);
            this.sqlQueryTabSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sqlQueryTabSplit)).EndInit();
            this.sqlQueryTabSplit.ResumeLayout(false);
            this.sqlQueryTopPanelSplit.Panel1.ResumeLayout(false);
            this.sqlQueryTopPanelSplit.Panel1.PerformLayout();
            this.sqlQueryTopPanelSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sqlQueryTopPanelSplit)).EndInit();
            this.sqlQueryTopPanelSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridForQuery)).EndInit();
            this.tabQueryBuilder.ResumeLayout(false);
            this.tabQueryBuilder.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainDisplay;
        private System.Windows.Forms.TabPage customerInformationTab;
        private System.Windows.Forms.TabPage lookupTab;
        private System.Windows.Forms.ComboBox stateSelectBox;
        private System.Windows.Forms.TextBox zipCodeBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox address1Box;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label stateZipLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage queryTab;
        private System.Windows.Forms.SplitContainer sqlQueryTabSplit;
        private System.Windows.Forms.DataGridView datagridForQuery;
        private System.Windows.Forms.SplitContainer sqlQueryTopPanelSplit;
        private System.Windows.Forms.TextBox sqlQueryTextbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabPage tabQueryBuilder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox topText;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

