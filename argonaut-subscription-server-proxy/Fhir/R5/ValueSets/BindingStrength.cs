// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Indication of the degree of conformance expectations associated with a binding.
  /// </summary>
  public static class BindingStrengthCodes
  {
    /// <summary>
    /// Instances are not expected or even encouraged to draw from the specified value set.  The value set merely provides examples of the types of concepts intended to be included.
    /// </summary>
    public static readonly Coding Example = new Coding
    {
      Code = "example",
      Display = "Example",
      System = "http://hl7.org/fhir/binding-strength"
    };
    /// <summary>
    /// To be conformant, the concept in this element SHALL be from the specified value set if any of the codes within the value set can apply to the concept being communicated.  If the value set does not cover the concept (based on human review), alternate codings (or, data type allowing, text) may be included instead.
    /// </summary>
    public static readonly Coding Extensible = new Coding
    {
      Code = "extensible",
      Display = "Extensible",
      System = "http://hl7.org/fhir/binding-strength"
    };
    /// <summary>
    /// Instances are encouraged to draw from the specified codes for interoperability purposes but are not required to do so to be considered conformant.
    /// </summary>
    public static readonly Coding Preferred = new Coding
    {
      Code = "preferred",
      Display = "Preferred",
      System = "http://hl7.org/fhir/binding-strength"
    };
    /// <summary>
    /// To be conformant, the concept in this element SHALL be from the specified value set.
    /// </summary>
    public static readonly Coding Required = new Coding
    {
      Code = "required",
      Display = "Required",
      System = "http://hl7.org/fhir/binding-strength"
    };

    /// <summary>
    /// Literal for code: Example
    /// </summary>
    public const string LiteralExample = "example";

    /// <summary>
    /// Literal for code: Extensible
    /// </summary>
    public const string LiteralExtensible = "extensible";

    /// <summary>
    /// Literal for code: Preferred
    /// </summary>
    public const string LiteralPreferred = "preferred";

    /// <summary>
    /// Literal for code: Required
    /// </summary>
    public const string LiteralRequired = "required";
  };
}
