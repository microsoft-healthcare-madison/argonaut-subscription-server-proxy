// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// What the target is validated against
  /// </summary>
  public static class VerificationresultValidationTypeCodes
  {
    /// <summary>
    /// Multiple Sources
    /// </summary>
    public static readonly Coding MultipleSources = new Coding
    {
      Code = "multiple",
      Display = "Multiple Sources",
      System = "http://terminology.hl7.org/CodeSystem/validation-type"
    };
    /// <summary>
    /// Nothing
    /// </summary>
    public static readonly Coding Nothing = new Coding
    {
      Code = "nothing",
      Display = "Nothing",
      System = "http://terminology.hl7.org/CodeSystem/validation-type"
    };
    /// <summary>
    /// Primary Source
    /// </summary>
    public static readonly Coding PrimarySource = new Coding
    {
      Code = "primary",
      Display = "Primary Source",
      System = "http://terminology.hl7.org/CodeSystem/validation-type"
    };

    /// <summary>
    /// Literal for code: MultipleSources
    /// </summary>
    public const string LiteralMultipleSources = "multiple";

    /// <summary>
    /// Literal for code: ValidationTypeMultipleSources
    /// </summary>
    public const string LiteralValidationTypeMultipleSources = "http://terminology.hl7.org/CodeSystem/validation-type#multiple";

    /// <summary>
    /// Literal for code: Nothing
    /// </summary>
    public const string LiteralNothing = "nothing";

    /// <summary>
    /// Literal for code: ValidationTypeNothing
    /// </summary>
    public const string LiteralValidationTypeNothing = "http://terminology.hl7.org/CodeSystem/validation-type#nothing";

    /// <summary>
    /// Literal for code: PrimarySource
    /// </summary>
    public const string LiteralPrimarySource = "primary";

    /// <summary>
    /// Literal for code: ValidationTypePrimarySource
    /// </summary>
    public const string LiteralValidationTypePrimarySource = "http://terminology.hl7.org/CodeSystem/validation-type#primary";

    /// <summary>
    /// Dictionary for looking up VerificationresultValidationType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "multiple", MultipleSources }, 
      { "http://terminology.hl7.org/CodeSystem/validation-type#multiple", MultipleSources }, 
      { "nothing", Nothing }, 
      { "http://terminology.hl7.org/CodeSystem/validation-type#nothing", Nothing }, 
      { "primary", PrimarySource }, 
      { "http://terminology.hl7.org/CodeSystem/validation-type#primary", PrimarySource }, 
    };
  };
}
