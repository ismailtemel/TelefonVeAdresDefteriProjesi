using DataAcessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TelefonVeAdresDefteriProjesi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        // Burada asenkronik bir yapı kullandık.
        [HttpPost]
        public async Task<IActionResult> Index(User p)
        {
            Context c = new Context();
            // FirstOrDefault tek değer sorgusu yapmak için kullanılır.
            var datavalue = c.Users.FirstOrDefault(x => x.Mail == p.Mail && x.Password == p.Password);
            if (datavalue != null)
            {
                //Claim'ler talep oluşturmak, kullanıcı bilgisi tutmak ve bu bilgilere göre yetkilendirme yapmamızı sağlar.
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,p.Mail)
                };
                // ClaimsIdentity'nin parantez içerisine tanımlamış olduğumuz komutların herbiri aslında bir üst satırındaki 
                // tanımlanan değeri alır.
                // "a" değeri ise belirtilen talepler ve kimlik doğrulama türü ile ClaimsIdentity sınıfının yeni bir örneğini başlatır.
                var useridentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                // Gelen değeri şifreli formatta cookie oluşturması için aşağıdaki kod satırını yazarız.
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }
        }
    }
}
