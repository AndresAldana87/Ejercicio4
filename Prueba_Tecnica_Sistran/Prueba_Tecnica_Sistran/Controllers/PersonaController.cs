using Prueba_Tecnica_Sistran.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba_Tecnica_Sistran.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            using (SISTRANEntities context = new SISTRANEntities() )
            {
                return View(context.Personas.ToList());
            }
                
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            using (SISTRANEntities context = new SISTRANEntities())
            {
                return View(context.Personas.Where(x => x.ID == id ).FirstOrDefault());
            }
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        public ActionResult Create(Personas personas)
        {
            try
            {
                using (SISTRANEntities context = new SISTRANEntities())
                {
                    context.Personas.Add(personas);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            using (SISTRANEntities context = new SISTRANEntities())
            {
                return View(context.Personas.Where(x => x.ID == id).FirstOrDefault());
            }
        }

        // POST: Persona/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Personas personas)
        {
            try
            {
                using (SISTRANEntities context = new SISTRANEntities())
                {
                    context.Entry(personas).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            using (SISTRANEntities context = new SISTRANEntities())
            {
                return View(context.Personas.Where(x => x.ID == id).FirstOrDefault());
            }
        }

        // POST: Persona/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (SISTRANEntities context = new SISTRANEntities())
                {
                    Personas personas = context.Personas.Where(x => x.ID == id).FirstOrDefault();
                    context.Personas.Remove(personas);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
