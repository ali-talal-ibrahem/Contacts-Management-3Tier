using System;
using System.Linq;
using System.Data;
using Contacts_Management_BusinessLayer;

namespace Contacts_Test_Presentation
{
    internal class TestConsoleProject
    {

        static void testFindContactByID(int ID)
        { 
            clsContact contact = clsContact.Find(ID);

            if (contact == null)
            {
                Console.WriteLine("Contact {0} was not found.",ID);
                return;
            }

            Console.WriteLine("ID: " + contact.ID);
            Console.WriteLine("First Name: " + contact.FirstName);
            Console.WriteLine("Last Name: " + contact.LastName);
            Console.WriteLine("Email: " + contact.Email);
            Console.WriteLine("Phone: " + contact.Phone);
            Console.WriteLine("Address: " + contact.Address);
            Console.WriteLine("Date Of Birth: " + contact.DateOfBirth);
            Console.WriteLine("Country ID: " + contact.CountryID);
            Console.WriteLine("Image Path: " + contact.ImagePath);
        }

        static void testGetAllContactsFromDataBase() 
        {
            DataTable dataAllContacts = clsContact.GetAllContactsFromDataBase();

            Console.WriteLine("Contacts info: \n");

            foreach (DataRow Row in dataAllContacts.Rows) {
                Console.WriteLine($"[{Row["ContactID"]}] - {Row["FirstName"]} {Row["LastName"]}");
            }
            
        }

        static void testIsContactExist(int ID)
        {
            if (!clsContact.IsContactExist(ID))
            {
                Console.WriteLine($"The contact with ID [{ID}] does not exist in the system!");
                return;
            }

            clsContact ContactFound = clsContact.Find(ID);

            Console.WriteLine($"The contact with ID [{ID}] exists in the system, and here is their information:\n");

            Console.WriteLine("Full Name: " + ContactFound.FirstName +" "+ ContactFound.LastName);
            Console.WriteLine("Email: " + ContactFound.Email);
            Console.WriteLine("Phone: " + ContactFound.Phone);
            Console.WriteLine("Address: " + ContactFound.Address);
            Console.WriteLine("Date Of Birth: " + ContactFound.DateOfBirth);
            Console.WriteLine("Country ID: " + ContactFound.CountryID);
            Console.WriteLine("Image Path: " + ContactFound.ImagePath);

        }


        static void Main(string[] args)
        {
            //Contacts Test :

            //int contactID = 1;
            //testFindContactByID(contactID);
            //testGetAllContactsFromDataBase();
            //testIsContactExist(6);


        }
    }
}
