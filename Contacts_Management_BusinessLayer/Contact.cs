using System;
using System.Data;
using Contacts_Management_DataLayer;

namespace Contacts_Management_BusinessLayer
{
    public class clsContact
    {

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }

        public clsContact()
        {
            Mode = enMode.AddNew;
            ID = -1;
            FirstName = "";
            LastName = "";
            Email = "";
            Phone = "";
            Address = "";
            DateOfBirth = DateTime.Now;
            CountryID = -1;
            ImagePath = "";
        }

        private bool _AddNewContact() {
            this.ID = clsContactData.AddNewContact(this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
            return (this.ID != -1);
        }

        private bool _UpdateContact() {
            return clsContactData.UpdateContact(this.ID, this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
        }

        private clsContact(int id, string firstName, string lastName,string email ,string phone,
            string address, DateTime dateOfBirth, int countryID, string imagePath)
        {
            Mode = enMode.Update;
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            DateOfBirth = dateOfBirth;
            CountryID = countryID;
            ImagePath = imagePath;
        }

        static public clsContact Find(int ID)
        {
            string firstName = "";
            string lastName = "";
            string email = "";
            string phone = "";
            string address = "";
            DateTime dateOfBirth = DateTime.Now;
            int countryID = -1;
            string imagePath = "";

            if (clsContactData.GetContactinfoById(ID, ref firstName, ref lastName
                ,ref email,ref phone, ref address, ref dateOfBirth, ref countryID, ref imagePath))
            {
                return new clsContact(ID, firstName, lastName,email, phone, address,
                    dateOfBirth, countryID, imagePath);
            }

            return null;
        }

        static public DataTable GetAllContactsFrom()
        {
            return clsContactData.GetAllContactsFrom();
        }

        static public bool IsContactExist(int ID) {
            return clsContactData.IsContactExist(ID);
        }

        static public bool DeleteContactByID(int ID) {
            return clsContactData.DeleteContactByID(ID);
        }

        public bool Save() {

            switch (Mode) {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else {
                        return false;
                    }
                case enMode.Update:
                    return (_UpdateContact());
            }

            return false;
        }


        static void Main(string[] args)
        {


        }
    }
}
