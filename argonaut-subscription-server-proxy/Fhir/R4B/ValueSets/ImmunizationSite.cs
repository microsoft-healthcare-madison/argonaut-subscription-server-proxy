// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the body site where the vaccination occurred. This value set is provided as a suggestive example.
  /// </summary>
  public static class ImmunizationSiteCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding LeftArm = new Coding
    {
      Code = "LA",
      Display = "Left arm",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActSite"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding RightArm = new Coding
    {
      Code = "RA",
      Display = "Right arm",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActSite"
    };

    /// <summary>
    /// Literal for code: LeftArm
    /// </summary>
    public const string LiteralLeftArm = "LA";

    /// <summary>
    /// Literal for code: RightArm
    /// </summary>
    public const string LiteralRightArm = "RA";
  };
}
