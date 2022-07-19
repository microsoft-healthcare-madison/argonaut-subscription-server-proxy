// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes sample Contract Term SubType codes.
  /// </summary>
  public static class ContractTermSubtypeCodes
  {
    /// <summary>
    /// Condition
    /// </summary>
    public static readonly Coding Condition = new Coding
    {
      Code = "condition",
      Display = "Condition",
      System = "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes"
    };
    /// <summary>
    /// Innominate
    /// </summary>
    public static readonly Coding Innominate = new Coding
    {
      Code = "innominate",
      Display = "Innominate",
      System = "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes"
    };
    /// <summary>
    /// Warranty
    /// </summary>
    public static readonly Coding Warranty = new Coding
    {
      Code = "warranty",
      Display = "Warranty",
      System = "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes"
    };

    /// <summary>
    /// Literal for code: Condition
    /// </summary>
    public const string LiteralCondition = "condition";

    /// <summary>
    /// Literal for code: ContracttermsubtypecodesCondition
    /// </summary>
    public const string LiteralContracttermsubtypecodesCondition = "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes#condition";

    /// <summary>
    /// Literal for code: Innominate
    /// </summary>
    public const string LiteralInnominate = "innominate";

    /// <summary>
    /// Literal for code: ContracttermsubtypecodesInnominate
    /// </summary>
    public const string LiteralContracttermsubtypecodesInnominate = "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes#innominate";

    /// <summary>
    /// Literal for code: Warranty
    /// </summary>
    public const string LiteralWarranty = "warranty";

    /// <summary>
    /// Literal for code: ContracttermsubtypecodesWarranty
    /// </summary>
    public const string LiteralContracttermsubtypecodesWarranty = "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes#warranty";

    /// <summary>
    /// Dictionary for looking up ContractTermSubtype Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "condition", Condition }, 
      { "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes#condition", Condition }, 
      { "innominate", Innominate }, 
      { "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes#innominate", Innominate }, 
      { "warranty", Warranty }, 
      { "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes#warranty", Warranty }, 
    };
  };
}
