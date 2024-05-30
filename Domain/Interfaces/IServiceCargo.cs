using Entities.Entities;

namespace Domain.Interfaces
{
	public interface IServiceCargo
	{
		Task<Cargo> BuscarCargoAsync(int id);
		Task AdicionarCargoAsync(Cargo produto);
		Task AtualizarCargoAsync(Cargo produto);
		Task DeletarCargoAsync(int id);
		Task<List<Cargo>> ListarCargoAsync();
	}
}
