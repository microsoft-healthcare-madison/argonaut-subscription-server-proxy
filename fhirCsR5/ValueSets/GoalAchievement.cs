// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Describes the progression, or lack thereof, towards the goal against the target.
  /// </summary>
  public static class GoalAchievementCodes
  {
    /// <summary>
    /// Achieved
    /// </summary>
    public static readonly Coding Achieved = new Coding
    {
      Code = "achieved",
      Display = "Achieved",
      System = "http://terminology.hl7.org/CodeSystem/goal-achievement"
    };
    /// <summary>
    /// Improving
    /// </summary>
    public static readonly Coding Improving = new Coding
    {
      Code = "improving",
      Display = "Improving",
      System = "http://terminology.hl7.org/CodeSystem/goal-achievement"
    };
    /// <summary>
    /// In Progress
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://terminology.hl7.org/CodeSystem/goal-achievement"
    };
    /// <summary>
    /// No Change
    /// </summary>
    public static readonly Coding NoChange = new Coding
    {
      Code = "no-change",
      Display = "No Change",
      System = "http://terminology.hl7.org/CodeSystem/goal-achievement"
    };
    /// <summary>
    /// No Progress
    /// </summary>
    public static readonly Coding NoProgress = new Coding
    {
      Code = "no-progress",
      Display = "No Progress",
      System = "http://terminology.hl7.org/CodeSystem/goal-achievement"
    };
    /// <summary>
    /// Not Achieved
    /// </summary>
    public static readonly Coding NotAchieved = new Coding
    {
      Code = "not-achieved",
      Display = "Not Achieved",
      System = "http://terminology.hl7.org/CodeSystem/goal-achievement"
    };
    /// <summary>
    /// Not Attainable
    /// </summary>
    public static readonly Coding NotAttainable = new Coding
    {
      Code = "not-attainable",
      Display = "Not Attainable",
      System = "http://terminology.hl7.org/CodeSystem/goal-achievement"
    };
    /// <summary>
    /// Sustaining
    /// </summary>
    public static readonly Coding Sustaining = new Coding
    {
      Code = "sustaining",
      Display = "Sustaining",
      System = "http://terminology.hl7.org/CodeSystem/goal-achievement"
    };
    /// <summary>
    /// Worsening
    /// </summary>
    public static readonly Coding Worsening = new Coding
    {
      Code = "worsening",
      Display = "Worsening",
      System = "http://terminology.hl7.org/CodeSystem/goal-achievement"
    };

    /// <summary>
    /// Literal for code: Achieved
    /// </summary>
    public const string LiteralAchieved = "achieved";

    /// <summary>
    /// Literal for code: GoalAchievementAchieved
    /// </summary>
    public const string LiteralGoalAchievementAchieved = "http://terminology.hl7.org/CodeSystem/goal-achievement#achieved";

    /// <summary>
    /// Literal for code: Improving
    /// </summary>
    public const string LiteralImproving = "improving";

    /// <summary>
    /// Literal for code: GoalAchievementImproving
    /// </summary>
    public const string LiteralGoalAchievementImproving = "http://terminology.hl7.org/CodeSystem/goal-achievement#improving";

    /// <summary>
    /// Literal for code: InProgress
    /// </summary>
    public const string LiteralInProgress = "in-progress";

    /// <summary>
    /// Literal for code: GoalAchievementInProgress
    /// </summary>
    public const string LiteralGoalAchievementInProgress = "http://terminology.hl7.org/CodeSystem/goal-achievement#in-progress";

    /// <summary>
    /// Literal for code: NoChange
    /// </summary>
    public const string LiteralNoChange = "no-change";

    /// <summary>
    /// Literal for code: GoalAchievementNoChange
    /// </summary>
    public const string LiteralGoalAchievementNoChange = "http://terminology.hl7.org/CodeSystem/goal-achievement#no-change";

    /// <summary>
    /// Literal for code: NoProgress
    /// </summary>
    public const string LiteralNoProgress = "no-progress";

    /// <summary>
    /// Literal for code: GoalAchievementNoProgress
    /// </summary>
    public const string LiteralGoalAchievementNoProgress = "http://terminology.hl7.org/CodeSystem/goal-achievement#no-progress";

    /// <summary>
    /// Literal for code: NotAchieved
    /// </summary>
    public const string LiteralNotAchieved = "not-achieved";

    /// <summary>
    /// Literal for code: GoalAchievementNotAchieved
    /// </summary>
    public const string LiteralGoalAchievementNotAchieved = "http://terminology.hl7.org/CodeSystem/goal-achievement#not-achieved";

    /// <summary>
    /// Literal for code: NotAttainable
    /// </summary>
    public const string LiteralNotAttainable = "not-attainable";

    /// <summary>
    /// Literal for code: GoalAchievementNotAttainable
    /// </summary>
    public const string LiteralGoalAchievementNotAttainable = "http://terminology.hl7.org/CodeSystem/goal-achievement#not-attainable";

    /// <summary>
    /// Literal for code: Sustaining
    /// </summary>
    public const string LiteralSustaining = "sustaining";

    /// <summary>
    /// Literal for code: GoalAchievementSustaining
    /// </summary>
    public const string LiteralGoalAchievementSustaining = "http://terminology.hl7.org/CodeSystem/goal-achievement#sustaining";

    /// <summary>
    /// Literal for code: Worsening
    /// </summary>
    public const string LiteralWorsening = "worsening";

    /// <summary>
    /// Literal for code: GoalAchievementWorsening
    /// </summary>
    public const string LiteralGoalAchievementWorsening = "http://terminology.hl7.org/CodeSystem/goal-achievement#worsening";

    /// <summary>
    /// Dictionary for looking up GoalAchievement Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "achieved", Achieved }, 
      { "http://terminology.hl7.org/CodeSystem/goal-achievement#achieved", Achieved }, 
      { "improving", Improving }, 
      { "http://terminology.hl7.org/CodeSystem/goal-achievement#improving", Improving }, 
      { "in-progress", InProgress }, 
      { "http://terminology.hl7.org/CodeSystem/goal-achievement#in-progress", InProgress }, 
      { "no-change", NoChange }, 
      { "http://terminology.hl7.org/CodeSystem/goal-achievement#no-change", NoChange }, 
      { "no-progress", NoProgress }, 
      { "http://terminology.hl7.org/CodeSystem/goal-achievement#no-progress", NoProgress }, 
      { "not-achieved", NotAchieved }, 
      { "http://terminology.hl7.org/CodeSystem/goal-achievement#not-achieved", NotAchieved }, 
      { "not-attainable", NotAttainable }, 
      { "http://terminology.hl7.org/CodeSystem/goal-achievement#not-attainable", NotAttainable }, 
      { "sustaining", Sustaining }, 
      { "http://terminology.hl7.org/CodeSystem/goal-achievement#sustaining", Sustaining }, 
      { "worsening", Worsening }, 
      { "http://terminology.hl7.org/CodeSystem/goal-achievement#worsening", Worsening }, 
    };
  };
}
