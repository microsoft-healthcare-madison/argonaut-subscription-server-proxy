// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The aspect of quality, confidence, or certainty.
  /// </summary>
  public static class CertaintyTypeCodes
  {
    /// <summary>
    /// higher certainty due to dose response relationship.
    /// </summary>
    public static readonly Coding DoseResponseGradient = new Coding
    {
      Code = "DoseResponseGradient",
      Display = "Dose response gradient",
      System = "http://terminology.hl7.org/CodeSystem/certainty-type"
    };
    /// <summary>
    /// fuzzy or wide variability.
    /// </summary>
    public static readonly Coding Imprecision = new Coding
    {
      Code = "Imprecision",
      Display = "Imprecision",
      System = "http://terminology.hl7.org/CodeSystem/certainty-type"
    };
    /// <summary>
    /// concerns that findings are not similar enough to support certainty.
    /// </summary>
    public static readonly Coding Inconsistency = new Coding
    {
      Code = "Inconsistency",
      Display = "Inconsistency",
      System = "http://terminology.hl7.org/CodeSystem/certainty-type"
    };
    /// <summary>
    /// concerns reducing external validity.
    /// </summary>
    public static readonly Coding Indirectness = new Coding
    {
      Code = "Indirectness",
      Display = "Indirectness",
      System = "http://terminology.hl7.org/CodeSystem/certainty-type"
    };
    /// <summary>
    /// higher certainty due to large effect size.
    /// </summary>
    public static readonly Coding LargeEffect = new Coding
    {
      Code = "LargeEffect",
      Display = "Large effect",
      System = "http://terminology.hl7.org/CodeSystem/certainty-type"
    };
    /// <summary>
    /// Overall certainty of evidence (quality of evidence).
    /// </summary>
    public static readonly Coding OverallCertainty = new Coding
    {
      Code = "Overall",
      Display = "Overall certainty",
      System = "http://terminology.hl7.org/CodeSystem/certainty-type"
    };
    /// <summary>
    /// higher certainty due to risk of bias in opposite direction.
    /// </summary>
    public static readonly Coding PlausibleConfounding = new Coding
    {
      Code = "PlausibleConfounding",
      Display = "Plausible confounding",
      System = "http://terminology.hl7.org/CodeSystem/certainty-type"
    };
    /// <summary>
    /// likelihood that what is published misrepresents what is available to publish.
    /// </summary>
    public static readonly Coding PublicationBias = new Coding
    {
      Code = "PublicationBias",
      Display = "Publication bias",
      System = "http://terminology.hl7.org/CodeSystem/certainty-type"
    };
    /// <summary>
    /// methodologic concerns reducing internal validity.
    /// </summary>
    public static readonly Coding RiskOfBias = new Coding
    {
      Code = "RiskOfBias",
      Display = "Risk of bias",
      System = "http://terminology.hl7.org/CodeSystem/certainty-type"
    };

    /// <summary>
    /// Literal for code: DoseResponseGradient
    /// </summary>
    public const string LiteralDoseResponseGradient = "DoseResponseGradient";

    /// <summary>
    /// Literal for code: CertaintyTypeDoseResponseGradient
    /// </summary>
    public const string LiteralCertaintyTypeDoseResponseGradient = "http://terminology.hl7.org/CodeSystem/certainty-type#DoseResponseGradient";

    /// <summary>
    /// Literal for code: Imprecision
    /// </summary>
    public const string LiteralImprecision = "Imprecision";

    /// <summary>
    /// Literal for code: CertaintyTypeImprecision
    /// </summary>
    public const string LiteralCertaintyTypeImprecision = "http://terminology.hl7.org/CodeSystem/certainty-type#Imprecision";

    /// <summary>
    /// Literal for code: Inconsistency
    /// </summary>
    public const string LiteralInconsistency = "Inconsistency";

    /// <summary>
    /// Literal for code: CertaintyTypeInconsistency
    /// </summary>
    public const string LiteralCertaintyTypeInconsistency = "http://terminology.hl7.org/CodeSystem/certainty-type#Inconsistency";

    /// <summary>
    /// Literal for code: Indirectness
    /// </summary>
    public const string LiteralIndirectness = "Indirectness";

    /// <summary>
    /// Literal for code: CertaintyTypeIndirectness
    /// </summary>
    public const string LiteralCertaintyTypeIndirectness = "http://terminology.hl7.org/CodeSystem/certainty-type#Indirectness";

    /// <summary>
    /// Literal for code: LargeEffect
    /// </summary>
    public const string LiteralLargeEffect = "LargeEffect";

    /// <summary>
    /// Literal for code: CertaintyTypeLargeEffect
    /// </summary>
    public const string LiteralCertaintyTypeLargeEffect = "http://terminology.hl7.org/CodeSystem/certainty-type#LargeEffect";

    /// <summary>
    /// Literal for code: OverallCertainty
    /// </summary>
    public const string LiteralOverallCertainty = "Overall";

    /// <summary>
    /// Literal for code: CertaintyTypeOverallCertainty
    /// </summary>
    public const string LiteralCertaintyTypeOverallCertainty = "http://terminology.hl7.org/CodeSystem/certainty-type#Overall";

    /// <summary>
    /// Literal for code: PlausibleConfounding
    /// </summary>
    public const string LiteralPlausibleConfounding = "PlausibleConfounding";

    /// <summary>
    /// Literal for code: CertaintyTypePlausibleConfounding
    /// </summary>
    public const string LiteralCertaintyTypePlausibleConfounding = "http://terminology.hl7.org/CodeSystem/certainty-type#PlausibleConfounding";

    /// <summary>
    /// Literal for code: PublicationBias
    /// </summary>
    public const string LiteralPublicationBias = "PublicationBias";

    /// <summary>
    /// Literal for code: CertaintyTypePublicationBias
    /// </summary>
    public const string LiteralCertaintyTypePublicationBias = "http://terminology.hl7.org/CodeSystem/certainty-type#PublicationBias";

    /// <summary>
    /// Literal for code: RiskOfBias
    /// </summary>
    public const string LiteralRiskOfBias = "RiskOfBias";

    /// <summary>
    /// Literal for code: CertaintyTypeRiskOfBias
    /// </summary>
    public const string LiteralCertaintyTypeRiskOfBias = "http://terminology.hl7.org/CodeSystem/certainty-type#RiskOfBias";

    /// <summary>
    /// Dictionary for looking up CertaintyType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "DoseResponseGradient", DoseResponseGradient }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-type#DoseResponseGradient", DoseResponseGradient }, 
      { "Imprecision", Imprecision }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-type#Imprecision", Imprecision }, 
      { "Inconsistency", Inconsistency }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-type#Inconsistency", Inconsistency }, 
      { "Indirectness", Indirectness }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-type#Indirectness", Indirectness }, 
      { "LargeEffect", LargeEffect }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-type#LargeEffect", LargeEffect }, 
      { "Overall", OverallCertainty }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-type#Overall", OverallCertainty }, 
      { "PlausibleConfounding", PlausibleConfounding }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-type#PlausibleConfounding", PlausibleConfounding }, 
      { "PublicationBias", PublicationBias }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-type#PublicationBias", PublicationBias }, 
      { "RiskOfBias", RiskOfBias }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-type#RiskOfBias", RiskOfBias }, 
    };
  };
}