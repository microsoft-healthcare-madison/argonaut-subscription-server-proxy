// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// HL7 v3 ActMood Predicate codes, including inactive codes
  /// </summary>
  public static class InactiveCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Criterion = new Coding
    {
      Code = "CRT",
      Display = "criterion",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActMood"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Expectation = new Coding
    {
      Code = "EXPEC",
      Display = "expectation",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActMood"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Goal = new Coding
    {
      Code = "GOL",
      Display = "goal",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActMood"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Option = new Coding
    {
      Code = "OPT",
      Display = "option",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActMood"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Risk = new Coding
    {
      Code = "RSK",
      Display = "risk",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActMood"
    };

    /// <summary>
    /// Literal for code: Criterion
    /// </summary>
    public const string LiteralCriterion = "CRT";

    /// <summary>
    /// Literal for code: Expectation
    /// </summary>
    public const string LiteralExpectation = "EXPEC";

    /// <summary>
    /// Literal for code: Goal
    /// </summary>
    public const string LiteralGoal = "GOL";

    /// <summary>
    /// Literal for code: Option
    /// </summary>
    public const string LiteralOption = "OPT";

    /// <summary>
    /// Literal for code: Risk
    /// </summary>
    public const string LiteralRisk = "RSK";
  };
}
