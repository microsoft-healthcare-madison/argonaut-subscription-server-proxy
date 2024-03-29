// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The method by which the substance weight was measured.
  /// </summary>
  public static class SubstanceWeightMethodCodes
  {
    /// <summary>
    /// calculated
    /// </summary>
    public static readonly Coding Calculated = new Coding
    {
      Code = "Calculated",
      Display = "calculated",
      System = "http://hl7.org/fhir/substance-weight-method"
    };
    /// <summary>
    /// End-group analysis
    /// </summary>
    public static readonly Coding EndGroupAnalysis = new Coding
    {
      Code = "End-groupAnalysis",
      Display = "End-group analysis",
      System = "http://hl7.org/fhir/substance-weight-method"
    };
    /// <summary>
    /// End-group titration
    /// </summary>
    public static readonly Coding EndGroupTitration = new Coding
    {
      Code = "End-groupTitration",
      Display = "End-group titration",
      System = "http://hl7.org/fhir/substance-weight-method"
    };
    /// <summary>
    /// gel permeation centrifugation
    /// </summary>
    public static readonly Coding GelPermeationCentrifugation = new Coding
    {
      Code = "GelPermeationCentrifugation",
      Display = "gel permeation centrifugation",
      System = "http://hl7.org/fhir/substance-weight-method"
    };
    /// <summary>
    /// light scattering
    /// </summary>
    public static readonly Coding LightScattering = new Coding
    {
      Code = "LighScattering",
      Display = "light scattering",
      System = "http://hl7.org/fhir/substance-weight-method"
    };
    /// <summary>
    /// SDS-PAGE (sodium dodecyl sulfate-polyacrylamide gel electrophoresis)
    /// </summary>
    public static readonly Coding SDSPAGESodiumDodecylSulfatePolyacrylamideGelElectrophoresis = new Coding
    {
      Code = "SDS-PAGE",
      Display = "SDS-PAGE (sodium dodecyl sulfate-polyacrylamide gel electrophoresis)",
      System = "http://hl7.org/fhir/substance-weight-method"
    };
    /// <summary>
    /// Size-exclusion chromatography
    /// </summary>
    public static readonly Coding SizeExclusionChromatography = new Coding
    {
      Code = "Size-ExclusionChromatography",
      Display = "Size-exclusion chromatography",
      System = "http://hl7.org/fhir/substance-weight-method"
    };
    /// <summary>
    /// viscosity
    /// </summary>
    public static readonly Coding Viscosity = new Coding
    {
      Code = "Viscosity",
      Display = "viscosity",
      System = "http://hl7.org/fhir/substance-weight-method"
    };

    /// <summary>
    /// Literal for code: Calculated
    /// </summary>
    public const string LiteralCalculated = "Calculated";

    /// <summary>
    /// Literal for code: SubstanceWeightMethodCalculated
    /// </summary>
    public const string LiteralSubstanceWeightMethodCalculated = "http://hl7.org/fhir/substance-weight-method#Calculated";

    /// <summary>
    /// Literal for code: EndGroupAnalysis
    /// </summary>
    public const string LiteralEndGroupAnalysis = "End-groupAnalysis";

    /// <summary>
    /// Literal for code: SubstanceWeightMethodEndGroupAnalysis
    /// </summary>
    public const string LiteralSubstanceWeightMethodEndGroupAnalysis = "http://hl7.org/fhir/substance-weight-method#End-groupAnalysis";

    /// <summary>
    /// Literal for code: EndGroupTitration
    /// </summary>
    public const string LiteralEndGroupTitration = "End-groupTitration";

    /// <summary>
    /// Literal for code: SubstanceWeightMethodEndGroupTitration
    /// </summary>
    public const string LiteralSubstanceWeightMethodEndGroupTitration = "http://hl7.org/fhir/substance-weight-method#End-groupTitration";

    /// <summary>
    /// Literal for code: GelPermeationCentrifugation
    /// </summary>
    public const string LiteralGelPermeationCentrifugation = "GelPermeationCentrifugation";

    /// <summary>
    /// Literal for code: SubstanceWeightMethodGelPermeationCentrifugation
    /// </summary>
    public const string LiteralSubstanceWeightMethodGelPermeationCentrifugation = "http://hl7.org/fhir/substance-weight-method#GelPermeationCentrifugation";

    /// <summary>
    /// Literal for code: LightScattering
    /// </summary>
    public const string LiteralLightScattering = "LighScattering";

    /// <summary>
    /// Literal for code: SubstanceWeightMethodLightScattering
    /// </summary>
    public const string LiteralSubstanceWeightMethodLightScattering = "http://hl7.org/fhir/substance-weight-method#LighScattering";

    /// <summary>
    /// Literal for code: SDSPAGESodiumDodecylSulfatePolyacrylamideGelElectrophoresis
    /// </summary>
    public const string LiteralSDSPAGESodiumDodecylSulfatePolyacrylamideGelElectrophoresis = "SDS-PAGE";

    /// <summary>
    /// Literal for code: SubstanceWeightMethodSDSPAGESodiumDodecylSulfatePolyacrylamideGelElectrophoresis
    /// </summary>
    public const string LiteralSubstanceWeightMethodSDSPAGESodiumDodecylSulfatePolyacrylamideGelElectrophoresis = "http://hl7.org/fhir/substance-weight-method#SDS-PAGE";

    /// <summary>
    /// Literal for code: SizeExclusionChromatography
    /// </summary>
    public const string LiteralSizeExclusionChromatography = "Size-ExclusionChromatography";

    /// <summary>
    /// Literal for code: SubstanceWeightMethodSizeExclusionChromatography
    /// </summary>
    public const string LiteralSubstanceWeightMethodSizeExclusionChromatography = "http://hl7.org/fhir/substance-weight-method#Size-ExclusionChromatography";

    /// <summary>
    /// Literal for code: Viscosity
    /// </summary>
    public const string LiteralViscosity = "Viscosity";

    /// <summary>
    /// Literal for code: SubstanceWeightMethodViscosity
    /// </summary>
    public const string LiteralSubstanceWeightMethodViscosity = "http://hl7.org/fhir/substance-weight-method#Viscosity";

    /// <summary>
    /// Dictionary for looking up SubstanceWeightMethod Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "Calculated", Calculated }, 
      { "http://hl7.org/fhir/substance-weight-method#Calculated", Calculated }, 
      { "End-groupAnalysis", EndGroupAnalysis }, 
      { "http://hl7.org/fhir/substance-weight-method#End-groupAnalysis", EndGroupAnalysis }, 
      { "End-groupTitration", EndGroupTitration }, 
      { "http://hl7.org/fhir/substance-weight-method#End-groupTitration", EndGroupTitration }, 
      { "GelPermeationCentrifugation", GelPermeationCentrifugation }, 
      { "http://hl7.org/fhir/substance-weight-method#GelPermeationCentrifugation", GelPermeationCentrifugation }, 
      { "LighScattering", LightScattering }, 
      { "http://hl7.org/fhir/substance-weight-method#LighScattering", LightScattering }, 
      { "SDS-PAGE", SDSPAGESodiumDodecylSulfatePolyacrylamideGelElectrophoresis }, 
      { "http://hl7.org/fhir/substance-weight-method#SDS-PAGE", SDSPAGESodiumDodecylSulfatePolyacrylamideGelElectrophoresis }, 
      { "Size-ExclusionChromatography", SizeExclusionChromatography }, 
      { "http://hl7.org/fhir/substance-weight-method#Size-ExclusionChromatography", SizeExclusionChromatography }, 
      { "Viscosity", Viscosity }, 
      { "http://hl7.org/fhir/substance-weight-method#Viscosity", Viscosity }, 
    };
  };
}
