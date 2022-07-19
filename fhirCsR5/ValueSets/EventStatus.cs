// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes identifying the lifecycle stage of an event.
  /// </summary>
  public static class EventStatusCodes
  {
    /// <summary>
    /// The event has now concluded.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// This electronic record should never have existed, though it is possible that real-world decisions were based on it.  (If real-world activity has occurred, the status should be "stopped" rather than "entered-in-error".).
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The event is currently occurring.
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The event was terminated prior to any activity beyond preparation.  I.e. The 'main' activity has not yet begun.  The boundary between preparatory and the 'main' activity is context-specific.
    /// </summary>
    public static readonly Coding NotDone = new Coding
    {
      Code = "not-done",
      Display = "Not Done",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The event has been temporarily stopped but is expected to resume in the future.
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On Hold",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The core event has not started yet, but some staging activities have begun (e.g. surgical suite preparation).  Preparation stages may be tracked for billing purposes.
    /// </summary>
    public static readonly Coding Preparation = new Coding
    {
      Code = "preparation",
      Display = "Preparation",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The event was terminated prior to the full completion of the intended activity but after at least some of the 'main' activity (beyond preparation) has occurred.
    /// </summary>
    public static readonly Coding Stopped = new Coding
    {
      Code = "stopped",
      Display = "Stopped",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The authoring/source system does not know which of the status values currently applies for this event.  Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply,  but the authoring/source system does not know which.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/event-status"
    };

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: EventStatusCompleted
    /// </summary>
    public const string LiteralEventStatusCompleted = "http://hl7.org/fhir/event-status#completed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: EventStatusEnteredInError
    /// </summary>
    public const string LiteralEventStatusEnteredInError = "http://hl7.org/fhir/event-status#entered-in-error";

    /// <summary>
    /// Literal for code: InProgress
    /// </summary>
    public const string LiteralInProgress = "in-progress";

    /// <summary>
    /// Literal for code: EventStatusInProgress
    /// </summary>
    public const string LiteralEventStatusInProgress = "http://hl7.org/fhir/event-status#in-progress";

    /// <summary>
    /// Literal for code: NotDone
    /// </summary>
    public const string LiteralNotDone = "not-done";

    /// <summary>
    /// Literal for code: EventStatusNotDone
    /// </summary>
    public const string LiteralEventStatusNotDone = "http://hl7.org/fhir/event-status#not-done";

    /// <summary>
    /// Literal for code: OnHold
    /// </summary>
    public const string LiteralOnHold = "on-hold";

    /// <summary>
    /// Literal for code: EventStatusOnHold
    /// </summary>
    public const string LiteralEventStatusOnHold = "http://hl7.org/fhir/event-status#on-hold";

    /// <summary>
    /// Literal for code: Preparation
    /// </summary>
    public const string LiteralPreparation = "preparation";

    /// <summary>
    /// Literal for code: EventStatusPreparation
    /// </summary>
    public const string LiteralEventStatusPreparation = "http://hl7.org/fhir/event-status#preparation";

    /// <summary>
    /// Literal for code: Stopped
    /// </summary>
    public const string LiteralStopped = "stopped";

    /// <summary>
    /// Literal for code: EventStatusStopped
    /// </summary>
    public const string LiteralEventStatusStopped = "http://hl7.org/fhir/event-status#stopped";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: EventStatusUnknown
    /// </summary>
    public const string LiteralEventStatusUnknown = "http://hl7.org/fhir/event-status#unknown";

    /// <summary>
    /// Dictionary for looking up EventStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "completed", Completed }, 
      { "http://hl7.org/fhir/event-status#completed", Completed }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/event-status#entered-in-error", EnteredInError }, 
      { "in-progress", InProgress }, 
      { "http://hl7.org/fhir/event-status#in-progress", InProgress }, 
      { "not-done", NotDone }, 
      { "http://hl7.org/fhir/event-status#not-done", NotDone }, 
      { "on-hold", OnHold }, 
      { "http://hl7.org/fhir/event-status#on-hold", OnHold }, 
      { "preparation", Preparation }, 
      { "http://hl7.org/fhir/event-status#preparation", Preparation }, 
      { "stopped", Stopped }, 
      { "http://hl7.org/fhir/event-status#stopped", Stopped }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/event-status#unknown", Unknown }, 
    };
  };
}
