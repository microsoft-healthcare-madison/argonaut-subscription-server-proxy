// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
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
    /// Literal for code: Cells
    /// </summary>
    public const string LiteralCells = "cells";

    /// <summary>
    /// Literal for code: Fluid
    /// </summary>
    public const string LiteralFluid = "fluid";

    /// <summary>
    /// Literal for code: Organ
    /// </summary>
    public const string LiteralOrgan = "organ";

    /// <summary>
    /// Literal for code: Tissue
    /// </summary>
    public const string LiteralTissue = "tissue";
  };
}
