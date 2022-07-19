// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Type of the validation primary source
  /// </summary>
  public static class VerificationresultPrimarySourceTypeCodes
  {
    /// <summary>
    /// Authoritative source
    /// </summary>
    public static readonly Coding AuthoritativeSource = new Coding
    {
      Code = "auth-source",
      Display = "Authoritative source",
      System = "http://terminology.hl7.org/CodeSystem/primary-source-type"
    };
    /// <summary>
    /// Continuing Education
    /// </summary>
    public static readonly Coding ContinuingEducation = new Coding
    {
      Code = "cont-ed",
      Display = "Continuing Education",
      System = "http://terminology.hl7.org/CodeSystem/primary-source-type"
    };
    /// <summary>
    /// Issuing source
    /// </summary>
    public static readonly Coding IssuingSource = new Coding
    {
      Code = "issuer",
      Display = "Issuing source",
      System = "http://terminology.hl7.org/CodeSystem/primary-source-type"
    };
    /// <summary>
    /// Legal source
    /// </summary>
    public static readonly Coding LegalSource = new Coding
    {
      Code = "legal",
      Display = "Legal source",
      System = "http://terminology.hl7.org/CodeSystem/primary-source-type"
    };
    /// <summary>
    /// License Board
    /// </summary>
    public static readonly Coding LicenseBoard = new Coding
    {
      Code = "lic-board",
      Display = "License Board",
      System = "http://terminology.hl7.org/CodeSystem/primary-source-type"
    };
    /// <summary>
    /// Postal Service
    /// </summary>
    public static readonly Coding PostalService = new Coding
    {
      Code = "post-serv",
      Display = "Postal Service",
      System = "http://terminology.hl7.org/CodeSystem/primary-source-type"
    };
    /// <summary>
    /// Primary Education
    /// </summary>
    public static readonly Coding PrimaryEducation = new Coding
    {
      Code = "prim",
      Display = "Primary Education",
      System = "http://terminology.hl7.org/CodeSystem/primary-source-type"
    };
    /// <summary>
    /// Registration Authority
    /// </summary>
    public static readonly Coding RegistrationAuthority = new Coding
    {
      Code = "reg-auth",
      Display = "Registration Authority",
      System = "http://terminology.hl7.org/CodeSystem/primary-source-type"
    };
    /// <summary>
    /// Relationship owner
    /// </summary>
    public static readonly Coding RelationshipOwner = new Coding
    {
      Code = "rel-own",
      Display = "Relationship owner",
      System = "http://terminology.hl7.org/CodeSystem/primary-source-type"
    };

    /// <summary>
    /// Literal for code: AuthoritativeSource
    /// </summary>
    public const string LiteralAuthoritativeSource = "auth-source";

    /// <summary>
    /// Literal for code: PrimarySourceTypeAuthoritativeSource
    /// </summary>
    public const string LiteralPrimarySourceTypeAuthoritativeSource = "http://terminology.hl7.org/CodeSystem/primary-source-type#auth-source";

    /// <summary>
    /// Literal for code: ContinuingEducation
    /// </summary>
    public const string LiteralContinuingEducation = "cont-ed";

    /// <summary>
    /// Literal for code: PrimarySourceTypeContinuingEducation
    /// </summary>
    public const string LiteralPrimarySourceTypeContinuingEducation = "http://terminology.hl7.org/CodeSystem/primary-source-type#cont-ed";

    /// <summary>
    /// Literal for code: IssuingSource
    /// </summary>
    public const string LiteralIssuingSource = "issuer";

    /// <summary>
    /// Literal for code: PrimarySourceTypeIssuingSource
    /// </summary>
    public const string LiteralPrimarySourceTypeIssuingSource = "http://terminology.hl7.org/CodeSystem/primary-source-type#issuer";

    /// <summary>
    /// Literal for code: LegalSource
    /// </summary>
    public const string LiteralLegalSource = "legal";

    /// <summary>
    /// Literal for code: PrimarySourceTypeLegalSource
    /// </summary>
    public const string LiteralPrimarySourceTypeLegalSource = "http://terminology.hl7.org/CodeSystem/primary-source-type#legal";

    /// <summary>
    /// Literal for code: LicenseBoard
    /// </summary>
    public const string LiteralLicenseBoard = "lic-board";

    /// <summary>
    /// Literal for code: PrimarySourceTypeLicenseBoard
    /// </summary>
    public const string LiteralPrimarySourceTypeLicenseBoard = "http://terminology.hl7.org/CodeSystem/primary-source-type#lic-board";

    /// <summary>
    /// Literal for code: PostalService
    /// </summary>
    public const string LiteralPostalService = "post-serv";

    /// <summary>
    /// Literal for code: PrimarySourceTypePostalService
    /// </summary>
    public const string LiteralPrimarySourceTypePostalService = "http://terminology.hl7.org/CodeSystem/primary-source-type#post-serv";

    /// <summary>
    /// Literal for code: PrimaryEducation
    /// </summary>
    public const string LiteralPrimaryEducation = "prim";

    /// <summary>
    /// Literal for code: PrimarySourceTypePrimaryEducation
    /// </summary>
    public const string LiteralPrimarySourceTypePrimaryEducation = "http://terminology.hl7.org/CodeSystem/primary-source-type#prim";

    /// <summary>
    /// Literal for code: RegistrationAuthority
    /// </summary>
    public const string LiteralRegistrationAuthority = "reg-auth";

    /// <summary>
    /// Literal for code: PrimarySourceTypeRegistrationAuthority
    /// </summary>
    public const string LiteralPrimarySourceTypeRegistrationAuthority = "http://terminology.hl7.org/CodeSystem/primary-source-type#reg-auth";

    /// <summary>
    /// Literal for code: RelationshipOwner
    /// </summary>
    public const string LiteralRelationshipOwner = "rel-own";

    /// <summary>
    /// Literal for code: PrimarySourceTypeRelationshipOwner
    /// </summary>
    public const string LiteralPrimarySourceTypeRelationshipOwner = "http://terminology.hl7.org/CodeSystem/primary-source-type#rel-own";

    /// <summary>
    /// Dictionary for looking up VerificationresultPrimarySourceType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "auth-source", AuthoritativeSource }, 
      { "http://terminology.hl7.org/CodeSystem/primary-source-type#auth-source", AuthoritativeSource }, 
      { "cont-ed", ContinuingEducation }, 
      { "http://terminology.hl7.org/CodeSystem/primary-source-type#cont-ed", ContinuingEducation }, 
      { "issuer", IssuingSource }, 
      { "http://terminology.hl7.org/CodeSystem/primary-source-type#issuer", IssuingSource }, 
      { "legal", LegalSource }, 
      { "http://terminology.hl7.org/CodeSystem/primary-source-type#legal", LegalSource }, 
      { "lic-board", LicenseBoard }, 
      { "http://terminology.hl7.org/CodeSystem/primary-source-type#lic-board", LicenseBoard }, 
      { "post-serv", PostalService }, 
      { "http://terminology.hl7.org/CodeSystem/primary-source-type#post-serv", PostalService }, 
      { "prim", PrimaryEducation }, 
      { "http://terminology.hl7.org/CodeSystem/primary-source-type#prim", PrimaryEducation }, 
      { "reg-auth", RegistrationAuthority }, 
      { "http://terminology.hl7.org/CodeSystem/primary-source-type#reg-auth", RegistrationAuthority }, 
      { "rel-own", RelationshipOwner }, 
      { "http://terminology.hl7.org/CodeSystem/primary-source-type#rel-own", RelationshipOwner }, 
    };
  };
}
