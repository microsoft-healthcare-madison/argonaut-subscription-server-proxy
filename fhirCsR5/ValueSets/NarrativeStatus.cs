// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The status of a resource narrative.
  /// </summary>
  public static class NarrativeStatusCodes
  {
    /// <summary>
    /// The contents of the narrative may contain additional information not found in the structured data. Note that there is no computable way to determine what the extra information is, other than by human inspection.
    /// </summary>
    public static readonly Coding Additional = new Coding
    {
      Code = "additional",
      Display = "Additional",
      System = "http://hl7.org/fhir/narrative-status"
    };
    /// <summary>
    /// The contents of the narrative are some equivalent of "No human-readable text provided in this case".
    /// </summary>
    public static readonly Coding Empty = new Coding
    {
      Code = "empty",
      Display = "Empty",
      System = "http://hl7.org/fhir/narrative-status"
    };
    /// <summary>
    /// The contents of the narrative are entirely generated from the core elements in the content and some of the content is generated from extensions. The narrative SHALL reflect the impact of all modifier extensions.
    /// </summary>
    public static readonly Coding Extensions = new Coding
    {
      Code = "extensions",
      Display = "Extensions",
      System = "http://hl7.org/fhir/narrative-status"
    };
    /// <summary>
    /// The contents of the narrative are entirely generated from the core elements in the content.
    /// </summary>
    public static readonly Coding Generated = new Coding
    {
      Code = "generated",
      Display = "Generated",
      System = "http://hl7.org/fhir/narrative-status"
    };

    /// <summary>
    /// Literal for code: Additional
    /// </summary>
    public const string LiteralAdditional = "additional";

    /// <summary>
    /// Literal for code: NarrativeStatusAdditional
    /// </summary>
    public const string LiteralNarrativeStatusAdditional = "http://hl7.org/fhir/narrative-status#additional";

    /// <summary>
    /// Literal for code: Empty
    /// </summary>
    public const string LiteralEmpty = "empty";

    /// <summary>
    /// Literal for code: NarrativeStatusEmpty
    /// </summary>
    public const string LiteralNarrativeStatusEmpty = "http://hl7.org/fhir/narrative-status#empty";

    /// <summary>
    /// Literal for code: Extensions
    /// </summary>
    public const string LiteralExtensions = "extensions";

    /// <summary>
    /// Literal for code: NarrativeStatusExtensions
    /// </summary>
    public const string LiteralNarrativeStatusExtensions = "http://hl7.org/fhir/narrative-status#extensions";

    /// <summary>
    /// Literal for code: Generated
    /// </summary>
    public const string LiteralGenerated = "generated";

    /// <summary>
    /// Literal for code: NarrativeStatusGenerated
    /// </summary>
    public const string LiteralNarrativeStatusGenerated = "http://hl7.org/fhir/narrative-status#generated";

    /// <summary>
    /// Dictionary for looking up NarrativeStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "additional", Additional }, 
      { "http://hl7.org/fhir/narrative-status#additional", Additional }, 
      { "empty", Empty }, 
      { "http://hl7.org/fhir/narrative-status#empty", Empty }, 
      { "extensions", Extensions }, 
      { "http://hl7.org/fhir/narrative-status#extensions", Extensions }, 
      { "generated", Generated }, 
      { "http://hl7.org/fhir/narrative-status#generated", Generated }, 
    };
  };
}
