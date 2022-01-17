using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AeroclubeAplicacao;

namespace Aeroclube.Controllers
{
    public class LoginController : Controller
    {
        private Login usuario;        
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public JsonResult GetLogin(string pNmUsuario, string pDsSenha)
        {
            var Result = this.usuario.getLogin(pNmUsuario, pDsSenha);

            return new JsonResult(Result);
            
        }
    }
}