// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the function a practitioner or organization may play in the immunization event. This value set is provided as a suggestive example.
  /// </summary>
  public static class ImmunizationFunctionCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AP = new Coding
    {
      Code = "AP",
      System = "http://terminology.hl7.org/CodeSystem/v2-0443"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OP = new Coding
    {
      Code = "OP",
      System = "http://terminology.hl7.org/CodeSystem/v2-0443"
    };

    /// <summary>
    /// Literal for code: AP
    /// </summary>
    public const string LiteralAP = "AP";

    /// <summary>
    /// Literal for code: OP
    /// </summary>
    public const string LiteralOP = "OP";
  };
}