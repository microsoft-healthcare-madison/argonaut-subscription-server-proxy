// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes for why the study ended prematurely.
  /// </summary>
  public static class ResearchStudyReasonStoppedCodes
  {
    /// <summary>
    /// The study prematurely ended because the accrual goal was met.
    /// </summary>
    public static readonly Coding AccrualGoalMet = new Coding
    {
      Code = "accrual-goal-met",
      Display = "Accrual Goal Met",
      System = "http://terminology.hl7.org/CodeSystem/research-study-reason-stopped"
    };
    /// <summary>
    /// The study prematurely ended due to lack of study progress.
    /// </summary>
    public static readonly Coding ClosedDueToLackOfStudyProgress = new Coding
    {
      Code = "closed-due-to-lack-of-study-progress",
      Display = "Closed due to lack of study progress",
      System = "http://terminology.hl7.org/CodeSystem/research-study-reason-stopped"
    };
    /// <summary>
    /// The study prematurely ended due to toxicity.
    /// </summary>
    public static readonly Coding ClosedDueToToxicity = new Coding
    {
      Code = "closed-due-to-toxicity",
      Display = "Closed due to toxicity",
      System = "http://terminology.hl7.org/CodeSystem/research-study-reason-stopped"
    };
    /// <summary>
    /// The study prematurely ended temporarily per study design.
    /// </summary>
    public static readonly Coding TemporarilyClosedPerStudyDesign = new Coding
    {
      Code = "temporarily-closed-per-study-design",
      Display = "Temporarily closed per study design",
      System = "http://terminology.hl7.org/CodeSystem/research-study-reason-stopped"
    };

    /// <summary>
    /// Literal for code: AccrualGoalMet
    /// </summary>
    public const string LiteralAccrualGoalMet = "accrual-goal-met";

    /// <summary>
    /// Literal for code: ClosedDueToLackOfStudyProgress
    /// </summary>
    public const string LiteralClosedDueToLackOfStudyProgress = "closed-due-to-lack-of-study-progress";

    /// <summary>
    /// Literal for code: ClosedDueToToxicity
    /// </summary>
    public const string LiteralClosedDueToToxicity = "closed-due-to-toxicity";

    /// <summary>
    /// Literal for code: TemporarilyClosedPerStudyDesign
    /// </summary>
    public const string LiteralTemporarilyClosedPerStudyDesign = "temporarily-closed-per-study-design";
  };
}
