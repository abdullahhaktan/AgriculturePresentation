# 🌾 Agriculture Management System – ASP.NET Core MVC + EF Core + Identity Based Admin Platform

> ASP.NET Core MVC, Entity Framework Core ve Identity kullanılarak geliştirilmiş modern tarım yönetim sistemi  
> A modern agriculture management platform built with ASP.NET Core MVC, Entity Framework Core and Identity

[![.NET](https://img.shields.io/badge/.NET-ASP.NET_Core-512bd4?logo=dotnet)](https://dotnet.microsoft.com/)
[![ORM](https://img.shields.io/badge/ORM-Entity_Framework_Core-6C2DBE.svg)](https://learn.microsoft.com/ef/core/)
[![Database](https://img.shields.io/badge/Database-SQL_Server-CC2927.svg)](https://www.microsoft.com/sql-server)
[![Auth](https://img.shields.io/badge/Auth-ASP.NET_Identity-blue.svg)](https://learn.microsoft.com/aspnet/core/security/authentication/identity)
[![Validation](https://img.shields.io/badge/Validation-FluentValidation-green.svg)](https://fluentvalidation.net/)
[![Language](https://img.shields.io/badge/Language-C%23-blue.svg)](https://learn.microsoft.com/dotnet/csharp/)

---

## 🚀 Özellikler / Features

| 🇹🇷 Türkçe | 🇬🇧 English |
|-----------|------------|
| Identity ile güvenli kullanıcı yönetimi | Secure user management via Identity |
| Admin panel destekli CRUD işlemleri | Admin panel based CRUD operations |
| FluentValidation ile doğrulama sistemi | Model validation with FluentValidation |
| Entity Framework Core veri yönetimi | EF Core database management |
| Katmanlı mimari yapı | Layered architecture |
| Rol tabanlı yetkilendirme | Role-based authorization |
| SQL Server veri tabanı | SQL Server integration |

---

## 💻 Proje Hakkında / About the Project

Bu proje **tarım hizmetlerini yönetmek**, duyurular yayınlamak, ekip üyelerini düzenlemek ve iletişim bilgilerini yönetmek için geliştirilmiştir.

This system enables management of agriculture services, announcements, team members and contact information through an admin panel interface.

---

## 🔐 Identity & Authorization Architecture

Projede **ASP.NET Core Identity** kullanılmıştır:

✔ Login / Logout sistemi  
✔ Role-based authorization  
✔ Secure password infrastructure  
✔ Admin / User role separation  

Provides enterprise-ready authentication infrastructure.

---

## 🧩 CRUD Yönetim Modülleri / CRUD Modules

Admin panel üzerinden aşağıdaki modüller yönetilmektedir:

✔ Announcements  
✔ Services  
✔ Team Members  
✔ Address & Contact Information  

Provides full administrative lifecycle management.

---

## 🧪 Validation Architecture

Projede **FluentValidation** kullanılmıştır:

✔ Required field validation  
✔ Minimum character validation  
✔ Date validation  
✔ User-friendly validation messages  

Ensures strong input validation pipeline.

---

## 🏗️ Mimari / Architecture

```
AgricultureManagementSystem/
├── Controllers/
│
├── Models/
│
├── ViewModels/
│
├── Validators/
│
├── DataAccess/
│
├── Identity/
│
├── Views/
│
└── wwwroot/
```

Layered structure sayesinde sürdürülebilir ve genişletilebilir mimari sağlanmıştır.

---

## 🛠️ Kullanılan Teknolojiler / Tech Stack

| Layer | Technology |
|------|------------|
| Backend | ASP.NET Core MVC |
| ORM | Entity Framework Core |
| Authentication | ASP.NET Identity |
| Validation | FluentValidation |
| Database | SQL Server |
| UI Engine | Razor View Engine |
| Language | C# |

---

## ⚙️ Kurulum / Setup

### Gereksinimler / Requirements

- .NET SDK
- SQL Server
- Visual Studio 2022+

---

### Adımlar / Steps

```bash
git clone https://github.com/username/AgricultureManagementSystem
cd AgricultureManagementSystem
```

### Veritabanı Migration

```
Update-Database
```

### Connection String Güncelle

```
Server=YOUR_SERVER;
Database=DbAgriculture;
Trusted_Connection=True;
Encrypt=True;
TrustServerCertificate=True;
```

### Projeyi Çalıştır

```
dotnet run
```

---

## 📊 Proje Vizyonu / Project Vision

Bu proje aşağıdaki modern backend mimari bileşenlerini göstermektedir:

✔ ASP.NET Identity authentication  
✔ FluentValidation input pipeline  
✔ EF Core relational database management  
✔ Layered MVC architecture  

Demonstrates a scalable admin-based agriculture management platform architecture.

---

## 📸 Screenshots

<img width="724" height="388" src="https://github.com/user-attachments/assets/4724f1bb-991f-4858-8a29-e67e7c43d1a2" />

<br/>

---

<br/>

<img width="604" height="424" src="https://github.com/user-attachments/assets/ec2bed1a-bb9f-41e3-a5c5-0db68e306020" />

<br/>

---

<br/>

<img width="670" height="317" src="https://github.com/user-attachments/assets/469fb3bb-6c0b-4e03-84f2-fb3091e3bc91" />

<br/>

---

<br/>

<img width="644" height="340" src="https://github.com/user-attachments/assets/2f6d3b9c-1e7e-49a8-9beb-9a0202901143" />

<br/>

---

<br/>

<img width="644" height="340" src="https://github.com/user-attachments/assets/31b97632-6657-48a2-abca-b0d272813725" />

<br/>

---

<br/>

<img width="469" height="269" src="https://github.com/user-attachments/assets/1f6cd99a-0f6e-47a7-865b-02b239a38b0c" />

<br/>

---

<br/>

<img width="949" height="437" src="https://github.com/user-attachments/assets/1b0d3e9e-2e2a-4fc1-9735-6b89473f2c98" />

---

## 👨‍💻 Developer

**Abdullah Haktan**

GitHub → https://github.com/abdullahhaktan
