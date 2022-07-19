// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes Example Coverage Financial Exception Codes.
  /// </summary>
  public static class CoverageFinancialExceptionCodes
  {
    /// <summary>
    /// Children in the foster care have all copays and deductibles waived.
    /// </summary>
    public static readonly Coding FosterChild = new Coding
    {
      Code = "foster",
      Display = "Foster child",
      System = "http://terminology.hl7.org/CodeSystem/ex-coverage-financial-exception"
    };
    /// <summary>
    /// Retired persons have all copays and deductibles reduced.
    /// </summary>
    public static readonly Coding Retired = new Coding
    {
      Code = "retired",
      Display = "Retired",
      System = "http://terminology.hl7.org/CodeSystem/ex-coverage-financial-exception"
    };

    /// <summary>
    /// Literal for code: FosterChild
    /// </summary>
    public const string LiteralFosterChild = "foster";

    /// <summary>
    /// Literal for code: CoverageFinancialExceptionFosterChild
    /// </summary>
    public const string LiteralCoverageFinancialExceptionFosterChild = "http://terminology.hl7.org/CodeSystem/ex-coverage-financial-exception#foster";

    /// <summary>
    /// Literal for code: Retired
    /// </summary>
    public const string LiteralRetired = "retired";

    /// <summary>
    /// Literal for code: CoverageFinancialExceptionRetired
    /// </summary>
    public const string LiteralCoverageFinancialExceptionRetired = "http://terminology.hl7.org/CodeSystem/ex-coverage-financial-exception#retired";

    /// <summary>
    /// Dictionary for looking up CoverageFinancialException Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "foster", FosterChild }, 
      { "http://terminology.hl7.org/CodeSystem/ex-coverage-financial-exception#foster", FosterChild }, 
      { "retired", Retired }, 
      { "http://terminology.hl7.org/CodeSystem/ex-coverage-financial-exception#retired", Retired }, 
    };
  };
}
