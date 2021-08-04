// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// NLM codes Internet or Print.
  /// </summary>
  public static class JournalIssueMediumCodes
  {
    /// <summary>
    /// NLM JournalIssue CitedMedium code for online version.
    /// </summary>
    public static readonly Coding Internet = new Coding
    {
      Code = "Internet",
      Display = "Internet",
      System = "http://terminology.hl7.org/CodeSystem/journal-issue-medium"
    };
    /// <summary>
    /// Used for article specific publication date which could be the same as or different from journal issue publication date.
    /// </summary>
    public static readonly Coding InternetWithoutIssueArticleSpecificOnlinePublication = new Coding
    {
      Code = "Internet-Without-Issue",
      Display = "Internet Without Issue (Article Specific Online Publication)",
      System = "http://terminology.hl7.org/CodeSystem/journal-issue-medium"
    };
    /// <summary>
    /// NLM JournalIssue CitedMedium code for print version.
    /// </summary>
    public static readonly Coding Print = new Coding
    {
      Code = "Print",
      Display = "Print",
      System = "http://terminology.hl7.org/CodeSystem/journal-issue-medium"
    };

    /// <summary>
    /// Literal for code: Internet
    /// </summary>
    public const string LiteralInternet = "Internet";

    /// <summary>
    /// Literal for code: InternetWithoutIssueArticleSpecificOnlinePublication
    /// </summary>
    public const string LiteralInternetWithoutIssueArticleSpecificOnlinePublication = "Internet-Without-Issue";

    /// <summary>
    /// Literal for code: Print
    /// </summary>
    public const string LiteralPrint = "Print";
  };
}
