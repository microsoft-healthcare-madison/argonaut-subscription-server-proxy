// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the source of the vaccine administered. This value set is provided as a suggestive example.
  /// </summary>
  public static class ImmunizationFundingSourceCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Private = new Coding
    {
      Code = "private",
      Display = "Private",
      System = "http://terminology.hl7.org/CodeSystem/immunization-funding-source"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Public = new Coding
    {
      Code = "public",
      Display = "Public",
      System = "http://terminology.hl7.org/CodeSystem/immunization-funding-source"
    };

    /// <summary>
    /// Literal for code: Private
    /// </summary>
    public const string LiteralPrivate = "private";

    /// <summary>
    /// Literal for code: Public
    /// </summary>
    public const string LiteralPublic = "public";
  };
}