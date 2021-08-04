// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Why an entry is in the result set - whether it's included as a match or because of an _include requirement, or to convey information or warning information about the search process.
  /// </summary>
  public static class SearchEntryModeCodes
  {
    /// <summary>
    /// This resource is returned because it is referred to from another resource in the search set.
    /// </summary>
    public static readonly Coding Include = new Coding
    {
      Code = "include",
      Display = "Include",
      System = "http://hl7.org/fhir/search-entry-mode"
    };
    /// <summary>
    /// This resource matched the search specification.
    /// </summary>
    public static readonly Coding Match = new Coding
    {
      Code = "match",
      Display = "Match",
      System = "http://hl7.org/fhir/search-entry-mode"
    };
    /// <summary>
    /// An OperationOutcome that provides additional information about the processing of a search.
    /// </summary>
    public static readonly Coding Outcome = new Coding
    {
      Code = "outcome",
      Display = "Outcome",
      System = "http://hl7.org/fhir/search-entry-mode"
    };

    /// <summary>
    /// Literal for code: Include
    /// </summary>
    public const string LiteralInclude = "include";

    /// <summary>
    /// Literal for code: Match
    /// </summary>
    public const string LiteralMatch = "match";

    /// <summary>
    /// Literal for code: Outcome
    /// </summary>
    public const string LiteralOutcome = "outcome";
  };
}
