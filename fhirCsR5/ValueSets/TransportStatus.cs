// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Status of the transport
  /// </summary>
  public static class TransportStatusCodes
  {
    /// <summary>
    /// Transport was started but not completed.
    /// </summary>
    public static readonly Coding Abandoned = new Coding
    {
      Code = "abandoned",
      Display = "Abandoned",
      System = "http://hl7.org/fhir/transport-status"
    };
    /// <summary>
    /// Transport was cancelled before started.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "Cancelled",
      System = "http://hl7.org/fhir/transport-status"
    };
    /// <summary>
    /// Transport has been completed.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/transport-status"
    };
    /// <summary>
    /// This electronic record should never have existed, though it is possible that real-world decisions were based on it. (If real-world activity has occurred, the status should be "abandoned" rather than "entered-in-error".).
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered In Error",
      System = "http://hl7.org/fhir/transport-status"
    };
    /// <summary>
    /// Transport has started but not completed.
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://hl7.org/fhir/transport-status"
    };
    /// <summary>
    /// Planned transport that is not yet requested.
    /// </summary>
    public static readonly Coding Planned = new Coding
    {
      Code = "planned",
      Display = "Planned",
      System = "http://hl7.org/fhir/transport-status"
    };

    /// <summary>
    /// Literal for code: Abandoned
    /// </summary>
    public const string LiteralAbandoned = "abandoned";

    /// <summary>
    /// Literal for code: TransportStatusAbandoned
    /// </summary>
    public const string LiteralTransportStatusAbandoned = "http://hl7.org/fhir/transport-status#abandoned";

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "cancelled";

    /// <summary>
    /// Literal for code: TransportStatusCancelled
    /// </summary>
    public const string LiteralTransportStatusCancelled = "http://hl7.org/fhir/transport-status#cancelled";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: TransportStatusCompleted
    /// </summary>
    public const string LiteralTransportStatusCompleted = "http://hl7.org/fhir/transport-status#completed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: TransportStatusEnteredInError
    /// </summary>
    public const string LiteralTransportStatusEnteredInError = "http://hl7.org/fhir/transport-status#entered-in-error";

    /// <summary>
    /// Literal for code: InProgress
    /// </summary>
    public const string LiteralInProgress = "in-progress";

    /// <summary>
    /// Literal for code: TransportStatusInProgress
    /// </summary>
    public const string LiteralTransportStatusInProgress = "http://hl7.org/fhir/transport-status#in-progress";

    /// <summary>
    /// Literal for code: Planned
    /// </summary>
    public const string LiteralPlanned = "planned";

    /// <summary>
    /// Literal for code: TransportStatusPlanned
    /// </summary>
    public const string LiteralTransportStatusPlanned = "http://hl7.org/fhir/transport-status#planned";

    /// <summary>
    /// Dictionary for looking up TransportStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "abandoned", Abandoned }, 
      { "http://hl7.org/fhir/transport-status#abandoned", Abandoned }, 
      { "cancelled", Cancelled }, 
      { "http://hl7.org/fhir/transport-status#cancelled", Cancelled }, 
      { "completed", Completed }, 
      { "http://hl7.org/fhir/transport-status#completed", Completed }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/transport-status#entered-in-error", EnteredInError }, 
      { "in-progress", InProgress }, 
      { "http://hl7.org/fhir/transport-status#in-progress", InProgress }, 
      { "planned", Planned }, 
      { "http://hl7.org/fhir/transport-status#planned", Planned }, 
    };
  };
}