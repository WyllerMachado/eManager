using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AV2_WyllerMachado.Models;

namespace AV2_WyllerMachado.Controllers
{
    public class ClientesController : Controller
    {
        private ApplicationDbContext _context;

        public ClientesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Clientes
        public ActionResult Index()
        {
            var clientes = _context.Clientes.ToList();

            return View(clientes);
        }

        // GET: Clientes/Novo
        public ActionResult Novo()
        {
            var cliente = new Cliente();

            return View("ClienteForm", cliente);
        }


        // GET: Clientes/Editar/{id}
        public ActionResult Editar(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();
            
            return View("ClienteForm", cliente);
        }


        public ActionResult Excluir(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Clientes");
        }


        [HttpPost]
        public ActionResult Salvar(Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                _context.Clientes.Add(cliente);
            }
            else
            {
                var clienteInDb = _context.Clientes.Single(c => c.Id == cliente.Id);

                clienteInDb.Nome = cliente.Nome;
                clienteInDb.Cpf = cliente.Cpf;
                clienteInDb.Endereco = cliente.Endereco;
                clienteInDb.Telefone = cliente.Telefone;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Clientes");
        }
    }
}