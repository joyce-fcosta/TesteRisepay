using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
	[Table("Cargo")]
	public class Cargo
	{
		[Column("Id")]
		public int Id { get; set; }

		[Column("Nome")]
		public string Nome { get; set; }
	}
}
