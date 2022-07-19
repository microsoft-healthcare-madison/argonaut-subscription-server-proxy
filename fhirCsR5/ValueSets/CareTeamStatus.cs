// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Indicates the status of the care team.
  /// </summary>
  public static class CareTeamStatusCodes
  {
    /// <summary>
    /// The care team is currently participating in the coordination and delivery of care.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/care-team-status"
    };
    /// <summary>
    /// The care team should have never existed.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/care-team-status"
    };
    /// <summary>
    /// The care team was, but is no longer, participating in the coordination and delivery of care.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://hl7.org/fhir/care-team-status"
    };
    /// <summary>
    /// The care team has been drafted and proposed, but not yet participating in the coordination and delivery of patient care.
    /// </summary>
    public static readonly Coding Proposed = new Coding
    {
      Code = "proposed",
      Display = "Proposed",
      System = "http://hl7.org/fhir/care-team-status"
    };
    /// <summary>
    /// The care team is temporarily on hold or suspended and not participating in the coordination and delivery of care.
    /// </summary>
    public static readonly Coding Suspended = new Coding
    {
      Code = "suspended",
      Display = "Suspended",
      System = "http://hl7.org/fhir/care-team-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: CareTeamStatusActive
    /// </summary>
    public const string LiteralCareTeamStatusActive = "http://hl7.org/fhir/care-team-status#active";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: CareTeamStatusEnteredInError
    /// </summary>
    public const string LiteralCareTeamStatusEnteredInError = "http://hl7.org/fhir/care-team-status#entered-in-error";

    /// <summary>
    /// Literal for code: Inactive
    /// </summary>
    public const string LiteralInactive = "inactive";

    /// <summary>
    /// Literal for code: CareTeamStatusInactive
    /// </summary>
    public const string LiteralCareTeamStatusInactive = "http://hl7.org/fhir/care-team-status#inactive";

    /// <summary>
    /// Literal for code: Proposed
    /// </summary>
    public const string LiteralProposed = "proposed";

    /// <summary>
    /// Literal for code: CareTeamStatusProposed
    /// </summary>
    public const string LiteralCareTeamStatusProposed = "http://hl7.org/fhir/care-team-status#proposed";

    /// <summary>
    /// Literal for code: Suspended
    /// </summary>
    public const string LiteralSuspended = "suspended";

    /// <summary>
    /// Literal for code: CareTeamStatusSuspended
    /// </summary>
    public const string LiteralCareTeamStatusSuspended = "http://hl7.org/fhir/care-team-status#suspended";

    /// <summary>
    /// Dictionary for looking up CareTeamStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/care-team-status#active", Active }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/care-team-status#entered-in-error", EnteredInError }, 
      { "inactive", Inactive }, 
      { "http://hl7.org/fhir/care-team-status#inactive", Inactive }, 
      { "proposed", Proposed }, 
      { "http://hl7.org/fhir/care-team-status#proposed", Proposed }, 
      { "suspended", Suspended }, 
      { "http://hl7.org/fhir/care-team-status#suspended", Suspended }, 
    };
  };
}
