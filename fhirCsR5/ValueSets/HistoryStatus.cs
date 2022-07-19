// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
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
    /// Literal for code: HistoryStatusCompleted
    /// </summary>
    public const string LiteralHistoryStatusCompleted = "http://hl7.org/fhir/history-status#completed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: HistoryStatusEnteredInError
    /// </summary>
    public const string LiteralHistoryStatusEnteredInError = "http://hl7.org/fhir/history-status#entered-in-error";

    /// <summary>
    /// Literal for code: HealthUnknown
    /// </summary>
    public const string LiteralHealthUnknown = "health-unknown";

    /// <summary>
    /// Literal for code: HistoryStatusHealthUnknown
    /// </summary>
    public const string LiteralHistoryStatusHealthUnknown = "http://hl7.org/fhir/history-status#health-unknown";

    /// <summary>
    /// Literal for code: Partial
    /// </summary>
    public const string LiteralPartial = "partial";

    /// <summary>
    /// Literal for code: HistoryStatusPartial
    /// </summary>
    public const string LiteralHistoryStatusPartial = "http://hl7.org/fhir/history-status#partial";

    /// <summary>
    /// Dictionary for looking up HistoryStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "completed", Completed }, 
      { "http://hl7.org/fhir/history-status#completed", Completed }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/history-status#entered-in-error", EnteredInError }, 
      { "health-unknown", HealthUnknown }, 
      { "http://hl7.org/fhir/history-status#health-unknown", HealthUnknown }, 
      { "partial", Partial }, 
      { "http://hl7.org/fhir/history-status#partial", Partial }, 
    };
  };
}
