﻿using System;
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

        public ActionResult PTM()
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

        [HttpPost]
        public ActionResult SendMail(string name, string mail, string message, string phone)
        {
            try
            {
                var client = new SmtpClient {EnableSsl = true};
                client.Send(mail, "scengby@gmail.com", "Заявка от " + name, phone + " " + message);
                var result = new
                {
                    Message = "Ok",
                    Success = true
                };
                return Json(result,JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                var result = new
                {
                    Message = ex.InnerException.Message,
                    Success = false
                };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }
    }
}