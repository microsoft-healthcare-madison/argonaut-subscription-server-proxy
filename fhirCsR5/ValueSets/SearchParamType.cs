// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Data types allowed to be used for search parameters.
  /// </summary>
  public static class SearchParamTypeCodes
  {
    /// <summary>
    /// A composite search parameter that combines a search on two values together.
    /// </summary>
    public static readonly Coding Composite = new Coding
    {
      Code = "composite",
      Display = "Composite",
      System = "http://hl7.org/fhir/search-param-type"
    };
    /// <summary>
    /// Search parameter is on a date/time. The date format is the standard XML format, though other formats may be supported.
    /// </summary>
    public static readonly Coding DateDateTime = new Coding
    {
      Code = "date",
      Display = "Date/DateTime",
      System = "http://hl7.org/fhir/search-param-type"
    };
    /// <summary>
    /// Search parameter SHALL be a number (a whole number, or a decimal).
    /// </summary>
    public static readonly Coding Number = new Coding
    {
      Code = "number",
      Display = "Number",
      System = "http://hl7.org/fhir/search-param-type"
    };
    /// <summary>
    /// A search parameter that searches on a quantity.
    /// </summary>
    public static readonly Coding Quantity = new Coding
    {
      Code = "quantity",
      Display = "Quantity",
      System = "http://hl7.org/fhir/search-param-type"
    };
    /// <summary>
    /// A reference to another resource (Reference or canonical).
    /// </summary>
    public static readonly Coding Reference = new Coding
    {
      Code = "reference",
      Display = "Reference",
      System = "http://hl7.org/fhir/search-param-type"
    };
    /// <summary>
    /// Special logic applies to this parameter per the description of the search parameter.
    /// </summary>
    public static readonly Coding Special = new Coding
    {
      Code = "special",
      Display = "Special",
      System = "http://hl7.org/fhir/search-param-type"
    };
    /// <summary>
    /// Search parameter is a simple string, like a name part. Search is case-insensitive and accent-insensitive. May match just the start of a string. String parameters may contain spaces.
    /// </summary>
    public static readonly Coding String = new Coding
    {
      Code = "string",
      Display = "String",
      System = "http://hl7.org/fhir/search-param-type"
    };
    /// <summary>
    /// Search parameter on a coded element or identifier. May be used to search through the text, display, code and code/codesystem (for codes) and label, system and key (for identifier). Its value is either a string or a pair of namespace and value, separated by a "|", depending on the modifier used.
    /// </summary>
    public static readonly Coding Token = new Coding
    {
      Code = "token",
      Display = "Token",
      System = "http://hl7.org/fhir/search-param-type"
    };
    /// <summary>
    /// A search parameter that searches on a URI (RFC 3986).
    /// </summary>
    public static readonly Coding URI = new Coding
    {
      Code = "uri",
      Display = "URI",
      System = "http://hl7.org/fhir/search-param-type"
    };

    /// <summary>
    /// Literal for code: Composite
    /// </summary>
    public const string LiteralComposite = "composite";

    /// <summary>
    /// Literal for code: SearchParamTypeComposite
    /// </summary>
    public const string LiteralSearchParamTypeComposite = "http://hl7.org/fhir/search-param-type#composite";

    /// <summary>
    /// Literal for code: DateDateTime
    /// </summary>
    public const string LiteralDateDateTime = "date";

    /// <summary>
    /// Literal for code: SearchParamTypeDateDateTime
    /// </summary>
    public const string LiteralSearchParamTypeDateDateTime = "http://hl7.org/fhir/search-param-type#date";

    /// <summary>
    /// Literal for code: Number
    /// </summary>
    public const string LiteralNumber = "number";

    /// <summary>
    /// Literal for code: SearchParamTypeNumber
    /// </summary>
    public const string LiteralSearchParamTypeNumber = "http://hl7.org/fhir/search-param-type#number";

    /// <summary>
    /// Literal for code: Quantity
    /// </summary>
    public const string LiteralQuantity = "quantity";

    /// <summary>
    /// Literal for code: SearchParamTypeQuantity
    /// </summary>
    public const string LiteralSearchParamTypeQuantity = "http://hl7.org/fhir/search-param-type#quantity";

    /// <summary>
    /// Literal for code: Reference
    /// </summary>
    public const string LiteralReference = "reference";

    /// <summary>
    /// Literal for code: SearchParamTypeReference
    /// </summary>
    public const string LiteralSearchParamTypeReference = "http://hl7.org/fhir/search-param-type#reference";

    /// <summary>
    /// Literal for code: Special
    /// </summary>
    public const string LiteralSpecial = "special";

    /// <summary>
    /// Literal for code: SearchParamTypeSpecial
    /// </summary>
    public const string LiteralSearchParamTypeSpecial = "http://hl7.org/fhir/search-param-type#special";

    /// <summary>
    /// Literal for code: String
    /// </summary>
    public const string LiteralString = "string";

    /// <summary>
    /// Literal for code: SearchParamTypeString
    /// </summary>
    public const string LiteralSearchParamTypeString = "http://hl7.org/fhir/search-param-type#string";

    /// <summary>
    /// Literal for code: Token
    /// </summary>
    public const string LiteralToken = "token";

    /// <summary>
    /// Literal for code: SearchParamTypeToken
    /// </summary>
    public const string LiteralSearchParamTypeToken = "http://hl7.org/fhir/search-param-type#token";

    /// <summary>
    /// Literal for code: URI
    /// </summary>
    public const string LiteralURI = "uri";

    /// <summary>
    /// Literal for code: SearchParamTypeURI
    /// </summary>
    public const string LiteralSearchParamTypeURI = "http://hl7.org/fhir/search-param-type#uri";

    /// <summary>
    /// Dictionary for looking up SearchParamType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "composite", Composite }, 
      { "http://hl7.org/fhir/search-param-type#composite", Composite }, 
      { "date", DateDateTime }, 
      { "http://hl7.org/fhir/search-param-type#date", DateDateTime }, 
      { "number", Number }, 
      { "http://hl7.org/fhir/search-param-type#number", Number }, 
      { "quantity", Quantity }, 
      { "http://hl7.org/fhir/search-param-type#quantity", Quantity }, 
      { "reference", Reference }, 
      { "http://hl7.org/fhir/search-param-type#reference", Reference }, 
      { "special", Special }, 
      { "http://hl7.org/fhir/search-param-type#special", Special }, 
      { "string", String }, 
      { "http://hl7.org/fhir/search-param-type#string", String }, 
      { "token", Token }, 
      { "http://hl7.org/fhir/search-param-type#token", Token }, 
      { "uri", URI }, 
      { "http://hl7.org/fhir/search-param-type#uri", URI }, 
    };
  };
}
