// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Example value set composed from SNOMED CT and HL7 V3 codes for observation targets such as donor, fetus or spouse. As use cases are discovered, more values may be added.
  /// </summary>
  public static class FocalSubjectCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Fetus = new Coding
    {
      Code = "83418008",
      Display = "Fetus",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Donor = new Coding
    {
      Code = "DON",
      Display = "donor",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Spouse = new Coding
    {
      Code = "SPS",
      Display = "spouse",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };

    /// <summary>
    /// Literal for code: Fetus
    /// </summary>
    public const string LiteralFetus = "83418008";

    /// <summary>
    /// Literal for code: Donor
    /// </summary>
    public const string LiteralDonor = "DON";

    /// <summary>
    /// Literal for code: Spouse
    /// </summary>
    public const string LiteralSpouse = "SPS";
  };
}
