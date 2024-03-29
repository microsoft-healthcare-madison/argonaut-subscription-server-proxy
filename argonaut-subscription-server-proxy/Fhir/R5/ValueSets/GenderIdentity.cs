// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This example value set defines a set of codes that can be used to indicate a patient's gender identity.
  /// </summary>
  public static class GenderIdentityCodes
  {
    /// <summary>
    /// the patient identifies as female
    /// </summary>
    public static readonly Coding Female = new Coding
    {
      Code = "female",
      Display = "female",
      System = "http://hl7.org/fhir/gender-identity"
    };
    /// <summary>
    /// the patient identifies as male
    /// </summary>
    public static readonly Coding Male = new Coding
    {
      Code = "male",
      Display = "male",
      System = "http://hl7.org/fhir/gender-identity"
    };
    /// <summary>
    /// the patient identifies with neither/both female and male
    /// </summary>
    public static readonly Coding NonBinary = new Coding
    {
      Code = "non-binary",
      Display = "non-binary",
      System = "http://hl7.org/fhir/gender-identity"
    };
    /// <summary>
    /// the patient does not wish to disclose his gender identity
    /// </summary>
    public static readonly Coding DoesNotWishToDisclose = new Coding
    {
      Code = "non-disclose",
      Display = "does not wish to disclose",
      System = "http://hl7.org/fhir/gender-identity"
    };
    /// <summary>
    /// other gender identity
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "other",
      System = "http://hl7.org/fhir/gender-identity"
    };
    /// <summary>
    /// the patient identifies as transgender male-to-female
    /// </summary>
    public static readonly Coding TransgenderFemale = new Coding
    {
      Code = "transgender-female",
      Display = "transgender female",
      System = "http://hl7.org/fhir/gender-identity"
    };
    /// <summary>
    /// the patient identifies as transgender female-to-male
    /// </summary>
    public static readonly Coding TransgenderMale = new Coding
    {
      Code = "transgender-male",
      Display = "transgender male",
      System = "http://hl7.org/fhir/gender-identity"
    };

    /// <summary>
    /// Literal for code: Female
    /// </summary>
    public const string LiteralFemale = "female";

    /// <summary>
    /// Literal for code: Male
    /// </summary>
    public const string LiteralMale = "male";

    /// <summary>
    /// Literal for code: NonBinary
    /// </summary>
    public const string LiteralNonBinary = "non-binary";

    /// <summary>
    /// Literal for code: DoesNotWishToDisclose
    /// </summary>
    public const string LiteralDoesNotWishToDisclose = "non-disclose";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: TransgenderFemale
    /// </summary>
    public const string LiteralTransgenderFemale = "transgender-female";

    /// <summary>
    /// Literal for code: TransgenderMale
    /// </summary>
    public const string LiteralTransgenderMale = "transgender-male";
  };
}
