// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The way in which this manufacturer is associated with the ingredient. For example whether it is a possible one (others allowed), or an exclusive authorized one for this ingredient. Note that this is not the manufacturing process role.
  /// </summary>
  public static class IngredientManufacturerRoleCodes
  {
    /// <summary>
    /// Manufacturer actually makes this particular ingredient
    /// </summary>
    public static readonly Coding ManufacturerActuallyMakesThisParticularIngredient = new Coding
    {
      Code = "actual",
      Display = "Manufacturer actually makes this particular ingredient",
      System = "http://hl7.org/fhir/ingredient-manufacturer-role"
    };
    /// <summary>
    /// Manufacturer is specifically allowed for this ingredient
    /// </summary>
    public static readonly Coding ManufacturerIsSpecificallyAllowedForThisIngredient = new Coding
    {
      Code = "allowed",
      Display = "Manufacturer is specifically allowed for this ingredient",
      System = "http://hl7.org/fhir/ingredient-manufacturer-role"
    };
    /// <summary>
    /// Manufacturer is known to make this ingredient in general
    /// </summary>
    public static readonly Coding ManufacturerIsKnownToMakeThisIngredientInGeneral = new Coding
    {
      Code = "possible",
      Display = "Manufacturer is known to make this ingredient in general",
      System = "http://hl7.org/fhir/ingredient-manufacturer-role"
    };

    /// <summary>
    /// Literal for code: ManufacturerActuallyMakesThisParticularIngredient
    /// </summary>
    public const string LiteralManufacturerActuallyMakesThisParticularIngredient = "actual";

    /// <summary>
    /// Literal for code: IngredientManufacturerRoleManufacturerActuallyMakesThisParticularIngredient
    /// </summary>
    public const string LiteralIngredientManufacturerRoleManufacturerActuallyMakesThisParticularIngredient = "http://hl7.org/fhir/ingredient-manufacturer-role#actual";

    /// <summary>
    /// Literal for code: ManufacturerIsSpecificallyAllowedForThisIngredient
    /// </summary>
    public const string LiteralManufacturerIsSpecificallyAllowedForThisIngredient = "allowed";

    /// <summary>
    /// Literal for code: IngredientManufacturerRoleManufacturerIsSpecificallyAllowedForThisIngredient
    /// </summary>
    public const string LiteralIngredientManufacturerRoleManufacturerIsSpecificallyAllowedForThisIngredient = "http://hl7.org/fhir/ingredient-manufacturer-role#allowed";

    /// <summary>
    /// Literal for code: ManufacturerIsKnownToMakeThisIngredientInGeneral
    /// </summary>
    public const string LiteralManufacturerIsKnownToMakeThisIngredientInGeneral = "possible";

    /// <summary>
    /// Literal for code: IngredientManufacturerRoleManufacturerIsKnownToMakeThisIngredientInGeneral
    /// </summary>
    public const string LiteralIngredientManufacturerRoleManufacturerIsKnownToMakeThisIngredientInGeneral = "http://hl7.org/fhir/ingredient-manufacturer-role#possible";

    /// <summary>
    /// Dictionary for looking up IngredientManufacturerRole Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "actual", ManufacturerActuallyMakesThisParticularIngredient }, 
      { "http://hl7.org/fhir/ingredient-manufacturer-role#actual", ManufacturerActuallyMakesThisParticularIngredient }, 
      { "allowed", ManufacturerIsSpecificallyAllowedForThisIngredient }, 
      { "http://hl7.org/fhir/ingredient-manufacturer-role#allowed", ManufacturerIsSpecificallyAllowedForThisIngredient }, 
      { "possible", ManufacturerIsKnownToMakeThisIngredientInGeneral }, 
      { "http://hl7.org/fhir/ingredient-manufacturer-role#possible", ManufacturerIsKnownToMakeThisIngredientInGeneral }, 
    };
  };
}
