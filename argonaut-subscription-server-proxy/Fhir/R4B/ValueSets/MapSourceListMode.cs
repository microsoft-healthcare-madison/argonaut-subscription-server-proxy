// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// If field is a list, how to manage the source.
  /// </summary>
  public static class MapSourceListModeCodes
  {
    /// <summary>
    /// Only process this rule for the first in the list.
    /// </summary>
    public static readonly Coding First = new Coding
    {
      Code = "first",
      Display = "First",
      System = "http://hl7.org/fhir/map-source-list-mode"
    };
    /// <summary>
    /// Only process this rule for the last in the list.
    /// </summary>
    public static readonly Coding Last = new Coding
    {
      Code = "last",
      Display = "Last",
      System = "http://hl7.org/fhir/map-source-list-mode"
    };
    /// <summary>
    /// Process this rule for all but the first.
    /// </summary>
    public static readonly Coding AllButTheFirst = new Coding
    {
      Code = "not_first",
      Display = "All but the first",
      System = "http://hl7.org/fhir/map-source-list-mode"
    };
    /// <summary>
    /// Process this rule for all but the last.
    /// </summary>
    public static readonly Coding AllButTheLast = new Coding
    {
      Code = "not_last",
      Display = "All but the last",
      System = "http://hl7.org/fhir/map-source-list-mode"
    };
    /// <summary>
    /// Only process this rule is there is only item.
    /// </summary>
    public static readonly Coding EnforceOnlyOne = new Coding
    {
      Code = "only_one",
      Display = "Enforce only one",
      System = "http://hl7.org/fhir/map-source-list-mode"
    };

    /// <summary>
    /// Literal for code: First
    /// </summary>
    public const string LiteralFirst = "first";

    /// <summary>
    /// Literal for code: Last
    /// </summary>
    public const string LiteralLast = "last";

    /// <summary>
    /// Literal for code: AllButTheFirst
    /// </summary>
    public const string LiteralAllButTheFirst = "not_first";

    /// <summary>
    /// Literal for code: AllButTheLast
    /// </summary>
    public const string LiteralAllButTheLast = "not_last";

    /// <summary>
    /// Literal for code: EnforceOnlyOne
    /// </summary>
    public const string LiteralEnforceOnlyOne = "only_one";
  };
}
