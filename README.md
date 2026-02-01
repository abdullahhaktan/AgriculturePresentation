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

### Ekran Görüntüleri

<img width="724" height="388" alt="Ekran görüntüsü 2026-02-01 151216" src="https://github.com/user-attachments/assets/4724f1bb-991f-4858-8a29-e67e7c43d1a2" />

---

<img width="604" height="424" alt="Ekran görüntüsü 2026-02-01 151240" src="https://github.com/user-attachments/assets/ec2bed1a-bb9f-41e3-a5c5-0db68e306020" />

---

<img width="670" height="317" alt="Ekran görüntüsü 2026-02-01 151307" src="https://github.com/user-attachments/assets/469fb3bb-6c0b-4e03-84f2-fb3091e3bc91" />

---

<img width="644" height="340" alt="Ekran görüntüsü 2026-02-01 151336" src="https://github.com/user-attachments/assets/2f6d3b9c-1e7e-49a8-9beb-9a0202901143" />

---

<img width="644" height="340" alt="Ekran görüntüsü 2026-02-01 151336" src="https://github.com/user-attachments/assets/31b97632-6657-48a2-abca-b0d272813725" />

---

<img width="469" height="269" alt="Ekran görüntüsü 2026-02-01 151409" src="https://github.com/user-attachments/assets/1f6cd99a-0f6e-47a7-865b-02b239a38b0c" />

---

<img width="949" height="437" alt="Ekran görüntüsü 2026-02-01 151535" src="https://github.com/user-attachments/assets/1b0d3e9e-2e2a-4fc1-9735-6b89473f2c98" />
