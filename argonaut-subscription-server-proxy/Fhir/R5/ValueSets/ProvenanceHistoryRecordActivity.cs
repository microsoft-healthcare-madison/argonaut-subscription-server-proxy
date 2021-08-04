// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes for Provenance activities that are relevant when capturing event history for resources.
  /// </summary>
  public static class ProvenanceHistoryRecordActivityCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding StoppedEndedAborted = new Coding
    {
      Code = "ABORT",
      Display = "Stopped/Ended/Aborted",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Activated = new Coding
    {
      Code = "ACTIVATE",
      Display = "Activated",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "CANCEL",
      Display = "Cancelled",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "COMPLETE",
      Display = "Completed",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Created = new Coding
    {
      Code = "CREATE",
      Display = "Created",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Deleted = new Coding
    {
      Code = "DELETE",
      Display = "Deleted",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Held = new Coding
    {
      Code = "HOLD",
      Display = "Held",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding MarkEnteredInError = new Coding
    {
      Code = "NULLIFY",
      Display = "Mark Entered-in-error",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Replaced = new Coding
    {
      Code = "OBSOLETE",
      Display = "Replaced",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Reactivated = new Coding
    {
      Code = "REACTIVATE",
      Display = "Reactivated",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Released = new Coding
    {
      Code = "RELEASE",
      Display = "Released",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding RESUME = new Coding
    {
      Code = "RESUME",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Suspended = new Coding
    {
      Code = "SUSPEND",
      Display = "Suspended",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Updated = new Coding
    {
      Code = "UPDATE",
      Display = "Updated",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };

    /// <summary>
    /// Literal for code: StoppedEndedAborted
    /// </summary>
    public const string LiteralStoppedEndedAborted = "ABORT";

    /// <summary>
    /// Literal for code: Activated
    /// </summary>
    public const string LiteralActivated = "ACTIVATE";

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "CANCEL";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "COMPLETE";

    /// <summary>
    /// Literal for code: Created
    /// </summary>
    public const string LiteralCreated = "CREATE";

    /// <summary>
    /// Literal for code: Deleted
    /// </summary>
    public const string LiteralDeleted = "DELETE";

    /// <summary>
    /// Literal for code: Held
    /// </summary>
    public const string LiteralHeld = "HOLD";

    /// <summary>
    /// Literal for code: MarkEnteredInError
    /// </summary>
    public const string LiteralMarkEnteredInError = "NULLIFY";

    /// <summary>
    /// Literal for code: Replaced
    /// </summary>
    public const string LiteralReplaced = "OBSOLETE";

    /// <summary>
    /// Literal for code: Reactivated
    /// </summary>
    public const string LiteralReactivated = "REACTIVATE";

    /// <summary>
    /// Literal for code: Released
    /// </summary>
    public const string LiteralReleased = "RELEASE";

    /// <summary>
    /// Literal for code: RESUME
    /// </summary>
    public const string LiteralRESUME = "RESUME";

    /// <summary>
    /// Literal for code: Suspended
    /// </summary>
    public const string LiteralSuspended = "SUSPEND";

    /// <summary>
    /// Literal for code: Updated
    /// </summary>
    public const string LiteralUpdated = "UPDATE";
  };
}
