// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Overall seriousness of this event for the patient.
  /// </summary>
  public static class AdverseEventSeriousnessCodes
  {
    /// <summary>
    /// This event is considered not to have the potential for persistent or costly injury or consequence.
    /// </summary>
    public static readonly Coding NonSerious = new Coding
    {
      Code = "non-serious",
      Display = "Non-serious",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-seriousness"
    };
    /// <summary>
    /// This event is considered to have the potential for persistent or costly injury or consequence.
    /// </summary>
    public static readonly Coding Serious = new Coding
    {
      Code = "serious",
      Display = "Serious",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-seriousness"
    };

    /// <summary>
    /// Literal for code: NonSerious
    /// </summary>
    public const string LiteralNonSerious = "non-serious";

    /// <summary>
    /// Literal for code: Serious
    /// </summary>
    public const string LiteralSerious = "serious";
  };
}
