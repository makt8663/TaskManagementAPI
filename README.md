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
