using Domain.Interfaces;
using Entities.Entities;

namespace Domain.Services
{
	public class ServiceColaborador : IServiceColaborador
	{
		private readonly IColaboradores _colaboradores;

		public ServiceColaborador(IColaboradores colaboradores)
		{
			_colaboradores = colaboradores;
		}

		public async Task AdicionarColaboradorAsync(Colaboradores colaboradores)
		{
			try
			{
				await _colaboradores.AddAsync(colaboradores);
			}
			catch (Exception) { throw; }
		}

		public async Task AtualizarColaboradorAsync(Colaboradores colaboradores)
		{
			try
			{
				await BuscarColaboradorAsync(colaboradores.Id);
				await _colaboradores.UppdateAsync(colaboradores);
			}
			catch (Exception) { throw; }
		}

		public async Task<Colaboradores> BuscarColaboradorAsync(int id)
		{
			try
			{
				var colaboradores = await _colaboradores.BuscarColaboradorAsync(id);

				if (colaboradores == null) new Exception("Não tem colaborador com esse id");

				return colaboradores;
			}
			catch (Exception) { throw; }
		}

		public async Task DeletarColaboradorAsync(int id)
		{
			try
			{
				var colaborador = await BuscarColaboradorAsync(id);

				await _colaboradores.DeleteAsync(colaborador);
			}
			catch (Exception) { throw; }
		}

		public async Task<List<Colaboradores>> ListarColaboradoresAsync()
		{
			try
			{
				return await _colaboradores.ListAsync();
			}
			catch (Exception) { throw; }
		}


	}
}
