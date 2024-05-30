using Domain.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web_Api.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class ColaboradoresController : ControllerBase
	{
		public readonly IServiceColaborador _serviceColaborador;
		public ColaboradoresController(IServiceColaborador serviceColaborador)
		{
			_serviceColaborador = serviceColaborador;

		}

		// GET: api/Colaboradores
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Colaboradores>>> GetColaborador()
		{
			return await _serviceColaborador.ListarColaboradoresAsync();
		}

		// GET: api/Colaboradores/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Colaboradores>> GetColaborador(int id)
		{
			return await _serviceColaborador.BuscarColaboradorAsync(id);
		}

		// PUT: api/Colaboradores/5
		[HttpPut("{id}")]
		public async Task PutColaborador(Colaboradores colaboradores)
		{
			await _serviceColaborador.AtualizarColaboradorAsync(colaboradores);
		}

		// POST: api/Colaboradores
		[HttpPost]
		public async Task PostColaborador(Colaboradores cargo)
		{
			await _serviceColaborador.AdicionarColaboradorAsync(cargo);
		}

		// DELETE: api/Colaboradores/5
		[HttpDelete("{id}")]
		public async Task DeleteColaborador(int id)
		{

			await _serviceColaborador.DeletarColaboradorAsync(id);
		}

	}
}
