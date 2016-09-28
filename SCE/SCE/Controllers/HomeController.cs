using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SCE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Outsourcing()
        {
            return View();
        }

        public ActionResult SafetyEngineering()
        {
            return View();
        }

        public ActionResult SOUT()
        {
            return View();
        }

        public ActionResult Сounseling()
        {
            return View();
        }

        public ActionResult PPR()
        {
            return View();
        }
        public ActionResult KD()
        {
            return View();
        }

        public ActionResult Video()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SendMail(string name, string mail, string message)
        {
            var client = new SmtpClient();
            client.EnableSsl = true;
            client.Send("pasha1rab@gmail.com", "pasha1rab@gmail.com", "test", "testbody");

            return Json(true);
        }
    }
}