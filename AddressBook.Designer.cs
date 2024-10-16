namespace AddressBook
{
    partial class AddressBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressBook));
            labelHeading = new Label();
            labelName = new Label();
            labelStreetAddress = new Label();
            textBoxName = new TextBox();
            textBoxStreet = new TextBox();
            textBoxPostelCode = new TextBox();
            labelPostelCode = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxTelephone = new TextBox();
            textBoxPostelAddress = new TextBox();
            labelTelephone = new Label();
            labelPostelAddress = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dataGridViewContacts = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            StreetAddress = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Arial Narrow", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeading.ForeColor = SystemColors.HotTrack;
            labelHeading.Location = new Point(183, 30);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(409, 77);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Address Book";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.HotTrack;
            labelName.Location = new Point(12, 183);
            labelName.Name = "labelName";
            labelName.Size = new Size(128, 54);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelStreetAddress
            // 
            labelStreetAddress.AutoSize = true;
            labelStreetAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStreetAddress.ForeColor = SystemColors.HotTrack;
            labelStreetAddress.Location = new Point(12, 284);
            labelStreetAddress.Name = "labelStreetAddress";
            labelStreetAddress.Size = new Size(281, 54);
            labelStreetAddress.TabIndex = 2;
            labelStreetAddress.Text = "Street Address";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(320, 180);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(736, 61);
            textBoxName.TabIndex = 3;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxStreet.Location = new Point(320, 281);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(736, 61);
            textBoxStreet.TabIndex = 4;
            // 
            // textBoxPostelCode
            // 
            textBoxPostelCode.Font = new Font("Segoe UI", 12F);
            textBoxPostelCode.Location = new Point(318, 396);
            textBoxPostelCode.Name = "textBoxPostelCode";
            textBoxPostelCode.Size = new Size(736, 61);
            textBoxPostelCode.TabIndex = 8;
            // 
            // labelPostelCode
            // 
            labelPostelCode.AutoSize = true;
            labelPostelCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPostelCode.ForeColor = SystemColors.HotTrack;
            labelPostelCode.Location = new Point(10, 399);
            labelPostelCode.Name = "labelPostelCode";
            labelPostelCode.Size = new Size(233, 54);
            labelPostelCode.TabIndex = 6;
            labelPostelCode.Text = "Postel Code";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(319, 697);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(736, 61);
            textBoxEmail.TabIndex = 15;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = SystemColors.HotTrack;
            labelEmail.Location = new Point(11, 700);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(117, 54);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email";
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Font = new Font("Segoe UI", 12F);
            textBoxTelephone.Location = new Point(320, 603);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(736, 61);
            textBoxTelephone.TabIndex = 12;
            // 
            // textBoxPostelAddress
            // 
            textBoxPostelAddress.Font = new Font("Segoe UI", 12F);
            textBoxPostelAddress.Location = new Point(320, 502);
            textBoxPostelAddress.Name = "textBoxPostelAddress";
            textBoxPostelAddress.Size = new Size(736, 61);
            textBoxPostelAddress.TabIndex = 11;
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTelephone.ForeColor = SystemColors.HotTrack;
            labelTelephone.Location = new Point(12, 606);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(206, 54);
            labelTelephone.TabIndex = 10;
            labelTelephone.Text = "Telephone";
            // 
            // labelPostelAddress
            // 
            labelPostelAddress.AutoSize = true;
            labelPostelAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPostelAddress.ForeColor = SystemColors.HotTrack;
            labelPostelAddress.Location = new Point(12, 505);
            labelPostelAddress.Name = "labelPostelAddress";
            labelPostelAddress.Size = new Size(283, 54);
            labelPostelAddress.TabIndex = 9;
            labelPostelAddress.Text = "Postel Address";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.HotTrack;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = SystemColors.ControlLightLight;
            buttonAdd.Location = new Point(199, 827);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(232, 93);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.HotTrack;
            buttonUpdate.FlatStyle = FlatStyle.Popup;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonUpdate.Location = new Point(507, 827);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(232, 93);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.HotTrack;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = SystemColors.ControlLightLight;
            buttonDelete.Location = new Point(814, 827);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(232, 93);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridViewContacts
            // 
            dataGridViewContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContacts.Columns.AddRange(new DataGridViewColumn[] { Name, StreetAddress, City, PostalCode, PhoneNumber, Email });
            dataGridViewContacts.Location = new Point(1140, 281);
            dataGridViewContacts.Name = "dataGridViewContacts";
            dataGridViewContacts.RowHeadersWidth = 102;
            dataGridViewContacts.Size = new Size(1606, 493);
            dataGridViewContacts.TabIndex = 19;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 12;
            Name.Name = "Name";
            Name.Width = 250;
            // 
            // StreetAddress
            // 
            StreetAddress.HeaderText = "StreetAddress";
            StreetAddress.MinimumWidth = 12;
            StreetAddress.Name = "StreetAddress";
            StreetAddress.Width = 250;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 12;
            City.Name = "City";
            City.Width = 250;
            // 
            // PostalCode
            // 
            PostalCode.HeaderText = "PostalCode";
            PostalCode.MinimumWidth = 12;
            PostalCode.Name = "PostalCode";
            PostalCode.Width = 250;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Column1";
            PhoneNumber.MinimumWidth = 12;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 250;
            // 
            // Email
            // 
            Email.HeaderText = "Column1";
            Email.MinimumWidth = 12;
            Email.Name = "Email";
            Email.Width = 250;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearch.ForeColor = SystemColors.HotTrack;
            labelSearch.Location = new Point(1140, 187);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(140, 54);
            labelSearch.TabIndex = 20;
            labelSearch.Text = "Search";
            labelSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(1298, 176);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(892, 61);
            textBoxSearch.TabIndex = 21;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.HotTrack;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(2223, 180);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(196, 61);
            buttonSearch.TabIndex = 22;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // AddressBook
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(2781, 989);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(dataGridViewContacts);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxTelephone);
            Controls.Add(textBoxPostelAddress);
            Controls.Add(labelTelephone);
            Controls.Add(labelPostelAddress);
            Controls.Add(textBoxPostelCode);
            Controls.Add(labelPostelCode);
            Controls.Add(textBoxStreet);
            Controls.Add(textBoxName);
            Controls.Add(labelStreetAddress);
            Controls.Add(labelName);
            Controls.Add(labelHeading);
            ForeColor = SystemColors.ActiveCaptionText;
            ((System.ComponentModel.ISupportInitialize)dataGridViewContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeading;
        private Label labelName;
        private Label labelStreetAddress;
        private TextBox textBoxName;
        private TextBox textBoxStreet;
        private TextBox textBoxPostelCode;
        private Label labelPostelCode;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxTelephone;
        private TextBox textBoxPostelAddress;
        private Label labelTelephone;
        private Label labelPostelAddress;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dataGridViewContacts;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn StreetAddress;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn PostalCode;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Email;
    }
}
