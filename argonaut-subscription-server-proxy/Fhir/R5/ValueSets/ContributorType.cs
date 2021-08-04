// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of contributor.
  /// </summary>
  public static class ContributorTypeCodes
  {
    /// <summary>
    /// An author of the content of the module.
    /// </summary>
    public static readonly Coding Author = new Coding
    {
      Code = "author",
      Display = "Author",
      System = "http://hl7.org/fhir/contributor-type"
    };
    /// <summary>
    /// An editor of the content of the module.
    /// </summary>
    public static readonly Coding Editor = new Coding
    {
      Code = "editor",
      Display = "Editor",
      System = "http://hl7.org/fhir/contributor-type"
    };
    /// <summary>
    /// An endorser of the content of the module.
    /// </summary>
    public static readonly Coding Endorser = new Coding
    {
      Code = "endorser",
      Display = "Endorser",
      System = "http://hl7.org/fhir/contributor-type"
    };
    /// <summary>
    /// A reviewer of the content of the module.
    /// </summary>
    public static readonly Coding Reviewer = new Coding
    {
      Code = "reviewer",
      Display = "Reviewer",
      System = "http://hl7.org/fhir/contributor-type"
    };

    /// <summary>
    /// Literal for code: Author
    /// </summary>
    public const string LiteralAuthor = "author";

    /// <summary>
    /// Literal for code: Editor
    /// </summary>
    public const string LiteralEditor = "editor";

    /// <summary>
    /// Literal for code: Endorser
    /// </summary>
    public const string LiteralEndorser = "endorser";

    /// <summary>
    /// Literal for code: Reviewer
    /// </summary>
    public const string LiteralReviewer = "reviewer";
  };
}
