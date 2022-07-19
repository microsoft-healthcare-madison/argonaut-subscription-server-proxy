// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The way in which a person authenticated a composition.
  /// </summary>
  public static class CompositionAttestationModeCodes
  {
    /// <summary>
    /// The person authenticated the content and accepted legal responsibility for its content.
    /// </summary>
    public static readonly Coding Legal = new Coding
    {
      Code = "legal",
      Display = "Legal",
      System = "http://hl7.org/fhir/composition-attestation-mode"
    };
    /// <summary>
    /// The organization authenticated the content as consistent with their policies and procedures.
    /// </summary>
    public static readonly Coding Official = new Coding
    {
      Code = "official",
      Display = "Official",
      System = "http://hl7.org/fhir/composition-attestation-mode"
    };
    /// <summary>
    /// The person authenticated the content in their personal capacity.
    /// </summary>
    public static readonly Coding Personal = new Coding
    {
      Code = "personal",
      Display = "Personal",
      System = "http://hl7.org/fhir/composition-attestation-mode"
    };
    /// <summary>
    /// The person authenticated the content in their professional capacity.
    /// </summary>
    public static readonly Coding Professional = new Coding
    {
      Code = "professional",
      Display = "Professional",
      System = "http://hl7.org/fhir/composition-attestation-mode"
    };

    /// <summary>
    /// Literal for code: Legal
    /// </summary>
    public const string LiteralLegal = "legal";

    /// <summary>
    /// Literal for code: CompositionAttestationModeLegal
    /// </summary>
    public const string LiteralCompositionAttestationModeLegal = "http://hl7.org/fhir/composition-attestation-mode#legal";

    /// <summary>
    /// Literal for code: Official
    /// </summary>
    public const string LiteralOfficial = "official";

    /// <summary>
    /// Literal for code: CompositionAttestationModeOfficial
    /// </summary>
    public const string LiteralCompositionAttestationModeOfficial = "http://hl7.org/fhir/composition-attestation-mode#official";

    /// <summary>
    /// Literal for code: Personal
    /// </summary>
    public const string LiteralPersonal = "personal";

    /// <summary>
    /// Literal for code: CompositionAttestationModePersonal
    /// </summary>
    public const string LiteralCompositionAttestationModePersonal = "http://hl7.org/fhir/composition-attestation-mode#personal";

    /// <summary>
    /// Literal for code: Professional
    /// </summary>
    public const string LiteralProfessional = "professional";

    /// <summary>
    /// Literal for code: CompositionAttestationModeProfessional
    /// </summary>
    public const string LiteralCompositionAttestationModeProfessional = "http://hl7.org/fhir/composition-attestation-mode#professional";

    /// <summary>
    /// Dictionary for looking up CompositionAttestationMode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "legal", Legal }, 
      { "http://hl7.org/fhir/composition-attestation-mode#legal", Legal }, 
      { "official", Official }, 
      { "http://hl7.org/fhir/composition-attestation-mode#official", Official }, 
      { "personal", Personal }, 
      { "http://hl7.org/fhir/composition-attestation-mode#personal", Personal }, 
      { "professional", Professional }, 
      { "http://hl7.org/fhir/composition-attestation-mode#professional", Professional }, 
    };
  };
}
