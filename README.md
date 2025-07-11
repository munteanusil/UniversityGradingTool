Why I Built This ;) : 

I developed this project initially to help someone in university complete a student grading system assignment. Through this, I also enhanced my own skills in desktop app development, multi-layered architecture, and database handling with MySQL. I'm sharing this as part of my personal portfolio to showcase practical .NET development.”
🧠 About the Project
This application was originally built to help a university student complete a real-world academic project for managing student records and grades. Beyond that, it served as an opportunity to apply best practices in C# desktop development with a layered architecture and MySQL integration.

It includes modules for managing:

- Students
- Subjects (Disciplines)
-  Grades
-  Average calculation & CSV export

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

 Main Features
✅ Student Management
✅ Subject (Discipline) Management
✅ Grade Recording and Editing
✅ Filtering by student or subject
✅ Calculating averages and status (Passed/Failed)
✅ Export to CSV

 UI Modules
Form	Functionality
MainForm	Navigation to all features
StudentForm	CRUD operations for students
DisciplinaForm	CRUD operations for subjects
NoteForm	Add/edit grades, filter, calculate average
AddStudentForm	Add a new student
AddDisciplinaForm	Add a new subject

 Setup Instructions
Clone this repo:

bash
git clone https://github.com/munteanusil/UniversityGradingTool.git
Open the .sln file in Visual Studio

Ensure you have MySQL running and create the DB with:

sql
CREATE DATABASE catalog_note;
USE catalog_note;
-- Then create tables: studenti, discipline, note
Update the database connection string in ConfigurationHelper.cs

Build and run the project in Visual Studio 
<img width="797" height="425" alt="image" src="https://github.com/user-attachments/assets/23ed2986-85ac-455b-ad0d-7a700fe0e893" />
<img width="646" height="421" alt="image" src="https://github.com/user-attachments/assets/cb47f71a-1768-4044-96a9-003d43a51c08" />
<img width="637" height="407" alt="image" src="https://github.com/user-attachments/assets/dd089aa6-8dcf-4785-a5b1-6121221a7f19" />
<img width="812" height="447" alt="image" src="https://github.com/user-attachments/assets/df265c8c-472e-4878-b86c-3489f497c87b" />
<img width="975" height="653" alt="image" src="https://github.com/user-attachments/assets/7b09cfd6-6e9f-44eb-9fb4-e8ad25b5dc08" />
csv File:
<img width="959" height="375" alt="image" src="https://github.com/user-attachments/assets/300d0c9f-46ee-489a-9c82-09b0f7ec64ac" />




