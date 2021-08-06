// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes defining the purpose of a Questionnaire item of type 'display'.
  /// </summary>
  public static class QuestionnaireDisplayCategoryCodes
  {
    /// <summary>
    /// The display text provides guidance on how to populate or use a portion of the questionnaire (or the questionnaire as a whole).
    /// </summary>
    public static readonly Coding Instructions = new Coding
    {
      Code = "instructions",
      Display = "Instructions",
      System = "http://hl7.org/fhir/questionnaire-display-category"
    };
    /// <summary>
    /// The display text indicates copyright, trademark, patent, regulations regarding completion, retention or use, or other legal text related to the item
    /// </summary>
    public static readonly Coding Legal = new Coding
    {
      Code = "legal",
      Display = "legal",
      System = "http://hl7.org/fhir/questionnaire-display-category"
    };
    /// <summary>
    /// The display text provides guidance on how the information should be or will be handled from a security/confidentiality/access control perspective when completed
    /// </summary>
    public static readonly Coding Security = new Coding
    {
      Code = "security",
      Display = "Security",
      System = "http://hl7.org/fhir/questionnaire-display-category"
    };

    /// <summary>
    /// Literal for code: Instructions
    /// </summary>
    public const string LiteralInstructions = "instructions";

    /// <summary>
    /// Literal for code: Legal
    /// </summary>
    public const string LiteralLegal = "legal";

    /// <summary>
    /// Literal for code: Security
    /// </summary>
    public const string LiteralSecurity = "security";
  };
}