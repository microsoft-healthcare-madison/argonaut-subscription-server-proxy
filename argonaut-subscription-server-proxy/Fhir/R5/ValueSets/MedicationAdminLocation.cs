// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// MedicationAdministration Location Codes
  /// </summary>
  public static class MedicationAdminLocationCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Community = new Coding
    {
      Code = "community",
      Display = "Community",
      System = "http://terminology.hl7.org/CodeSystem/medication-admin-location"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Inpatient = new Coding
    {
      Code = "inpatient",
      Display = "Inpatient",
      System = "http://terminology.hl7.org/CodeSystem/medication-admin-location"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Outpatient = new Coding
    {
      Code = "outpatient",
      Display = "Outpatient",
      System = "http://terminology.hl7.org/CodeSystem/medication-admin-location"
    };

    /// <summary>
    /// Literal for code: Community
    /// </summary>
    public const string LiteralCommunity = "community";

    /// <summary>
    /// Literal for code: Inpatient
    /// </summary>
    public const string LiteralInpatient = "inpatient";

    /// <summary>
    /// Literal for code: Outpatient
    /// </summary>
    public const string LiteralOutpatient = "outpatient";
  };
}
