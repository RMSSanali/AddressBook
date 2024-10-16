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
            labelStreet = new Label();
            textBoxName = new TextBox();
            textBoxStreet = new TextBox();
            textBoxPostelCode = new TextBox();
            labelPostelCode = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxTelephone = new TextBox();
            labelTelephone = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dataGridViewContacts = new DataGridView();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            pictureBox1 = new PictureBox();
            textBoxCity = new TextBox();
            labelCity = new Label();
            Name = new DataGridViewTextBoxColumn();
            StreetAddress = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
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
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStreet.ForeColor = SystemColors.HotTrack;
            labelStreet.Location = new Point(12, 284);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(127, 54);
            labelStreet.TabIndex = 2;
            labelStreet.Text = "Street";
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
            textBoxEmail.Location = new Point(317, 700);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(736, 61);
            textBoxEmail.TabIndex = 15;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = SystemColors.HotTrack;
            labelEmail.Location = new Point(9, 703);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(117, 54);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email";
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Font = new Font("Segoe UI", 12F);
            textBoxTelephone.Location = new Point(318, 606);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(736, 61);
            textBoxTelephone.TabIndex = 12;
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTelephone.ForeColor = SystemColors.HotTrack;
            labelTelephone.Location = new Point(10, 609);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(206, 54);
            labelTelephone.TabIndex = 10;
            labelTelephone.Text = "Telephone";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.HotTrack;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = SystemColors.ControlLightLight;
            buttonAdd.Location = new Point(206, 880);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(232, 93);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.HotTrack;
            buttonUpdate.FlatStyle = FlatStyle.Popup;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonUpdate.Location = new Point(514, 880);
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
            buttonDelete.Location = new Point(821, 880);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(232, 93);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridViewContacts
            // 
            dataGridViewContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContacts.Columns.AddRange(new DataGridViewColumn[] { Name, StreetAddress, PostalCode, City, PhoneNumber, Email });
            dataGridViewContacts.Location = new Point(1140, 281);
            dataGridViewContacts.Name = "dataGridViewContacts";
            dataGridViewContacts.RowHeadersWidth = 102;
            dataGridViewContacts.Size = new Size(1606, 493);
            dataGridViewContacts.TabIndex = 19;
            dataGridViewContacts.CellContentClick += dataGridViewContacts_CellContentClick;
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
            // textBoxCity
            // 
            textBoxCity.Font = new Font("Segoe UI", 12F);
            textBoxCity.Location = new Point(317, 495);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(736, 61);
            textBoxCity.TabIndex = 25;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCity.ForeColor = SystemColors.HotTrack;
            labelCity.Location = new Point(9, 498);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(91, 54);
            labelCity.TabIndex = 24;
            labelCity.Text = "City";
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
            StreetAddress.HeaderText = "Street";
            StreetAddress.MinimumWidth = 12;
            StreetAddress.Name = "StreetAddress";
            StreetAddress.Width = 250;
            // 
            // PostalCode
            // 
            PostalCode.HeaderText = "PostalCode";
            PostalCode.MinimumWidth = 12;
            PostalCode.Name = "PostalCode";
            PostalCode.Width = 250;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 12;
            City.Name = "City";
            City.Width = 250;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Telephone";
            PhoneNumber.MinimumWidth = 12;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 250;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 12;
            Email.Name = "Email";
            Email.Width = 250;
            // 
            // AddressBook
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(2786, 1020);
            Controls.Add(textBoxCity);
            Controls.Add(labelCity);
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
            Controls.Add(labelTelephone);
            Controls.Add(textBoxPostelCode);
            Controls.Add(labelPostelCode);
            Controls.Add(textBoxStreet);
            Controls.Add(textBoxName);
            Controls.Add(labelStreet);
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
        private Label labelStreet;
        private TextBox textBoxName;
        private TextBox textBoxStreet;
        private TextBox textBoxPostelCode;
        private Label labelPostelCode;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxTelephone;
        private Label labelTelephone;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dataGridViewContacts;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private PictureBox pictureBox1;
        private TextBox textBoxCity;
        private Label labelCity;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn StreetAddress;
        private DataGridViewTextBoxColumn PostalCode;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Email;
    }
}
