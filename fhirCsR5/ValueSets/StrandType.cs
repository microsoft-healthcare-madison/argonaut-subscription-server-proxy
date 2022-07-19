// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Type for strand.
  /// </summary>
  public static class StrandTypeCodes
  {
    /// <summary>
    /// Crick strand of reference sequence.
    /// </summary>
    public static readonly Coding CrickStrandOfReferenceSeq = new Coding
    {
      Code = "crick",
      Display = "Crick strand of referenceSeq",
      System = "http://hl7.org/fhir/strand-type"
    };
    /// <summary>
    /// Watson strand of reference sequence.
    /// </summary>
    public static readonly Coding WatsonStrandOfReferenceSeq = new Coding
    {
      Code = "watson",
      Display = "Watson strand of referenceSeq",
      System = "http://hl7.org/fhir/strand-type"
    };

    /// <summary>
    /// Literal for code: CrickStrandOfReferenceSeq
    /// </summary>
    public const string LiteralCrickStrandOfReferenceSeq = "crick";

    /// <summary>
    /// Literal for code: StrandTypeCrickStrandOfReferenceSeq
    /// </summary>
    public const string LiteralStrandTypeCrickStrandOfReferenceSeq = "http://hl7.org/fhir/strand-type#crick";

    /// <summary>
    /// Literal for code: WatsonStrandOfReferenceSeq
    /// </summary>
    public const string LiteralWatsonStrandOfReferenceSeq = "watson";

    /// <summary>
    /// Literal for code: StrandTypeWatsonStrandOfReferenceSeq
    /// </summary>
    public const string LiteralStrandTypeWatsonStrandOfReferenceSeq = "http://hl7.org/fhir/strand-type#watson";

    /// <summary>
    /// Dictionary for looking up StrandType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "crick", CrickStrandOfReferenceSeq }, 
      { "http://hl7.org/fhir/strand-type#crick", CrickStrandOfReferenceSeq }, 
      { "watson", WatsonStrandOfReferenceSeq }, 
      { "http://hl7.org/fhir/strand-type#watson", WatsonStrandOfReferenceSeq }, 
    };
  };
}
