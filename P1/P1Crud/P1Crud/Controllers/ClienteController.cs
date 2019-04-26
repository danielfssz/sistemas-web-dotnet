using P1Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P1Crud.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            ClienteDAL clienteDal = new ClienteDAL();
            var listaCliente = clienteDal.selecionarClientes();
            return View(listaCliente);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            ClienteDAL clienteDal = new ClienteDAL();
            var cliente = clienteDal.selecionarCliente(id);
            return View(cliente);
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
                clienteDal.insereCliente(cliente);
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
            var cliente = clienteDal.selecionarCliente(id);
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                ClienteDAL clienteDal = new ClienteDAL();
                clienteDal.atualizaCliente(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            ClienteDAL clienteDal = new ClienteDAL();
            var cliente = clienteDal.selecionarCliente(id);
            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Cliente cliente)
        {
            try
            {
                ClienteDAL clienteDal = new ClienteDAL();
                clienteDal.excluiCliente(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
