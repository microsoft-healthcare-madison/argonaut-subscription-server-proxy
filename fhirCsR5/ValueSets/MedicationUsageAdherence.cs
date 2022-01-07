// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// MedicationUsage Adherence Codes
  /// </summary>
  public static class MedicationUsageAdherenceCodes
  {
    /// <summary>
    /// The medication is not being taken.
    /// </summary>
    public static readonly Coding NotTaking = new Coding
    {
      Code = "not-taking",
      Display = "Not Taking",
      System = "http://hl7.org/fhir/CodeSystem/medication-usage-adherence"
    };
    /// <summary>
    /// The medication is being taken.
    /// </summary>
    public static readonly Coding Taking = new Coding
    {
      Code = "taking",
      Display = "Taking",
      System = "http://hl7.org/fhir/CodeSystem/medication-usage-adherence"
    };
    /// <summary>
    /// The medication is being taken as directed.
    /// </summary>
    public static readonly Coding TakingAsDirected = new Coding
    {
      Code = "taking-as-directed",
      Display = "Taking As Directed",
      System = "http://hl7.org/fhir/CodeSystem/medication-usage-adherence"
    };
    /// <summary>
    /// The medication is not being taken as directed.
    /// </summary>
    public static readonly Coding TakingNotAsDirected = new Coding
    {
      Code = "taking-not-as-directed",
      Display = "Taking Not As Directed",
      System = "http://hl7.org/fhir/CodeSystem/medication-usage-adherence"
    };
    /// <summary>
    /// Whether the medication is being taken or not is not currently known.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/CodeSystem/medication-usage-adherence"
    };

    /// <summary>
    /// Literal for code: NotTaking
    /// </summary>
    public const string LiteralNotTaking = "not-taking";

    /// <summary>
    /// Literal for code: MedicationUsageAdherenceNotTaking
    /// </summary>
    public const string LiteralMedicationUsageAdherenceNotTaking = "http://hl7.org/fhir/CodeSystem/medication-usage-adherence#not-taking";

    /// <summary>
    /// Literal for code: Taking
    /// </summary>
    public const string LiteralTaking = "taking";

    /// <summary>
    /// Literal for code: MedicationUsageAdherenceTaking
    /// </summary>
    public const string LiteralMedicationUsageAdherenceTaking = "http://hl7.org/fhir/CodeSystem/medication-usage-adherence#taking";

    /// <summary>
    /// Literal for code: TakingAsDirected
    /// </summary>
    public const string LiteralTakingAsDirected = "taking-as-directed";

    /// <summary>
    /// Literal for code: MedicationUsageAdherenceTakingAsDirected
    /// </summary>
    public const string LiteralMedicationUsageAdherenceTakingAsDirected = "http://hl7.org/fhir/CodeSystem/medication-usage-adherence#taking-as-directed";

    /// <summary>
    /// Literal for code: TakingNotAsDirected
    /// </summary>
    public const string LiteralTakingNotAsDirected = "taking-not-as-directed";

    /// <summary>
    /// Literal for code: MedicationUsageAdherenceTakingNotAsDirected
    /// </summary>
    public const string LiteralMedicationUsageAdherenceTakingNotAsDirected = "http://hl7.org/fhir/CodeSystem/medication-usage-adherence#taking-not-as-directed";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: MedicationUsageAdherenceUnknown
    /// </summary>
    public const string LiteralMedicationUsageAdherenceUnknown = "http://hl7.org/fhir/CodeSystem/medication-usage-adherence#unknown";

    /// <summary>
    /// Dictionary for looking up MedicationUsageAdherence Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "not-taking", NotTaking }, 
      { "http://hl7.org/fhir/CodeSystem/medication-usage-adherence#not-taking", NotTaking }, 
      { "taking", Taking }, 
      { "http://hl7.org/fhir/CodeSystem/medication-usage-adherence#taking", Taking }, 
      { "taking-as-directed", TakingAsDirected }, 
      { "http://hl7.org/fhir/CodeSystem/medication-usage-adherence#taking-as-directed", TakingAsDirected }, 
      { "taking-not-as-directed", TakingNotAsDirected }, 
      { "http://hl7.org/fhir/CodeSystem/medication-usage-adherence#taking-not-as-directed", TakingNotAsDirected }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/CodeSystem/medication-usage-adherence#unknown", Unknown }, 
    };
  };
}
