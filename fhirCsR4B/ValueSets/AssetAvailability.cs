// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set has asset availability codes.
  /// </summary>
  public static class AssetAvailabilityCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding Lease = new Coding
    {
      Code = "lease",
      Display = "Lease",
      System = "http://hl7.org/fhir/asset-availability"
    };

    /// <summary>
    /// Literal for code: Lease
    /// </summary>
    public const string LiteralLease = "lease";

    /// <summary>
    /// Literal for code: AssetAvailabilityLease
    /// </summary>
    public const string LiteralAssetAvailabilityLease = "http://hl7.org/fhir/asset-availability#lease";

    /// <summary>
    /// Dictionary for looking up AssetAvailability Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "lease", Lease }, 
      { "http://hl7.org/fhir/asset-availability#lease", Lease }, 
    };
  };
}
