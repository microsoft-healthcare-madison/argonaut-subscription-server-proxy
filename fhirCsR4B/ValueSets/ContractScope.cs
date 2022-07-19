// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set contract specific codes for scope.
  /// </summary>
  public static class ContractScopeCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding Policy = new Coding
    {
      Code = "policy",
      Display = "Policy",
      System = "http://hl7.org/fhir/contract-scope"
    };

    /// <summary>
    /// Literal for code: Policy
    /// </summary>
    public const string LiteralPolicy = "policy";

    /// <summary>
    /// Literal for code: ContractScopePolicy
    /// </summary>
    public const string LiteralContractScopePolicy = "http://hl7.org/fhir/contract-scope#policy";

    /// <summary>
    /// Dictionary for looking up ContractScope Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "policy", Policy }, 
      { "http://hl7.org/fhir/contract-scope#policy", Policy }, 
    };
  };
}
