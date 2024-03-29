// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// MedicationRequest Status Reason Codes
  /// </summary>
  public static class MedicationrequestStatusReasonCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TryAnotherTreatmentFirst = new Coding
    {
      Code = "altchoice",
      Display = "Try another treatment first",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrescriptionRequiresClarification = new Coding
    {
      Code = "clarif",
      Display = "Prescription requires clarification",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DrugLevelTooHigh = new Coding
    {
      Code = "drughigh",
      Display = "Drug level too high",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AdmissionToHospital = new Coding
    {
      Code = "hospadm",
      Display = "Admission to hospital",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding LabInterferenceIssues = new Coding
    {
      Code = "labint",
      Display = "Lab interference issues",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientNotAvailable = new Coding
    {
      Code = "non-avail",
      Display = "Patient not available",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ParentIsPregnantBreastFeeding = new Coding
    {
      Code = "preg",
      Display = "Parent is pregnant/breast feeding",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Allergy = new Coding
    {
      Code = "salg",
      Display = "Allergy",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DrugInteractsWithAnotherDrug = new Coding
    {
      Code = "sddi",
      Display = "Drug interacts with another drug",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DuplicateTherapy = new Coding
    {
      Code = "sdupther",
      Display = "Duplicate therapy",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SuspectedIntolerance = new Coding
    {
      Code = "sintol",
      Display = "Suspected intolerance",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientScheduledForSurgery = new Coding
    {
      Code = "surg",
      Display = "Patient scheduled for surgery.",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding WaitingForOldDrugToWashOut = new Coding
    {
      Code = "washout",
      Display = "Waiting for old drug to wash out",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-status-reason"
    };

    /// <summary>
    /// Literal for code: TryAnotherTreatmentFirst
    /// </summary>
    public const string LiteralTryAnotherTreatmentFirst = "altchoice";

    /// <summary>
    /// Literal for code: PrescriptionRequiresClarification
    /// </summary>
    public const string LiteralPrescriptionRequiresClarification = "clarif";

    /// <summary>
    /// Literal for code: DrugLevelTooHigh
    /// </summary>
    public const string LiteralDrugLevelTooHigh = "drughigh";

    /// <summary>
    /// Literal for code: AdmissionToHospital
    /// </summary>
    public const string LiteralAdmissionToHospital = "hospadm";

    /// <summary>
    /// Literal for code: LabInterferenceIssues
    /// </summary>
    public const string LiteralLabInterferenceIssues = "labint";

    /// <summary>
    /// Literal for code: PatientNotAvailable
    /// </summary>
    public const string LiteralPatientNotAvailable = "non-avail";

    /// <summary>
    /// Literal for code: ParentIsPregnantBreastFeeding
    /// </summary>
    public const string LiteralParentIsPregnantBreastFeeding = "preg";

    /// <summary>
    /// Literal for code: Allergy
    /// </summary>
    public const string LiteralAllergy = "salg";

    /// <summary>
    /// Literal for code: DrugInteractsWithAnotherDrug
    /// </summary>
    public const string LiteralDrugInteractsWithAnotherDrug = "sddi";

    /// <summary>
    /// Literal for code: DuplicateTherapy
    /// </summary>
    public const string LiteralDuplicateTherapy = "sdupther";

    /// <summary>
    /// Literal for code: SuspectedIntolerance
    /// </summary>
    public const string LiteralSuspectedIntolerance = "sintol";

    /// <summary>
    /// Literal for code: PatientScheduledForSurgery
    /// </summary>
    public const string LiteralPatientScheduledForSurgery = "surg";

    /// <summary>
    /// Literal for code: WaitingForOldDrugToWashOut
    /// </summary>
    public const string LiteralWaitingForOldDrugToWashOut = "washout";
  };
}
