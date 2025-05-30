using Microsoft.EntityFrameworkCore;
using SistemaReservaEquipamentos.Models;
using System.Collections.Generic;

namespace SistemaReservaEquipamentos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
