// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value sets refers to a Category of supply.
  /// </summary>
  public static class SupplyrequestKindCodes
  {
    /// <summary>
    /// Central Supply
    /// </summary>
    public static readonly Coding CentralSupply = new Coding
    {
      Code = "central",
      Display = "Central Supply",
      System = "http://terminology.hl7.org/CodeSystem/supply-kind"
    };
    /// <summary>
    /// Non-Stock
    /// </summary>
    public static readonly Coding NonStock = new Coding
    {
      Code = "nonstock",
      Display = "Non-Stock",
      System = "http://terminology.hl7.org/CodeSystem/supply-kind"
    };

    /// <summary>
    /// Literal for code: CentralSupply
    /// </summary>
    public const string LiteralCentralSupply = "central";

    /// <summary>
    /// Literal for code: SupplyKindCentralSupply
    /// </summary>
    public const string LiteralSupplyKindCentralSupply = "http://terminology.hl7.org/CodeSystem/supply-kind#central";

    /// <summary>
    /// Literal for code: NonStock
    /// </summary>
    public const string LiteralNonStock = "nonstock";

    /// <summary>
    /// Literal for code: SupplyKindNonStock
    /// </summary>
    public const string LiteralSupplyKindNonStock = "http://terminology.hl7.org/CodeSystem/supply-kind#nonstock";

    /// <summary>
    /// Dictionary for looking up SupplyrequestKind Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "central", CentralSupply }, 
      { "http://terminology.hl7.org/CodeSystem/supply-kind#central", CentralSupply }, 
      { "nonstock", NonStock }, 
      { "http://terminology.hl7.org/CodeSystem/supply-kind#nonstock", NonStock }, 
    };
  };
}
