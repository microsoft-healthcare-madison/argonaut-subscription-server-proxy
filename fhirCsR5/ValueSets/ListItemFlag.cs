// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Example Item Flags for the List Resource. In this case, these are the kind of flags that would be used on a medication list at the end of a consultation.
  /// </summary>
  public static class ListItemFlagCodes
  {
    /// <summary>
    /// No change has been made to the status of this medicine item.
    /// </summary>
    public static readonly Coding Unchanged = new Coding
    {
      Code = "01",
      Display = "Unchanged",
      System = "urn:oid:1.2.36.1.2001.1001.101.104.16592"
    };
    /// <summary>
    /// The medicine item has changed. The change may be described in an extension (not defined yet)
    /// </summary>
    public static readonly Coding Changed = new Coding
    {
      Code = "02",
      Display = "Changed",
      System = "urn:oid:1.2.36.1.2001.1001.101.104.16592"
    };
    /// <summary>
    /// The prescription for this medicine item was cancelled by an authorized health care provider. The patient may be advised to complete the course of the prescribed medicine. This advice is a clinical decision made based on assessment of the patient's clinical condition.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "03",
      Display = "Cancelled",
      System = "urn:oid:1.2.36.1.2001.1001.101.104.16592"
    };
    /// <summary>
    /// A new medicine item has been prescribed
    /// </summary>
    public static readonly Coding Prescribed = new Coding
    {
      Code = "04",
      Display = "Prescribed",
      System = "urn:oid:1.2.36.1.2001.1001.101.104.16592"
    };
    /// <summary>
    /// Administration of this medication item that the patient is currently taking is stopped or recommended to be stopped (i.e. instructed to be ceased by a health care provider). This cessation is anticipated to be permanent. The Change Description should describe the reason for cessation. Example uses: the medication in question is considered ineffective or has caused serious adverse effects. This value applies both to the cessation of a medication that is prescribed by another healthcare provider or patient self-administration of OTC medicines.
    /// </summary>
    public static readonly Coding Ceased = new Coding
    {
      Code = "05",
      Display = "Ceased",
      System = "urn:oid:1.2.36.1.2001.1001.101.104.16592"
    };
    /// <summary>
    /// Administration of this medication item that the patient is currently taking is on hold, or instructed or recommended by a health care provider to be temporarily stopped, or subject to clinical review (i.e. the stop may be temporary or permanent depending on the outcome of clinical review), or temporarily suspended as a pre-requisite to certain surgical or diagnostic procedures.
    /// </summary>
    public static readonly Coding Suspended = new Coding
    {
      Code = "06",
      Display = "Suspended",
      System = "urn:oid:1.2.36.1.2001.1001.101.104.16592"
    };

    /// <summary>
    /// Literal for code: Unchanged
    /// </summary>
    public const string LiteralUnchanged = "01";

    /// <summary>
    /// Literal for code: ListItemFlagUnchanged
    /// </summary>
    public const string LiteralListItemFlagUnchanged = "urn:oid:1.2.36.1.2001.1001.101.104.16592#01";

    /// <summary>
    /// Literal for code: Changed
    /// </summary>
    public const string LiteralChanged = "02";

    /// <summary>
    /// Literal for code: ListItemFlagChanged
    /// </summary>
    public const string LiteralListItemFlagChanged = "urn:oid:1.2.36.1.2001.1001.101.104.16592#02";

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "03";

    /// <summary>
    /// Literal for code: ListItemFlagCancelled
    /// </summary>
    public const string LiteralListItemFlagCancelled = "urn:oid:1.2.36.1.2001.1001.101.104.16592#03";

    /// <summary>
    /// Literal for code: Prescribed
    /// </summary>
    public const string LiteralPrescribed = "04";

    /// <summary>
    /// Literal for code: ListItemFlagPrescribed
    /// </summary>
    public const string LiteralListItemFlagPrescribed = "urn:oid:1.2.36.1.2001.1001.101.104.16592#04";

    /// <summary>
    /// Literal for code: Ceased
    /// </summary>
    public const string LiteralCeased = "05";

    /// <summary>
    /// Literal for code: ListItemFlagCeased
    /// </summary>
    public const string LiteralListItemFlagCeased = "urn:oid:1.2.36.1.2001.1001.101.104.16592#05";

    /// <summary>
    /// Literal for code: Suspended
    /// </summary>
    public const string LiteralSuspended = "06";

    /// <summary>
    /// Literal for code: ListItemFlagSuspended
    /// </summary>
    public const string LiteralListItemFlagSuspended = "urn:oid:1.2.36.1.2001.1001.101.104.16592#06";

    /// <summary>
    /// Dictionary for looking up ListItemFlag Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "01", Unchanged }, 
      { "urn:oid:1.2.36.1.2001.1001.101.104.16592#01", Unchanged }, 
      { "02", Changed }, 
      { "urn:oid:1.2.36.1.2001.1001.101.104.16592#02", Changed }, 
      { "03", Cancelled }, 
      { "urn:oid:1.2.36.1.2001.1001.101.104.16592#03", Cancelled }, 
      { "04", Prescribed }, 
      { "urn:oid:1.2.36.1.2001.1001.101.104.16592#04", Prescribed }, 
      { "05", Ceased }, 
      { "urn:oid:1.2.36.1.2001.1001.101.104.16592#05", Ceased }, 
      { "06", Suspended }, 
      { "urn:oid:1.2.36.1.2001.1001.101.104.16592#06", Suspended }, 
    };
  };
}
