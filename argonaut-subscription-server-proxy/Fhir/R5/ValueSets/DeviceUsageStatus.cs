// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// A coded concept indicating the current status of the Device Usage.
  /// </summary>
  public static class DeviceUsageStatusCodes
  {
    /// <summary>
    /// The device is still being used.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// The device is no longer being used.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// The statement was recorded incorrectly.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// The device may be used at some time in the future.
    /// </summary>
    public static readonly Coding Intended = new Coding
    {
      Code = "intended",
      Display = "Intended",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// Actions implied by the statement have been temporarily halted, but are expected to continue later. May also be called "suspended".
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On Hold",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// Actions implied by the statement have been permanently halted, before all of them occurred.
    /// </summary>
    public static readonly Coding Stopped = new Coding
    {
      Code = "stopped",
      Display = "Stopped",
      System = "http://hl7.org/fhir/device-usage-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: Intended
    /// </summary>
    public const string LiteralIntended = "intended";

    /// <summary>
    /// Literal for code: OnHold
    /// </summary>
    public const string LiteralOnHold = "on-hold";

    /// <summary>
    /// Literal for code: Stopped
    /// </summary>
    public const string LiteralStopped = "stopped";
  };
}
