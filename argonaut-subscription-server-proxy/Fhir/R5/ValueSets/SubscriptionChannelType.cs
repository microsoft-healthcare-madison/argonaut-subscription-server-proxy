// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Core-defined FHIR channel types allowed for use in Subscriptions.
  /// </summary>
  public static class SubscriptionChannelTypeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Email = new Coding
    {
      Code = "email",
      Display = "Email",
      System = "http://terminology.hl7.org/CodeSystem/subscription-channel-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Message = new Coding
    {
      Code = "message",
      Display = "Message",
      System = "http://terminology.hl7.org/CodeSystem/subscription-channel-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding RestHook = new Coding
    {
      Code = "rest-hook",
      Display = "Rest Hook",
      System = "http://terminology.hl7.org/CodeSystem/subscription-channel-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Websocket = new Coding
    {
      Code = "websocket",
      Display = "Websocket",
      System = "http://terminology.hl7.org/CodeSystem/subscription-channel-type"
    };

    /// <summary>
    /// Literal for code: Email
    /// </summary>
    public const string LiteralEmail = "email";

    /// <summary>
    /// Literal for code: Message
    /// </summary>
    public const string LiteralMessage = "message";

    /// <summary>
    /// Literal for code: RestHook
    /// </summary>
    public const string LiteralRestHook = "rest-hook";

    /// <summary>
    /// Literal for code: Websocket
    /// </summary>
    public const string LiteralWebsocket = "websocket";
  };
}
