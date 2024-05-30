using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuration
{
	public class ContextBase : DbContext
	{
		public ContextBase() { }
		public ContextBase(DbContextOptions<ContextBase> options) : base(options)
		{
		}

		public DbSet<Cargo> Cargo { get; set; }
		public DbSet<Colaboradores> Colaboradores { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseMySQL("Server=127.0.0.1;Port=3306;DataBase=empresa;Uid=root;Pwd=admin");
				base.OnConfiguring(optionsBuilder);
			}
		}

	}
}