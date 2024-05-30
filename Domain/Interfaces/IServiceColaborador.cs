using Entities.Entities;

namespace Domain.Interfaces
{
	public interface IServiceColaborador
	{
		Task<Colaboradores> BuscarColaboradorAsync(int id);
		Task AdicionarColaboradorAsync(Colaboradores produto);
		Task AtualizarColaboradorAsync(Colaboradores produto);
		Task DeletarColaboradorAsync(int id);
		Task<List<Colaboradores>> ListarColaboradoresAsync();
	
	}
}
