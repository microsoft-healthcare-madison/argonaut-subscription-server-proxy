// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Used to code the format of the display string.
  /// </summary>
  public static class ContributorSummaryStyleCodes
  {
    /// <summary>
    /// Example: Jennifer Laskowski et al.
    /// </summary>
    public static readonly Coding FirstAuthorFullNameEtAl = new Coding
    {
      Code = "a1full",
      Display = "First author (full name) et al",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example: Laskowski J et al.
    /// </summary>
    public static readonly Coding FirstAuthorLastNameFirstInitialsEtAl = new Coding
    {
      Code = "a1init",
      Display = "First author (last name first initials) et al",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example: Jennifer Laskowski, Brandon Renner, Matthew C. Pickering, et al.
    /// </summary>
    public static readonly Coding First3AuthorsFullNameEtAl = new Coding
    {
      Code = "a3full",
      Display = "First 3 authors (full name) et al",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example:  Laskowski J, Renner B, Pickering MC, et al.
    /// </summary>
    public static readonly Coding First3AuthorsLastNameFirstInitialsEtAl = new Coding
    {
      Code = "a3init",
      Display = "First 3 authors (last name first initials) et al",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example: Jennifer Laskowski, Brandon Renner, Matthew C. Pickering, Natalie J. Serkova, Peter M. Smith-Jones, Eric T. Clambey, et al.
    /// </summary>
    public static readonly Coding First6AuthorsFullNameEtAl = new Coding
    {
      Code = "a6full",
      Display = "First 6 authors (full name) et al",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example: Laskowski J, Renner B, Pickering MC, Serkova NJ, Smith-Jones PM, Clambey ET, et al.
    /// </summary>
    public static readonly Coding First6AuthorsLastNameFirstInitialsEtAl = new Coding
    {
      Code = "a6init",
      Display = "First 6 authors (last name first initials) et al",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example: Jennifer Laskowski, Brandon Renner, Matthew C. Pickering, Natalie J. Serkova, Peter M. Smith-Jones, Eric T. Clambey, Raphael A. Nemenoff, Joshua M. Thurman.
    /// </summary>
    public static readonly Coding AllAuthorsFullName = new Coding
    {
      Code = "aallfull",
      Display = "All authors (full name)",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example: Jennifer Laskowski, Brandon Renner, Matthew C. Pickering, Natalie J. Serkova, Peter M. Smith-Jones, Eric T. Clambey, Raphael A. Nemenoff, &amp; Joshua M. Thurman.
    /// </summary>
    public static readonly Coding AllAuthorsFullNameWithAnAmpersandBeforeLastAuthor = new Coding
    {
      Code = "aallfullwithampersand",
      Display = "All authors (full name) with an ampersand before last author",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example: Jennifer Laskowski, Brandon Renner, Matthew C. Pickering, Natalie J. Serkova, Peter M. Smith-Jones, Eric T. Clambey, Raphael A. Nemenoff, and Joshua M. Thurman.
    /// </summary>
    public static readonly Coding AllAuthorsFullNameWithAndBeforeLastAuthor = new Coding
    {
      Code = "aallfullwithand",
      Display = "All authors (full name) with and before last author",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example: Laskowski J, Renner B, Pickering MC, Serkova NJ, Smith-Jones PM, Clambey ET, Nemenoff RA, Thurman JM.
    /// </summary>
    public static readonly Coding AllAuthorsLastNameFirstInitials = new Coding
    {
      Code = "aallinit",
      Display = "All authors (last name first initials)",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example: Laskowski J, Renner B, Pickering MC, Serkova NJ, Smith-Jones PM, Clambey ET, Nemenoff RA, &amp; Thurman JM.
    /// </summary>
    public static readonly Coding AllAuthorsLastNameFirstInitialsWithAnAmpersandBeforeLastAuthor = new Coding
    {
      Code = "aallinitwithampersand",
      Display = "All authors (last name first initials) with an ampersand before last author",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Example: Laskowski J, Renner B, Pickering MC, Serkova NJ, Smith-Jones PM, Clambey ET, Nemenoff RA, and Thurman JM.
    /// </summary>
    public static readonly Coding AllAuthorsLastNameFirstInitialsWithAndBeforeLastAuthor = new Coding
    {
      Code = "aallinitwithand",
      Display = "All authors (last name first initials) with and before last author",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Project design by Jennnifer Laskowski (JL), Experiment design by JL and Joshua M. Thurman (JMT), technical advice and study design contribution by Matthew C. Pickering, experiments performed by JL, data collection and analysis by JL, PET imaging and associated analyses by Natalie J. Serkova and Peter M. Smith-Jones, conceptual and technical guidance by Eric T. Clambey (ETC) and Raphael A. Nemenoff (RAN), manuscript writing by JL and JMT, manuscript revised critically by JL, Brandon Renner, ETC, and RAN.
    /// </summary>
    public static readonly Coding ContributorshipStatementListedByContributionWithFullNames = new Coding
    {
      Code = "contr-full-by-contr",
      Display = "Contributorship statement listed by contribution with full names",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Jennnifer Laskowski designed project; developed and performed experiments; collected and analyzed data; wrote and revised manuscript. Brandon Renner performed critical review of manuscript. Matthew C. Pickering provided technical advice and contributed to study design. Natalie J. Serkova and Peter M. Smith-Jones performed PET imaging and associated analyses. Eric T. Clambey and Raphael A. Nemenoff provided conceptual and technical guidance and critical review of manuscript. Joshua M. Thurman contributed to experimental design and wrote manuscript.
    /// </summary>
    public static readonly Coding ContributorshipStatementListedByPersonWithFullNames = new Coding
    {
      Code = "contr-full-by-person",
      Display = "Contributorship statement listed by person with full names",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// Project design by JL, Experiment design by JL and JMT, technical advice and study design contribution by MCP, experiments performed by JL, data collection and analysis by JL, PET imaging and associated analyses by NJS and PMS-J, conceptual and technical guidance by ETC and RAN, manuscript writing by JL and JMT, manuscript revised critically by JL, BR, ETC, and RAN.
    /// </summary>
    public static readonly Coding ContributorshipStatementListedByContributionWithInitials = new Coding
    {
      Code = "contr-init-by-contr",
      Display = "Contributorship statement listed by contribution with initials",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };
    /// <summary>
    /// J.L. designed project; developed and performed experiments; collected and analyzed data; wrote and revised manuscript. B.R. performed critical review of manuscript. M.C.P. provided technical advice and contributed to study design. N.J.S and P.M.S.-J. performed PET imaging and associated analyses. E.T.C. and R.A.N provided conceptual and technical guidance and critical review of manuscript. J.M.T contributed to experimental design and wrote manuscript.
    /// </summary>
    public static readonly Coding ContributorshipStatementListedByPersonWithInitials = new Coding
    {
      Code = "contr-init-by-person",
      Display = "Contributorship statement listed by person with initials",
      System = "http://terminology.hl7.org/CodeSystem/contributor-summary-style"
    };

    /// <summary>
    /// Literal for code: FirstAuthorFullNameEtAl
    /// </summary>
    public const string LiteralFirstAuthorFullNameEtAl = "a1full";

    /// <summary>
    /// Literal for code: FirstAuthorLastNameFirstInitialsEtAl
    /// </summary>
    public const string LiteralFirstAuthorLastNameFirstInitialsEtAl = "a1init";

    /// <summary>
    /// Literal for code: First3AuthorsFullNameEtAl
    /// </summary>
    public const string LiteralFirst3AuthorsFullNameEtAl = "a3full";

    /// <summary>
    /// Literal for code: First3AuthorsLastNameFirstInitialsEtAl
    /// </summary>
    public const string LiteralFirst3AuthorsLastNameFirstInitialsEtAl = "a3init";

    /// <summary>
    /// Literal for code: First6AuthorsFullNameEtAl
    /// </summary>
    public const string LiteralFirst6AuthorsFullNameEtAl = "a6full";

    /// <summary>
    /// Literal for code: First6AuthorsLastNameFirstInitialsEtAl
    /// </summary>
    public const string LiteralFirst6AuthorsLastNameFirstInitialsEtAl = "a6init";

    /// <summary>
    /// Literal for code: AllAuthorsFullName
    /// </summary>
    public const string LiteralAllAuthorsFullName = "aallfull";

    /// <summary>
    /// Literal for code: AllAuthorsFullNameWithAnAmpersandBeforeLastAuthor
    /// </summary>
    public const string LiteralAllAuthorsFullNameWithAnAmpersandBeforeLastAuthor = "aallfullwithampersand";

    /// <summary>
    /// Literal for code: AllAuthorsFullNameWithAndBeforeLastAuthor
    /// </summary>
    public const string LiteralAllAuthorsFullNameWithAndBeforeLastAuthor = "aallfullwithand";

    /// <summary>
    /// Literal for code: AllAuthorsLastNameFirstInitials
    /// </summary>
    public const string LiteralAllAuthorsLastNameFirstInitials = "aallinit";

    /// <summary>
    /// Literal for code: AllAuthorsLastNameFirstInitialsWithAnAmpersandBeforeLastAuthor
    /// </summary>
    public const string LiteralAllAuthorsLastNameFirstInitialsWithAnAmpersandBeforeLastAuthor = "aallinitwithampersand";

    /// <summary>
    /// Literal for code: AllAuthorsLastNameFirstInitialsWithAndBeforeLastAuthor
    /// </summary>
    public const string LiteralAllAuthorsLastNameFirstInitialsWithAndBeforeLastAuthor = "aallinitwithand";

    /// <summary>
    /// Literal for code: ContributorshipStatementListedByContributionWithFullNames
    /// </summary>
    public const string LiteralContributorshipStatementListedByContributionWithFullNames = "contr-full-by-contr";

    /// <summary>
    /// Literal for code: ContributorshipStatementListedByPersonWithFullNames
    /// </summary>
    public const string LiteralContributorshipStatementListedByPersonWithFullNames = "contr-full-by-person";

    /// <summary>
    /// Literal for code: ContributorshipStatementListedByContributionWithInitials
    /// </summary>
    public const string LiteralContributorshipStatementListedByContributionWithInitials = "contr-init-by-contr";

    /// <summary>
    /// Literal for code: ContributorshipStatementListedByPersonWithInitials
    /// </summary>
    public const string LiteralContributorshipStatementListedByPersonWithInitials = "contr-init-by-person";
  };
}
