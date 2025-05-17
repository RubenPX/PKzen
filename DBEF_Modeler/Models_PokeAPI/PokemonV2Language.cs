namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Language
{
    public int Id { get; set; }

    public string Iso639 { get; set; } = null!;

    public string Iso3166 { get; set; } = null!;

    public bool Official { get; set; }

    public int? Order { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Abilitychangeeffecttext> PokemonV2Abilitychangeeffecttexts { get; set; } = new List<PokemonV2Abilitychangeeffecttext>();

    public virtual ICollection<PokemonV2Abilityeffecttext> PokemonV2Abilityeffecttexts { get; set; } = new List<PokemonV2Abilityeffecttext>();

    public virtual ICollection<PokemonV2Abilityflavortext> PokemonV2Abilityflavortexts { get; set; } = new List<PokemonV2Abilityflavortext>();

    public virtual ICollection<PokemonV2Abilityname> PokemonV2Abilitynames { get; set; } = new List<PokemonV2Abilityname>();

    public virtual ICollection<PokemonV2Berryfirmnessname> PokemonV2Berryfirmnessnames { get; set; } = new List<PokemonV2Berryfirmnessname>();

    public virtual ICollection<PokemonV2Berryflavorname> PokemonV2Berryflavornames { get; set; } = new List<PokemonV2Berryflavorname>();

    public virtual ICollection<PokemonV2Characteristicdescription> PokemonV2Characteristicdescriptions { get; set; } = new List<PokemonV2Characteristicdescription>();

    public virtual ICollection<PokemonV2Contesteffecteffecttext> PokemonV2Contesteffecteffecttexts { get; set; } = new List<PokemonV2Contesteffecteffecttext>();

    public virtual ICollection<PokemonV2Contesteffectflavortext> PokemonV2Contesteffectflavortexts { get; set; } = new List<PokemonV2Contesteffectflavortext>();

    public virtual ICollection<PokemonV2Contesttypename> PokemonV2Contesttypenames { get; set; } = new List<PokemonV2Contesttypename>();

    public virtual ICollection<PokemonV2Egggroupname> PokemonV2Egggroupnames { get; set; } = new List<PokemonV2Egggroupname>();

    public virtual ICollection<PokemonV2Encounterconditionname> PokemonV2Encounterconditionnames { get; set; } = new List<PokemonV2Encounterconditionname>();

    public virtual ICollection<PokemonV2Encounterconditionvaluename> PokemonV2Encounterconditionvaluenames { get; set; } = new List<PokemonV2Encounterconditionvaluename>();

    public virtual ICollection<PokemonV2Encountermethodname> PokemonV2Encountermethodnames { get; set; } = new List<PokemonV2Encountermethodname>();

    public virtual ICollection<PokemonV2Evolutiontriggername> PokemonV2Evolutiontriggernames { get; set; } = new List<PokemonV2Evolutiontriggername>();

    public virtual ICollection<PokemonV2Generationname> PokemonV2Generationnames { get; set; } = new List<PokemonV2Generationname>();

    public virtual ICollection<PokemonV2Growthratedescription> PokemonV2Growthratedescriptions { get; set; } = new List<PokemonV2Growthratedescription>();

    public virtual ICollection<PokemonV2Itemattributedescription> PokemonV2Itemattributedescriptions { get; set; } = new List<PokemonV2Itemattributedescription>();

    public virtual ICollection<PokemonV2Itemattributename> PokemonV2Itemattributenames { get; set; } = new List<PokemonV2Itemattributename>();

    public virtual ICollection<PokemonV2Itemcategoryname> PokemonV2Itemcategorynames { get; set; } = new List<PokemonV2Itemcategoryname>();

    public virtual ICollection<PokemonV2Itemeffecttext> PokemonV2Itemeffecttexts { get; set; } = new List<PokemonV2Itemeffecttext>();

    public virtual ICollection<PokemonV2Itemflavortext> PokemonV2Itemflavortexts { get; set; } = new List<PokemonV2Itemflavortext>();

    public virtual ICollection<PokemonV2Itemflingeffecteffecttext> PokemonV2Itemflingeffecteffecttexts { get; set; } = new List<PokemonV2Itemflingeffecteffecttext>();

    public virtual ICollection<PokemonV2Itemname> PokemonV2Itemnames { get; set; } = new List<PokemonV2Itemname>();

    public virtual ICollection<PokemonV2Itempocketname> PokemonV2Itempocketnames { get; set; } = new List<PokemonV2Itempocketname>();

    public virtual ICollection<PokemonV2Languagename> PokemonV2LanguagenameLanguages { get; set; } = new List<PokemonV2Languagename>();

    public virtual ICollection<PokemonV2Languagename> PokemonV2LanguagenameLocalLanguages { get; set; } = new List<PokemonV2Languagename>();

    public virtual ICollection<PokemonV2Locationareaname> PokemonV2Locationareanames { get; set; } = new List<PokemonV2Locationareaname>();

    public virtual ICollection<PokemonV2Locationname> PokemonV2Locationnames { get; set; } = new List<PokemonV2Locationname>();

    public virtual ICollection<PokemonV2Moveattributedescription> PokemonV2Moveattributedescriptions { get; set; } = new List<PokemonV2Moveattributedescription>();

    public virtual ICollection<PokemonV2Moveattributename> PokemonV2Moveattributenames { get; set; } = new List<PokemonV2Moveattributename>();

    public virtual ICollection<PokemonV2Movebattlestylename> PokemonV2Movebattlestylenames { get; set; } = new List<PokemonV2Movebattlestylename>();

    public virtual ICollection<PokemonV2Movedamageclassdescription> PokemonV2Movedamageclassdescriptions { get; set; } = new List<PokemonV2Movedamageclassdescription>();

    public virtual ICollection<PokemonV2Movedamageclassname> PokemonV2Movedamageclassnames { get; set; } = new List<PokemonV2Movedamageclassname>();

    public virtual ICollection<PokemonV2Moveeffectchangeeffecttext> PokemonV2Moveeffectchangeeffecttexts { get; set; } = new List<PokemonV2Moveeffectchangeeffecttext>();

    public virtual ICollection<PokemonV2Moveeffecteffecttext> PokemonV2Moveeffecteffecttexts { get; set; } = new List<PokemonV2Moveeffecteffecttext>();

    public virtual ICollection<PokemonV2Moveflavortext> PokemonV2Moveflavortexts { get; set; } = new List<PokemonV2Moveflavortext>();

    public virtual ICollection<PokemonV2Movelearnmethoddescription> PokemonV2Movelearnmethoddescriptions { get; set; } = new List<PokemonV2Movelearnmethoddescription>();

    public virtual ICollection<PokemonV2Movelearnmethodname> PokemonV2Movelearnmethodnames { get; set; } = new List<PokemonV2Movelearnmethodname>();

    public virtual ICollection<PokemonV2Movemetaailmentname> PokemonV2Movemetaailmentnames { get; set; } = new List<PokemonV2Movemetaailmentname>();

    public virtual ICollection<PokemonV2Movemetacategorydescription> PokemonV2Movemetacategorydescriptions { get; set; } = new List<PokemonV2Movemetacategorydescription>();

    public virtual ICollection<PokemonV2Movename> PokemonV2Movenames { get; set; } = new List<PokemonV2Movename>();

    public virtual ICollection<PokemonV2Movetargetdescription> PokemonV2Movetargetdescriptions { get; set; } = new List<PokemonV2Movetargetdescription>();

    public virtual ICollection<PokemonV2Movetargetname> PokemonV2Movetargetnames { get; set; } = new List<PokemonV2Movetargetname>();

    public virtual ICollection<PokemonV2Naturename> PokemonV2Naturenames { get; set; } = new List<PokemonV2Naturename>();

    public virtual ICollection<PokemonV2Palparkareaname> PokemonV2Palparkareanames { get; set; } = new List<PokemonV2Palparkareaname>();

    public virtual ICollection<PokemonV2Pokeathlonstatname> PokemonV2Pokeathlonstatnames { get; set; } = new List<PokemonV2Pokeathlonstatname>();

    public virtual ICollection<PokemonV2Pokedexdescription> PokemonV2Pokedexdescriptions { get; set; } = new List<PokemonV2Pokedexdescription>();

    public virtual ICollection<PokemonV2Pokedexname> PokemonV2Pokedexnames { get; set; } = new List<PokemonV2Pokedexname>();

    public virtual ICollection<PokemonV2Pokemoncolorname> PokemonV2Pokemoncolornames { get; set; } = new List<PokemonV2Pokemoncolorname>();

    public virtual ICollection<PokemonV2Pokemonformname> PokemonV2Pokemonformnames { get; set; } = new List<PokemonV2Pokemonformname>();

    public virtual ICollection<PokemonV2Pokemonhabitatname> PokemonV2Pokemonhabitatnames { get; set; } = new List<PokemonV2Pokemonhabitatname>();

    public virtual ICollection<PokemonV2Pokemonshapename> PokemonV2Pokemonshapenames { get; set; } = new List<PokemonV2Pokemonshapename>();

    public virtual ICollection<PokemonV2Pokemonspeciesdescription> PokemonV2Pokemonspeciesdescriptions { get; set; } = new List<PokemonV2Pokemonspeciesdescription>();

    public virtual ICollection<PokemonV2Pokemonspeciesflavortext> PokemonV2Pokemonspeciesflavortexts { get; set; } = new List<PokemonV2Pokemonspeciesflavortext>();

    public virtual ICollection<PokemonV2Pokemonspeciesname> PokemonV2Pokemonspeciesnames { get; set; } = new List<PokemonV2Pokemonspeciesname>();

    public virtual ICollection<PokemonV2Regionname> PokemonV2Regionnames { get; set; } = new List<PokemonV2Regionname>();

    public virtual ICollection<PokemonV2Statname> PokemonV2Statnames { get; set; } = new List<PokemonV2Statname>();

    public virtual ICollection<PokemonV2Supercontesteffectflavortext> PokemonV2Supercontesteffectflavortexts { get; set; } = new List<PokemonV2Supercontesteffectflavortext>();

    public virtual ICollection<PokemonV2Typename> PokemonV2Typenames { get; set; } = new List<PokemonV2Typename>();

    public virtual ICollection<PokemonV2Versionname> PokemonV2Versionnames { get; set; } = new List<PokemonV2Versionname>();
}
