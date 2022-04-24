using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefonVeAdresDefteriProjesi.Controllers
{
    public class AddressAndPhoneController : Controller
    {
        // Burada AddressPhoneManager sınıfından bir nesne türettik.
        AddressAndPhoneManager ad = new AddressAndPhoneManager(new EfAddressAndPhoneRepository());
        public IActionResult Index()
        {
            var values = ad.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult TelefonVeAdresEkle()
        {
            return View();
        }
        // Burası Ekleme yapma sayfasındaki butona basınca tetikleniyor.
        [HttpPost]
        public IActionResult TelefonVeAdresEkle(AddressAndPhone p)
        {
            ad.TAdd(p);
            return RedirectToAction("Index");
        }
        // Burada güncellenecek satırı id'sine göre çekiyoruz.
        [HttpGet]
        public IActionResult TelefonVeAdresGuncelle(int id)
        {
            var values = ad.GetById(id);
            return View(values);
        }
        // Burada da ise çektiğimiz değeri güncelleyip post ediyoruz.
        [HttpPost]
        public IActionResult TelefonVeAdresGuncelle(AddressAndPhone p)
        {
            ad.TUpdate(p);
            return RedirectToAction("Index");
        }
        // İlk önce bir değişken oluşturup onu id'sine göre çekiyoruz.
        // Ardından delte komutunu yazıp silme işlemimizi gerçekleştiriyoruz.
        public IActionResult TelefonVeAdresSil(int id)
        {
            var values = ad.GetById(id);
            ad.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
