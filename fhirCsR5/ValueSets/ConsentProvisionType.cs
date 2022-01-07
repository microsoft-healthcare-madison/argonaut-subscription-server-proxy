// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// How a rule statement is applied, such as adding additional consent or removing consent.
  /// </summary>
  public static class ConsentProvisionTypeCodes
  {
    /// <summary>
    /// Consent is denied for actions meeting these rules.
    /// </summary>
    public static readonly Coding Deny = new Coding
    {
      Code = "deny",
      Display = "Deny",
      System = "http://hl7.org/fhir/consent-provision-type"
    };
    /// <summary>
    /// Consent is provided for actions meeting these rules.
    /// </summary>
    public static readonly Coding Permit = new Coding
    {
      Code = "permit",
      Display = "Permit",
      System = "http://hl7.org/fhir/consent-provision-type"
    };

    /// <summary>
    /// Literal for code: Deny
    /// </summary>
    public const string LiteralDeny = "deny";

    /// <summary>
    /// Literal for code: ConsentProvisionTypeDeny
    /// </summary>
    public const string LiteralConsentProvisionTypeDeny = "http://hl7.org/fhir/consent-provision-type#deny";

    /// <summary>
    /// Literal for code: Permit
    /// </summary>
    public const string LiteralPermit = "permit";

    /// <summary>
    /// Literal for code: ConsentProvisionTypePermit
    /// </summary>
    public const string LiteralConsentProvisionTypePermit = "http://hl7.org/fhir/consent-provision-type#permit";

    /// <summary>
    /// Dictionary for looking up ConsentProvisionType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "deny", Deny }, 
      { "http://hl7.org/fhir/consent-provision-type#deny", Deny }, 
      { "permit", Permit }, 
      { "http://hl7.org/fhir/consent-provision-type#permit", Permit }, 
    };
  };
}
