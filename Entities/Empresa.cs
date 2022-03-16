using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Empresa")]
    public class Empresa
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O nome da empresa é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O site é obrigatório", AllowEmptyStrings = false)]
        public string Site { get; set; }

        [Display(Name = "Quantida de funcionários")]
        public int QuantidadeFuncionarios { get; set; }
    }
}
