// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of a property value.
  /// </summary>
  public static class ConceptPropertyTypeCodes
  {
    /// <summary>
    /// The property value is a boolean true | false.
    /// </summary>
    public static readonly Coding Boolean = new Coding
    {
      Code = "boolean",
      Display = "boolean",
      System = "http://hl7.org/fhir/concept-property-type"
    };
    /// <summary>
    /// The property value is a code that identifies a concept defined in the code system.
    /// </summary>
    public static readonly Coding CodeInternalReference = new Coding
    {
      Code = "code",
      Display = "code (internal reference)",
      System = "http://hl7.org/fhir/concept-property-type"
    };
    /// <summary>
    /// The property  value is a code defined in an external code system. This may be used for translations, but is not the intent.
    /// </summary>
    public static readonly Coding CodingExternalReference = new Coding
    {
      Code = "Coding",
      Display = "Coding (external reference)",
      System = "http://hl7.org/fhir/concept-property-type"
    };
    /// <summary>
    /// The property is a date or a date + time.
    /// </summary>
    public static readonly Coding DateTime = new Coding
    {
      Code = "dateTime",
      Display = "dateTime",
      System = "http://hl7.org/fhir/concept-property-type"
    };
    /// <summary>
    /// The property value is a decimal number.
    /// </summary>
    public static readonly Coding VALDecimal = new Coding
    {
      Code = "decimal",
      Display = "decimal",
      System = "http://hl7.org/fhir/concept-property-type"
    };
    /// <summary>
    /// The property value is an integer (often used to assign ranking values to concepts for supporting score assessments).
    /// </summary>
    public static readonly Coding Integer = new Coding
    {
      Code = "integer",
      Display = "integer",
      System = "http://hl7.org/fhir/concept-property-type"
    };
    /// <summary>
    /// The property value is a string.
    /// </summary>
    public static readonly Coding VALString = new Coding
    {
      Code = "string",
      Display = "string",
      System = "http://hl7.org/fhir/concept-property-type"
    };

    /// <summary>
    /// Literal for code: Boolean
    /// </summary>
    public const string LiteralBoolean = "boolean";

    /// <summary>
    /// Literal for code: ConceptPropertyTypeBoolean
    /// </summary>
    public const string LiteralConceptPropertyTypeBoolean = "http://hl7.org/fhir/concept-property-type#boolean";

    /// <summary>
    /// Literal for code: CodeInternalReference
    /// </summary>
    public const string LiteralCodeInternalReference = "code";

    /// <summary>
    /// Literal for code: ConceptPropertyTypeCodeInternalReference
    /// </summary>
    public const string LiteralConceptPropertyTypeCodeInternalReference = "http://hl7.org/fhir/concept-property-type#code";

    /// <summary>
    /// Literal for code: CodingExternalReference
    /// </summary>
    public const string LiteralCodingExternalReference = "Coding";

    /// <summary>
    /// Literal for code: ConceptPropertyTypeCodingExternalReference
    /// </summary>
    public const string LiteralConceptPropertyTypeCodingExternalReference = "http://hl7.org/fhir/concept-property-type#Coding";

    /// <summary>
    /// Literal for code: DateTime
    /// </summary>
    public const string LiteralDateTime = "dateTime";

    /// <summary>
    /// Literal for code: ConceptPropertyTypeDateTime
    /// </summary>
    public const string LiteralConceptPropertyTypeDateTime = "http://hl7.org/fhir/concept-property-type#dateTime";

    /// <summary>
    /// Literal for code: VALDecimal
    /// </summary>
    public const string LiteralVALDecimal = "decimal";

    /// <summary>
    /// Literal for code: ConceptPropertyTypeVALDecimal
    /// </summary>
    public const string LiteralConceptPropertyTypeVALDecimal = "http://hl7.org/fhir/concept-property-type#decimal";

    /// <summary>
    /// Literal for code: Integer
    /// </summary>
    public const string LiteralInteger = "integer";

    /// <summary>
    /// Literal for code: ConceptPropertyTypeInteger
    /// </summary>
    public const string LiteralConceptPropertyTypeInteger = "http://hl7.org/fhir/concept-property-type#integer";

    /// <summary>
    /// Literal for code: VALString
    /// </summary>
    public const string LiteralVALString = "string";

    /// <summary>
    /// Literal for code: ConceptPropertyTypeVALString
    /// </summary>
    public const string LiteralConceptPropertyTypeVALString = "http://hl7.org/fhir/concept-property-type#string";

    /// <summary>
    /// Dictionary for looking up ConceptPropertyType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "boolean", Boolean }, 
      { "http://hl7.org/fhir/concept-property-type#boolean", Boolean }, 
      { "code", CodeInternalReference }, 
      { "http://hl7.org/fhir/concept-property-type#code", CodeInternalReference }, 
      { "Coding", CodingExternalReference }, 
      { "http://hl7.org/fhir/concept-property-type#Coding", CodingExternalReference }, 
      { "dateTime", DateTime }, 
      { "http://hl7.org/fhir/concept-property-type#dateTime", DateTime }, 
      { "decimal", VALDecimal }, 
      { "http://hl7.org/fhir/concept-property-type#decimal", VALDecimal }, 
      { "integer", Integer }, 
      { "http://hl7.org/fhir/concept-property-type#integer", Integer }, 
      { "string", VALString }, 
      { "http://hl7.org/fhir/concept-property-type#string", VALString }, 
    };
  };
}
