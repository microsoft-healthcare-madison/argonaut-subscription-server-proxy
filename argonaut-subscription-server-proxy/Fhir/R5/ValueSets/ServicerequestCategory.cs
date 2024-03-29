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
    /// 
    /// </summary>
    public static readonly Coding LaboratoryProcedure = new Coding
    {
      Code = "108252007",
      Display = "Laboratory procedure",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Imaging = new Coding
    {
      Code = "363679005",
      Display = "Imaging",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SurgicalProcedure = new Coding
    {
      Code = "387713003",
      Display = "Surgical procedure",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Counselling = new Coding
    {
      Code = "409063005",
      Display = "Counselling",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
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
    /// Literal for code: Imaging
    /// </summary>
    public const string LiteralImaging = "363679005";

    /// <summary>
    /// Literal for code: SurgicalProcedure
    /// </summary>
    public const string LiteralSurgicalProcedure = "387713003";

    /// <summary>
    /// Literal for code: Counselling
    /// </summary>
    public const string LiteralCounselling = "409063005";

    /// <summary>
    /// Literal for code: Education
    /// </summary>
    public const string LiteralEducation = "409073007";
  };
}
