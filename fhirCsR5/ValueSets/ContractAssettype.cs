// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set contract specific codes for asset type.
  /// </summary>
  public static class ContractAssettypeCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding Participation = new Coding
    {
      Code = "participation",
      Display = "Participation",
      System = "http://hl7.org/fhir/contract-asset-type"
    };

    /// <summary>
    /// Literal for code: Participation
    /// </summary>
    public const string LiteralParticipation = "participation";

    /// <summary>
    /// Literal for code: ContractAssettypeParticipation
    /// </summary>
    public const string LiteralContractAssettypeParticipation = "http://hl7.org/fhir/contract-asset-type#participation";

    /// <summary>
    /// Dictionary for looking up ContractAssettype Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "participation", Participation }, 
      { "http://hl7.org/fhir/contract-asset-type#participation", Participation }, 
    };
  };
}
