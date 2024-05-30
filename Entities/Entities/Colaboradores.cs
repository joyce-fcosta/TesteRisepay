using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Entities.Entities
{
	[Table("Colaboradores")]
	public class Colaboradores
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		[Display(Name = "Cargo")]
		[ForeignKey("Cargo")]
		[Column(Order = 1)]
		public int Id_Cargo { get; set; }
		public Cargo CargoColaborador { get; set; }
	}
}