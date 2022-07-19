// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Logical grouping of characteristics.
  /// </summary>
  public static class CharacteristicCombinationCodes
  {
    /// <summary>
    /// Combine characteristics with AND.
    /// </summary>
    public static readonly Coding Intersection = new Coding
    {
      Code = "intersection",
      Display = "intersection",
      System = "http://hl7.org/fhir/characteristic-combination"
    };
    /// <summary>
    /// Combine characteristics with OR.
    /// </summary>
    public static readonly Coding Union = new Coding
    {
      Code = "union",
      Display = "union",
      System = "http://hl7.org/fhir/characteristic-combination"
    };

    /// <summary>
    /// Literal for code: Intersection
    /// </summary>
    public const string LiteralIntersection = "intersection";

    /// <summary>
    /// Literal for code: CharacteristicCombinationIntersection
    /// </summary>
    public const string LiteralCharacteristicCombinationIntersection = "http://hl7.org/fhir/characteristic-combination#intersection";

    /// <summary>
    /// Literal for code: Union
    /// </summary>
    public const string LiteralUnion = "union";

    /// <summary>
    /// Literal for code: CharacteristicCombinationUnion
    /// </summary>
    public const string LiteralCharacteristicCombinationUnion = "http://hl7.org/fhir/characteristic-combination#union";

    /// <summary>
    /// Dictionary for looking up CharacteristicCombination Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "intersection", Intersection }, 
      { "http://hl7.org/fhir/characteristic-combination#intersection", Intersection }, 
      { "union", Union }, 
      { "http://hl7.org/fhir/characteristic-combination#union", Union }, 
    };
  };
}
