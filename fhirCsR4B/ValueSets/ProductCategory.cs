// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Biologically Derived Product Category.
  /// </summary>
  public static class ProductCategoryCodes
  {
    /// <summary>
    /// Biological agent of unspecified type.
    /// </summary>
    public static readonly Coding BiologicalAgent = new Coding
    {
      Code = "biologicalAgent",
      Display = "BiologicalAgent",
      System = "http://hl7.org/fhir/product-category"
    };
    /// <summary>
    /// Collection of cells.
    /// </summary>
    public static readonly Coding Cells = new Coding
    {
      Code = "cells",
      Display = "Cells",
      System = "http://hl7.org/fhir/product-category"
    };
    /// <summary>
    /// Body fluid.
    /// </summary>
    public static readonly Coding Fluid = new Coding
    {
      Code = "fluid",
      Display = "Fluid",
      System = "http://hl7.org/fhir/product-category"
    };
    /// <summary>
    /// A collection of tissues joined in a structural unit to serve a common function.
    /// </summary>
    public static readonly Coding Organ = new Coding
    {
      Code = "organ",
      Display = "Organ",
      System = "http://hl7.org/fhir/product-category"
    };
    /// <summary>
    /// An ensemble of similar cells and their extracellular matrix from the same origin that together carry out a specific function.
    /// </summary>
    public static readonly Coding Tissue = new Coding
    {
      Code = "tissue",
      Display = "Tissue",
      System = "http://hl7.org/fhir/product-category"
    };

    /// <summary>
    /// Literal for code: BiologicalAgent
    /// </summary>
    public const string LiteralBiologicalAgent = "biologicalAgent";

    /// <summary>
    /// Literal for code: ProductCategoryBiologicalAgent
    /// </summary>
    public const string LiteralProductCategoryBiologicalAgent = "http://hl7.org/fhir/product-category#biologicalAgent";

    /// <summary>
    /// Literal for code: Cells
    /// </summary>
    public const string LiteralCells = "cells";

    /// <summary>
    /// Literal for code: ProductCategoryCells
    /// </summary>
    public const string LiteralProductCategoryCells = "http://hl7.org/fhir/product-category#cells";

    /// <summary>
    /// Literal for code: Fluid
    /// </summary>
    public const string LiteralFluid = "fluid";

    /// <summary>
    /// Literal for code: ProductCategoryFluid
    /// </summary>
    public const string LiteralProductCategoryFluid = "http://hl7.org/fhir/product-category#fluid";

    /// <summary>
    /// Literal for code: Organ
    /// </summary>
    public const string LiteralOrgan = "organ";

    /// <summary>
    /// Literal for code: ProductCategoryOrgan
    /// </summary>
    public const string LiteralProductCategoryOrgan = "http://hl7.org/fhir/product-category#organ";

    /// <summary>
    /// Literal for code: Tissue
    /// </summary>
    public const string LiteralTissue = "tissue";

    /// <summary>
    /// Literal for code: ProductCategoryTissue
    /// </summary>
    public const string LiteralProductCategoryTissue = "http://hl7.org/fhir/product-category#tissue";

    /// <summary>
    /// Dictionary for looking up ProductCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "biologicalAgent", BiologicalAgent }, 
      { "http://hl7.org/fhir/product-category#biologicalAgent", BiologicalAgent }, 
      { "cells", Cells }, 
      { "http://hl7.org/fhir/product-category#cells", Cells }, 
      { "fluid", Fluid }, 
      { "http://hl7.org/fhir/product-category#fluid", Fluid }, 
      { "organ", Organ }, 
      { "http://hl7.org/fhir/product-category#organ", Organ }, 
      { "tissue", Tissue }, 
      { "http://hl7.org/fhir/product-category#tissue", Tissue }, 
    };
  };
}
