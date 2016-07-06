using ClinicaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaMVC.Controllers
{
    public class MedicosController : Controller
    {
        public CadeMeuMedicoBDEntities2 banco = new CadeMeuMedicoBDEntities2();
        // GET: Medicos
        public ActionResult Index()
        {
            var medicos = banco.Medicos.Include("Cidade").Include("Especialidade");
            return View(medicos);
        }
    }
}