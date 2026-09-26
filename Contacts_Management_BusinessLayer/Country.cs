using System;
using System.Data;
using Contacts_Management_DataLayer;

namespace Contacts_Management_BusinessLayer
{
    public class clsCountry
    {
        private enum enMode { eAddMode = 0 , eUpdateMode = 1};
        private enMode Mode = enMode.eAddMode;

        public int ID { get; set; }
        public string CountryName { get; set; }
        public string PhoneCode { get; set; }
        public string CountryCode { get; set; }

        public clsCountry() {

            ID = -1;
            CountryName = "";
            PhoneCode = "";
            CountryCode = "";
            Mode = enMode.eAddMode;

        }

        private clsCountry(int ID,string CountryName, string PhoneCode,string CountryCode)
        {

            this.ID = ID;
            this.CountryName = CountryName;
            this.PhoneCode = PhoneCode;
            this.CountryCode = CountryCode;
            Mode = enMode.eUpdateMode;

        }

        public static DataTable GetAllCountries() {
            return clsCountriesData.GetAllCountries();
        }


    }
}
