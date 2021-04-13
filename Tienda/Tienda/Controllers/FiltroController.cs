using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Services;

namespace Tienda.Controllers
{
    public class FiltroController : Controller
    {
        // GET: Filtro
        public ActionResult Index()
        {
            var repository = new SublineaServices();
            ViewBag.subline = repository.listsublineas();
            var repository2 = new LineaServices();
            ViewBag.line = repository2.listmaterias();
            return View();
        }

        public JsonResult chargeParameters(int id)

        {
            var repository = new FiltroServices();
            var listParameters = repository.listsublineas(id);
            return Json(listParameters, JsonRequestBehavior.AllowGet);
        }
        public JsonResult chargeParameters2(int id)

        {
            var repository = new FiltroServices();
            var listParameters = repository.listlineas(id);
            return Json(listParameters, JsonRequestBehavior.AllowGet);
        }

    }
}