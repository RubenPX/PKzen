using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class StatChange {
    public int Id { get; set; }
    public int Change { get; set; }
    public int StatId { get; set; }
    public int MoveId { get; set; }

    // Relación con Stat
    public Stat Stat { get; set; }

    // Relación con Move
    public Move Move { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<StatChange>(entity => {
            entity.HasKey(sc => sc.Id);

            entity.Property(sc => sc.Change).IsRequired();

            entity.HasOne(sc => sc.Stat)
                .WithMany()
                .HasForeignKey(sc => sc.StatId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(sc => sc.Move)
                .WithMany()
                .HasForeignKey(sc => sc.MoveId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
