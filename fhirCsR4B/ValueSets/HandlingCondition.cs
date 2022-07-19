// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Set of handling instructions prior testing of the specimen.
  /// </summary>
  public static class HandlingConditionCodes
  {
    /// <summary>
    /// frozen temperature.
    /// </summary>
    public static readonly Coding Frozen = new Coding
    {
      Code = "frozen",
      Display = "frozen",
      System = "http://terminology.hl7.org/CodeSystem/handling-condition"
    };
    /// <summary>
    /// refrigerated temperature.
    /// </summary>
    public static readonly Coding Refrigerated = new Coding
    {
      Code = "refrigerated",
      Display = "refrigerated",
      System = "http://terminology.hl7.org/CodeSystem/handling-condition"
    };
    /// <summary>
    /// room temperature.
    /// </summary>
    public static readonly Coding RoomTemperature = new Coding
    {
      Code = "room",
      Display = "room temperature",
      System = "http://terminology.hl7.org/CodeSystem/handling-condition"
    };

    /// <summary>
    /// Literal for code: Frozen
    /// </summary>
    public const string LiteralFrozen = "frozen";

    /// <summary>
    /// Literal for code: HandlingConditionFrozen
    /// </summary>
    public const string LiteralHandlingConditionFrozen = "http://terminology.hl7.org/CodeSystem/handling-condition#frozen";

    /// <summary>
    /// Literal for code: Refrigerated
    /// </summary>
    public const string LiteralRefrigerated = "refrigerated";

    /// <summary>
    /// Literal for code: HandlingConditionRefrigerated
    /// </summary>
    public const string LiteralHandlingConditionRefrigerated = "http://terminology.hl7.org/CodeSystem/handling-condition#refrigerated";

    /// <summary>
    /// Literal for code: RoomTemperature
    /// </summary>
    public const string LiteralRoomTemperature = "room";

    /// <summary>
    /// Literal for code: HandlingConditionRoomTemperature
    /// </summary>
    public const string LiteralHandlingConditionRoomTemperature = "http://terminology.hl7.org/CodeSystem/handling-condition#room";

    /// <summary>
    /// Dictionary for looking up HandlingCondition Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "frozen", Frozen }, 
      { "http://terminology.hl7.org/CodeSystem/handling-condition#frozen", Frozen }, 
      { "refrigerated", Refrigerated }, 
      { "http://terminology.hl7.org/CodeSystem/handling-condition#refrigerated", Refrigerated }, 
      { "room", RoomTemperature }, 
      { "http://terminology.hl7.org/CodeSystem/handling-condition#room", RoomTemperature }, 
    };
  };
}
