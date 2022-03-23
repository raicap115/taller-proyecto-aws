using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using taller_proyecto_aws.Models;
using taller_proyecto_aws.Data;



namespace taller_proyecto_aws.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lista = _context.participantes.ToList();
            return View(lista);
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Participantes objParticipantes)
        {
            if(ModelState.IsValid)
            {
                _context.Add(objParticipantes);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(objParticipantes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
