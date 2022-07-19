// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Example list of general categories for flagged issues. (Not complete or necessarily appropriate.)
  /// </summary>
  public static class FlagCategoryCodes
  {
    /// <summary>
    /// Administrative
    /// </summary>
    public static readonly Coding Administrative = new Coding
    {
      Code = "admin",
      Display = "Administrative",
      System = "http://terminology.hl7.org/CodeSystem/flag-category"
    };
    /// <summary>
    /// Advance Directive
    /// </summary>
    public static readonly Coding AdvanceDirective = new Coding
    {
      Code = "advance-directive",
      Display = "Advance Directive",
      System = "http://terminology.hl7.org/CodeSystem/flag-category"
    };
    /// <summary>
    /// Behavioral
    /// </summary>
    public static readonly Coding Behavioral = new Coding
    {
      Code = "behavioral",
      Display = "Behavioral",
      System = "http://terminology.hl7.org/CodeSystem/flag-category"
    };
    /// <summary>
    /// Clinical
    /// </summary>
    public static readonly Coding Clinical = new Coding
    {
      Code = "clinical",
      Display = "Clinical",
      System = "http://terminology.hl7.org/CodeSystem/flag-category"
    };
    /// <summary>
    /// Subject Contact
    /// </summary>
    public static readonly Coding SubjectContact = new Coding
    {
      Code = "contact",
      Display = "Subject Contact",
      System = "http://terminology.hl7.org/CodeSystem/flag-category"
    };
    /// <summary>
    /// Diet
    /// </summary>
    public static readonly Coding Diet = new Coding
    {
      Code = "diet",
      Display = "Diet",
      System = "http://terminology.hl7.org/CodeSystem/flag-category"
    };
    /// <summary>
    /// Drug
    /// </summary>
    public static readonly Coding Drug = new Coding
    {
      Code = "drug",
      Display = "Drug",
      System = "http://terminology.hl7.org/CodeSystem/flag-category"
    };
    /// <summary>
    /// Lab
    /// </summary>
    public static readonly Coding Lab = new Coding
    {
      Code = "lab",
      Display = "Lab",
      System = "http://terminology.hl7.org/CodeSystem/flag-category"
    };
    /// <summary>
    /// Research
    /// </summary>
    public static readonly Coding Research = new Coding
    {
      Code = "research",
      Display = "Research",
      System = "http://terminology.hl7.org/CodeSystem/flag-category"
    };
    /// <summary>
    /// Safety
    /// </summary>
    public static readonly Coding Safety = new Coding
    {
      Code = "safety",
      Display = "Safety",
      System = "http://terminology.hl7.org/CodeSystem/flag-category"
    };

    /// <summary>
    /// Literal for code: Administrative
    /// </summary>
    public const string LiteralAdministrative = "admin";

    /// <summary>
    /// Literal for code: FlagCategoryAdministrative
    /// </summary>
    public const string LiteralFlagCategoryAdministrative = "http://terminology.hl7.org/CodeSystem/flag-category#admin";

    /// <summary>
    /// Literal for code: AdvanceDirective
    /// </summary>
    public const string LiteralAdvanceDirective = "advance-directive";

    /// <summary>
    /// Literal for code: FlagCategoryAdvanceDirective
    /// </summary>
    public const string LiteralFlagCategoryAdvanceDirective = "http://terminology.hl7.org/CodeSystem/flag-category#advance-directive";

    /// <summary>
    /// Literal for code: Behavioral
    /// </summary>
    public const string LiteralBehavioral = "behavioral";

    /// <summary>
    /// Literal for code: FlagCategoryBehavioral
    /// </summary>
    public const string LiteralFlagCategoryBehavioral = "http://terminology.hl7.org/CodeSystem/flag-category#behavioral";

    /// <summary>
    /// Literal for code: Clinical
    /// </summary>
    public const string LiteralClinical = "clinical";

    /// <summary>
    /// Literal for code: FlagCategoryClinical
    /// </summary>
    public const string LiteralFlagCategoryClinical = "http://terminology.hl7.org/CodeSystem/flag-category#clinical";

    /// <summary>
    /// Literal for code: SubjectContact
    /// </summary>
    public const string LiteralSubjectContact = "contact";

    /// <summary>
    /// Literal for code: FlagCategorySubjectContact
    /// </summary>
    public const string LiteralFlagCategorySubjectContact = "http://terminology.hl7.org/CodeSystem/flag-category#contact";

    /// <summary>
    /// Literal for code: Diet
    /// </summary>
    public const string LiteralDiet = "diet";

    /// <summary>
    /// Literal for code: FlagCategoryDiet
    /// </summary>
    public const string LiteralFlagCategoryDiet = "http://terminology.hl7.org/CodeSystem/flag-category#diet";

    /// <summary>
    /// Literal for code: Drug
    /// </summary>
    public const string LiteralDrug = "drug";

    /// <summary>
    /// Literal for code: FlagCategoryDrug
    /// </summary>
    public const string LiteralFlagCategoryDrug = "http://terminology.hl7.org/CodeSystem/flag-category#drug";

    /// <summary>
    /// Literal for code: Lab
    /// </summary>
    public const string LiteralLab = "lab";

    /// <summary>
    /// Literal for code: FlagCategoryLab
    /// </summary>
    public const string LiteralFlagCategoryLab = "http://terminology.hl7.org/CodeSystem/flag-category#lab";

    /// <summary>
    /// Literal for code: Research
    /// </summary>
    public const string LiteralResearch = "research";

    /// <summary>
    /// Literal for code: FlagCategoryResearch
    /// </summary>
    public const string LiteralFlagCategoryResearch = "http://terminology.hl7.org/CodeSystem/flag-category#research";

    /// <summary>
    /// Literal for code: Safety
    /// </summary>
    public const string LiteralSafety = "safety";

    /// <summary>
    /// Literal for code: FlagCategorySafety
    /// </summary>
    public const string LiteralFlagCategorySafety = "http://terminology.hl7.org/CodeSystem/flag-category#safety";

    /// <summary>
    /// Dictionary for looking up FlagCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "admin", Administrative }, 
      { "http://terminology.hl7.org/CodeSystem/flag-category#admin", Administrative }, 
      { "advance-directive", AdvanceDirective }, 
      { "http://terminology.hl7.org/CodeSystem/flag-category#advance-directive", AdvanceDirective }, 
      { "behavioral", Behavioral }, 
      { "http://terminology.hl7.org/CodeSystem/flag-category#behavioral", Behavioral }, 
      { "clinical", Clinical }, 
      { "http://terminology.hl7.org/CodeSystem/flag-category#clinical", Clinical }, 
      { "contact", SubjectContact }, 
      { "http://terminology.hl7.org/CodeSystem/flag-category#contact", SubjectContact }, 
      { "diet", Diet }, 
      { "http://terminology.hl7.org/CodeSystem/flag-category#diet", Diet }, 
      { "drug", Drug }, 
      { "http://terminology.hl7.org/CodeSystem/flag-category#drug", Drug }, 
      { "lab", Lab }, 
      { "http://terminology.hl7.org/CodeSystem/flag-category#lab", Lab }, 
      { "research", Research }, 
      { "http://terminology.hl7.org/CodeSystem/flag-category#research", Research }, 
      { "safety", Safety }, 
      { "http://terminology.hl7.org/CodeSystem/flag-category#safety", Safety }, 
    };
  };
}
