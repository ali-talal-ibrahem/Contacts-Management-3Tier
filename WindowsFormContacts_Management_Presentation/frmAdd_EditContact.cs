using System;
using System.Data;
using System.Windows.Forms;
using Contacts_Management_BusinessLayer;


namespace WindowsFormContacts_Management_Presentation
{
    public partial class frmAdd_EditContact : Form
    {
        public frmAdd_EditContact()
        {
            InitializeComponent();
        }


        public void _RefreshPage()
        {

            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow Row in dtCountries.Rows) {
                cb_Countries.Items.Add(Row["CountryName"]);
            }

            cb_Countries.SelectedIndex = 0;
        }

        private void frmAdd_EditContact_Load(object sender, EventArgs e)
        {
            _RefreshPage();
        }

        private void cb_Countries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddPhoto_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditPhoto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
