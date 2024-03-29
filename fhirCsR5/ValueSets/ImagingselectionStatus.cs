// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The status of the ImagingSelection.
  /// </summary>
  public static class ImagingselectionStatusCodes
  {
    /// <summary>
    /// The selected resources are available..
    /// </summary>
    public static readonly Coding Available = new Coding
    {
      Code = "available",
      Display = "Available",
      System = "http://hl7.org/fhir/imagingselection-status"
    };
    /// <summary>
    /// The imaging selection has been withdrawn following a release.  This electronic record should never have existed, though it is possible that real-world decisions were based on it. (If real-world activity has occurred, the status should be "cancelled" rather than "entered-in-error".).
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/imagingselection-status"
    };
    /// <summary>
    /// The system does not know which of the status values currently applies for this request. Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply, it's just not known which one.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/imagingselection-status"
    };

    /// <summary>
    /// Literal for code: Available
    /// </summary>
    public const string LiteralAvailable = "available";

    /// <summary>
    /// Literal for code: ImagingselectionStatusAvailable
    /// </summary>
    public const string LiteralImagingselectionStatusAvailable = "http://hl7.org/fhir/imagingselection-status#available";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: ImagingselectionStatusEnteredInError
    /// </summary>
    public const string LiteralImagingselectionStatusEnteredInError = "http://hl7.org/fhir/imagingselection-status#entered-in-error";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: ImagingselectionStatusUnknown
    /// </summary>
    public const string LiteralImagingselectionStatusUnknown = "http://hl7.org/fhir/imagingselection-status#unknown";

    /// <summary>
    /// Dictionary for looking up ImagingselectionStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "available", Available }, 
      { "http://hl7.org/fhir/imagingselection-status#available", Available }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/imagingselection-status#entered-in-error", EnteredInError }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/imagingselection-status#unknown", Unknown }, 
    };
  };
}
