using CalculadoraMejorada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraMejorada.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Calcular()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Calcular(CalculadoraModel model, string valor)
        {
            switch (valor)
            {
                case "+": model.resultado = model.ola + model.Numero2;
                    break;
            }

            return View(model);
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}