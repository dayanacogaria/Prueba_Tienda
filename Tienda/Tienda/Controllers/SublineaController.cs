using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Services;

namespace Tienda.Controllers
{
    public class SublineaController : Controller
    {
        // GET: Sublinea
        public ActionResult Index()
        {
            var repository = new LineaServices();
            ViewBag.linea = repository.listmaterias();
            return View();
        }


        public JsonResult chargeParameters()

        {
            var repository = new SublineaServices();
            var listParameters = repository.listsublineas();
            return Json(listParameters, JsonRequestBehavior.AllowGet);
        }
        public JsonResult updateandSaveData(int tipo, int id, String sublinea,int idlinea)
        {
            var repository = new SublineaServices();

            var listParameters = repository.updateandSaveData(tipo, id, sublinea,idlinea);
            return Json(listParameters, JsonRequestBehavior.AllowGet);
        }
    }
}