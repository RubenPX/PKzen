using DataBaseBuilder.Entities;
using Microsoft.EntityFrameworkCore;
using Type = DataBaseBuilder.Entities.Type;


namespace DataBaseBuilder.DataBuilder;

public class PokemonDbContext(DbContextOptions<PokemonDbContext> options) : DbContext(options)
{
    public static DbSet<Ability> Ability { get; set; }
    public DbSet<Cries> Cries { get; set; }        
    public DbSet<DamageRelation> DamageRelation { get; set; }    
    public DbSet<EggGroup> EggGroup { get; set; }        
    public DbSet<EvolutionChain> EvolutionChain { get; set; }    
    public DbSet<EvolutionFamilyMember> EvolutionFamilyMember { get; set; }        
    public DbSet<Move> Move { get; set; }    
    public DbSet<Pokemon> Pokemon { get; set; }        
    public DbSet<PokemonAbility> PokemonAbility { get; set; }    
    public DbSet<PokemonStat> PokemonStat { get; set; }        
    public DbSet<Species> Species { get; set; }    
    public DbSet<SpeciesEggGroup> SpeciesEggGroup { get; set; }        
    public DbSet<SpeciesType> SpeciesType { get; set; }    
    public DbSet<Sprite> Sprite { get; set; }        
    public DbSet<Stat> Stat { get; set; }    
    public DbSet<StatChange> StatChange { get; set; }        
    public DbSet<Type> Type { get; set; }    
    public DbSet<Variety> Variety { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Entities.Ability.OnModelCreating(modelBuilder);
        Entities.Cries.OnModelCreating(modelBuilder);
        Entities.DamageRelation.OnModelCreating(modelBuilder);
        Entities.EggGroup.OnModelCreating(modelBuilder);
        Entities.EvolutionChain.OnModelCreating(modelBuilder);
        Entities.EvolutionFamilyMember.OnModelCreating(modelBuilder);
        Entities.Move.OnModelCreating(modelBuilder);
        Entities.Pokemon.OnModelCreating(modelBuilder);
        Entities.PokemonAbility.OnModelCreating(modelBuilder);
        Entities.PokemonStat.OnModelCreating(modelBuilder);
        Entities.Species.OnModelCreating(modelBuilder);
        Entities.SpeciesEggGroup.OnModelCreating(modelBuilder);
        Entities.SpeciesType.OnModelCreating(modelBuilder);
        Entities.Sprite.OnModelCreating(modelBuilder);
        Entities.Stat.OnModelCreating(modelBuilder);
        Entities.StatChange.OnModelCreating(modelBuilder);
        Entities.Type.OnModelCreating(modelBuilder);
        Entities.Variety.OnModelCreating(modelBuilder);
    }
}