// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Used to code author list statement, contributorship statement, and such.
  /// </summary>
  public static class ContributorSummaryTypeCodes
  {
    /// <summary>
    /// Display of the list of acknowledged parties as a complete string.
    /// </summary>
    public static readonly Coding AcknowledgmentList = new Coding
    {
      Code = "acknowledgement-list",
      Display = "Acknowledgment list",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-type"
    };
    /// <summary>
    /// Statement of acknowledgment of contributions beyond those compiled for formal contributorship statements.
    /// </summary>
    public static readonly Coding AcknowledgmentStatement = new Coding
    {
      Code = "acknowledgment-statement",
      Display = "Acknowledgment statement",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-type"
    };
    /// <summary>
    /// Display of the author list as a complete string.
    /// </summary>
    public static readonly Coding AuthorString = new Coding
    {
      Code = "author-string",
      Display = "Author string",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-type"
    };
    /// <summary>
    /// Statement of completing interests related to the creation of the cited artifact. Also called conflicts of interest or declaration of interests.
    /// </summary>
    public static readonly Coding CompetingInterestsStatement = new Coding
    {
      Code = "competing-interests-statement",
      Display = "Competing interests statement",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-type"
    };
    /// <summary>
    /// Display of the list of contributors as a complete string.
    /// </summary>
    public static readonly Coding ContributorshipList = new Coding
    {
      Code = "contributorship-list",
      Display = "Contributorship list",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-type"
    };
    /// <summary>
    /// Compiled summary of contributions.
    /// </summary>
    public static readonly Coding ContributorshipStatement = new Coding
    {
      Code = "contributorship-statement",
      Display = "Contributorship statement",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-type"
    };
    /// <summary>
    /// Statement of financial support for the creation of the cited artifact.
    /// </summary>
    public static readonly Coding FundingStatement = new Coding
    {
      Code = "funding-statement",
      Display = "Funding statement",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-type"
    };

    /// <summary>
    /// Literal for code: AcknowledgmentList
    /// </summary>
    public const string LiteralAcknowledgmentList = "acknowledgement-list";

    /// <summary>
    /// Literal for code: AcknowledgmentStatement
    /// </summary>
    public const string LiteralAcknowledgmentStatement = "acknowledgment-statement";

    /// <summary>
    /// Literal for code: AuthorString
    /// </summary>
    public const string LiteralAuthorString = "author-string";

    /// <summary>
    /// Literal for code: CompetingInterestsStatement
    /// </summary>
    public const string LiteralCompetingInterestsStatement = "competing-interests-statement";

    /// <summary>
    /// Literal for code: ContributorshipList
    /// </summary>
    public const string LiteralContributorshipList = "contributorship-list";

    /// <summary>
    /// Literal for code: ContributorshipStatement
    /// </summary>
    public const string LiteralContributorshipStatement = "contributorship-statement";

    /// <summary>
    /// Literal for code: FundingStatement
    /// </summary>
    public const string LiteralFundingStatement = "funding-statement";
  };
}