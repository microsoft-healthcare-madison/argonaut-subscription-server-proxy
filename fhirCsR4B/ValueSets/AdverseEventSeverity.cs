// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The severity of the adverse event itself, in direct relation to the subject.
  /// </summary>
  public static class AdverseEventSeverityCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Mild = new Coding
    {
      Code = "mild",
      Display = "Mild",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-severity"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Moderate = new Coding
    {
      Code = "moderate",
      Display = "Moderate",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-severity"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Severe = new Coding
    {
      Code = "severe",
      Display = "Severe",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-severity"
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
