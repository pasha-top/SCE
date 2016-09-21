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
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("pasha1rab@gmail.com", "Tom");
            // кому отправляем
            MailAddress to = new MailAddress("pasha1rab@gmail.com");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("pasha1rab@gmail.com", "bubopi823");
            smtp.EnableSsl = false;
            smtp.Send(m);

            return Json(true);
        }
    }
}