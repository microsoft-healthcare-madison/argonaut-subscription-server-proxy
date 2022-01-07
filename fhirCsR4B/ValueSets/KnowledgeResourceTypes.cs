// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// A list of all the knowledge resource types defined in this version of the FHIR specification.
  /// </summary>
  public static class KnowledgeResourceTypesCodes
  {
    /// <summary>
    /// The definition of a specific activity to be taken, independent of any particular patient or context.
    /// </summary>
    public static readonly Coding ActivityDefinition = new Coding
    {
      Code = "ActivityDefinition",
      Display = "ActivityDefinition",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// A set of codes drawn from one or more code systems.
    /// </summary>
    public static readonly Coding CodeSystem = new Coding
    {
      Code = "CodeSystem",
      Display = "CodeSystem",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// A map from one set of concepts to one or more other concepts.
    /// </summary>
    public static readonly Coding ConceptMap = new Coding
    {
      Code = "ConceptMap",
      Display = "ConceptMap",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// Represents a library of quality improvement components.
    /// </summary>
    public static readonly Coding Library = new Coding
    {
      Code = "Library",
      Display = "Library",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// A quality measure definition.
    /// </summary>
    public static readonly Coding Measure = new Coding
    {
      Code = "Measure",
      Display = "Measure",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// The definition of a plan for a series of actions, independent of any specific patient or context.
    /// </summary>
    public static readonly Coding PlanDefinition = new Coding
    {
      Code = "PlanDefinition",
      Display = "PlanDefinition",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// Structural Definition.
    /// </summary>
    public static readonly Coding StructureDefinition = new Coding
    {
      Code = "StructureDefinition",
      Display = "StructureDefinition",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// A Map of relationships between 2 structures that can be used to transform data.
    /// </summary>
    public static readonly Coding StructureMap = new Coding
    {
      Code = "StructureMap",
      Display = "StructureMap",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };
    /// <summary>
    /// A set of codes drawn from one or more code systems.
    /// </summary>
    public static readonly Coding ValueSet = new Coding
    {
      Code = "ValueSet",
      Display = "ValueSet",
      System = "http://hl7.org/fhir/knowledge-resource-types"
    };

    /// <summary>
    /// Literal for code: ActivityDefinition
    /// </summary>
    public const string LiteralActivityDefinition = "ActivityDefinition";

    /// <summary>
    /// Literal for code: CodeSystem
    /// </summary>
    public const string LiteralCodeSystem = "CodeSystem";

    /// <summary>
    /// Literal for code: ConceptMap
    /// </summary>
    public const string LiteralConceptMap = "ConceptMap";

    /// <summary>
    /// Literal for code: Library
    /// </summary>
    public const string LiteralLibrary = "Library";

    /// <summary>
    /// Literal for code: Measure
    /// </summary>
    public const string LiteralMeasure = "Measure";

    /// <summary>
    /// Literal for code: PlanDefinition
    /// </summary>
    public const string LiteralPlanDefinition = "PlanDefinition";

    /// <summary>
    /// Literal for code: StructureDefinition
    /// </summary>
    public const string LiteralStructureDefinition = "StructureDefinition";

    /// <summary>
    /// Literal for code: StructureMap
    /// </summary>
    public const string LiteralStructureMap = "StructureMap";

    /// <summary>
    /// Literal for code: ValueSet
    /// </summary>
    public const string LiteralValueSet = "ValueSet";
  };
}
