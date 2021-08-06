// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Description Needed Here
  /// </summary>
  public static class CatalogTypeCodes
  {
    /// <summary>
    /// Device Catalog.
    /// </summary>
    public static readonly Coding DeviceCatalog = new Coding
    {
      Code = "device",
      Display = "Device Catalog",
      System = "http://hl7.org/fhir/catalogType"
    };
    /// <summary>
    /// Medication Catalog.
    /// </summary>
    public static readonly Coding MedicationCatalog = new Coding
    {
      Code = "medication",
      Display = "Medication Catalog",
      System = "http://hl7.org/fhir/catalogType"
    };
    /// <summary>
    /// Protocol List.
    /// </summary>
    public static readonly Coding ProtocolList = new Coding
    {
      Code = "protocol",
      Display = "Protocol List",
      System = "http://hl7.org/fhir/catalogType"
    };

    /// <summary>
    /// Literal for code: DeviceCatalog
    /// </summary>
    public const string LiteralDeviceCatalog = "device";

    /// <summary>
    /// Literal for code: MedicationCatalog
    /// </summary>
    public const string LiteralMedicationCatalog = "medication";

    /// <summary>
    /// Literal for code: ProtocolList
    /// </summary>
    public const string LiteralProtocolList = "protocol";
  };
}