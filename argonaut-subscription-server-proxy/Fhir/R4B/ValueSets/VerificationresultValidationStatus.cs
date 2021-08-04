// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Status of the validation of the target against the primary source
  /// </summary>
  public static class VerificationresultValidationStatusCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Failed = new Coding
    {
      Code = "failed",
      Display = "Failed",
      System = "http://terminology.hl7.org/CodeSystem/validation-status"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Successful = new Coding
    {
      Code = "successful",
      Display = "Successful",
      System = "http://terminology.hl7.org/CodeSystem/validation-status"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://terminology.hl7.org/CodeSystem/validation-status"
    };

    /// <summary>
    /// Literal for code: Failed
    /// </summary>
    public const string LiteralFailed = "failed";

    /// <summary>
    /// Literal for code: Successful
    /// </summary>
    public const string LiteralSuccessful = "successful";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";
  };
}
