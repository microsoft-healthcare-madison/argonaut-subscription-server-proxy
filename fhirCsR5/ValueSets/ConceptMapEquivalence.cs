// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The degree of equivalence between concepts.
  /// </summary>
  public static class ConceptMapEquivalenceCodes
  {
    /// <summary>
    /// This is an explicit assertion that there is no mapping between the source and target concept.
    /// </summary>
    public static readonly Coding Disjoint = new Coding
    {
      Code = "disjoint",
      Display = "Disjoint",
      System = "http://hl7.org/fhir/concept-map-equivalence"
    };
    /// <summary>
    /// The definitions of the concepts are exactly the same (i.e. only grammatical differences) and structural implications of meaning are identical or irrelevant (i.e. intentionally identical).
    /// </summary>
    public static readonly Coding Equal = new Coding
    {
      Code = "equal",
      Display = "Equal",
      System = "http://hl7.org/fhir/concept-map-equivalence"
    };
    /// <summary>
    /// The definitions of the concepts mean the same thing (including when structural implications of meaning are considered) (i.e. extensionally identical).
    /// </summary>
    public static readonly Coding Equivalent = new Coding
    {
      Code = "equivalent",
      Display = "Equivalent",
      System = "http://hl7.org/fhir/concept-map-equivalence"
    };
    /// <summary>
    /// The target mapping overlaps with the source concept, but both source and target cover additional meaning, or the definitions are imprecise and it is uncertain whether they have the same boundaries to their meaning. The sense in which the mapping is inexact SHALL be described in the comments in this case, and applications should be careful when attempting to use these mappings operationally.
    /// </summary>
    public static readonly Coding Inexact = new Coding
    {
      Code = "inexact",
      Display = "Inexact",
      System = "http://hl7.org/fhir/concept-map-equivalence"
    };
    /// <summary>
    /// The target mapping is narrower in meaning than the source concept. The sense in which the mapping is narrower SHALL be described in the comments in this case, and applications should be careful when attempting to use these mappings operationally.
    /// </summary>
    public static readonly Coding Narrower = new Coding
    {
      Code = "narrower",
      Display = "Narrower",
      System = "http://hl7.org/fhir/concept-map-equivalence"
    };
    /// <summary>
    /// The concepts are related to each other, and have at least some overlap in meaning, but the exact relationship is not known.
    /// </summary>
    public static readonly Coding RelatedTo = new Coding
    {
      Code = "relatedto",
      Display = "Related To",
      System = "http://hl7.org/fhir/concept-map-equivalence"
    };
    /// <summary>
    /// The target mapping specializes the meaning of the source concept (e.g. the target is-a source).
    /// </summary>
    public static readonly Coding Specializes = new Coding
    {
      Code = "specializes",
      Display = "Specializes",
      System = "http://hl7.org/fhir/concept-map-equivalence"
    };
    /// <summary>
    /// The target mapping subsumes the meaning of the source concept (e.g. the source is-a target).
    /// </summary>
    public static readonly Coding Subsumes = new Coding
    {
      Code = "subsumes",
      Display = "Subsumes",
      System = "http://hl7.org/fhir/concept-map-equivalence"
    };
    /// <summary>
    /// There is no match for this concept in the target code system.
    /// </summary>
    public static readonly Coding Unmatched = new Coding
    {
      Code = "unmatched",
      Display = "Unmatched",
      System = "http://hl7.org/fhir/concept-map-equivalence"
    };
    /// <summary>
    /// The target mapping is wider in meaning than the source concept.
    /// </summary>
    public static readonly Coding Wider = new Coding
    {
      Code = "wider",
      Display = "Wider",
      System = "http://hl7.org/fhir/concept-map-equivalence"
    };

    /// <summary>
    /// Literal for code: Disjoint
    /// </summary>
    public const string LiteralDisjoint = "disjoint";

    /// <summary>
    /// Literal for code: ConceptMapEquivalenceDisjoint
    /// </summary>
    public const string LiteralConceptMapEquivalenceDisjoint = "http://hl7.org/fhir/concept-map-equivalence#disjoint";

    /// <summary>
    /// Literal for code: Equal
    /// </summary>
    public const string LiteralEqual = "equal";

    /// <summary>
    /// Literal for code: ConceptMapEquivalenceEqual
    /// </summary>
    public const string LiteralConceptMapEquivalenceEqual = "http://hl7.org/fhir/concept-map-equivalence#equal";

    /// <summary>
    /// Literal for code: Equivalent
    /// </summary>
    public const string LiteralEquivalent = "equivalent";

    /// <summary>
    /// Literal for code: ConceptMapEquivalenceEquivalent
    /// </summary>
    public const string LiteralConceptMapEquivalenceEquivalent = "http://hl7.org/fhir/concept-map-equivalence#equivalent";

    /// <summary>
    /// Literal for code: Inexact
    /// </summary>
    public const string LiteralInexact = "inexact";

    /// <summary>
    /// Literal for code: ConceptMapEquivalenceInexact
    /// </summary>
    public const string LiteralConceptMapEquivalenceInexact = "http://hl7.org/fhir/concept-map-equivalence#inexact";

    /// <summary>
    /// Literal for code: Narrower
    /// </summary>
    public const string LiteralNarrower = "narrower";

    /// <summary>
    /// Literal for code: ConceptMapEquivalenceNarrower
    /// </summary>
    public const string LiteralConceptMapEquivalenceNarrower = "http://hl7.org/fhir/concept-map-equivalence#narrower";

    /// <summary>
    /// Literal for code: RelatedTo
    /// </summary>
    public const string LiteralRelatedTo = "relatedto";

    /// <summary>
    /// Literal for code: ConceptMapEquivalenceRelatedTo
    /// </summary>
    public const string LiteralConceptMapEquivalenceRelatedTo = "http://hl7.org/fhir/concept-map-equivalence#relatedto";

    /// <summary>
    /// Literal for code: Specializes
    /// </summary>
    public const string LiteralSpecializes = "specializes";

    /// <summary>
    /// Literal for code: ConceptMapEquivalenceSpecializes
    /// </summary>
    public const string LiteralConceptMapEquivalenceSpecializes = "http://hl7.org/fhir/concept-map-equivalence#specializes";

    /// <summary>
    /// Literal for code: Subsumes
    /// </summary>
    public const string LiteralSubsumes = "subsumes";

    /// <summary>
    /// Literal for code: ConceptMapEquivalenceSubsumes
    /// </summary>
    public const string LiteralConceptMapEquivalenceSubsumes = "http://hl7.org/fhir/concept-map-equivalence#subsumes";

    /// <summary>
    /// Literal for code: Unmatched
    /// </summary>
    public const string LiteralUnmatched = "unmatched";

    /// <summary>
    /// Literal for code: ConceptMapEquivalenceUnmatched
    /// </summary>
    public const string LiteralConceptMapEquivalenceUnmatched = "http://hl7.org/fhir/concept-map-equivalence#unmatched";

    /// <summary>
    /// Literal for code: Wider
    /// </summary>
    public const string LiteralWider = "wider";

    /// <summary>
    /// Literal for code: ConceptMapEquivalenceWider
    /// </summary>
    public const string LiteralConceptMapEquivalenceWider = "http://hl7.org/fhir/concept-map-equivalence#wider";

    /// <summary>
    /// Dictionary for looking up ConceptMapEquivalence Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "disjoint", Disjoint }, 
      { "http://hl7.org/fhir/concept-map-equivalence#disjoint", Disjoint }, 
      { "equal", Equal }, 
      { "http://hl7.org/fhir/concept-map-equivalence#equal", Equal }, 
      { "equivalent", Equivalent }, 
      { "http://hl7.org/fhir/concept-map-equivalence#equivalent", Equivalent }, 
      { "inexact", Inexact }, 
      { "http://hl7.org/fhir/concept-map-equivalence#inexact", Inexact }, 
      { "narrower", Narrower }, 
      { "http://hl7.org/fhir/concept-map-equivalence#narrower", Narrower }, 
      { "relatedto", RelatedTo }, 
      { "http://hl7.org/fhir/concept-map-equivalence#relatedto", RelatedTo }, 
      { "specializes", Specializes }, 
      { "http://hl7.org/fhir/concept-map-equivalence#specializes", Specializes }, 
      { "subsumes", Subsumes }, 
      { "http://hl7.org/fhir/concept-map-equivalence#subsumes", Subsumes }, 
      { "unmatched", Unmatched }, 
      { "http://hl7.org/fhir/concept-map-equivalence#unmatched", Unmatched }, 
      { "wider", Wider }, 
      { "http://hl7.org/fhir/concept-map-equivalence#wider", Wider }, 
    };
  };
}
