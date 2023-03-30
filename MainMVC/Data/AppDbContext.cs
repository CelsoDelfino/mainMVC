using System;
using MainMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MainMVC.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

		public DbSet<Candidato> Candidatos { get; set; }

	}
}

