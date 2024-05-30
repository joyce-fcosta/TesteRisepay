using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces
{
	public interface IColaboradores:IGenerics<Colaboradores>
	{
		Task<Colaboradores> BuscarColaboradorAsync(int id);
	}
}
