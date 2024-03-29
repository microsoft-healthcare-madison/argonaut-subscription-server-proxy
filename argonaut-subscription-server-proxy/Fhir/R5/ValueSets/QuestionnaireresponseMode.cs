// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes describing how the QuestionnaireResponse was populated
  /// </summary>
  public static class QuestionnaireresponseModeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ELECTRONIC = new Coding
    {
      Code = "ELECTRONIC",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationMode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VERBAL = new Coding
    {
      Code = "VERBAL",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationMode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding WRITTEN = new Coding
    {
      Code = "WRITTEN",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationMode"
    };

    /// <summary>
    /// Literal for code: ELECTRONIC
    /// </summary>
    public const string LiteralELECTRONIC = "ELECTRONIC";

    /// <summary>
    /// Literal for code: VERBAL
    /// </summary>
    public const string LiteralVERBAL = "VERBAL";

    /// <summary>
    /// Literal for code: WRITTEN
    /// </summary>
    public const string LiteralWRITTEN = "WRITTEN";
  };
}
