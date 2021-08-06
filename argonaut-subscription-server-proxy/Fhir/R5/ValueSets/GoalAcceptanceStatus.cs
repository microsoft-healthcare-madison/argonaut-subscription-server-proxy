// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Description Needed Here
  /// </summary>
  public static class GoalAcceptanceStatusCodes
  {
    /// <summary>
    /// Stakeholder supports pursuit of the goal.
    /// </summary>
    public static readonly Coding Agree = new Coding
    {
      Code = "agree",
      Display = "Agree",
      System = "http://hl7.org/fhir/goal-acceptance-status"
    };
    /// <summary>
    /// Stakeholder is not in support of the pursuit of the goal.
    /// </summary>
    public static readonly Coding Disagree = new Coding
    {
      Code = "disagree",
      Display = "Disagree",
      System = "http://hl7.org/fhir/goal-acceptance-status"
    };
    /// <summary>
    /// Stakeholder has not yet made a decision on whether they support the goal.
    /// </summary>
    public static readonly Coding Pending = new Coding
    {
      Code = "pending",
      Display = "Pending",
      System = "http://hl7.org/fhir/goal-acceptance-status"
    };

    /// <summary>
    /// Literal for code: Agree
    /// </summary>
    public const string LiteralAgree = "agree";

    /// <summary>
    /// Literal for code: Disagree
    /// </summary>
    public const string LiteralDisagree = "disagree";

    /// <summary>
    /// Literal for code: Pending
    /// </summary>
    public const string LiteralPending = "pending";
  };
}