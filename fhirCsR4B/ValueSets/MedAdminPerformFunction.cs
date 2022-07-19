// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// MedicationAdministration Performer Function Codes
  /// </summary>
  public static class MedAdminPerformFunctionCodes
  {
    /// <summary>
    /// A person, non-person living subject, organization or device that who actually and principally carries out the action
    /// </summary>
    public static readonly Coding Performer = new Coding
    {
      Code = "performer",
      Display = "Performer",
      System = "http://terminology.hl7.org/CodeSystem/med-admin-perform-function"
    };
    /// <summary>
    /// A person who verifies the correctness and appropriateness of the service (plan, order, event, etc.) and hence takes on accountability.
    /// </summary>
    public static readonly Coding Verifier = new Coding
    {
      Code = "verifier",
      Display = "Verifier",
      System = "http://terminology.hl7.org/CodeSystem/med-admin-perform-function"
    };
    /// <summary>
    /// A person witnessing the action happening without doing anything. A witness is not necessarily aware, much less approves of anything stated in the service event. Example for a witness is students watching an operation or an advanced directive witness.
    /// </summary>
    public static readonly Coding Witness = new Coding
    {
      Code = "witness",
      Display = "Witness",
      System = "http://terminology.hl7.org/CodeSystem/med-admin-perform-function"
    };

    /// <summary>
    /// Literal for code: Performer
    /// </summary>
    public const string LiteralPerformer = "performer";

    /// <summary>
    /// Literal for code: MedAdminPerformFunctionPerformer
    /// </summary>
    public const string LiteralMedAdminPerformFunctionPerformer = "http://terminology.hl7.org/CodeSystem/med-admin-perform-function#performer";

    /// <summary>
    /// Literal for code: Verifier
    /// </summary>
    public const string LiteralVerifier = "verifier";

    /// <summary>
    /// Literal for code: MedAdminPerformFunctionVerifier
    /// </summary>
    public const string LiteralMedAdminPerformFunctionVerifier = "http://terminology.hl7.org/CodeSystem/med-admin-perform-function#verifier";

    /// <summary>
    /// Literal for code: Witness
    /// </summary>
    public const string LiteralWitness = "witness";

    /// <summary>
    /// Literal for code: MedAdminPerformFunctionWitness
    /// </summary>
    public const string LiteralMedAdminPerformFunctionWitness = "http://terminology.hl7.org/CodeSystem/med-admin-perform-function#witness";

    /// <summary>
    /// Dictionary for looking up MedAdminPerformFunction Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "performer", Performer }, 
      { "http://terminology.hl7.org/CodeSystem/med-admin-perform-function#performer", Performer }, 
      { "verifier", Verifier }, 
      { "http://terminology.hl7.org/CodeSystem/med-admin-perform-function#verifier", Verifier }, 
      { "witness", Witness }, 
      { "http://terminology.hl7.org/CodeSystem/med-admin-perform-function#witness", Witness }, 
    };
  };
}
