// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of count.
  /// </summary>
  public static class InventoryreportCounttypeCodes
  {
    /// <summary>
    /// The inventory report is about the difference between a previous count and a current count, i.e. it represents the items that have been added/subtracted from inventory.
    /// </summary>
    public static readonly Coding Difference = new Coding
    {
      Code = "difference",
      Display = "Difference",
      System = "http://hl7.org/fhir/inventoryreport-counttype"
    };
    /// <summary>
    /// The inventory report is a current absolute snapshot, i.e. it represents the quantities at hand.
    /// </summary>
    public static readonly Coding Snapshot = new Coding
    {
      Code = "snapshot",
      Display = "Snapshot",
      System = "http://hl7.org/fhir/inventoryreport-counttype"
    };

    /// <summary>
    /// Literal for code: Difference
    /// </summary>
    public const string LiteralDifference = "difference";

    /// <summary>
    /// Literal for code: Snapshot
    /// </summary>
    public const string LiteralSnapshot = "snapshot";
  };
}
