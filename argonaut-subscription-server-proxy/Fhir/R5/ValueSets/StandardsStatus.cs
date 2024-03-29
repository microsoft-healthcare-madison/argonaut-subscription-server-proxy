// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Description Needed Here
  /// </summary>
  public static class StandardsStatusCodes
  {
    /// <summary>
    /// This portion of the specification is provided for implementer assistance, and does not make rules that implementers are required to follow. Typical examples of this content in the FHIR specification are tables of contents, registries, examples, and implementer advice.
    /// </summary>
    public static readonly Coding Deprecated = new Coding
    {
      Code = "deprecated",
      Display = "Deprecated",
      System = "http://hl7.org/fhir/standards-status"
    };
    /// <summary>
    /// This portion of the specification is not considered to be complete enough or sufficiently reviewed to be safe for implementation. It may have known issues or still be in the "in development" stage. It is included in the publication as a place-holder, to solicit feedback from the implementation community and/or to give implementers some insight as to functionality likely to be included in future versions of the specification. Content at this level should only be implemented by the brave or desperate and is very much "use at your own risk". The content that is Draft that will usually be elevated to Trial Use once review and correction is complete after it has been subjected to ballot.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/standards-status"
    };
    /// <summary>
    /// This is content that is managed outside the FHIR Specification, but included for implementer convenience.
    /// </summary>
    public static readonly Coding External = new Coding
    {
      Code = "external",
      Display = "External",
      System = "http://hl7.org/fhir/standards-status"
    };
    /// <summary>
    /// This portion of the specification is provided for implementer assistance, and does not make rules that implementers are required to follow. Typical examples of this content in the FHIR specification are tables of contents, registries, examples, and implementer advice.
    /// </summary>
    public static readonly Coding Informative = new Coding
    {
      Code = "informative",
      Display = "Informative",
      System = "http://hl7.org/fhir/standards-status"
    };
    /// <summary>
    /// This content has been subject to review and production implementation in a wide variety of environments. The content is considered to be stable and has been 'locked', subjecting it to FHIR Inter-version Compatibility Rules. While changes are possible, they are expected to be infrequent and are tightly constrained. Compatibility Rules.
    /// </summary>
    public static readonly Coding Normative = new Coding
    {
      Code = "normative",
      Display = "Normative",
      System = "http://hl7.org/fhir/standards-status"
    };
    /// <summary>
    /// This content has been well reviewed and is considered by the authors to be ready for use in production systems. It has been subjected to ballot and approved as an official standard. However, it has not yet seen widespread use in production across the full spectrum of environments it is intended to be used in. In some cases, there may be documented known issues that require implementation experience to determine appropriate resolutions for.
    /// Future versions of FHIR may make significant changes to Trial Use content that are not compatible with previously published content.
    /// </summary>
    public static readonly Coding TrialUse = new Coding
    {
      Code = "trial-use",
      Display = "Trial-Use",
      System = "http://hl7.org/fhir/standards-status"
    };

    /// <summary>
    /// Literal for code: Deprecated
    /// </summary>
    public const string LiteralDeprecated = "deprecated";

    /// <summary>
    /// Literal for code: Draft
    /// </summary>
    public const string LiteralDraft = "draft";

    /// <summary>
    /// Literal for code: External
    /// </summary>
    public const string LiteralExternal = "external";

    /// <summary>
    /// Literal for code: Informative
    /// </summary>
    public const string LiteralInformative = "informative";

    /// <summary>
    /// Literal for code: Normative
    /// </summary>
    public const string LiteralNormative = "normative";

    /// <summary>
    /// Literal for code: TrialUse
    /// </summary>
    public const string LiteralTrialUse = "trial-use";
  };
}
