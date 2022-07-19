// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Extra monitoring defined for a Medicinal Product.
  /// </summary>
  public static class MedicinalProductAdditionalMonitoringCodes
  {
    /// <summary>
    /// Requirement for Black Triangle Monitoring
    /// </summary>
    public static readonly Coding RequirementForBlackTriangleMonitoring = new Coding
    {
      Code = "BlackTriangleMonitoring",
      Display = "Requirement for Black Triangle Monitoring",
      System = "http://hl7.org/fhir/medicinal-product-additional-monitoring"
    };

    /// <summary>
    /// Literal for code: RequirementForBlackTriangleMonitoring
    /// </summary>
    public const string LiteralRequirementForBlackTriangleMonitoring = "BlackTriangleMonitoring";

    /// <summary>
    /// Literal for code: MedicinalProductAdditionalMonitoringRequirementForBlackTriangleMonitoring
    /// </summary>
    public const string LiteralMedicinalProductAdditionalMonitoringRequirementForBlackTriangleMonitoring = "http://hl7.org/fhir/medicinal-product-additional-monitoring#BlackTriangleMonitoring";

    /// <summary>
    /// Dictionary for looking up MedicinalProductAdditionalMonitoring Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "BlackTriangleMonitoring", RequirementForBlackTriangleMonitoring }, 
      { "http://hl7.org/fhir/medicinal-product-additional-monitoring#BlackTriangleMonitoring", RequirementForBlackTriangleMonitoring }, 
    };
  };
}