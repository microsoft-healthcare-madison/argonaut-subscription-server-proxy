// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// How an entity was used in an activity.
  /// </summary>
  public static class ProvenanceEntityRoleCodes
  {
    /// <summary>
    /// A transformation of an entity into another, an update of an entity resulting in a new one, or the construction of a new entity based on a pre-existing entity.
    /// </summary>
    public static readonly Coding Derivation = new Coding
    {
      Code = "derivation",
      Display = "Derivation",
      System = "http://hl7.org/fhir/provenance-entity-role"
    };
    /// <summary>
    /// The repeat of (some or all of) an entity, such as text or image, by someone who might or might not be its original author.
    /// </summary>
    public static readonly Coding Quotation = new Coding
    {
      Code = "quotation",
      Display = "Quotation",
      System = "http://hl7.org/fhir/provenance-entity-role"
    };
    /// <summary>
    /// A derivation for which the entity is removed from accessibility usually through the use of the Delete operation.
    /// </summary>
    public static readonly Coding Removal = new Coding
    {
      Code = "removal",
      Display = "Removal",
      System = "http://hl7.org/fhir/provenance-entity-role"
    };
    /// <summary>
    /// A derivation for which the resulting entity is a revised version of some original.
    /// </summary>
    public static readonly Coding Revision = new Coding
    {
      Code = "revision",
      Display = "Revision",
      System = "http://hl7.org/fhir/provenance-entity-role"
    };
    /// <summary>
    /// A primary source for a topic refers to something produced by some agent with direct experience and knowledge about the topic, at the time of the topic's study, without benefit from hindsight.
    /// </summary>
    public static readonly Coding Source = new Coding
    {
      Code = "source",
      Display = "Source",
      System = "http://hl7.org/fhir/provenance-entity-role"
    };

    /// <summary>
    /// Literal for code: Derivation
    /// </summary>
    public const string LiteralDerivation = "derivation";

    /// <summary>
    /// Literal for code: Quotation
    /// </summary>
    public const string LiteralQuotation = "quotation";

    /// <summary>
    /// Literal for code: Removal
    /// </summary>
    public const string LiteralRemoval = "removal";

    /// <summary>
    /// Literal for code: Revision
    /// </summary>
    public const string LiteralRevision = "revision";

    /// <summary>
    /// Literal for code: Source
    /// </summary>
    public const string LiteralSource = "source";
  };
}
