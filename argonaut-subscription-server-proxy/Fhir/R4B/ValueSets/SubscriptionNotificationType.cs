// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The type of notification represented by the status message.
  /// </summary>
  public static class SubscriptionNotificationTypeCodes
  {
    /// <summary>
    /// The status was generated for an event to the subscriber.
    /// </summary>
    public static readonly Coding EventNotification = new Coding
    {
      Code = "event-notification",
      Display = "Event Notification",
      System = "http://hl7.org/fhir/subscription-notification-type"
    };
    /// <summary>
    /// The status was generated as part of the setup or verification of a communications channel.
    /// </summary>
    public static readonly Coding Handshake = new Coding
    {
      Code = "handshake",
      Display = "Handshake",
      System = "http://hl7.org/fhir/subscription-notification-type"
    };
    /// <summary>
    /// The status was generated to perform a heartbeat notification to the subscriber.
    /// </summary>
    public static readonly Coding Heartbeat = new Coding
    {
      Code = "heartbeat",
      Display = "Heartbeat",
      System = "http://hl7.org/fhir/subscription-notification-type"
    };
    /// <summary>
    /// The status was generated in response to a query/request.
    /// </summary>
    public static readonly Coding QueryStatus = new Coding
    {
      Code = "query-status",
      Display = "Query Status",
      System = "http://hl7.org/fhir/subscription-notification-type"
    };

    /// <summary>The status was generated in response to an event query.</summary>
    public static readonly Coding QueryEvent = new Coding
    {
        Code = "query-event",
        Display = "Query Event",
        System = "http://hl7.org/fhir/subscription-notification-type"
    };

    /// <summary>
    /// Literal for code: EventNotification
    /// </summary>
    public const string LiteralEventNotification = "event-notification";

    /// <summary>
    /// Literal for code: Handshake
    /// </summary>
    public const string LiteralHandshake = "handshake";

    /// <summary>
    /// Literal for code: Heartbeat
    /// </summary>
    public const string LiteralHeartbeat = "heartbeat";

    /// <summary>
    /// Literal for code: QueryStatus
    /// </summary>
    public const string LiteralQueryStatus = "query-status";

    /// <summary>The literal query event.</summary>
    public const string LiteralQueryEvent = "query-event";
    };
}
