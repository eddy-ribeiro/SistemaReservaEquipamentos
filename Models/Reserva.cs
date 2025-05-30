using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaReservaEquipamentos.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        [Required]
        public string NomeSolicitante { get; set; } = string.Empty;

        [Required]
        public DateTime DataReserva { get; set; }

        [Required]
        public int EquipamentoId { get; set; }

        [ForeignKey("EquipamentoId")]
        public Equipamento? Equipamento { get; set; }

        public string? Observacoes { get; set; }
    }
}
