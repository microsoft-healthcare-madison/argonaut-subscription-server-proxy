// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes indicating the type of action that is expected to be performed
  /// </summary>
  public static class TaskCodeCodes
  {
    /// <summary>
    /// Abort, cancel or withdraw the focal resource, as appropriate for the type of resource.
    /// </summary>
    public static readonly Coding MarkTheFocalResourceAsNoLongerActive = new Coding
    {
      Code = "abort",
      Display = "Mark the focal resource as no longer active",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Take what actions are needed to transition the focus resource from 'draft' to 'active' or 'in-progress', as appropriate for the resource type.  This may involve additing additional content, approval, validation, etc.
    /// </summary>
    public static readonly Coding ActivateApproveTheFocalResource = new Coding
    {
      Code = "approve",
      Display = "Activate/approve the focal resource",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Update the focal resource of the owning system to reflect the content specified as the Task.focus
    /// </summary>
    public static readonly Coding ChangeTheFocalResource = new Coding
    {
      Code = "change",
      Display = "Change the focal resource",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Act to perform the actions described in the focus request.  This might result in a 'more assertive' request (order for a plan or proposal, filler order for a placer order), but is intend to eventually result in events.  The degree of fulfillment requested might be limited by Task.restriction.
    /// </summary>
    public static readonly Coding FulfillTheFocalRequest = new Coding
    {
      Code = "fulfill",
      Display = "Fulfill the focal request",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Act to perform the actions defined in the focus definition resource (ActivityDefinition, PlanDefinition, Questionnaire, etc.)  For PlanDefinition or ActivityDefinition, this might result in a 'more assertive' request (order for a plan or proposal, filler order for a placer order), but is intend to eventually result in events.  For Questionnaire, this would result in a QuestionnaireResponse - and possibly resources constructed using data extracted from the response.  The degree of fulfillment requested might be limited by Task.restriction.
    /// </summary>
    public static readonly Coding InstantiateTheFocalDefinition = new Coding
    {
      Code = "instantiate",
      Display = "Instantiate the focal definition",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Replace the focal resource with the specified input resource
    /// </summary>
    public static readonly Coding ReplaceTheFocalResourceWithTheInputResource = new Coding
    {
      Code = "replace",
      Display = "Replace the focal resource with the input resource",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Transition the focal resource from 'suspended' to 'active' or 'in-progress' as appropriate for the resource type.
    /// </summary>
    public static readonly Coding ReActivateTheFocalResource = new Coding
    {
      Code = "resume",
      Display = "Re-activate the focal resource",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Transition the focal resource from 'active' or 'in-progress' to 'suspended'
    /// </summary>
    public static readonly Coding SuspendTheFocalResource = new Coding
    {
      Code = "suspend",
      Display = "Suspend the focal resource",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };

    /// <summary>
    /// Literal for code: MarkTheFocalResourceAsNoLongerActive
    /// </summary>
    public const string LiteralMarkTheFocalResourceAsNoLongerActive = "abort";

    /// <summary>
    /// Literal for code: ActivateApproveTheFocalResource
    /// </summary>
    public const string LiteralActivateApproveTheFocalResource = "approve";

    /// <summary>
    /// Literal for code: ChangeTheFocalResource
    /// </summary>
    public const string LiteralChangeTheFocalResource = "change";

    /// <summary>
    /// Literal for code: FulfillTheFocalRequest
    /// </summary>
    public const string LiteralFulfillTheFocalRequest = "fulfill";

    /// <summary>
    /// Literal for code: InstantiateTheFocalDefinition
    /// </summary>
    public const string LiteralInstantiateTheFocalDefinition = "instantiate";

    /// <summary>
    /// Literal for code: ReplaceTheFocalResourceWithTheInputResource
    /// </summary>
    public const string LiteralReplaceTheFocalResourceWithTheInputResource = "replace";

    /// <summary>
    /// Literal for code: ReActivateTheFocalResource
    /// </summary>
    public const string LiteralReActivateTheFocalResource = "resume";

    /// <summary>
    /// Literal for code: SuspendTheFocalResource
    /// </summary>
    public const string LiteralSuspendTheFocalResource = "suspend";
  };
}
