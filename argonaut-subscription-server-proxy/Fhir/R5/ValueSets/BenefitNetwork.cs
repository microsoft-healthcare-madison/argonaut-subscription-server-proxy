// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of Network type codes.
  /// </summary>
  public static class BenefitNetworkCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding InNetwork = new Coding
    {
      Code = "in",
      Display = "In Network",
      System = "http://terminology.hl7.org/CodeSystem/benefit-network"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OutOfNetwork = new Coding
    {
      Code = "out",
      Display = "Out of Network",
      System = "http://terminology.hl7.org/CodeSystem/benefit-network"
    };

    /// <summary>
    /// Literal for code: InNetwork
    /// </summary>
    public const string LiteralInNetwork = "in";

    /// <summary>
    /// Literal for code: OutOfNetwork
    /// </summary>
    public const string LiteralOutOfNetwork = "out";
  };
}
