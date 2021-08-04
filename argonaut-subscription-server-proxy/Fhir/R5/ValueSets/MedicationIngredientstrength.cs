// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Medication Ingredient Strength Codes
  /// </summary>
  public static class MedicationIngredientstrengthCodes
  {
    /// <summary>
    /// As much as is sufficient.
    /// </summary>
    public static readonly Coding QS = new Coding
    {
      Code = "qs",
      Display = "QS",
      System = "http://hl7.org/fhir/CodeSystem/medication-ingredientstrength"
    };
    /// <summary>
    /// Very small amount.
    /// </summary>
    public static readonly Coding Trace = new Coding
    {
      Code = "trace",
      Display = "Trace",
      System = "http://hl7.org/fhir/CodeSystem/medication-ingredientstrength"
    };

    /// <summary>
    /// Literal for code: QS
    /// </summary>
    public const string LiteralQS = "qs";

    /// <summary>
    /// Literal for code: Trace
    /// </summary>
    public const string LiteralTrace = "trace";
  };
}
