// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Codes identifying the lifecycle stage of an Invoice.
  /// </summary>
  public static class InvoiceStatusCodes
  {
    /// <summary>
    /// the invoice has been balaced / completely paid.
    /// </summary>
    public static readonly Coding Balanced = new Coding
    {
      Code = "balanced",
      Display = "balanced",
      System = "http://hl7.org/fhir/invoice-status"
    };
    /// <summary>
    /// the invoice was cancelled.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "cancelled",
      System = "http://hl7.org/fhir/invoice-status"
    };
    /// <summary>
    /// the invoice has been prepared but not yet finalized.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "draft",
      System = "http://hl7.org/fhir/invoice-status"
    };
    /// <summary>
    /// the invoice was determined as entered in error before it was issued.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "entered in error",
      System = "http://hl7.org/fhir/invoice-status"
    };
    /// <summary>
    /// the invoice has been finalized and sent to the recipient.
    /// </summary>
    public static readonly Coding Issued = new Coding
    {
      Code = "issued",
      Display = "issued",
      System = "http://hl7.org/fhir/invoice-status"
    };

    /// <summary>
    /// Literal for code: Balanced
    /// </summary>
    public const string LiteralBalanced = "balanced";

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "cancelled";

    /// <summary>
    /// Literal for code: Draft
    /// </summary>
    public const string LiteralDraft = "draft";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: Issued
    /// </summary>
    public const string LiteralIssued = "issued";
  };
}
