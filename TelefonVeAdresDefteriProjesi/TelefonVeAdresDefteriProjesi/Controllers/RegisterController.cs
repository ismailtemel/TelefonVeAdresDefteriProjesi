using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefonVeAdresDefteriProjesi.Controllers
{
    public class RegisterController : Controller
    {
        UserManager um = new UserManager(new EfUserRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        // Burada önce User sınıfından bir p parametresi türetiyoruz.
        // 
        [HttpPost]
        public IActionResult Index(User p)
        {
            // Aşağıdaki iki satırda validasyonların kontrolünü sağlıyoruz.
            UserValidator uv = new UserValidator();
            ValidationResult results = uv.Validate(p);
            if (results.IsValid)
            {
                // Eğer sonuçlar geçerli ise aşağıdaki işlemleri yap.
                um.TAdd(p);
                return RedirectToAction("Index", "Home");
            }
            // Validasyon koşullarını sağlamıyorsa bu işlemler yapılır. 
            else
            {
                foreach (var item in results.Errors)
                {
                    // Modelin durumuna bir error ekleyeceğiz error durumları ise parantez içindedir.
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            // İşlem geçersiz ise bize bir View döner ve hata ortadan kalkar.
            return View();
        }
    }
}
