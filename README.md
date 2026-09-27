<img width="1280" height="300" alt="Contacts Management project banner" src="https://github.com/user-attachments/assets/04aff6af-328a-4869-bb78-5b38b9b9edfc" />
<h1 align="center">Contacts Management — 3-Tier Architecture</h1>

<p align="center">
  A C# Windows desktop learning project for managing contacts and looking up country data with ADO.NET and SQL Server.
</p>

<p align="center">
  <img alt="C#" src="https://img.shields.io/badge/C%23-language-512BD4" />
  <img alt=".NET Framework 4.8" src="https://img.shields.io/badge/.NET_Framework-4.8-512BD4" />
  <img alt="SQL Server" src="https://img.shields.io/badge/Database-SQL_Server-CC2927" />
  <img alt="Architecture" src="https://img.shields.io/badge/Architecture-3--Tier-2F6F9F" />
</p>

## Overview

Contacts Management separates database access, business objects, and presentation into distinct projects. It demonstrates contact create, read, update, and delete (CRUD) operations and country lookup functionality against SQL Server. Two presentation projects are included: a console-based test harness and a Windows Forms application shell.

> **Current project status:** The console project contains callable database examples, but its sample calls are commented out by default. The WinForms project launches a main form, but its forms are currently scaffolding and are not yet connected to contact or country operations. Country operations currently provide listing, lookup, and existence checks; country create, update, and delete are not implemented.

## Architecture & Design

The solution follows a 3-tier / N-layer design. Both presentation projects reference the Business Logic Layer (BLL), which delegates persistence to the Data Access Layer (DAL). The DAL executes SQL commands against SQL Server.

```text
+----------------------+       +----------------------+       +----------------------+
| Presentation Layer   | ----> | Business Logic Layer | ----> | Data Access Layer    |
| Console test harness |       | Contact/Country      |       | ADO.NET queries      |
| Windows Forms shell  |       | objects and methods  |       | connection settings  |
+----------------------+       +----------------------+       +----------+-----------+
                                                                         |
                                                                         v
                                                              +----------------------+
                                                              | SQL Server           |
                                                              | ContactsDB1          |
                                                              +----------------------+
```

| Layer | Project(s) | Responsibility |
| --- | --- | --- |
| Presentation (UI) | `Contacts_Test_Presentation`, `WindowsFormContacts_Management_Presentation` | Console examples and the WinForms application entry point/forms. |
| Business Logic (BLL) | `Contacts_Management_BusinessLayer` | `clsContact` and `clsCountry` objects and operations; mediates between UI callers and data access. |
| Data Access (DAL) | `Contacts_Management_DataLayer` | Opens SQL Server connections and executes contact and country queries using ADO.NET. |
| Database | SQL Server | Stores contacts and country reference data. The repository includes a database backup artifact named `ContactsDB1` in its root. |

## Features & Technical Highlights

### Contact management

- Retrieve a contact by ID and list contacts.
- Add, update, and delete contacts through the BLL/DAL APIs.
- Store contact details including name, email, phone, address, date of birth, country ID, and optional image path.

### Country lookup

- List countries and find a country by ID or name.
- Check country existence by ID, name, or country code.
- Country records are lookup/reference data in the current implementation; country CRUD is not available.

### ADO.NET and data handling

- Uses `SqlConnection`, `SqlCommand`, and `SqlDataReader` for SQL Server access.
- Uses command parameters in many queries and in contact insert/update operations. **Not every operation is parameterized:** contact deletion currently builds its SQL with an interpolated ID and should be parameterized before use with untrusted input.
- Database exceptions are caught in the data layer, and some methods return a failure value. Error reporting is limited; some catches suppress exception details.
- Business-level input validation is not yet comprehensive and should be added before production use.

## Repository Structure

```text
Contacts-Management-3Tier/
├── Contacts_Management_BusinessLayer/
│   ├── Contact.cs                         # Contact business object and operations
│   ├── Country.cs                         # Country lookup business object
│   └── Contacts_Management_BusinessLayer.csproj
├── Contacts_Management_DataLayer/
│   ├── ContactsData.cs                    # Contact SQL operations
│   ├── CountriesData.cs                   # Country SQL queries and lookups
│   ├── clsDataAccessSettings.cs           # Active database connection string
│   └── Contacts_Management_DataLayer.csproj
├── Contacts_Test_Presentation/
│   ├── TestConsoleProject.cs              # Console database examples
│   └── Contacts_Test_Presentation.csproj
├── WindowsFormContacts_Management_Presentation/
│   ├── MainForm.cs                        # WinForms main form shell
│   ├── frmAdd_EditContact.cs              # Add/edit form shell
│   ├── Program.cs                         # WinForms entry point
│   └── WindowsFormContacts_Management_Presentation.csproj
├── ContactsDB1                            # SQL Server backup artifact (no extension)
├── Digram.png                             # Repository diagram image
└── Contacts-Management-3Tier.slnx         # Solution file
```

All projects currently target **.NET Framework 4.8**. The root `.slnx` currently contains an empty solution definition, so open and build the project files individually in Visual Studio unless you add the projects to a solution.

## Getting Started

### Prerequisites

- Windows with **.NET Framework 4.8** (Developer Pack/Targeting Pack for building).
- **Visual Studio** with the .NET desktop development workload; Visual Studio 2019 or later is suitable.
- **SQL Server** (local or remote instance) and SQL Server Management Studio (SSMS) for restoring the database backup.
- Access to a SQL Server login or Windows authentication account with permissions to the database.

### 1. Clone the repository

```powershell
git clone https://github.com/ali-talal-ibrahem/Contacts-Management-3Tier.git
cd Contacts-Management-3Tier
```

### 2. Restore or prepare the database

The repository root contains a SQL Server backup artifact named `ContactsDB1` (without a file extension); no standalone `.sql` schema script is included.

1. Open SSMS and connect to your SQL Server instance.
2. Restore the included artifact using **Databases > Restore Database > Device**, and select the repository's `ContactsDB1` file. If SSMS does not recognize the file without an extension, make a copy named `ContactsDB1.bak` and select the copy.
3. Restore the database with the name **`ContactsDB1`**, or adjust the connection string in the next step to match your chosen database name.
4. Confirm that the SQL Server account used by the application has permission to access the restored database.

If the backup cannot be restored in your SQL Server version/environment, create a compatible database with the expected `Contacts` and `Countries` tables before running the application.

### 3. Configure the database connection

The checked-in `App.config` files currently specify the .NET runtime only; the active connection string is in `Contacts_Management_DataLayer/clsDataAccessSettings.cs`. Update that value to match your SQL Server instance and authentication method. For example, for a local instance using Windows authentication:

```csharp
static public string ConnectionString = "Server=.;Database=ContactsDB1;Integrated Security=True";
```

For SQL authentication, use your own server, login, and password. Do not commit real credentials to source control. The file `clsDataAccessSettings - For You.cs` is an unused template; the application uses `clsDataAccessSettings.cs`.

### 4. Build and run

1. Open the `.csproj` files in Visual Studio (or create a solution and add all four projects). Build the console and WinForms projects; their project references pull in the BLL and DAL dependencies.
2. To run the **console examples**, set `Contacts_Test_Presentation` as the startup project and start debugging. The sample invocations in `TestConsoleProject.Main` are commented out by default; uncomment the example operation(s) you want to run, then rebuild and start the project. This is a test harness rather than an interactive menu-driven console UI.
3. To run the **WinForms shell**, set `WindowsFormContacts_Management_Presentation` as the startup project and start debugging. The main form currently opens without contact-management actions wired up.

## Application Workflow

### Console test harness

The console project contains examples for contact lookup/listing/creation/update/deletion and country listing/lookup/existence checks. Edit the sample data or IDs in `TestConsoleProject.cs`, uncomment the desired call in `Main`, and run the project after configuring SQL Server access. Use a development database because these operations can change or delete records.

### Windows Forms

The WinForms entry point opens `MainForm`. The add/edit contact form and main form are currently presentation scaffolding; they do not yet call the BLL. Wiring up data grids, input controls, validation, and save/delete actions is future work.

## Future Enhancements

- Build a functional WinForms workflow and connect forms to the BLL.
- Add country create, update, and delete operations if country maintenance is required.
- Move connection strings into configuration or secure secret storage; remove embedded credentials.
- Parameterize every SQL command and improve structured error logging and user-facing feedback.
- Add comprehensive input validation and automated tests.
- Consider asynchronous database access (`async`/`await`), an EF Core implementation, or an additional WPF presentation client.

## License

No `LICENSE` file is currently included. Until the repository owner adds one, the project has no explicit open-source license; reuse and redistribution are subject to the default copyright laws. Add a license file (for example, MIT) to formally permit open-source use.
