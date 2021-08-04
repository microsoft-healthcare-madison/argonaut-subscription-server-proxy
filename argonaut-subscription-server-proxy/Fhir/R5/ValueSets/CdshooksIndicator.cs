// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set captures the set of indicator codes defined by the CDS Hooks specification.
  /// </summary>
  public static class CdshooksIndicatorCodes
  {
    /// <summary>
    /// The response is critical and indicates that it contains information or activities that have high urgency and importance that should be immediately addressed
    /// </summary>
    public static readonly Coding Critical = new Coding
    {
      Code = "critical",
      Display = "Critical",
      System = "http://cds-hooks.hl7.org/CodeSystem/indicator"
    };
    /// <summary>
    /// The response is informational and indicates that it contains additional information or relevant guidance that may be of interest
    /// </summary>
    public static readonly Coding Information = new Coding
    {
      Code = "info",
      Display = "Information",
      System = "http://cds-hooks.hl7.org/CodeSystem/indicator"
    };
    /// <summary>
    /// The response is a warning and indicates that it contains urgent or highly relevant information that should be considered
    /// </summary>
    public static readonly Coding Warning = new Coding
    {
      Code = "warning",
      Display = "Warning",
      System = "http://cds-hooks.hl7.org/CodeSystem/indicator"
    };

    /// <summary>
    /// Literal for code: Critical
    /// </summary>
    public const string LiteralCritical = "critical";

    /// <summary>
    /// Literal for code: Information
    /// </summary>
    public const string LiteralInformation = "info";

    /// <summary>
    /// Literal for code: Warning
    /// </summary>
    public const string LiteralWarning = "warning";
  };
}
