using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;
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
        NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;User Id=anas;Password=741520;Database=WebProgramlama;");
        private NpgsqlCommand cmd;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KullaniciEkle(Kullanici k)
        {
            con.Open();
            string sql = "INSERT INTO kullanici(adi, soyadi, mail, sifre, dogumtarihi, admin) VALUES(@adi, @soyadi, @mail, @sifre, @dogumtarihi, @admin)";
            try
            {
                //insert into kullanici Start
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("adi", k.KullaniciAd);
                cmd.Parameters.AddWithValue("soyadi", k.KullaniciSoyad);
                cmd.Parameters.AddWithValue("mail", k.mail);
                cmd.Parameters.AddWithValue("sifre", k.sifre);
                cmd.Parameters.AddWithValue("dogumtarihi", k.DogumTarihi);
                cmd.Parameters.AddWithValue("admin", false);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                //insert into kullanici End
                con.Close();
                return View();
            }
            catch (Exception e)
            {
                con.Close();
                return View("Error");
            }
        }
        [HttpPost]
        public IActionResult Login(Login l)
        {
            con.Open();
            string sql = "SELECT mail FROM kullanici";
            cmd = new NpgsqlCommand(sql, con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return View(dt.Rows);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
