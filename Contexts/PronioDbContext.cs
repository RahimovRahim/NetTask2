using Microsoft.EntityFrameworkCore;

public class ProniaDbContext : DbContext
{
    public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
    {

    }
    public DbSet<Slider> Sliders { get; set; } = null!;
}