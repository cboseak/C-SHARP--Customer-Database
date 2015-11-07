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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.stateZipLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.stateSelectBox = new System.Windows.Forms.ComboBox();
            this.zipCodeBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.address1Box = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lookupTab = new System.Windows.Forms.TabPage();
            this.sqlResults = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.MainDisplay.SuspendLayout();
            this.customerInformationTab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.lookupTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDisplay
            // 
            this.MainDisplay.Controls.Add(this.customerInformationTab);
            this.MainDisplay.Controls.Add(this.lookupTab);
            this.MainDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDisplay.Location = new System.Drawing.Point(0, 0);
            this.MainDisplay.Multiline = true;
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.SelectedIndex = 0;
            this.MainDisplay.Size = new System.Drawing.Size(629, 496);
            this.MainDisplay.TabIndex = 0;
            // 
            // customerInformationTab
            // 
            this.customerInformationTab.BackColor = System.Drawing.SystemColors.Control;
            this.customerInformationTab.Controls.Add(this.statusStrip1);
            this.customerInformationTab.Controls.Add(this.button1);
            this.customerInformationTab.Controls.Add(this.phoneTextbox);
            this.customerInformationTab.Controls.Add(this.emailTextbox);
            this.customerInformationTab.Controls.Add(this.label1);
            this.customerInformationTab.Controls.Add(this.phoneLabel);
            this.customerInformationTab.Controls.Add(this.emailLabel);
            this.customerInformationTab.Controls.Add(this.stateZipLabel);
            this.customerInformationTab.Controls.Add(this.cityLabel);
            this.customerInformationTab.Controls.Add(this.addressLabel);
            this.customerInformationTab.Controls.Add(this.lastNameLabel);
            this.customerInformationTab.Controls.Add(this.firstNameLabel);
            this.customerInformationTab.Controls.Add(this.stateSelectBox);
            this.customerInformationTab.Controls.Add(this.zipCodeBox);
            this.customerInformationTab.Controls.Add(this.cityBox);
            this.customerInformationTab.Controls.Add(this.address1Box);
            this.customerInformationTab.Controls.Add(this.lastNameBox);
            this.customerInformationTab.Controls.Add(this.firstNameBox);
            this.customerInformationTab.Location = new System.Drawing.Point(4, 22);
            this.customerInformationTab.Name = "customerInformationTab";
            this.customerInformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerInformationTab.Size = new System.Drawing.Size(621, 470);
            this.customerInformationTab.TabIndex = 0;
            this.customerInformationTab.Text = "Customer Information";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(615, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(71, 184);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(215, 20);
            this.phoneTextbox.TabIndex = 16;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(71, 159);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(215, 20);
            this.emailTextbox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(11, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 2);
            this.label1.TabIndex = 14;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(8, 188);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(8, 162);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email";
            // 
            // stateZipLabel
            // 
            this.stateZipLabel.AutoSize = true;
            this.stateZipLabel.Location = new System.Drawing.Point(8, 116);
            this.stateZipLabel.Name = "stateZipLabel";
            this.stateZipLabel.Size = new System.Drawing.Size(58, 13);
            this.stateZipLabel.TabIndex = 10;
            this.stateZipLabel.Text = "State / Zip";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(8, 90);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(8, 65);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(8, 39);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 13);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
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
            this.stateSelectBox.Location = new System.Drawing.Point(71, 112);
            this.stateSelectBox.Name = "stateSelectBox";
            this.stateSelectBox.Size = new System.Drawing.Size(121, 21);
            this.stateSelectBox.Sorted = true;
            this.stateSelectBox.TabIndex = 5;
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Location = new System.Drawing.Point(198, 113);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(88, 20);
            this.zipCodeBox.TabIndex = 4;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(71, 87);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(215, 20);
            this.cityBox.TabIndex = 3;
            // 
            // address1Box
            // 
            this.address1Box.Location = new System.Drawing.Point(71, 62);
            this.address1Box.Name = "address1Box";
            this.address1Box.Size = new System.Drawing.Size(215, 20);
            this.address1Box.TabIndex = 2;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(71, 36);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(215, 20);
            this.lastNameBox.TabIndex = 1;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(71, 10);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(215, 20);
            this.firstNameBox.TabIndex = 0;
            // 
            // lookupTab
            // 
            this.lookupTab.BackColor = System.Drawing.SystemColors.Control;
            this.lookupTab.Controls.Add(this.sqlResults);
            this.lookupTab.Location = new System.Drawing.Point(4, 22);
            this.lookupTab.Name = "lookupTab";
            this.lookupTab.Padding = new System.Windows.Forms.Padding(3);
            this.lookupTab.Size = new System.Drawing.Size(621, 470);
            this.lookupTab.TabIndex = 1;
            this.lookupTab.Text = "Customer Lookup";
            // 
            // sqlResults
            // 
            this.sqlResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastname,
            this.address,
            this.city,
            this.state,
            this.zip,
            this.email,
            this.phone});
            this.sqlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlResults.Location = new System.Drawing.Point(3, 3);
            this.sqlResults.Name = "sqlResults";
            this.sqlResults.Size = new System.Drawing.Size(615, 464);
            this.sqlResults.TabIndex = 3;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "lastName";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // zip
            // 
            this.zip.HeaderText = "Zip";
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone Number";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainDisplay);
            this.splitContainer1.Size = new System.Drawing.Size(719, 496);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Customer_Database.Properties.Resources._7002_grey_gradient_1280x800_abstract_wallpaper;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 1500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // searchTerm
            // 
            this.searchTerm.Location = new System.Drawing.Point(427, 3);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(211, 20);
            this.searchTerm.TabIndex = 20;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(644, 1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 520);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTerm);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainDisplay.ResumeLayout(false);
            this.customerInformationTab.ResumeLayout(false);
            this.customerInformationTab.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.lookupTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sqlResults)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView sqlResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Button searchButton;
    }
}

