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
      System = "http://hl7.org/fhir/research-study-classifiers"
    };
    /// <summary>
    /// The main question to be answered, and the one that drives any statistical planning for the study—e.g., calculation of the sample size to provide the appropriate power for statistical testing.
    /// </summary>
    public static readonly Coding Primary = new Coding
    {
      Code = "primary",
      Display = "Primary",
      System = "http://hl7.org/fhir/research-study-classifiers"
    };
    /// <summary>
    /// Question to be answered in the study that is of lesser importance than the primary objective.
    /// </summary>
    public static readonly Coding Secondary = new Coding
    {
      Code = "secondary",
      Display = "Secondary",
      System = "http://hl7.org/fhir/research-study-classifiers"
    };

    /// <summary>
    /// Literal for code: Exploratory
    /// </summary>
    public const string LiteralExploratory = "exploratory";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersExploratory
    /// </summary>
    public const string LiteralResearchStudyClassifiersExploratory = "http://hl7.org/fhir/research-study-classifiers#exploratory";

    /// <summary>
    /// Literal for code: Primary
    /// </summary>
    public const string LiteralPrimary = "primary";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersPrimary
    /// </summary>
    public const string LiteralResearchStudyClassifiersPrimary = "http://hl7.org/fhir/research-study-classifiers#primary";

    /// <summary>
    /// Literal for code: Secondary
    /// </summary>
    public const string LiteralSecondary = "secondary";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersSecondary
    /// </summary>
    public const string LiteralResearchStudyClassifiersSecondary = "http://hl7.org/fhir/research-study-classifiers#secondary";

    /// <summary>
    /// Dictionary for looking up ResearchStudyObjectiveType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "exploratory", Exploratory }, 
      { "http://hl7.org/fhir/research-study-classifiers#exploratory", Exploratory }, 
      { "primary", Primary }, 
      { "http://hl7.org/fhir/research-study-classifiers#primary", Primary }, 
      { "secondary", Secondary }, 
      { "http://hl7.org/fhir/research-study-classifiers#secondary", Secondary }, 
    };
  };
}
