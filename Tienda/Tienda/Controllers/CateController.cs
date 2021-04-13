using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Services;

namespace Tienda.Controllers
{
    public class CateController : Controller
    {
        // GET: Cate
        public ActionResult Index()
        {

            var repository = new SublineaServices();
            ViewBag.linea = repository.listsublineas();
            return View();
        }


        public JsonResult chargeParameters()

        {
            var repository = new CateServices();
            var listParameters = repository.listcate();
            return Json(listParameters, JsonRequestBehavior.AllowGet);
        }
        public JsonResult updateandSaveData(int tipo, int id, String categoria, int idsublinea)
        {
            var repository = new CateServices();

            var listParameters = repository.updateandSaveData(tipo, id, categoria,idsublinea);
            return Json(listParameters, JsonRequestBehavior.AllowGet);
        }


    }
}