// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support the definition of dates relevant to recommendations for future doses of vaccines. This value set is provided as a suggestive example.
  /// </summary>
  public static class ImmunizationRecommendationDateCriterionCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VAL309807 = new Coding
    {
      Code = "30980-7",
      System = "http://loinc.org"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VAL309815 = new Coding
    {
      Code = "30981-5",
      System = "http://loinc.org"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VAL597773 = new Coding
    {
      Code = "59777-3",
      System = "http://loinc.org"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VAL597781 = new Coding
    {
      Code = "59778-1",
      System = "http://loinc.org"
    };

    /// <summary>
    /// Literal for code: VAL309807
    /// </summary>
    public const string LiteralVAL309807 = "30980-7";

    /// <summary>
    /// Literal for code: NONEVAL309807
    /// </summary>
    public const string LiteralNONEVAL309807 = "http://loinc.org#30980-7";

    /// <summary>
    /// Literal for code: VAL309815
    /// </summary>
    public const string LiteralVAL309815 = "30981-5";

    /// <summary>
    /// Literal for code: NONEVAL309815
    /// </summary>
    public const string LiteralNONEVAL309815 = "http://loinc.org#30981-5";

    /// <summary>
    /// Literal for code: VAL597773
    /// </summary>
    public const string LiteralVAL597773 = "59777-3";

    /// <summary>
    /// Literal for code: NONEVAL597773
    /// </summary>
    public const string LiteralNONEVAL597773 = "http://loinc.org#59777-3";

    /// <summary>
    /// Literal for code: VAL597781
    /// </summary>
    public const string LiteralVAL597781 = "59778-1";

    /// <summary>
    /// Literal for code: NONEVAL597781
    /// </summary>
    public const string LiteralNONEVAL597781 = "http://loinc.org#59778-1";

    /// <summary>
    /// Dictionary for looking up ImmunizationRecommendationDateCriterion Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "30980-7", VAL309807 }, 
      { "http://loinc.org#30980-7", VAL309807 }, 
      { "30981-5", VAL309815 }, 
      { "http://loinc.org#30981-5", VAL309815 }, 
      { "59777-3", VAL597773 }, 
      { "http://loinc.org#59777-3", VAL597773 }, 
      { "59778-1", VAL597781 }, 
      { "http://loinc.org#59778-1", VAL597781 }, 
    };
  };
}
