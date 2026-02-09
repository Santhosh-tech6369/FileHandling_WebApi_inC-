# Student Registration Web API (.NET 8)

A RESTful Web API built using ASP.NET Core (.NET 8) for managing student registrations with full CRUD operations and support for file uploads (Audio, Video, PDF).

## 🚀 Features
- Create, Read, Update, Delete (CRUD) student records
- Upload and download files:
  - 📄 PDF
  - 🎵 Audio
  - 🎥 Video
- RESTful API design
- Swagger UI for API testing
- Clean project structure
- Proper error handling

## 🛠 Tech Stack
- ASP.NET Core Web API (.NET 8)
- C#
- Entity Framework Core
- SQL Server (or your DB name)
- Swagger / OpenAPI
- Git & GitHub

## 📂 API Endpoints (Sample)
- `GET /api/students` – Get all students  
- `GET /api/students/{id}` – Get student by ID  
- `POST /api/students` – Create student  
- `PUT /api/students/{id}` – Update student  
- `DELETE /api/students/{id}` – Delete student  
- `POST /api/students/upload` – Upload files (PDF, audio, video)

## ▶️ Run Locally

1. Clone the repository:
   ```bash
   git clone https://github.com/YOUR-USERNAME/FileHandling_WebApi_inC-.git
