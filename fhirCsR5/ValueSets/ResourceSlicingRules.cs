// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// How slices are interpreted when evaluating an instance.
  /// </summary>
  public static class ResourceSlicingRulesCodes
  {
    /// <summary>
    /// No additional content is allowed other than that described by the slices in this profile.
    /// </summary>
    public static readonly Coding Closed = new Coding
    {
      Code = "closed",
      Display = "Closed",
      System = "http://hl7.org/fhir/resource-slicing-rules"
    };
    /// <summary>
    /// Additional content is allowed anywhere in the list.
    /// </summary>
    public static readonly Coding Open = new Coding
    {
      Code = "open",
      Display = "Open",
      System = "http://hl7.org/fhir/resource-slicing-rules"
    };
    /// <summary>
    /// Additional content is allowed, but only at the end of the list. Note that using this requires that the slices be ordered, which makes it hard to share uses. This should only be done where absolutely required.
    /// </summary>
    public static readonly Coding OpenAtEnd = new Coding
    {
      Code = "openAtEnd",
      Display = "Open at End",
      System = "http://hl7.org/fhir/resource-slicing-rules"
    };

    /// <summary>
    /// Literal for code: Closed
    /// </summary>
    public const string LiteralClosed = "closed";

    /// <summary>
    /// Literal for code: ResourceSlicingRulesClosed
    /// </summary>
    public const string LiteralResourceSlicingRulesClosed = "http://hl7.org/fhir/resource-slicing-rules#closed";

    /// <summary>
    /// Literal for code: Open
    /// </summary>
    public const string LiteralOpen = "open";

    /// <summary>
    /// Literal for code: ResourceSlicingRulesOpen
    /// </summary>
    public const string LiteralResourceSlicingRulesOpen = "http://hl7.org/fhir/resource-slicing-rules#open";

    /// <summary>
    /// Literal for code: OpenAtEnd
    /// </summary>
    public const string LiteralOpenAtEnd = "openAtEnd";

    /// <summary>
    /// Literal for code: ResourceSlicingRulesOpenAtEnd
    /// </summary>
    public const string LiteralResourceSlicingRulesOpenAtEnd = "http://hl7.org/fhir/resource-slicing-rules#openAtEnd";

    /// <summary>
    /// Dictionary for looking up ResourceSlicingRules Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "closed", Closed }, 
      { "http://hl7.org/fhir/resource-slicing-rules#closed", Closed }, 
      { "open", Open }, 
      { "http://hl7.org/fhir/resource-slicing-rules#open", Open }, 
      { "openAtEnd", OpenAtEnd }, 
      { "http://hl7.org/fhir/resource-slicing-rules#openAtEnd", OpenAtEnd }, 
    };
  };
}
