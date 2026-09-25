namespace Contacts_Management_DataLayer
{

#warning A very, very important note:

    /*Before replacing your information, you must change the class name
    from [ clsDataAccessSettings_ForYou ]  to [ clsDataAccessSettings ] so that the project works perfectly.*/

    // FIX : Replace the phrase "[YOUR_SERVER_NAME]" with your actual server name.
    // FIX : Replace the phrase "[YOUR_PASSWORD]" with your actual password.


    static class clsDataAccessSettings_ForYou
    //           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    {
        static public string ConnectionString = "Server=.;Database=ContactsDB;User Id=[YOUR_SERVER_NAME];Password=[YOUR_PASSWORD]";
        //                                                                            ^^^^^^^^^^^^^^^^^^          ^^^^^^^^^^^^^^^
    }
}
