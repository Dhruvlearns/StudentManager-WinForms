# StudentManager - WinForms CRUD Application

This is a simple Windows Forms (WinForms) application that allows you to perform **Create, Read, Update, and Delete (CRUD)** operations on student records.

The project is built using C# and connected to a database using Entity Framework.

---

## 📸 Screenshots

### 📝 Student Registration Form
![Student Registration Form]
![image](https://github.com/user-attachments/assets/6f4c8ada-5b46-459b-ac8b-0c7897720956)



### 📋 Student Records Table
![Student Records Table]
![image](https://github.com/user-attachments/assets/053fb383-fdc4-4175-8991-bac0ab159627)

---

## 🎯 Features

- Add new student with:
  - Name
  - Address
  - Mobile Number
  - Gender
  - Course selection
- View all registered students in a table
- Update existing student details
- Delete student records
- Auto-generate unique `GUID` for each student

---

## 🛠 Technologies Used

- **C#**
- **WinForms**
- **Entity Framework (Database First)**
- **SQL Server**

---

## 🗂 Database Schema

The project uses a table named `Student_information` with the following fields:

- `Id` (GUID)
- `Name` (string)
- `Address` (string)
- `Mobile` (string)
- `Gender` (string)
- `CourseId` (int, foreign key)

---

## 🚀 Getting Started

1. Clone the repository:
   ```bash
  https://github.com/codecrafters-io/build-your-own-x.git
