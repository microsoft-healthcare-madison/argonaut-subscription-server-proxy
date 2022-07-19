// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The Participation status of an appointment.
  /// </summary>
  public static class ParticipationstatusCodes
  {
    /// <summary>
    /// The participant has accepted the appointment.
    /// </summary>
    public static readonly Coding Accepted = new Coding
    {
      Code = "accepted",
      Display = "Accepted",
      System = "http://hl7.org/fhir/participationstatus"
    };
    /// <summary>
    /// The participant has declined the appointment and will not participate in the appointment.
    /// </summary>
    public static readonly Coding Declined = new Coding
    {
      Code = "declined",
      Display = "Declined",
      System = "http://hl7.org/fhir/participationstatus"
    };
    /// <summary>
    /// The participant needs to indicate if they accept the appointment by changing this status to one of the other statuses.
    /// </summary>
    public static readonly Coding NeedsAction = new Coding
    {
      Code = "needs-action",
      Display = "Needs Action",
      System = "http://hl7.org/fhir/participationstatus"
    };
    /// <summary>
    /// The participant has  tentatively accepted the appointment. This could be automatically created by a system and requires further processing before it can be accepted. There is no commitment that attendance will occur.
    /// </summary>
    public static readonly Coding Tentative = new Coding
    {
      Code = "tentative",
      Display = "Tentative",
      System = "http://hl7.org/fhir/participationstatus"
    };

    /// <summary>
    /// Literal for code: Accepted
    /// </summary>
    public const string LiteralAccepted = "accepted";

    /// <summary>
    /// Literal for code: ParticipationstatusAccepted
    /// </summary>
    public const string LiteralParticipationstatusAccepted = "http://hl7.org/fhir/participationstatus#accepted";

    /// <summary>
    /// Literal for code: Declined
    /// </summary>
    public const string LiteralDeclined = "declined";

    /// <summary>
    /// Literal for code: ParticipationstatusDeclined
    /// </summary>
    public const string LiteralParticipationstatusDeclined = "http://hl7.org/fhir/participationstatus#declined";

    /// <summary>
    /// Literal for code: NeedsAction
    /// </summary>
    public const string LiteralNeedsAction = "needs-action";

    /// <summary>
    /// Literal for code: ParticipationstatusNeedsAction
    /// </summary>
    public const string LiteralParticipationstatusNeedsAction = "http://hl7.org/fhir/participationstatus#needs-action";

    /// <summary>
    /// Literal for code: Tentative
    /// </summary>
    public const string LiteralTentative = "tentative";

    /// <summary>
    /// Literal for code: ParticipationstatusTentative
    /// </summary>
    public const string LiteralParticipationstatusTentative = "http://hl7.org/fhir/participationstatus#tentative";

    /// <summary>
    /// Dictionary for looking up Participationstatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "accepted", Accepted }, 
      { "http://hl7.org/fhir/participationstatus#accepted", Accepted }, 
      { "declined", Declined }, 
      { "http://hl7.org/fhir/participationstatus#declined", Declined }, 
      { "needs-action", NeedsAction }, 
      { "http://hl7.org/fhir/participationstatus#needs-action", NeedsAction }, 
      { "tentative", Tentative }, 
      { "http://hl7.org/fhir/participationstatus#tentative", Tentative }, 
    };
  };
}
