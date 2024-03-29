// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Provides examples of actions to be performed.
  /// </summary>
  public static class ActionCodeCodes
  {
    /// <summary>
    /// The action indicates that information should be collected from a participant in the process.
    /// </summary>
    public static readonly Coding CollectInformation = new Coding
    {
      Code = "collect-information",
      Display = "Collect information",
      System = "http://terminology.hl7.org/CodeSystem/action-code"
    };
    /// <summary>
    /// The action indicates that a particular service should be provided.
    /// </summary>
    public static readonly Coding OrderAService = new Coding
    {
      Code = "order-service",
      Display = "Order a service",
      System = "http://terminology.hl7.org/CodeSystem/action-code"
    };
    /// <summary>
    /// The action indicates that a particular medication should be prescribed to the patient.
    /// </summary>
    public static readonly Coding PrescribeAMedication = new Coding
    {
      Code = "prescribe-medication",
      Display = "Prescribe a medication",
      System = "http://terminology.hl7.org/CodeSystem/action-code"
    };
    /// <summary>
    /// The action indicates that a particular diagnosis should be proposed.
    /// </summary>
    public static readonly Coding ProposeADiagnosis = new Coding
    {
      Code = "propose-diagnosis",
      Display = "Propose a diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/action-code"
    };
    /// <summary>
    /// The action indicates that a particular immunization should be performed.
    /// </summary>
    public static readonly Coding RecommendAnImmunization = new Coding
    {
      Code = "recommend-immunization",
      Display = "Recommend an immunization",
      System = "http://terminology.hl7.org/CodeSystem/action-code"
    };
    /// <summary>
    /// The action indicates that a particular detected issue should be recorded.
    /// </summary>
    public static readonly Coding RecordADetectedIssue = new Coding
    {
      Code = "record-detected-issue",
      Display = "Record a detected issue",
      System = "http://terminology.hl7.org/CodeSystem/action-code"
    };
    /// <summary>
    /// The action indicates that a particular inference should be recorded.
    /// </summary>
    public static readonly Coding RecordAnInference = new Coding
    {
      Code = "record-inference",
      Display = "Record an inference",
      System = "http://terminology.hl7.org/CodeSystem/action-code"
    };
    /// <summary>
    /// The action indicates that a particular flag should be reported.
    /// </summary>
    public static readonly Coding ReportAFlag = new Coding
    {
      Code = "report-flag",
      Display = "Report a flag",
      System = "http://terminology.hl7.org/CodeSystem/action-code"
    };
    /// <summary>
    /// The action indicates that a particular message should be sent to a participant in the process.
    /// </summary>
    public static readonly Coding SendAMessage = new Coding
    {
      Code = "send-message",
      Display = "Send a message",
      System = "http://terminology.hl7.org/CodeSystem/action-code"
    };

    /// <summary>
    /// Literal for code: CollectInformation
    /// </summary>
    public const string LiteralCollectInformation = "collect-information";

    /// <summary>
    /// Literal for code: OrderAService
    /// </summary>
    public const string LiteralOrderAService = "order-service";

    /// <summary>
    /// Literal for code: PrescribeAMedication
    /// </summary>
    public const string LiteralPrescribeAMedication = "prescribe-medication";

    /// <summary>
    /// Literal for code: ProposeADiagnosis
    /// </summary>
    public const string LiteralProposeADiagnosis = "propose-diagnosis";

    /// <summary>
    /// Literal for code: RecommendAnImmunization
    /// </summary>
    public const string LiteralRecommendAnImmunization = "recommend-immunization";

    /// <summary>
    /// Literal for code: RecordADetectedIssue
    /// </summary>
    public const string LiteralRecordADetectedIssue = "record-detected-issue";

    /// <summary>
    /// Literal for code: RecordAnInference
    /// </summary>
    public const string LiteralRecordAnInference = "record-inference";

    /// <summary>
    /// Literal for code: ReportAFlag
    /// </summary>
    public const string LiteralReportAFlag = "report-flag";

    /// <summary>
    /// Literal for code: SendAMessage
    /// </summary>
    public const string LiteralSendAMessage = "send-message";
  };
}
