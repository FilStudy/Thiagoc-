
using _06_Fiap.Web.aspNet.Models;
using _06_Fiap.Web.aspNet.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _06_Fiap.Web.aspNet.Controllers
{
    public class CorridaController : Controller
    {
        private CorridaContext _context;

        public CorridaController(CorridaContext corridaContext)
        {
            _context = corridaContext;
        }

        //CADASTRAR///CREATE
        [HttpGet]
        public IActionResult CadastrarCorrida()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarCorrida(Corrida corrida)
        {
            _context.Corridas.Add(corrida);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado";
            return RedirectToAction("Listar");
        }

        //LISTAR///READ
        public IActionResult Listar()
        {
            return View(_context.Corridas.ToList());
        }

        //ATUALIZAR///UPDATE
        [HttpPost]
        public IActionResult Atualizar(Corrida corrida)
        {
            _context.Corridas.Update(corrida);
            _context.SaveChanges();
            TempData["msg"] = "Atualizado";
            return RedirectToAction("Listar");
        }

        //REMOVER///REMOVE
        [HttpPost]
        public IActionResult Remove(int id)
        {
            var busca = _context.Corridas.Find(id);
            _context.Corridas.Remove(busca);
            _context.SaveChanges();
            TempData["msg"] = "Removido";
            return RedirectToAction("Listar");
        }
    }
}