// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// FormularyItem Status Codes
  /// </summary>
  public static class FormularyitemStatusCodes
  {
    /// <summary>
    /// The service or product referred to by this FormularyItem is in active use within the drug database or inventory system.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/CodeSystem/formularyitem-status"
    };
    /// <summary>
    /// The service or product referred to by this FormularyItem was entered in error within the drug database or inventory system.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/CodeSystem/formularyitem-status"
    };
    /// <summary>
    /// The service or product referred to by this FormularyItem is not in active use within the drug database or inventory system.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://hl7.org/fhir/CodeSystem/formularyitem-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: FormularyitemStatusActive
    /// </summary>
    public const string LiteralFormularyitemStatusActive = "http://hl7.org/fhir/CodeSystem/formularyitem-status#active";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: FormularyitemStatusEnteredInError
    /// </summary>
    public const string LiteralFormularyitemStatusEnteredInError = "http://hl7.org/fhir/CodeSystem/formularyitem-status#entered-in-error";

    /// <summary>
    /// Literal for code: Inactive
    /// </summary>
    public const string LiteralInactive = "inactive";

    /// <summary>
    /// Literal for code: FormularyitemStatusInactive
    /// </summary>
    public const string LiteralFormularyitemStatusInactive = "http://hl7.org/fhir/CodeSystem/formularyitem-status#inactive";

    /// <summary>
    /// Dictionary for looking up FormularyitemStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/CodeSystem/formularyitem-status#active", Active }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/CodeSystem/formularyitem-status#entered-in-error", EnteredInError }, 
      { "inactive", Inactive }, 
      { "http://hl7.org/fhir/CodeSystem/formularyitem-status#inactive", Inactive }, 
    };
  };
}
