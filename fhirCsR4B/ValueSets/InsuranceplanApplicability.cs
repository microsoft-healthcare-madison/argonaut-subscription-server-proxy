// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Whether the cost applies to in-network or out-of-network providers.
  /// </summary>
  public static class InsuranceplanApplicabilityCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding InNetwork = new Coding
    {
      Code = "in-network",
      Display = "In Network",
      System = "http://terminology.hl7.org/CodeSystem/applicability"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://terminology.hl7.org/CodeSystem/applicability"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OutOfNetwork = new Coding
    {
      Code = "out-of-network",
      Display = "Out of Network",
      System = "http://terminology.hl7.org/CodeSystem/applicability"
    };

    /// <summary>
    /// Literal for code: InNetwork
    /// </summary>
    public const string LiteralInNetwork = "in-network";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: OutOfNetwork
    /// </summary>
    public const string LiteralOutOfNetwork = "out-of-network";
  };
}