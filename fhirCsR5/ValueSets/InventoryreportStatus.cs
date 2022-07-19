// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The status of the InventoryReport.
  /// </summary>
  public static class InventoryreportStatusCodes
  {
    /// <summary>
    /// This report is submitted as current.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/inventoryreport-status"
    };
    /// <summary>
    /// The existence of the report is registered, but it is still without content or only some preliminary content.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/inventoryreport-status"
    };
    /// <summary>
    /// The report has been withdrawn following a previous final release.  This electronic record should never have existed, though it is possible that real-world decisions were based on it.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/inventoryreport-status"
    };
    /// <summary>
    /// The inventory report has been requested but there is no data available.
    /// </summary>
    public static readonly Coding Requested = new Coding
    {
      Code = "requested",
      Display = "Requested",
      System = "http://hl7.org/fhir/inventoryreport-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: InventoryreportStatusActive
    /// </summary>
    public const string LiteralInventoryreportStatusActive = "http://hl7.org/fhir/inventoryreport-status#active";

    /// <summary>
    /// Literal for code: Draft
    /// </summary>
    public const string LiteralDraft = "draft";

    /// <summary>
    /// Literal for code: InventoryreportStatusDraft
    /// </summary>
    public const string LiteralInventoryreportStatusDraft = "http://hl7.org/fhir/inventoryreport-status#draft";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: InventoryreportStatusEnteredInError
    /// </summary>
    public const string LiteralInventoryreportStatusEnteredInError = "http://hl7.org/fhir/inventoryreport-status#entered-in-error";

    /// <summary>
    /// Literal for code: Requested
    /// </summary>
    public const string LiteralRequested = "requested";

    /// <summary>
    /// Literal for code: InventoryreportStatusRequested
    /// </summary>
    public const string LiteralInventoryreportStatusRequested = "http://hl7.org/fhir/inventoryreport-status#requested";

    /// <summary>
    /// Dictionary for looking up InventoryreportStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/inventoryreport-status#active", Active }, 
      { "draft", Draft }, 
      { "http://hl7.org/fhir/inventoryreport-status#draft", Draft }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/inventoryreport-status#entered-in-error", EnteredInError }, 
      { "requested", Requested }, 
      { "http://hl7.org/fhir/inventoryreport-status#requested", Requested }, 
    };
  };
}
