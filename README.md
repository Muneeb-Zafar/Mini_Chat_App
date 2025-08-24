🗨️ Mini Chat App in C#
📌 Description

This repository contains a simple console-based chat application built in C# using TcpListener and TcpClient.
It demonstrates basic client-server communication with support for asynchronous messaging using async and await.

The project is a great starting point for learning:

TCP/IP networking in C#

Asynchronous programming (async/await)

Socket-based client-server models

⚙️ Features

Multiple clients can connect to the server

Asynchronous communication (non-blocking I/O)

Simple console interface

Easy to extend (add usernames, commands, GUI later)

🚀 Getting Started
🔹 Prerequisites

.NET SDK
 (>= .NET 6.0 recommended)

Git

🔹 Clone the Repository
git clone https://github.com/VastScientist69/Mini_Chat_App/blob/main/README.md
cd csharp-mini-chat-app

🔹 Build and Run
1. Start the Chat Server
cd ChatServer
dotnet run


(Default port: 5000)

2. Start a Chat Client

Open another terminal:

cd ChatClient
dotnet run


(Connects to localhost:5000)

👉 You can start multiple clients to test group chatting.

📂 Project Structure
csharp-mini-chat-app/
│── ChatServer/       # Server project
│   └── Program.cs
│   └── ChatServer.csproj
│
│── ChatClient/       # Client project
│   └── Program.cs
│   └── ChatClient.csproj
│
├── .gitignore
└── README.md

🛠️ To-Do / Improvements

Add usernames instead of anonymous messages

Implement private messages

Add logging

Build a GUI (WPF/WinForms) version

📜 License

This project is licensed under the MIT License – feel free to use and modify it.  
