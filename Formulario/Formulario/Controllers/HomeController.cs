using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //inicializar valor do ViewBag
            ViewBag.Resposta = "";
            return View();
        }

        // POST: Home
       [HttpPost]
        public ActionResult Index(string nome, int? idade)
        {
            //var auxiliar
            string resposta = "";

            if(nome != "") { 
            // preparar a resposta a enviar para a View.
            resposta += "Voce chama-se " + nome;}

            if(idade != null) {
                //ver o final no git
                resposta += " e tem " + idade + " anos.";
            }

            ViewBag.Resposta = resposta;

            return View();
        }
    }
}