using Microsoft.EntityFrameworkCore;
using DinoAssetTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace DinoAssetTracker.Data
{
  public class DinoAssetContext : DbContext
  {
    public DbSet<Dinosaur> Dinosaurs { get; set; }
    public DinoAssetContext(DbContextOptions<DinoAssetContext> dbContextOptions) : base(dbContextOptions) { }

    public void Seed()
    {
      if(this.Dinosaurs.First() != null)
        return;

      HashSet<Dinosaur> dinosaurs = new HashSet<Dinosaur>
      {
        new Dinosaur { Name = "T-Rex" },
        new Dinosaur { Name = "Pterydactyl" },
        new Dinosaur { Name = "Triceratops" },
        new Dinosaur { Name = "Broncyosaurus" },
      };

      this.Dinosaurs.AddRange(dinosaurs);
      this.SaveChanges();
    }
  }
}