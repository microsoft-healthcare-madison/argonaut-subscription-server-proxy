// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set contract specific codes for offer party participation.
  /// </summary>
  public static class ContractPartyRoleCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding FLunky = new Coding
    {
      Code = "flunky",
      Display = "FLunky",
      System = "http://hl7.org/fhir/contract-party-role"
    };

    /// <summary>
    /// Literal for code: FLunky
    /// </summary>
    public const string LiteralFLunky = "flunky";

    /// <summary>
    /// Literal for code: ContractPartyRoleFLunky
    /// </summary>
    public const string LiteralContractPartyRoleFLunky = "http://hl7.org/fhir/contract-party-role#flunky";

    /// <summary>
    /// Dictionary for looking up ContractPartyRole Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "flunky", FLunky }, 
      { "http://hl7.org/fhir/contract-party-role#flunky", FLunky }, 
    };
  };
}
