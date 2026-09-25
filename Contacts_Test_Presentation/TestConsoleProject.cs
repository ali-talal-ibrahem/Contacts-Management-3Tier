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

        static void Main(string[] args)
        {
            //int contactID = 1;
            //testFindContactByID(contactID);

            testGetAllContactsFromDataBase();
        }
    }
}
