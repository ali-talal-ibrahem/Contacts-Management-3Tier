namespace WindowsFormContacts_Management_Presentation
{
    partial class frmAdd_EditContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_EditContact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_TitlePage = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_FirstName = new System.Windows.Forms.TextBox();
            this.txb_LastName = new System.Windows.Forms.TextBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cb_Countries = new System.Windows.Forms.ComboBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.pic_photo = new System.Windows.Forms.PictureBox();
            this.btn_AddPhoto = new System.Windows.Forms.Button();
            this.btn_DeletePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1083, 388);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_TitlePage
            // 
            this.lbl_TitlePage.AutoSize = true;
            this.lbl_TitlePage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TitlePage.Font = new System.Drawing.Font("Cairo Black", 12F);
            this.lbl_TitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(68)))));
            this.lbl_TitlePage.Location = new System.Drawing.Point(9, 47);
            this.lbl_TitlePage.Name = "lbl_TitlePage";
            this.lbl_TitlePage.Size = new System.Drawing.Size(175, 30);
            this.lbl_TitlePage.TabIndex = 4;
            this.lbl_TitlePage.Text = "Add New Contact Page";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Cairo Black", 20F);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.lbl_Title.Location = new System.Drawing.Point(3, 4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(369, 50);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Contacts Managment System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label1.Font = new System.Drawing.Font("Cairo-Regular", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label2.Font = new System.Drawing.Font("Cairo-Regular", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label3.Font = new System.Drawing.Font("Cairo-Regular", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(278, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label4.Font = new System.Drawing.Font("Cairo-Regular", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(552, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label5.Font = new System.Drawing.Font("Cairo-Regular", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(278, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label6.Font = new System.Drawing.Font("Cairo-Regular", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(552, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "Country ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label7.Font = new System.Drawing.Font("Cairo-Regular", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address";
            // 
            // txb_FirstName
            // 
            this.txb_FirstName.BackColor = System.Drawing.Color.White;
            this.txb_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_FirstName.Font = new System.Drawing.Font("Cairo Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_FirstName.Location = new System.Drawing.Point(21, 167);
            this.txb_FirstName.MaxLength = 30;
            this.txb_FirstName.Multiline = true;
            this.txb_FirstName.Name = "txb_FirstName";
            this.txb_FirstName.Size = new System.Drawing.Size(179, 34);
            this.txb_FirstName.TabIndex = 0;
            this.txb_FirstName.WordWrap = false;
            // 
            // txb_LastName
            // 
            this.txb_LastName.BackColor = System.Drawing.Color.White;
            this.txb_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_LastName.Font = new System.Drawing.Font("Cairo Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_LastName.Location = new System.Drawing.Point(285, 167);
            this.txb_LastName.MaxLength = 30;
            this.txb_LastName.Multiline = true;
            this.txb_LastName.Name = "txb_LastName";
            this.txb_LastName.Size = new System.Drawing.Size(179, 34);
            this.txb_LastName.TabIndex = 1;
            this.txb_LastName.WordWrap = false;
            // 
            // txb_Email
            // 
            this.txb_Email.BackColor = System.Drawing.Color.White;
            this.txb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Email.Font = new System.Drawing.Font("Cairo Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Email.Location = new System.Drawing.Point(559, 167);
            this.txb_Email.MaxLength = 50;
            this.txb_Email.Multiline = true;
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(179, 34);
            this.txb_Email.TabIndex = 2;
            this.txb_Email.WordWrap = false;
            // 
            // txb_PhoneNumber
            // 
            this.txb_PhoneNumber.BackColor = System.Drawing.Color.White;
            this.txb_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_PhoneNumber.Font = new System.Drawing.Font("Cairo Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PhoneNumber.Location = new System.Drawing.Point(19, 270);
            this.txb_PhoneNumber.MaxLength = 16;
            this.txb_PhoneNumber.Multiline = true;
            this.txb_PhoneNumber.Name = "txb_PhoneNumber";
            this.txb_PhoneNumber.Size = new System.Drawing.Size(179, 34);
            this.txb_PhoneNumber.TabIndex = 3;
            this.txb_PhoneNumber.Text = "+";
            this.txb_PhoneNumber.WordWrap = false;
            // 
            // txb_Address
            // 
            this.txb_Address.BackColor = System.Drawing.Color.White;
            this.txb_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Address.Font = new System.Drawing.Font("Cairo Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Address.Location = new System.Drawing.Point(21, 349);
            this.txb_Address.MaxLength = 200;
            this.txb_Address.Multiline = true;
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(443, 73);
            this.txb_Address.TabIndex = 6;
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.CalendarFont = new System.Drawing.Font("Cairo-Regular", 8F);
            this.dtp_DateOfBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.dtp_DateOfBirth.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.dtp_DateOfBirth.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtp_DateOfBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_DateOfBirth.Font = new System.Drawing.Font("Cairo-Regular", 9F);
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(285, 271);
            this.dtp_DateOfBirth.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dtp_DateOfBirth.MinDate = new System.DateTime(1960, 12, 31, 0, 0, 0, 0);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(179, 30);
            this.dtp_DateOfBirth.TabIndex = 4;
            // 
            // cb_Countries
            // 
            this.cb_Countries.BackColor = System.Drawing.Color.White;
            this.cb_Countries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Countries.DropDownHeight = 150;
            this.cb_Countries.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_Countries.Font = new System.Drawing.Font("Cairo-Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Countries.FormattingEnabled = true;
            this.cb_Countries.IntegralHeight = false;
            this.cb_Countries.ItemHeight = 23;
            this.cb_Countries.Location = new System.Drawing.Point(559, 270);
            this.cb_Countries.Name = "cb_Countries";
            this.cb_Countries.Size = new System.Drawing.Size(179, 31);
            this.cb_Countries.Sorted = true;
            this.cb_Countries.TabIndex = 5;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Cairo Black", 12F);
            this.lbl_ID.ForeColor = System.Drawing.Color.Lime;
            this.lbl_ID.Location = new System.Drawing.Point(9, 75);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(58, 30);
            this.lbl_ID.TabIndex = 10;
            this.lbl_ID.Text = "ID : ???";
            // 
            // pic_photo
            // 
            this.pic_photo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pic_photo.Location = new System.Drawing.Point(898, 130);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(163, 171);
            this.pic_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_photo.TabIndex = 11;
            this.pic_photo.TabStop = false;
            // 
            // btn_AddPhoto
            // 
            this.btn_AddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(68)))));
            this.btn_AddPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddPhoto.FlatAppearance.BorderSize = 0;
            this.btn_AddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPhoto.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_AddPhoto.Location = new System.Drawing.Point(968, 307);
            this.btn_AddPhoto.Name = "btn_AddPhoto";
            this.btn_AddPhoto.Size = new System.Drawing.Size(93, 29);
            this.btn_AddPhoto.TabIndex = 12;
            this.btn_AddPhoto.Text = "Add Photo";
            this.btn_AddPhoto.UseVisualStyleBackColor = false;
            this.btn_AddPhoto.Click += new System.EventHandler(this.btn_AddPhoto_Click);
            // 
            // btn_DeletePhoto
            // 
            this.btn_DeletePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DeletePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeletePhoto.FlatAppearance.BorderSize = 0;
            this.btn_DeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeletePhoto.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_DeletePhoto.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_DeletePhoto.Location = new System.Drawing.Point(898, 307);
            this.btn_DeletePhoto.Name = "btn_DeletePhoto";
            this.btn_DeletePhoto.Size = new System.Drawing.Size(64, 29);
            this.btn_DeletePhoto.TabIndex = 13;
            this.btn_DeletePhoto.Text = "Delete";
            this.btn_DeletePhoto.UseVisualStyleBackColor = false;
            this.btn_DeletePhoto.Visible = false;
            this.btn_DeletePhoto.Click += new System.EventHandler(this.btn_DeletePhoto_Click);
            // 
            // frmAdd_EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(1083, 498);
            this.Controls.Add(this.btn_DeletePhoto);
            this.Controls.Add(this.btn_AddPhoto);
            this.Controls.Add(this.pic_photo);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.cb_Countries);
            this.Controls.Add(this.dtp_DateOfBirth);
            this.Controls.Add(this.txb_Address);
            this.Controls.Add(this.txb_PhoneNumber);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.txb_LastName);
            this.Controls.Add(this.txb_FirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TitlePage);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdd_EditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts Managment System - Add Contact";
            this.Load += new System.EventHandler(this.frmAdd_EditContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_TitlePage;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_FirstName;
        private System.Windows.Forms.TextBox txb_LastName;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_PhoneNumber;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.ComboBox cb_Countries;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.PictureBox pic_photo;
        private System.Windows.Forms.Button btn_AddPhoto;
        private System.Windows.Forms.Button btn_DeletePhoto;
    }
}