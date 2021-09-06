using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_Ticona.Models;


namespace Lab2_Ticona.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular(ClsCompra objcompra) {
            Random numero = new Random();
            objcompra.valoraleatorio = numero.Next(1, 500);
            return View(objcompra);
            }
    }
}