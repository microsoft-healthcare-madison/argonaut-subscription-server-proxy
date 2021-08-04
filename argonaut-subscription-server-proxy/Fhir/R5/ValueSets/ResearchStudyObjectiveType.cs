// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes for the kind of study objective.
  /// </summary>
  public static class ResearchStudyObjectiveTypeCodes
  {
    /// <summary>
    /// Exploratory questions to be answered in the study.
    /// </summary>
    public static readonly Coding Exploratory = new Coding
    {
      Code = "exploratory",
      Display = "Exploratory",
      System = "http://terminology.hl7.org/CodeSystem/research-study-objective-type"
    };
    /// <summary>
    /// The main question to be answered, and the one that drives any statistical planning for the study—e.g., calculation of the sample size to provide the appropriate power for statistical testing.
    /// </summary>
    public static readonly Coding Primary = new Coding
    {
      Code = "primary",
      Display = "Primary",
      System = "http://terminology.hl7.org/CodeSystem/research-study-objective-type"
    };
    /// <summary>
    /// Question to be answered in the study that is of lesser importance than the primary objective.
    /// </summary>
    public static readonly Coding Secondary = new Coding
    {
      Code = "secondary",
      Display = "Secondary",
      System = "http://terminology.hl7.org/CodeSystem/research-study-objective-type"
    };

    /// <summary>
    /// Literal for code: Exploratory
    /// </summary>
    public const string LiteralExploratory = "exploratory";

    /// <summary>
    /// Literal for code: Primary
    /// </summary>
    public const string LiteralPrimary = "primary";

    /// <summary>
    /// Literal for code: Secondary
    /// </summary>
    public const string LiteralSecondary = "secondary";
  };
}
