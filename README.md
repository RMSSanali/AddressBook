# AddressBook

A desktop address-book application built with C# and Windows Forms. The application allows users to manage contact information, search for contacts, and store data in a text file.

This project was created as part of a C# and Windows Forms academic assignment.

## Features

- Add new contacts
- Update existing contacts
- Delete contacts
- Search contacts by name or city
- Display contacts in a table
- Select a contact to view and edit its details
- Prevent duplicate contact names
- Store contact data in a text file
- Generate a unique identifier for each contact

## Contact Information

Each contact can contain:

- Name
- Street address
- Postal code
- City
- Telephone number
- Email address

## Technologies

- C#
- .NET 8
- Windows Forms
- Visual Studio
- Text-file storage
- LINQ
- GUID-based contact identifiers

## Project Structure

AddressBook/
├── Classes/
│   └── Contact.cs
├── Properties/
├── AddressBook.cs
├── AddressBook.Designer.cs
├── AddressBook.resx
├── AddressBook.csproj
├── AddressBook.sln
├── AddressBook.txt
└── Program.cs

## How to Run

### Requirements

- Windows
- .NET 8 SDK
- Visual Studio 2022 or later
- Windows Forms development workload

### Steps

1. Clone the repository:

   ```bash
   git clone https://github.com/RMSSanali/AddressBook.git

   Open `AddressBook.sln` in Visual Studio.

2. Build the solution.

3. Run the application using Visual Studio.

## How to Use

1. Enter the contact information in the input fields.
2. Select **Add** to save a new contact.
3. Select a contact from the table to display its information.
4. Edit the contact details and select **Update** to save changes.
5. Select a contact and choose **Delete** to remove it.
6. Enter a name or city in the search field and select **Search**.
7. Use **Clear** to reset the input fields.

## Data Storage

Contact information is stored in a plain-text file. Each contact is saved as a separate line, with the individual values separated by a pipe character (`|`).

The application loads saved contacts when it starts and writes changes back to the file when contacts are added, updated, or deleted.

## Academic Context

The purpose of this project was to practise:

- Object-oriented programming in C#
- Windows Forms user-interface development
- Event-driven programming
- Reading and writing text files
- Working with collections and LINQ
- Implementing search and filtering functionality
- Managing CRUD operations

## Future Improvements

Possible improvements include:

- Replacing text-file storage with a database
- Adding input validation for email addresses and telephone numbers
- Using a configurable data-file path
- Adding confirmation dialogs before deleting contacts
- Improving accessibility and responsive layout
- Adding automated tests
- Separating the user interface, business logic, and data-access code

## Author

Created by [RMSSanali](https://github.com/RMSSanali).

## License

This project was created for educational purposes.
