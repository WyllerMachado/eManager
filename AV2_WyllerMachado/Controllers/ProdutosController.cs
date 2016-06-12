using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AV2_WyllerMachado.Models;

namespace AV2_WyllerMachado.Controllers
{
    public class ProdutosController : Controller
    {
        private ApplicationDbContext _context;

        public ProdutosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Produtos
        public ActionResult Index()
        {
            var produtos = _context.Produtos.ToList();

            return View(produtos);
        }

        // GET: Produtos/Novo
        public ActionResult Novo()
        {
            var produto = new Produto();

            return View("ProdutoForm", produto);
        }


        // GET: Produtos/Editar/{id}
        public ActionResult Editar(int id)
        {
            var produto = _context.Produtos.SingleOrDefault(p => p.Id == id);

            if (produto == null)
                return HttpNotFound();

            return View("ProdutoForm", produto);
        }


        public ActionResult Excluir(int id)
        {
            var produto = _context.Produtos.SingleOrDefault(p => p.Id == id);


            if (produto == null)
                return HttpNotFound();
            

            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            
            return RedirectToAction("Index", "Produtos");
        }


        [HttpPost]
        public ActionResult Salvar(Produto produto)
        {
            if (produto.Id == 0)
            {
                _context.Produtos.Add(produto);
            }
            else
            {
                var produtoInDb = _context.Produtos.Single(p => p.Id == produto.Id);

                produtoInDb.Valor = produto.Valor;
                produtoInDb.Nome = produto.Nome;
                produtoInDb.Marca = produto.Marca;
                produtoInDb.Estoque = produto.Estoque;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Produtos");
        }
    }
}