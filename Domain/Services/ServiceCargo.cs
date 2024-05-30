using Domain.Interfaces;
using Entities.Entities;

namespace Domain.Services
{
	public class ServiceCargo : IServiceCargo
	{
		private readonly ICargo _cargo;

		public ServiceCargo(ICargo cargo)
		{
			_cargo = cargo;
		}
		public async Task AdicionarCargoAsync(Cargo cargo)
		{
			await _cargo.AddAsync(cargo);
		}

		public async Task AtualizarCargoAsync(Cargo cargo)
		{
			await BuscarCargoAsync(cargo.Id);
			await _cargo.UppdateAsync(cargo);
		}

		public async Task<Cargo> BuscarCargoAsync(int id)
		{

			var cargo = await _cargo.BuscarCargoAsync(id);

			return cargo;
		}

		public async Task DeletarCargoAsync(int id)
		{
			var cargo = await BuscarCargoAsync(id);
			await _cargo.DeleteAsync(cargo);
		}

		public async Task<List<Cargo>> ListarCargoAsync()
		{
			return await _cargo.ListAsync();
		}
	}
}
