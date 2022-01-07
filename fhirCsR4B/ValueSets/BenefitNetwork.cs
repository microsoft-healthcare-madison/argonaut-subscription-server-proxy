// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of Network type codes.
  /// </summary>
  public static class BenefitNetworkCodes
  {
    /// <summary>
    /// Services rendered by a Network provider
    /// </summary>
    public static readonly Coding InNetwork = new Coding
    {
      Code = "in",
      Display = "In Network",
      System = "http://terminology.hl7.org/CodeSystem/benefit-network"
    };
    /// <summary>
    /// Services rendered by a provider who is not in the Network
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
