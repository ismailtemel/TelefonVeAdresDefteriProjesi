using BusinessLayer.Concrete;
using DataAcessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefonVeAdresDefteriProjesi.Controllers
{
    public class PersonController : Controller
    {
        PersonManager pm = new PersonManager(new EfPersonRepository());
        public IActionResult Index()
        {
            var values = pm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult KayıtEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KayıtEkle(Person p)
        {
            pm.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult KayıtGuncelle(int id)
        {
            var values = pm.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult KayıtGuncelle(Person p)
        {
            pm.TUpdate(p);
            return RedirectToAction("Index");
        }
        public IActionResult KayıtSil(int id)
        {
            var values = pm.GetById(id);
            pm.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
