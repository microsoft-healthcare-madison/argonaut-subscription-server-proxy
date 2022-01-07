// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The location, in Bundle.entry, where URLs for resources should be located.
  /// </summary>
  public static class SubscriptionUrlLocationCodes
  {
    /// <summary>
    /// URLS should be filled out in all available locations.
    /// </summary>
    public static readonly Coding All = new Coding
    {
      Code = "all",
      Display = "all",
      System = "http://hl7.org/fhir/subscription-url-location"
    };
    /// <summary>
    /// URLs should be placed in Bundle.entry.fullUrl.
    /// </summary>
    public static readonly Coding FullUrl = new Coding
    {
      Code = "full-url",
      Display = "full-url",
      System = "http://hl7.org/fhir/subscription-url-location"
    };
    /// <summary>
    /// URLs should NOT be included in notifications.
    /// </summary>
    public static readonly Coding None = new Coding
    {
      Code = "none",
      Display = "none",
      System = "http://hl7.org/fhir/subscription-url-location"
    };
    /// <summary>
    /// URLs should be placed in Bundle.entry.request and/or Bundle.entry.response.
    /// </summary>
    public static readonly Coding RequestResponse = new Coding
    {
      Code = "request-response",
      Display = "request-response",
      System = "http://hl7.org/fhir/subscription-url-location"
    };

    /// <summary>
    /// Literal for code: All
    /// </summary>
    public const string LiteralAll = "all";

    /// <summary>
    /// Literal for code: SubscriptionUrlLocationAll
    /// </summary>
    public const string LiteralSubscriptionUrlLocationAll = "http://hl7.org/fhir/subscription-url-location#all";

    /// <summary>
    /// Literal for code: FullUrl
    /// </summary>
    public const string LiteralFullUrl = "full-url";

    /// <summary>
    /// Literal for code: SubscriptionUrlLocationFullUrl
    /// </summary>
    public const string LiteralSubscriptionUrlLocationFullUrl = "http://hl7.org/fhir/subscription-url-location#full-url";

    /// <summary>
    /// Literal for code: None
    /// </summary>
    public const string LiteralNone = "none";

    /// <summary>
    /// Literal for code: SubscriptionUrlLocationNone
    /// </summary>
    public const string LiteralSubscriptionUrlLocationNone = "http://hl7.org/fhir/subscription-url-location#none";

    /// <summary>
    /// Literal for code: RequestResponse
    /// </summary>
    public const string LiteralRequestResponse = "request-response";

    /// <summary>
    /// Literal for code: SubscriptionUrlLocationRequestResponse
    /// </summary>
    public const string LiteralSubscriptionUrlLocationRequestResponse = "http://hl7.org/fhir/subscription-url-location#request-response";

    /// <summary>
    /// Dictionary for looking up SubscriptionUrlLocation Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "all", All }, 
      { "http://hl7.org/fhir/subscription-url-location#all", All }, 
      { "full-url", FullUrl }, 
      { "http://hl7.org/fhir/subscription-url-location#full-url", FullUrl }, 
      { "none", None }, 
      { "http://hl7.org/fhir/subscription-url-location#none", None }, 
      { "request-response", RequestResponse }, 
      { "http://hl7.org/fhir/subscription-url-location#request-response", RequestResponse }, 
    };
  };
}
