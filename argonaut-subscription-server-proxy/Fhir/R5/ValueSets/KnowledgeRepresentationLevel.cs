// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// A knowledge representation level, narrative, semi-structured, structured, and executable
  /// </summary>
  public static class KnowledgeRepresentationLevelCodes
  {
    /// <summary>
    /// The knowledge is expressed in a way that is coded and interpretable by CDS systems using a variety of formats, affording direct executability, but potentially limited shareability. The knowledge is typically expressed focusing on a specific delivery method (modality), technology platform, and implementation environment. Knowledge at this level is typically built and developed by implementers working in specific technology platforms, for the purpose of implementation at a specific site, though affordances such as computable mappings and configuration capabilities can broaden the usability of the knowledge artifact.
    /// </summary>
    public static readonly Coding Executable = new Coding
    {
      Code = "executable",
      Display = "Executable",
      System = "http://hl7.org/fhir/CodeSystem/knowledge-representation-level"
    };
    /// <summary>
    /// The knowledge is expressed as narrative text, affording broad shareability, but limited computability. The knowledge is typically expressed independent of delivery method (modality), technology platform, and implementation site. Knowledge at this level is typically authored by guideline developers for a broad range of purposes including communication of policy, synthesis of evidence, and dissemination of best-practices.
    /// </summary>
    public static readonly Coding Narrative = new Coding
    {
      Code = "narrative",
      Display = "Narrative",
      System = "http://hl7.org/fhir/CodeSystem/knowledge-representation-level"
    };
    /// <summary>
    /// The knowledge is expressed as organized text, often accompanied by diagrams such as flow charts and decision tables, affording broad shareability and moderate computability. The knowledge is typically expressed independent of delivery method (modality), technology platform, and implementation site. Knowledge at this level is typically authored by clinical domain experts for the purpose of communication the description of recommendations for implementation in various modalities.
    /// </summary>
    public static readonly Coding SemiStructured = new Coding
    {
      Code = "semi-structured",
      Display = "Semi-Structured",
      System = "http://hl7.org/fhir/CodeSystem/knowledge-representation-level"
    };
    /// <summary>
    /// The knowledge is expressed in a structured way that is interpretable by computer, including being coded using standard terminologies and specifications for the representation of structured content, affording broad shareability and high computability. The knowledge is typically expressed independent of delivery method (modality), technology platform, and implementation site. Knowledge at this level is typically authored by knowledge engineersto enable precise communication and validation of the recommendations.
    /// </summary>
    public static readonly Coding Structured = new Coding
    {
      Code = "structured",
      Display = "Structured",
      System = "http://hl7.org/fhir/CodeSystem/knowledge-representation-level"
    };

    /// <summary>
    /// Literal for code: Executable
    /// </summary>
    public const string LiteralExecutable = "executable";

    /// <summary>
    /// Literal for code: Narrative
    /// </summary>
    public const string LiteralNarrative = "narrative";

    /// <summary>
    /// Literal for code: SemiStructured
    /// </summary>
    public const string LiteralSemiStructured = "semi-structured";

    /// <summary>
    /// Literal for code: Structured
    /// </summary>
    public const string LiteralStructured = "structured";
  };
}