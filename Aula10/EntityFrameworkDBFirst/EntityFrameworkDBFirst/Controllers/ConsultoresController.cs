using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkDBFirst;

namespace EntityFrameworkDBFirst.Controllers
{
    public class ConsultoresController : Controller
    {
        private Aula db = new Aula();

        // GET: Consultores
        public ActionResult Index()
        {
            return View(db.Consultores.ToList());
        }

        // GET: Consultores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultore consultore = db.Consultores.Find(id);
            if (consultore == null)
            {
                return HttpNotFound();
            }
            return View(consultore);
        }

        // GET: Consultores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consultores/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome")] Consultore consultore)
        {
            if (ModelState.IsValid)
            {
                db.Consultores.Add(consultore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consultore);
        }

        // GET: Consultores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultore consultore = db.Consultores.Find(id);
            if (consultore == null)
            {
                return HttpNotFound();
            }
            return View(consultore);
        }

        // POST: Consultores/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome")] Consultore consultore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consultore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consultore);
        }

        // GET: Consultores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultore consultore = db.Consultores.Find(id);
            if (consultore == null)
            {
                return HttpNotFound();
            }
            return View(consultore);
        }

        // POST: Consultores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Consultore consultore = db.Consultores.Find(id);
            db.Consultores.Remove(consultore);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
