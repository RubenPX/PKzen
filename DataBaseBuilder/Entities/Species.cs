using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class Species {
    public int Id { get; set; }
    public int BaseHappiness { get; set; }
    public int CaptureRate { get; set; }
    public string Color { get; set; }
    public string? FlavorText { get; set; }
    public bool FormsSwitchable { get; set; }
    public int GenderRate { get; set; }
    public string? Genera { get; set; }
    public string? Generation { get; set; }
    public string? Habitat { get; set; }
    public bool HasGenderDifferences { get; set; }
    public int HatchCounter { get; set; }
    public bool IsBaby { get; set; }
    public bool IsLegendary { get; set; }
    public bool IsMythical { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Species>(entity => {
            entity.HasKey(s => s.Id);
            entity.Property(s => s.BaseHappiness).IsRequired();
            entity.Property(s => s.CaptureRate).IsRequired();
            entity.Property(s => s.Color).IsRequired();
            entity.Property(s => s.FormsSwitchable).IsRequired();
            entity.Property(s => s.GenderRate).IsRequired();
            entity.Property(s => s.HasGenderDifferences).IsRequired();
            entity.Property(s => s.HatchCounter).IsRequired();
            entity.Property(s => s.IsBaby).IsRequired();
            entity.Property(s => s.IsLegendary).IsRequired();
            entity.Property(s => s.IsMythical).IsRequired();
        });
    }
}
