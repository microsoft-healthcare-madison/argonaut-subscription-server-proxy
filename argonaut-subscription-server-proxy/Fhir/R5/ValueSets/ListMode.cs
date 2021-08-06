// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The processing mode that applies to this list.
  /// </summary>
  public static class ListModeCodes
  {
    /// <summary>
    /// A point-in-time list that shows what changes have been made or recommended.  E.g. a discharge medication list showing what was added and removed during an encounter.
    /// </summary>
    public static readonly Coding ChangeList = new Coding
    {
      Code = "changes",
      Display = "Change List",
      System = "http://hl7.org/fhir/list-mode"
    };
    /// <summary>
    /// This list was prepared as a snapshot. It should not be assumed to be current.
    /// </summary>
    public static readonly Coding SnapshotList = new Coding
    {
      Code = "snapshot",
      Display = "Snapshot List",
      System = "http://hl7.org/fhir/list-mode"
    };
    /// <summary>
    /// This list is the master list, maintained in an ongoing fashion with regular updates as the real world list it is tracking changes.
    /// </summary>
    public static readonly Coding WorkingList = new Coding
    {
      Code = "working",
      Display = "Working List",
      System = "http://hl7.org/fhir/list-mode"
    };

    /// <summary>
    /// Literal for code: ChangeList
    /// </summary>
    public const string LiteralChangeList = "changes";

    /// <summary>
    /// Literal for code: SnapshotList
    /// </summary>
    public const string LiteralSnapshotList = "snapshot";

    /// <summary>
    /// Literal for code: WorkingList
    /// </summary>
    public const string LiteralWorkingList = "working";
  };
}