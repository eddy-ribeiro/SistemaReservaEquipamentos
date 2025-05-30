using System.ComponentModel.DataAnnotations;

namespace SistemaReservaEquipamentos.Models
{
    public class Equipamento
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        public string? Descricao { get; set; }
    }
}

