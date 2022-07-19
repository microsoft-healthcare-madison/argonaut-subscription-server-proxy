// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Overall defining type of this Medicinal Product.
  /// </summary>
  public static class MedicinalProductTypeCodes
  {
    /// <summary>
    /// An investigational medicinal product.
    /// </summary>
    public static readonly Coding InvestigationalMedicinalProduct = new Coding
    {
      Code = "InvestigationalProduct",
      Display = "Investigational Medicinal Product",
      System = "http://hl7.org/fhir/medicinal-product-type"
    };
    /// <summary>
    /// A standard medicinal product.
    /// </summary>
    public static readonly Coding MedicinalProduct = new Coding
    {
      Code = "MedicinalProduct",
      Display = "Medicinal Product",
      System = "http://hl7.org/fhir/medicinal-product-type"
    };

    /// <summary>
    /// Literal for code: InvestigationalMedicinalProduct
    /// </summary>
    public const string LiteralInvestigationalMedicinalProduct = "InvestigationalProduct";

    /// <summary>
    /// Literal for code: MedicinalProductTypeInvestigationalMedicinalProduct
    /// </summary>
    public const string LiteralMedicinalProductTypeInvestigationalMedicinalProduct = "http://hl7.org/fhir/medicinal-product-type#InvestigationalProduct";

    /// <summary>
    /// Literal for code: MedicinalProduct
    /// </summary>
    public const string LiteralMedicinalProduct = "MedicinalProduct";

    /// <summary>
    /// Literal for code: MedicinalProductTypeMedicinalProduct
    /// </summary>
    public const string LiteralMedicinalProductTypeMedicinalProduct = "http://hl7.org/fhir/medicinal-product-type#MedicinalProduct";

    /// <summary>
    /// Dictionary for looking up MedicinalProductType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "InvestigationalProduct", InvestigationalMedicinalProduct }, 
      { "http://hl7.org/fhir/medicinal-product-type#InvestigationalProduct", InvestigationalMedicinalProduct }, 
      { "MedicinalProduct", MedicinalProduct }, 
      { "http://hl7.org/fhir/medicinal-product-type#MedicinalProduct", MedicinalProduct }, 
    };
  };
}
