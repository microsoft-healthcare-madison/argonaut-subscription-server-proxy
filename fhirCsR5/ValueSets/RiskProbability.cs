// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes representing the likelihood of a particular outcome in a risk assessment.
  /// </summary>
  public static class RiskProbabilityCodes
  {
    /// <summary>
    /// Certain
    /// </summary>
    public static readonly Coding Certain = new Coding
    {
      Code = "certain",
      Display = "Certain",
      System = "http://terminology.hl7.org/CodeSystem/risk-probability"
    };
    /// <summary>
    /// High likelihood
    /// </summary>
    public static readonly Coding HighLikelihood = new Coding
    {
      Code = "high",
      Display = "High likelihood",
      System = "http://terminology.hl7.org/CodeSystem/risk-probability"
    };
    /// <summary>
    /// Low likelihood
    /// </summary>
    public static readonly Coding LowLikelihood = new Coding
    {
      Code = "low",
      Display = "Low likelihood",
      System = "http://terminology.hl7.org/CodeSystem/risk-probability"
    };
    /// <summary>
    /// Moderate likelihood
    /// </summary>
    public static readonly Coding ModerateLikelihood = new Coding
    {
      Code = "moderate",
      Display = "Moderate likelihood",
      System = "http://terminology.hl7.org/CodeSystem/risk-probability"
    };
    /// <summary>
    /// Negligible likelihood
    /// </summary>
    public static readonly Coding NegligibleLikelihood = new Coding
    {
      Code = "negligible",
      Display = "Negligible likelihood",
      System = "http://terminology.hl7.org/CodeSystem/risk-probability"
    };

    /// <summary>
    /// Literal for code: Certain
    /// </summary>
    public const string LiteralCertain = "certain";

    /// <summary>
    /// Literal for code: RiskProbabilityCertain
    /// </summary>
    public const string LiteralRiskProbabilityCertain = "http://terminology.hl7.org/CodeSystem/risk-probability#certain";

    /// <summary>
    /// Literal for code: HighLikelihood
    /// </summary>
    public const string LiteralHighLikelihood = "high";

    /// <summary>
    /// Literal for code: RiskProbabilityHighLikelihood
    /// </summary>
    public const string LiteralRiskProbabilityHighLikelihood = "http://terminology.hl7.org/CodeSystem/risk-probability#high";

    /// <summary>
    /// Literal for code: LowLikelihood
    /// </summary>
    public const string LiteralLowLikelihood = "low";

    /// <summary>
    /// Literal for code: RiskProbabilityLowLikelihood
    /// </summary>
    public const string LiteralRiskProbabilityLowLikelihood = "http://terminology.hl7.org/CodeSystem/risk-probability#low";

    /// <summary>
    /// Literal for code: ModerateLikelihood
    /// </summary>
    public const string LiteralModerateLikelihood = "moderate";

    /// <summary>
    /// Literal for code: RiskProbabilityModerateLikelihood
    /// </summary>
    public const string LiteralRiskProbabilityModerateLikelihood = "http://terminology.hl7.org/CodeSystem/risk-probability#moderate";

    /// <summary>
    /// Literal for code: NegligibleLikelihood
    /// </summary>
    public const string LiteralNegligibleLikelihood = "negligible";

    /// <summary>
    /// Literal for code: RiskProbabilityNegligibleLikelihood
    /// </summary>
    public const string LiteralRiskProbabilityNegligibleLikelihood = "http://terminology.hl7.org/CodeSystem/risk-probability#negligible";

    /// <summary>
    /// Dictionary for looking up RiskProbability Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "certain", Certain }, 
      { "http://terminology.hl7.org/CodeSystem/risk-probability#certain", Certain }, 
      { "high", HighLikelihood }, 
      { "http://terminology.hl7.org/CodeSystem/risk-probability#high", HighLikelihood }, 
      { "low", LowLikelihood }, 
      { "http://terminology.hl7.org/CodeSystem/risk-probability#low", LowLikelihood }, 
      { "moderate", ModerateLikelihood }, 
      { "http://terminology.hl7.org/CodeSystem/risk-probability#moderate", ModerateLikelihood }, 
      { "negligible", NegligibleLikelihood }, 
      { "http://terminology.hl7.org/CodeSystem/risk-probability#negligible", NegligibleLikelihood }, 
    };
  };
}
