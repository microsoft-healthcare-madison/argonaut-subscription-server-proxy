// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Codes indicating the degree of authority/intentionality associated with a request.
  /// </summary>
  public static class RequestIntentCodes
  {
    /// <summary>
    /// The request represents a legally binding instruction authored by a Patient or RelatedPerson.
    /// </summary>
    public static readonly Coding Directive = new Coding
    {
      Code = "directive",
      Display = "Directive",
      System = "http://hl7.org/fhir/request-intent"
    };
    /// <summary>
    /// The request represents the view of an authorization instantiated by a fulfilling system representing the details of the fulfiller's intention to act upon a submitted order.
    /// </summary>
    public static readonly Coding FillerOrder = new Coding
    {
      Code = "filler-order",
      Display = "Filler Order",
      System = "http://hl7.org/fhir/request-intent"
    };
    /// <summary>
    /// An order created in fulfillment of a broader order that represents the authorization for a single activity occurrence.  E.g. The administration of a single dose of a drug.
    /// </summary>
    public static readonly Coding InstanceOrder = new Coding
    {
      Code = "instance-order",
      Display = "Instance Order",
      System = "http://hl7.org/fhir/request-intent"
    };
    /// <summary>
    /// The request represents a component or option for a RequestGroup that establishes timing, conditionality and/or other constraints among a set of requests.  Refer to [[[RequestGroup]]] for additional information on how this status is used.
    /// </summary>
    public static readonly Coding Option = new Coding
    {
      Code = "option",
      Display = "Option",
      System = "http://hl7.org/fhir/request-intent"
    };
    /// <summary>
    /// The request represents a request/demand and authorization for action by a Practitioner.
    /// </summary>
    public static readonly Coding Order = new Coding
    {
      Code = "order",
      Display = "Order",
      System = "http://hl7.org/fhir/request-intent"
    };
    /// <summary>
    /// The request represents an original authorization for action.
    /// </summary>
    public static readonly Coding OriginalOrder = new Coding
    {
      Code = "original-order",
      Display = "Original Order",
      System = "http://hl7.org/fhir/request-intent"
    };
    /// <summary>
    /// The request represents an intention to ensure something occurs without providing an authorization for others to act.
    /// </summary>
    public static readonly Coding Plan = new Coding
    {
      Code = "plan",
      Display = "Plan",
      System = "http://hl7.org/fhir/request-intent"
    };
    /// <summary>
    /// The request is a suggestion made by someone/something that does not have an intention to ensure it occurs and without providing an authorization to act.
    /// </summary>
    public static readonly Coding Proposal = new Coding
    {
      Code = "proposal",
      Display = "Proposal",
      System = "http://hl7.org/fhir/request-intent"
    };
    /// <summary>
    /// The request represents an automatically generated supplemental authorization for action based on a parent authorization together with initial results of the action taken against that parent authorization.
    /// </summary>
    public static readonly Coding ReflexOrder = new Coding
    {
      Code = "reflex-order",
      Display = "Reflex Order",
      System = "http://hl7.org/fhir/request-intent"
    };

    /// <summary>
    /// Literal for code: Directive
    /// </summary>
    public const string LiteralDirective = "directive";

    /// <summary>
    /// Literal for code: FillerOrder
    /// </summary>
    public const string LiteralFillerOrder = "filler-order";

    /// <summary>
    /// Literal for code: InstanceOrder
    /// </summary>
    public const string LiteralInstanceOrder = "instance-order";

    /// <summary>
    /// Literal for code: Option
    /// </summary>
    public const string LiteralOption = "option";

    /// <summary>
    /// Literal for code: Order
    /// </summary>
    public const string LiteralOrder = "order";

    /// <summary>
    /// Literal for code: OriginalOrder
    /// </summary>
    public const string LiteralOriginalOrder = "original-order";

    /// <summary>
    /// Literal for code: Plan
    /// </summary>
    public const string LiteralPlan = "plan";

    /// <summary>
    /// Literal for code: Proposal
    /// </summary>
    public const string LiteralProposal = "proposal";

    /// <summary>
    /// Literal for code: ReflexOrder
    /// </summary>
    public const string LiteralReflexOrder = "reflex-order";
  };
}
