// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The mode of a message capability statement.
  /// </summary>
  public static class EventCapabilityModeCodes
  {
    /// <summary>
    /// The application receives requests and sends responses.
    /// </summary>
    public static readonly Coding Receiver = new Coding
    {
      Code = "receiver",
      Display = "Receiver",
      System = "http://hl7.org/fhir/event-capability-mode"
    };
    /// <summary>
    /// The application sends requests and receives responses.
    /// </summary>
    public static readonly Coding Sender = new Coding
    {
      Code = "sender",
      Display = "Sender",
      System = "http://hl7.org/fhir/event-capability-mode"
    };

    /// <summary>
    /// Literal for code: Receiver
    /// </summary>
    public const string LiteralReceiver = "receiver";

    /// <summary>
    /// Literal for code: EventCapabilityModeReceiver
    /// </summary>
    public const string LiteralEventCapabilityModeReceiver = "http://hl7.org/fhir/event-capability-mode#receiver";

    /// <summary>
    /// Literal for code: Sender
    /// </summary>
    public const string LiteralSender = "sender";

    /// <summary>
    /// Literal for code: EventCapabilityModeSender
    /// </summary>
    public const string LiteralEventCapabilityModeSender = "http://hl7.org/fhir/event-capability-mode#sender";

    /// <summary>
    /// Dictionary for looking up EventCapabilityMode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "receiver", Receiver }, 
      { "http://hl7.org/fhir/event-capability-mode#receiver", Receiver }, 
      { "sender", Sender }, 
      { "http://hl7.org/fhir/event-capability-mode#sender", Sender }, 
    };
  };
}
