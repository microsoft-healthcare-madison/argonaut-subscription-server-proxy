// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of publication such as book, database, or journal.
  /// </summary>
  public static class PublishedInTypeCodes
  {
    /// <summary>
    /// Non-periodical written or printed works consisting of sheets of pages fastened or bound together within covers.
    /// </summary>
    public static readonly Coding Book = new Coding
    {
      Code = "D001877",
      Display = "Book",
      System = "http://terminology.hl7.org/CodeSystem/published-in-type"
    };
    /// <summary>
    /// A structured file of information or a set of logically related data stored and retrieved using computer-based means.
    /// </summary>
    public static readonly Coding Database = new Coding
    {
      Code = "D019991",
      Display = "Database",
      System = "http://terminology.hl7.org/CodeSystem/published-in-type"
    };
    /// <summary>
    /// Publication intended to be issued on an ongoing basis, generally more frequently than annually, containing separate articles, stories, or writings.
    /// </summary>
    public static readonly Coding Periodical = new Coding
    {
      Code = "D020492",
      Display = "Periodical",
      System = "http://terminology.hl7.org/CodeSystem/published-in-type"
    };
    /// <summary>
    /// Works consisting of organized collections of data, which have been stored permanently in a formalized manner suitable for communication, interpretation, or processing.
    /// </summary>
    public static readonly Coding Dataset = new Coding
    {
      Code = "D064886",
      Display = "Dataset",
      System = "http://terminology.hl7.org/CodeSystem/published-in-type"
    };

    /// <summary>
    /// Literal for code: Book
    /// </summary>
    public const string LiteralBook = "D001877";

    /// <summary>
    /// Literal for code: Database
    /// </summary>
    public const string LiteralDatabase = "D019991";

    /// <summary>
    /// Literal for code: Periodical
    /// </summary>
    public const string LiteralPeriodical = "D020492";

    /// <summary>
    /// Literal for code: Dataset
    /// </summary>
    public const string LiteralDataset = "D064886";
  };
}
