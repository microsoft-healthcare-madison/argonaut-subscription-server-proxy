// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The quality of how direct the match is.
  /// </summary>
  public static class DirectnessCodes
  {
    /// <summary>
    /// Exact matching quality between observed and intended variable, so no concern for indirectness in evidence interpretation.
    /// </summary>
    public static readonly Coding ExactMatchBetweenObservedAndIntendedVariable = new Coding
    {
      Code = "exact",
      Display = "Exact match between observed and intended variable",
      System = "http://terminology.hl7.org/CodeSystem/directness"
    };
    /// <summary>
    /// High matching quality between observed and intended variable, so little concern for indirectness in evidence interpretation.
    /// </summary>
    public static readonly Coding HighQualityMatchBetweenObservedAndIntendedVariable = new Coding
    {
      Code = "high",
      Display = "High quality match between observed and intended variable",
      System = "http://terminology.hl7.org/CodeSystem/directness"
    };
    /// <summary>
    /// Low matching quality between observed and intended variable, so very serious concern for indirectness in evidence interpretation.
    /// </summary>
    public static readonly Coding LowQualityMatchBetweenObservedAndIntendedVariable = new Coding
    {
      Code = "low",
      Display = "Low quality match between observed and intended variable",
      System = "http://terminology.hl7.org/CodeSystem/directness"
    };
    /// <summary>
    /// Moderate matching quality between observed and intended variable, so serious concern for indirectness in evidence interpretation.
    /// </summary>
    public static readonly Coding ModerateQualityMatchBetweenObservedAndIntendedVariable = new Coding
    {
      Code = "moderate",
      Display = "Moderate quality match between observed and intended variable",
      System = "http://terminology.hl7.org/CodeSystem/directness"
    };

    /// <summary>
    /// Literal for code: ExactMatchBetweenObservedAndIntendedVariable
    /// </summary>
    public const string LiteralExactMatchBetweenObservedAndIntendedVariable = "exact";

    /// <summary>
    /// Literal for code: DirectnessExactMatchBetweenObservedAndIntendedVariable
    /// </summary>
    public const string LiteralDirectnessExactMatchBetweenObservedAndIntendedVariable = "http://terminology.hl7.org/CodeSystem/directness#exact";

    /// <summary>
    /// Literal for code: HighQualityMatchBetweenObservedAndIntendedVariable
    /// </summary>
    public const string LiteralHighQualityMatchBetweenObservedAndIntendedVariable = "high";

    /// <summary>
    /// Literal for code: DirectnessHighQualityMatchBetweenObservedAndIntendedVariable
    /// </summary>
    public const string LiteralDirectnessHighQualityMatchBetweenObservedAndIntendedVariable = "http://terminology.hl7.org/CodeSystem/directness#high";

    /// <summary>
    /// Literal for code: LowQualityMatchBetweenObservedAndIntendedVariable
    /// </summary>
    public const string LiteralLowQualityMatchBetweenObservedAndIntendedVariable = "low";

    /// <summary>
    /// Literal for code: DirectnessLowQualityMatchBetweenObservedAndIntendedVariable
    /// </summary>
    public const string LiteralDirectnessLowQualityMatchBetweenObservedAndIntendedVariable = "http://terminology.hl7.org/CodeSystem/directness#low";

    /// <summary>
    /// Literal for code: ModerateQualityMatchBetweenObservedAndIntendedVariable
    /// </summary>
    public const string LiteralModerateQualityMatchBetweenObservedAndIntendedVariable = "moderate";

    /// <summary>
    /// Literal for code: DirectnessModerateQualityMatchBetweenObservedAndIntendedVariable
    /// </summary>
    public const string LiteralDirectnessModerateQualityMatchBetweenObservedAndIntendedVariable = "http://terminology.hl7.org/CodeSystem/directness#moderate";

    /// <summary>
    /// Dictionary for looking up Directness Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "exact", ExactMatchBetweenObservedAndIntendedVariable }, 
      { "http://terminology.hl7.org/CodeSystem/directness#exact", ExactMatchBetweenObservedAndIntendedVariable }, 
      { "high", HighQualityMatchBetweenObservedAndIntendedVariable }, 
      { "http://terminology.hl7.org/CodeSystem/directness#high", HighQualityMatchBetweenObservedAndIntendedVariable }, 
      { "low", LowQualityMatchBetweenObservedAndIntendedVariable }, 
      { "http://terminology.hl7.org/CodeSystem/directness#low", LowQualityMatchBetweenObservedAndIntendedVariable }, 
      { "moderate", ModerateQualityMatchBetweenObservedAndIntendedVariable }, 
      { "http://terminology.hl7.org/CodeSystem/directness#moderate", ModerateQualityMatchBetweenObservedAndIntendedVariable }, 
    };
  };
}
