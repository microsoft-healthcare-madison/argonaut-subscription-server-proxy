// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the reason why an administered dose has been assigned a particular status. Often, this reason describes why a dose is considered invalid. This value set is provided as a suggestive example.
  /// </summary>
  public static class ImmunizationEvaluationDoseStatusReasonCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AdverseStorage = new Coding
    {
      Code = "adversestorage",
      Display = "Adverse Storage",
      System = "http://terminology.hl7.org/CodeSystem/immunization-evaluation-dose-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ColdChainBreak = new Coding
    {
      Code = "coldchainbreak",
      Display = "Cold Chain Break",
      System = "http://terminology.hl7.org/CodeSystem/immunization-evaluation-dose-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ExpiredProduct = new Coding
    {
      Code = "expired",
      Display = "Expired Product",
      System = "http://terminology.hl7.org/CodeSystem/immunization-evaluation-dose-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OutsideSchedule = new Coding
    {
      Code = "outsideschedule",
      Display = "Outside Schedule",
      System = "http://terminology.hl7.org/CodeSystem/immunization-evaluation-dose-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PartialDose = new Coding
    {
      Code = "partialdose",
      Display = "Partial Dose",
      System = "http://terminology.hl7.org/CodeSystem/immunization-evaluation-dose-status-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ManufacturerRecall = new Coding
    {
      Code = "recall",
      Display = "Manufacturer Recall",
      System = "http://terminology.hl7.org/CodeSystem/immunization-evaluation-dose-status-reason"
    };

    /// <summary>
    /// Literal for code: AdverseStorage
    /// </summary>
    public const string LiteralAdverseStorage = "adversestorage";

    /// <summary>
    /// Literal for code: ColdChainBreak
    /// </summary>
    public const string LiteralColdChainBreak = "coldchainbreak";

    /// <summary>
    /// Literal for code: ExpiredProduct
    /// </summary>
    public const string LiteralExpiredProduct = "expired";

    /// <summary>
    /// Literal for code: OutsideSchedule
    /// </summary>
    public const string LiteralOutsideSchedule = "outsideschedule";

    /// <summary>
    /// Literal for code: PartialDose
    /// </summary>
    public const string LiteralPartialDose = "partialdose";

    /// <summary>
    /// Literal for code: ManufacturerRecall
    /// </summary>
    public const string LiteralManufacturerRecall = "recall";
  };
}