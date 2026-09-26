using System;
using System.Linq;
using System.Data;
using Contacts_Management_BusinessLayer;

namespace Contacts_Test_Presentation
{
    internal class TestConsoleProject
    {
        //Contacts

        //En: A function to search for a contact in the database using its ID and return the object if found.
        //Ar: دالة للبحث عن جهة اتصال في قاعدة البيانات باستخدام مُعرِّفها، وإرجاع الكائن في حال العثور عليه
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

        //En: A function to return all contacts stored in the database.
        //Ar: دالة لإرجاع جميع جهات الاتصال المخزنة في قاعدة البيانات
        static void testGetAllContacts() 
        {
            DataTable dataAllContacts = clsContact.GetAllContactsFrom();

            Console.WriteLine("Contacts (ID , FullName , Phone , Email)info: \n");
            string FullName = "";

            foreach (DataRow Row in dataAllContacts.Rows) {
                FullName = $"{Row["FirstName"]} {Row["LastName"]}";
                Console.WriteLine($" {Row["ContactID"],-3} - NAME : {FullName,-20} | PHONE : {Row["Phone"],-15} | Email : {Row["Email"],-15}");
            }
            
        }

        //En: A function to check whether the contact exists in the database.
        //Ar: دالة للتحقق مما إذا كانت جهة الاتصال موجودة في قاعدة البيانات
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

        //En: A function to delete a contact by its ID.
        //Ar: دالة لحذف جهة اتصال باستخدام مُعرِّفها.
        static void testDeleteContactByID(int ID) {

            if (clsContact.IsContactExist(ID))
            {
                if (clsContact.DeleteContactByID(ID))
                {
                    Console.WriteLine($"\aThe contact with the ID [{ID}] has been deleted.");
                }
                else
                {
                    Console.WriteLine("\aAn error occurred while deleting the following contact. Please try again.");
                }
            }
            else {
                Console.WriteLine($"\aWe do not have a contact associated with that ID [{ID}] in our system.");
            }
        }

        //En: A function to add a new contact to the database.
        //Ar: دالة لإضافة جهة اتصال جديدة في قاعدة البيانات
        static void testAddNewContact() {

            // Edit the information yourself - قم بتعديل المعلومات بنفسك

            clsContact NewContact = new clsContact();

            NewContact.FirstName = "FirstName";
            NewContact.LastName = "LastName";
            NewContact.Email = "Email@example.com";
            NewContact.Phone = "+000000000";
            NewContact.DateOfBirth = new DateTime(2000,01,01,12,00,00);
            NewContact.CountryID = 1;
            NewContact.Address = "Any Think";
            NewContact.ImagePath = "";

            if (NewContact.Save())
            {
                Console.WriteLine("\nThe new contact has been successfully saved to the database, and here is the stored information:\n");
                Console.WriteLine($"ID: {NewContact.ID}");
                Console.WriteLine($"Name: {NewContact.FirstName} {NewContact.LastName}");
                Console.WriteLine($"Email: {NewContact.Email}");
                Console.WriteLine($"Phone: {NewContact.Phone}");
                Console.WriteLine($"DateOfBirth: {NewContact.DateOfBirth}");
                Console.WriteLine($"CountryID: {NewContact.CountryID}");
                Console.WriteLine($"Address: {NewContact.Address}");
                Console.WriteLine($"ImagePath: {NewContact.ImagePath}");
            }
            else {
                Console.WriteLine("\nAn error occurred while saving the new contact to the database... Please try again later.\n");
            }
        
        }
        
        //En: A function to update an existing contact in the database using its ID. 
        //Ar: دالة لتحديث جهة اتصال موجودة في قاعدة البيانات عن طريق المعرف الخاص بها
        static void testUpdateContactByID(int ID) 
        {
            // Edit the information yourself - قم بتعديل المعلومات بنفسك

            clsContact Contact = clsContact.Find(ID);

            if (Contact != null)
            {
                Contact.FirstName = "New-FirstName";
                Contact.LastName = "New-LastName";
                Contact.Email = "New-Email@example.com";
                Contact.Phone = "New-+000000";
                Contact.DateOfBirth = new DateTime(2001, 02, 02, 01, 00, 00);
                Contact.CountryID = 1;
                Contact.Address = "New-Address";
                Contact.ImagePath = "";

                if (Contact.Save())
                {
                    Console.WriteLine($"Contact information for the contact with ID [{ID}] has been successfully updated!");
                }
                else {
                    Console.WriteLine("An error occurred while updating the contact details. Please try again.");
                }
            }
            else {
                Console.WriteLine($"\aContact ID {ID} Is Not Found !\n");
            }


        }

        static void Main(string[] args)
        {
            //NOTE : Contacts Test

            //int contactID = 1;
            //testFindContactByID(contactID);
            //testIsContactExist(1);

            //testGetAllContacts();
            
            //testAddNewContact();

            //testUpdateContactByID(100); // This Return True - هذه تعمل بنجاح
            //testUpdateContactByID(500); // This Return False هذه لا يجب ان تعمل

            //testDeleteContactByID(8);
        }
    }
}
