// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// A list of all the definition resource types defined in this version of the FHIR specification.
  /// </summary>
  public static class DefinitionResourceTypesCodes
  {
    /// <summary>
    /// This resource allows for the definition of some activity to be performed, independent of a particular patient, practitioner, or other performance context.
    /// </summary>
    public static readonly Coding ActivityDefinition = new Coding
    {
      Code = "ActivityDefinition",
      Display = "ActivityDefinition",
      System = "http://hl7.org/fhir/definition-resource-types"
    };
    /// <summary>
    /// The EventDefinition resource provides a reusable description of when a particular event can occur.
    /// </summary>
    public static readonly Coding EventDefinition = new Coding
    {
      Code = "EventDefinition",
      Display = "EventDefinition",
      System = "http://hl7.org/fhir/definition-resource-types"
    };
    /// <summary>
    /// The Measure resource provides the definition of a quality measure.
    /// </summary>
    public static readonly Coding Measure = new Coding
    {
      Code = "Measure",
      Display = "Measure",
      System = "http://hl7.org/fhir/definition-resource-types"
    };
    /// <summary>
    /// A formal computable definition of an operation (on the RESTful interface) or a named query (using the search interaction).
    /// </summary>
    public static readonly Coding OperationDefinition = new Coding
    {
      Code = "OperationDefinition",
      Display = "OperationDefinition",
      System = "http://hl7.org/fhir/definition-resource-types"
    };
    /// <summary>
    /// This resource allows for the definition of various types of plans as a sharable, consumable, and executable artifact. The resource is general enough to support the description of a broad range of clinical artifacts such as clinical decision support rules, order sets and protocols.
    /// </summary>
    public static readonly Coding PlanDefinition = new Coding
    {
      Code = "PlanDefinition",
      Display = "PlanDefinition",
      System = "http://hl7.org/fhir/definition-resource-types"
    };
    /// <summary>
    /// A structured set of questions intended to guide the collection of answers from end-users. Questionnaires provide detailed control over order, presentation, phraseology and grouping to allow coherent, consistent data collection.
    /// </summary>
    public static readonly Coding Questionnaire = new Coding
    {
      Code = "Questionnaire",
      Display = "Questionnaire",
      System = "http://hl7.org/fhir/definition-resource-types"
    };

    /// <summary>
    /// Literal for code: ActivityDefinition
    /// </summary>
    public const string LiteralActivityDefinition = "ActivityDefinition";

    /// <summary>
    /// Literal for code: DefinitionResourceTypesActivityDefinition
    /// </summary>
    public const string LiteralDefinitionResourceTypesActivityDefinition = "http://hl7.org/fhir/definition-resource-types#ActivityDefinition";

    /// <summary>
    /// Literal for code: EventDefinition
    /// </summary>
    public const string LiteralEventDefinition = "EventDefinition";

    /// <summary>
    /// Literal for code: DefinitionResourceTypesEventDefinition
    /// </summary>
    public const string LiteralDefinitionResourceTypesEventDefinition = "http://hl7.org/fhir/definition-resource-types#EventDefinition";

    /// <summary>
    /// Literal for code: Measure
    /// </summary>
    public const string LiteralMeasure = "Measure";

    /// <summary>
    /// Literal for code: DefinitionResourceTypesMeasure
    /// </summary>
    public const string LiteralDefinitionResourceTypesMeasure = "http://hl7.org/fhir/definition-resource-types#Measure";

    /// <summary>
    /// Literal for code: OperationDefinition
    /// </summary>
    public const string LiteralOperationDefinition = "OperationDefinition";

    /// <summary>
    /// Literal for code: DefinitionResourceTypesOperationDefinition
    /// </summary>
    public const string LiteralDefinitionResourceTypesOperationDefinition = "http://hl7.org/fhir/definition-resource-types#OperationDefinition";

    /// <summary>
    /// Literal for code: PlanDefinition
    /// </summary>
    public const string LiteralPlanDefinition = "PlanDefinition";

    /// <summary>
    /// Literal for code: DefinitionResourceTypesPlanDefinition
    /// </summary>
    public const string LiteralDefinitionResourceTypesPlanDefinition = "http://hl7.org/fhir/definition-resource-types#PlanDefinition";

    /// <summary>
    /// Literal for code: Questionnaire
    /// </summary>
    public const string LiteralQuestionnaire = "Questionnaire";

    /// <summary>
    /// Literal for code: DefinitionResourceTypesQuestionnaire
    /// </summary>
    public const string LiteralDefinitionResourceTypesQuestionnaire = "http://hl7.org/fhir/definition-resource-types#Questionnaire";

    /// <summary>
    /// Dictionary for looking up DefinitionResourceTypes Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "ActivityDefinition", ActivityDefinition }, 
      { "http://hl7.org/fhir/definition-resource-types#ActivityDefinition", ActivityDefinition }, 
      { "EventDefinition", EventDefinition }, 
      { "http://hl7.org/fhir/definition-resource-types#EventDefinition", EventDefinition }, 
      { "Measure", Measure }, 
      { "http://hl7.org/fhir/definition-resource-types#Measure", Measure }, 
      { "OperationDefinition", OperationDefinition }, 
      { "http://hl7.org/fhir/definition-resource-types#OperationDefinition", OperationDefinition }, 
      { "PlanDefinition", PlanDefinition }, 
      { "http://hl7.org/fhir/definition-resource-types#PlanDefinition", PlanDefinition }, 
      { "Questionnaire", Questionnaire }, 
      { "http://hl7.org/fhir/definition-resource-types#Questionnaire", Questionnaire }, 
    };
  };
}
