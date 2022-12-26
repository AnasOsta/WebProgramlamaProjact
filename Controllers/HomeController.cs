using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using v6.Models;

namespace v6.Controllers
{

    public class HomeController : Controller
    {

        KullaniciContext k = new KullaniciContext();
        Kullanici kullaniciSave;

        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
            _logger = logger;
        }
        void getContent()
        {
           var aa = (from item in k.Contentlar
                     select item).ToList();
            for (int i = 0; i < aa.Count; i++)
            {
                var aa2 = (from item in k.Kullanicilar
                           where item.KullaniciID == aa[i].KullaniciID
                           select item).First();
                aa[i].Kullanici = aa2;
            }
            ViewBag.Data = aa;
        }
        [HttpGet]
        public IActionResult Index()
        {
            getContent();
            return View();
        }
        [HttpPost]
        public IActionResult KullaniciEkle(Kullanici k)
        {
            if (ModelState.IsValid)
            {
                this.k.Add(k);
                this.k.SaveChanges();
                Response.WriteAsync("<script>alert('Basariyla yeni kullanici ekledi');window.location = 'Index';</script>");
                return RedirectToAction("Index");
            }
            else
            {
                TempData["hata"] = "Lütfen Gerekli alanları doldurunuz";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("Login");
            HttpContext.Response.Cookies.Delete("Admin");
            HttpContext.Response.Cookies.Delete("KullaniciAd");
            HttpContext.Response.Cookies.Delete("KullaniciSoyad");
            HttpContext.Response.Cookies.Delete("KullaniciID");
            HttpContext.Response.Cookies.Delete("mail");
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login l)
        {
            if (ModelState.IsValid)
            {
                var aa = await k.Kullanicilar
                .FirstOrDefaultAsync(m => m.KullaniciAd == l.KullaniciAd);

                if (aa != null) {
                    kullaniciSave = aa;
                    HttpContext.Response.Cookies.Append("Login", l.KullaniciAd); 
                    HttpContext.Response.Cookies.Append("Admin", aa.admin.ToString());
                    HttpContext.Response.Cookies.Append("KullaniciAd", aa.KullaniciAd.ToString()); 
                    HttpContext.Response.Cookies.Append("KullaniciSoyad", aa.KullaniciSoyad.ToString()); 
                    HttpContext.Response.Cookies.Append("KullaniciID", aa.KullaniciID.ToString()); 
                    HttpContext.Response.Cookies.Append("mail", aa.mail.ToString()); 
                }
                else Response.WriteAsync("<script>alert('Kullanici adi yada sifre yanlis');window.location = 'Index';</script>");

            }
            else
            {
                TempData["hata"] = "Lütfen Gerekli alanları doldurunuz";
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult content(Content c)
        {
            if (ModelState.IsValid)
            {
                c.KullaniciID = int.Parse(HttpContext.Request.Cookies["KullaniciID"]);
                this.k.Add(c);
                this.k.SaveChanges();
                Response.WriteAsync("<script>alert('Basariyla yeni içerik ekeldi');window.location = 'Index';</script>");
                return View("Index");
            }
            else
            {
                TempData["hata"] = "Lütfen Gerekli alanları doldurunuz";
                return RedirectToAction("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
