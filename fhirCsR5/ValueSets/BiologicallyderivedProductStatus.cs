// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Biologically Derived Product Status.
  /// </summary>
  public static class BiologicallyderivedProductStatusCodes
  {
    /// <summary>
    /// Product is currently available for use.
    /// </summary>
    public static readonly Coding Available = new Coding
    {
      Code = "available",
      Display = "Available",
      System = "http://hl7.org/fhir/biologicallyderived-product-status"
    };
    /// <summary>
    /// Product is not currently available for use.
    /// </summary>
    public static readonly Coding Unavailable = new Coding
    {
      Code = "unavailable",
      Display = "Unavailable",
      System = "http://hl7.org/fhir/biologicallyderived-product-status"
    };

    /// <summary>
    /// Literal for code: Available
    /// </summary>
    public const string LiteralAvailable = "available";

    /// <summary>
    /// Literal for code: BiologicallyderivedProductStatusAvailable
    /// </summary>
    public const string LiteralBiologicallyderivedProductStatusAvailable = "http://hl7.org/fhir/biologicallyderived-product-status#available";

    /// <summary>
    /// Literal for code: Unavailable
    /// </summary>
    public const string LiteralUnavailable = "unavailable";

    /// <summary>
    /// Literal for code: BiologicallyderivedProductStatusUnavailable
    /// </summary>
    public const string LiteralBiologicallyderivedProductStatusUnavailable = "http://hl7.org/fhir/biologicallyderived-product-status#unavailable";

    /// <summary>
    /// Dictionary for looking up BiologicallyderivedProductStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "available", Available }, 
      { "http://hl7.org/fhir/biologicallyderived-product-status#available", Available }, 
      { "unavailable", Unavailable }, 
      { "http://hl7.org/fhir/biologicallyderived-product-status#unavailable", Unavailable }, 
    };
  };
}
