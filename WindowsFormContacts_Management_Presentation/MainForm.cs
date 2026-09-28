using System;
using System.Windows.Forms;
using Contacts_Management_BusinessLayer;

namespace WindowsFormContacts_Management_Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _RefreshContactList() {

            dgvAllContacts.DataSource = clsContact.GetAllContactsFrom();
            int CountAllContacts = dgvAllContacts.RowCount;
            lbl_Count.Text = CountAllContacts.ToString();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _RefreshContactList();
        }

        private void btn_AddNewContact_Click(object sender, EventArgs e)
        {
            frmAdd_EditContact AddContactForm = new frmAdd_EditContact(-1);
            AddContactForm.ShowDialog();

            _RefreshContactList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int contactID = (int)dgvAllContacts.CurrentRow.Cells[0].Value;


            frmAdd_EditContact AddContactForm = new frmAdd_EditContact(contactID);
            AddContactForm.ShowDialog();

            _RefreshContactList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int contactID = (int)dgvAllContacts.CurrentRow.Cells[0].Value;

            if (clsContact.DeleteContactByID(contactID))
            {

                MessageBox.Show("Contact Deleted Successfully.", "Successfully!", MessageBoxButtons.OK);
                _RefreshContactList();
            }
            else
            {
                MessageBox.Show("Error: Data Is not Delete Successfully.");
            }
        }
        

        private void btn_ShowCountriesTable_Click(object sender, EventArgs e)
        {
            btn_ShowContactsTable.Visible = true;
            btn_ShowCountriesTable.Visible = false;
            btn_AddNewContact.Visible = false;
            contextMenuStrip1.Enabled = false;


            dgvAllContacts.DataSource = null;
            dgvAllContacts.DataSource = clsCountry.GetAllCountries();

            int CountAllCountries = dgvAllContacts.RowCount;
            lbl_Count.Text = CountAllCountries.ToString();
            lbl_Title3.Text = "Number Countries: ";
        }

        private void btn_ShowContactsTable_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Enabled = true;
            btn_ShowCountriesTable.Visible = true;
            btn_AddNewContact.Visible = true;
            btn_ShowContactsTable.Visible = false;

            dgvAllContacts.DataSource = null;
            dgvAllContacts.DataSource = clsContact.GetAllContactsFrom();

            int CountAllContacts = dgvAllContacts.RowCount;
            lbl_Count.Text = CountAllContacts.ToString();
            lbl_Title3.Text = "Number Contacts: ";
        }


    }
}
