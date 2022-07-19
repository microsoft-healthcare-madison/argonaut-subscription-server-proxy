// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Describes the operational status of the DeviceMetric.
  /// </summary>
  public static class MetricOperationalStatusCodes
  {
    /// <summary>
    /// The DeviceMetric was entered in error.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered In Error",
      System = "http://hl7.org/fhir/metric-operational-status"
    };
    /// <summary>
    /// The DeviceMetric is not operating.
    /// </summary>
    public static readonly Coding Off = new Coding
    {
      Code = "off",
      Display = "Off",
      System = "http://hl7.org/fhir/metric-operational-status"
    };
    /// <summary>
    /// The DeviceMetric is operating and will generate DeviceObservations.
    /// </summary>
    public static readonly Coding On = new Coding
    {
      Code = "on",
      Display = "On",
      System = "http://hl7.org/fhir/metric-operational-status"
    };
    /// <summary>
    /// The DeviceMetric is operating, but will not generate any DeviceObservations.
    /// </summary>
    public static readonly Coding Standby = new Coding
    {
      Code = "standby",
      Display = "Standby",
      System = "http://hl7.org/fhir/metric-operational-status"
    };

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: MetricOperationalStatusEnteredInError
    /// </summary>
    public const string LiteralMetricOperationalStatusEnteredInError = "http://hl7.org/fhir/metric-operational-status#entered-in-error";

    /// <summary>
    /// Literal for code: Off
    /// </summary>
    public const string LiteralOff = "off";

    /// <summary>
    /// Literal for code: MetricOperationalStatusOff
    /// </summary>
    public const string LiteralMetricOperationalStatusOff = "http://hl7.org/fhir/metric-operational-status#off";

    /// <summary>
    /// Literal for code: On
    /// </summary>
    public const string LiteralOn = "on";

    /// <summary>
    /// Literal for code: MetricOperationalStatusOn
    /// </summary>
    public const string LiteralMetricOperationalStatusOn = "http://hl7.org/fhir/metric-operational-status#on";

    /// <summary>
    /// Literal for code: Standby
    /// </summary>
    public const string LiteralStandby = "standby";

    /// <summary>
    /// Literal for code: MetricOperationalStatusStandby
    /// </summary>
    public const string LiteralMetricOperationalStatusStandby = "http://hl7.org/fhir/metric-operational-status#standby";

    /// <summary>
    /// Dictionary for looking up MetricOperationalStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/metric-operational-status#entered-in-error", EnteredInError }, 
      { "off", Off }, 
      { "http://hl7.org/fhir/metric-operational-status#off", Off }, 
      { "on", On }, 
      { "http://hl7.org/fhir/metric-operational-status#on", On }, 
      { "standby", Standby }, 
      { "http://hl7.org/fhir/metric-operational-status#standby", Standby }, 
    };
  };
}
