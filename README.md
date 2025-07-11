Why I Built This
“I developed this project initially to help someone in university complete a student grading system assignment. Through this, I also enhanced my own skills in desktop app development, multi-layered architecture, and database handling with MySQL. I'm sharing this as part of my personal portfolio to showcase practical .NET development.”
🧠 About the Project
This application was originally built to help a university student complete a real-world academic project for managing student records and grades. Beyond that, it served as an opportunity to apply best practices in C# desktop development with a layered architecture and MySQL integration.

It includes modules for managing:

🎓 Students

📚 Subjects (Disciplines)

📝 Grades

📊 Average calculation & CSV export

🏗️ Architecture Overview
The application follows a layered architecture:

UI Layer: Windows Forms for user interaction

Data Layer: MySQL access via DbConnectorHelper and repository classes

Model Layer: POCO classes for Student, Disciplina, Nota

Utils Layer: Helpers like ConfigurationHelper for config handling

⚙️ Technologies Used
Component	Technology
Framework	.NET Framework 4.8
Language	C#
UI	Windows Forms (WinForms)
Database	MySQL (Workbench 8.0 CE)
DB Connector	MySql.Data (via NuGet)
Export Format	CSV (via StreamWriter in C#)

🧩 Database Schema
Database: catalog_note
Tables:

studenti – student details

discipline – subject information

note – grades, linked via foreign keys to students and disciplines

Relationships:

One student → many grades

One subject → many grades
Foreign keys are enforced with ON DELETE CASCADE.

📺 Main Features
✅ Student Management
✅ Subject (Discipline) Management
✅ Grade Recording and Editing
✅ Filtering by student or subject
✅ Calculating averages and status (Passed/Failed)
✅ Export to CSV

🖼️ UI Modules
Form	Functionality
MainForm	Navigation to all features
StudentForm	CRUD operations for students
DisciplinaForm	CRUD operations for subjects
NoteForm	Add/edit grades, filter, calculate average
AddStudentForm	Add a new student
AddDisciplinaForm	Add a new subject

🛠️ Setup Instructions
Clone this repo:

bash
Copiază
Editează
git clone https://github.com/munteanusil/UniversityGradingTool.git
Open the .sln file in Visual Studio

Ensure you have MySQL running and create the DB with:

sql
Copiază
Editează
CREATE DATABASE catalog_note;
USE catalog_note;
-- Then create tables: studenti, discipline, note
Update the database connection string in ConfigurationHelper.cs

Build and run the project in Visual Studio
