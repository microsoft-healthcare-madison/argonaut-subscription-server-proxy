// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
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
    /// Literal for code: Open
    /// </summary>
    public const string LiteralOpen = "open";

    /// <summary>
    /// Literal for code: OpenAtEnd
    /// </summary>
    public const string LiteralOpenAtEnd = "openAtEnd";
  };
}
