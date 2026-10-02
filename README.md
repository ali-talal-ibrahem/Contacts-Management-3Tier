<img width="1920" height="1080" alt="Contacts" src="https://github.com/user-attachments/assets/78e50851-4ebf-487e-9968-41fe9db86f93" />

<h1 align="center">Contacts Management System</h1>

<p align="center">A C# Windows desktop application for managing contacts.</p>
<p align="center">
  <img alt="C#" src="https://img.shields.io/badge/C%23-language-512BD4" />
  <img alt=".NET Framework 4.8" src="https://img.shields.io/badge/.NET_Framework-4.8-512BD4" />
  <img alt="SQL Server" src="https://img.shields.io/badge/Database-SQL_Server-CC2927" />
  <img alt="Architecture" src="https://img.shields.io/badge/Architecture-3--Tier-2F6F9F" />
</p>

## Overview

Contacts Management is a three-tier desktop application for managing SQL Server contact records. The Windows Forms client supports creating, viewing, editing, and deleting contacts, and displaying the countries reference table. A separate console project contains manually invoked examples for business-layer operations. All projects target **.NET Framework 4.8**. The repository includes a SQL Server backup named `ContactsDB1` at its root.

## Features

- Browse contacts in a data grid and see the displayed record count.
- Add, edit, and delete contacts.
- Store names, email, phone, address, date of birth, country, and an optional image path.
- Browse countries and select a country when adding or editing a contact. Country CRUD is not implemented.
- Console examples cover contact lookup/list/add/update/delete and country list/lookup/existence checks. Calls in `TestConsoleProject.Main` are commented out by default; edit sample values and uncomment the desired call. This is a manual test harness, not an interactive menu or automated test suite.

Photos are stored as file paths rather than image data. Keep files accessible at their saved paths.

## Architecture

```text
Windows Forms client ─┐
                      ├──> Business Logic Layer ───> Data Access Layer ───> SQL Server
Console examples ─────┘
```

| Layer | Project | Responsibility |
| --- | --- | --- |
| Presentation | `WindowsFormContacts_Management_Presentation` | Splash screen, contact grid, add/edit form, country list. |
| Examples | `Contacts_Test_Presentation` | Console examples calling business operations. |
| Business logic | `Contacts_Management_BusinessLayer` | Contact and country models and operations. |
| Data access | `Contacts_Management_DataLayer` | ADO.NET queries and connection settings. |

The presentation projects reference the business layer, which references the data layer.

## Repository layout

```text
Contacts-Management-3Tier/
├── Contacts_Management_BusinessLayer/
├── Contacts_Management_DataLayer/
├── Contacts_Test_Presentation/             # Console examples and solution
├── WindowsFormContacts_Management_Presentation/
├── ContactsDB1                              # SQL Server backup
├── Digram.png
└── Contacts-Management-3Tier.slnx            # Empty root solution
```

The solution containing all four projects is `Contacts_Test_Presentation/Contacts-Management-3Tier.slnx`. The root `.slnx` is empty. Open the nested solution or open an individual project file in Visual Studio.

## Requirements

- Windows and Visual Studio with the **.NET desktop development** workload.
- **.NET Framework 4.8 Developer Pack**.
- SQL Server and an account with access to the application database. SSMS is recommended for restoring the backup.

## Setup and run

### 1. Open the solution

Open `Contacts_Test_Presentation/Contacts-Management-3Tier.slnx` in Visual Studio, or open the Windows Forms or console `.csproj` directly.

### 2. Restore the database

The root contains a SQL Server backup named `ContactsDB1` without a file extension. No standalone schema script is included.

1. In SSMS, connect to SQL Server and restore `ContactsDB1` using **Databases > Restore Database > Device**. If needed, restore a copy renamed to `ContactsDB1.bak`.
2. Restore the database as `ContactsDB1`, or update the connection string to match your database name.
3. Ensure the SQL Server account used by the application can access the database.

The application queries `Contacts` and `Countries`; another database must provide compatible tables and columns.

### 3. Configure database access

The active connection string is hard-coded in `Contacts_Management_DataLayer/clsDataAccessSettings.cs`; `App.config` does not contain a connection string. Set it for your SQL Server instance and authentication method. Example for local Windows authentication:

```csharp
static public string ConnectionString = "Server=.;Database=ContactsDB1;Integrated Security=True";
```

For SQL authentication, use your own values and do not commit credentials. `clsDataAccessSettings - For You.cs` is a template, not the active settings class.

### 4. Run the Windows Forms app

Set `WindowsFormContacts_Management_Presentation` as the startup project and build/run. A splash screen appears before the main window. Switch between contacts and countries; use **Add New Contact** or right-click a contact to edit/delete it.

### 5. Run console examples

Set `Contacts_Test_Presentation` as the startup project. Uncomment the desired call in `TestConsoleProject.Main`, update sample values or IDs, then build and run. Use a development database for operations that modify or delete records.

## Implementation notes

- Input validation and user-facing database error reporting are limited; this is a learning project.
- Contact deletion currently interpolates the ID into SQL instead of using a parameter. Parameterize it before accepting untrusted input.
- The connection string is stored in source code. Move credentials to protected configuration or a secret store before sharing or deploying.
- No automated test project is included; console examples are manual.

## License

No `LICENSE` file is included, so there is no explicit open-source license. Add a license file to define reuse and redistribution terms.
