// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// A species of origin a substance raw material.
  /// </summary>
  public static class SubstanceSourceMaterialSpeciesCodes
  {
    /// <summary>
    /// Ginkgo biloba
    /// </summary>
    public static readonly Coding GinkgoBiloba = new Coding
    {
      Code = "GinkgoBiloba",
      Display = "Ginkgo biloba",
      System = "http://hl7.org/fhir/substance-source-material-species"
    };
    /// <summary>
    /// Olea europaea
    /// </summary>
    public static readonly Coding OleaEuropaea = new Coding
    {
      Code = "OleaEuropaea",
      Display = "Olea europaea",
      System = "http://hl7.org/fhir/substance-source-material-species"
    };

    /// <summary>
    /// Literal for code: GinkgoBiloba
    /// </summary>
    public const string LiteralGinkgoBiloba = "GinkgoBiloba";

    /// <summary>
    /// Literal for code: SubstanceSourceMaterialSpeciesGinkgoBiloba
    /// </summary>
    public const string LiteralSubstanceSourceMaterialSpeciesGinkgoBiloba = "http://hl7.org/fhir/substance-source-material-species#GinkgoBiloba";

    /// <summary>
    /// Literal for code: OleaEuropaea
    /// </summary>
    public const string LiteralOleaEuropaea = "OleaEuropaea";

    /// <summary>
    /// Literal for code: SubstanceSourceMaterialSpeciesOleaEuropaea
    /// </summary>
    public const string LiteralSubstanceSourceMaterialSpeciesOleaEuropaea = "http://hl7.org/fhir/substance-source-material-species#OleaEuropaea";

    /// <summary>
    /// Dictionary for looking up SubstanceSourceMaterialSpecies Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "GinkgoBiloba", GinkgoBiloba }, 
      { "http://hl7.org/fhir/substance-source-material-species#GinkgoBiloba", GinkgoBiloba }, 
      { "OleaEuropaea", OleaEuropaea }, 
      { "http://hl7.org/fhir/substance-source-material-species#OleaEuropaea", OleaEuropaea }, 
    };
  };
}
