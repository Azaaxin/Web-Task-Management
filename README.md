# ASP.NET Core "task" manager

![C# Task manager](https://github.com/Azaaxin/Web-Task-Management/blob/main/taskmanager.jpg?raw=true)

This is my first project in ASP.NET using C#. The Website is storing all the information shown in the picture above in a database with full (CRUD) functionality.

I styled the app with Bootstrap and Materialize. 

Model for database:

        public int Id { get; set; }
        public string Title { get; set; } // Title of the Task
        public bool Status { get; set; } // The current status of the task
        public string Version { get; set; } // Which version this task apply to
        public int Priority { get; set; } // 0 = Not set, 1 = Low, 2 = Medium, 3 = High
        public string Deadline { get; set; } // Set the date and time for deadline
        public string Date { get; set; } // When the task was issued.

This is just a demo, for myself to learn how to use the language.


The project was made in one evening and there might be few bugs with the code, but the only one I have found so far is listing the status of a task in "Details". 
*Ludvig Olausson*
