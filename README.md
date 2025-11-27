# AgricultureManagementSystem

[TR]

**ASP.NET Core MVC + Entity Framework Core + Identity Kullanılarak Geliştirilmiş Tarım Yönetimi Uygulaması**

[![Entity Framework](https://img.shields.io/badge/ORM-Entity_Framework_Core-6C2DBE.svg)](https://docs.microsoft.com/en-us/ef/core/)
[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![ASP.NET Core](https://img.shields.io/badge/Framework-ASP.NET_Core-5C2D91.svg)](https://docs.microsoft.com/en-us/aspnet/core/)
[![Database](https://img.shields.io/badge/Database-SQL_Server-CC2927.svg)](https://www.microsoft.com/en-us/sql-server)
[![GitHub repo size](https://img.shields.io/github/repo-size/username/AgricultureManagementSystem)](https://github.com/username/AgricultureManagementSystem)

---

## 💻 Proje Hakkında

Bu proje, **ASP.NET Core MVC**, **Entity Framework Core** ve **Identity** teknolojilerini kullanarak geliştirilmiş bir **tarım yönetimi uygulamasıdır**.  
Amaç, kullanıcıların **tarım hizmetlerini, duyuruları, ekip üyelerini ve iletişim bilgilerini** yönetebildiği bir sistem oluşturmaktır.

---

## ✨ Temel Özellikler

### Kullanıcı ve Kimlik Yönetimi
* **Login/Logout:** ASP.NET Core Identity ile güvenli giriş ve çıkış işlemleri.
* **Rol Yönetimi:** Kullanıcı yetkilendirme (Admin, User vb.).

### CRUD Operasyonları
* **Duyurular:** Ekleme, güncelleme, silme ve listeleme.
* **Hizmetler:** Tarım hizmetlerini yönetme.
* **Takım Yönetimi:** Ekip üyeleri ekleme, düzenleme ve silme.
* **Adres ve İletişim Yönetimi:** Firma veya çiftçi bilgilerini kaydetme ve görüntüleme.

### Validasyon
* **FluentValidation:** Model doğrulama ve kullanıcı dostu hata mesajları.
* **Tarih ve Alan Kontrolü:** Boş alan kontrolü, tarih geçerliliği, minimum karakter kontrolü.

### Kullanılan Teknolojiler
* **C#**  
* **ASP.NET Core MVC**  
* **Entity Framework Core**  
* **SQL Server**  
* **ASP.NET Core Identity**  
* **FluentValidation**  
* **Razor View Engine**

---

## 🚀 Nasıl Çalıştırılır?

1.  **Projeyi Klonlama:**
    ```bash
    git clone https://github.com/username/AgricultureManagementSystem
    cd AgricultureManagementSystem
    ```

2.  **Veritabanı Kurulumu:**
    * Eğer **EF Migrations** kullanıyorsa: **Package Manager Console** üzerinden `Update-Database` komutunu çalıştırın.  
    * Manuel kurulum gerekiyorsa: **SQL Server Management Studio** açın ve gerekli tabloları oluşturun.

3.  **Bağlantı Dizesi Ayarı:**
    * `appsettings.json` içindeki SQL Server bağlantı dizesini kendi ortamınıza göre güncelleyin:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER;Database=DbAgriculture;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"
    }
    ```

4.  **Projeyi Başlatma:**
    * Visual Studio ile `.sln` dosyasını açın.
    * Gerekirse NuGet paketlerini geri yükleyin.
    * **F5** ile çalıştırın.

---

[EN]

# AgricultureManagementSystem

**ASP.NET Core MVC + EF Core + Identity Based Agriculture Management System**

---

## 💻 About the Project

This project is an **agriculture management system** built with **ASP.NET Core MVC**, **EF Core**, and **Identity**.  
The goal is to manage **agriculture services, announcements, team members, and contact information** efficiently.

---

## ✨ Core Features

### User & Identity Management
* **Login/Logout:** Secure login and logout with ASP.NET Core Identity.
* **Role Management:** Admin and user role authorization.

### CRUD Operations
* **Announcements:** Add, update, delete, list.
* **Services:** Manage agriculture services.
* **Team Management:** Add, edit, delete team members.
* **Address & Contact Management:** Store and view addresses and contact information.

### Validation
* **FluentValidation:** Model validation with user-friendly messages.
* **Date & Field Control:** Non-empty fields, minimum character length, future date validation.

### Technologies
* **C#**  
* **ASP.NET Core MVC**  
* **Entity Framework Core**  
* **SQL Server**  
* **ASP.NET Core Identity**  
* **FluentValidation**  
* **Razor View Engine**

---

## 🚀 How to Run

1.  **Clone the Project:**
    ```bash
    git clone https://github.com/username/AgricultureManagementSystem
    cd AgricultureManagementSystem
    ```

2.  **Database Setup:**
    * If **EF Migrations** are used: run `Update-Database` in **Package Manager Console**.  
    * If manual setup: create required tables in **SQL Server Management Studio**.

3.  **Configure Connection String:**
    * Update the connection string in `appsettings.json` to match your local SQL Server.

4.  **Start the Project:**
    * Open the `.sln` file in Visual Studio.
    * Restore NuGet packages if needed.
    * Press **F5** to run.

---

<img width="937" height="385" alt="Ekran görüntüsü 2025-11-27 155346" src="https://github.com/user-attachments/assets/cf45add7-9e17-42d7-8850-90a5dd8299e6" />

---

<img width="930" height="410" alt="Ekran görüntüsü 2025-11-27 155410" src="https://github.com/user-attachments/assets/4ba64191-d917-430f-ae9d-dd771d9833a2" />

---

<img width="929" height="320" alt="Ekran görüntüsü 2025-11-27 155434" src="https://github.com/user-attachments/assets/239123e0-b0b9-4f50-89f4-e96b8efb6591" />

---

<img width="925" height="340" alt="Ekran görüntüsü 2025-11-27 155450" src="https://github.com/user-attachments/assets/50dde152-f0e4-4600-80a2-f92b17e56d82" />

---

<img width="878" height="356" alt="Ekran görüntüsü 2025-11-27 155510" src="https://github.com/user-attachments/assets/06932e25-81b9-49c3-a4e7-6aa27a318e2a" />

---

<img width="907" height="275" alt="Ekran görüntüsü 2025-11-27 155526" src="https://github.com/user-attachments/assets/01bba750-2217-47fb-b9bf-c4898cbd1700" />

---

<img width="923" height="265" alt="Ekran görüntüsü 2025-11-27 155545" src="https://github.com/user-attachments/assets/0893fc73-062a-44be-8b50-fe1be0e3f66f" />

---

<img width="937" height="238" alt="Ekran görüntüsü 2025-11-27 155600" src="https://github.com/user-attachments/assets/54ad3751-dac1-49db-af29-a97b0f49cee2" />

---

<img width="1901" height="2048" alt="localhost_7138_Dashboard_Index" src="https://github.com/user-attachments/assets/46fe5242-9925-4ee7-bcab-6134cee41134" />
