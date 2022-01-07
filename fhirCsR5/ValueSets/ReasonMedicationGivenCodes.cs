// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set is provided as an example. The value set to instantiate this attribute should be drawn from a robust terminology code system that consists of or contains concepts to support the medication process.
  /// </summary>
  public static class ReasonMedicationGivenCodesCodes
  {
    /// <summary>
    /// None
    /// </summary>
    public static readonly Coding None = new Coding
    {
      Code = "a",
      Display = "None",
      System = "http://terminology.hl7.org/CodeSystem/reason-medication-given"
    };
    /// <summary>
    /// Given as Ordered
    /// </summary>
    public static readonly Coding GivenAsOrdered = new Coding
    {
      Code = "b",
      Display = "Given as Ordered",
      System = "http://terminology.hl7.org/CodeSystem/reason-medication-given"
    };
    /// <summary>
    /// Emergency
    /// </summary>
    public static readonly Coding Emergency = new Coding
    {
      Code = "c",
      Display = "Emergency",
      System = "http://terminology.hl7.org/CodeSystem/reason-medication-given"
    };

    /// <summary>
    /// Literal for code: None
    /// </summary>
    public const string LiteralNone = "a";

    /// <summary>
    /// Literal for code: ReasonMedicationGivenNone
    /// </summary>
    public const string LiteralReasonMedicationGivenNone = "http://terminology.hl7.org/CodeSystem/reason-medication-given#a";

    /// <summary>
    /// Literal for code: GivenAsOrdered
    /// </summary>
    public const string LiteralGivenAsOrdered = "b";

    /// <summary>
    /// Literal for code: ReasonMedicationGivenGivenAsOrdered
    /// </summary>
    public const string LiteralReasonMedicationGivenGivenAsOrdered = "http://terminology.hl7.org/CodeSystem/reason-medication-given#b";

    /// <summary>
    /// Literal for code: Emergency
    /// </summary>
    public const string LiteralEmergency = "c";

    /// <summary>
    /// Literal for code: ReasonMedicationGivenEmergency
    /// </summary>
    public const string LiteralReasonMedicationGivenEmergency = "http://terminology.hl7.org/CodeSystem/reason-medication-given#c";

    /// <summary>
    /// Dictionary for looking up ReasonMedicationGivenCodes Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "a", None }, 
      { "http://terminology.hl7.org/CodeSystem/reason-medication-given#a", None }, 
      { "b", GivenAsOrdered }, 
      { "http://terminology.hl7.org/CodeSystem/reason-medication-given#b", GivenAsOrdered }, 
      { "c", Emergency }, 
      { "http://terminology.hl7.org/CodeSystem/reason-medication-given#c", Emergency }, 
    };
  };
}