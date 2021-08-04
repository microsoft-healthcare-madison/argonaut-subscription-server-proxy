// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set defines the set of codes for describing the type or mode of the patient's preferred language.
  /// </summary>
  public static class LanguagePreferenceTypeCodes
  {
    /// <summary>
    /// The patient prefers to verbally communicate with the associated language.
    /// </summary>
    public static readonly Coding Verbal = new Coding
    {
      Code = "verbal",
      Display = "verbal",
      System = "http://hl7.org/fhir/language-preference-type"
    };
    /// <summary>
    /// The patient prefers to communicate in writing with the associated language.
    /// </summary>
    public static readonly Coding Written = new Coding
    {
      Code = "written",
      Display = "written",
      System = "http://hl7.org/fhir/language-preference-type"
    };

    /// <summary>
    /// Literal for code: Verbal
    /// </summary>
    public const string LiteralVerbal = "verbal";

    /// <summary>
    /// Literal for code: Written
    /// </summary>
    public const string LiteralWritten = "written";
  };
}
