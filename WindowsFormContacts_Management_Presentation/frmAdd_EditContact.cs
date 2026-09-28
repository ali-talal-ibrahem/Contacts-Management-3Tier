using System;
using System.Data;
using System.Windows.Forms;
using Contacts_Management_BusinessLayer;


namespace WindowsFormContacts_Management_Presentation
{
    public partial class frmAdd_EditContact : Form
    {

        private enum _enMode { AddContact = 0 , UpdateContact = 1};
        private _enMode _Mode = _enMode.AddContact;

        private int _ContactID;
        private clsContact _Contact;


        public frmAdd_EditContact(int ContactID)
        {
            InitializeComponent();

            _ContactID = ContactID;

            if (_ContactID == -1)
            {
                _Mode = _enMode.AddContact;
                this.Text = "Contacts Managment System - Add Contact";
                lbl_TitlePage.Text = "Add New Contact Page";
            }
            else {
                _Mode = _enMode.UpdateContact;
                this.Text = "Contacts Managment System - Update Contact";
                lbl_TitlePage.Text = "Update Contact Page";
            }

        }


        public void _FillCountriesInComboBox()
        {

            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow Row in dtCountries.Rows) {
                cb_Countries.Items.Add(Row["CountryName"]);
            }

        }


        private void _Load() 
        {
            _FillCountriesInComboBox();
            cb_Countries.SelectedIndex = 0;

            if (_Mode == _enMode.AddContact)
            {
                _Contact = new clsContact();
                return;
            }

            _Contact = clsContact.Find(_ContactID);

            if (_Contact == null) 
            {
                MessageBox.Show("This form will be closed because No Contact with ID = \" + _ContactID");
                this.Close();
                return;
            }

            lbl_ID.Text = "ID : " + _Contact.ID;

            txb_FirstName.Text = _Contact.FirstName;
            txb_LastName.Text = _Contact.LastName;
            txb_Email.Text = _Contact.Email;
            txb_PhoneNumber.Text = _Contact.Phone;
            txb_Address.Text = _Contact.Address;
            dtp_DateOfBirth.Value = _Contact.DateOfBirth;

            if (_Contact.ImagePath != "") {
                pic_photo.Load(_Contact.ImagePath);
            }
                btn_AddPhoto.Enabled = (_Contact.ImagePath == "");
                btn_DeletePhoto.Visible = (_Contact.ImagePath != "");

            cb_Countries.SelectedIndex = cb_Countries.FindString(clsCountry.Find(_Contact.CountryID).CountryName);


        }
        
        

        private void frmAdd_EditContact_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btn_AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                pic_photo.Load(selectedFilePath);
            }

            if (pic_photo.ImageLocation != null) { 
                btn_AddPhoto.Enabled = false;
                btn_DeletePhoto.Visible = true;
            }
        }

        private void btn_DeletePhoto_Click(object sender, EventArgs e)
        {

            pic_photo.ImageLocation = null;
            btn_AddPhoto.Enabled = true;
            btn_DeletePhoto.Visible = false;
        }

    }
}
