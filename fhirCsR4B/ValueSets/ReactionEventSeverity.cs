// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Clinical assessment of the severity of a reaction event as a whole, potentially considering multiple different manifestations.
  /// </summary>
  public static class ReactionEventSeverityCodes
  {
    /// <summary>
    /// Causes mild physiological effects.
    /// </summary>
    public static readonly Coding Mild = new Coding
    {
      Code = "mild",
      Display = "Mild",
      System = "http://hl7.org/fhir/reaction-event-severity"
    };
    /// <summary>
    /// Causes moderate physiological effects.
    /// </summary>
    public static readonly Coding Moderate = new Coding
    {
      Code = "moderate",
      Display = "Moderate",
      System = "http://hl7.org/fhir/reaction-event-severity"
    };
    /// <summary>
    /// Causes severe physiological effects.
    /// </summary>
    public static readonly Coding Severe = new Coding
    {
      Code = "severe",
      Display = "Severe",
      System = "http://hl7.org/fhir/reaction-event-severity"
    };

    /// <summary>
    /// Literal for code: Mild
    /// </summary>
    public const string LiteralMild = "mild";

    /// <summary>
    /// Literal for code: Moderate
    /// </summary>
    public const string LiteralModerate = "moderate";

    /// <summary>
    /// Literal for code: Severe
    /// </summary>
    public const string LiteralSevere = "severe";
  };
}
