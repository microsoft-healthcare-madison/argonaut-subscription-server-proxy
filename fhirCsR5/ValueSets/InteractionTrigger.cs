// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// FHIR RESTful interaction codes used for SubscriptionTopic trigger.
  /// </summary>
  public static class InteractionTriggerCodes
  {
    /// <summary>
    /// Create a new resource with a server assigned id.
    /// </summary>
    public static readonly Coding Create = new Coding
    {
      Code = "create",
      Display = "create",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Delete a resource.
    /// </summary>
    public static readonly Coding Delete = new Coding
    {
      Code = "delete",
      Display = "delete",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Update an existing resource by its id (or create it if it is new).
    /// </summary>
    public static readonly Coding Update = new Coding
    {
      Code = "update",
      Display = "update",
      System = "http://hl7.org/fhir/restful-interaction"
    };

    /// <summary>
    /// Literal for code: Create
    /// </summary>
    public const string LiteralCreate = "create";

    /// <summary>
    /// Literal for code: RestfulInteractionCreate
    /// </summary>
    public const string LiteralRestfulInteractionCreate = "http://hl7.org/fhir/restful-interaction#create";

    /// <summary>
    /// Literal for code: Delete
    /// </summary>
    public const string LiteralDelete = "delete";

    /// <summary>
    /// Literal for code: RestfulInteractionDelete
    /// </summary>
    public const string LiteralRestfulInteractionDelete = "http://hl7.org/fhir/restful-interaction#delete";

    /// <summary>
    /// Literal for code: Update
    /// </summary>
    public const string LiteralUpdate = "update";

    /// <summary>
    /// Literal for code: RestfulInteractionUpdate
    /// </summary>
    public const string LiteralRestfulInteractionUpdate = "http://hl7.org/fhir/restful-interaction#update";

    /// <summary>
    /// Dictionary for looking up InteractionTrigger Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "create", Create }, 
      { "http://hl7.org/fhir/restful-interaction#create", Create }, 
      { "delete", Delete }, 
      { "http://hl7.org/fhir/restful-interaction#delete", Delete }, 
      { "update", Update }, 
      { "http://hl7.org/fhir/restful-interaction#update", Update }, 
    };
  };
}
