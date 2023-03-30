
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainMVC.Data;
using MainMVC.Models;
using MainMVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MainMVC.Controllers
{
    public class CandidatoController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICandidatoRepository _repository;

        public CandidatoController(AppDbContext context, ICandidatoRepository repository)
        {
            _context = context;
            _repository = repository;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Candidato candidato)
        { 
            _repository.Create(candidato);
            _context.SaveChanges();
            return View();
        }

        public IActionResult GetAll()
        {
            var list = _repository.GetAll();
            return View(list);
        }

    }
}

