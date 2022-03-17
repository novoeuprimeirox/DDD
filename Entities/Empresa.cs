using Entities.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Empresa : Entity
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Site { get; set; }
        
        public int QuantidadeFuncionarios { get; set; }
    }
}
