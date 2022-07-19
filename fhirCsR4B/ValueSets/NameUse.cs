// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The use of a human name.
  /// </summary>
  public static class NameUseCodes
  {
    /// <summary>
    /// Anonymous assigned name, alias, or pseudonym (used to protect a person's identity for privacy reasons).
    /// </summary>
    public static readonly Coding Anonymous = new Coding
    {
      Code = "anonymous",
      Display = "Anonymous",
      System = "http://hl7.org/fhir/name-use"
    };
    /// <summary>
    /// A name used prior to changing name because of marriage. This name use is for use by applications that collect and store names that were used prior to a marriage. Marriage naming customs vary greatly around the world, and are constantly changing. This term is not gender specific. The use of this term does not imply any particular history for a person's name.
    /// </summary>
    public static readonly Coding NameChangedForMarriage = new Coding
    {
      Code = "maiden",
      Display = "Name changed for Marriage",
      System = "http://hl7.org/fhir/name-use"
    };
    /// <summary>
    /// A name that is used to address the person in an informal manner, but is not part of their formal or usual name.
    /// </summary>
    public static readonly Coding Nickname = new Coding
    {
      Code = "nickname",
      Display = "Nickname",
      System = "http://hl7.org/fhir/name-use"
    };
    /// <summary>
    /// The formal name as registered in an official (government) registry, but which name might not be commonly used. May be called "legal name".
    /// </summary>
    public static readonly Coding Official = new Coding
    {
      Code = "official",
      Display = "Official",
      System = "http://hl7.org/fhir/name-use"
    };
    /// <summary>
    /// This name is no longer in use (or was never correct, but retained for records).
    /// </summary>
    public static readonly Coding Old = new Coding
    {
      Code = "old",
      Display = "Old",
      System = "http://hl7.org/fhir/name-use"
    };
    /// <summary>
    /// A temporary name. Name.period can provide more detailed information. This may also be used for temporary names assigned at birth or in emergency situations.
    /// </summary>
    public static readonly Coding Temp = new Coding
    {
      Code = "temp",
      Display = "Temp",
      System = "http://hl7.org/fhir/name-use"
    };
    /// <summary>
    /// Known as/conventional/the one you normally use.
    /// </summary>
    public static readonly Coding Usual = new Coding
    {
      Code = "usual",
      Display = "Usual",
      System = "http://hl7.org/fhir/name-use"
    };

    /// <summary>
    /// Literal for code: Anonymous
    /// </summary>
    public const string LiteralAnonymous = "anonymous";

    /// <summary>
    /// Literal for code: NameUseAnonymous
    /// </summary>
    public const string LiteralNameUseAnonymous = "http://hl7.org/fhir/name-use#anonymous";

    /// <summary>
    /// Literal for code: NameChangedForMarriage
    /// </summary>
    public const string LiteralNameChangedForMarriage = "maiden";

    /// <summary>
    /// Literal for code: NameUseNameChangedForMarriage
    /// </summary>
    public const string LiteralNameUseNameChangedForMarriage = "http://hl7.org/fhir/name-use#maiden";

    /// <summary>
    /// Literal for code: Nickname
    /// </summary>
    public const string LiteralNickname = "nickname";

    /// <summary>
    /// Literal for code: NameUseNickname
    /// </summary>
    public const string LiteralNameUseNickname = "http://hl7.org/fhir/name-use#nickname";

    /// <summary>
    /// Literal for code: Official
    /// </summary>
    public const string LiteralOfficial = "official";

    /// <summary>
    /// Literal for code: NameUseOfficial
    /// </summary>
    public const string LiteralNameUseOfficial = "http://hl7.org/fhir/name-use#official";

    /// <summary>
    /// Literal for code: Old
    /// </summary>
    public const string LiteralOld = "old";

    /// <summary>
    /// Literal for code: NameUseOld
    /// </summary>
    public const string LiteralNameUseOld = "http://hl7.org/fhir/name-use#old";

    /// <summary>
    /// Literal for code: Temp
    /// </summary>
    public const string LiteralTemp = "temp";

    /// <summary>
    /// Literal for code: NameUseTemp
    /// </summary>
    public const string LiteralNameUseTemp = "http://hl7.org/fhir/name-use#temp";

    /// <summary>
    /// Literal for code: Usual
    /// </summary>
    public const string LiteralUsual = "usual";

    /// <summary>
    /// Literal for code: NameUseUsual
    /// </summary>
    public const string LiteralNameUseUsual = "http://hl7.org/fhir/name-use#usual";

    /// <summary>
    /// Dictionary for looking up NameUse Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "anonymous", Anonymous }, 
      { "http://hl7.org/fhir/name-use#anonymous", Anonymous }, 
      { "maiden", NameChangedForMarriage }, 
      { "http://hl7.org/fhir/name-use#maiden", NameChangedForMarriage }, 
      { "nickname", Nickname }, 
      { "http://hl7.org/fhir/name-use#nickname", Nickname }, 
      { "official", Official }, 
      { "http://hl7.org/fhir/name-use#official", Official }, 
      { "old", Old }, 
      { "http://hl7.org/fhir/name-use#old", Old }, 
      { "temp", Temp }, 
      { "http://hl7.org/fhir/name-use#temp", Temp }, 
      { "usual", Usual }, 
      { "http://hl7.org/fhir/name-use#usual", Usual }, 
    };
  };
}
