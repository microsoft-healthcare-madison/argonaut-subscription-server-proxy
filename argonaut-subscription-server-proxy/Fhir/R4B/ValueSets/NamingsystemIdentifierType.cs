// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Identifies the style of unique identifier used to identify a namespace.
  /// </summary>
  public static class NamingsystemIdentifierTypeCodes
  {
    /// <summary>
    /// An ISO object identifier; e.g. 1.2.3.4.5.
    /// </summary>
    public static readonly Coding OID = new Coding
    {
      Code = "oid",
      Display = "OID",
      System = "http://hl7.org/fhir/namingsystem-identifier-type"
    };
    /// <summary>
    /// Some other type of unique identifier; e.g. HL7-assigned reserved string such as LN for LOINC.
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://hl7.org/fhir/namingsystem-identifier-type"
    };
    /// <summary>
    /// A uniform resource identifier (ideally a URL - uniform resource locator); e.g. http://unitsofmeasure.org.
    /// </summary>
    public static readonly Coding URI = new Coding
    {
      Code = "uri",
      Display = "URI",
      System = "http://hl7.org/fhir/namingsystem-identifier-type"
    };
    /// <summary>
    /// A universally unique identifier of the form a5afddf4-e880-459b-876e-e4591b0acc11.
    /// </summary>
    public static readonly Coding UUID = new Coding
    {
      Code = "uuid",
      Display = "UUID",
      System = "http://hl7.org/fhir/namingsystem-identifier-type"
    };

    /// <summary>
    /// Literal for code: OID
    /// </summary>
    public const string LiteralOID = "oid";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: URI
    /// </summary>
    public const string LiteralURI = "uri";

    /// <summary>
    /// Literal for code: UUID
    /// </summary>
    public const string LiteralUUID = "uuid";
  };
}
