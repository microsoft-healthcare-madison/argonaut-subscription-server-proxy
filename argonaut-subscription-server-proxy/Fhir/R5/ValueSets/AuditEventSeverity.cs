// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The severity of the audit entry.
  /// </summary>
  public static class AuditEventSeverityCodes
  {
    /// <summary>
    /// Action must be taken immediately.
    /// </summary>
    public static readonly Coding Alert = new Coding
    {
      Code = "alert",
      Display = "Alert",
      System = "http://hl7.org/fhir/audit-event-severity"
    };
    /// <summary>
    /// Critical conditions.
    /// </summary>
    public static readonly Coding Critical = new Coding
    {
      Code = "critical",
      Display = "Critical",
      System = "http://hl7.org/fhir/audit-event-severity"
    };
    /// <summary>
    /// Debug-level messages.
    /// </summary>
    public static readonly Coding Debug = new Coding
    {
      Code = "debug",
      Display = "Debug",
      System = "http://hl7.org/fhir/audit-event-severity"
    };
    /// <summary>
    /// System is unusable.
    /// </summary>
    public static readonly Coding Emergency = new Coding
    {
      Code = "emergency",
      Display = "Emergency",
      System = "http://hl7.org/fhir/audit-event-severity"
    };
    /// <summary>
    /// Error conditions.
    /// </summary>
    public static readonly Coding Error = new Coding
    {
      Code = "error",
      Display = "Error",
      System = "http://hl7.org/fhir/audit-event-severity"
    };
    /// <summary>
    /// Informational messages.
    /// </summary>
    public static readonly Coding Informational = new Coding
    {
      Code = "informational",
      Display = "Informational",
      System = "http://hl7.org/fhir/audit-event-severity"
    };
    /// <summary>
    /// Normal but significant condition.
    /// </summary>
    public static readonly Coding Notice = new Coding
    {
      Code = "notice",
      Display = "Notice",
      System = "http://hl7.org/fhir/audit-event-severity"
    };
    /// <summary>
    /// Warning conditions.
    /// </summary>
    public static readonly Coding Warning = new Coding
    {
      Code = "warning",
      Display = "Warning",
      System = "http://hl7.org/fhir/audit-event-severity"
    };

    /// <summary>
    /// Literal for code: Alert
    /// </summary>
    public const string LiteralAlert = "alert";

    /// <summary>
    /// Literal for code: Critical
    /// </summary>
    public const string LiteralCritical = "critical";

    /// <summary>
    /// Literal for code: Debug
    /// </summary>
    public const string LiteralDebug = "debug";

    /// <summary>
    /// Literal for code: Emergency
    /// </summary>
    public const string LiteralEmergency = "emergency";

    /// <summary>
    /// Literal for code: Error
    /// </summary>
    public const string LiteralError = "error";

    /// <summary>
    /// Literal for code: Informational
    /// </summary>
    public const string LiteralInformational = "informational";

    /// <summary>
    /// Literal for code: Notice
    /// </summary>
    public const string LiteralNotice = "notice";

    /// <summary>
    /// Literal for code: Warning
    /// </summary>
    public const string LiteralWarning = "warning";
  };
}
