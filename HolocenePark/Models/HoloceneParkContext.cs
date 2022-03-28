using Microsoft.EntityFrameworkCore;

namespace HolocenePark.Models
{
  public class HoloceneParkContext : DbContext
  {
    public HoloceneParkContext(DbContextOptions<HoloceneParkContext> options) : base(options)
    {
    }
    public DbSet<Animal> Animals { get; set; }
  }
}