// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Description Needed Here
  /// </summary>
  public static class CodesystemPropertiesModeCodes
  {
    /// <summary>
    /// All the property and filters definitions for the code system are included in the code system resource.
    /// </summary>
    public static readonly Coding Complete = new Coding
    {
      Code = "complete",
      Display = "Complete",
      System = "http://hl7.org/fhir/codesystem-properties-mode"
    };
    /// <summary>
    /// None of the properties and filters defined by the code system are included in the code system resource.
    /// </summary>
    public static readonly Coding NotPresent = new Coding
    {
      Code = "not-present",
      Display = "Not Present",
      System = "http://hl7.org/fhir/codesystem-properties-mode"
    };
    /// <summary>
    /// A subset of the code system properties and filter definitions are included in the code system resource.
    /// </summary>
    public static readonly Coding Partial = new Coding
    {
      Code = "partial",
      Display = "Partial",
      System = "http://hl7.org/fhir/codesystem-properties-mode"
    };

    /// <summary>
    /// Literal for code: Complete
    /// </summary>
    public const string LiteralComplete = "complete";

    /// <summary>
    /// Literal for code: NotPresent
    /// </summary>
    public const string LiteralNotPresent = "not-present";

    /// <summary>
    /// Literal for code: Partial
    /// </summary>
    public const string LiteralPartial = "partial";
  };
}
