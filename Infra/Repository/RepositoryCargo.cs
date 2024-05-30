using Domain.Interfaces;
using Entities.Entities;
using Infra.Configuration;
using Microsoft.EntityFrameworkCore;


namespace Infra.Repository
{
	public class RepositoryCargo : RepositoryGenerics<Cargo>, ICargo
	{
		public readonly DbContextOptions<ContextBase> _options;
		public RepositoryCargo()
		{
			_options = new DbContextOptions<ContextBase>();
		}

		public async Task<Cargo> BuscarCargoAsync(int id)
		{
			using (var banco = new ContextBase())
			{
				return await banco.Cargo.FindAsync(id);
			}
		}
	}
}
