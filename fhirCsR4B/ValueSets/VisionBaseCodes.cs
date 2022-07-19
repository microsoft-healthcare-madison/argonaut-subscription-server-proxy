// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// A coded concept listing the base codes.
  /// </summary>
  public static class VisionBaseCodesCodes
  {
    /// <summary>
    /// bottom.
    /// </summary>
    public static readonly Coding Down = new Coding
    {
      Code = "down",
      Display = "Down",
      System = "http://hl7.org/fhir/vision-base-codes"
    };
    /// <summary>
    /// inner edge.
    /// </summary>
    public static readonly Coding In = new Coding
    {
      Code = "in",
      Display = "In",
      System = "http://hl7.org/fhir/vision-base-codes"
    };
    /// <summary>
    /// outer edge.
    /// </summary>
    public static readonly Coding Out = new Coding
    {
      Code = "out",
      Display = "Out",
      System = "http://hl7.org/fhir/vision-base-codes"
    };
    /// <summary>
    /// top.
    /// </summary>
    public static readonly Coding Up = new Coding
    {
      Code = "up",
      Display = "Up",
      System = "http://hl7.org/fhir/vision-base-codes"
    };

    /// <summary>
    /// Literal for code: Down
    /// </summary>
    public const string LiteralDown = "down";

    /// <summary>
    /// Literal for code: VisionBaseCodesDown
    /// </summary>
    public const string LiteralVisionBaseCodesDown = "http://hl7.org/fhir/vision-base-codes#down";

    /// <summary>
    /// Literal for code: In
    /// </summary>
    public const string LiteralIn = "in";

    /// <summary>
    /// Literal for code: VisionBaseCodesIn
    /// </summary>
    public const string LiteralVisionBaseCodesIn = "http://hl7.org/fhir/vision-base-codes#in";

    /// <summary>
    /// Literal for code: Out
    /// </summary>
    public const string LiteralOut = "out";

    /// <summary>
    /// Literal for code: VisionBaseCodesOut
    /// </summary>
    public const string LiteralVisionBaseCodesOut = "http://hl7.org/fhir/vision-base-codes#out";

    /// <summary>
    /// Literal for code: Up
    /// </summary>
    public const string LiteralUp = "up";

    /// <summary>
    /// Literal for code: VisionBaseCodesUp
    /// </summary>
    public const string LiteralVisionBaseCodesUp = "http://hl7.org/fhir/vision-base-codes#up";

    /// <summary>
    /// Dictionary for looking up VisionBaseCodes Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "down", Down }, 
      { "http://hl7.org/fhir/vision-base-codes#down", Down }, 
      { "in", In }, 
      { "http://hl7.org/fhir/vision-base-codes#in", In }, 
      { "out", Out }, 
      { "http://hl7.org/fhir/vision-base-codes#out", Out }, 
      { "up", Up }, 
      { "http://hl7.org/fhir/vision-base-codes#up", Up }, 
    };
  };
}
