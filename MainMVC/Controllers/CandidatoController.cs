
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using MainMVC.Data;
using MainMVC.Models;
using MainMVC.Repositories.Interfaces;
using MainMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        public ActionResult Index()
        {
            var candidato = new Candidato() { Nome = "celso", Email = "celso@gmail.com" };

            var cursos = new List<Cursos>() 
            {
                new Cursos() {Nome = "asp net c# 1"},
                new Cursos() {Nome = "asp net c# 2"},
                new Cursos() {Nome = "asp net c# 3"},
                new Cursos() {Nome = "asp net c# 4"},
            };

            var viewModel = new CandidatoCursoViewModel()
            {
                Candidato= candidato,
                Cursos = cursos,
            };

            return View(viewModel);
        }
    }
}

