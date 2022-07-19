// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// MedicationKnowledge Status Codes
  /// </summary>
  public static class MedicationknowledgeStatusCodes
  {
    /// <summary>
    /// The medication referred to by this MedicationKnowledge is in active use within the drug database or inventory system.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/CodeSystem/medicationknowledge-status"
    };
    /// <summary>
    /// The medication referred to by this MedicationKnowledge was entered in error within the drug database or inventory system.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/CodeSystem/medicationknowledge-status"
    };
    /// <summary>
    /// The medication referred to by this MedicationKnowledge is not in active use within the drug database or inventory system.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://hl7.org/fhir/CodeSystem/medicationknowledge-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: MedicationknowledgeStatusActive
    /// </summary>
    public const string LiteralMedicationknowledgeStatusActive = "http://hl7.org/fhir/CodeSystem/medicationknowledge-status#active";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: MedicationknowledgeStatusEnteredInError
    /// </summary>
    public const string LiteralMedicationknowledgeStatusEnteredInError = "http://hl7.org/fhir/CodeSystem/medicationknowledge-status#entered-in-error";

    /// <summary>
    /// Literal for code: Inactive
    /// </summary>
    public const string LiteralInactive = "inactive";

    /// <summary>
    /// Literal for code: MedicationknowledgeStatusInactive
    /// </summary>
    public const string LiteralMedicationknowledgeStatusInactive = "http://hl7.org/fhir/CodeSystem/medicationknowledge-status#inactive";

    /// <summary>
    /// Dictionary for looking up MedicationknowledgeStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/CodeSystem/medicationknowledge-status#active", Active }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/CodeSystem/medicationknowledge-status#entered-in-error", EnteredInError }, 
      { "inactive", Inactive }, 
      { "http://hl7.org/fhir/CodeSystem/medicationknowledge-status#inactive", Inactive }, 
    };
  };
}
