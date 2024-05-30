using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Entities;
using Infra.Configuration;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.AspNetCore.Identity;

namespace Web_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CargosController : Controller
	{
		public readonly IServiceCargo _serviceCargo;
		public CargosController(IServiceCargo serviceCargo)
		{
			_serviceCargo = serviceCargo;

		}

		// GET: api/Cargos
		[HttpGet("/api/Cargos")]
		public async Task<ActionResult<IEnumerable<Cargo>>> GetCargo()
		{
			return await _serviceCargo.ListarCargoAsync();
		}

		// GET: api/Cargos/5
		[HttpGet("/api/Cargos/{id}")]
		public async Task<ActionResult<Cargo>> GetCargo(int id)
		{
			var cargo = await _serviceCargo.BuscarCargoAsync(id);

			if (cargo == null)
			{
				return NotFound();
			}

			return cargo;
		}

		// PUT: api/Cargos/5
		[HttpPut("/api/Cargos/{id}")]
		public async Task PutCargo(Cargo cargo)
		{
			await _serviceCargo.AtualizarCargoAsync(cargo);
		}

		// POST: api/Cargos
		[HttpPost]
		public async Task PostCargo(Cargo cargo)
		{
			 await _serviceCargo.AdicionarCargoAsync(cargo);
		}

		// DELETE: api/Cargos/5
		[HttpDelete("/api/Cargos/{id}")]
		public async Task DeleteCargo(int id)
		{

			await _serviceCargo.DeletarCargoAsync(id);
		}
		
	}
}
