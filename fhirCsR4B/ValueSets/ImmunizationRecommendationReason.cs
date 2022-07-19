// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the reasons why a given recommendation status is assigned. This value set is provided as a suggestive example and includes SNOMED CT concepts.
  /// </summary>
  public static class ImmunizationRecommendationReasonCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VAL77176002 = new Coding
    {
      Code = "77176002",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VAL77386006 = new Coding
    {
      Code = "77386006",
      System = "http://snomed.info/sct"
    };

    /// <summary>
    /// Literal for code: VAL77176002
    /// </summary>
    public const string LiteralVAL77176002 = "77176002";

    /// <summary>
    /// Literal for code: NONEVAL77176002
    /// </summary>
    public const string LiteralNONEVAL77176002 = "http://snomed.info/sct#77176002";

    /// <summary>
    /// Literal for code: VAL77386006
    /// </summary>
    public const string LiteralVAL77386006 = "77386006";

    /// <summary>
    /// Literal for code: NONEVAL77386006
    /// </summary>
    public const string LiteralNONEVAL77386006 = "http://snomed.info/sct#77386006";

    /// <summary>
    /// Dictionary for looking up ImmunizationRecommendationReason Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "77176002", VAL77176002 }, 
      { "http://snomed.info/sct#77176002", VAL77176002 }, 
      { "77386006", VAL77386006 }, 
      { "http://snomed.info/sct#77386006", VAL77386006 }, 
    };
  };
}
