using ClinicaMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public ActionResult Adicionar()
        {
            ViewBag.IdCidade = new SelectList(banco.Cidades, "IDCidade", "Nome");
            ViewBag.IdEspecialidade = new SelectList(banco.Especialidades, "IDEspecialidade", "Nome");
            return View();
        }
        [HttpPost]
        public ActionResult Adicionar(Medico medico)
        {
            if (ModelState.IsValid)
            {
                banco.Medicos.Add(medico);
                banco.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCidade = new SelectList(banco.Cidades, "IDCidade", "Nome", medico.IDCidade);
            ViewBag.IdEspecialidade = new SelectList(banco.Especialidades, "IDEspecialidade", "Nome", medico.IDEspecialidade);
            return View(medico);
        }
        public ActionResult Editar(long id)
        {
            Medico medico = banco.Medicos.Find(id);
            ViewBag.IdCidade = new SelectList(banco.Cidades, "IdCidade", "Nome", medico.IDCidade);
            ViewBag.IdEspecialidade = new SelectList(banco.Especialidades, "IDEspecialidade", "Nome",medico.IDEspecialidade);
            return View(medico);
        }
        [HttpPost]
        public ActionResult Editar(Medico medico)
        {
            if (ModelState.IsValid)
            {
                banco.Entry(medico).State = EntityState.Modified;
                banco.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCidade = new SelectList(banco.Cidades, "IDCidade", "Nome", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(banco.Especialidades, "IDEspecialidade", "Nome", medico.IDEspecialidade);
            return View(medico);
        }
        public ActionResult Editar(int id)
        {

            return View();
        }
    }
}
