// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Types of security services used with FHIR.
  /// </summary>
  public static class RestfulSecurityServiceCodes
  {
    /// <summary>
    /// Basic authentication defined in HTTP specification.
    /// </summary>
    public static readonly Coding Basic = new Coding
    {
      Code = "Basic",
      Display = "Basic",
      System = "http://terminology.hl7.org/CodeSystem/restful-security-service"
    };
    /// <summary>
    /// SSL where client must have a certificate registered with the server.
    /// </summary>
    public static readonly Coding Certificates = new Coding
    {
      Code = "Certificates",
      Display = "Certificates",
      System = "http://terminology.hl7.org/CodeSystem/restful-security-service"
    };
    /// <summary>
    /// see http://www.ietf.org/rfc/rfc4120.txt.
    /// </summary>
    public static readonly Coding Kerberos = new Coding
    {
      Code = "Kerberos",
      Display = "Kerberos",
      System = "http://terminology.hl7.org/CodeSystem/restful-security-service"
    };
    /// <summary>
    /// Microsoft NTLM Authentication.
    /// </summary>
    public static readonly Coding NTLM = new Coding
    {
      Code = "NTLM",
      Display = "NTLM",
      System = "http://terminology.hl7.org/CodeSystem/restful-security-service"
    };
    /// <summary>
    /// OAuth (unspecified version see oauth.net).
    /// </summary>
    public static readonly Coding OAuth = new Coding
    {
      Code = "OAuth",
      Display = "OAuth",
      System = "http://terminology.hl7.org/CodeSystem/restful-security-service"
    };
    /// <summary>
    /// OAuth2 using SMART-on-FHIR profile (see http://docs.smarthealthit.org/).
    /// </summary>
    public static readonly Coding SMARTOnFHIR = new Coding
    {
      Code = "SMART-on-FHIR",
      Display = "SMART-on-FHIR",
      System = "http://terminology.hl7.org/CodeSystem/restful-security-service"
    };

    /// <summary>
    /// Literal for code: Basic
    /// </summary>
    public const string LiteralBasic = "Basic";

    /// <summary>
    /// Literal for code: RestfulSecurityServiceBasic
    /// </summary>
    public const string LiteralRestfulSecurityServiceBasic = "http://terminology.hl7.org/CodeSystem/restful-security-service#Basic";

    /// <summary>
    /// Literal for code: Certificates
    /// </summary>
    public const string LiteralCertificates = "Certificates";

    /// <summary>
    /// Literal for code: RestfulSecurityServiceCertificates
    /// </summary>
    public const string LiteralRestfulSecurityServiceCertificates = "http://terminology.hl7.org/CodeSystem/restful-security-service#Certificates";

    /// <summary>
    /// Literal for code: Kerberos
    /// </summary>
    public const string LiteralKerberos = "Kerberos";

    /// <summary>
    /// Literal for code: RestfulSecurityServiceKerberos
    /// </summary>
    public const string LiteralRestfulSecurityServiceKerberos = "http://terminology.hl7.org/CodeSystem/restful-security-service#Kerberos";

    /// <summary>
    /// Literal for code: NTLM
    /// </summary>
    public const string LiteralNTLM = "NTLM";

    /// <summary>
    /// Literal for code: RestfulSecurityServiceNTLM
    /// </summary>
    public const string LiteralRestfulSecurityServiceNTLM = "http://terminology.hl7.org/CodeSystem/restful-security-service#NTLM";

    /// <summary>
    /// Literal for code: OAuth
    /// </summary>
    public const string LiteralOAuth = "OAuth";

    /// <summary>
    /// Literal for code: RestfulSecurityServiceOAuth
    /// </summary>
    public const string LiteralRestfulSecurityServiceOAuth = "http://terminology.hl7.org/CodeSystem/restful-security-service#OAuth";

    /// <summary>
    /// Literal for code: SMARTOnFHIR
    /// </summary>
    public const string LiteralSMARTOnFHIR = "SMART-on-FHIR";

    /// <summary>
    /// Literal for code: RestfulSecurityServiceSMARTOnFHIR
    /// </summary>
    public const string LiteralRestfulSecurityServiceSMARTOnFHIR = "http://terminology.hl7.org/CodeSystem/restful-security-service#SMART-on-FHIR";

    /// <summary>
    /// Dictionary for looking up RestfulSecurityService Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "Basic", Basic }, 
      { "http://terminology.hl7.org/CodeSystem/restful-security-service#Basic", Basic }, 
      { "Certificates", Certificates }, 
      { "http://terminology.hl7.org/CodeSystem/restful-security-service#Certificates", Certificates }, 
      { "Kerberos", Kerberos }, 
      { "http://terminology.hl7.org/CodeSystem/restful-security-service#Kerberos", Kerberos }, 
      { "NTLM", NTLM }, 
      { "http://terminology.hl7.org/CodeSystem/restful-security-service#NTLM", NTLM }, 
      { "OAuth", OAuth }, 
      { "http://terminology.hl7.org/CodeSystem/restful-security-service#OAuth", OAuth }, 
      { "SMART-on-FHIR", SMARTOnFHIR }, 
      { "http://terminology.hl7.org/CodeSystem/restful-security-service#SMART-on-FHIR", SMARTOnFHIR }, 
    };
  };
}
