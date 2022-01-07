// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes Coverage Class codes.
  /// </summary>
  public static class CoverageClassCodes
  {
    /// <summary>
    /// A class of benefits.
    /// </summary>
    public static readonly Coding Class = new Coding
    {
      Code = "class",
      Display = "Class",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// An employee group
    /// </summary>
    public static readonly Coding Group = new Coding
    {
      Code = "group",
      Display = "Group",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A specific suite of benefits.
    /// </summary>
    public static readonly Coding Plan = new Coding
    {
      Code = "plan",
      Display = "Plan",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// Pharmacy benefit manager's Business Identification Number.
    /// </summary>
    public static readonly Coding RXBIN = new Coding
    {
      Code = "rxbin",
      Display = "RX BIN",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A Pharmacy Benefit Manager specified Group number.
    /// </summary>
    public static readonly Coding RXGroup = new Coding
    {
      Code = "rxgroup",
      Display = "RX Group",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A Pharmacy Benefit Manager specified Member ID.
    /// </summary>
    public static readonly Coding RXId = new Coding
    {
      Code = "rxid",
      Display = "RX Id",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A Pharmacy Benefit Manager specified Processor Control Number.
    /// </summary>
    public static readonly Coding RXPCN = new Coding
    {
      Code = "rxpcn",
      Display = "RX PCN",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A sequence number associated with a short-term continuance of the coverage.
    /// </summary>
    public static readonly Coding Sequence = new Coding
    {
      Code = "sequence",
      Display = "Sequence",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A subset of a class of benefits.
    /// </summary>
    public static readonly Coding SubClass = new Coding
    {
      Code = "subclass",
      Display = "SubClass",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A sub-group of an employee group
    /// </summary>
    public static readonly Coding SubGroup = new Coding
    {
      Code = "subgroup",
      Display = "SubGroup",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A subset of a specific suite of benefits.
    /// </summary>
    public static readonly Coding SubPlan = new Coding
    {
      Code = "subplan",
      Display = "SubPlan",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };

    /// <summary>
    /// Literal for code: Class
    /// </summary>
    public const string LiteralClass = "class";

    /// <summary>
    /// Literal for code: Group
    /// </summary>
    public const string LiteralGroup = "group";

    /// <summary>
    /// Literal for code: Plan
    /// </summary>
    public const string LiteralPlan = "plan";

    /// <summary>
    /// Literal for code: RXBIN
    /// </summary>
    public const string LiteralRXBIN = "rxbin";

    /// <summary>
    /// Literal for code: RXGroup
    /// </summary>
    public const string LiteralRXGroup = "rxgroup";

    /// <summary>
    /// Literal for code: RXId
    /// </summary>
    public const string LiteralRXId = "rxid";

    /// <summary>
    /// Literal for code: RXPCN
    /// </summary>
    public const string LiteralRXPCN = "rxpcn";

    /// <summary>
    /// Literal for code: Sequence
    /// </summary>
    public const string LiteralSequence = "sequence";

    /// <summary>
    /// Literal for code: SubClass
    /// </summary>
    public const string LiteralSubClass = "subclass";

    /// <summary>
    /// Literal for code: SubGroup
    /// </summary>
    public const string LiteralSubGroup = "subgroup";

    /// <summary>
    /// Literal for code: SubPlan
    /// </summary>
    public const string LiteralSubPlan = "subplan";
  };
}