// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// How the Quantity should be understood and represented.
  /// </summary>
  public static class QuantityComparatorCodes
  {
    /// <summary>
    /// The actual value is less than the given value.
    /// </summary>
    public static readonly Coding LessThan = new Coding
    {
      Code = "<",
      Display = "Less than",
      System = "http://hl7.org/fhir/quantity-comparator"
    };
    /// <summary>
    /// The actual value is less than or equal to the given value.
    /// </summary>
    public static readonly Coding LessOrEqualTo = new Coding
    {
      Code = "<=",
      Display = "Less or Equal to",
      System = "http://hl7.org/fhir/quantity-comparator"
    };
    /// <summary>
    /// The actual value is greater than the given value.
    /// </summary>
    public static readonly Coding GreaterThan = new Coding
    {
      Code = ">",
      Display = "Greater than",
      System = "http://hl7.org/fhir/quantity-comparator"
    };
    /// <summary>
    /// The actual value is greater than or equal to the given value.
    /// </summary>
    public static readonly Coding GreaterOrEqualTo = new Coding
    {
      Code = ">=",
      Display = "Greater or Equal to",
      System = "http://hl7.org/fhir/quantity-comparator"
    };

    /// <summary>
    /// Literal for code: LessThan
    /// </summary>
    public const string LiteralLessThan = "<";

    /// <summary>
    /// Literal for code: QuantityComparatorLessThan
    /// </summary>
    public const string LiteralQuantityComparatorLessThan = "http://hl7.org/fhir/quantity-comparator#<";

    /// <summary>
    /// Literal for code: LessOrEqualTo
    /// </summary>
    public const string LiteralLessOrEqualTo = "<=";

    /// <summary>
    /// Literal for code: QuantityComparatorLessOrEqualTo
    /// </summary>
    public const string LiteralQuantityComparatorLessOrEqualTo = "http://hl7.org/fhir/quantity-comparator#<=";

    /// <summary>
    /// Literal for code: GreaterThan
    /// </summary>
    public const string LiteralGreaterThan = ">";

    /// <summary>
    /// Literal for code: QuantityComparatorGreaterThan
    /// </summary>
    public const string LiteralQuantityComparatorGreaterThan = "http://hl7.org/fhir/quantity-comparator#>";

    /// <summary>
    /// Literal for code: GreaterOrEqualTo
    /// </summary>
    public const string LiteralGreaterOrEqualTo = ">=";

    /// <summary>
    /// Literal for code: QuantityComparatorGreaterOrEqualTo
    /// </summary>
    public const string LiteralQuantityComparatorGreaterOrEqualTo = "http://hl7.org/fhir/quantity-comparator#>=";

    /// <summary>
    /// Dictionary for looking up QuantityComparator Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "<", LessThan }, 
      { "http://hl7.org/fhir/quantity-comparator#<", LessThan }, 
      { "<=", LessOrEqualTo }, 
      { "http://hl7.org/fhir/quantity-comparator#<=", LessOrEqualTo }, 
      { ">", GreaterThan }, 
      { "http://hl7.org/fhir/quantity-comparator#>", GreaterThan }, 
      { ">=", GreaterOrEqualTo }, 
      { "http://hl7.org/fhir/quantity-comparator#>=", GreaterOrEqualTo }, 
    };
  };
}
