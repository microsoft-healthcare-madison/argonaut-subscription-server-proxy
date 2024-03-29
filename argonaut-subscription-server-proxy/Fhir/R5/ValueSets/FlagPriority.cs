// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set is provided as an exemplar. The value set is driven by IHE Table B.8-4: Abnormal Flags, Alert Priority.
  /// </summary>
  public static class FlagPriorityCodes
  {
    /// <summary>
    /// High priority.
    /// </summary>
    public static readonly Coding HighPriority = new Coding
    {
      Code = "PH",
      Display = "High priority",
      System = "http://hl7.org/fhir/flag-priority-code"
    };
    /// <summary>
    /// Low priority.
    /// </summary>
    public static readonly Coding LowPriority = new Coding
    {
      Code = "PL",
      Display = "Low priority",
      System = "http://hl7.org/fhir/flag-priority-code"
    };
    /// <summary>
    /// Medium priority.
    /// </summary>
    public static readonly Coding MediumPriority = new Coding
    {
      Code = "PM",
      Display = "Medium priority",
      System = "http://hl7.org/fhir/flag-priority-code"
    };
    /// <summary>
    /// No alarm.
    /// </summary>
    public static readonly Coding NoAlarm = new Coding
    {
      Code = "PN",
      Display = "No alarm",
      System = "http://hl7.org/fhir/flag-priority-code"
    };

    /// <summary>
    /// Literal for code: HighPriority
    /// </summary>
    public const string LiteralHighPriority = "PH";

    /// <summary>
    /// Literal for code: LowPriority
    /// </summary>
    public const string LiteralLowPriority = "PL";

    /// <summary>
    /// Literal for code: MediumPriority
    /// </summary>
    public const string LiteralMediumPriority = "PM";

    /// <summary>
    /// Literal for code: NoAlarm
    /// </summary>
    public const string LiteralNoAlarm = "PN";
  };
}
