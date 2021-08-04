// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes the four Consent scope codes.
  /// </summary>
  public static class ConsentScopeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrivacyConsent = new Coding
    {
      Code = "patient-privacy",
      Display = "Privacy Consent",
      System = "http://terminology.hl7.org/CodeSystem/consentscope"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Research = new Coding
    {
      Code = "research",
      Display = "Research",
      System = "http://terminology.hl7.org/CodeSystem/consentscope"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Treatment = new Coding
    {
      Code = "treatment",
      Display = "Treatment",
      System = "http://terminology.hl7.org/CodeSystem/consentscope"
    };

    /// <summary>
    /// Literal for code: PrivacyConsent
    /// </summary>
    public const string LiteralPrivacyConsent = "patient-privacy";

    /// <summary>
    /// Literal for code: Research
    /// </summary>
    public const string LiteralResearch = "research";

    /// <summary>
    /// Literal for code: Treatment
    /// </summary>
    public const string LiteralTreatment = "treatment";
  };
}
