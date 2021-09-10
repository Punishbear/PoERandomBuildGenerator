using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PoERandomBuildGenerator
{
    public partial class PassiveTree
    {
        [JsonProperty("classes")]
        public List<Class> Classes { get; set; }

#if DEBUG
        [JsonProperty("groups")]
        public Dictionary<string, Group> Groups { get; set; }

        [JsonProperty("extraImages")]
        public Dictionary<string, ExtraImage> ExtraImages { get; set; }

        [JsonProperty("assets")]
        public Assets Assets { get; set; }

        [JsonProperty("constants")]
        public Constants Constants { get; set; }

        [JsonProperty("skillSprites")]
        public SkillSprites SkillSprites { get; set; }
#endif
        [JsonProperty("nodes")]
        public Dictionary<string, Node> Nodes { get; set; }

        [JsonProperty("jewelSlots")]
        public List<long> JewelSlots { get; set; }

        [JsonProperty("min_x")]
        public long MinX { get; set; }

        [JsonProperty("min_y")]
        public long MinY { get; set; }

        [JsonProperty("max_x")]
        public long MaxX { get; set; }

        [JsonProperty("max_y")]
        public long MaxY { get; set; }

        [JsonProperty("imageZoomLevels")]
        public List<double> ImageZoomLevels { get; set; }
    }

#if DEBUG
    public partial class Assets
    {
        [JsonProperty("PSSkillFrame")]
        public AscendancyButton PsSkillFrame { get; set; }

        [JsonProperty("PSSkillFrameHighlighted")]
        public AscendancyButton PsSkillFrameHighlighted { get; set; }

        [JsonProperty("PSSkillFrameActive")]
        public AscendancyButton PsSkillFrameActive { get; set; }

        [JsonProperty("KeystoneFrameUnallocated")]
        public AscendancyButton KeystoneFrameUnallocated { get; set; }

        [JsonProperty("KeystoneFrameCanAllocate")]
        public AscendancyButton KeystoneFrameCanAllocate { get; set; }

        [JsonProperty("KeystoneFrameAllocated")]
        public AscendancyButton KeystoneFrameAllocated { get; set; }

        [JsonProperty("PSGroupBackground1")]
        public AscendancyButton PsGroupBackground1 { get; set; }

        [JsonProperty("PSGroupBackground2")]
        public AscendancyButton PsGroupBackground2 { get; set; }

        [JsonProperty("PSGroupBackground3")]
        public AscendancyButton PsGroupBackground3 { get; set; }

        [JsonProperty("GroupBackgroundSmallAlt")]
        public AscendancyButton GroupBackgroundSmallAlt { get; set; }

        [JsonProperty("GroupBackgroundMediumAlt")]
        public AscendancyButton GroupBackgroundMediumAlt { get; set; }

        [JsonProperty("GroupBackgroundLargeHalfAlt")]
        public AscendancyButton GroupBackgroundLargeHalfAlt { get; set; }

        [JsonProperty("Orbit1Normal")]
        public AscendancyButton Orbit1Normal { get; set; }

        [JsonProperty("Orbit1Intermediate")]
        public AscendancyButton Orbit1Intermediate { get; set; }

        [JsonProperty("Orbit1Active")]
        public AscendancyButton Orbit1Active { get; set; }

        [JsonProperty("Orbit2Normal")]
        public AscendancyButton Orbit2Normal { get; set; }

        [JsonProperty("Orbit2Intermediate")]
        public AscendancyButton Orbit2Intermediate { get; set; }

        [JsonProperty("Orbit2Active")]
        public AscendancyButton Orbit2Active { get; set; }

        [JsonProperty("Orbit3Normal")]
        public AscendancyButton Orbit3Normal { get; set; }

        [JsonProperty("Orbit3Intermediate")]
        public AscendancyButton Orbit3Intermediate { get; set; }

        [JsonProperty("Orbit3Active")]
        public AscendancyButton Orbit3Active { get; set; }

        [JsonProperty("Orbit4Normal")]
        public AscendancyButton Orbit4Normal { get; set; }

        [JsonProperty("Orbit4Intermediate")]
        public AscendancyButton Orbit4Intermediate { get; set; }

        [JsonProperty("Orbit4Active")]
        public AscendancyButton Orbit4Active { get; set; }

        [JsonProperty("LineConnectorNormal")]
        public AscendancyButton LineConnectorNormal { get; set; }

        [JsonProperty("LineConnectorIntermediate")]
        public AscendancyButton LineConnectorIntermediate { get; set; }

        [JsonProperty("LineConnectorActive")]
        public AscendancyButton LineConnectorActive { get; set; }

        [JsonProperty("PSLineDeco")]
        public AscendancyButton PsLineDeco { get; set; }

        [JsonProperty("PSLineDecoHighlighted")]
        public AscendancyButton PsLineDecoHighlighted { get; set; }

        [JsonProperty("PSStartNodeBackgroundInactive")]
        public AscendancyButton PsStartNodeBackgroundInactive { get; set; }

        [JsonProperty("centerduelist")]
        public AscendancyButton Centerduelist { get; set; }

        [JsonProperty("centermarauder")]
        public AscendancyButton Centermarauder { get; set; }

        [JsonProperty("centerranger")]
        public AscendancyButton Centerranger { get; set; }

        [JsonProperty("centershadow")]
        public AscendancyButton Centershadow { get; set; }

        [JsonProperty("centertemplar")]
        public AscendancyButton Centertemplar { get; set; }

        [JsonProperty("centerwitch")]
        public AscendancyButton Centerwitch { get; set; }

        [JsonProperty("centerscion")]
        public AscendancyButton Centerscion { get; set; }

        [JsonProperty("PSPointsFrame")]
        public EternalEmpireJewelCircle1 PsPointsFrame { get; set; }

        [JsonProperty("NotableFrameUnallocated")]
        public AscendancyButton NotableFrameUnallocated { get; set; }

        [JsonProperty("NotableFrameCanAllocate")]
        public AscendancyButton NotableFrameCanAllocate { get; set; }

        [JsonProperty("NotableFrameAllocated")]
        public AscendancyButton NotableFrameAllocated { get; set; }

        [JsonProperty("BlightedNotableFrameUnallocated")]
        public AscendancyButton BlightedNotableFrameUnallocated { get; set; }

        [JsonProperty("BlightedNotableFrameCanAllocate")]
        public AscendancyButton BlightedNotableFrameCanAllocate { get; set; }

        [JsonProperty("BlightedNotableFrameAllocated")]
        public AscendancyButton BlightedNotableFrameAllocated { get; set; }

        [JsonProperty("JewelFrameUnallocated")]
        public AscendancyButton JewelFrameUnallocated { get; set; }

        [JsonProperty("JewelFrameCanAllocate")]
        public AscendancyButton JewelFrameCanAllocate { get; set; }

        [JsonProperty("JewelFrameAllocated")]
        public AscendancyButton JewelFrameAllocated { get; set; }

        [JsonProperty("JewelSocketActiveBlue")]
        public AscendancyButton JewelSocketActiveBlue { get; set; }

        [JsonProperty("JewelSocketActiveGreen")]
        public AscendancyButton JewelSocketActiveGreen { get; set; }

        [JsonProperty("JewelSocketActiveRed")]
        public AscendancyButton JewelSocketActiveRed { get; set; }

        [JsonProperty("JewelSocketActivePrismatic")]
        public AscendancyButton JewelSocketActivePrismatic { get; set; }

        [JsonProperty("JewelSocketActiveAbyss")]
        public AscendancyButton JewelSocketActiveAbyss { get; set; }

        [JsonProperty("JewelSocketActiveLegion")]
        public AscendancyButton JewelSocketActiveLegion { get; set; }

        [JsonProperty("JewelSocketActiveAltRed")]
        public AscendancyButton JewelSocketActiveAltRed { get; set; }

        [JsonProperty("JewelSocketActiveAltBlue")]
        public AscendancyButton JewelSocketActiveAltBlue { get; set; }

        [JsonProperty("JewelSocketActiveAltPurple")]
        public AscendancyButton JewelSocketActiveAltPurple { get; set; }

        [JsonProperty("JewelCircle1")]
        public EternalEmpireJewelCircle1 JewelCircle1 { get; set; }

        [JsonProperty("JewelCircle1Inverse")]
        public EternalEmpireJewelCircle1 JewelCircle1Inverse { get; set; }

        [JsonProperty("VaalJewelCircle1")]
        public EternalEmpireJewelCircle1 VaalJewelCircle1 { get; set; }

        [JsonProperty("VaalJewelCircle2")]
        public EternalEmpireJewelCircle1 VaalJewelCircle2 { get; set; }

        [JsonProperty("KaruiJewelCircle1")]
        public EternalEmpireJewelCircle1 KaruiJewelCircle1 { get; set; }

        [JsonProperty("KaruiJewelCircle2")]
        public EternalEmpireJewelCircle1 KaruiJewelCircle2 { get; set; }

        [JsonProperty("MarakethJewelCircle1")]
        public EternalEmpireJewelCircle1 MarakethJewelCircle1 { get; set; }

        [JsonProperty("MarakethJewelCircle2")]
        public EternalEmpireJewelCircle1 MarakethJewelCircle2 { get; set; }

        [JsonProperty("TemplarJewelCircle1")]
        public EternalEmpireJewelCircle1 TemplarJewelCircle1 { get; set; }

        [JsonProperty("TemplarJewelCircle2")]
        public EternalEmpireJewelCircle1 TemplarJewelCircle2 { get; set; }

        [JsonProperty("EternalEmpireJewelCircle1")]
        public EternalEmpireJewelCircle1 EternalEmpireJewelCircle1 { get; set; }

        [JsonProperty("EternalEmpireJewelCircle2")]
        public EternalEmpireJewelCircle1 EternalEmpireJewelCircle2 { get; set; }

        [JsonProperty("JewelSocketAltNormal")]
        public AscendancyButton JewelSocketAltNormal { get; set; }

        [JsonProperty("JewelSocketAltCanAllocate")]
        public AscendancyButton JewelSocketAltCanAllocate { get; set; }

        [JsonProperty("JewelSocketAltActive")]
        public AscendancyButton JewelSocketAltActive { get; set; }

        [JsonProperty("JewelSocketActiveBlueAlt")]
        public AscendancyButton JewelSocketActiveBlueAlt { get; set; }

        [JsonProperty("JewelSocketActiveGreenAlt")]
        public AscendancyButton JewelSocketActiveGreenAlt { get; set; }

        [JsonProperty("JewelSocketActiveRedAlt")]
        public AscendancyButton JewelSocketActiveRedAlt { get; set; }

        [JsonProperty("JewelSocketActivePrismaticAlt")]
        public AscendancyButton JewelSocketActivePrismaticAlt { get; set; }

        [JsonProperty("JewelSocketActiveAbyssAlt")]
        public AscendancyButton JewelSocketActiveAbyssAlt { get; set; }

        [JsonProperty("JewelSocketActiveLegionAlt")]
        public AscendancyButton JewelSocketActiveLegionAlt { get; set; }

        [JsonProperty("JewelSocketClusterAltNormal1Small")]
        public AscendancyButton JewelSocketClusterAltNormal1Small { get; set; }

        [JsonProperty("JewelSocketClusterAltCanAllocate1Small")]
        public AscendancyButton JewelSocketClusterAltCanAllocate1Small { get; set; }

        [JsonProperty("JewelSocketClusterAltNormal1Medium")]
        public AscendancyButton JewelSocketClusterAltNormal1Medium { get; set; }

        [JsonProperty("JewelSocketClusterAltCanAllocate1Medium")]
        public AscendancyButton JewelSocketClusterAltCanAllocate1Medium { get; set; }

        [JsonProperty("JewelSocketClusterAltNormal1Large")]
        public AscendancyButton JewelSocketClusterAltNormal1Large { get; set; }

        [JsonProperty("JewelSocketClusterAltCanAllocate1Large")]
        public AscendancyButton JewelSocketClusterAltCanAllocate1Large { get; set; }

        [JsonProperty("AscendancyButton")]
        public AscendancyButton AscendancyButton { get; set; }

        [JsonProperty("AscendancyButtonHighlight")]
        public AscendancyButton AscendancyButtonHighlight { get; set; }

        [JsonProperty("AscendancyButtonPressed")]
        public AscendancyButton AscendancyButtonPressed { get; set; }

        [JsonProperty("AscendancyFrameLargeAllocated")]
        public AscendancyButton AscendancyFrameLargeAllocated { get; set; }

        [JsonProperty("AscendancyFrameLargeCanAllocate")]
        public AscendancyButton AscendancyFrameLargeCanAllocate { get; set; }

        [JsonProperty("AscendancyFrameLargeNormal")]
        public AscendancyButton AscendancyFrameLargeNormal { get; set; }

        [JsonProperty("AscendancyFrameSmallAllocated")]
        public AscendancyButton AscendancyFrameSmallAllocated { get; set; }

        [JsonProperty("AscendancyFrameSmallCanAllocate")]
        public AscendancyButton AscendancyFrameSmallCanAllocate { get; set; }

        [JsonProperty("AscendancyFrameSmallNormal")]
        public AscendancyButton AscendancyFrameSmallNormal { get; set; }

        [JsonProperty("AscendancyMiddle")]
        public AscendancyButton AscendancyMiddle { get; set; }

        [JsonProperty("ClassesAscendant")]
        public AscendancyButton ClassesAscendant { get; set; }

        [JsonProperty("ClassesJuggernaut")]
        public AscendancyButton ClassesJuggernaut { get; set; }

        [JsonProperty("ClassesBerserker")]
        public AscendancyButton ClassesBerserker { get; set; }

        [JsonProperty("ClassesChieftain")]
        public AscendancyButton ClassesChieftain { get; set; }

        [JsonProperty("ClassesRaider")]
        public AscendancyButton ClassesRaider { get; set; }

        [JsonProperty("ClassesDeadeye")]
        public AscendancyButton ClassesDeadeye { get; set; }

        [JsonProperty("ClassesPathfinder")]
        public AscendancyButton ClassesPathfinder { get; set; }

        [JsonProperty("ClassesOccultist")]
        public AscendancyButton ClassesOccultist { get; set; }

        [JsonProperty("ClassesElementalist")]
        public AscendancyButton ClassesElementalist { get; set; }

        [JsonProperty("ClassesNecromancer")]
        public AscendancyButton ClassesNecromancer { get; set; }

        [JsonProperty("ClassesSlayer")]
        public AscendancyButton ClassesSlayer { get; set; }

        [JsonProperty("ClassesGladiator")]
        public AscendancyButton ClassesGladiator { get; set; }

        [JsonProperty("ClassesChampion")]
        public AscendancyButton ClassesChampion { get; set; }

        [JsonProperty("ClassesInquisitor")]
        public AscendancyButton ClassesInquisitor { get; set; }

        [JsonProperty("ClassesHierophant")]
        public AscendancyButton ClassesHierophant { get; set; }

        [JsonProperty("ClassesGuardian")]
        public AscendancyButton ClassesGuardian { get; set; }

        [JsonProperty("ClassesAssassin")]
        public AscendancyButton ClassesAssassin { get; set; }

        [JsonProperty("ClassesTrickster")]
        public AscendancyButton ClassesTrickster { get; set; }

        [JsonProperty("ClassesSaboteur")]
        public AscendancyButton ClassesSaboteur { get; set; }

        [JsonProperty("Background1")]
        public AscendancyButton Background1 { get; set; }

        [JsonProperty("BackgroundDex")]
        public AscendancyButton BackgroundDex { get; set; }

        [JsonProperty("BackgroundDexInt")]
        public AscendancyButton BackgroundDexInt { get; set; }

        [JsonProperty("BackgroundInt")]
        public AscendancyButton BackgroundInt { get; set; }

        [JsonProperty("BackgroundStr")]
        public AscendancyButton BackgroundStr { get; set; }

        [JsonProperty("BackgroundStrDex")]
        public AscendancyButton BackgroundStrDex { get; set; }

        [JsonProperty("BackgroundStrInt")]
        public AscendancyButton BackgroundStrInt { get; set; }

        [JsonProperty("imgPSFadeCorner")]
        public EternalEmpireJewelCircle1 ImgPsFadeCorner { get; set; }

        [JsonProperty("imgPSFadeSide")]
        public EternalEmpireJewelCircle1 ImgPsFadeSide { get; set; }
    }

    public partial class AscendancyButton
    {
        [JsonProperty("0.1246")]
        public Uri The01246 { get; set; }

        [JsonProperty("0.2109")]
        public Uri The02109 { get; set; }

        [JsonProperty("0.2972")]
        public Uri The02972 { get; set; }

        [JsonProperty("0.3835")]
        public Uri The03835 { get; set; }
    }

    public partial class EternalEmpireJewelCircle1
    {
        [JsonProperty("1")]
        public Uri The1 { get; set; }
    }
#endif
    public partial class Class
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("base_str")]
        public long BaseStr { get; set; }

        [JsonProperty("base_dex")]
        public long BaseDex { get; set; }

        [JsonProperty("base_int")]
        public long BaseInt { get; set; }

        [JsonProperty("ascendancies")]
        public List<Ascendancy> Ascendancies { get; set; }
    }

    public partial class Ascendancy : PropertyChangedBase
    {
        public Ascendancy()
        {
            isActive = true;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("flavourText", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavourText { get; set; }

        [JsonProperty("flavourTextColour", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavourTextColour { get; set; }

        [JsonProperty("flavourTextRect", NullValueHandling = NullValueHandling.Ignore)]
        public FlavourTextRect FlavourTextRect { get; set; }

        private bool isActive;

        public bool IsActive
        {
            get => isActive;
            set => SetProperty(ref isActive, value);
        }
    }

    public partial class FlavourTextRect
    {
        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

#if DEBUG
    public partial class Constants
    {
        [JsonProperty("classes")]
        public Classes Classes { get; set; }

        [JsonProperty("characterAttributes")]
        public CharacterAttributes CharacterAttributes { get; set; }

        [JsonProperty("PSSCentreInnerRadius")]
        public long PssCentreInnerRadius { get; set; }

        [JsonProperty("skillsPerOrbit")]
        public List<long> SkillsPerOrbit { get; set; }

        [JsonProperty("orbitRadii")]
        public List<long> OrbitRadii { get; set; }
    }

    public partial class CharacterAttributes
    {
        [JsonProperty("Strength")]
        public long Strength { get; set; }

        [JsonProperty("Dexterity")]
        public long Dexterity { get; set; }

        [JsonProperty("Intelligence")]
        public long Intelligence { get; set; }
    }

    public partial class Classes
    {
        [JsonProperty("StrDexIntClass")]
        public long StrDexIntClass { get; set; }

        [JsonProperty("StrClass")]
        public long StrClass { get; set; }

        [JsonProperty("DexClass")]
        public long DexClass { get; set; }

        [JsonProperty("IntClass")]
        public long IntClass { get; set; }

        [JsonProperty("StrDexClass")]
        public long StrDexClass { get; set; }

        [JsonProperty("StrIntClass")]
        public long StrIntClass { get; set; }

        [JsonProperty("DexIntClass")]
        public long DexIntClass { get; set; }
    }

    public partial class ExtraImage
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public partial class Group
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("orbits")]
        public List<long> Orbits { get; set; }

        [JsonProperty("nodes")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Nodes { get; set; }

        [JsonProperty("isProxy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProxy { get; set; }
    }
#endif

    public partial class Node : PropertyChangedBase
    {
        public Node()
        {
            isActive = true;
        }

        [JsonProperty("skill", NullValueHandling = NullValueHandling.Ignore)]
        public long? Skill { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("isNotable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNotable { get; set; }

#if DEBUG
        [JsonProperty("recipe", NullValueHandling = NullValueHandling.Ignore)]
        public List<Recipe> Recipe { get; set; }
        [JsonProperty("expansionJewel", NullValueHandling = NullValueHandling.Ignore)]
        public ExpansionJewel ExpansionJewel { get; set; }
#endif

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Stats { get; set; }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public long? Group { get; set; }

        [JsonProperty("orbit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Orbit { get; set; }

        [JsonProperty("orbitIndex", NullValueHandling = NullValueHandling.Ignore)]
        public long? OrbitIndex { get; set; }

        [JsonProperty("out", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Out { get; set; }

        [JsonProperty("in", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> In { get; set; }

        [JsonProperty("reminderText", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReminderText { get; set; }

        [JsonProperty("isMastery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMastery { get; set; }

        [JsonProperty("grantedStrength", NullValueHandling = NullValueHandling.Ignore)]
        public long? GrantedStrength { get; set; }

        [JsonProperty("ascendancyName", NullValueHandling = NullValueHandling.Ignore)]
        public string AscendancyName { get; set; }

        [JsonProperty("grantedDexterity", NullValueHandling = NullValueHandling.Ignore)]
        public long? GrantedDexterity { get; set; }

        [JsonProperty("isAscendancyStart", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAscendancyStart { get; set; }

        [JsonProperty("isMultipleChoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultipleChoice { get; set; }

        [JsonProperty("grantedIntelligence", NullValueHandling = NullValueHandling.Ignore)]
        public long? GrantedIntelligence { get; set; }

        [JsonProperty("isJewelSocket", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsJewelSocket { get; set; }

        [JsonProperty("grantedPassivePoints", NullValueHandling = NullValueHandling.Ignore)]
        public long? GrantedPassivePoints { get; set; }

        [JsonProperty("isKeystone", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsKeystone { get; set; }

        [JsonProperty("flavourText", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FlavourText { get; set; }

        [JsonProperty("isProxy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProxy { get; set; }

        [JsonProperty("isMultipleChoiceOption", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultipleChoiceOption { get; set; }

        [JsonProperty("isBlighted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBlighted { get; set; }

        [JsonProperty("classStartIndex", NullValueHandling = NullValueHandling.Ignore)]
        public long? ClassStartIndex { get; set; }

        private bool isActive;

        public bool IsActive
        {
            get => isActive;
            set => SetProperty(ref isActive, value);
        }
    }

#if DEBUG
    public partial class ExpansionJewel
    {
        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("index")]
        public long Index { get; set; }

        [JsonProperty("proxy")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Proxy { get; set; }

        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Parent { get; set; }
    }

    public partial class SkillSprites
    {
        [JsonProperty("normalActive")]
        public List<KeystoneActive> NormalActive { get; set; }

        [JsonProperty("notableActive")]
        public List<KeystoneActive> NotableActive { get; set; }

        [JsonProperty("keystoneActive")]
        public List<KeystoneActive> KeystoneActive { get; set; }

        [JsonProperty("normalInactive")]
        public List<KeystoneActive> NormalInactive { get; set; }

        [JsonProperty("notableInactive")]
        public List<KeystoneActive> NotableInactive { get; set; }

        [JsonProperty("keystoneInactive")]
        public List<KeystoneActive> KeystoneInactive { get; set; }

        [JsonProperty("mastery")]
        public List<KeystoneActive> Mastery { get; set; }
    }

    public partial class KeystoneActive
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("coords")]
        public Dictionary<string, Coord> Coords { get; set; }
    }

    public partial class Coord
    {
        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("w")]
        public long W { get; set; }

        [JsonProperty("h")]
        public long H { get; set; }
    }

    public enum Recipe { AmberOil, AzureOil, BlackOil, ClearOil, CrimsonOil, GoldenOil, IndigoOil, OpalescentOil, SepiaOil, SilverOil, TealOil, VerdantOil, VioletOil };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                RecipeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
#endif

    internal class DecodeArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(List<long>);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (List<long>)untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

#if DEBUG
    internal class RecipeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Recipe) || t == typeof(Recipe?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AmberOil":
                    return Recipe.AmberOil;
                case "AzureOil":
                    return Recipe.AzureOil;
                case "BlackOil":
                    return Recipe.BlackOil;
                case "ClearOil":
                    return Recipe.ClearOil;
                case "CrimsonOil":
                    return Recipe.CrimsonOil;
                case "GoldenOil":
                    return Recipe.GoldenOil;
                case "IndigoOil":
                    return Recipe.IndigoOil;
                case "OpalescentOil":
                    return Recipe.OpalescentOil;
                case "SepiaOil":
                    return Recipe.SepiaOil;
                case "SilverOil":
                    return Recipe.SilverOil;
                case "TealOil":
                    return Recipe.TealOil;
                case "VerdantOil":
                    return Recipe.VerdantOil;
                case "VioletOil":
                    return Recipe.VioletOil;
            }
            throw new Exception("Cannot unmarshal type Recipe");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Recipe)untypedValue;
            switch (value)
            {
                case Recipe.AmberOil:
                    serializer.Serialize(writer, "AmberOil");
                    return;
                case Recipe.AzureOil:
                    serializer.Serialize(writer, "AzureOil");
                    return;
                case Recipe.BlackOil:
                    serializer.Serialize(writer, "BlackOil");
                    return;
                case Recipe.ClearOil:
                    serializer.Serialize(writer, "ClearOil");
                    return;
                case Recipe.CrimsonOil:
                    serializer.Serialize(writer, "CrimsonOil");
                    return;
                case Recipe.GoldenOil:
                    serializer.Serialize(writer, "GoldenOil");
                    return;
                case Recipe.IndigoOil:
                    serializer.Serialize(writer, "IndigoOil");
                    return;
                case Recipe.OpalescentOil:
                    serializer.Serialize(writer, "OpalescentOil");
                    return;
                case Recipe.SepiaOil:
                    serializer.Serialize(writer, "SepiaOil");
                    return;
                case Recipe.SilverOil:
                    serializer.Serialize(writer, "SilverOil");
                    return;
                case Recipe.TealOil:
                    serializer.Serialize(writer, "TealOil");
                    return;
                case Recipe.VerdantOil:
                    serializer.Serialize(writer, "VerdantOil");
                    return;
                case Recipe.VioletOil:
                    serializer.Serialize(writer, "VioletOil");
                    return;
            }
            throw new Exception("Cannot marshal type Recipe");
        }

        public static readonly RecipeConverter Singleton = new RecipeConverter();
    }
#endif
}
