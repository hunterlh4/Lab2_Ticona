using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_Ticona.Models;
namespace Lab2_Ticona.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Calcular(ClsOperaciones objOper)
        {
            objOper.numero1 = Convert.ToDouble(Request.Form["n1"]);
            objOper.numero2 = Convert.ToDouble(Request.Form["n2"]);

            objOper.tipo = Request.Form["operacion"];
            if (objOper.tipo.Equals("Suma"))
            {
                objOper.resultado = objOper.numero1 + objOper.numero2;
            }
            else if (objOper.tipo.Equals("Resta"))
            {
                objOper.resultado = objOper.numero1 - objOper.numero2;
            }
            else if (objOper.tipo.Equals("Multiplicacion"))
            {
                objOper.resultado = objOper.numero1 * objOper.numero2;
            }
            else
            {
                objOper.resultado = objOper.numero1 / objOper.numero2;
            }

            return View(objOper);
        }
    }
}