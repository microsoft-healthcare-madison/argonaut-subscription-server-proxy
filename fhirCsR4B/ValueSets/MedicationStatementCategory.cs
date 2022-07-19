// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Medication Status Codes
  /// </summary>
  public static class MedicationStatementCategoryCodes
  {
    /// <summary>
    /// Includes orders for medications to be administered or consumed by the patient in their home (this would include long term care or nursing homes, hospices, etc.).
    /// </summary>
    public static readonly Coding Community = new Coding
    {
      Code = "community",
      Display = "Community",
      System = "http://terminology.hl7.org/CodeSystem/medication-statement-category"
    };
    /// <summary>
    /// Includes orders for medications to be administered or consumed in an inpatient or acute care setting
    /// </summary>
    public static readonly Coding Inpatient = new Coding
    {
      Code = "inpatient",
      Display = "Inpatient",
      System = "http://terminology.hl7.org/CodeSystem/medication-statement-category"
    };
    /// <summary>
    /// Includes orders for medications to be administered or consumed in an outpatient setting (for example, Emergency Department, Outpatient Clinic, Outpatient Surgery, Doctor's office)
    /// </summary>
    public static readonly Coding Outpatient = new Coding
    {
      Code = "outpatient",
      Display = "Outpatient",
      System = "http://terminology.hl7.org/CodeSystem/medication-statement-category"
    };
    /// <summary>
    /// Includes statements about medication use, including over the counter medication, provided by the patient, agent or another provider
    /// </summary>
    public static readonly Coding PatientSpecified = new Coding
    {
      Code = "patientspecified",
      Display = "Patient Specified",
      System = "http://terminology.hl7.org/CodeSystem/medication-statement-category"
    };

    /// <summary>
    /// Literal for code: Community
    /// </summary>
    public const string LiteralCommunity = "community";

    /// <summary>
    /// Literal for code: MedicationStatementCategoryCommunity
    /// </summary>
    public const string LiteralMedicationStatementCategoryCommunity = "http://terminology.hl7.org/CodeSystem/medication-statement-category#community";

    /// <summary>
    /// Literal for code: Inpatient
    /// </summary>
    public const string LiteralInpatient = "inpatient";

    /// <summary>
    /// Literal for code: MedicationStatementCategoryInpatient
    /// </summary>
    public const string LiteralMedicationStatementCategoryInpatient = "http://terminology.hl7.org/CodeSystem/medication-statement-category#inpatient";

    /// <summary>
    /// Literal for code: Outpatient
    /// </summary>
    public const string LiteralOutpatient = "outpatient";

    /// <summary>
    /// Literal for code: MedicationStatementCategoryOutpatient
    /// </summary>
    public const string LiteralMedicationStatementCategoryOutpatient = "http://terminology.hl7.org/CodeSystem/medication-statement-category#outpatient";

    /// <summary>
    /// Literal for code: PatientSpecified
    /// </summary>
    public const string LiteralPatientSpecified = "patientspecified";

    /// <summary>
    /// Literal for code: MedicationStatementCategoryPatientSpecified
    /// </summary>
    public const string LiteralMedicationStatementCategoryPatientSpecified = "http://terminology.hl7.org/CodeSystem/medication-statement-category#patientspecified";

    /// <summary>
    /// Dictionary for looking up MedicationStatementCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "community", Community }, 
      { "http://terminology.hl7.org/CodeSystem/medication-statement-category#community", Community }, 
      { "inpatient", Inpatient }, 
      { "http://terminology.hl7.org/CodeSystem/medication-statement-category#inpatient", Inpatient }, 
      { "outpatient", Outpatient }, 
      { "http://terminology.hl7.org/CodeSystem/medication-statement-category#outpatient", Outpatient }, 
      { "patientspecified", PatientSpecified }, 
      { "http://terminology.hl7.org/CodeSystem/medication-statement-category#patientspecified", PatientSpecified }, 
    };
  };
}
