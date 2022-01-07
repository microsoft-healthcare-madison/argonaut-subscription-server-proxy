// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// A code that identifies the status of the family history record.
  /// </summary>
  public static class HistoryStatusCodes
  {
    /// <summary>
    /// All available related health information is captured as of the date (and possibly time) when the family member history was taken.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/history-status"
    };
    /// <summary>
    /// This instance should not have been part of this patient's medical record.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/history-status"
    };
    /// <summary>
    /// Health information for this family member is unavailable/unknown.
    /// </summary>
    public static readonly Coding HealthUnknown = new Coding
    {
      Code = "health-unknown",
      Display = "Health Unknown",
      System = "http://hl7.org/fhir/history-status"
    };
    /// <summary>
    /// Some health information is known and captured, but not complete - see notes for details.
    /// </summary>
    public static readonly Coding Partial = new Coding
    {
      Code = "partial",
      Display = "Partial",
      System = "http://hl7.org/fhir/history-status"
    };

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: HealthUnknown
    /// </summary>
    public const string LiteralHealthUnknown = "health-unknown";

    /// <summary>
    /// Literal for code: Partial
    /// </summary>
    public const string LiteralPartial = "partial";
  };
}
