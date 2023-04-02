using System;
using MainMVC.Models;

namespace MainMVC.Repositories.Interfaces
{
	public interface ICandidatoRepository
	{
        Candidato Create(Candidato candidato);
		IEnumerable<Candidato> GetAll();
	}
}

