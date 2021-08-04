// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The kind of report, such as grouping of classifiers, search results, or human-compiled expression.
  /// </summary>
  public static class EvidenceReportTypeCodes
  {
    /// <summary>
    /// The report is primarily a listing of classifiers about the report subject.
    /// </summary>
    public static readonly Coding Classification = new Coding
    {
      Code = "classification",
      Display = "Classification",
      System = "http://terminology.hl7.org/CodeSystem/evidence-report-type"
    };
    /// <summary>
    /// The report is a composition containing one or more FHIR resources in the content.
    /// </summary>
    public static readonly Coding ResourceCompilation = new Coding
    {
      Code = "resources-compiled",
      Display = "Resource Compilation",
      System = "http://terminology.hl7.org/CodeSystem/evidence-report-type"
    };
    /// <summary>
    /// The report is a composition of results generated in response to a search query.
    /// </summary>
    public static readonly Coding SearchResults = new Coding
    {
      Code = "search-results",
      Display = "Search Results",
      System = "http://terminology.hl7.org/CodeSystem/evidence-report-type"
    };
    /// <summary>
    /// The report is a structured representation of text.
    /// </summary>
    public static readonly Coding StructuredText = new Coding
    {
      Code = "text-structured",
      Display = "Structured Text",
      System = "http://terminology.hl7.org/CodeSystem/evidence-report-type"
    };

    /// <summary>
    /// Literal for code: Classification
    /// </summary>
    public const string LiteralClassification = "classification";

    /// <summary>
    /// Literal for code: ResourceCompilation
    /// </summary>
    public const string LiteralResourceCompilation = "resources-compiled";

    /// <summary>
    /// Literal for code: SearchResults
    /// </summary>
    public const string LiteralSearchResults = "search-results";

    /// <summary>
    /// Literal for code: StructuredText
    /// </summary>
    public const string LiteralStructuredText = "text-structured";
  };
}
