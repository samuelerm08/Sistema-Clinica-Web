using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaClinicaWeb.Core.Data;
using SistemaClinicaWeb.Core.Models.Persona;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace SistemaClinicaWeb.App.Controllers
{
    [Authorize]
    public class MedicoController : Controller
    {
        private readonly DbClinicaContext context;              
        public MedicoController(DbClinicaContext context) { this.context = context; }

        public ActionResult<IEnumerable<Medico>> Index()
        {            
            var medicos = context.Medicos.ToList();            
            return View(medicos);
        }

        [HttpGet]
        public ActionResult<Medico> Details(int id)
        {
            var medico = context.Medicos.Find(id);

            if (medico == null)
                return NotFound();

            return View(medico);
        }

        [HttpGet]
        public ActionResult Nuevo()
        {
            var m = new Medico();
            return View(m);
        }

        [HttpPost]
        public ActionResult Nuevo(Medico m)
        {
            if (!ModelState.IsValid)
                return View(m);

            context.Medicos.Add(m);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var m = context.Medicos.Find(id);
            if (m != null)
                return View(m);

            return NotFound(m);
        }

        [HttpPost]
        public ActionResult Edit(Medico m)
        {
            if (!ModelState.IsValid)
                return View(m);

            context.Entry(m).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {            
            if (id != null)
                return View();

            return NotFound();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var m = context.Medicos.Find(id);
            context.Medicos.Remove(m);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
