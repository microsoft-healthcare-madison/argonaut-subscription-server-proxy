// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The results of executing an action.
  /// </summary>
  public static class ReportActionResultCodesCodes
  {
    /// <summary>
    /// The action encountered a fatal error and the engine was unable to process.
    /// </summary>
    public static readonly Coding Error = new Coding
    {
      Code = "error",
      Display = "Error",
      System = "http://hl7.org/fhir/report-action-result-codes"
    };
    /// <summary>
    /// The action failed.
    /// </summary>
    public static readonly Coding Fail = new Coding
    {
      Code = "fail",
      Display = "Fail",
      System = "http://hl7.org/fhir/report-action-result-codes"
    };
    /// <summary>
    /// The action was successful.
    /// </summary>
    public static readonly Coding Pass = new Coding
    {
      Code = "pass",
      Display = "Pass",
      System = "http://hl7.org/fhir/report-action-result-codes"
    };
    /// <summary>
    /// The action was skipped.
    /// </summary>
    public static readonly Coding Skip = new Coding
    {
      Code = "skip",
      Display = "Skip",
      System = "http://hl7.org/fhir/report-action-result-codes"
    };
    /// <summary>
    /// The action passed but with warnings.
    /// </summary>
    public static readonly Coding Warning = new Coding
    {
      Code = "warning",
      Display = "Warning",
      System = "http://hl7.org/fhir/report-action-result-codes"
    };

    /// <summary>
    /// Literal for code: Error
    /// </summary>
    public const string LiteralError = "error";

    /// <summary>
    /// Literal for code: ReportActionResultCodesError
    /// </summary>
    public const string LiteralReportActionResultCodesError = "http://hl7.org/fhir/report-action-result-codes#error";

    /// <summary>
    /// Literal for code: Fail
    /// </summary>
    public const string LiteralFail = "fail";

    /// <summary>
    /// Literal for code: ReportActionResultCodesFail
    /// </summary>
    public const string LiteralReportActionResultCodesFail = "http://hl7.org/fhir/report-action-result-codes#fail";

    /// <summary>
    /// Literal for code: Pass
    /// </summary>
    public const string LiteralPass = "pass";

    /// <summary>
    /// Literal for code: ReportActionResultCodesPass
    /// </summary>
    public const string LiteralReportActionResultCodesPass = "http://hl7.org/fhir/report-action-result-codes#pass";

    /// <summary>
    /// Literal for code: Skip
    /// </summary>
    public const string LiteralSkip = "skip";

    /// <summary>
    /// Literal for code: ReportActionResultCodesSkip
    /// </summary>
    public const string LiteralReportActionResultCodesSkip = "http://hl7.org/fhir/report-action-result-codes#skip";

    /// <summary>
    /// Literal for code: Warning
    /// </summary>
    public const string LiteralWarning = "warning";

    /// <summary>
    /// Literal for code: ReportActionResultCodesWarning
    /// </summary>
    public const string LiteralReportActionResultCodesWarning = "http://hl7.org/fhir/report-action-result-codes#warning";

    /// <summary>
    /// Dictionary for looking up ReportActionResultCodes Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "error", Error }, 
      { "http://hl7.org/fhir/report-action-result-codes#error", Error }, 
      { "fail", Fail }, 
      { "http://hl7.org/fhir/report-action-result-codes#fail", Fail }, 
      { "pass", Pass }, 
      { "http://hl7.org/fhir/report-action-result-codes#pass", Pass }, 
      { "skip", Skip }, 
      { "http://hl7.org/fhir/report-action-result-codes#skip", Skip }, 
      { "warning", Warning }, 
      { "http://hl7.org/fhir/report-action-result-codes#warning", Warning }, 
    };
  };
}
