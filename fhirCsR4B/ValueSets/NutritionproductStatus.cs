// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Codes identifying the lifecycle stage of a product.
  /// </summary>
  public static class NutritionproductStatusCodes
  {
    /// <summary>
    /// The product can be used.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/nutritionproduct-status"
    };
    /// <summary>
    /// This electronic record should never have existed, though it is possible that real-world decisions were based on it.  (If real-world activity has occurred, the status should be "cancelled" rather than "entered-in-error".).
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/nutritionproduct-status"
    };
    /// <summary>
    /// The product is not expected or allowed to be used.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://hl7.org/fhir/nutritionproduct-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: NutritionproductStatusActive
    /// </summary>
    public const string LiteralNutritionproductStatusActive = "http://hl7.org/fhir/nutritionproduct-status#active";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: NutritionproductStatusEnteredInError
    /// </summary>
    public const string LiteralNutritionproductStatusEnteredInError = "http://hl7.org/fhir/nutritionproduct-status#entered-in-error";

    /// <summary>
    /// Literal for code: Inactive
    /// </summary>
    public const string LiteralInactive = "inactive";

    /// <summary>
    /// Literal for code: NutritionproductStatusInactive
    /// </summary>
    public const string LiteralNutritionproductStatusInactive = "http://hl7.org/fhir/nutritionproduct-status#inactive";

    /// <summary>
    /// Dictionary for looking up NutritionproductStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/nutritionproduct-status#active", Active }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/nutritionproduct-status#entered-in-error", EnteredInError }, 
      { "inactive", Inactive }, 
      { "http://hl7.org/fhir/nutritionproduct-status#inactive", Inactive }, 
    };
  };
}
