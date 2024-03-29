// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Some potential code systems are:
  /// - [v3-DocumentCompletion](http://terminology.hl7.org/3.0.0/CodeSystem-v3-DocumentCompletion.html)
  /// - [v3-DataOperation](http://terminology.hl7.org/3.0.0/CodeSystem-v3-DataOperation.html)
  /// - [v3-ActCode](http://hl7.org/fhir/v3/ActCode/cs.html)
  /// - [ISO Lifecycle](http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle)
  /// </summary>
  public static class ProvenanceActivityTypeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Amend = new Coding
    {
      Code = "amend",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Deidentify = new Coding
    {
      Code = "deidentify",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Merge = new Coding
    {
      Code = "merge",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Originate = new Coding
    {
      Code = "originate",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Receive = new Coding
    {
      Code = "receive",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Transform = new Coding
    {
      Code = "transform",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Verify = new Coding
    {
      Code = "verify",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };

    /// <summary>
    /// Literal for code: Amend
    /// </summary>
    public const string LiteralAmend = "amend";

    /// <summary>
    /// Literal for code: Iso21089LifecycleAmend
    /// </summary>
    public const string LiteralIso21089LifecycleAmend = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#amend";

    /// <summary>
    /// Literal for code: Deidentify
    /// </summary>
    public const string LiteralDeidentify = "deidentify";

    /// <summary>
    /// Literal for code: Iso21089LifecycleDeidentify
    /// </summary>
    public const string LiteralIso21089LifecycleDeidentify = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#deidentify";

    /// <summary>
    /// Literal for code: Merge
    /// </summary>
    public const string LiteralMerge = "merge";

    /// <summary>
    /// Literal for code: Iso21089LifecycleMerge
    /// </summary>
    public const string LiteralIso21089LifecycleMerge = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#merge";

    /// <summary>
    /// Literal for code: Originate
    /// </summary>
    public const string LiteralOriginate = "originate";

    /// <summary>
    /// Literal for code: Iso21089LifecycleOriginate
    /// </summary>
    public const string LiteralIso21089LifecycleOriginate = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#originate";

    /// <summary>
    /// Literal for code: Receive
    /// </summary>
    public const string LiteralReceive = "receive";

    /// <summary>
    /// Literal for code: Iso21089LifecycleReceive
    /// </summary>
    public const string LiteralIso21089LifecycleReceive = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#receive";

    /// <summary>
    /// Literal for code: Transform
    /// </summary>
    public const string LiteralTransform = "transform";

    /// <summary>
    /// Literal for code: Iso21089LifecycleTransform
    /// </summary>
    public const string LiteralIso21089LifecycleTransform = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#transform";

    /// <summary>
    /// Literal for code: Verify
    /// </summary>
    public const string LiteralVerify = "verify";

    /// <summary>
    /// Literal for code: Iso21089LifecycleVerify
    /// </summary>
    public const string LiteralIso21089LifecycleVerify = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#verify";

    /// <summary>
    /// Dictionary for looking up ProvenanceActivityType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "amend", Amend }, 
      { "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#amend", Amend }, 
      { "deidentify", Deidentify }, 
      { "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#deidentify", Deidentify }, 
      { "merge", Merge }, 
      { "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#merge", Merge }, 
      { "originate", Originate }, 
      { "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#originate", Originate }, 
      { "receive", Receive }, 
      { "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#receive", Receive }, 
      { "transform", Transform }, 
      { "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#transform", Transform }, 
      { "verify", Verify }, 
      { "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle#verify", Verify }, 
    };
  };
}
