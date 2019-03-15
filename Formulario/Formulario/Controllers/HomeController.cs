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
            string resposta = "Você chama-se " + nome + " e tem " + idade + " anos.";}

            if(idade != null) {
                //ver o final no git

            }

            ViewBag.Resposta = resposta;

            return View();
        }
    }
}