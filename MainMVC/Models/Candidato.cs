using System;
namespace MainMVC.Models
{
	public class Candidato
	{
		public Candidato()
		{
		}

		public int Id { get; set; }
		public string Nome { get; set; }
		public string Img { get; set; }
		public string Estado { get; set; }
		public string Email { get; set; }
    }
}

