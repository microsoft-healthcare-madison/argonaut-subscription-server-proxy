// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Description Needed Here
  /// </summary>
  public static class GoalRelationshipTypeCodes
  {
    /// <summary>
    /// Indicates that the target goal is considered to be a "piece" of attaining this goal.
    /// </summary>
    public static readonly Coding Milestone = new Coding
    {
      Code = "milestone",
      Display = "Milestone",
      System = "http://hl7.org/fhir/goal-relationship-type"
    };
    /// <summary>
    /// Indicates that the relationship is not covered by one of the pre-defined codes.  (An extension may convey more information about the meaning of the relationship.).
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://hl7.org/fhir/goal-relationship-type"
    };
    /// <summary>
    /// Indicates that the target goal is one which must be met before striving for the current goal.
    /// </summary>
    public static readonly Coding Predecessor = new Coding
    {
      Code = "predecessor",
      Display = "Predecessor",
      System = "http://hl7.org/fhir/goal-relationship-type"
    };
    /// <summary>
    /// Indicates that this goal has been replaced by the target goal.
    /// </summary>
    public static readonly Coding Replacement = new Coding
    {
      Code = "replacement",
      Display = "Replacement",
      System = "http://hl7.org/fhir/goal-relationship-type"
    };
    /// <summary>
    /// Indicates that the target goal is a desired objective once the current goal is met.
    /// </summary>
    public static readonly Coding Successor = new Coding
    {
      Code = "successor",
      Display = "Successor",
      System = "http://hl7.org/fhir/goal-relationship-type"
    };

    /// <summary>
    /// Literal for code: Milestone
    /// </summary>
    public const string LiteralMilestone = "milestone";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: Predecessor
    /// </summary>
    public const string LiteralPredecessor = "predecessor";

    /// <summary>
    /// Literal for code: Replacement
    /// </summary>
    public const string LiteralReplacement = "replacement";

    /// <summary>
    /// Literal for code: Successor
    /// </summary>
    public const string LiteralSuccessor = "successor";
  };
}
