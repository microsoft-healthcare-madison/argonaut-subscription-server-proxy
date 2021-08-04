// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// A vaule for a feature that may be declared in a capability statement
  /// </summary>
  public static class CapabilityFeatureValueCodes
  {
    /// <summary>
    /// The server enforces that references have integrity - e.g. it ensures that references can always be resolved. This is typically the case for clinical record systems, but often not the case for middleware/proxy systems.
    /// </summary>
    public static readonly Coding ReferenceIntegrityEnforced = new Coding
    {
      Code = "enforced",
      Display = "Reference Integrity Enforced",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ValueIsFalse = new Coding
    {
      Code = "false",
      Display = "Value is false",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// Conditional reads are supported, with both If-Modified-Since and If-None-Match HTTP Headers.
    /// </summary>
    public static readonly Coding FullSupport = new Coding
    {
      Code = "full-support",
      Display = "Full Support",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// The server supports and populates Literal references (i.e. using Reference.reference) where they are known (this code does not guarantee that all references are literal; see 'enforced').
    /// </summary>
    public static readonly Coding LiteralReferences = new Coding
    {
      Code = "literal",
      Display = "Literal References",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// The server does not support references that point to other servers.
    /// </summary>
    public static readonly Coding LocalReferencesOnly = new Coding
    {
      Code = "local",
      Display = "Local References Only",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// The server allows logical references (i.e. using Reference.identifier).
    /// </summary>
    public static readonly Coding LogicalReferences = new Coding
    {
      Code = "logical",
      Display = "Logical References",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// Conditional reads are supported, but only with the If-Modified-Since HTTP Header.
    /// </summary>
    public static readonly Coding IfModifiedSince = new Coding
    {
      Code = "modified-since",
      Display = "If-Modified-Since",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// Conditional deletes are supported, and multiple resources can be deleted in a single interaction.
    /// </summary>
    public static readonly Coding MultipleDeletesSupported = new Coding
    {
      Code = "multiple",
      Display = "Multiple Deletes Supported",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// Conditional reads are supported, but only with the If-None-Match HTTP Header.
    /// </summary>
    public static readonly Coding IfNoneMatch = new Coding
    {
      Code = "not-match",
      Display = "If-None-Match",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// No support for conditional reads.
    /// </summary>
    public static readonly Coding NotSupported = new Coding
    {
      Code = "not-supported",
      Display = "Not Supported",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NoVersionIdSupport = new Coding
    {
      Code = "no-version",
      Display = "No VersionId Support",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// The server will attempt to resolve logical references to literal references - i.e. converting Reference.identifier to Reference.reference (if resolution fails, the server may still accept resources; see logical).
    /// </summary>
    public static readonly Coding ResolvesReferences = new Coding
    {
      Code = "resolves",
      Display = "Resolves References",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// Conditional deletes are supported, but only single resources at a time.
    /// </summary>
    public static readonly Coding SingleDeletesSupported = new Coding
    {
      Code = "single",
      Display = "Single Deletes Supported",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ValueIsTrue = new Coding
    {
      Code = "true",
      Display = "Value is true",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Versioned = new Coding
    {
      Code = "versioned",
      Display = "Versioned",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VersionIdTrackedFully = new Coding
    {
      Code = "versioned-update",
      Display = "VersionId tracked fully",
      System = "http://hl7.org/fhir/CodeSystem/capability-features"
    };

    /// <summary>
    /// Literal for code: ReferenceIntegrityEnforced
    /// </summary>
    public const string LiteralReferenceIntegrityEnforced = "enforced";

    /// <summary>
    /// Literal for code: ValueIsFalse
    /// </summary>
    public const string LiteralValueIsFalse = "false";

    /// <summary>
    /// Literal for code: FullSupport
    /// </summary>
    public const string LiteralFullSupport = "full-support";

    /// <summary>
    /// Literal for code: LiteralReferences
    /// </summary>
    public const string LiteralLiteralReferences = "literal";

    /// <summary>
    /// Literal for code: LocalReferencesOnly
    /// </summary>
    public const string LiteralLocalReferencesOnly = "local";

    /// <summary>
    /// Literal for code: LogicalReferences
    /// </summary>
    public const string LiteralLogicalReferences = "logical";

    /// <summary>
    /// Literal for code: IfModifiedSince
    /// </summary>
    public const string LiteralIfModifiedSince = "modified-since";

    /// <summary>
    /// Literal for code: MultipleDeletesSupported
    /// </summary>
    public const string LiteralMultipleDeletesSupported = "multiple";

    /// <summary>
    /// Literal for code: IfNoneMatch
    /// </summary>
    public const string LiteralIfNoneMatch = "not-match";

    /// <summary>
    /// Literal for code: NotSupported
    /// </summary>
    public const string LiteralNotSupported = "not-supported";

    /// <summary>
    /// Literal for code: NoVersionIdSupport
    /// </summary>
    public const string LiteralNoVersionIdSupport = "no-version";

    /// <summary>
    /// Literal for code: ResolvesReferences
    /// </summary>
    public const string LiteralResolvesReferences = "resolves";

    /// <summary>
    /// Literal for code: SingleDeletesSupported
    /// </summary>
    public const string LiteralSingleDeletesSupported = "single";

    /// <summary>
    /// Literal for code: ValueIsTrue
    /// </summary>
    public const string LiteralValueIsTrue = "true";

    /// <summary>
    /// Literal for code: Versioned
    /// </summary>
    public const string LiteralVersioned = "versioned";

    /// <summary>
    /// Literal for code: VersionIdTrackedFully
    /// </summary>
    public const string LiteralVersionIdTrackedFully = "versioned-update";
  };
}
