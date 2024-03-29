// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The validation status of the target
  /// </summary>
  public static class VerificationresultStatusCodes
  {
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding Attested = new Coding
    {
      Code = "attested",
      Display = "Attested",
      System = "http://hl7.org/fhir/CodeSystem/verificationresult-status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding InProcess = new Coding
    {
      Code = "in-process",
      Display = "In process",
      System = "http://hl7.org/fhir/CodeSystem/verificationresult-status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding RequiresRevalidation = new Coding
    {
      Code = "req-revalid",
      Display = "Requires revalidation",
      System = "http://hl7.org/fhir/CodeSystem/verificationresult-status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding ReValidationFailed = new Coding
    {
      Code = "reval-fail",
      Display = "Re-Validation failed",
      System = "http://hl7.org/fhir/CodeSystem/verificationresult-status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding ValidationFailed = new Coding
    {
      Code = "val-fail",
      Display = "Validation failed",
      System = "http://hl7.org/fhir/CodeSystem/verificationresult-status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding Validated = new Coding
    {
      Code = "validated",
      Display = "Validated",
      System = "http://hl7.org/fhir/CodeSystem/verificationresult-status"
    };

    /// <summary>
    /// Literal for code: Attested
    /// </summary>
    public const string LiteralAttested = "attested";

    /// <summary>
    /// Literal for code: InProcess
    /// </summary>
    public const string LiteralInProcess = "in-process";

    /// <summary>
    /// Literal for code: RequiresRevalidation
    /// </summary>
    public const string LiteralRequiresRevalidation = "req-revalid";

    /// <summary>
    /// Literal for code: ReValidationFailed
    /// </summary>
    public const string LiteralReValidationFailed = "reval-fail";

    /// <summary>
    /// Literal for code: ValidationFailed
    /// </summary>
    public const string LiteralValidationFailed = "val-fail";

    /// <summary>
    /// Literal for code: Validated
    /// </summary>
    public const string LiteralValidated = "validated";
  };
}
