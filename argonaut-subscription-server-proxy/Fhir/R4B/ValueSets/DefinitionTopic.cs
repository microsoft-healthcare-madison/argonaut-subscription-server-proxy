// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// High-level categorization of the definition, used for searching, sorting, and filtering.
  /// </summary>
  public static class DefinitionTopicCodes
  {
    /// <summary>
    /// The definition is related to assessment of the patient.
    /// </summary>
    public static readonly Coding Assessment = new Coding
    {
      Code = "assessment",
      Display = "Assessment",
      System = "http://terminology.hl7.org/CodeSystem/definition-topic"
    };
    /// <summary>
    /// The definition is related to education of the patient.
    /// </summary>
    public static readonly Coding Education = new Coding
    {
      Code = "education",
      Display = "Education",
      System = "http://terminology.hl7.org/CodeSystem/definition-topic"
    };
    /// <summary>
    /// The definition is related to treatment of the patient.
    /// </summary>
    public static readonly Coding Treatment = new Coding
    {
      Code = "treatment",
      Display = "Treatment",
      System = "http://terminology.hl7.org/CodeSystem/definition-topic"
    };

    /// <summary>
    /// Literal for code: Assessment
    /// </summary>
    public const string LiteralAssessment = "assessment";

    /// <summary>
    /// Literal for code: Education
    /// </summary>
    public const string LiteralEducation = "education";

    /// <summary>
    /// Literal for code: Treatment
    /// </summary>
    public const string LiteralTreatment = "treatment";
  };
}
