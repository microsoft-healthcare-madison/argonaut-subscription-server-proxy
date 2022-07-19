// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// An example value set of SNOMED CT concepts that can classify a requested service
  /// </summary>
  public static class ServicerequestCategoryCodes
  {
    /// <summary>
    /// Laboratory procedure
    /// </summary>
    public static readonly Coding LaboratoryProcedure = new Coding
    {
      Code = "108252007",
      Display = "Laboratory procedure",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Imaging
    /// </summary>
    public static readonly Coding Imaging = new Coding
    {
      Code = "363679005",
      Display = "Imaging",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Surgical procedure
    /// </summary>
    public static readonly Coding SurgicalProcedure = new Coding
    {
      Code = "387713003",
      Display = "Surgical procedure",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Counselling
    /// </summary>
    public static readonly Coding Counselling = new Coding
    {
      Code = "409063005",
      Display = "Counselling",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Education
    /// </summary>
    public static readonly Coding Education = new Coding
    {
      Code = "409073007",
      Display = "Education",
      System = "http://snomed.info/sct"
    };

    /// <summary>
    /// Literal for code: LaboratoryProcedure
    /// </summary>
    public const string LiteralLaboratoryProcedure = "108252007";

    /// <summary>
    /// Literal for code: NONELaboratoryProcedure
    /// </summary>
    public const string LiteralNONELaboratoryProcedure = "http://snomed.info/sct#108252007";

    /// <summary>
    /// Literal for code: Imaging
    /// </summary>
    public const string LiteralImaging = "363679005";

    /// <summary>
    /// Literal for code: NONEImaging
    /// </summary>
    public const string LiteralNONEImaging = "http://snomed.info/sct#363679005";

    /// <summary>
    /// Literal for code: SurgicalProcedure
    /// </summary>
    public const string LiteralSurgicalProcedure = "387713003";

    /// <summary>
    /// Literal for code: NONESurgicalProcedure
    /// </summary>
    public const string LiteralNONESurgicalProcedure = "http://snomed.info/sct#387713003";

    /// <summary>
    /// Literal for code: Counselling
    /// </summary>
    public const string LiteralCounselling = "409063005";

    /// <summary>
    /// Literal for code: NONECounselling
    /// </summary>
    public const string LiteralNONECounselling = "http://snomed.info/sct#409063005";

    /// <summary>
    /// Literal for code: Education
    /// </summary>
    public const string LiteralEducation = "409073007";

    /// <summary>
    /// Literal for code: NONEEducation
    /// </summary>
    public const string LiteralNONEEducation = "http://snomed.info/sct#409073007";

    /// <summary>
    /// Dictionary for looking up ServicerequestCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "108252007", LaboratoryProcedure }, 
      { "http://snomed.info/sct#108252007", LaboratoryProcedure }, 
      { "363679005", Imaging }, 
      { "http://snomed.info/sct#363679005", Imaging }, 
      { "387713003", SurgicalProcedure }, 
      { "http://snomed.info/sct#387713003", SurgicalProcedure }, 
      { "409063005", Counselling }, 
      { "http://snomed.info/sct#409063005", Counselling }, 
      { "409073007", Education }, 
      { "http://snomed.info/sct#409073007", Education }, 
    };
  };
}
