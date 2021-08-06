// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes sample Claim Care Team Role codes.
  /// </summary>
  public static class ClaimCareteamroleCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AssistingProvider = new Coding
    {
      Code = "assist",
      Display = "Assisting Provider",
      System = "http://terminology.hl7.org/CodeSystem/claimcareteamrole"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://terminology.hl7.org/CodeSystem/claimcareteamrole"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrimaryProvider = new Coding
    {
      Code = "primary",
      Display = "Primary provider",
      System = "http://terminology.hl7.org/CodeSystem/claimcareteamrole"
    };
    /// <summary>
    /// 
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
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: PrimaryProvider
    /// </summary>
    public const string LiteralPrimaryProvider = "primary";

    /// <summary>
    /// Literal for code: SupervisingProvider
    /// </summary>
    public const string LiteralSupervisingProvider = "supervisor";
  };
}