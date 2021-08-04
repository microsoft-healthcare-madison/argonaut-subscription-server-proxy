// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Identification of the underlying physiological mechanism for a Reaction Risk.
  /// </summary>
  public static class AllergyIntoleranceTypeCodes
  {
    /// <summary>
    /// A propensity for hypersensitive reaction(s) to a substance.  These reactions are most typically type I hypersensitivity, plus other "allergy-like" reactions, including pseudoallergy.
    /// </summary>
    public static readonly Coding Allergy = new Coding
    {
      Code = "allergy",
      Display = "Allergy",
      System = "http://hl7.org/fhir/allergy-intolerance-type"
    };
    /// <summary>
    /// A propensity for adverse reactions to a substance that is not judged to be allergic or "allergy-like".  These reactions are typically (but not necessarily) non-immune.  They are to some degree idiosyncratic and/or patient-specific (i.e. are not a reaction that is expected to occur with most or all patients given similar circumstances).
    /// </summary>
    public static readonly Coding Intolerance = new Coding
    {
      Code = "intolerance",
      Display = "Intolerance",
      System = "http://hl7.org/fhir/allergy-intolerance-type"
    };

    /// <summary>
    /// Literal for code: Allergy
    /// </summary>
    public const string LiteralAllergy = "allergy";

    /// <summary>
    /// Literal for code: Intolerance
    /// </summary>
    public const string LiteralIntolerance = "intolerance";
  };
}
