// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The optical rotation type of a substance.
  /// </summary>
  public static class SubstanceStereochemistryCodes
  {
    /// <summary>
    /// constitutional isomer
    /// </summary>
    public static readonly Coding ConstitutionalIsomer = new Coding
    {
      Code = "ConstitutionalIsomer",
      Display = "constitutional isomer",
      System = "http://hl7.org/fhir/substance-stereochemistry"
    };
    /// <summary>
    /// enantiomer
    /// </summary>
    public static readonly Coding Enantiomer = new Coding
    {
      Code = "Enantiomer",
      Display = "enantiomer",
      System = "http://hl7.org/fhir/substance-stereochemistry"
    };
    /// <summary>
    /// stereoisomer
    /// </summary>
    public static readonly Coding Stereoisomer = new Coding
    {
      Code = "Stereoisomer",
      Display = "stereoisomer",
      System = "http://hl7.org/fhir/substance-stereochemistry"
    };

    /// <summary>
    /// Literal for code: ConstitutionalIsomer
    /// </summary>
    public const string LiteralConstitutionalIsomer = "ConstitutionalIsomer";

    /// <summary>
    /// Literal for code: SubstanceStereochemistryConstitutionalIsomer
    /// </summary>
    public const string LiteralSubstanceStereochemistryConstitutionalIsomer = "http://hl7.org/fhir/substance-stereochemistry#ConstitutionalIsomer";

    /// <summary>
    /// Literal for code: Enantiomer
    /// </summary>
    public const string LiteralEnantiomer = "Enantiomer";

    /// <summary>
    /// Literal for code: SubstanceStereochemistryEnantiomer
    /// </summary>
    public const string LiteralSubstanceStereochemistryEnantiomer = "http://hl7.org/fhir/substance-stereochemistry#Enantiomer";

    /// <summary>
    /// Literal for code: Stereoisomer
    /// </summary>
    public const string LiteralStereoisomer = "Stereoisomer";

    /// <summary>
    /// Literal for code: SubstanceStereochemistryStereoisomer
    /// </summary>
    public const string LiteralSubstanceStereochemistryStereoisomer = "http://hl7.org/fhir/substance-stereochemistry#Stereoisomer";

    /// <summary>
    /// Dictionary for looking up SubstanceStereochemistry Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "ConstitutionalIsomer", ConstitutionalIsomer }, 
      { "http://hl7.org/fhir/substance-stereochemistry#ConstitutionalIsomer", ConstitutionalIsomer }, 
      { "Enantiomer", Enantiomer }, 
      { "http://hl7.org/fhir/substance-stereochemistry#Enantiomer", Enantiomer }, 
      { "Stereoisomer", Stereoisomer }, 
      { "http://hl7.org/fhir/substance-stereochemistry#Stereoisomer", Stereoisomer }, 
    };
  };
}
