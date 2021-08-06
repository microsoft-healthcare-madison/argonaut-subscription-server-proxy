// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes codes that describe the type of involvement of the actor in the adverse event.
  /// </summary>
  public static class AdverseEventParticipantFunctionCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AUT = new Coding
    {
      Code = "AUT",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding INF = new Coding
    {
      Code = "INF",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PART = new Coding
    {
      Code = "PART",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding WIT = new Coding
    {
      Code = "WIT",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };

    /// <summary>
    /// Literal for code: AUT
    /// </summary>
    public const string LiteralAUT = "AUT";

    /// <summary>
    /// Literal for code: INF
    /// </summary>
    public const string LiteralINF = "INF";

    /// <summary>
    /// Literal for code: PART
    /// </summary>
    public const string LiteralPART = "PART";

    /// <summary>
    /// Literal for code: WIT
    /// </summary>
    public const string LiteralWIT = "WIT";
  };
}