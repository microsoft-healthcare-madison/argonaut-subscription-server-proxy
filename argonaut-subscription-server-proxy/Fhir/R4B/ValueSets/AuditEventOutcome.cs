// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Indicates whether the event succeeded or failed.
  /// </summary>
  public static class AuditEventOutcomeCodes
  {
    /// <summary>
    /// The operation completed successfully (whether with warnings or not).
    /// </summary>
    public static readonly Coding Success = new Coding
    {
      Code = "0",
      Display = "Success",
      System = "http://hl7.org/fhir/audit-event-outcome"
    };
    /// <summary>
    /// An error of such magnitude occurred that the system is no longer available for use (i.e. the system died).
    /// </summary>
    public static readonly Coding MajorFailure = new Coding
    {
      Code = "12",
      Display = "Major failure",
      System = "http://hl7.org/fhir/audit-event-outcome"
    };
    /// <summary>
    /// The action was not successful due to some kind of minor failure (often equivalent to an HTTP 400 response).
    /// </summary>
    public static readonly Coding MinorFailure = new Coding
    {
      Code = "4",
      Display = "Minor failure",
      System = "http://hl7.org/fhir/audit-event-outcome"
    };
    /// <summary>
    /// The action was not successful due to some kind of unexpected error (often equivalent to an HTTP 500 response).
    /// </summary>
    public static readonly Coding SeriousFailure = new Coding
    {
      Code = "8",
      Display = "Serious failure",
      System = "http://hl7.org/fhir/audit-event-outcome"
    };

    /// <summary>
    /// Literal for code: Success
    /// </summary>
    public const string LiteralSuccess = "0";

    /// <summary>
    /// Literal for code: MajorFailure
    /// </summary>
    public const string LiteralMajorFailure = "12";

    /// <summary>
    /// Literal for code: MinorFailure
    /// </summary>
    public const string LiteralMinorFailure = "4";

    /// <summary>
    /// Literal for code: SeriousFailure
    /// </summary>
    public const string LiteralSeriousFailure = "8";
  };
}
