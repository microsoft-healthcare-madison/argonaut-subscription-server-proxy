// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Category of an identified substance associated with allergies or intolerances.
  /// </summary>
  public static class AllergyIntoleranceCategoryCodes
  {
    /// <summary>
    /// A preparation that is synthesized from living organisms or their products, especially a human or animal protein, such as a hormone or antitoxin, that is used as a diagnostic, preventive, or therapeutic agent. Examples of biologic medications include: vaccines; allergenic extracts, which are used for both diagnosis and treatment (for example, allergy shots); gene therapies; cellular therapies.  There are other biologic products, such as tissues, which are not typically associated with allergies.
    /// </summary>
    public static readonly Coding Biologic = new Coding
    {
      Code = "biologic",
      Display = "Biologic",
      System = "http://hl7.org/fhir/allergy-intolerance-category"
    };
    /// <summary>
    /// Any substances that are encountered in the environment, including any substance not already classified as food, medication, or biologic.
    /// </summary>
    public static readonly Coding Environment = new Coding
    {
      Code = "environment",
      Display = "Environment",
      System = "http://hl7.org/fhir/allergy-intolerance-category"
    };
    /// <summary>
    /// Any substance consumed to provide nutritional support for the body.
    /// </summary>
    public static readonly Coding Food = new Coding
    {
      Code = "food",
      Display = "Food",
      System = "http://hl7.org/fhir/allergy-intolerance-category"
    };
    /// <summary>
    /// Substances administered to achieve a physiological effect.
    /// </summary>
    public static readonly Coding Medication = new Coding
    {
      Code = "medication",
      Display = "Medication",
      System = "http://hl7.org/fhir/allergy-intolerance-category"
    };

    /// <summary>
    /// Literal for code: Biologic
    /// </summary>
    public const string LiteralBiologic = "biologic";

    /// <summary>
    /// Literal for code: Environment
    /// </summary>
    public const string LiteralEnvironment = "environment";

    /// <summary>
    /// Literal for code: Food
    /// </summary>
    public const string LiteralFood = "food";

    /// <summary>
    /// Literal for code: Medication
    /// </summary>
    public const string LiteralMedication = "medication";
  };
}
