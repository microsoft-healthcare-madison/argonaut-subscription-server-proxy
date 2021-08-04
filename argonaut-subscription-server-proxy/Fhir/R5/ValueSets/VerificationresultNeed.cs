// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The frequency with which the target must be validated
  /// </summary>
  public static class VerificationresultNeedCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Initial = new Coding
    {
      Code = "initial",
      Display = "Initial",
      System = "http://terminology.hl7.org/CodeSystem/need"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding None = new Coding
    {
      Code = "none",
      Display = "None",
      System = "http://terminology.hl7.org/CodeSystem/need"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Periodic = new Coding
    {
      Code = "periodic",
      Display = "Periodic",
      System = "http://terminology.hl7.org/CodeSystem/need"
    };

    /// <summary>
    /// Literal for code: Initial
    /// </summary>
    public const string LiteralInitial = "initial";

    /// <summary>
    /// Literal for code: None
    /// </summary>
    public const string LiteralNone = "none";

    /// <summary>
    /// Literal for code: Periodic
    /// </summary>
    public const string LiteralPeriodic = "periodic";
  };
}
