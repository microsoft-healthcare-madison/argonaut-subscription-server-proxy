// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Type for access of external URI.
  /// </summary>
  public static class RepositoryTypeCodes
  {
    /// <summary>
    /// When URL is clicked, the resource can be seen directly (by webpage or by download link format).
    /// </summary>
    public static readonly Coding ClickAndSee = new Coding
    {
      Code = "directlink",
      Display = "Click and see",
      System = "http://hl7.org/fhir/repository-type"
    };
    /// <summary>
    /// When logged into the website, the resource can be seen.
    /// </summary>
    public static readonly Coding ResultCannotBeAccessUnlessAnAccountIsLoggedIn = new Coding
    {
      Code = "login",
      Display = "Result cannot be access unless an account is logged in",
      System = "http://hl7.org/fhir/repository-type"
    };
    /// <summary>
    /// When logged in and  follow the API in the website related with URL, the resource can be seen.
    /// </summary>
    public static readonly Coding ResultNeedToBeFetchedWithAPIAndNeedLOGINOrCookiesAreRequiredWhenVisitingTheLinkOfResource = new Coding
    {
      Code = "oauth",
      Display = "Result need to be fetched with API and need LOGIN( or cookies are required when visiting the link of resource)",
      System = "http://hl7.org/fhir/repository-type"
    };
    /// <summary>
    /// When the API method (e.g. [base_url]/[parameter]) related with the URL of the website is executed, the resource can be seen directly (usually in JSON or XML format).
    /// </summary>
    public static readonly Coding TheURLIsTheRESTfulOrOtherKindOfAPIThatCanAccessToTheResult = new Coding
    {
      Code = "openapi",
      Display = "The URL is the RESTful or other kind of API that can access to the result.",
      System = "http://hl7.org/fhir/repository-type"
    };
    /// <summary>
    /// Some other complicated or particular way to get resource from URL.
    /// </summary>
    public static readonly Coding SomeOtherComplicatedOrParticularWayToGetResourceFromURL = new Coding
    {
      Code = "other",
      Display = "Some other complicated or particular way to get resource from URL.",
      System = "http://hl7.org/fhir/repository-type"
    };

    /// <summary>
    /// Literal for code: ClickAndSee
    /// </summary>
    public const string LiteralClickAndSee = "directlink";

    /// <summary>
    /// Literal for code: RepositoryTypeClickAndSee
    /// </summary>
    public const string LiteralRepositoryTypeClickAndSee = "http://hl7.org/fhir/repository-type#directlink";

    /// <summary>
    /// Literal for code: ResultCannotBeAccessUnlessAnAccountIsLoggedIn
    /// </summary>
    public const string LiteralResultCannotBeAccessUnlessAnAccountIsLoggedIn = "login";

    /// <summary>
    /// Literal for code: RepositoryTypeResultCannotBeAccessUnlessAnAccountIsLoggedIn
    /// </summary>
    public const string LiteralRepositoryTypeResultCannotBeAccessUnlessAnAccountIsLoggedIn = "http://hl7.org/fhir/repository-type#login";

    /// <summary>
    /// Literal for code: ResultNeedToBeFetchedWithAPIAndNeedLOGINOrCookiesAreRequiredWhenVisitingTheLinkOfResource
    /// </summary>
    public const string LiteralResultNeedToBeFetchedWithAPIAndNeedLOGINOrCookiesAreRequiredWhenVisitingTheLinkOfResource = "oauth";

    /// <summary>
    /// Literal for code: RepositoryTypeResultNeedToBeFetchedWithAPIAndNeedLOGINOrCookiesAreRequiredWhenVisitingTheLinkOfResource
    /// </summary>
    public const string LiteralRepositoryTypeResultNeedToBeFetchedWithAPIAndNeedLOGINOrCookiesAreRequiredWhenVisitingTheLinkOfResource = "http://hl7.org/fhir/repository-type#oauth";

    /// <summary>
    /// Literal for code: TheURLIsTheRESTfulOrOtherKindOfAPIThatCanAccessToTheResult
    /// </summary>
    public const string LiteralTheURLIsTheRESTfulOrOtherKindOfAPIThatCanAccessToTheResult = "openapi";

    /// <summary>
    /// Literal for code: RepositoryTypeTheURLIsTheRESTfulOrOtherKindOfAPIThatCanAccessToTheResult
    /// </summary>
    public const string LiteralRepositoryTypeTheURLIsTheRESTfulOrOtherKindOfAPIThatCanAccessToTheResult = "http://hl7.org/fhir/repository-type#openapi";

    /// <summary>
    /// Literal for code: SomeOtherComplicatedOrParticularWayToGetResourceFromURL
    /// </summary>
    public const string LiteralSomeOtherComplicatedOrParticularWayToGetResourceFromURL = "other";

    /// <summary>
    /// Literal for code: RepositoryTypeSomeOtherComplicatedOrParticularWayToGetResourceFromURL
    /// </summary>
    public const string LiteralRepositoryTypeSomeOtherComplicatedOrParticularWayToGetResourceFromURL = "http://hl7.org/fhir/repository-type#other";

    /// <summary>
    /// Dictionary for looking up RepositoryType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "directlink", ClickAndSee }, 
      { "http://hl7.org/fhir/repository-type#directlink", ClickAndSee }, 
      { "login", ResultCannotBeAccessUnlessAnAccountIsLoggedIn }, 
      { "http://hl7.org/fhir/repository-type#login", ResultCannotBeAccessUnlessAnAccountIsLoggedIn }, 
      { "oauth", ResultNeedToBeFetchedWithAPIAndNeedLOGINOrCookiesAreRequiredWhenVisitingTheLinkOfResource }, 
      { "http://hl7.org/fhir/repository-type#oauth", ResultNeedToBeFetchedWithAPIAndNeedLOGINOrCookiesAreRequiredWhenVisitingTheLinkOfResource }, 
      { "openapi", TheURLIsTheRESTfulOrOtherKindOfAPIThatCanAccessToTheResult }, 
      { "http://hl7.org/fhir/repository-type#openapi", TheURLIsTheRESTfulOrOtherKindOfAPIThatCanAccessToTheResult }, 
      { "other", SomeOtherComplicatedOrParticularWayToGetResourceFromURL }, 
      { "http://hl7.org/fhir/repository-type#other", SomeOtherComplicatedOrParticularWayToGetResourceFromURL }, 
    };
  };
}
