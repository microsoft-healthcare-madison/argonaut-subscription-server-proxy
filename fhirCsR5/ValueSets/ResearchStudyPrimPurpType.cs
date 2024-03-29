// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes for the main intent of the study.
  /// </summary>
  public static class ResearchStudyPrimPurpTypeCodes
  {
    /// <summary>
    /// One or more interventions for examining the basic mechanism of action (for example, physiology or biomechanics of an intervention).
    /// </summary>
    public static readonly Coding BasicScience = new Coding
    {
      Code = "basic-science",
      Display = "Basic Science",
      System = "http://hl7.org/fhir/research-study-classifiers"
    };
    /// <summary>
    /// An intervention of a device product is being evaluated to determine the feasibility of the product or to test a prototype device and not health outcomes. Such studies are conducted to confirm the design and operating specifications of a device before beginning a full clinical trial.
    /// </summary>
    public static readonly Coding DeviceFeasibility = new Coding
    {
      Code = "device-feasibility",
      Display = "Device Feasibility",
      System = "http://hl7.org/fhir/research-study-classifiers"
    };
    /// <summary>
    /// One or more interventions are being evaluated for identifying a disease or health condition.
    /// </summary>
    public static readonly Coding Diagnostic = new Coding
    {
      Code = "diagnostic",
      Display = "Diagnostic",
      System = "http://hl7.org/fhir/research-study-classifiers"
    };
    /// <summary>
    /// One or more interventions for evaluating the delivery, processes, management, organization, or financing of healthcare.
    /// </summary>
    public static readonly Coding HealthServicesResearch = new Coding
    {
      Code = "health-services-research",
      Display = "Health Services Research",
      System = "http://hl7.org/fhir/research-study-classifiers"
    };
    /// <summary>
    /// One or more interventions are being assessed for preventing the development of a specific disease or health condition.
    /// </summary>
    public static readonly Coding Prevention = new Coding
    {
      Code = "prevention",
      Display = "Prevention",
      System = "http://hl7.org/fhir/research-study-classifiers"
    };
    /// <summary>
    /// One or more interventions are assessed or examined for identifying a condition, or risk factors for a condition, in people who are not yet known to have the condition or risk factor.
    /// </summary>
    public static readonly Coding Screening = new Coding
    {
      Code = "screening",
      Display = "Screening",
      System = "http://hl7.org/fhir/research-study-classifiers"
    };
    /// <summary>
    /// One or more interventions are evaluated for maximizing comfort, minimizing side effects, or mitigating against a decline in the participant's health or function.
    /// </summary>
    public static readonly Coding SupportiveCare = new Coding
    {
      Code = "supportive-care",
      Display = "Supportive Care",
      System = "http://hl7.org/fhir/research-study-classifiers"
    };
    /// <summary>
    /// One or more interventions are being evaluated for treating a disease, syndrome, or condition.
    /// </summary>
    public static readonly Coding Treatment = new Coding
    {
      Code = "treatment",
      Display = "Treatment",
      System = "http://hl7.org/fhir/research-study-classifiers"
    };

    /// <summary>
    /// Literal for code: BasicScience
    /// </summary>
    public const string LiteralBasicScience = "basic-science";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersBasicScience
    /// </summary>
    public const string LiteralResearchStudyClassifiersBasicScience = "http://hl7.org/fhir/research-study-classifiers#basic-science";

    /// <summary>
    /// Literal for code: DeviceFeasibility
    /// </summary>
    public const string LiteralDeviceFeasibility = "device-feasibility";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersDeviceFeasibility
    /// </summary>
    public const string LiteralResearchStudyClassifiersDeviceFeasibility = "http://hl7.org/fhir/research-study-classifiers#device-feasibility";

    /// <summary>
    /// Literal for code: Diagnostic
    /// </summary>
    public const string LiteralDiagnostic = "diagnostic";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersDiagnostic
    /// </summary>
    public const string LiteralResearchStudyClassifiersDiagnostic = "http://hl7.org/fhir/research-study-classifiers#diagnostic";

    /// <summary>
    /// Literal for code: HealthServicesResearch
    /// </summary>
    public const string LiteralHealthServicesResearch = "health-services-research";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersHealthServicesResearch
    /// </summary>
    public const string LiteralResearchStudyClassifiersHealthServicesResearch = "http://hl7.org/fhir/research-study-classifiers#health-services-research";

    /// <summary>
    /// Literal for code: Prevention
    /// </summary>
    public const string LiteralPrevention = "prevention";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersPrevention
    /// </summary>
    public const string LiteralResearchStudyClassifiersPrevention = "http://hl7.org/fhir/research-study-classifiers#prevention";

    /// <summary>
    /// Literal for code: Screening
    /// </summary>
    public const string LiteralScreening = "screening";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersScreening
    /// </summary>
    public const string LiteralResearchStudyClassifiersScreening = "http://hl7.org/fhir/research-study-classifiers#screening";

    /// <summary>
    /// Literal for code: SupportiveCare
    /// </summary>
    public const string LiteralSupportiveCare = "supportive-care";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersSupportiveCare
    /// </summary>
    public const string LiteralResearchStudyClassifiersSupportiveCare = "http://hl7.org/fhir/research-study-classifiers#supportive-care";

    /// <summary>
    /// Literal for code: Treatment
    /// </summary>
    public const string LiteralTreatment = "treatment";

    /// <summary>
    /// Literal for code: ResearchStudyClassifiersTreatment
    /// </summary>
    public const string LiteralResearchStudyClassifiersTreatment = "http://hl7.org/fhir/research-study-classifiers#treatment";

    /// <summary>
    /// Dictionary for looking up ResearchStudyPrimPurpType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "basic-science", BasicScience }, 
      { "http://hl7.org/fhir/research-study-classifiers#basic-science", BasicScience }, 
      { "device-feasibility", DeviceFeasibility }, 
      { "http://hl7.org/fhir/research-study-classifiers#device-feasibility", DeviceFeasibility }, 
      { "diagnostic", Diagnostic }, 
      { "http://hl7.org/fhir/research-study-classifiers#diagnostic", Diagnostic }, 
      { "health-services-research", HealthServicesResearch }, 
      { "http://hl7.org/fhir/research-study-classifiers#health-services-research", HealthServicesResearch }, 
      { "prevention", Prevention }, 
      { "http://hl7.org/fhir/research-study-classifiers#prevention", Prevention }, 
      { "screening", Screening }, 
      { "http://hl7.org/fhir/research-study-classifiers#screening", Screening }, 
      { "supportive-care", SupportiveCare }, 
      { "http://hl7.org/fhir/research-study-classifiers#supportive-care", SupportiveCare }, 
      { "treatment", Treatment }, 
      { "http://hl7.org/fhir/research-study-classifiers#treatment", Treatment }, 
    };
  };
}
