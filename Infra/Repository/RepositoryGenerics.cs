using Infra.Configuration;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Domain.Interfaces.Generics;

namespace Infra.Repository
{
    public class RepositoryGenerics<T> : IGenerics<T> where T : class
	{
		private readonly DbContextOptions<ContextBase> _optionsBuilder;

		public RepositoryGenerics()
		{
			_optionsBuilder = new DbContextOptions<ContextBase>();
		}
		public async Task AddAsync(T objeto)
		{
			using (var data = new ContextBase(_optionsBuilder))
			{
				await data.Set<T>().AddAsync(objeto);
				await data.SaveChangesAsync();
			}
		}

		public async Task DeleteAsync(T objeto)
		{
			using (var data = new ContextBase(_optionsBuilder))
			{
				data.Set<T>().Remove(objeto);
				await data.SaveChangesAsync();
			}
		}

		public async Task<List<T>> ListAsync()
		{
			using (var data = new ContextBase(_optionsBuilder))
			{
				return await data.Set<T>().AsNoTracking().ToListAsync();
			}
		}

		public async Task UppdateAsync(T objeto)
		{

			using (var data = new ContextBase(_optionsBuilder))
			{
				data.Set<T>().Update(objeto);
				await data.SaveChangesAsync();
			}
		}
	}
}
