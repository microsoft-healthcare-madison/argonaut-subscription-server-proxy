// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The type of relations between entries.
  /// </summary>
  public static class RelationTypeCodes
  {
    /// <summary>
    /// the related entry represents an item that replaces the current retired item.
    /// </summary>
    public static readonly Coding ReplacedBy = new Coding
    {
      Code = "is-replaced-by",
      Display = "Replaced By",
      System = "http://hl7.org/fhir/relation-type"
    };
    /// <summary>
    /// the related entry represents an activity that may be triggered by the current item.
    /// </summary>
    public static readonly Coding Triggers = new Coding
    {
      Code = "triggers",
      Display = "Triggers",
      System = "http://hl7.org/fhir/relation-type"
    };

    /// <summary>
    /// Literal for code: ReplacedBy
    /// </summary>
    public const string LiteralReplacedBy = "is-replaced-by";

    /// <summary>
    /// Literal for code: RelationTypeReplacedBy
    /// </summary>
    public const string LiteralRelationTypeReplacedBy = "http://hl7.org/fhir/relation-type#is-replaced-by";

    /// <summary>
    /// Literal for code: Triggers
    /// </summary>
    public const string LiteralTriggers = "triggers";

    /// <summary>
    /// Literal for code: RelationTypeTriggers
    /// </summary>
    public const string LiteralRelationTypeTriggers = "http://hl7.org/fhir/relation-type#triggers";

    /// <summary>
    /// Dictionary for looking up RelationType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "is-replaced-by", ReplacedBy }, 
      { "http://hl7.org/fhir/relation-type#is-replaced-by", ReplacedBy }, 
      { "triggers", Triggers }, 
      { "http://hl7.org/fhir/relation-type#triggers", Triggers }, 
    };
  };
}
