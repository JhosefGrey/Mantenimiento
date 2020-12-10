using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mantenimiento.Models;
using Mantenimiento.Models.ViewModels;

namespace Mantenimiento.Controllers
{
    public class MaestrosController : Controller
    {
        // GET: Maestros
        public ActionResult Index()
        {
            List<MaestroViewlModel> lista;
            using (db_colegioEntities db = new db_colegioEntities())
            {
                lista = (from d in db.tb_maestros
                         select new MaestroViewlModel
                         {
                             id = d.id,
                             apellido = d.apellido,
                             nombre = d.nombre
                         }).ToList();
            }

            return View(lista);
        }

        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(MaestrosViewModelA modelA)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (db_colegioEntities db= new db_colegioEntities())
                    {
                        var oMaestros = new tb_maestros();
                        oMaestros.apellido = modelA.apellido;
                        oMaestros.nombre = modelA.nombre;

                        db.tb_maestros.Add(oMaestros);
                        db.SaveChanges();
                    }
                }
               return Redirect("Maestros/");
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}