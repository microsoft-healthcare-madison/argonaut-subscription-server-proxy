// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Degree of preference of a type of conditioned specimen.
  /// </summary>
  public static class SpecimenContainedPreferenceCodes
  {
    /// <summary>
    /// This type of conditioned specimen is an alternate.
    /// </summary>
    public static readonly Coding Alternate = new Coding
    {
      Code = "alternate",
      Display = "Alternate",
      System = "http://hl7.org/fhir/specimen-contained-preference"
    };
    /// <summary>
    /// This type of contained specimen is preferred to collect this kind of specimen.
    /// </summary>
    public static readonly Coding Preferred = new Coding
    {
      Code = "preferred",
      Display = "Preferred",
      System = "http://hl7.org/fhir/specimen-contained-preference"
    };

    /// <summary>
    /// Literal for code: Alternate
    /// </summary>
    public const string LiteralAlternate = "alternate";

    /// <summary>
    /// Literal for code: Preferred
    /// </summary>
    public const string LiteralPreferred = "preferred";
  };
}
