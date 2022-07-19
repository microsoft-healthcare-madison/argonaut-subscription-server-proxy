// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set contract specific codes for asset context.
  /// </summary>
  public static class ContractAssetcontextCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding Custodian = new Coding
    {
      Code = "custodian",
      Display = "Custodian",
      System = "http://hl7.org/fhir/contract-assetcontext"
    };

    /// <summary>
    /// Literal for code: Custodian
    /// </summary>
    public const string LiteralCustodian = "custodian";

    /// <summary>
    /// Literal for code: ContractAssetcontextCustodian
    /// </summary>
    public const string LiteralContractAssetcontextCustodian = "http://hl7.org/fhir/contract-assetcontext#custodian";

    /// <summary>
    /// Dictionary for looking up ContractAssetcontext Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "custodian", Custodian }, 
      { "http://hl7.org/fhir/contract-assetcontext#custodian", Custodian }, 
    };
  };
}
