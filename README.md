<img width="1045" height="706" alt="Screenshot 2026-03-06 132726" src="https://github.com/user-attachments/assets/effc9c74-d5da-4068-88c1-23f32f7f99ff" />
<img width="890" height="687" alt="Screenshot 2026-03-06 132856" src="https://github.com/user-attachments/assets/4b8b01cf-cc43-4e34-987f-9280b9857680" />
<img width="1333" height="717" alt="Screenshot 2026-03-06 132915" src="https://github.com/user-attachments/assets/27b951c6-ba80-4f08-bf5e-c8131634241e" />
<img width="835" height="866" alt="Screenshot 2026-03-06 132927" src="https://github.com/user-attachments/assets/ac942af0-e1c3-4412-b6f1-811ac77c7b48" />
<img width="775" height="811" alt="Screenshot 2026-03-06 133014" src="https://github.com/user-attachments/assets/73a340d8-8d08-47aa-9c8e-d537ab4e3ea1" />
<img width="611" height="823" alt="Screenshot 2026-03-06 133026" src="https://github.com/user-attachments/assets/6ec48166-0132-4622-b451-4b757d29ef3a" />
<img width="633" height="880" alt="Screenshot 2026-03-06 133034" src="https://github.com/user-attachments/assets/032ea955-b040-428e-9157-4d161e3012b9" />
<img width="728" height="846" alt="Screenshot 2026-03-06 133048" src="https://github.com/user-attachments/assets/bac5f4a1-63f0-4c23-af0b-bf8aab57a7fb" />
<img width="1866" height="969" alt="Screenshot 2026-03-06 133111" src="https://github.com/user-attachments/assets/48462ba2-d2e2-4dd3-8af0-dc1079dfd836" />
<img width="1917" height="930" alt="Screenshot 2026-03-06 133158" src="https://github.com/user-attachments/assets/aaaca0cf-a7f8-40a5-88f1-0f3d89a10e57" />
<img width="1896" height="958" alt="Screenshot 2026-03-06 133210" src="https://github.com/user-attachments/assets/25fc5290-d77d-4351-9bdd-8befc6aa9f6b" />

# TaskManagementAPI
Task Manager Application

Tech Stack
- ASP.NET Core Web API
- React
- Entity Framework Core
- JWT Authentication

Features
- User Registration
- Login Authentication
- Add Tasks
- Edit Tasks
- Delete Tasks
- User-specific task management

Run Backend
dotnet run

Run Frontend
npm install
npm run dev

##Project sturcture: 

task-manager-app
│
├── backend
│   ├── Controllers
│   │   ├── AuthController.cs
│   │   └── TaskController.cs
│   │
│   ├── Models
│   │   ├── User.cs
│   │   └── TaskItem.cs
│   │
│   ├── Data
│   │   └── ApplicationDbContext.cs
│   │
│   ├── Services
│   │   └── JwtService.cs
│   │
│   ├── Program.cs
│   └── appsettings.json
│
├── frontend
│   ├── src
│   │   ├── pages
│   │   │   ├── Login.jsx
│   │   │   ├── Register.jsx
│   │   │   └── Dashboard.jsx
│   │   │
│   │   ├── components
│   │   │   └── TaskList.jsx
│   │   │
│   │   ├── services
│   │   │   └── api.js
│   │   │
│   │   ├── App.jsx
│   │   └── main.jsx
│   │
│   └── package.json
│
├── README.md
└── .gitignore



##The application is in 2 parts. TaskManagementAPI contains the API code with all the endpoints viz. Register User, Login, Add Task, Delete Task, etc. 
The API is secured with the JWT token authorization for the endpoints.

##2nd part of the code is the TaskManagerUI.zip file, which contains the ReactJS files as in UI of the application. 
This application works for both i.e. API as well as Webapplication for the user. Even for Webapp, application shows Register and Login functionality. Once the user login successfully, JWT Token is stored on server side and passed on to next function calls. Once user logins, he is taken to Dashboard where he can see the tasks created by him to which he can mark as complete or delete. Also, he can add more tasks on his name if wanted. And finally there is a logout button by which user can logout with closing his session.

##In Migrations folder, there are migration file, to which developer just need to import the EntityframeworkCore dependencies and once done, update-database would create the database automatically in your connected database which you can configure in appconfig.cs (Connection string).
