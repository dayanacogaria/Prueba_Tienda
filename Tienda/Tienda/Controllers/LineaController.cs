using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Services;

namespace Tienda.Controllers
{
    public class LineaController : Controller
    {
        // GET: Linea
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult chargeParameters()

        {
            var repository = new LineaServices();
            var listParameters = repository.listmaterias();
            return Json(listParameters, JsonRequestBehavior.AllowGet);
        }
        public JsonResult updateandSaveData(int tipo, int id, String linea)
        {
            var repository = new LineaServices();

            var listParameters = repository.updateandSaveData(tipo, id, linea);
            return Json(listParameters, JsonRequestBehavior.AllowGet);
        }
    }
}