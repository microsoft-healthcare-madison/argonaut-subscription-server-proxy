// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Description Needed Here
  /// </summary>
  public static class ReactionEventCertaintyCodes
  {
    /// <summary>
    /// There is a very high level of clinical certainty that the reaction was due to the identified substance, which may include clinical evidence by testing or rechallenge.
    /// </summary>
    public static readonly Coding Confirmed = new Coding
    {
      Code = "confirmed",
      Display = "Confirmed",
      System = "http://hl7.org/fhir/reaction-event-certainty"
    };
    /// <summary>
    /// There is a high level of clinical certainty that the reaction was caused by the identified substance.
    /// </summary>
    public static readonly Coding Likely = new Coding
    {
      Code = "likely",
      Display = "Likely",
      System = "http://hl7.org/fhir/reaction-event-certainty"
    };
    /// <summary>
    /// The clinical certainty that the reaction was caused by the identified substance is unknown.  It is an explicit assertion that certainty is not known.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/reaction-event-certainty"
    };
    /// <summary>
    /// There is a low level of clinical certainty that the reaction was caused by the identified substance.
    /// </summary>
    public static readonly Coding Unlikely = new Coding
    {
      Code = "unlikely",
      Display = "Unlikely",
      System = "http://hl7.org/fhir/reaction-event-certainty"
    };

    /// <summary>
    /// Literal for code: Confirmed
    /// </summary>
    public const string LiteralConfirmed = "confirmed";

    /// <summary>
    /// Literal for code: Likely
    /// </summary>
    public const string LiteralLikely = "likely";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: Unlikely
    /// </summary>
    public const string LiteralUnlikely = "unlikely";
  };
}