using System;
using MainMVC.Data;
using MainMVC.Models;
using MainMVC.Repositories.Interfaces;

namespace MainMVC.Repositories
{
	public class CandidatoRepository : ICandidatoRepository
	{
		private readonly AppDbContext _context;
		public CandidatoRepository(AppDbContext context)
		{
            _context = context;
		}

        public Candidato Create(Candidato candidato)
        {
                if(candidato != null)
                {
                    var newCandidato = new Candidato
                    {
                        Nome = candidato.Nome,
                        Email = candidato.Email,
                        Estado = candidato.Estado,
                        Img = candidato.Img
                    };
                    _context.Candidatos.Add(newCandidato);

                    return candidato;
                }
                else
                {
                    return null;
                }
            
        }

        public IEnumerable<Candidato> GetAll()
        {
            var listCandidatos = _context.Candidatos.ToList();
            return listCandidatos;
        }
    }
}

