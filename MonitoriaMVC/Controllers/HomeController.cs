using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonitoriaMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoriaMVC.Controllers
{
    public class HomeController : Controller
    {

        private ClienteDbContext _context;

        public HomeController(ClienteDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Index()
        {

            List<Cliente> clientes = _context.clientes.ToList();

            if(clientes == null)
            {
                return View("Cadastro");
            }

            return View(clientes);
        }

        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            if(cliente == null)
            {
                return View("Cadastro");
            }

            _context.Add(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {

            Cliente cliente = _context.clientes.Find(id);

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {

            _context.Update(cliente);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int id)
        {

            Cliente cliente = _context.clientes.SingleOrDefault(a => a.ID == id);

            if(cliente == null)
            {
                return RedirectToAction("Cadastro");
            }
            

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Deletar(Cliente cliente)
        {
            

            _context.Remove(cliente);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
