// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// How a property is represented when serialized.
  /// </summary>
  public static class PropertyRepresentationCodes
  {
    /// <summary>
    /// Use CDA narrative instead of XHTML.
    /// </summary>
    public static readonly Coding CDATextFormat = new Coding
    {
      Code = "cdaText",
      Display = "CDA Text Format",
      System = "http://hl7.org/fhir/property-representation"
    };
    /// <summary>
    /// The type of this element is indicated using xsi:type.
    /// </summary>
    public static readonly Coding TypeAttribute = new Coding
    {
      Code = "typeAttr",
      Display = "Type Attribute",
      System = "http://hl7.org/fhir/property-representation"
    };
    /// <summary>
    /// The property is represented using XHTML.
    /// </summary>
    public static readonly Coding XHTML = new Coding
    {
      Code = "xhtml",
      Display = "XHTML",
      System = "http://hl7.org/fhir/property-representation"
    };
    /// <summary>
    /// In XML, this property is represented as an attribute not an element.
    /// </summary>
    public static readonly Coding XMLAttribute = new Coding
    {
      Code = "xmlAttr",
      Display = "XML Attribute",
      System = "http://hl7.org/fhir/property-representation"
    };
    /// <summary>
    /// This element is represented using the XML text attribute (primitives only).
    /// </summary>
    public static readonly Coding XMLText = new Coding
    {
      Code = "xmlText",
      Display = "XML Text",
      System = "http://hl7.org/fhir/property-representation"
    };

    /// <summary>
    /// Literal for code: CDATextFormat
    /// </summary>
    public const string LiteralCDATextFormat = "cdaText";

    /// <summary>
    /// Literal for code: TypeAttribute
    /// </summary>
    public const string LiteralTypeAttribute = "typeAttr";

    /// <summary>
    /// Literal for code: XHTML
    /// </summary>
    public const string LiteralXHTML = "xhtml";

    /// <summary>
    /// Literal for code: XMLAttribute
    /// </summary>
    public const string LiteralXMLAttribute = "xmlAttr";

    /// <summary>
    /// Literal for code: XMLText
    /// </summary>
    public const string LiteralXMLText = "xmlText";
  };
}
