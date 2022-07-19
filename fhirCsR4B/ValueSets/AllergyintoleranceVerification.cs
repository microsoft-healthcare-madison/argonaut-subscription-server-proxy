// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Preferred value set for AllergyIntolerance Verification Status.
  /// </summary>
  public static class AllergyintoleranceVerificationCodes
  {
    /// <summary>
    /// A high level of certainty about the propensity for a reaction to the identified substance, which may include clinical evidence by testing or rechallenge.
    /// </summary>
    public static readonly Coding Confirmed = new Coding
    {
      Code = "confirmed",
      Display = "Confirmed",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// The statement was entered in error and is not valid.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// A propensity for a reaction to the identified substance has been disputed or disproven with a sufficient level of clinical certainty to justify invalidating the assertion. This might or might not include testing or rechallenge.
    /// </summary>
    public static readonly Coding Refuted = new Coding
    {
      Code = "refuted",
      Display = "Refuted",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// A low level of certainty about the propensity for a reaction to the identified substance.
    /// </summary>
    public static readonly Coding Unconfirmed = new Coding
    {
      Code = "unconfirmed",
      Display = "Unconfirmed",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };

    /// <summary>
    /// Literal for code: Confirmed
    /// </summary>
    public const string LiteralConfirmed = "confirmed";

    /// <summary>
    /// Literal for code: AllergyintoleranceVerificationConfirmed
    /// </summary>
    public const string LiteralAllergyintoleranceVerificationConfirmed = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#confirmed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: AllergyintoleranceVerificationEnteredInError
    /// </summary>
    public const string LiteralAllergyintoleranceVerificationEnteredInError = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#entered-in-error";

    /// <summary>
    /// Literal for code: Refuted
    /// </summary>
    public const string LiteralRefuted = "refuted";

    /// <summary>
    /// Literal for code: AllergyintoleranceVerificationRefuted
    /// </summary>
    public const string LiteralAllergyintoleranceVerificationRefuted = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#refuted";

    /// <summary>
    /// Literal for code: Unconfirmed
    /// </summary>
    public const string LiteralUnconfirmed = "unconfirmed";

    /// <summary>
    /// Literal for code: AllergyintoleranceVerificationUnconfirmed
    /// </summary>
    public const string LiteralAllergyintoleranceVerificationUnconfirmed = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#unconfirmed";

    /// <summary>
    /// Dictionary for looking up AllergyintoleranceVerification Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "confirmed", Confirmed }, 
      { "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#confirmed", Confirmed }, 
      { "entered-in-error", EnteredInError }, 
      { "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#entered-in-error", EnteredInError }, 
      { "refuted", Refuted }, 
      { "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#refuted", Refuted }, 
      { "unconfirmed", Unconfirmed }, 
      { "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification#unconfirmed", Unconfirmed }, 
    };
  };
}
