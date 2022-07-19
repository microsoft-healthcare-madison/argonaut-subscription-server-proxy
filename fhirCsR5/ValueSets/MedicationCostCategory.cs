// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Medication Cost Category Codes
  /// </summary>
  public static class MedicationCostCategoryCodes
  {
    /// <summary>
    /// Tier A cost for this medication
    /// </summary>
    public static readonly Coding BandA = new Coding
    {
      Code = "banda",
      Display = "Band A",
      System = "http://terminology.hl7.org/CodeSystem/medication-cost-category"
    };
    /// <summary>
    /// Tier B cost for this medication
    /// </summary>
    public static readonly Coding BandB = new Coding
    {
      Code = "bandb",
      Display = "Band B",
      System = "http://terminology.hl7.org/CodeSystem/medication-cost-category"
    };

    /// <summary>
    /// Literal for code: BandA
    /// </summary>
    public const string LiteralBandA = "banda";

    /// <summary>
    /// Literal for code: MedicationCostCategoryBandA
    /// </summary>
    public const string LiteralMedicationCostCategoryBandA = "http://terminology.hl7.org/CodeSystem/medication-cost-category#banda";

    /// <summary>
    /// Literal for code: BandB
    /// </summary>
    public const string LiteralBandB = "bandb";

    /// <summary>
    /// Literal for code: MedicationCostCategoryBandB
    /// </summary>
    public const string LiteralMedicationCostCategoryBandB = "http://terminology.hl7.org/CodeSystem/medication-cost-category#bandb";

    /// <summary>
    /// Dictionary for looking up MedicationCostCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "banda", BandA }, 
      { "http://terminology.hl7.org/CodeSystem/medication-cost-category#banda", BandA }, 
      { "bandb", BandB }, 
      { "http://terminology.hl7.org/CodeSystem/medication-cost-category#bandb", BandB }, 
    };
  };
}
