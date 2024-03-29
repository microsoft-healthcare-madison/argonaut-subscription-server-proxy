// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Description Needed Here
  /// </summary>
  public static class ObservationStatisticsCodes
  {
    /// <summary>
    /// The 20th [Percentile](https://en.wikipedia.org/wiki/Percentile) of N measurements over the stated period.
    /// </summary>
    public static readonly Coding VAL20thPercentile = new Coding
    {
      Code = "20-percent",
      Display = "20th Percentile",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The difference between the upper and lower [Quartiles](https://en.wikipedia.org/wiki/Quartile) is called the Interquartile range. (IQR = Q3-Q1) Quartile deviation or Semi-interquartile range is one-half the difference between the first and the third quartiles.
    /// </summary>
    public static readonly Coding QuartileDeviation = new Coding
    {
      Code = "4-dev",
      Display = "Quartile Deviation",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The lower [Quartile](https://en.wikipedia.org/wiki/Quartile) Boundary of N measurements over the stated period.
    /// </summary>
    public static readonly Coding LowerQuartile = new Coding
    {
      Code = "4-lower",
      Display = "Lower Quartile",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The upper [Quartile](https://en.wikipedia.org/wiki/Quartile) Boundary of N measurements over the stated period.
    /// </summary>
    public static readonly Coding UpperQuartile = new Coding
    {
      Code = "4-upper",
      Display = "Upper Quartile",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The lowest of four values that divide the N measurements into a frequency distribution of five classes with each containing one fifth of the total population.
    /// </summary>
    public static readonly Coding VAL1stQuintile = new Coding
    {
      Code = "5-1",
      Display = "1st Quintile",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The second of four values that divide the N measurements into a frequency distribution of five classes with each containing one fifth of the total population.
    /// </summary>
    public static readonly Coding VAL2ndQuintile = new Coding
    {
      Code = "5-2",
      Display = "2nd Quintile",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The third of four values that divide the N measurements into a frequency distribution of five classes with each containing one fifth of the total population.
    /// </summary>
    public static readonly Coding VAL3rdQuintile = new Coding
    {
      Code = "5-3",
      Display = "3rd Quintile",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The fourth of four values that divide the N measurements into a frequency distribution of five classes with each containing one fifth of the total population.
    /// </summary>
    public static readonly Coding VAL4thQuintile = new Coding
    {
      Code = "5-4",
      Display = "4th Quintile",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The 80th [Percentile](https://en.wikipedia.org/wiki/Percentile) of N measurements over the stated period.
    /// </summary>
    public static readonly Coding VAL80thPercentile = new Coding
    {
      Code = "80-percent",
      Display = "80th Percentile",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The [mean](https://en.wikipedia.org/wiki/Arithmetic_mean) of N measurements over the stated period.
    /// </summary>
    public static readonly Coding Average = new Coding
    {
      Code = "average",
      Display = "Average",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The [number] of valid measurements over the stated period that contributed to the other statistical outputs.
    /// </summary>
    public static readonly Coding Count = new Coding
    {
      Code = "count",
      Display = "Count",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// Kurtosis  is a measure of the "tailedness" of the probability distribution of a real-valued random variable.   Source: [Wikipedia](https://en.wikipedia.org/wiki/Kurtosis).
    /// </summary>
    public static readonly Coding Kurtosis = new Coding
    {
      Code = "kurtosis",
      Display = "Kurtosis",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The [maximum](https://en.wikipedia.org/wiki/Maximal_element) value of N measurements over the stated period.
    /// </summary>
    public static readonly Coding Maximum = new Coding
    {
      Code = "maximum",
      Display = "Maximum",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The [median](https://en.wikipedia.org/wiki/Median) of N measurements over the stated period.
    /// </summary>
    public static readonly Coding Median = new Coding
    {
      Code = "median",
      Display = "Median",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The [minimum](https://en.wikipedia.org/wiki/Minimal_element) value of N measurements over the stated period.
    /// </summary>
    public static readonly Coding Minimum = new Coding
    {
      Code = "minimum",
      Display = "Minimum",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// Linear regression is an approach for modeling two-dimensional sample points with one independent variable and one dependent variable (conventionally, the x and y coordinates in a Cartesian coordinate system) and finds a linear function (a non-vertical straight line) that, as accurately as possible, predicts the dependent variable values as a function of the independent variables. Source: [Wikipedia](https://en.wikipedia.org/wiki/Simple_linear_regression)  This Statistic code will return both a gradient and an intercept value.
    /// </summary>
    public static readonly Coding Regression = new Coding
    {
      Code = "regression",
      Display = "Regression",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// Skewness is a measure of the asymmetry of the probability distribution of a real-valued random variable about its mean. The skewness value can be positive or negative, or even undefined.  Source: [Wikipedia](https://en.wikipedia.org/wiki/Skewness).
    /// </summary>
    public static readonly Coding Skew = new Coding
    {
      Code = "skew",
      Display = "Skew",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The [standard deviation](https://en.wikipedia.org/wiki/Standard_deviation) of N measurements over the stated period.
    /// </summary>
    public static readonly Coding StandardDeviation = new Coding
    {
      Code = "std-dev",
      Display = "Standard Deviation",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The [sum](https://en.wikipedia.org/wiki/Summation) of N measurements over the stated period.
    /// </summary>
    public static readonly Coding Sum = new Coding
    {
      Code = "sum",
      Display = "Sum",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The total [number] of valid measurements over the stated period, including observations that were ignored because they did not contain valid result values.
    /// </summary>
    public static readonly Coding TotalCount = new Coding
    {
      Code = "total-count",
      Display = "Total Count",
      System = "http://hl7.org/fhir/observation-statistics"
    };
    /// <summary>
    /// The [variance](https://en.wikipedia.org/wiki/Variance) of N measurements over the stated period.
    /// </summary>
    public static readonly Coding Variance = new Coding
    {
      Code = "variance",
      Display = "Variance",
      System = "http://hl7.org/fhir/observation-statistics"
    };

    /// <summary>
    /// Literal for code: VAL20thPercentile
    /// </summary>
    public const string LiteralVAL20thPercentile = "20-percent";

    /// <summary>
    /// Literal for code: QuartileDeviation
    /// </summary>
    public const string LiteralQuartileDeviation = "4-dev";

    /// <summary>
    /// Literal for code: LowerQuartile
    /// </summary>
    public const string LiteralLowerQuartile = "4-lower";

    /// <summary>
    /// Literal for code: UpperQuartile
    /// </summary>
    public const string LiteralUpperQuartile = "4-upper";

    /// <summary>
    /// Literal for code: VAL1stQuintile
    /// </summary>
    public const string LiteralVAL1stQuintile = "5-1";

    /// <summary>
    /// Literal for code: VAL2ndQuintile
    /// </summary>
    public const string LiteralVAL2ndQuintile = "5-2";

    /// <summary>
    /// Literal for code: VAL3rdQuintile
    /// </summary>
    public const string LiteralVAL3rdQuintile = "5-3";

    /// <summary>
    /// Literal for code: VAL4thQuintile
    /// </summary>
    public const string LiteralVAL4thQuintile = "5-4";

    /// <summary>
    /// Literal for code: VAL80thPercentile
    /// </summary>
    public const string LiteralVAL80thPercentile = "80-percent";

    /// <summary>
    /// Literal for code: Average
    /// </summary>
    public const string LiteralAverage = "average";

    /// <summary>
    /// Literal for code: Count
    /// </summary>
    public const string LiteralCount = "count";

    /// <summary>
    /// Literal for code: Kurtosis
    /// </summary>
    public const string LiteralKurtosis = "kurtosis";

    /// <summary>
    /// Literal for code: Maximum
    /// </summary>
    public const string LiteralMaximum = "maximum";

    /// <summary>
    /// Literal for code: Median
    /// </summary>
    public const string LiteralMedian = "median";

    /// <summary>
    /// Literal for code: Minimum
    /// </summary>
    public const string LiteralMinimum = "minimum";

    /// <summary>
    /// Literal for code: Regression
    /// </summary>
    public const string LiteralRegression = "regression";

    /// <summary>
    /// Literal for code: Skew
    /// </summary>
    public const string LiteralSkew = "skew";

    /// <summary>
    /// Literal for code: StandardDeviation
    /// </summary>
    public const string LiteralStandardDeviation = "std-dev";

    /// <summary>
    /// Literal for code: Sum
    /// </summary>
    public const string LiteralSum = "sum";

    /// <summary>
    /// Literal for code: TotalCount
    /// </summary>
    public const string LiteralTotalCount = "total-count";

    /// <summary>
    /// Literal for code: Variance
    /// </summary>
    public const string LiteralVariance = "variance";
  };
}
