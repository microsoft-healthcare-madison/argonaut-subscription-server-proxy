// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Defines which action to take if there is no match in the group.
  /// </summary>
  public static class Conceptmap2UnmappedModeCodes
  {
    /// <summary>
    /// Use the code(s) explicitly provided in the group.unmapped 'code' or 'valueSet' element.
    /// </summary>
    public static readonly Coding FixedCode = new Coding
    {
      Code = "fixed",
      Display = "Fixed Code",
      System = "http://hl7.org/fhir/conceptmap2-unmapped-mode"
    };
    /// <summary>
    /// Use the map identified by the canonical URL in the url element.
    /// </summary>
    public static readonly Coding OtherMap = new Coding
    {
      Code = "other-map",
      Display = "Other Map",
      System = "http://hl7.org/fhir/conceptmap2-unmapped-mode"
    };
    /// <summary>
    /// Use the code as provided in the $translate request in one of the following input parameters: sourceCode, sourceCoding, sourceCodeableConcept.
    /// </summary>
    public static readonly Coding UseProvidedSourceCode = new Coding
    {
      Code = "use-source-code",
      Display = "Use Provided Source Code",
      System = "http://hl7.org/fhir/conceptmap2-unmapped-mode"
    };

    /// <summary>
    /// Literal for code: FixedCode
    /// </summary>
    public const string LiteralFixedCode = "fixed";

    /// <summary>
    /// Literal for code: Conceptmap2UnmappedModeFixedCode
    /// </summary>
    public const string LiteralConceptmap2UnmappedModeFixedCode = "http://hl7.org/fhir/conceptmap2-unmapped-mode#fixed";

    /// <summary>
    /// Literal for code: OtherMap
    /// </summary>
    public const string LiteralOtherMap = "other-map";

    /// <summary>
    /// Literal for code: Conceptmap2UnmappedModeOtherMap
    /// </summary>
    public const string LiteralConceptmap2UnmappedModeOtherMap = "http://hl7.org/fhir/conceptmap2-unmapped-mode#other-map";

    /// <summary>
    /// Literal for code: UseProvidedSourceCode
    /// </summary>
    public const string LiteralUseProvidedSourceCode = "use-source-code";

    /// <summary>
    /// Literal for code: Conceptmap2UnmappedModeUseProvidedSourceCode
    /// </summary>
    public const string LiteralConceptmap2UnmappedModeUseProvidedSourceCode = "http://hl7.org/fhir/conceptmap2-unmapped-mode#use-source-code";

    /// <summary>
    /// Dictionary for looking up Conceptmap2UnmappedMode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "fixed", FixedCode }, 
      { "http://hl7.org/fhir/conceptmap2-unmapped-mode#fixed", FixedCode }, 
      { "other-map", OtherMap }, 
      { "http://hl7.org/fhir/conceptmap2-unmapped-mode#other-map", OtherMap }, 
      { "use-source-code", UseProvidedSourceCode }, 
      { "http://hl7.org/fhir/conceptmap2-unmapped-mode#use-source-code", UseProvidedSourceCode }, 
    };
  };
}