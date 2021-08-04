// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes the Patient to subscriber relationship codes.
  /// </summary>
  public static class RelationshipCodes
  {
    /// <summary>
    /// The patient is the subscriber (policy holder)
    /// </summary>
    public static readonly Coding Self = new Coding
    {
      Code = "1",
      Display = "Self",
      System = "http://hl7.org/fhir/relationship"
    };
    /// <summary>
    /// The patient is the spouse or equivalent of the subscriber (policy holder)
    /// </summary>
    public static readonly Coding Spouse = new Coding
    {
      Code = "2",
      Display = "Spouse",
      System = "http://hl7.org/fhir/relationship"
    };
    /// <summary>
    /// The patient is the child of the subscriber (policy holder)
    /// </summary>
    public static readonly Coding Child = new Coding
    {
      Code = "3",
      Display = "Child",
      System = "http://hl7.org/fhir/relationship"
    };
    /// <summary>
    /// The patient is the common law spouse of the subscriber (policy holder)
    /// </summary>
    public static readonly Coding CommonLawSpouse = new Coding
    {
      Code = "4",
      Display = "Common Law Spouse",
      System = "http://hl7.org/fhir/relationship"
    };
    /// <summary>
    /// The patient has some other relationship, such as parent, to the subscriber (policy holder)
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "5",
      Display = "Other",
      System = "http://hl7.org/fhir/relationship"
    };

    /// <summary>
    /// Literal for code: Self
    /// </summary>
    public const string LiteralSelf = "1";

    /// <summary>
    /// Literal for code: Spouse
    /// </summary>
    public const string LiteralSpouse = "2";

    /// <summary>
    /// Literal for code: Child
    /// </summary>
    public const string LiteralChild = "3";

    /// <summary>
    /// Literal for code: CommonLawSpouse
    /// </summary>
    public const string LiteralCommonLawSpouse = "4";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "5";
  };
}
