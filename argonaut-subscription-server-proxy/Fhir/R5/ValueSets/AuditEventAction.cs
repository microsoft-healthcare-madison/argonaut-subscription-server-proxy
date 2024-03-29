// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Indicator for type of action performed during the event that generated the event.
  /// </summary>
  public static class AuditEventActionCodes
  {
    /// <summary>
    /// Create a new database object, such as placing an order.
    /// </summary>
    public static readonly Coding Create = new Coding
    {
      Code = "C",
      Display = "Create",
      System = "http://hl7.org/fhir/audit-event-action"
    };
    /// <summary>
    /// Delete items, such as a doctor master file record.
    /// </summary>
    public static readonly Coding Delete = new Coding
    {
      Code = "D",
      Display = "Delete",
      System = "http://hl7.org/fhir/audit-event-action"
    };
    /// <summary>
    /// Perform a system or application function such as log-on, program execution or use of an object's method, or perform a query/search operation.
    /// </summary>
    public static readonly Coding Execute = new Coding
    {
      Code = "E",
      Display = "Execute",
      System = "http://hl7.org/fhir/audit-event-action"
    };
    /// <summary>
    /// Display or print data, such as a doctor census.
    /// </summary>
    public static readonly Coding ReadViewPrint = new Coding
    {
      Code = "R",
      Display = "Read/View/Print",
      System = "http://hl7.org/fhir/audit-event-action"
    };
    /// <summary>
    /// Update data, such as revise patient information.
    /// </summary>
    public static readonly Coding Update = new Coding
    {
      Code = "U",
      Display = "Update",
      System = "http://hl7.org/fhir/audit-event-action"
    };

    /// <summary>
    /// Literal for code: Create
    /// </summary>
    public const string LiteralCreate = "C";

    /// <summary>
    /// Literal for code: Delete
    /// </summary>
    public const string LiteralDelete = "D";

    /// <summary>
    /// Literal for code: Execute
    /// </summary>
    public const string LiteralExecute = "E";

    /// <summary>
    /// Literal for code: ReadViewPrint
    /// </summary>
    public const string LiteralReadViewPrint = "R";

    /// <summary>
    /// Literal for code: Update
    /// </summary>
    public const string LiteralUpdate = "U";
  };
}
