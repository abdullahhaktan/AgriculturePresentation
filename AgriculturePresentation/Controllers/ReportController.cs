using AgriculturePresentation.Models;
using ClosedXML.Excel;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
using OfficeOpenXml;

namespace AgriculturePresentation.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticReport()
        {
            // EPPlus 8+ LICENSE SETTING
            //ExcelPackage.License = new ExcelLicense(LicenseType.NonCommercial); // artık bu yok

            ExcelPackage.License.SetNonCommercialPersonal("Abdullah");

            using var excelPackage = new ExcelPackage();
            var workBook = excelPackage.Workbook.Worksheets.Add("Dosya1");

            workBook.Cells[1, 1].Value = "Ürün Adı";
            workBook.Cells[1, 2].Value = "Ürün Kategorisi";
            workBook.Cells[1, 3].Value = "Ürün Stok";

            workBook.Cells[2, 1].Value = "Mercimek";
            workBook.Cells[2, 2].Value = "Bakliyat";
            workBook.Cells[2, 3].Value = "785";

            workBook.Cells[3, 1].Value = "Ayçiçek Yağı";
            workBook.Cells[3, 2].Value = "Gıda";
            workBook.Cells[3, 3].Value = "120";

            workBook.Cells[4, 1].Value = "Bulaşık Deterjanı";
            workBook.Cells[4, 2].Value = "Temizlik";
            workBook.Cells[4, 3].Value = "56";

            var bytes = excelPackage.GetAsByteArray();

            return File(bytes,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "BakliyatRaporu.xlsx");  // xlsk değil, xlsx olmalı!
        }

        public List<ContactModel> ContactList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            
            using(var context = new AgricultureContext())
            {
                contactModels = context.Contacts.Select(x => new ContactModel
                {
                    ContactId = x.ContactId,
                    Name = x.Name,
                    Date = x.Date,
                    Mail = x.Mail,
                    Message = x.Message,
                }).ToList();
            }
            return contactModels;
        }
        public IActionResult ContactReport()
        {
            using(var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Mesaj Listesi");

                workSheet.Cell(1, 1).Value = "Mesaj ID";
                workSheet.Cell(1, 2).Value = "Mesaj Gönderen";
                workSheet.Cell(1, 3).Value = "Mail Adresi";
                workSheet.Cell(1, 4).Value = "Mesaj İçeriği";
                workSheet.Cell(1, 5).Value = "Mesaj Tarihi";

                int contactRawCount = 2;
                foreach(var item in ContactList())
                {
                    workSheet.Cell(contactRawCount,1).Value = item.ContactId;
                    workSheet.Cell(contactRawCount,2).Value = item.Name;
                    workSheet.Cell(contactRawCount, 3).Value = item.Mail;
                    workSheet.Cell(contactRawCount, 4).Value = item.Message;
                    workSheet.Cell(contactRawCount, 5).Value = item.Date;

                    contactRawCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "MesajRapor.xlsx");
                }
            }
        }

        public List<AnnouncementModel> AnnouncementList()
        {
            List<AnnouncementModel> announcementModels = new List<AnnouncementModel>();

            using(var context = new AgricultureContext())
            {
                announcementModels = context.Announcements.Select(x => new AnnouncementModel
                {
                    AnnouncementID = x.AnnouncementID,
                    Title = x.Title,
                    Description = x.Description,
                    ImageUrl = x.ImageUrl,
                    Date = x.Date,
                    Status = x.Status
                }).ToList();
            }

            return announcementModels;
        }

        public IActionResult AnnouncementReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Duyuru Listesi");

                workSheet.Cell(1, 1).Value = "Duyuru ID";
                workSheet.Cell(1, 2).Value = "Duyuru Başlık";
                workSheet.Cell(1, 3).Value = "Duyuru Açıklama";
                workSheet.Cell(1, 4).Value = "Duyuru Resim Url";
                workSheet.Cell(1, 5).Value = "Duyuru Tarih";
                workSheet.Cell(1, 6).Value = "Duyuru Durum";

                int announcementRawCount = 2;
                foreach (var item in AnnouncementList())
                {
                    workSheet.Cell(announcementRawCount, 1).Value = item.AnnouncementID;
                    workSheet.Cell(announcementRawCount, 2).Value = item.Title;
                    workSheet.Cell(announcementRawCount, 3).Value = item.Description;
                    workSheet.Cell(announcementRawCount, 4).Value = item.ImageUrl;
                    workSheet.Cell(announcementRawCount, 5).Value = item.Date;
                    workSheet.Cell(announcementRawCount, 6).Value = item.Status;

                    announcementRawCount++;
                }

                Guid newGuid = Guid.NewGuid();

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                $"{newGuid}.xlsx");
                }
            }
        }
    }
}
