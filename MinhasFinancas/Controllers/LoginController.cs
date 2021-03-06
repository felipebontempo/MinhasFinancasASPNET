﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace MinhasFinancas.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Autentica(String login, String senha)
        {
            if (WebSecurity.Login(login, senha))
            {
                return RedirectToAction("Index", "Movimentacao");
            }
            else
            {
                ModelState.AddModelError("login.Invalido", "Login ou senha incorretos");
                return View("Index");
            }
            
        }
        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return RedirectToAction("Index");
        }
    }
}