// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// A characteristic of a package.
  /// </summary>
  public static class PackageCharacteristicCodes
  {
    /// <summary>
    /// Calendar pack
    /// </summary>
    public static readonly Coding CalendarPack = new Coding
    {
      Code = "CalendarPack",
      Display = "Calendar pack",
      System = "http://hl7.org/fhir/package-characteristic"
    };
    /// <summary>
    /// Hospital pack
    /// </summary>
    public static readonly Coding HospitalPack = new Coding
    {
      Code = "HospitalPack",
      Display = "Hospital pack",
      System = "http://hl7.org/fhir/package-characteristic"
    };
    /// <summary>
    /// Nurse prescribable
    /// </summary>
    public static readonly Coding NursePrescribable = new Coding
    {
      Code = "NursePrescribable",
      Display = "Nurse prescribable",
      System = "http://hl7.org/fhir/package-characteristic"
    };

    /// <summary>
    /// Literal for code: CalendarPack
    /// </summary>
    public const string LiteralCalendarPack = "CalendarPack";

    /// <summary>
    /// Literal for code: PackageCharacteristicCalendarPack
    /// </summary>
    public const string LiteralPackageCharacteristicCalendarPack = "http://hl7.org/fhir/package-characteristic#CalendarPack";

    /// <summary>
    /// Literal for code: HospitalPack
    /// </summary>
    public const string LiteralHospitalPack = "HospitalPack";

    /// <summary>
    /// Literal for code: PackageCharacteristicHospitalPack
    /// </summary>
    public const string LiteralPackageCharacteristicHospitalPack = "http://hl7.org/fhir/package-characteristic#HospitalPack";

    /// <summary>
    /// Literal for code: NursePrescribable
    /// </summary>
    public const string LiteralNursePrescribable = "NursePrescribable";

    /// <summary>
    /// Literal for code: PackageCharacteristicNursePrescribable
    /// </summary>
    public const string LiteralPackageCharacteristicNursePrescribable = "http://hl7.org/fhir/package-characteristic#NursePrescribable";

    /// <summary>
    /// Dictionary for looking up PackageCharacteristic Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "CalendarPack", CalendarPack }, 
      { "http://hl7.org/fhir/package-characteristic#CalendarPack", CalendarPack }, 
      { "HospitalPack", HospitalPack }, 
      { "http://hl7.org/fhir/package-characteristic#HospitalPack", HospitalPack }, 
      { "NursePrescribable", NursePrescribable }, 
      { "http://hl7.org/fhir/package-characteristic#NursePrescribable", NursePrescribable }, 
    };
  };
}
