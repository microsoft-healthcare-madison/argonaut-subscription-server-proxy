// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set contract specific codes for status.
  /// </summary>
  public static class ContractDefinitionTypeCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding TemporaryValue = new Coding
    {
      Code = "temp",
      Display = "Temporary Value",
      System = "http://hl7.org/fhir/contract-definition-type"
    };

    /// <summary>
    /// Literal for code: TemporaryValue
    /// </summary>
    public const string LiteralTemporaryValue = "temp";

    /// <summary>
    /// Literal for code: ContractDefinitionTypeTemporaryValue
    /// </summary>
    public const string LiteralContractDefinitionTypeTemporaryValue = "http://hl7.org/fhir/contract-definition-type#temp";

    /// <summary>
    /// Dictionary for looking up ContractDefinitionType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "temp", TemporaryValue }, 
      { "http://hl7.org/fhir/contract-definition-type#temp", TemporaryValue }, 
    };
  };
}
