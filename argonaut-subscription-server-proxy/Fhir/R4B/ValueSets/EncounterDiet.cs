// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set defines a set of codes that can be used to indicate dietary preferences or restrictions a patient may have.
  /// </summary>
  public static class EncounterDietCodes
  {
    /// <summary>
    /// Excludes dairy products.
    /// </summary>
    public static readonly Coding DairyFree = new Coding
    {
      Code = "dairy-free",
      Display = "Dairy Free",
      System = "http://terminology.hl7.org/CodeSystem/diet"
    };
    /// <summary>
    /// Excludes ingredients containing gluten.
    /// </summary>
    public static readonly Coding GlutenFree = new Coding
    {
      Code = "gluten-free",
      Display = "Gluten Free",
      System = "http://terminology.hl7.org/CodeSystem/diet"
    };
    /// <summary>
    /// Foods that conform to Islamic law.
    /// </summary>
    public static readonly Coding Halal = new Coding
    {
      Code = "halal",
      Display = "Halal",
      System = "http://terminology.hl7.org/CodeSystem/diet"
    };
    /// <summary>
    /// Foods that conform to Jewish dietary law.
    /// </summary>
    public static readonly Coding Kosher = new Coding
    {
      Code = "kosher",
      Display = "Kosher",
      System = "http://terminology.hl7.org/CodeSystem/diet"
    };
    /// <summary>
    /// Excludes ingredients containing nuts.
    /// </summary>
    public static readonly Coding NutFree = new Coding
    {
      Code = "nut-free",
      Display = "Nut Free",
      System = "http://terminology.hl7.org/CodeSystem/diet"
    };
    /// <summary>
    /// Food without meat, poultry, seafood, eggs, dairy products and other animal-derived substances.
    /// </summary>
    public static readonly Coding Vegan = new Coding
    {
      Code = "vegan",
      Display = "Vegan",
      System = "http://terminology.hl7.org/CodeSystem/diet"
    };
    /// <summary>
    /// Food without meat, poultry or seafood.
    /// </summary>
    public static readonly Coding Vegetarian = new Coding
    {
      Code = "vegetarian",
      Display = "Vegetarian",
      System = "http://terminology.hl7.org/CodeSystem/diet"
    };

    /// <summary>
    /// Literal for code: DairyFree
    /// </summary>
    public const string LiteralDairyFree = "dairy-free";

    /// <summary>
    /// Literal for code: GlutenFree
    /// </summary>
    public const string LiteralGlutenFree = "gluten-free";

    /// <summary>
    /// Literal for code: Halal
    /// </summary>
    public const string LiteralHalal = "halal";

    /// <summary>
    /// Literal for code: Kosher
    /// </summary>
    public const string LiteralKosher = "kosher";

    /// <summary>
    /// Literal for code: NutFree
    /// </summary>
    public const string LiteralNutFree = "nut-free";

    /// <summary>
    /// Literal for code: Vegan
    /// </summary>
    public const string LiteralVegan = "vegan";

    /// <summary>
    /// Literal for code: Vegetarian
    /// </summary>
    public const string LiteralVegetarian = "vegetarian";
  };
}
