// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set is provided as an example. The value set to instantiate this attribute should be drawn from a robust terminology code system that consists of or contains concepts to support the medication process.
  /// </summary>
  public static class ReasonMedicationGivenCodesCodes
  {
    /// <summary>
    /// No reason known.
    /// </summary>
    public static readonly Coding None = new Coding
    {
      Code = "a",
      Display = "None",
      System = "http://terminology.hl7.org/CodeSystem/reason-medication-given"
    };
    /// <summary>
    /// The administration was following an ordered protocol.
    /// </summary>
    public static readonly Coding GivenAsOrdered = new Coding
    {
      Code = "b",
      Display = "Given as Ordered",
      System = "http://terminology.hl7.org/CodeSystem/reason-medication-given"
    };
    /// <summary>
    /// The administration was needed to treat an emergency.
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
    /// Literal for code: GivenAsOrdered
    /// </summary>
    public const string LiteralGivenAsOrdered = "b";

    /// <summary>
    /// Literal for code: Emergency
    /// </summary>
    public const string LiteralEmergency = "c";
  };
}
