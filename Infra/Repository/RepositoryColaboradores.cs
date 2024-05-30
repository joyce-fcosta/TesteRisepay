using Domain.Interfaces;
using Entities.Entities;
using Infra.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
	public class RepositoryColaboradores:RepositoryGenerics<Colaboradores>,IColaboradores
	{
		public readonly DbContextOptions<ContextBase> _options;
		public RepositoryColaboradores()
		{
			_options = new DbContextOptions<ContextBase>();
		}
		public async Task<Colaboradores> BuscarColaboradorAsync(int id)
		{
			using (var banco = new ContextBase())
			{
				return await banco.Colaboradores.FindAsync(id);
			}
		}
	}
}
