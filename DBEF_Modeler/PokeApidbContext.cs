using Microsoft.EntityFrameworkCore;

namespace DBEF_Modeler.Models_PokeAPI;

// NOTA: Esto ha sido autogenerado por Scaffolding y aplicando técnicas de ingeniería inversa
// https://learn.microsoft.com/es-es/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli

public partial class PokeApidbContext : DbContext {
    public PokeApidbContext() { }

    public PokeApidbContext(DbContextOptions<PokeApidbContext> options) : base(options) { }

    public virtual DbSet<PokemonV2Ability> PokemonV2Abilities { get; set; }
    public virtual DbSet<PokemonV2Abilitychange> PokemonV2Abilitychanges { get; set; }
    public virtual DbSet<PokemonV2Abilitychangeeffecttext> PokemonV2Abilitychangeeffecttexts { get; set; }
    public virtual DbSet<PokemonV2Abilityeffecttext> PokemonV2Abilityeffecttexts { get; set; }
    public virtual DbSet<PokemonV2Abilityflavortext> PokemonV2Abilityflavortexts { get; set; }
    public virtual DbSet<PokemonV2Abilityname> PokemonV2Abilitynames { get; set; }
    public virtual DbSet<PokemonV2Berry> PokemonV2Berries { get; set; }
    public virtual DbSet<PokemonV2Berryfirmness> PokemonV2Berryfirmnesses { get; set; }
    public virtual DbSet<PokemonV2Berryfirmnessname> PokemonV2Berryfirmnessnames { get; set; }
    public virtual DbSet<PokemonV2Berryflavor> PokemonV2Berryflavors { get; set; }
    public virtual DbSet<PokemonV2Berryflavormap> PokemonV2Berryflavormaps { get; set; }
    public virtual DbSet<PokemonV2Berryflavorname> PokemonV2Berryflavornames { get; set; }
    public virtual DbSet<PokemonV2Characteristic> PokemonV2Characteristics { get; set; }
    public virtual DbSet<PokemonV2Characteristicdescription> PokemonV2Characteristicdescriptions { get; set; }
    public virtual DbSet<PokemonV2Contestcombo> PokemonV2Contestcombos { get; set; }
    public virtual DbSet<PokemonV2Contesteffect> PokemonV2Contesteffects { get; set; }
    public virtual DbSet<PokemonV2Contesteffecteffecttext> PokemonV2Contesteffecteffecttexts { get; set; }
    public virtual DbSet<PokemonV2Contesteffectflavortext> PokemonV2Contesteffectflavortexts { get; set; }
    public virtual DbSet<PokemonV2Contesttype> PokemonV2Contesttypes { get; set; }
    public virtual DbSet<PokemonV2Contesttypename> PokemonV2Contesttypenames { get; set; }
    public virtual DbSet<PokemonV2Egggroup> PokemonV2Egggroups { get; set; }
    public virtual DbSet<PokemonV2Egggroupname> PokemonV2Egggroupnames { get; set; }
    public virtual DbSet<PokemonV2Encounter> PokemonV2Encounters { get; set; }
    public virtual DbSet<PokemonV2Encountercondition> PokemonV2Encounterconditions { get; set; }
    public virtual DbSet<PokemonV2Encounterconditionname> PokemonV2Encounterconditionnames { get; set; }
    public virtual DbSet<PokemonV2Encounterconditionvalue> PokemonV2Encounterconditionvalues { get; set; }
    public virtual DbSet<PokemonV2Encounterconditionvaluemap> PokemonV2Encounterconditionvaluemaps { get; set; }
    public virtual DbSet<PokemonV2Encounterconditionvaluename> PokemonV2Encounterconditionvaluenames { get; set; }
    public virtual DbSet<PokemonV2Encountermethod> PokemonV2Encountermethods { get; set; }
    public virtual DbSet<PokemonV2Encountermethodname> PokemonV2Encountermethodnames { get; set; }
    public virtual DbSet<PokemonV2Encounterslot> PokemonV2Encounterslots { get; set; }
    public virtual DbSet<PokemonV2Evolutionchain> PokemonV2Evolutionchains { get; set; }
    public virtual DbSet<PokemonV2Evolutiontrigger> PokemonV2Evolutiontriggers { get; set; }
    public virtual DbSet<PokemonV2Evolutiontriggername> PokemonV2Evolutiontriggernames { get; set; }
    public virtual DbSet<PokemonV2Experience> PokemonV2Experiences { get; set; }
    public virtual DbSet<PokemonV2Gender> PokemonV2Genders { get; set; }
    public virtual DbSet<PokemonV2Generation> PokemonV2Generations { get; set; }
    public virtual DbSet<PokemonV2Generationname> PokemonV2Generationnames { get; set; }
    public virtual DbSet<PokemonV2Growthrate> PokemonV2Growthrates { get; set; }
    public virtual DbSet<PokemonV2Growthratedescription> PokemonV2Growthratedescriptions { get; set; }
    public virtual DbSet<PokemonV2Item> PokemonV2Items { get; set; }
    public virtual DbSet<PokemonV2Itemattribute> PokemonV2Itemattributes { get; set; }
    public virtual DbSet<PokemonV2Itemattributedescription> PokemonV2Itemattributedescriptions { get; set; }
    public virtual DbSet<PokemonV2Itemattributemap> PokemonV2Itemattributemaps { get; set; }
    public virtual DbSet<PokemonV2Itemattributename> PokemonV2Itemattributenames { get; set; }
    public virtual DbSet<PokemonV2Itemcategory> PokemonV2Itemcategories { get; set; }
    public virtual DbSet<PokemonV2Itemcategoryname> PokemonV2Itemcategorynames { get; set; }
    public virtual DbSet<PokemonV2Itemeffecttext> PokemonV2Itemeffecttexts { get; set; }
    public virtual DbSet<PokemonV2Itemflavortext> PokemonV2Itemflavortexts { get; set; }
    public virtual DbSet<PokemonV2Itemflingeffect> PokemonV2Itemflingeffects { get; set; }
    public virtual DbSet<PokemonV2Itemflingeffecteffecttext> PokemonV2Itemflingeffecteffecttexts { get; set; }
    public virtual DbSet<PokemonV2Itemgameindex> PokemonV2Itemgameindices { get; set; }
    public virtual DbSet<PokemonV2Itemname> PokemonV2Itemnames { get; set; }
    public virtual DbSet<PokemonV2Itempocket> PokemonV2Itempockets { get; set; }
    public virtual DbSet<PokemonV2Itempocketname> PokemonV2Itempocketnames { get; set; }
    public virtual DbSet<PokemonV2Itemsprite> PokemonV2Itemsprites { get; set; }
    public virtual DbSet<PokemonV2Language> PokemonV2Languages { get; set; }
    public virtual DbSet<PokemonV2Languagename> PokemonV2Languagenames { get; set; }
    public virtual DbSet<PokemonV2Location> PokemonV2Locations { get; set; }
    public virtual DbSet<PokemonV2Locationarea> PokemonV2Locationareas { get; set; }
    public virtual DbSet<PokemonV2Locationareaencounterrate> PokemonV2Locationareaencounterrates { get; set; }
    public virtual DbSet<PokemonV2Locationareaname> PokemonV2Locationareanames { get; set; }
    public virtual DbSet<PokemonV2Locationgameindex> PokemonV2Locationgameindices { get; set; }
    public virtual DbSet<PokemonV2Locationname> PokemonV2Locationnames { get; set; }
    public virtual DbSet<PokemonV2Machine> PokemonV2Machines { get; set; }
    public virtual DbSet<PokemonV2Move> PokemonV2Moves { get; set; }
    public virtual DbSet<PokemonV2Moveattribute> PokemonV2Moveattributes { get; set; }
    public virtual DbSet<PokemonV2Moveattributedescription> PokemonV2Moveattributedescriptions { get; set; }
    public virtual DbSet<PokemonV2Moveattributemap> PokemonV2Moveattributemaps { get; set; }
    public virtual DbSet<PokemonV2Moveattributename> PokemonV2Moveattributenames { get; set; }
    public virtual DbSet<PokemonV2Movebattlestyle> PokemonV2Movebattlestyles { get; set; }
    public virtual DbSet<PokemonV2Movebattlestylename> PokemonV2Movebattlestylenames { get; set; }
    public virtual DbSet<PokemonV2Movechange> PokemonV2Movechanges { get; set; }
    public virtual DbSet<PokemonV2Movedamageclass> PokemonV2Movedamageclasses { get; set; }
    public virtual DbSet<PokemonV2Movedamageclassdescription> PokemonV2Movedamageclassdescriptions { get; set; }
    public virtual DbSet<PokemonV2Movedamageclassname> PokemonV2Movedamageclassnames { get; set; }
    public virtual DbSet<PokemonV2Moveeffect> PokemonV2Moveeffects { get; set; }
    public virtual DbSet<PokemonV2Moveeffectchange> PokemonV2Moveeffectchanges { get; set; }
    public virtual DbSet<PokemonV2Moveeffectchangeeffecttext> PokemonV2Moveeffectchangeeffecttexts { get; set; }
    public virtual DbSet<PokemonV2Moveeffecteffecttext> PokemonV2Moveeffecteffecttexts { get; set; }
    public virtual DbSet<PokemonV2Moveflavortext> PokemonV2Moveflavortexts { get; set; }
    public virtual DbSet<PokemonV2Movelearnmethod> PokemonV2Movelearnmethods { get; set; }
    public virtual DbSet<PokemonV2Movelearnmethoddescription> PokemonV2Movelearnmethoddescriptions { get; set; }
    public virtual DbSet<PokemonV2Movelearnmethodname> PokemonV2Movelearnmethodnames { get; set; }
    public virtual DbSet<PokemonV2Movemetaailment> PokemonV2Movemetaailments { get; set; }
    public virtual DbSet<PokemonV2Movemetaailmentname> PokemonV2Movemetaailmentnames { get; set; }
    public virtual DbSet<PokemonV2Movemetacategory> PokemonV2Movemetacategories { get; set; }
    public virtual DbSet<PokemonV2Movemetacategorydescription> PokemonV2Movemetacategorydescriptions { get; set; }
    public virtual DbSet<PokemonV2Movemetastatchange> PokemonV2Movemetastatchanges { get; set; }
    public virtual DbSet<PokemonV2Movemetum> PokemonV2Movemeta { get; set; }
    public virtual DbSet<PokemonV2Movename> PokemonV2Movenames { get; set; }
    public virtual DbSet<PokemonV2Movetarget> PokemonV2Movetargets { get; set; }
    public virtual DbSet<PokemonV2Movetargetdescription> PokemonV2Movetargetdescriptions { get; set; }
    public virtual DbSet<PokemonV2Movetargetname> PokemonV2Movetargetnames { get; set; }
    public virtual DbSet<PokemonV2Nature> PokemonV2Natures { get; set; }
    public virtual DbSet<PokemonV2Naturebattlestylepreference> PokemonV2Naturebattlestylepreferences { get; set; }
    public virtual DbSet<PokemonV2Naturename> PokemonV2Naturenames { get; set; }
    public virtual DbSet<PokemonV2Naturepokeathlonstat> PokemonV2Naturepokeathlonstats { get; set; }
    public virtual DbSet<PokemonV2Palpark> PokemonV2Palparks { get; set; }
    public virtual DbSet<PokemonV2Palparkarea> PokemonV2Palparkareas { get; set; }
    public virtual DbSet<PokemonV2Palparkareaname> PokemonV2Palparkareanames { get; set; }
    public virtual DbSet<PokemonV2Pokeathlonstat> PokemonV2Pokeathlonstats { get; set; }
    public virtual DbSet<PokemonV2Pokeathlonstatname> PokemonV2Pokeathlonstatnames { get; set; }
    public virtual DbSet<PokemonV2Pokedex> PokemonV2Pokedices { get; set; }
    public virtual DbSet<PokemonV2Pokedexdescription> PokemonV2Pokedexdescriptions { get; set; }
    public virtual DbSet<PokemonV2Pokedexname> PokemonV2Pokedexnames { get; set; }
    public virtual DbSet<PokemonV2Pokedexversiongroup> PokemonV2Pokedexversiongroups { get; set; }
    public virtual DbSet<PokemonV2Pokemon> PokemonV2Pokemons { get; set; }
    public virtual DbSet<PokemonV2Pokemonability> PokemonV2Pokemonabilities { get; set; }
    public virtual DbSet<PokemonV2Pokemonabilitypast> PokemonV2Pokemonabilitypasts { get; set; }
    public virtual DbSet<PokemonV2Pokemoncolor> PokemonV2Pokemoncolors { get; set; }
    public virtual DbSet<PokemonV2Pokemoncolorname> PokemonV2Pokemoncolornames { get; set; }
    public virtual DbSet<PokemonV2Pokemoncry> PokemonV2Pokemoncries { get; set; }
    public virtual DbSet<PokemonV2Pokemondexnumber> PokemonV2Pokemondexnumbers { get; set; }
    public virtual DbSet<PokemonV2Pokemonegggroup> PokemonV2Pokemonegggroups { get; set; }
    public virtual DbSet<PokemonV2Pokemonevolution> PokemonV2Pokemonevolutions { get; set; }
    public virtual DbSet<PokemonV2Pokemonform> PokemonV2Pokemonforms { get; set; }
    public virtual DbSet<PokemonV2Pokemonformgeneration> PokemonV2Pokemonformgenerations { get; set; }
    public virtual DbSet<PokemonV2Pokemonformname> PokemonV2Pokemonformnames { get; set; }
    public virtual DbSet<PokemonV2Pokemonformsprite> PokemonV2Pokemonformsprites { get; set; }
    public virtual DbSet<PokemonV2Pokemonformtype> PokemonV2Pokemonformtypes { get; set; }
    public virtual DbSet<PokemonV2Pokemongameindex> PokemonV2Pokemongameindices { get; set; }
    public virtual DbSet<PokemonV2Pokemonhabitat> PokemonV2Pokemonhabitats { get; set; }
    public virtual DbSet<PokemonV2Pokemonhabitatname> PokemonV2Pokemonhabitatnames { get; set; }
    public virtual DbSet<PokemonV2Pokemonitem> PokemonV2Pokemonitems { get; set; }
    public virtual DbSet<PokemonV2Pokemonmove> PokemonV2Pokemonmoves { get; set; }
    public virtual DbSet<PokemonV2Pokemonshape> PokemonV2Pokemonshapes { get; set; }
    public virtual DbSet<PokemonV2Pokemonshapename> PokemonV2Pokemonshapenames { get; set; }
    public virtual DbSet<PokemonV2Pokemonspeciesdescription> PokemonV2Pokemonspeciesdescriptions { get; set; }
    public virtual DbSet<PokemonV2Pokemonspeciesflavortext> PokemonV2Pokemonspeciesflavortexts { get; set; }
    public virtual DbSet<PokemonV2Pokemonspeciesname> PokemonV2Pokemonspeciesnames { get; set; }
    public virtual DbSet<PokemonV2Pokemonspecy> PokemonV2Pokemonspecies { get; set; }
    public virtual DbSet<PokemonV2Pokemonsprite> PokemonV2Pokemonsprites { get; set; }
    public virtual DbSet<PokemonV2Pokemonstat> PokemonV2Pokemonstats { get; set; }
    public virtual DbSet<PokemonV2Pokemontype> PokemonV2Pokemontypes { get; set; }
    public virtual DbSet<PokemonV2Pokemontypepast> PokemonV2Pokemontypepasts { get; set; }
    public virtual DbSet<PokemonV2Region> PokemonV2Regions { get; set; }
    public virtual DbSet<PokemonV2Regionname> PokemonV2Regionnames { get; set; }
    public virtual DbSet<PokemonV2Stat> PokemonV2Stats { get; set; }
    public virtual DbSet<PokemonV2Statname> PokemonV2Statnames { get; set; }
    public virtual DbSet<PokemonV2Supercontestcombo> PokemonV2Supercontestcombos { get; set; }
    public virtual DbSet<PokemonV2Supercontesteffect> PokemonV2Supercontesteffects { get; set; }
    public virtual DbSet<PokemonV2Supercontesteffectflavortext> PokemonV2Supercontesteffectflavortexts { get; set; }
    public virtual DbSet<PokemonV2Type> PokemonV2Types { get; set; }
    public virtual DbSet<PokemonV2Typeefficacy> PokemonV2Typeefficacies { get; set; }
    public virtual DbSet<PokemonV2Typeefficacypast> PokemonV2Typeefficacypasts { get; set; }
    public virtual DbSet<PokemonV2Typegameindex> PokemonV2Typegameindices { get; set; }
    public virtual DbSet<PokemonV2Typename> PokemonV2Typenames { get; set; }
    public virtual DbSet<PokemonV2Typesprite> PokemonV2Typesprites { get; set; }
    public virtual DbSet<PokemonV2Version> PokemonV2Versions { get; set; }
    public virtual DbSet<PokemonV2Versiongroup> PokemonV2Versiongroups { get; set; }
    public virtual DbSet<PokemonV2Versiongroupmovelearnmethod> PokemonV2Versiongroupmovelearnmethods { get; set; }
    public virtual DbSet<PokemonV2Versiongroupregion> PokemonV2Versiongroupregions { get; set; }
    public virtual DbSet<PokemonV2Versionname> PokemonV2Versionnames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=../../../PokeAPIDB.sqlite3");

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<PokemonV2Ability>(entity => {
            entity.ToTable("pokemon_v2_ability");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_ability_generation_id_225aa68a");

            entity.HasIndex(e => e.Name, "pokemon_v2_ability_name_744d1800");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.IsMainSeries)
                .HasColumnType("bool")
                .HasColumnName("is_main_series");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Abilities).HasForeignKey(d => d.GenerationId);
        });

        modelBuilder.Entity<PokemonV2Abilitychange>(entity => {
            entity.ToTable("pokemon_v2_abilitychange");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_abilitychange_ability_id_b263505f");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_abilitychange_version_group_id_04bcdf19");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Ability).WithMany(p => p.PokemonV2Abilitychanges).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Abilitychanges).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Abilitychangeeffecttext>(entity => {
            entity.ToTable("pokemon_v2_abilitychangeeffecttext");

            entity.HasIndex(e => e.AbilityChangeId, "pokemon_v2_abilitychangeeffecttext_ability_change_id_7b10479d");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_abilitychangeeffecttext_language_id_ed14bf34");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityChangeId).HasColumnName("ability_change_id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.AbilityChange).WithMany(p => p.PokemonV2Abilitychangeeffecttexts).HasForeignKey(d => d.AbilityChangeId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Abilitychangeeffecttexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Abilityeffecttext>(entity => {
            entity.ToTable("pokemon_v2_abilityeffecttext");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_abilityeffecttext_ability_id_9fe65f70");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_abilityeffecttext_language_id_9a3fc9eb");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.ShortEffect)
                .HasColumnType("varchar(300)")
                .HasColumnName("short_effect");

            entity.HasOne(d => d.Ability).WithMany(p => p.PokemonV2Abilityeffecttexts).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Abilityeffecttexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Abilityflavortext>(entity => {
            entity.ToTable("pokemon_v2_abilityflavortext");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_abilityflavortext_ability_id_8c20d4bf");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_abilityflavortext_language_id_91dfb962");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_abilityflavortext_version_group_id_a379dd5d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Ability).WithMany(p => p.PokemonV2Abilityflavortexts).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Abilityflavortexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Abilityflavortexts).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Abilityname>(entity => {
            entity.ToTable("pokemon_v2_abilityname");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_abilityname_ability_id_2753864d");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_abilityname_language_id_e64c37fb");

            entity.HasIndex(e => e.Name, "pokemon_v2_abilityname_name_8db2ae39");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Ability).WithMany(p => p.PokemonV2Abilitynames).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Abilitynames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Berry>(entity => {
            entity.ToTable("pokemon_v2_berry");

            entity.HasIndex(e => e.BerryFirmnessId, "pokemon_v2_berry_berry_firmness_id_780e6268");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_berry_item_id_72a1ed81");

            entity.HasIndex(e => e.Name, "pokemon_v2_berry_name_4eaa4d0f");

            entity.HasIndex(e => e.NaturalGiftTypeId, "pokemon_v2_berry_natural_gift_type_id_7d76f035");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BerryFirmnessId).HasColumnName("berry_firmness_id");
            entity.Property(e => e.GrowthTime).HasColumnName("growth_time");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.MaxHarvest).HasColumnName("max_harvest");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.NaturalGiftPower).HasColumnName("natural_gift_power");
            entity.Property(e => e.NaturalGiftTypeId).HasColumnName("natural_gift_type_id");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Smoothness).HasColumnName("smoothness");
            entity.Property(e => e.SoilDryness).HasColumnName("soil_dryness");

            entity.HasOne(d => d.BerryFirmness).WithMany(p => p.PokemonV2Berries).HasForeignKey(d => d.BerryFirmnessId);

            entity.HasOne(d => d.Item).WithMany(p => p.PokemonV2Berries).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.NaturalGiftType).WithMany(p => p.PokemonV2Berries).HasForeignKey(d => d.NaturalGiftTypeId);
        });

        modelBuilder.Entity<PokemonV2Berryfirmness>(entity => {
            entity.ToTable("pokemon_v2_berryfirmness");

            entity.HasIndex(e => e.Name, "pokemon_v2_berryfirmness_name_13b8b31d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Berryfirmnessname>(entity => {
            entity.ToTable("pokemon_v2_berryfirmnessname");

            entity.HasIndex(e => e.BerryFirmnessId, "pokemon_v2_berryfirmnessname_berry_firmness_id_905d4dcf");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_berryfirmnessname_language_id_7e7f395e");

            entity.HasIndex(e => e.Name, "pokemon_v2_berryfirmnessname_name_2a74382f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BerryFirmnessId).HasColumnName("berry_firmness_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.BerryFirmness).WithMany(p => p.PokemonV2Berryfirmnessnames).HasForeignKey(d => d.BerryFirmnessId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Berryfirmnessnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Berryflavor>(entity => {
            entity.ToTable("pokemon_v2_berryflavor");

            entity.HasIndex(e => e.ContestTypeId, "IX_pokemon_v2_berryflavor_contest_type_id").IsUnique();

            entity.HasIndex(e => e.Name, "pokemon_v2_berryflavor_name_b33ebfb3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ContestType).WithOne(p => p.PokemonV2Berryflavor).HasForeignKey<PokemonV2Berryflavor>(d => d.ContestTypeId);
        });

        modelBuilder.Entity<PokemonV2Berryflavormap>(entity => {
            entity.ToTable("pokemon_v2_berryflavormap");

            entity.HasIndex(e => e.BerryFlavorId, "pokemon_v2_berryflavormap_berry_flavor_id_65cf6f73");

            entity.HasIndex(e => e.BerryId, "pokemon_v2_berryflavormap_berry_id_e4a753e4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BerryFlavorId).HasColumnName("berry_flavor_id");
            entity.Property(e => e.BerryId).HasColumnName("berry_id");
            entity.Property(e => e.Potency).HasColumnName("potency");

            entity.HasOne(d => d.BerryFlavor).WithMany(p => p.PokemonV2Berryflavormaps).HasForeignKey(d => d.BerryFlavorId);

            entity.HasOne(d => d.Berry).WithMany(p => p.PokemonV2Berryflavormaps).HasForeignKey(d => d.BerryId);
        });

        modelBuilder.Entity<PokemonV2Berryflavorname>(entity => {
            entity.ToTable("pokemon_v2_berryflavorname");

            entity.HasIndex(e => e.BerryFlavorId, "pokemon_v2_berryflavorname_berry_flavor_id_1dd899da");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_berryflavorname_language_id_fa96a7af");

            entity.HasIndex(e => e.Name, "pokemon_v2_berryflavorname_name_c499b01c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BerryFlavorId).HasColumnName("berry_flavor_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.BerryFlavor).WithMany(p => p.PokemonV2Berryflavornames).HasForeignKey(d => d.BerryFlavorId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Berryflavornames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Characteristic>(entity => {
            entity.ToTable("pokemon_v2_characteristic");

            entity.HasIndex(e => e.StatId, "pokemon_v2_characteristic_stat_id_cf62870d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GeneMod5).HasColumnName("gene_mod_5");
            entity.Property(e => e.StatId).HasColumnName("stat_id");

            entity.HasOne(d => d.Stat).WithMany(p => p.PokemonV2Characteristics).HasForeignKey(d => d.StatId);
        });

        modelBuilder.Entity<PokemonV2Characteristicdescription>(entity => {
            entity.ToTable("pokemon_v2_characteristicdescription");

            entity.HasIndex(e => e.CharacteristicId, "pokemon_v2_characteristicdescription_characteristic_id_a943ddcf");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_characteristicdescription_language_id_48d9a020");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CharacteristicId).HasColumnName("characteristic_id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(1000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.Characteristic).WithMany(p => p.PokemonV2Characteristicdescriptions).HasForeignKey(d => d.CharacteristicId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Characteristicdescriptions).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Contestcombo>(entity => {
            entity.ToTable("pokemon_v2_contestcombo");

            entity.HasIndex(e => e.FirstMoveId, "pokemon_v2_contestcombo_first_move_id_e86fe950");

            entity.HasIndex(e => e.SecondMoveId, "pokemon_v2_contestcombo_second_move_id_5bf6f920");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstMoveId).HasColumnName("first_move_id");
            entity.Property(e => e.SecondMoveId).HasColumnName("second_move_id");

            entity.HasOne(d => d.FirstMove).WithMany(p => p.PokemonV2ContestcomboFirstMoves).HasForeignKey(d => d.FirstMoveId);

            entity.HasOne(d => d.SecondMove).WithMany(p => p.PokemonV2ContestcomboSecondMoves).HasForeignKey(d => d.SecondMoveId);
        });

        modelBuilder.Entity<PokemonV2Contesteffect>(entity => {
            entity.ToTable("pokemon_v2_contesteffect");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appeal).HasColumnName("appeal");
            entity.Property(e => e.Jam).HasColumnName("jam");
        });

        modelBuilder.Entity<PokemonV2Contesteffecteffecttext>(entity => {
            entity.ToTable("pokemon_v2_contesteffecteffecttext");

            entity.HasIndex(e => e.ContestEffectId, "pokemon_v2_contesteffecteffecttext_contest_effect_id_523f86e5");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_contesteffecteffecttext_language_id_0e98da56");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContestEffectId).HasColumnName("contest_effect_id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.ContestEffect).WithMany(p => p.PokemonV2Contesteffecteffecttexts).HasForeignKey(d => d.ContestEffectId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Contesteffecteffecttexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Contesteffectflavortext>(entity => {
            entity.ToTable("pokemon_v2_contesteffectflavortext");

            entity.HasIndex(e => e.ContestEffectId, "pokemon_v2_contesteffectflavortext_contest_effect_id_73bd43b4");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_contesteffectflavortext_language_id_a584e527");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContestEffectId).HasColumnName("contest_effect_id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.ContestEffect).WithMany(p => p.PokemonV2Contesteffectflavortexts).HasForeignKey(d => d.ContestEffectId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Contesteffectflavortexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Contesttype>(entity => {
            entity.ToTable("pokemon_v2_contesttype");

            entity.HasIndex(e => e.Name, "pokemon_v2_contesttype_name_18e75f76");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Contesttypename>(entity => {
            entity.ToTable("pokemon_v2_contesttypename");

            entity.HasIndex(e => e.ContestTypeId, "pokemon_v2_contesttypename_contest_type_id_08e7cb9d");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_contesttypename_language_id_2113d494");

            entity.HasIndex(e => e.Name, "pokemon_v2_contesttypename_name_270b053a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasColumnType("varchar(10)")
                .HasColumnName("color");
            entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");
            entity.Property(e => e.Flavor)
                .HasColumnType("varchar(10)")
                .HasColumnName("flavor");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ContestType).WithMany(p => p.PokemonV2Contesttypenames).HasForeignKey(d => d.ContestTypeId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Contesttypenames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Egggroup>(entity => {
            entity.ToTable("pokemon_v2_egggroup");

            entity.HasIndex(e => e.Name, "pokemon_v2_egggroup_name_452dc3a4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Egggroupname>(entity => {
            entity.ToTable("pokemon_v2_egggroupname");

            entity.HasIndex(e => e.EggGroupId, "pokemon_v2_egggroupname_egg_group_id_0e05a091");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_egggroupname_language_id_b233cbf3");

            entity.HasIndex(e => e.Name, "pokemon_v2_egggroupname_name_4ae8920c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EggGroupId).HasColumnName("egg_group_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EggGroup).WithMany(p => p.PokemonV2Egggroupnames).HasForeignKey(d => d.EggGroupId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Egggroupnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Encounter>(entity => {
            entity.ToTable("pokemon_v2_encounter");

            entity.HasIndex(e => e.EncounterSlotId, "pokemon_v2_encounter_encounter_slot_id_67f269af");

            entity.HasIndex(e => e.LocationAreaId, "pokemon_v2_encounter_location_area_id_fa408e67");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_encounter_pokemon_id_a4a76f85");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_encounter_version_id_46932476");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterSlotId).HasColumnName("encounter_slot_id");
            entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.MinLevel).HasColumnName("min_level");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.EncounterSlot).WithMany(p => p.PokemonV2Encounters).HasForeignKey(d => d.EncounterSlotId);

            entity.HasOne(d => d.LocationArea).WithMany(p => p.PokemonV2Encounters).HasForeignKey(d => d.LocationAreaId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Encounters).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Version).WithMany(p => p.PokemonV2Encounters).HasForeignKey(d => d.VersionId);
        });

        modelBuilder.Entity<PokemonV2Encountercondition>(entity => {
            entity.ToTable("pokemon_v2_encountercondition");

            entity.HasIndex(e => e.Name, "pokemon_v2_encountercondition_name_6825a841");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Encounterconditionname>(entity => {
            entity.ToTable("pokemon_v2_encounterconditionname");

            entity.HasIndex(e => e.EncounterConditionId, "pokemon_v2_encounterconditionname_encounter_condition_id_07da9a9c");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_encounterconditionname_language_id_15462dd7");

            entity.HasIndex(e => e.Name, "pokemon_v2_encounterconditionname_name_9140f29e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterConditionId).HasColumnName("encounter_condition_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EncounterCondition).WithMany(p => p.PokemonV2Encounterconditionnames).HasForeignKey(d => d.EncounterConditionId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Encounterconditionnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Encounterconditionvalue>(entity => {
            entity.ToTable("pokemon_v2_encounterconditionvalue");

            entity.HasIndex(e => e.EncounterConditionId, "pokemon_v2_encounterconditionvalue_encounter_condition_id_e246ac97");

            entity.HasIndex(e => e.Name, "pokemon_v2_encounterconditionvalue_name_fd9a9104");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterConditionId).HasColumnName("encounter_condition_id");
            entity.Property(e => e.IsDefault)
                .HasColumnType("bool")
                .HasColumnName("is_default");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EncounterCondition).WithMany(p => p.PokemonV2Encounterconditionvalues).HasForeignKey(d => d.EncounterConditionId);
        });

        modelBuilder.Entity<PokemonV2Encounterconditionvaluemap>(entity => {
            entity.ToTable("pokemon_v2_encounterconditionvaluemap");

            entity.HasIndex(e => e.EncounterConditionValueId, "pokemon_v2_encounterconditionvaluemap_encounter_condition_value_id_aea7c219");

            entity.HasIndex(e => e.EncounterId, "pokemon_v2_encounterconditionvaluemap_encounter_id_07cf7d14");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterConditionValueId).HasColumnName("encounter_condition_value_id");
            entity.Property(e => e.EncounterId).HasColumnName("encounter_id");

            entity.HasOne(d => d.EncounterConditionValue).WithMany(p => p.PokemonV2Encounterconditionvaluemaps).HasForeignKey(d => d.EncounterConditionValueId);

            entity.HasOne(d => d.Encounter).WithMany(p => p.PokemonV2Encounterconditionvaluemaps).HasForeignKey(d => d.EncounterId);
        });

        modelBuilder.Entity<PokemonV2Encounterconditionvaluename>(entity => {
            entity.ToTable("pokemon_v2_encounterconditionvaluename");

            entity.HasIndex(e => e.EncounterConditionValueId, "pokemon_v2_encounterconditionvaluename_encounter_condition_value_id_30a8cc50");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_encounterconditionvaluename_language_id_759f2aa7");

            entity.HasIndex(e => e.Name, "pokemon_v2_encounterconditionvaluename_name_09aada74");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterConditionValueId).HasColumnName("encounter_condition_value_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EncounterConditionValue).WithMany(p => p.PokemonV2Encounterconditionvaluenames).HasForeignKey(d => d.EncounterConditionValueId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Encounterconditionvaluenames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Encountermethod>(entity => {
            entity.ToTable("pokemon_v2_encountermethod");

            entity.HasIndex(e => e.Name, "pokemon_v2_encountermethod_name_807a7363");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
        });

        modelBuilder.Entity<PokemonV2Encountermethodname>(entity => {
            entity.ToTable("pokemon_v2_encountermethodname");

            entity.HasIndex(e => e.EncounterMethodId, "pokemon_v2_encountermethodname_encounter_method_id_f0b81197");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_encountermethodname_language_id_df10978f");

            entity.HasIndex(e => e.Name, "pokemon_v2_encountermethodname_name_c50b0da6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EncounterMethod).WithMany(p => p.PokemonV2Encountermethodnames).HasForeignKey(d => d.EncounterMethodId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Encountermethodnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Encounterslot>(entity => {
            entity.ToTable("pokemon_v2_encounterslot");

            entity.HasIndex(e => e.EncounterMethodId, "pokemon_v2_encounterslot_encounter_method_id_b9a4d963");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_encounterslot_version_group_id_de2e9658");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");
            entity.Property(e => e.Rarity).HasColumnName("rarity");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.EncounterMethod).WithMany(p => p.PokemonV2Encounterslots).HasForeignKey(d => d.EncounterMethodId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Encounterslots).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Evolutionchain>(entity => {
            entity.ToTable("pokemon_v2_evolutionchain");

            entity.HasIndex(e => e.BabyTriggerItemId, "pokemon_v2_evolutionchain_baby_trigger_item_id_8341ae6a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BabyTriggerItemId).HasColumnName("baby_trigger_item_id");

            entity.HasOne(d => d.BabyTriggerItem).WithMany(p => p.PokemonV2Evolutionchains).HasForeignKey(d => d.BabyTriggerItemId);
        });

        modelBuilder.Entity<PokemonV2Evolutiontrigger>(entity => {
            entity.ToTable("pokemon_v2_evolutiontrigger");

            entity.HasIndex(e => e.Name, "pokemon_v2_evolutiontrigger_name_5e94bd81");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Evolutiontriggername>(entity => {
            entity.ToTable("pokemon_v2_evolutiontriggername");

            entity.HasIndex(e => e.EvolutionTriggerId, "pokemon_v2_evolutiontriggername_evolution_trigger_id_9d66b90d");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_evolutiontriggername_language_id_9a05e0c7");

            entity.HasIndex(e => e.Name, "pokemon_v2_evolutiontriggername_name_8119ef67");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EvolutionTriggerId).HasColumnName("evolution_trigger_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.EvolutionTrigger).WithMany(p => p.PokemonV2Evolutiontriggernames).HasForeignKey(d => d.EvolutionTriggerId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Evolutiontriggernames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Experience>(entity => {
            entity.ToTable("pokemon_v2_experience");

            entity.HasIndex(e => e.GrowthRateId, "pokemon_v2_experience_growth_rate_id_42dcd743");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Experience).HasColumnName("experience");
            entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");
            entity.Property(e => e.Level).HasColumnName("level");

            entity.HasOne(d => d.GrowthRate).WithMany(p => p.PokemonV2Experiences).HasForeignKey(d => d.GrowthRateId);
        });

        modelBuilder.Entity<PokemonV2Gender>(entity => {
            entity.ToTable("pokemon_v2_gender");

            entity.HasIndex(e => e.Name, "pokemon_v2_gender_name_40507af4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Generation>(entity => {
            entity.ToTable("pokemon_v2_generation");

            entity.HasIndex(e => e.RegionId, "IX_pokemon_v2_generation_region_id").IsUnique();

            entity.HasIndex(e => e.Name, "pokemon_v2_generation_name_6e9940f4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.RegionId).HasColumnName("region_id");

            entity.HasOne(d => d.Region).WithOne(p => p.PokemonV2Generation).HasForeignKey<PokemonV2Generation>(d => d.RegionId);
        });

        modelBuilder.Entity<PokemonV2Generationname>(entity => {
            entity.ToTable("pokemon_v2_generationname");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_generationname_generation_id_9f22cdbb");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_generationname_language_id_4e855215");

            entity.HasIndex(e => e.Name, "pokemon_v2_generationname_name_f79c2051");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Generationnames).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Generationnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Growthrate>(entity => {
            entity.ToTable("pokemon_v2_growthrate");

            entity.HasIndex(e => e.Name, "pokemon_v2_growthrate_name_1926e11a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Formula)
                .HasColumnType("varchar(500)")
                .HasColumnName("formula");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Growthratedescription>(entity => {
            entity.ToTable("pokemon_v2_growthratedescription");

            entity.HasIndex(e => e.GrowthRateId, "pokemon_v2_growthratedescription_growth_rate_id_2e126dd5");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_growthratedescription_language_id_5bbe9b57");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(1000)")
                .HasColumnName("description");
            entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.GrowthRate).WithMany(p => p.PokemonV2Growthratedescriptions).HasForeignKey(d => d.GrowthRateId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Growthratedescriptions).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Item>(entity => {
            entity.ToTable("pokemon_v2_item");

            entity.HasIndex(e => e.ItemCategoryId, "pokemon_v2_item_item_category_id_9f55b7ca");

            entity.HasIndex(e => e.ItemFlingEffectId, "pokemon_v2_item_item_fling_effect_id_8e7cefaa");

            entity.HasIndex(e => e.Name, "pokemon_v2_item_name_5597f95e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.FlingPower).HasColumnName("fling_power");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.ItemFlingEffectId).HasColumnName("item_fling_effect_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.PokemonV2Items).HasForeignKey(d => d.ItemCategoryId);

            entity.HasOne(d => d.ItemFlingEffect).WithMany(p => p.PokemonV2Items).HasForeignKey(d => d.ItemFlingEffectId);
        });

        modelBuilder.Entity<PokemonV2Itemattribute>(entity => {
            entity.ToTable("pokemon_v2_itemattribute");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemattribute_name_7e365d21");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Itemattributedescription>(entity => {
            entity.ToTable("pokemon_v2_itemattributedescription");

            entity.HasIndex(e => e.ItemAttributeId, "pokemon_v2_itemattributedescription_item_attribute_id_cdd96fff");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemattributedescription_language_id_5385b04c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(1000)")
                .HasColumnName("description");
            entity.Property(e => e.ItemAttributeId).HasColumnName("item_attribute_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.ItemAttribute).WithMany(p => p.PokemonV2Itemattributedescriptions).HasForeignKey(d => d.ItemAttributeId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Itemattributedescriptions).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Itemattributemap>(entity => {
            entity.ToTable("pokemon_v2_itemattributemap");

            entity.HasIndex(e => e.ItemAttributeId, "pokemon_v2_itemattributemap_item_attribute_id_e6cd252f");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemattributemap_item_id_e6dba1a6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemAttributeId).HasColumnName("item_attribute_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");

            entity.HasOne(d => d.ItemAttribute).WithMany(p => p.PokemonV2Itemattributemaps).HasForeignKey(d => d.ItemAttributeId);

            entity.HasOne(d => d.Item).WithMany(p => p.PokemonV2Itemattributemaps).HasForeignKey(d => d.ItemId);
        });

        modelBuilder.Entity<PokemonV2Itemattributename>(entity => {
            entity.ToTable("pokemon_v2_itemattributename");

            entity.HasIndex(e => e.ItemAttributeId, "pokemon_v2_itemattributename_item_attribute_id_85acc7f5");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemattributename_language_id_e36a7fe1");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemattributename_name_3e2ccd4a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemAttributeId).HasColumnName("item_attribute_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ItemAttribute).WithMany(p => p.PokemonV2Itemattributenames).HasForeignKey(d => d.ItemAttributeId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Itemattributenames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Itemcategory>(entity => {
            entity.ToTable("pokemon_v2_itemcategory");

            entity.HasIndex(e => e.ItemPocketId, "pokemon_v2_itemcategory_item_pocket_id_8ebf7645");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemcategory_name_54594288");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemPocketId).HasColumnName("item_pocket_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ItemPocket).WithMany(p => p.PokemonV2Itemcategories).HasForeignKey(d => d.ItemPocketId);
        });

        modelBuilder.Entity<PokemonV2Itemcategoryname>(entity => {
            entity.ToTable("pokemon_v2_itemcategoryname");

            entity.HasIndex(e => e.ItemCategoryId, "pokemon_v2_itemcategoryname_item_category_id_10412a45");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemcategoryname_language_id_6a5424db");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemcategoryname_name_b0889e22");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.PokemonV2Itemcategorynames).HasForeignKey(d => d.ItemCategoryId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Itemcategorynames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Itemeffecttext>(entity => {
            entity.ToTable("pokemon_v2_itemeffecttext");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemeffecttext_item_id_2fb7601c");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemeffecttext_language_id_53e95659");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.ShortEffect)
                .HasColumnType("varchar(300)")
                .HasColumnName("short_effect");

            entity.HasOne(d => d.Item).WithMany(p => p.PokemonV2Itemeffecttexts).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Itemeffecttexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Itemflavortext>(entity => {
            entity.ToTable("pokemon_v2_itemflavortext");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemflavortext_item_id_f2575960");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemflavortext_language_id_dee91cde");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_itemflavortext_version_group_id_20b07485");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Item).WithMany(p => p.PokemonV2Itemflavortexts).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Itemflavortexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Itemflavortexts).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Itemflingeffect>(entity => {
            entity.ToTable("pokemon_v2_itemflingeffect");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemflingeffect_name_bcd91c57");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Itemflingeffecteffecttext>(entity => {
            entity.ToTable("pokemon_v2_itemflingeffecteffecttext");

            entity.HasIndex(e => e.ItemFlingEffectId, "pokemon_v2_itemflingeffecteffecttext_item_fling_effect_id_31f3ddda");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemflingeffecteffecttext_language_id_7c369333");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.ItemFlingEffectId).HasColumnName("item_fling_effect_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");

            entity.HasOne(d => d.ItemFlingEffect).WithMany(p => p.PokemonV2Itemflingeffecteffecttexts).HasForeignKey(d => d.ItemFlingEffectId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Itemflingeffecteffecttexts).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Itemgameindex>(entity => {
            entity.ToTable("pokemon_v2_itemgameindex");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_itemgameindex_generation_id_a182ee37");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemgameindex_item_id_518e20fd");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Itemgameindices).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Item).WithMany(p => p.PokemonV2Itemgameindices).HasForeignKey(d => d.ItemId);
        });

        modelBuilder.Entity<PokemonV2Itemname>(entity => {
            entity.ToTable("pokemon_v2_itemname");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemname_item_id_cf942d90");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itemname_language_id_69bf5660");

            entity.HasIndex(e => e.Name, "pokemon_v2_itemname_name_4b3fc446");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Item).WithMany(p => p.PokemonV2Itemnames).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Itemnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Itempocket>(entity => {
            entity.ToTable("pokemon_v2_itempocket");

            entity.HasIndex(e => e.Name, "pokemon_v2_itempocket_name_d30e337a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Itempocketname>(entity => {
            entity.ToTable("pokemon_v2_itempocketname");

            entity.HasIndex(e => e.ItemPocketId, "pokemon_v2_itempocketname_item_pocket_id_2856f7ba");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_itempocketname_language_id_bd18485d");

            entity.HasIndex(e => e.Name, "pokemon_v2_itempocketname_name_c3e53fd6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemPocketId).HasColumnName("item_pocket_id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.ItemPocket).WithMany(p => p.PokemonV2Itempocketnames).HasForeignKey(d => d.ItemPocketId);

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Itempocketnames).HasForeignKey(d => d.LanguageId);
        });

        modelBuilder.Entity<PokemonV2Itemsprite>(entity => {
            entity.ToTable("pokemon_v2_itemsprites");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_itemsprites_item_id_ad42d3ae");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Sprites).HasColumnName("sprites");

            entity.HasOne(d => d.Item).WithMany(p => p.PokemonV2Itemsprites).HasForeignKey(d => d.ItemId);
        });

        modelBuilder.Entity<PokemonV2Language>(entity => {
            entity.ToTable("pokemon_v2_language");

            entity.HasIndex(e => e.Name, "pokemon_v2_language_name_012b2a8c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Iso3166)
                .HasColumnType("varchar(2)")
                .HasColumnName("iso3166");
            entity.Property(e => e.Iso639)
                .HasColumnType("varchar(10)")
                .HasColumnName("iso639");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Official)
                .HasColumnType("bool")
                .HasColumnName("official");
            entity.Property(e => e.Order).HasColumnName("order");
        });

        modelBuilder.Entity<PokemonV2Languagename>(entity => {
            entity.ToTable("pokemon_v2_languagename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_languagename_language_id_75856281");

            entity.HasIndex(e => e.LocalLanguageId, "pokemon_v2_languagename_local_language_id_b09a9c7d");

            entity.HasIndex(e => e.Name, "pokemon_v2_languagename_name_6597eeaa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2LanguagenameLanguages).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.LocalLanguage).WithMany(p => p.PokemonV2LanguagenameLocalLanguages).HasForeignKey(d => d.LocalLanguageId);
        });

        modelBuilder.Entity<PokemonV2Location>(entity => {
            entity.ToTable("pokemon_v2_location");

            entity.HasIndex(e => e.Name, "pokemon_v2_location_name_09fe9462");

            entity.HasIndex(e => e.RegionId, "pokemon_v2_location_region_id_fd1b5904");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.RegionId).HasColumnName("region_id");

            entity.HasOne(d => d.Region).WithMany(p => p.PokemonV2Locations).HasForeignKey(d => d.RegionId);
        });

        modelBuilder.Entity<PokemonV2Locationarea>(entity => {
            entity.ToTable("pokemon_v2_locationarea");

            entity.HasIndex(e => e.LocationId, "pokemon_v2_locationarea_location_id_a62c4737");

            entity.HasIndex(e => e.Name, "pokemon_v2_locationarea_name_8b427914");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Location).WithMany(p => p.PokemonV2Locationareas).HasForeignKey(d => d.LocationId);
        });

        modelBuilder.Entity<PokemonV2Locationareaencounterrate>(entity => {
            entity.ToTable("pokemon_v2_locationareaencounterrate");

            entity.HasIndex(e => e.EncounterMethodId, "pokemon_v2_locationareaencounterrate_encounter_method_id_631902d6");

            entity.HasIndex(e => e.LocationAreaId, "pokemon_v2_locationareaencounterrate_location_area_id_78fab47d");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_locationareaencounterrate_version_id_67e1bbb9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");
            entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.EncounterMethod).WithMany(p => p.PokemonV2Locationareaencounterrates).HasForeignKey(d => d.EncounterMethodId);

            entity.HasOne(d => d.LocationArea).WithMany(p => p.PokemonV2Locationareaencounterrates).HasForeignKey(d => d.LocationAreaId);

            entity.HasOne(d => d.Version).WithMany(p => p.PokemonV2Locationareaencounterrates).HasForeignKey(d => d.VersionId);
        });

        modelBuilder.Entity<PokemonV2Locationareaname>(entity => {
            entity.ToTable("pokemon_v2_locationareaname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_locationareaname_language_id_82f198e4");

            entity.HasIndex(e => e.LocationAreaId, "pokemon_v2_locationareaname_location_area_id_99f07edf");

            entity.HasIndex(e => e.Name, "pokemon_v2_locationareaname_name_36edcff1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Locationareanames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.LocationArea).WithMany(p => p.PokemonV2Locationareanames).HasForeignKey(d => d.LocationAreaId);
        });

        modelBuilder.Entity<PokemonV2Locationgameindex>(entity => {
            entity.ToTable("pokemon_v2_locationgameindex");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_locationgameindex_generation_id_15ae87aa");

            entity.HasIndex(e => e.LocationId, "pokemon_v2_locationgameindex_location_id_4eadd886");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Locationgameindices).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Location).WithMany(p => p.PokemonV2Locationgameindices).HasForeignKey(d => d.LocationId);
        });

        modelBuilder.Entity<PokemonV2Locationname>(entity => {
            entity.ToTable("pokemon_v2_locationname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_locationname_language_id_9c042035");

            entity.HasIndex(e => e.LocationId, "pokemon_v2_locationname_location_id_b4de5b51");

            entity.HasIndex(e => e.Name, "pokemon_v2_locationname_name_0dc028d2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Locationnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Location).WithMany(p => p.PokemonV2Locationnames).HasForeignKey(d => d.LocationId);
        });

        modelBuilder.Entity<PokemonV2Machine>(entity => {
            entity.ToTable("pokemon_v2_machine");

            entity.HasIndex(e => e.GrowthRateId, "pokemon_v2_machine_growth_rate_id_d67448d0");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_machine_item_id_4c870846");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_machine_move_id_965a6a38");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_machine_version_group_id_d69b6064");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.MachineNumber).HasColumnName("machine_number");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.GrowthRate).WithMany(p => p.PokemonV2Machines).HasForeignKey(d => d.GrowthRateId);

            entity.HasOne(d => d.Item).WithMany(p => p.PokemonV2Machines).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Move).WithMany(p => p.PokemonV2Machines).HasForeignKey(d => d.MoveId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Machines).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Move>(entity => {
            entity.ToTable("pokemon_v2_move");

            entity.HasIndex(e => e.ContestEffectId, "pokemon_v2_move_contest_effect_id_2e4d04a1");

            entity.HasIndex(e => e.ContestTypeId, "pokemon_v2_move_contest_type_id_8da106eb");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_move_generation_id_d18da2f9");

            entity.HasIndex(e => e.MoveDamageClassId, "pokemon_v2_move_move_damage_class_id_6f60c380");

            entity.HasIndex(e => e.MoveEffectId, "pokemon_v2_move_move_effect_id_e12d5c62");

            entity.HasIndex(e => e.MoveTargetId, "pokemon_v2_move_move_target_id_47f917eb");

            entity.HasIndex(e => e.Name, "pokemon_v2_move_name_b3558818");

            entity.HasIndex(e => e.SuperContestEffectId, "pokemon_v2_move_super_contest_effect_id_c0efdaf5");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_move_type_id_a2b25a4c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accuracy).HasColumnName("accuracy");
            entity.Property(e => e.ContestEffectId).HasColumnName("contest_effect_id");
            entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");
            entity.Property(e => e.MoveEffectChance).HasColumnName("move_effect_chance");
            entity.Property(e => e.MoveEffectId).HasColumnName("move_effect_id");
            entity.Property(e => e.MoveTargetId).HasColumnName("move_target_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Power).HasColumnName("power");
            entity.Property(e => e.Pp).HasColumnName("pp");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.SuperContestEffectId).HasColumnName("super_contest_effect_id");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.ContestEffect).WithMany(p => p.PokemonV2Moves).HasForeignKey(d => d.ContestEffectId);

            entity.HasOne(d => d.ContestType).WithMany(p => p.PokemonV2Moves).HasForeignKey(d => d.ContestTypeId);

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Moves).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.MoveDamageClass).WithMany(p => p.PokemonV2Moves).HasForeignKey(d => d.MoveDamageClassId);

            entity.HasOne(d => d.MoveEffect).WithMany(p => p.PokemonV2Moves).HasForeignKey(d => d.MoveEffectId);

            entity.HasOne(d => d.MoveTarget).WithMany(p => p.PokemonV2Moves).HasForeignKey(d => d.MoveTargetId);

            entity.HasOne(d => d.SuperContestEffect).WithMany(p => p.PokemonV2Moves).HasForeignKey(d => d.SuperContestEffectId);

            entity.HasOne(d => d.Type).WithMany(p => p.PokemonV2Moves).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<PokemonV2Moveattribute>(entity => {
            entity.ToTable("pokemon_v2_moveattribute");

            entity.HasIndex(e => e.Name, "pokemon_v2_moveattribute_name_3a5f5200");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Moveattributedescription>(entity => {
            entity.ToTable("pokemon_v2_moveattributedescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_moveattributedescription_language_id_3cc96a2c");

            entity.HasIndex(e => e.MoveAttributeId, "pokemon_v2_moveattributedescription_move_attribute_id_26fa4593");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(1000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveAttributeId).HasColumnName("move_attribute_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Moveattributedescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveAttribute).WithMany(p => p.PokemonV2Moveattributedescriptions).HasForeignKey(d => d.MoveAttributeId);
        });

        modelBuilder.Entity<PokemonV2Moveattributemap>(entity => {
            entity.ToTable("pokemon_v2_moveattributemap");

            entity.HasIndex(e => e.MoveAttributeId, "pokemon_v2_moveattributemap_move_attribute_id_4bdcbae4");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_moveattributemap_move_id_8e9353e9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MoveAttributeId).HasColumnName("move_attribute_id");
            entity.Property(e => e.MoveId).HasColumnName("move_id");

            entity.HasOne(d => d.MoveAttribute).WithMany(p => p.PokemonV2Moveattributemaps).HasForeignKey(d => d.MoveAttributeId);

            entity.HasOne(d => d.Move).WithMany(p => p.PokemonV2Moveattributemaps).HasForeignKey(d => d.MoveId);
        });

        modelBuilder.Entity<PokemonV2Moveattributename>(entity => {
            entity.ToTable("pokemon_v2_moveattributename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_moveattributename_language_id_f0fdbb0e");

            entity.HasIndex(e => e.MoveAttributeId, "pokemon_v2_moveattributename_move_attribute_id_06b2d536");

            entity.HasIndex(e => e.Name, "pokemon_v2_moveattributename_name_9d7c4e1e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveAttributeId).HasColumnName("move_attribute_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Moveattributenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveAttribute).WithMany(p => p.PokemonV2Moveattributenames).HasForeignKey(d => d.MoveAttributeId);
        });

        modelBuilder.Entity<PokemonV2Movebattlestyle>(entity => {
            entity.ToTable("pokemon_v2_movebattlestyle");

            entity.HasIndex(e => e.Name, "pokemon_v2_movebattlestyle_name_0257848e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Movebattlestylename>(entity => {
            entity.ToTable("pokemon_v2_movebattlestylename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movebattlestylename_language_id_6dd407cd");

            entity.HasIndex(e => e.MoveBattleStyleId, "pokemon_v2_movebattlestylename_move_battle_style_id_0216e7a5");

            entity.HasIndex(e => e.Name, "pokemon_v2_movebattlestylename_name_4470754a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveBattleStyleId).HasColumnName("move_battle_style_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Movebattlestylenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveBattleStyle).WithMany(p => p.PokemonV2Movebattlestylenames).HasForeignKey(d => d.MoveBattleStyleId);
        });

        modelBuilder.Entity<PokemonV2Movechange>(entity => {
            entity.ToTable("pokemon_v2_movechange");

            entity.HasIndex(e => e.MoveEffectId, "pokemon_v2_movechange_move_effect_id_d0711cd2");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_movechange_move_id_56b40d0f");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_movechange_type_id_07064588");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_movechange_version_group_id_d98e7e4b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accuracy).HasColumnName("accuracy");
            entity.Property(e => e.MoveEffectChance).HasColumnName("move_effect_chance");
            entity.Property(e => e.MoveEffectId).HasColumnName("move_effect_id");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.Power).HasColumnName("power");
            entity.Property(e => e.Pp).HasColumnName("pp");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.MoveEffect).WithMany(p => p.PokemonV2Movechanges).HasForeignKey(d => d.MoveEffectId);

            entity.HasOne(d => d.Move).WithMany(p => p.PokemonV2Movechanges).HasForeignKey(d => d.MoveId);

            entity.HasOne(d => d.Type).WithMany(p => p.PokemonV2Movechanges).HasForeignKey(d => d.TypeId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Movechanges).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Movedamageclass>(entity => {
            entity.ToTable("pokemon_v2_movedamageclass");

            entity.HasIndex(e => e.Name, "pokemon_v2_movedamageclass_name_8c1669d6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Movedamageclassdescription>(entity => {
            entity.ToTable("pokemon_v2_movedamageclassdescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movedamageclassdescription_language_id_984a7058");

            entity.HasIndex(e => e.MoveDamageClassId, "pokemon_v2_movedamageclassdescription_move_damage_class_id_4624e8c3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(1000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Movedamageclassdescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveDamageClass).WithMany(p => p.PokemonV2Movedamageclassdescriptions).HasForeignKey(d => d.MoveDamageClassId);
        });

        modelBuilder.Entity<PokemonV2Movedamageclassname>(entity => {
            entity.ToTable("pokemon_v2_movedamageclassname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movedamageclassname_language_id_b66d9a02");

            entity.HasIndex(e => e.MoveDamageClassId, "pokemon_v2_movedamageclassname_move_damage_class_id_8d041412");

            entity.HasIndex(e => e.Name, "pokemon_v2_movedamageclassname_name_e38f4f0f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Movedamageclassnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveDamageClass).WithMany(p => p.PokemonV2Movedamageclassnames).HasForeignKey(d => d.MoveDamageClassId);
        });

        modelBuilder.Entity<PokemonV2Moveeffect>(entity => {
            entity.ToTable("pokemon_v2_moveeffect");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<PokemonV2Moveeffectchange>(entity => {
            entity.ToTable("pokemon_v2_moveeffectchange");

            entity.HasIndex(e => e.MoveEffectId, "pokemon_v2_moveeffectchange_move_effect_id_83bb0e24");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_moveeffectchange_version_group_id_ad5675d0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MoveEffectId).HasColumnName("move_effect_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.MoveEffect).WithMany(p => p.PokemonV2Moveeffectchanges).HasForeignKey(d => d.MoveEffectId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Moveeffectchanges).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Moveeffectchangeeffecttext>(entity => {
            entity.ToTable("pokemon_v2_moveeffectchangeeffecttext");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_moveeffectchangeeffecttext_language_id_f616622c");

            entity.HasIndex(e => e.MoveEffectChangeId, "pokemon_v2_moveeffectchangeeffecttext_move_effect_change_id_c4e6b8f2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveEffectChangeId).HasColumnName("move_effect_change_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Moveeffectchangeeffecttexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveEffectChange).WithMany(p => p.PokemonV2Moveeffectchangeeffecttexts).HasForeignKey(d => d.MoveEffectChangeId);
        });

        modelBuilder.Entity<PokemonV2Moveeffecteffecttext>(entity => {
            entity.ToTable("pokemon_v2_moveeffecteffecttext");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_moveeffecteffecttext_language_id_4e202686");

            entity.HasIndex(e => e.MoveEffectId, "pokemon_v2_moveeffecteffecttext_move_effect_id_e834153e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Effect)
                .HasColumnType("varchar(6000)")
                .HasColumnName("effect");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveEffectId).HasColumnName("move_effect_id");
            entity.Property(e => e.ShortEffect)
                .HasColumnType("varchar(300)")
                .HasColumnName("short_effect");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Moveeffecteffecttexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveEffect).WithMany(p => p.PokemonV2Moveeffecteffecttexts).HasForeignKey(d => d.MoveEffectId);
        });

        modelBuilder.Entity<PokemonV2Moveflavortext>(entity => {
            entity.ToTable("pokemon_v2_moveflavortext");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_moveflavortext_language_id_cad665e7");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_moveflavortext_move_id_e694b553");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_moveflavortext_version_group_id_acb46240");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Moveflavortexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Move).WithMany(p => p.PokemonV2Moveflavortexts).HasForeignKey(d => d.MoveId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Moveflavortexts).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Movelearnmethod>(entity => {
            entity.ToTable("pokemon_v2_movelearnmethod");

            entity.HasIndex(e => e.Name, "pokemon_v2_movelearnmethod_name_d6294fe9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Movelearnmethoddescription>(entity => {
            entity.ToTable("pokemon_v2_movelearnmethoddescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movelearnmethoddescription_language_id_a6bac991");

            entity.HasIndex(e => e.MoveLearnMethodId, "pokemon_v2_movelearnmethoddescription_move_learn_method_id_09ec6a7b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(1000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveLearnMethodId).HasColumnName("move_learn_method_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Movelearnmethoddescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveLearnMethod).WithMany(p => p.PokemonV2Movelearnmethoddescriptions).HasForeignKey(d => d.MoveLearnMethodId);
        });

        modelBuilder.Entity<PokemonV2Movelearnmethodname>(entity => {
            entity.ToTable("pokemon_v2_movelearnmethodname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movelearnmethodname_language_id_aa17010f");

            entity.HasIndex(e => e.MoveLearnMethodId, "pokemon_v2_movelearnmethodname_move_learn_method_id_04b9abfa");

            entity.HasIndex(e => e.Name, "pokemon_v2_movelearnmethodname_name_b665e82d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveLearnMethodId).HasColumnName("move_learn_method_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Movelearnmethodnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveLearnMethod).WithMany(p => p.PokemonV2Movelearnmethodnames).HasForeignKey(d => d.MoveLearnMethodId);
        });

        modelBuilder.Entity<PokemonV2Movemetaailment>(entity => {
            entity.ToTable("pokemon_v2_movemetaailment");

            entity.HasIndex(e => e.Name, "pokemon_v2_movemetaailment_name_7e8b85b0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Movemetaailmentname>(entity => {
            entity.ToTable("pokemon_v2_movemetaailmentname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movemetaailmentname_language_id_c536b83b");

            entity.HasIndex(e => e.MoveMetaAilmentId, "pokemon_v2_movemetaailmentname_move_meta_ailment_id_3166201a");

            entity.HasIndex(e => e.Name, "pokemon_v2_movemetaailmentname_name_a286e4d0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveMetaAilmentId).HasColumnName("move_meta_ailment_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Movemetaailmentnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveMetaAilment).WithMany(p => p.PokemonV2Movemetaailmentnames).HasForeignKey(d => d.MoveMetaAilmentId);
        });

        modelBuilder.Entity<PokemonV2Movemetacategory>(entity => {
            entity.ToTable("pokemon_v2_movemetacategory");

            entity.HasIndex(e => e.Name, "pokemon_v2_movemetacategory_name_2d508cb0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Movemetacategorydescription>(entity => {
            entity.ToTable("pokemon_v2_movemetacategorydescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movemetacategorydescription_language_id_feacc726");

            entity.HasIndex(e => e.MoveMetaCategoryId, "pokemon_v2_movemetacategorydescription_move_meta_category_id_4b604073");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(1000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveMetaCategoryId).HasColumnName("move_meta_category_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Movemetacategorydescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveMetaCategory).WithMany(p => p.PokemonV2Movemetacategorydescriptions).HasForeignKey(d => d.MoveMetaCategoryId);
        });

        modelBuilder.Entity<PokemonV2Movemetastatchange>(entity => {
            entity.ToTable("pokemon_v2_movemetastatchange");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_movemetastatchange_move_id_b8528bde");

            entity.HasIndex(e => e.StatId, "pokemon_v2_movemetastatchange_stat_id_7bbd0200");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Change).HasColumnName("change");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.StatId).HasColumnName("stat_id");

            entity.HasOne(d => d.Move).WithMany(p => p.PokemonV2Movemetastatchanges).HasForeignKey(d => d.MoveId);

            entity.HasOne(d => d.Stat).WithMany(p => p.PokemonV2Movemetastatchanges).HasForeignKey(d => d.StatId);
        });

        modelBuilder.Entity<PokemonV2Movemetum>(entity => {
            entity.ToTable("pokemon_v2_movemeta");

            entity.HasIndex(e => e.MoveId, "IX_pokemon_v2_movemeta_move_id").IsUnique();

            entity.HasIndex(e => e.MoveMetaAilmentId, "pokemon_v2_movemeta_move_meta_ailment_id_d261d5e1");

            entity.HasIndex(e => e.MoveMetaCategoryId, "pokemon_v2_movemeta_move_meta_category_id_5fc2f4b6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AilmentChance).HasColumnName("ailment_chance");
            entity.Property(e => e.CritRate).HasColumnName("crit_rate");
            entity.Property(e => e.Drain).HasColumnName("drain");
            entity.Property(e => e.FlinchChance).HasColumnName("flinch_chance");
            entity.Property(e => e.Healing).HasColumnName("healing");
            entity.Property(e => e.MaxHits).HasColumnName("max_hits");
            entity.Property(e => e.MaxTurns).HasColumnName("max_turns");
            entity.Property(e => e.MinHits).HasColumnName("min_hits");
            entity.Property(e => e.MinTurns).HasColumnName("min_turns");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.MoveMetaAilmentId).HasColumnName("move_meta_ailment_id");
            entity.Property(e => e.MoveMetaCategoryId).HasColumnName("move_meta_category_id");
            entity.Property(e => e.StatChance).HasColumnName("stat_chance");

            entity.HasOne(d => d.Move).WithOne(p => p.PokemonV2Movemetum)
                .HasForeignKey<PokemonV2Movemetum>(d => d.MoveId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.MoveMetaAilment).WithMany(p => p.PokemonV2Movemeta).HasForeignKey(d => d.MoveMetaAilmentId);

            entity.HasOne(d => d.MoveMetaCategory).WithMany(p => p.PokemonV2Movemeta).HasForeignKey(d => d.MoveMetaCategoryId);
        });

        modelBuilder.Entity<PokemonV2Movename>(entity => {
            entity.ToTable("pokemon_v2_movename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movename_language_id_9c478512");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_movename_move_id_f28e6bef");

            entity.HasIndex(e => e.Name, "pokemon_v2_movename_name_8f60338a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Movenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Move).WithMany(p => p.PokemonV2Movenames).HasForeignKey(d => d.MoveId);
        });

        modelBuilder.Entity<PokemonV2Movetarget>(entity => {
            entity.ToTable("pokemon_v2_movetarget");

            entity.HasIndex(e => e.Name, "pokemon_v2_movetarget_name_af0c75ad");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Movetargetdescription>(entity => {
            entity.ToTable("pokemon_v2_movetargetdescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movetargetdescription_language_id_85ac7390");

            entity.HasIndex(e => e.MoveTargetId, "pokemon_v2_movetargetdescription_move_target_id_1afb9b51");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(1000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveTargetId).HasColumnName("move_target_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Movetargetdescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveTarget).WithMany(p => p.PokemonV2Movetargetdescriptions).HasForeignKey(d => d.MoveTargetId);
        });

        modelBuilder.Entity<PokemonV2Movetargetname>(entity => {
            entity.ToTable("pokemon_v2_movetargetname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_movetargetname_language_id_05d3b8b8");

            entity.HasIndex(e => e.MoveTargetId, "pokemon_v2_movetargetname_move_target_id_61f56365");

            entity.HasIndex(e => e.Name, "pokemon_v2_movetargetname_name_ae888d7a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.MoveTargetId).HasColumnName("move_target_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Movetargetnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.MoveTarget).WithMany(p => p.PokemonV2Movetargetnames).HasForeignKey(d => d.MoveTargetId);
        });

        modelBuilder.Entity<PokemonV2Nature>(entity => {
            entity.ToTable("pokemon_v2_nature");

            entity.HasIndex(e => e.DecreasedStatId, "pokemon_v2_nature_decreased_stat_id_d89610fc");

            entity.HasIndex(e => e.HatesFlavorId, "pokemon_v2_nature_hates_flavor_id_d9c22d5d");

            entity.HasIndex(e => e.IncreasedStatId, "pokemon_v2_nature_increased_stat_id_949bb3bd");

            entity.HasIndex(e => e.LikesFlavorId, "pokemon_v2_nature_likes_flavor_id_475f0a7d");

            entity.HasIndex(e => e.Name, "pokemon_v2_nature_name_a7f453b0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DecreasedStatId).HasColumnName("decreased_stat_id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.HatesFlavorId).HasColumnName("hates_flavor_id");
            entity.Property(e => e.IncreasedStatId).HasColumnName("increased_stat_id");
            entity.Property(e => e.LikesFlavorId).HasColumnName("likes_flavor_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.DecreasedStat).WithMany(p => p.PokemonV2NatureDecreasedStats).HasForeignKey(d => d.DecreasedStatId);

            entity.HasOne(d => d.HatesFlavor).WithMany(p => p.PokemonV2NatureHatesFlavors).HasForeignKey(d => d.HatesFlavorId);

            entity.HasOne(d => d.IncreasedStat).WithMany(p => p.PokemonV2NatureIncreasedStats).HasForeignKey(d => d.IncreasedStatId);

            entity.HasOne(d => d.LikesFlavor).WithMany(p => p.PokemonV2NatureLikesFlavors).HasForeignKey(d => d.LikesFlavorId);
        });

        modelBuilder.Entity<PokemonV2Naturebattlestylepreference>(entity => {
            entity.ToTable("pokemon_v2_naturebattlestylepreference");

            entity.HasIndex(e => e.MoveBattleStyleId, "pokemon_v2_naturebattlestylepreference_move_battle_style_id_f1dd2e92");

            entity.HasIndex(e => e.NatureId, "pokemon_v2_naturebattlestylepreference_nature_id_03c37bf2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HighHpPreference).HasColumnName("high_hp_preference");
            entity.Property(e => e.LowHpPreference).HasColumnName("low_hp_preference");
            entity.Property(e => e.MoveBattleStyleId).HasColumnName("move_battle_style_id");
            entity.Property(e => e.NatureId).HasColumnName("nature_id");

            entity.HasOne(d => d.MoveBattleStyle).WithMany(p => p.PokemonV2Naturebattlestylepreferences).HasForeignKey(d => d.MoveBattleStyleId);

            entity.HasOne(d => d.Nature).WithMany(p => p.PokemonV2Naturebattlestylepreferences).HasForeignKey(d => d.NatureId);
        });

        modelBuilder.Entity<PokemonV2Naturename>(entity => {
            entity.ToTable("pokemon_v2_naturename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_naturename_language_id_7b3bb981");

            entity.HasIndex(e => e.Name, "pokemon_v2_naturename_name_d0bfe13a");

            entity.HasIndex(e => e.NatureId, "pokemon_v2_naturename_nature_id_e6043d64");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.NatureId).HasColumnName("nature_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Naturenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Nature).WithMany(p => p.PokemonV2Naturenames).HasForeignKey(d => d.NatureId);
        });

        modelBuilder.Entity<PokemonV2Naturepokeathlonstat>(entity => {
            entity.ToTable("pokemon_v2_naturepokeathlonstat");

            entity.HasIndex(e => e.NatureId, "pokemon_v2_naturepokeathlonstat_nature_id_11b4efea");

            entity.HasIndex(e => e.PokeathlonStatId, "pokemon_v2_naturepokeathlonstat_pokeathlon_stat_id_0d042f0d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaxChange).HasColumnName("max_change");
            entity.Property(e => e.NatureId).HasColumnName("nature_id");
            entity.Property(e => e.PokeathlonStatId).HasColumnName("pokeathlon_stat_id");

            entity.HasOne(d => d.Nature).WithMany(p => p.PokemonV2Naturepokeathlonstats).HasForeignKey(d => d.NatureId);

            entity.HasOne(d => d.PokeathlonStat).WithMany(p => p.PokemonV2Naturepokeathlonstats).HasForeignKey(d => d.PokeathlonStatId);
        });

        modelBuilder.Entity<PokemonV2Palpark>(entity => {
            entity.ToTable("pokemon_v2_palpark");

            entity.HasIndex(e => e.PalParkAreaId, "pokemon_v2_palpark_pal_park_area_id_8df4fce8");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_palpark_pokemon_species_id_639ae7f1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseScore).HasColumnName("base_score");
            entity.Property(e => e.PalParkAreaId).HasColumnName("pal_park_area_id");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");
            entity.Property(e => e.Rate).HasColumnName("rate");

            entity.HasOne(d => d.PalParkArea).WithMany(p => p.PokemonV2Palparks).HasForeignKey(d => d.PalParkAreaId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.PokemonV2Palparks).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<PokemonV2Palparkarea>(entity => {
            entity.ToTable("pokemon_v2_palparkarea");

            entity.HasIndex(e => e.Name, "pokemon_v2_palparkarea_name_d27212e7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Palparkareaname>(entity => {
            entity.ToTable("pokemon_v2_palparkareaname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_palparkareaname_language_id_1961595b");

            entity.HasIndex(e => e.Name, "pokemon_v2_palparkareaname_name_1fef3377");

            entity.HasIndex(e => e.PalParkAreaId, "pokemon_v2_palparkareaname_pal_park_area_id_9732132d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PalParkAreaId).HasColumnName("pal_park_area_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Palparkareanames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PalParkArea).WithMany(p => p.PokemonV2Palparkareanames).HasForeignKey(d => d.PalParkAreaId);
        });

        modelBuilder.Entity<PokemonV2Pokeathlonstat>(entity => {
            entity.ToTable("pokemon_v2_pokeathlonstat");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokeathlonstat_name_dfd410d4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Pokeathlonstatname>(entity => {
            entity.ToTable("pokemon_v2_pokeathlonstatname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokeathlonstatname_language_id_053b296b");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokeathlonstatname_name_21dff6f1");

            entity.HasIndex(e => e.PokeathlonStatId, "pokemon_v2_pokeathlonstatname_pokeathlon_stat_id_95163495");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokeathlonStatId).HasColumnName("pokeathlon_stat_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Pokeathlonstatnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokeathlonStat).WithMany(p => p.PokemonV2Pokeathlonstatnames).HasForeignKey(d => d.PokeathlonStatId);
        });

        modelBuilder.Entity<PokemonV2Pokedex>(entity => {
            entity.ToTable("pokemon_v2_pokedex");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokedex_name_d3054d11");

            entity.HasIndex(e => e.RegionId, "pokemon_v2_pokedex_region_id_d894ac3e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsMainSeries)
                .HasColumnType("bool")
                .HasColumnName("is_main_series");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.RegionId).HasColumnName("region_id");

            entity.HasOne(d => d.Region).WithMany(p => p.PokemonV2Pokedices).HasForeignKey(d => d.RegionId);
        });

        modelBuilder.Entity<PokemonV2Pokedexdescription>(entity => {
            entity.ToTable("pokemon_v2_pokedexdescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokedexdescription_language_id_908fbcc8");

            entity.HasIndex(e => e.PokedexId, "pokemon_v2_pokedexdescription_pokedex_id_6519a3de");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(1000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Pokedexdescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Pokedex).WithMany(p => p.PokemonV2Pokedexdescriptions).HasForeignKey(d => d.PokedexId);
        });

        modelBuilder.Entity<PokemonV2Pokedexname>(entity => {
            entity.ToTable("pokemon_v2_pokedexname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokedexname_language_id_97285e07");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokedexname_name_9e582b7c");

            entity.HasIndex(e => e.PokedexId, "pokemon_v2_pokedexname_pokedex_id_e31703e5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Pokedexnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Pokedex).WithMany(p => p.PokemonV2Pokedexnames).HasForeignKey(d => d.PokedexId);
        });

        modelBuilder.Entity<PokemonV2Pokedexversiongroup>(entity => {
            entity.ToTable("pokemon_v2_pokedexversiongroup");

            entity.HasIndex(e => e.PokedexId, "pokemon_v2_pokedexversiongroup_pokedex_id_e9aaac37");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_pokedexversiongroup_version_group_id_2fbd3e54");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Pokedex).WithMany(p => p.PokemonV2Pokedexversiongroups).HasForeignKey(d => d.PokedexId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Pokedexversiongroups).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Pokemon>(entity => {
            entity.ToTable("pokemon_v2_pokemon");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemon_name_b4719884");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemon_pokemon_species_id_e3dbafe1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseExperience).HasColumnName("base_experience");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.IsDefault)
                .HasColumnType("bool")
                .HasColumnName("is_default");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.PokemonV2Pokemons).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<PokemonV2Pokemonability>(entity => {
            entity.ToTable("pokemon_v2_pokemonability");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_pokemonability_ability_id_e6de97cc");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonability_pokemon_id_2d9f606f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.IsHidden)
                .HasColumnType("bool")
                .HasColumnName("is_hidden");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Slot).HasColumnName("slot");

            entity.HasOne(d => d.Ability).WithMany(p => p.PokemonV2Pokemonabilities).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemonabilities).HasForeignKey(d => d.PokemonId);
        });

        modelBuilder.Entity<PokemonV2Pokemonabilitypast>(entity => {
            entity.ToTable("pokemon_v2_pokemonabilitypast");

            entity.HasIndex(e => e.AbilityId, "pokemon_v2_pokemonabilitypast_ability_id_27ce43f2");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_pokemonabilitypast_generation_id_7c49a4a1");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonabilitypast_pokemon_id_1f8eef75");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbilityId).HasColumnName("ability_id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.IsHidden)
                .HasColumnType("bool")
                .HasColumnName("is_hidden");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Slot).HasColumnName("slot");

            entity.HasOne(d => d.Ability).WithMany(p => p.PokemonV2Pokemonabilitypasts).HasForeignKey(d => d.AbilityId);

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Pokemonabilitypasts).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemonabilitypasts).HasForeignKey(d => d.PokemonId);
        });

        modelBuilder.Entity<PokemonV2Pokemoncolor>(entity => {
            entity.ToTable("pokemon_v2_pokemoncolor");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemoncolor_name_be656ffc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Pokemoncolorname>(entity => {
            entity.ToTable("pokemon_v2_pokemoncolorname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemoncolorname_language_id_640a8271");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemoncolorname_name_21cdd894");

            entity.HasIndex(e => e.PokemonColorId, "pokemon_v2_pokemoncolorname_pokemon_color_id_33a759e5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokemonColorId).HasColumnName("pokemon_color_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Pokemoncolornames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonColor).WithMany(p => p.PokemonV2Pokemoncolornames).HasForeignKey(d => d.PokemonColorId);
        });

        modelBuilder.Entity<PokemonV2Pokemoncry>(entity => {
            entity.ToTable("pokemon_v2_pokemoncries");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemoncries_pokemon_id_f4f1bdc4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cries).HasColumnName("cries");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemoncries).HasForeignKey(d => d.PokemonId);
        });

        modelBuilder.Entity<PokemonV2Pokemondexnumber>(entity => {
            entity.ToTable("pokemon_v2_pokemondexnumber");

            entity.HasIndex(e => e.PokedexId, "pokemon_v2_pokemondexnumber_pokedex_id_5f882d27");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemondexnumber_pokemon_species_id_0b92eca5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");
            entity.Property(e => e.PokedexNumber).HasColumnName("pokedex_number");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

            entity.HasOne(d => d.Pokedex).WithMany(p => p.PokemonV2Pokemondexnumbers).HasForeignKey(d => d.PokedexId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.PokemonV2Pokemondexnumbers).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<PokemonV2Pokemonegggroup>(entity => {
            entity.ToTable("pokemon_v2_pokemonegggroup");

            entity.HasIndex(e => e.EggGroupId, "pokemon_v2_pokemonegggroup_egg_group_id_cd305d10");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemonegggroup_pokemon_species_id_d0fc6e47");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EggGroupId).HasColumnName("egg_group_id");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

            entity.HasOne(d => d.EggGroup).WithMany(p => p.PokemonV2Pokemonegggroups).HasForeignKey(d => d.EggGroupId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.PokemonV2Pokemonegggroups).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<PokemonV2Pokemonevolution>(entity => {
            entity.ToTable("pokemon_v2_pokemonevolution");

            entity.HasIndex(e => e.EvolutionItemId, "pokemon_v2_pokemonevolution_evolution_item_id_afdb70a5");

            entity.HasIndex(e => e.EvolutionTriggerId, "pokemon_v2_pokemonevolution_evolution_trigger_id_7d6a5102");

            entity.HasIndex(e => e.EvolvedSpeciesId, "pokemon_v2_pokemonevolution_evolved_species_id_bcbf43a3");

            entity.HasIndex(e => e.GenderId, "pokemon_v2_pokemonevolution_gender_id_ccbf258a");

            entity.HasIndex(e => e.HeldItemId, "pokemon_v2_pokemonevolution_held_item_id_ef69a719");

            entity.HasIndex(e => e.KnownMoveId, "pokemon_v2_pokemonevolution_known_move_id_301dfc54");

            entity.HasIndex(e => e.KnownMoveTypeId, "pokemon_v2_pokemonevolution_known_move_type_id_de1a6bf4");

            entity.HasIndex(e => e.LocationId, "pokemon_v2_pokemonevolution_location_id_fb0e2aa2");

            entity.HasIndex(e => e.PartySpeciesId, "pokemon_v2_pokemonevolution_party_species_id_aa57f0d1");

            entity.HasIndex(e => e.PartyTypeId, "pokemon_v2_pokemonevolution_party_type_id_6af7cb68");

            entity.HasIndex(e => e.TradeSpeciesId, "pokemon_v2_pokemonevolution_trade_species_id_6eefecdc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EvolutionItemId).HasColumnName("evolution_item_id");
            entity.Property(e => e.EvolutionTriggerId).HasColumnName("evolution_trigger_id");
            entity.Property(e => e.EvolvedSpeciesId).HasColumnName("evolved_species_id");
            entity.Property(e => e.GenderId).HasColumnName("gender_id");
            entity.Property(e => e.HeldItemId).HasColumnName("held_item_id");
            entity.Property(e => e.KnownMoveId).HasColumnName("known_move_id");
            entity.Property(e => e.KnownMoveTypeId).HasColumnName("known_move_type_id");
            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.MinAffection).HasColumnName("min_affection");
            entity.Property(e => e.MinBeauty).HasColumnName("min_beauty");
            entity.Property(e => e.MinHappiness).HasColumnName("min_happiness");
            entity.Property(e => e.MinLevel).HasColumnName("min_level");
            entity.Property(e => e.NeedsOverworldRain)
                .HasColumnType("bool")
                .HasColumnName("needs_overworld_rain");
            entity.Property(e => e.PartySpeciesId).HasColumnName("party_species_id");
            entity.Property(e => e.PartyTypeId).HasColumnName("party_type_id");
            entity.Property(e => e.RelativePhysicalStats).HasColumnName("relative_physical_stats");
            entity.Property(e => e.TimeOfDay)
                .HasColumnType("varchar(10)")
                .HasColumnName("time_of_day");
            entity.Property(e => e.TradeSpeciesId).HasColumnName("trade_species_id");
            entity.Property(e => e.TurnUpsideDown)
                .HasColumnType("bool")
                .HasColumnName("turn_upside_down");

            entity.HasOne(d => d.EvolutionItem).WithMany(p => p.PokemonV2PokemonevolutionEvolutionItems).HasForeignKey(d => d.EvolutionItemId);

            entity.HasOne(d => d.EvolutionTrigger).WithMany(p => p.PokemonV2Pokemonevolutions).HasForeignKey(d => d.EvolutionTriggerId);

            entity.HasOne(d => d.EvolvedSpecies).WithMany(p => p.PokemonV2PokemonevolutionEvolvedSpecies).HasForeignKey(d => d.EvolvedSpeciesId);

            entity.HasOne(d => d.Gender).WithMany(p => p.PokemonV2Pokemonevolutions).HasForeignKey(d => d.GenderId);

            entity.HasOne(d => d.HeldItem).WithMany(p => p.PokemonV2PokemonevolutionHeldItems).HasForeignKey(d => d.HeldItemId);

            entity.HasOne(d => d.KnownMove).WithMany(p => p.PokemonV2Pokemonevolutions).HasForeignKey(d => d.KnownMoveId);

            entity.HasOne(d => d.KnownMoveType).WithMany(p => p.PokemonV2PokemonevolutionKnownMoveTypes).HasForeignKey(d => d.KnownMoveTypeId);

            entity.HasOne(d => d.Location).WithMany(p => p.PokemonV2Pokemonevolutions).HasForeignKey(d => d.LocationId);

            entity.HasOne(d => d.PartySpecies).WithMany(p => p.PokemonV2PokemonevolutionPartySpecies).HasForeignKey(d => d.PartySpeciesId);

            entity.HasOne(d => d.PartyType).WithMany(p => p.PokemonV2PokemonevolutionPartyTypes).HasForeignKey(d => d.PartyTypeId);

            entity.HasOne(d => d.TradeSpecies).WithMany(p => p.PokemonV2PokemonevolutionTradeSpecies).HasForeignKey(d => d.TradeSpeciesId);
        });

        modelBuilder.Entity<PokemonV2Pokemonform>(entity => {
            entity.ToTable("pokemon_v2_pokemonform");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonform_name_fe094947");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonform_pokemon_id_f1307072");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_pokemonform_version_group_id_88573ce7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FormName)
                .HasColumnType("varchar(30)")
                .HasColumnName("form_name");
            entity.Property(e => e.FormOrder).HasColumnName("form_order");
            entity.Property(e => e.IsBattleOnly)
                .HasColumnType("bool")
                .HasColumnName("is_battle_only");
            entity.Property(e => e.IsDefault)
                .HasColumnType("bool")
                .HasColumnName("is_default");
            entity.Property(e => e.IsMega)
                .HasColumnType("bool")
                .HasColumnName("is_mega");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemonforms).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Pokemonforms).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Pokemonformgeneration>(entity => {
            entity.ToTable("pokemon_v2_pokemonformgeneration");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_pokemonformgeneration_generation_id_2f4d5474");

            entity.HasIndex(e => e.PokemonFormId, "pokemon_v2_pokemonformgeneration_pokemon_form_id_63610ed9");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Pokemonformgenerations).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.PokemonForm).WithMany(p => p.PokemonV2Pokemonformgenerations).HasForeignKey(d => d.PokemonFormId);
        });

        modelBuilder.Entity<PokemonV2Pokemonformname>(entity => {
            entity.ToTable("pokemon_v2_pokemonformname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonformname_language_id_2570013b");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonformname_name_4496fca6");

            entity.HasIndex(e => e.PokemonFormId, "pokemon_v2_pokemonformname_pokemon_form_id_7c4f1fb5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");
            entity.Property(e => e.PokemonName)
                .HasColumnType("varchar(60)")
                .HasColumnName("pokemon_name");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Pokemonformnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonForm).WithMany(p => p.PokemonV2Pokemonformnames).HasForeignKey(d => d.PokemonFormId);
        });

        modelBuilder.Entity<PokemonV2Pokemonformsprite>(entity => {
            entity.ToTable("pokemon_v2_pokemonformsprites");

            entity.HasIndex(e => e.PokemonFormId, "pokemon_v2_pokemonformsprites_pokemon_form_id_b09cb8b3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");
            entity.Property(e => e.Sprites).HasColumnName("sprites");

            entity.HasOne(d => d.PokemonForm).WithMany(p => p.PokemonV2Pokemonformsprites).HasForeignKey(d => d.PokemonFormId);
        });

        modelBuilder.Entity<PokemonV2Pokemonformtype>(entity => {
            entity.ToTable("pokemon_v2_pokemonformtype");

            entity.HasIndex(e => e.PokemonFormId, "pokemon_v2_pokemonformtype_pokemon_form_id_bff24ddc");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_pokemonformtype_type_id_10672412");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.PokemonForm).WithMany(p => p.PokemonV2Pokemonformtypes).HasForeignKey(d => d.PokemonFormId);

            entity.HasOne(d => d.Type).WithMany(p => p.PokemonV2Pokemonformtypes).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<PokemonV2Pokemongameindex>(entity => {
            entity.ToTable("pokemon_v2_pokemongameindex");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemongameindex_pokemon_id_d1278b45");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_pokemongameindex_version_id_2f3cda39");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemongameindices).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Version).WithMany(p => p.PokemonV2Pokemongameindices).HasForeignKey(d => d.VersionId);
        });

        modelBuilder.Entity<PokemonV2Pokemonhabitat>(entity => {
            entity.ToTable("pokemon_v2_pokemonhabitat");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonhabitat_name_e36918ba");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Pokemonhabitatname>(entity => {
            entity.ToTable("pokemon_v2_pokemonhabitatname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonhabitatname_language_id_b247fa35");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonhabitatname_name_0b8b38c3");

            entity.HasIndex(e => e.PokemonHabitatId, "pokemon_v2_pokemonhabitatname_pokemon_habitat_id_8bb656e6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokemonHabitatId).HasColumnName("pokemon_habitat_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Pokemonhabitatnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonHabitat).WithMany(p => p.PokemonV2Pokemonhabitatnames).HasForeignKey(d => d.PokemonHabitatId);
        });

        modelBuilder.Entity<PokemonV2Pokemonitem>(entity => {
            entity.ToTable("pokemon_v2_pokemonitem");

            entity.HasIndex(e => e.ItemId, "pokemon_v2_pokemonitem_item_id_f2d37afe");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonitem_pokemon_id_d5dd8083");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_pokemonitem_version_id_4f5c2a1c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Rarity).HasColumnName("rarity");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.Item).WithMany(p => p.PokemonV2Pokemonitems).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemonitems).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Version).WithMany(p => p.PokemonV2Pokemonitems).HasForeignKey(d => d.VersionId);
        });

        modelBuilder.Entity<PokemonV2Pokemonmove>(entity => {
            entity.ToTable("pokemon_v2_pokemonmove");

            entity.HasIndex(e => e.MoveId, "pokemon_v2_pokemonmove_move_id_b5f71cf7");

            entity.HasIndex(e => e.MoveLearnMethodId, "pokemon_v2_pokemonmove_move_learn_method_id_f7503746");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonmove_pokemon_id_ca9e0e55");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_pokemonmove_version_group_id_ca4c374c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Mastery).HasColumnName("mastery");
            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.MoveLearnMethodId).HasColumnName("move_learn_method_id");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Move).WithMany(p => p.PokemonV2Pokemonmoves).HasForeignKey(d => d.MoveId);

            entity.HasOne(d => d.MoveLearnMethod).WithMany(p => p.PokemonV2Pokemonmoves).HasForeignKey(d => d.MoveLearnMethodId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemonmoves).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Pokemonmoves).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Pokemonshape>(entity => {
            entity.ToTable("pokemon_v2_pokemonshape");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonshape_name_d7251478");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Pokemonshapename>(entity => {
            entity.ToTable("pokemon_v2_pokemonshapename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonshapename_language_id_e094373f");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonshapename_name_224dc527");

            entity.HasIndex(e => e.PokemonShapeId, "pokemon_v2_pokemonshapename_pokemon_shape_id_69bb934f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AwesomeName)
                .HasColumnType("varchar(30)")
                .HasColumnName("awesome_name");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokemonShapeId).HasColumnName("pokemon_shape_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Pokemonshapenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonShape).WithMany(p => p.PokemonV2Pokemonshapenames).HasForeignKey(d => d.PokemonShapeId);
        });

        modelBuilder.Entity<PokemonV2Pokemonspeciesdescription>(entity => {
            entity.ToTable("pokemon_v2_pokemonspeciesdescription");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonspeciesdescription_language_id_75b5e267");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemonspeciesdescription_pokemon_species_id_c62bce07");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("varchar(1000)")
                .HasColumnName("description");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Pokemonspeciesdescriptions).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.PokemonV2Pokemonspeciesdescriptions).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<PokemonV2Pokemonspeciesflavortext>(entity => {
            entity.ToTable("pokemon_v2_pokemonspeciesflavortext");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonspeciesflavortext_language_id_725fcf28");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemonspeciesflavortext_pokemon_species_id_345e9c6c");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_pokemonspeciesflavortext_version_id_67eb47ad");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Pokemonspeciesflavortexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.PokemonV2Pokemonspeciesflavortexts).HasForeignKey(d => d.PokemonSpeciesId);

            entity.HasOne(d => d.Version).WithMany(p => p.PokemonV2Pokemonspeciesflavortexts).HasForeignKey(d => d.VersionId);
        });

        modelBuilder.Entity<PokemonV2Pokemonspeciesname>(entity => {
            entity.ToTable("pokemon_v2_pokemonspeciesname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_pokemonspeciesname_language_id_1a5acda5");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonspeciesname_name_e53fa719");

            entity.HasIndex(e => e.PokemonSpeciesId, "pokemon_v2_pokemonspeciesname_pokemon_species_id_6566cdc8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Genus)
                .HasColumnType("varchar(30)")
                .HasColumnName("genus");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Pokemonspeciesnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.PokemonSpecies).WithMany(p => p.PokemonV2Pokemonspeciesnames).HasForeignKey(d => d.PokemonSpeciesId);
        });

        modelBuilder.Entity<PokemonV2Pokemonspecy>(entity => {
            entity.ToTable("pokemon_v2_pokemonspecies");

            entity.HasIndex(e => e.EvolutionChainId, "pokemon_v2_pokemonspecies_evolution_chain_id_d94981c6");

            entity.HasIndex(e => e.EvolvesFromSpeciesId, "pokemon_v2_pokemonspecies_evolves_from_species_id_6e40aea2");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_pokemonspecies_generation_id_57b5b3ef");

            entity.HasIndex(e => e.GrowthRateId, "pokemon_v2_pokemonspecies_growth_rate_id_78ff36e3");

            entity.HasIndex(e => e.Name, "pokemon_v2_pokemonspecies_name_f1ec390b");

            entity.HasIndex(e => e.PokemonColorId, "pokemon_v2_pokemonspecies_pokemon_color_id_27cb23c7");

            entity.HasIndex(e => e.PokemonHabitatId, "pokemon_v2_pokemonspecies_pokemon_habitat_id_61d7914c");

            entity.HasIndex(e => e.PokemonShapeId, "pokemon_v2_pokemonspecies_pokemon_shape_id_9420bbbf");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseHappiness).HasColumnName("base_happiness");
            entity.Property(e => e.CaptureRate).HasColumnName("capture_rate");
            entity.Property(e => e.EvolutionChainId).HasColumnName("evolution_chain_id");
            entity.Property(e => e.EvolvesFromSpeciesId).HasColumnName("evolves_from_species_id");
            entity.Property(e => e.FormsSwitchable)
                .HasColumnType("bool")
                .HasColumnName("forms_switchable");
            entity.Property(e => e.GenderRate).HasColumnName("gender_rate");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");
            entity.Property(e => e.HasGenderDifferences)
                .HasColumnType("bool")
                .HasColumnName("has_gender_differences");
            entity.Property(e => e.HatchCounter).HasColumnName("hatch_counter");
            entity.Property(e => e.IsBaby)
                .HasColumnType("bool")
                .HasColumnName("is_baby");
            entity.Property(e => e.IsLegendary)
                .HasColumnType("bool")
                .HasColumnName("is_legendary");
            entity.Property(e => e.IsMythical)
                .HasColumnType("bool")
                .HasColumnName("is_mythical");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.PokemonColorId).HasColumnName("pokemon_color_id");
            entity.Property(e => e.PokemonHabitatId).HasColumnName("pokemon_habitat_id");
            entity.Property(e => e.PokemonShapeId).HasColumnName("pokemon_shape_id");

            entity.HasOne(d => d.EvolutionChain).WithMany(p => p.PokemonV2Pokemonspecies).HasForeignKey(d => d.EvolutionChainId);

            entity.HasOne(d => d.EvolvesFromSpecies).WithMany(p => p.InverseEvolvesFromSpecies).HasForeignKey(d => d.EvolvesFromSpeciesId);

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Pokemonspecies).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.GrowthRate).WithMany(p => p.PokemonV2Pokemonspecies).HasForeignKey(d => d.GrowthRateId);

            entity.HasOne(d => d.PokemonColor).WithMany(p => p.PokemonV2Pokemonspecies).HasForeignKey(d => d.PokemonColorId);

            entity.HasOne(d => d.PokemonHabitat).WithMany(p => p.PokemonV2Pokemonspecies).HasForeignKey(d => d.PokemonHabitatId);

            entity.HasOne(d => d.PokemonShape).WithMany(p => p.PokemonV2Pokemonspecies).HasForeignKey(d => d.PokemonShapeId);
        });

        modelBuilder.Entity<PokemonV2Pokemonsprite>(entity => {
            entity.ToTable("pokemon_v2_pokemonsprites");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonsprites_pokemon_id_37e1b6e5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Sprites).HasColumnName("sprites");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemonsprites).HasForeignKey(d => d.PokemonId);
        });

        modelBuilder.Entity<PokemonV2Pokemonstat>(entity => {
            entity.ToTable("pokemon_v2_pokemonstat");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemonstat_pokemon_id_224bda7f");

            entity.HasIndex(e => e.StatId, "pokemon_v2_pokemonstat_stat_id_ff99830f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseStat).HasColumnName("base_stat");
            entity.Property(e => e.Effort).HasColumnName("effort");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.StatId).HasColumnName("stat_id");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemonstats).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Stat).WithMany(p => p.PokemonV2Pokemonstats).HasForeignKey(d => d.StatId);
        });

        modelBuilder.Entity<PokemonV2Pokemontype>(entity => {
            entity.ToTable("pokemon_v2_pokemontype");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemontype_pokemon_id_8cd53409");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_pokemontype_type_id_50c80158");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemontypes).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Type).WithMany(p => p.PokemonV2Pokemontypes).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<PokemonV2Pokemontypepast>(entity => {
            entity.ToTable("pokemon_v2_pokemontypepast");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_pokemontypepast_generation_id_9dbf45f3");

            entity.HasIndex(e => e.PokemonId, "pokemon_v2_pokemontypepast_pokemon_id_7c9bb3e4");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_pokemontypepast_type_id_c7a01783");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Pokemontypepasts).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Pokemon).WithMany(p => p.PokemonV2Pokemontypepasts).HasForeignKey(d => d.PokemonId);

            entity.HasOne(d => d.Type).WithMany(p => p.PokemonV2Pokemontypepasts).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<PokemonV2Region>(entity => {
            entity.ToTable("pokemon_v2_region");

            entity.HasIndex(e => e.Name, "pokemon_v2_region_name_8acf2189");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonV2Regionname>(entity => {
            entity.ToTable("pokemon_v2_regionname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_regionname_language_id_b977a545");

            entity.HasIndex(e => e.Name, "pokemon_v2_regionname_name_d9c7dec9");

            entity.HasIndex(e => e.RegionId, "pokemon_v2_regionname_region_id_70a321d1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.RegionId).HasColumnName("region_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Regionnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Region).WithMany(p => p.PokemonV2Regionnames).HasForeignKey(d => d.RegionId);
        });

        modelBuilder.Entity<PokemonV2Stat>(entity => {
            entity.ToTable("pokemon_v2_stat");

            entity.HasIndex(e => e.MoveDamageClassId, "pokemon_v2_stat_move_damage_class_id_0ed19a23");

            entity.HasIndex(e => e.Name, "pokemon_v2_stat_name_abcae9af");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.IsBattleOnly)
                .HasColumnType("bool")
                .HasColumnName("is_battle_only");
            entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.MoveDamageClass).WithMany(p => p.PokemonV2Stats).HasForeignKey(d => d.MoveDamageClassId);
        });

        modelBuilder.Entity<PokemonV2Statname>(entity => {
            entity.ToTable("pokemon_v2_statname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_statname_language_id_813421dc");

            entity.HasIndex(e => e.Name, "pokemon_v2_statname_name_e6d5a1d2");

            entity.HasIndex(e => e.StatId, "pokemon_v2_statname_stat_id_fadbe40b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.StatId).HasColumnName("stat_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Statnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Stat).WithMany(p => p.PokemonV2Statnames).HasForeignKey(d => d.StatId);
        });

        modelBuilder.Entity<PokemonV2Supercontestcombo>(entity => {
            entity.ToTable("pokemon_v2_supercontestcombo");

            entity.HasIndex(e => e.FirstMoveId, "pokemon_v2_supercontestcombo_first_move_id_b595ebbb");

            entity.HasIndex(e => e.SecondMoveId, "pokemon_v2_supercontestcombo_second_move_id_15fdde61");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstMoveId).HasColumnName("first_move_id");
            entity.Property(e => e.SecondMoveId).HasColumnName("second_move_id");

            entity.HasOne(d => d.FirstMove).WithMany(p => p.PokemonV2SupercontestcomboFirstMoves).HasForeignKey(d => d.FirstMoveId);

            entity.HasOne(d => d.SecondMove).WithMany(p => p.PokemonV2SupercontestcomboSecondMoves).HasForeignKey(d => d.SecondMoveId);
        });

        modelBuilder.Entity<PokemonV2Supercontesteffect>(entity => {
            entity.ToTable("pokemon_v2_supercontesteffect");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appeal).HasColumnName("appeal");
        });

        modelBuilder.Entity<PokemonV2Supercontesteffectflavortext>(entity => {
            entity.ToTable("pokemon_v2_supercontesteffectflavortext");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_supercontesteffectflavortext_language_id_a8b218a8");

            entity.HasIndex(e => e.SuperContestEffectId, "pokemon_v2_supercontesteffectflavortext_super_contest_effect_id_632d04b4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FlavorText)
                .HasColumnType("varchar(500)")
                .HasColumnName("flavor_text");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.SuperContestEffectId).HasColumnName("super_contest_effect_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Supercontesteffectflavortexts).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.SuperContestEffect).WithMany(p => p.PokemonV2Supercontesteffectflavortexts).HasForeignKey(d => d.SuperContestEffectId);
        });

        modelBuilder.Entity<PokemonV2Type>(entity => {
            entity.ToTable("pokemon_v2_type");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_type_generation_id_f3988f1c");

            entity.HasIndex(e => e.MoveDamageClassId, "pokemon_v2_type_move_damage_class_id_5f546a8f");

            entity.HasIndex(e => e.Name, "pokemon_v2_type_name_90172f48");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Types).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.MoveDamageClass).WithMany(p => p.PokemonV2Types).HasForeignKey(d => d.MoveDamageClassId);
        });

        modelBuilder.Entity<PokemonV2Typeefficacy>(entity => {
            entity.ToTable("pokemon_v2_typeefficacy");

            entity.HasIndex(e => e.DamageTypeId, "pokemon_v2_typeefficacy_damage_type_id_1b7c2d73");

            entity.HasIndex(e => e.TargetTypeId, "pokemon_v2_typeefficacy_target_type_id_bf2be275");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DamageFactor).HasColumnName("damage_factor");
            entity.Property(e => e.DamageTypeId).HasColumnName("damage_type_id");
            entity.Property(e => e.TargetTypeId).HasColumnName("target_type_id");

            entity.HasOne(d => d.DamageType).WithMany(p => p.PokemonV2TypeefficacyDamageTypes).HasForeignKey(d => d.DamageTypeId);

            entity.HasOne(d => d.TargetType).WithMany(p => p.PokemonV2TypeefficacyTargetTypes).HasForeignKey(d => d.TargetTypeId);
        });

        modelBuilder.Entity<PokemonV2Typeefficacypast>(entity => {
            entity.ToTable("pokemon_v2_typeefficacypast");

            entity.HasIndex(e => e.DamageTypeId, "pokemon_v2_typeefficacypast_damage_type_id_b8eae4c9");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_typeefficacypast_generation_id_43b555ea");

            entity.HasIndex(e => e.TargetTypeId, "pokemon_v2_typeefficacypast_target_type_id_2e9e1cb6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DamageFactor).HasColumnName("damage_factor");
            entity.Property(e => e.DamageTypeId).HasColumnName("damage_type_id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.TargetTypeId).HasColumnName("target_type_id");

            entity.HasOne(d => d.DamageType).WithMany(p => p.PokemonV2TypeefficacypastDamageTypes).HasForeignKey(d => d.DamageTypeId);

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Typeefficacypasts).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.TargetType).WithMany(p => p.PokemonV2TypeefficacypastTargetTypes).HasForeignKey(d => d.TargetTypeId);
        });

        modelBuilder.Entity<PokemonV2Typegameindex>(entity => {
            entity.ToTable("pokemon_v2_typegameindex");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_typegameindex_generation_id_520a4043");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_typegameindex_type_id_8264662d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GameIndex).HasColumnName("game_index");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Typegameindices).HasForeignKey(d => d.GenerationId);

            entity.HasOne(d => d.Type).WithMany(p => p.PokemonV2Typegameindices).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<PokemonV2Typename>(entity => {
            entity.ToTable("pokemon_v2_typename");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_typename_language_id_6b15eb1d");

            entity.HasIndex(e => e.Name, "pokemon_v2_typename_name_95fbeace");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_typename_type_id_3fe2e4d2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Typenames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Type).WithMany(p => p.PokemonV2Typenames).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<PokemonV2Typesprite>(entity => {
            entity.ToTable("pokemon_v2_typesprites");

            entity.HasIndex(e => e.TypeId, "pokemon_v2_typesprites_type_id_0cfdcdc8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Sprites).HasColumnName("sprites");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Type).WithMany(p => p.PokemonV2Typesprites).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<PokemonV2Version>(entity => {
            entity.ToTable("pokemon_v2_version");

            entity.HasIndex(e => e.Name, "pokemon_v2_version_name_a1b54eaa");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_version_version_group_id_1ab67107");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Versions).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Versiongroup>(entity => {
            entity.ToTable("pokemon_v2_versiongroup");

            entity.HasIndex(e => e.GenerationId, "pokemon_v2_versiongroup_generation_id_f7073699");

            entity.HasIndex(e => e.Name, "pokemon_v2_versiongroup_name_4c396513");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenerationId).HasColumnName("generation_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");

            entity.HasOne(d => d.Generation).WithMany(p => p.PokemonV2Versiongroups).HasForeignKey(d => d.GenerationId);
        });

        modelBuilder.Entity<PokemonV2Versiongroupmovelearnmethod>(entity => {
            entity.ToTable("pokemon_v2_versiongroupmovelearnmethod");

            entity.HasIndex(e => e.MoveLearnMethodId, "pokemon_v2_versiongroupmovelearnmethod_move_learn_method_id_7e827604");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_versiongroupmovelearnmethod_version_group_id_36c973b6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MoveLearnMethodId).HasColumnName("move_learn_method_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.MoveLearnMethod).WithMany(p => p.PokemonV2Versiongroupmovelearnmethods).HasForeignKey(d => d.MoveLearnMethodId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Versiongroupmovelearnmethods).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Versiongroupregion>(entity => {
            entity.ToTable("pokemon_v2_versiongroupregion");

            entity.HasIndex(e => e.RegionId, "pokemon_v2_versiongroupregion_region_id_8f876d0b");

            entity.HasIndex(e => e.VersionGroupId, "pokemon_v2_versiongroupregion_version_group_id_a3445bcb");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

            entity.HasOne(d => d.Region).WithMany(p => p.PokemonV2Versiongroupregions).HasForeignKey(d => d.RegionId);

            entity.HasOne(d => d.VersionGroup).WithMany(p => p.PokemonV2Versiongroupregions).HasForeignKey(d => d.VersionGroupId);
        });

        modelBuilder.Entity<PokemonV2Versionname>(entity => {
            entity.ToTable("pokemon_v2_versionname");

            entity.HasIndex(e => e.LanguageId, "pokemon_v2_versionname_language_id_890e148a");

            entity.HasIndex(e => e.Name, "pokemon_v2_versionname_name_df504fd7");

            entity.HasIndex(e => e.VersionId, "pokemon_v2_versionname_version_id_84baf0a3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .HasColumnName("name");
            entity.Property(e => e.VersionId).HasColumnName("version_id");

            entity.HasOne(d => d.Language).WithMany(p => p.PokemonV2Versionnames).HasForeignKey(d => d.LanguageId);

            entity.HasOne(d => d.Version).WithMany(p => p.PokemonV2Versionnames).HasForeignKey(d => d.VersionId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
