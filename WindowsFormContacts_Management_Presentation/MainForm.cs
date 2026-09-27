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
            lbl_CountContacts.Text = CountAllContacts.ToString();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _RefreshContactList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit", "Successfuly");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete", "Successfuly");
        }
    }
}
