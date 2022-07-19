// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of substance weight measurement.
  /// </summary>
  public static class SubstanceWeightTypeCodes
  {
    /// <summary>
    /// number average
    /// </summary>
    public static readonly Coding NumberAverage = new Coding
    {
      Code = "Average",
      Display = "number average",
      System = "http://hl7.org/fhir/substance-weight-type"
    };
    /// <summary>
    /// exact
    /// </summary>
    public static readonly Coding Exact = new Coding
    {
      Code = "Exact",
      Display = "exact",
      System = "http://hl7.org/fhir/substance-weight-type"
    };
    /// <summary>
    /// weight average
    /// </summary>
    public static readonly Coding WeightAverage = new Coding
    {
      Code = "WeightAverage",
      Display = "weight average",
      System = "http://hl7.org/fhir/substance-weight-type"
    };

    /// <summary>
    /// Literal for code: NumberAverage
    /// </summary>
    public const string LiteralNumberAverage = "Average";

    /// <summary>
    /// Literal for code: SubstanceWeightTypeNumberAverage
    /// </summary>
    public const string LiteralSubstanceWeightTypeNumberAverage = "http://hl7.org/fhir/substance-weight-type#Average";

    /// <summary>
    /// Literal for code: Exact
    /// </summary>
    public const string LiteralExact = "Exact";

    /// <summary>
    /// Literal for code: SubstanceWeightTypeExact
    /// </summary>
    public const string LiteralSubstanceWeightTypeExact = "http://hl7.org/fhir/substance-weight-type#Exact";

    /// <summary>
    /// Literal for code: WeightAverage
    /// </summary>
    public const string LiteralWeightAverage = "WeightAverage";

    /// <summary>
    /// Literal for code: SubstanceWeightTypeWeightAverage
    /// </summary>
    public const string LiteralSubstanceWeightTypeWeightAverage = "http://hl7.org/fhir/substance-weight-type#WeightAverage";

    /// <summary>
    /// Dictionary for looking up SubstanceWeightType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "Average", NumberAverage }, 
      { "http://hl7.org/fhir/substance-weight-type#Average", NumberAverage }, 
      { "Exact", Exact }, 
      { "http://hl7.org/fhir/substance-weight-type#Exact", Exact }, 
      { "WeightAverage", WeightAverage }, 
      { "http://hl7.org/fhir/substance-weight-type#WeightAverage", WeightAverage }, 
    };
  };
}
