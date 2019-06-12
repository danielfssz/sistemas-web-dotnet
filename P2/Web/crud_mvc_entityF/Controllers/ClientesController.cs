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
    public class ClientesController : Controller
    {
        private LojaContext db = new LojaContext();
        private ClientesService clientesService = new ClientesService();

        // GET: Clientes
        public async Task<ActionResult> Index()
        {
            //var clientes = await clientesService.GetClientesAsync();
            var clientes = db.Clientes;
            return View(clientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Cliente cliente = db.Clientes.Find(id);
            Cliente cliente = db.Clientes.Include(c => c.Consultor).Include(c => c.Telefones).FirstOrDefault(c =>c.Id == id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            ViewBag.IdConsultor = new SelectList(db.Consultores, "Id", "Nome");
            return View();
        }

        // POST: Clientes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Email,IdConsultor,Telefones")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                //await clientesService.AddClienteAsync(cliente);                
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdConsultor = new SelectList(db.Consultores, "Id", "Nome",cliente.IdConsultor);
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdConsultor = new SelectList(db.Consultores, "Id", "Nome", cliente.IdConsultor);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Email,IdConsultor,Telefones")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {

                foreach (var telefone in cliente.Telefones)
                {
                    if (telefone.Id > 0)
                        db.Entry(telefone).State = EntityState.Modified;
                    else
                        db.Entry(telefone).State = EntityState.Added;
                }

                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdConsultor = new SelectList(db.Consultores, "Id", "Nome", cliente.IdConsultor);
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = db.Clientes.Find(id);
            db.Telefone.RemoveRange(cliente.Telefones);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public void RemoverTelefone(int id)
        {
            var telefone = db.Telefone.Find(id);
            db.Entry(telefone).State = EntityState.Deleted;
            db.SaveChanges();
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
