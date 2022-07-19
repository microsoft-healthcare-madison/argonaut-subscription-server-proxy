// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// A high level categorisation of a package.
  /// </summary>
  public static class PackageTypeCodes
  {
    /// <summary>
    /// Medicinal product pack
    /// </summary>
    public static readonly Coding MedicinalProductPack = new Coding
    {
      Code = "MedicinalProductPack",
      Display = "Medicinal product pack",
      System = "http://hl7.org/fhir/package-type"
    };
    /// <summary>
    /// Raw material package
    /// </summary>
    public static readonly Coding RawMaterialPackage = new Coding
    {
      Code = "RawMaterialPackage",
      Display = "Raw material package",
      System = "http://hl7.org/fhir/package-type"
    };
    /// <summary>
    /// Shipping or transport container
    /// </summary>
    public static readonly Coding ShippingOrTransportContainer = new Coding
    {
      Code = "Shipping-TransportContainer",
      Display = "Shipping or transport container",
      System = "http://hl7.org/fhir/package-type"
    };

    /// <summary>
    /// Literal for code: MedicinalProductPack
    /// </summary>
    public const string LiteralMedicinalProductPack = "MedicinalProductPack";

    /// <summary>
    /// Literal for code: PackageTypeMedicinalProductPack
    /// </summary>
    public const string LiteralPackageTypeMedicinalProductPack = "http://hl7.org/fhir/package-type#MedicinalProductPack";

    /// <summary>
    /// Literal for code: RawMaterialPackage
    /// </summary>
    public const string LiteralRawMaterialPackage = "RawMaterialPackage";

    /// <summary>
    /// Literal for code: PackageTypeRawMaterialPackage
    /// </summary>
    public const string LiteralPackageTypeRawMaterialPackage = "http://hl7.org/fhir/package-type#RawMaterialPackage";

    /// <summary>
    /// Literal for code: ShippingOrTransportContainer
    /// </summary>
    public const string LiteralShippingOrTransportContainer = "Shipping-TransportContainer";

    /// <summary>
    /// Literal for code: PackageTypeShippingOrTransportContainer
    /// </summary>
    public const string LiteralPackageTypeShippingOrTransportContainer = "http://hl7.org/fhir/package-type#Shipping-TransportContainer";

    /// <summary>
    /// Dictionary for looking up PackageType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "MedicinalProductPack", MedicinalProductPack }, 
      { "http://hl7.org/fhir/package-type#MedicinalProductPack", MedicinalProductPack }, 
      { "RawMaterialPackage", RawMaterialPackage }, 
      { "http://hl7.org/fhir/package-type#RawMaterialPackage", RawMaterialPackage }, 
      { "Shipping-TransportContainer", ShippingOrTransportContainer }, 
      { "http://hl7.org/fhir/package-type#Shipping-TransportContainer", ShippingOrTransportContainer }, 
    };
  };
}