// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes sample Claim Care Team Role codes.
  /// </summary>
  public static class ClaimCareteamroleCodes
  {
    /// <summary>
    /// Assisting care provider.
    /// </summary>
    public static readonly Coding AssistingProvider = new Coding
    {
      Code = "assist",
      Display = "Assisting Provider",
      System = "http://terminology.hl7.org/CodeSystem/claimcareteamrole"
    };
    /// <summary>
    /// Other role on the care team.
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://terminology.hl7.org/CodeSystem/claimcareteamrole"
    };
    /// <summary>
    /// The primary care provider.
    /// </summary>
    public static readonly Coding PrimaryProvider = new Coding
    {
      Code = "primary",
      Display = "Primary provider",
      System = "http://terminology.hl7.org/CodeSystem/claimcareteamrole"
    };
    /// <summary>
    /// Supervising care provider.
    /// </summary>
    public static readonly Coding SupervisingProvider = new Coding
    {
      Code = "supervisor",
      Display = "Supervising Provider",
      System = "http://terminology.hl7.org/CodeSystem/claimcareteamrole"
    };

    /// <summary>
    /// Literal for code: AssistingProvider
    /// </summary>
    public const string LiteralAssistingProvider = "assist";

    /// <summary>
    /// Literal for code: ClaimCareteamroleAssistingProvider
    /// </summary>
    public const string LiteralClaimCareteamroleAssistingProvider = "http://terminology.hl7.org/CodeSystem/claimcareteamrole#assist";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: ClaimCareteamroleOther
    /// </summary>
    public const string LiteralClaimCareteamroleOther = "http://terminology.hl7.org/CodeSystem/claimcareteamrole#other";

    /// <summary>
    /// Literal for code: PrimaryProvider
    /// </summary>
    public const string LiteralPrimaryProvider = "primary";

    /// <summary>
    /// Literal for code: ClaimCareteamrolePrimaryProvider
    /// </summary>
    public const string LiteralClaimCareteamrolePrimaryProvider = "http://terminology.hl7.org/CodeSystem/claimcareteamrole#primary";

    /// <summary>
    /// Literal for code: SupervisingProvider
    /// </summary>
    public const string LiteralSupervisingProvider = "supervisor";

    /// <summary>
    /// Literal for code: ClaimCareteamroleSupervisingProvider
    /// </summary>
    public const string LiteralClaimCareteamroleSupervisingProvider = "http://terminology.hl7.org/CodeSystem/claimcareteamrole#supervisor";

    /// <summary>
    /// Dictionary for looking up ClaimCareteamrole Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "assist", AssistingProvider }, 
      { "http://terminology.hl7.org/CodeSystem/claimcareteamrole#assist", AssistingProvider }, 
      { "other", Other }, 
      { "http://terminology.hl7.org/CodeSystem/claimcareteamrole#other", Other }, 
      { "primary", PrimaryProvider }, 
      { "http://terminology.hl7.org/CodeSystem/claimcareteamrole#primary", PrimaryProvider }, 
      { "supervisor", SupervisingProvider }, 
      { "http://terminology.hl7.org/CodeSystem/claimcareteamrole#supervisor", SupervisingProvider }, 
    };
  };
}
