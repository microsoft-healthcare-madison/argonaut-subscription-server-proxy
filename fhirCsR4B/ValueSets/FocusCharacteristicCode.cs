// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Evidence focus characteristic code.
  /// </summary>
  public static class FocusCharacteristicCodeCodes
  {
    /// <summary>
    /// Used to reference a specific article.
    /// </summary>
    public static readonly Coding Citation = new Coding
    {
      Code = "citation",
      Display = "Citation",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// Used to denote a focus on clinical outcomes, ie evidence variable in role of outcome (measured variable) as observed is considered a "clinical outcome" (patient-important outcome such as mortality, symptoms, function or quality of life).
    /// </summary>
    public static readonly Coding ObservedOutcomesAreClinicalOutcomes = new Coding
    {
      Code = "clinical-outcomes-observed",
      Display = "Observed outcomes are clinical outcomes",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// The comparator (intervention or control state) of interest.
    /// </summary>
    public static readonly Coding Comparator = new Coding
    {
      Code = "comparator",
      Display = "Comparator",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// The exposure of interest, such as an intervention.
    /// </summary>
    public static readonly Coding Exposure = new Coding
    {
      Code = "exposure",
      Display = "Exposure",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// Any medication exposures. A subset of exposures or interventions that are medications.
    /// </summary>
    public static readonly Coding MedicationExposures = new Coding
    {
      Code = "medication-exposures",
      Display = "Medication exposures",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// the outcome of interest.
    /// </summary>
    public static readonly Coding Outcome = new Coding
    {
      Code = "outcome",
      Display = "Outcome",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// The population of interest.
    /// </summary>
    public static readonly Coding Population = new Coding
    {
      Code = "population",
      Display = "Population",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// Type of research study, such as randomized trial or case-control study.
    /// </summary>
    public static readonly Coding StudyType = new Coding
    {
      Code = "study-type",
      Display = "Study type",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };

    /// <summary>
    /// Literal for code: Citation
    /// </summary>
    public const string LiteralCitation = "citation";

    /// <summary>
    /// Literal for code: FocusCharacteristicCodeCitation
    /// </summary>
    public const string LiteralFocusCharacteristicCodeCitation = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#citation";

    /// <summary>
    /// Literal for code: ObservedOutcomesAreClinicalOutcomes
    /// </summary>
    public const string LiteralObservedOutcomesAreClinicalOutcomes = "clinical-outcomes-observed";

    /// <summary>
    /// Literal for code: FocusCharacteristicCodeObservedOutcomesAreClinicalOutcomes
    /// </summary>
    public const string LiteralFocusCharacteristicCodeObservedOutcomesAreClinicalOutcomes = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#clinical-outcomes-observed";

    /// <summary>
    /// Literal for code: Comparator
    /// </summary>
    public const string LiteralComparator = "comparator";

    /// <summary>
    /// Literal for code: FocusCharacteristicCodeComparator
    /// </summary>
    public const string LiteralFocusCharacteristicCodeComparator = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#comparator";

    /// <summary>
    /// Literal for code: Exposure
    /// </summary>
    public const string LiteralExposure = "exposure";

    /// <summary>
    /// Literal for code: FocusCharacteristicCodeExposure
    /// </summary>
    public const string LiteralFocusCharacteristicCodeExposure = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#exposure";

    /// <summary>
    /// Literal for code: MedicationExposures
    /// </summary>
    public const string LiteralMedicationExposures = "medication-exposures";

    /// <summary>
    /// Literal for code: FocusCharacteristicCodeMedicationExposures
    /// </summary>
    public const string LiteralFocusCharacteristicCodeMedicationExposures = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#medication-exposures";

    /// <summary>
    /// Literal for code: Outcome
    /// </summary>
    public const string LiteralOutcome = "outcome";

    /// <summary>
    /// Literal for code: FocusCharacteristicCodeOutcome
    /// </summary>
    public const string LiteralFocusCharacteristicCodeOutcome = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#outcome";

    /// <summary>
    /// Literal for code: Population
    /// </summary>
    public const string LiteralPopulation = "population";

    /// <summary>
    /// Literal for code: FocusCharacteristicCodePopulation
    /// </summary>
    public const string LiteralFocusCharacteristicCodePopulation = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#population";

    /// <summary>
    /// Literal for code: StudyType
    /// </summary>
    public const string LiteralStudyType = "study-type";

    /// <summary>
    /// Literal for code: FocusCharacteristicCodeStudyType
    /// </summary>
    public const string LiteralFocusCharacteristicCodeStudyType = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#study-type";

    /// <summary>
    /// Dictionary for looking up FocusCharacteristicCode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "citation", Citation }, 
      { "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#citation", Citation }, 
      { "clinical-outcomes-observed", ObservedOutcomesAreClinicalOutcomes }, 
      { "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#clinical-outcomes-observed", ObservedOutcomesAreClinicalOutcomes }, 
      { "comparator", Comparator }, 
      { "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#comparator", Comparator }, 
      { "exposure", Exposure }, 
      { "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#exposure", Exposure }, 
      { "medication-exposures", MedicationExposures }, 
      { "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#medication-exposures", MedicationExposures }, 
      { "outcome", Outcome }, 
      { "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#outcome", Outcome }, 
      { "population", Population }, 
      { "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#population", Population }, 
      { "study-type", StudyType }, 
      { "http://terminology.hl7.org/CodeSystem/focus-characteristic-code#study-type", StudyType }, 
    };
  };
}
