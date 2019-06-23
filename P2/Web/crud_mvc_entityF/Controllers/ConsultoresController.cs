using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using crud_mvc_entityF.Models;
using crud_mvc_entityF.Services;

namespace crud_mvc_entityF.Controllers
{
    public class ConsultoresController : Controller
    {
        private LojaContext db = new LojaContext();
        private ConsultoresService consultoresService = new ConsultoresService();

        // GET: Consultores
        public async Task<ActionResult> Index()
        {
            var consultores = await consultoresService.GetConsultoresAsync();
            return View(consultores);
            //return View(db.Consultores.ToList());
        }

        // GET: Consultores/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var consultor = await consultoresService.GetConsultorAsync(id);
            //Consultor consultor = db.Consultores.Find(id);
            if (consultor == null)
            {
                return HttpNotFound();
            }
            return View(consultor);
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
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome")] Consultor consultor)
        {
            if (ModelState.IsValid)
            {
                await consultoresService.AddConsultorAsync(consultor);
                //db.Consultores.Add(consultor);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consultor);
        }

        // GET: Consultores/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Consultor consultor = db.Consultores.Find(id);
            var consultor = await consultoresService.GetConsultorAsync(id);
            if (consultor == null)
            {
                return HttpNotFound();
            }
            return View(consultor);
        }

        // POST: Consultores/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nome")] Consultor consultor)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(consultor).State = EntityState.Modified;
                //db.SaveChanges();
                await consultoresService.EditConsultorAsync(consultor);
                return RedirectToAction("Index");
            }
            return View(consultor);
        }

        // GET: Consultores/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Consultor consultor = db.Consultores.Find(id);
            var consultor = await consultoresService.GetConsultorAsync(id);
            if (consultor == null)
            {
                return HttpNotFound();
            }
            return View(consultor);
        }

        // POST: Consultores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            //Consultor consultor = db.Consultores.Find(id);
            //db.Consultores.Remove(consultor);
            //db.SaveChanges();
            await consultoresService.RemoveConsultorAsync(id);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
