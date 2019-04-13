using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP01Crud.Models;

namespace TP01Crud.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            ClienteDAL clienteDal = new ClienteDAL();
            var ret = clienteDal.ExecutaOperacao(null, "SEL");
            return View(ret);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            ClienteDAL clienteDal = new ClienteDAL();
            Cliente cliente = new Cliente(id);
            var ret = clienteDal.ExecutaOperacao(cliente, "SEL");
            return View(ret);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                ClienteDAL clienteDal = new ClienteDAL();
                clienteDal.ExecutaOperacao(cliente, "INS");
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            ClienteDAL clienteDal = new ClienteDAL();
            Cliente cliente = new Cliente(id);            
            var ret = clienteDal.ExecutaOperacao(cliente, "SEL");
            return View(ret);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                ClienteDAL clienteDal = new ClienteDAL();
                clienteDal.ExecutaOperacao(cliente, "UPD");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            ClienteDAL clienteDal = new ClienteDAL();
            Cliente cliente = new Cliente(id);
            var ret = clienteDal.ExecutaOperacao(cliente, "SEL");
            return View(ret);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Cliente clientee)
        {
            try
            {
                ClienteDAL clienteDal = new ClienteDAL();
                Cliente cliente = new Cliente(id);
                clienteDal.ExecutaOperacao(cliente, "DEL");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
