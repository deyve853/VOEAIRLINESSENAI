using Microsoft.EntityFrameworkCore;
using VoeAirlinesSenai.Entities;

namespace VoeAirlinesSenai.Contexts;
public class VoeAirlinesSenaiContexts : DbContext
{
    private readonly IConfiguration _configuration;
    public VoeAirlinesSenaiContexts(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public DbSet<Aeronave> Aeronaves => Set<Aeronave>();
    public DbSet<Manutencao> Manutencaos => Set<Manutencao>();
    //public DbSet<Piloto>  Pilotos=> Set <Piloto>();
    //public DbSet<Voo>  Voos=> Set <Voo>();
    //public DbSet<Cancelamento>  Cancelamentos=> Set <Cancelamento>();
}
