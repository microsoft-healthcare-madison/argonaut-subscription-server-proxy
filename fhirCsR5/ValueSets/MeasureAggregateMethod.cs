// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Aggregation method for a measure (e.g. sum, average, median, minimum, maximum, count)
  /// </summary>
  public static class MeasureAggregateMethodCodes
  {
    /// <summary>
    /// The measure score is determined by taking the average of the observations derived from the measure population.
    /// </summary>
    public static readonly Coding Average = new Coding
    {
      Code = "average",
      Display = "Average",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
    /// <summary>
    /// The measure score is determined as the number of observations derived from the measure population.
    /// </summary>
    public static readonly Coding Count = new Coding
    {
      Code = "count",
      Display = "Count",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
    /// <summary>
    /// The measure score is determined by taking the maximum of the observations derived from the measure population.
    /// </summary>
    public static readonly Coding Maximum = new Coding
    {
      Code = "maximum",
      Display = "Maximum",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
    /// <summary>
    /// The measure score is determined by taking the median of the observations derived from the measure population.
    /// </summary>
    public static readonly Coding Median = new Coding
    {
      Code = "median",
      Display = "Median",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
    /// <summary>
    /// The measure score is determined by taking the minimum of the observations derived from the measure population.
    /// </summary>
    public static readonly Coding Minimum = new Coding
    {
      Code = "minimum",
      Display = "Minimum",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
    /// <summary>
    /// The measure score is determined by adding together the observations derived from the measure population.
    /// </summary>
    public static readonly Coding Sum = new Coding
    {
      Code = "sum",
      Display = "Sum",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };

    /// <summary>
    /// Literal for code: Average
    /// </summary>
    public const string LiteralAverage = "average";

    /// <summary>
    /// Literal for code: MeasureAggregateMethodAverage
    /// </summary>
    public const string LiteralMeasureAggregateMethodAverage = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#average";

    /// <summary>
    /// Literal for code: Count
    /// </summary>
    public const string LiteralCount = "count";

    /// <summary>
    /// Literal for code: MeasureAggregateMethodCount
    /// </summary>
    public const string LiteralMeasureAggregateMethodCount = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#count";

    /// <summary>
    /// Literal for code: Maximum
    /// </summary>
    public const string LiteralMaximum = "maximum";

    /// <summary>
    /// Literal for code: MeasureAggregateMethodMaximum
    /// </summary>
    public const string LiteralMeasureAggregateMethodMaximum = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#maximum";

    /// <summary>
    /// Literal for code: Median
    /// </summary>
    public const string LiteralMedian = "median";

    /// <summary>
    /// Literal for code: MeasureAggregateMethodMedian
    /// </summary>
    public const string LiteralMeasureAggregateMethodMedian = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#median";

    /// <summary>
    /// Literal for code: Minimum
    /// </summary>
    public const string LiteralMinimum = "minimum";

    /// <summary>
    /// Literal for code: MeasureAggregateMethodMinimum
    /// </summary>
    public const string LiteralMeasureAggregateMethodMinimum = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#minimum";

    /// <summary>
    /// Literal for code: Sum
    /// </summary>
    public const string LiteralSum = "sum";

    /// <summary>
    /// Literal for code: MeasureAggregateMethodSum
    /// </summary>
    public const string LiteralMeasureAggregateMethodSum = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#sum";

    /// <summary>
    /// Dictionary for looking up MeasureAggregateMethod Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "average", Average }, 
      { "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#average", Average }, 
      { "count", Count }, 
      { "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#count", Count }, 
      { "maximum", Maximum }, 
      { "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#maximum", Maximum }, 
      { "median", Median }, 
      { "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#median", Median }, 
      { "minimum", Minimum }, 
      { "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#minimum", Minimum }, 
      { "sum", Sum }, 
      { "http://hl7.org/fhir/CodeSystem/measure-aggregate-method#sum", Sum }, 
    };
  };
}
