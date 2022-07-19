// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set defines a set of codes that are used to indicate the supported operations of a testing engine or tool.
  /// </summary>
  public static class TestscriptOperationCodesCodes
  {
    /// <summary>
    /// Realizes an ActivityDefinition in a specific context
    /// </summary>
    public static readonly Coding Apply = new Coding
    {
      Code = "apply",
      Display = "$apply",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Update, create or delete a set of resources as independent actions.
    /// </summary>
    public static readonly Coding Batch = new Coding
    {
      Code = "batch",
      Display = "Batch",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Get a capability statement for the system.
    /// </summary>
    public static readonly Coding Capabilities = new Coding
    {
      Code = "capabilities",
      Display = "Capabilities",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Closure Table Maintenance
    /// </summary>
    public static readonly Coding Closure = new Coding
    {
      Code = "closure",
      Display = "$closure",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Compare two systems CapabilityStatements
    /// </summary>
    public static readonly Coding Conforms = new Coding
    {
      Code = "conforms",
      Display = "$conforms",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Create a new resource with a server assigned id.
    /// </summary>
    public static readonly Coding Create = new Coding
    {
      Code = "create",
      Display = "Create",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Aggregates and returns the parameters and data requirements for a resource and all its dependencies as a single module definition
    /// </summary>
    public static readonly Coding DataRequirements = new Coding
    {
      Code = "data-requirements",
      Display = "$data-requirements",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Delete a resource.
    /// </summary>
    public static readonly Coding Delete = new Coding
    {
      Code = "delete",
      Display = "Delete",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Conditionally delete one or more resources based on search parameters.
    /// </summary>
    public static readonly Coding DeleteCondMultiple = new Coding
    {
      Code = "deleteCondMultiple",
      Display = "Conditional Delete Multiple",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Conditionally delete a single resource based on search parameters.
    /// </summary>
    public static readonly Coding DeleteCondSingle = new Coding
    {
      Code = "deleteCondSingle",
      Display = "Conditional Delete Single",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Generate a Document
    /// </summary>
    public static readonly Coding Document = new Coding
    {
      Code = "document",
      Display = "$document",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Request clinical decision support guidance based on a specific decision support module
    /// </summary>
    public static readonly Coding Evaluate = new Coding
    {
      Code = "evaluate",
      Display = "$evaluate",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Invoke an eMeasure and obtain the results
    /// </summary>
    public static readonly Coding EvaluateMeasure = new Coding
    {
      Code = "evaluate-measure",
      Display = "$evaluate-measure",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Return all the related information as described in the Encounter or Patient
    /// </summary>
    public static readonly Coding Everything = new Coding
    {
      Code = "everything",
      Display = "$everything",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Value Set Expansion
    /// </summary>
    public static readonly Coding Expand = new Coding
    {
      Code = "expand",
      Display = "$expand",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Find a functional list
    /// </summary>
    public static readonly Coding Find = new Coding
    {
      Code = "find",
      Display = "$find",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Finding Codes based on supplied properties
    /// </summary>
    public static readonly Coding FindMatches = new Coding
    {
      Code = "find-matches",
      Display = "$find-matches",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Invoke a GraphQL query
    /// </summary>
    public static readonly Coding Graphql = new Coding
    {
      Code = "graphql",
      Display = "$graphql",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Retrieve the change history for a particular resource or resource type.
    /// </summary>
    public static readonly Coding History = new Coding
    {
      Code = "history",
      Display = "History",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Test if a server implements a client's required operations
    /// </summary>
    public static readonly Coding Implements = new Coding
    {
      Code = "implements",
      Display = "$implements",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Last N Observations Query
    /// </summary>
    public static readonly Coding Lastn = new Coding
    {
      Code = "lastn",
      Display = "$lastn",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Concept Look Up and Decomposition
    /// </summary>
    public static readonly Coding Lookup = new Coding
    {
      Code = "lookup",
      Display = "$lookup",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Find patient matches using MPI based logic
    /// </summary>
    public static readonly Coding Match = new Coding
    {
      Code = "match",
      Display = "$match",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Access a list of profiles, tags, and security labels
    /// </summary>
    public static readonly Coding Meta = new Coding
    {
      Code = "meta",
      Display = "$meta",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Add profiles, tags, and security labels to a resource
    /// </summary>
    public static readonly Coding MetaAdd = new Coding
    {
      Code = "meta-add",
      Display = "$meta-add",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Delete profiles, tags, and security labels for a resource
    /// </summary>
    public static readonly Coding MetaDelete = new Coding
    {
      Code = "meta-delete",
      Display = "$meta-delete",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Patch an existing resource by its id.
    /// </summary>
    public static readonly Coding Patch = new Coding
    {
      Code = "patch",
      Display = "Patch",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Populate Questionnaire
    /// </summary>
    public static readonly Coding Populate = new Coding
    {
      Code = "populate",
      Display = "$populate",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Generate HTML for Questionnaire
    /// </summary>
    public static readonly Coding Populatehtml = new Coding
    {
      Code = "populatehtml",
      Display = "$populatehtml",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Generate a link to a Questionnaire completion webpage
    /// </summary>
    public static readonly Coding Populatelink = new Coding
    {
      Code = "populatelink",
      Display = "$populatelink",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Process a message according to the defined event
    /// </summary>
    public static readonly Coding ProcessMessage = new Coding
    {
      Code = "process-message",
      Display = "$process-message",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Build Questionnaire
    /// </summary>
    public static readonly Coding Questionnaire = new Coding
    {
      Code = "questionnaire",
      Display = "$questionnaire",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Read the current state of the resource.
    /// </summary>
    public static readonly Coding Read = new Coding
    {
      Code = "read",
      Display = "Read",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Search based on some filter criteria.
    /// </summary>
    public static readonly Coding Search = new Coding
    {
      Code = "search",
      Display = "Search",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Observation Statistics
    /// </summary>
    public static readonly Coding Stats = new Coding
    {
      Code = "stats",
      Display = "$stats",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Fetch a subset of the CapabilityStatement resource
    /// </summary>
    public static readonly Coding Subset = new Coding
    {
      Code = "subset",
      Display = "$subset",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// CodeSystem Subsumption Testing
    /// </summary>
    public static readonly Coding Subsumes = new Coding
    {
      Code = "subsumes",
      Display = "$subsumes",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Update, create or delete a set of resources as a single transaction.
    /// </summary>
    public static readonly Coding Transaction = new Coding
    {
      Code = "transaction",
      Display = "Transaction",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Model Instance Transformation
    /// </summary>
    public static readonly Coding Transform = new Coding
    {
      Code = "transform",
      Display = "$transform",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Concept Translation
    /// </summary>
    public static readonly Coding Translate = new Coding
    {
      Code = "translate",
      Display = "$translate",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Update an existing resource by its id.
    /// </summary>
    public static readonly Coding Update = new Coding
    {
      Code = "update",
      Display = "Update",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Update an existing resource by its id (or create it if it is new).
    /// </summary>
    public static readonly Coding UpdateCreate = new Coding
    {
      Code = "updateCreate",
      Display = "Create using Update",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Validate a resource
    /// </summary>
    public static readonly Coding Validate = new Coding
    {
      Code = "validate",
      Display = "$validate",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// ValueSet based Validation
    /// </summary>
    public static readonly Coding ValidateCode = new Coding
    {
      Code = "validate-code",
      Display = "$validate-code",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };
    /// <summary>
    /// Read the state of a specific version of the resource.
    /// </summary>
    public static readonly Coding Vread = new Coding
    {
      Code = "vread",
      Display = "Version Read",
      System = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes"
    };

    /// <summary>
    /// Literal for code: Apply
    /// </summary>
    public const string LiteralApply = "apply";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesApply
    /// </summary>
    public const string LiteralTestscriptOperationCodesApply = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#apply";

    /// <summary>
    /// Literal for code: Batch
    /// </summary>
    public const string LiteralBatch = "batch";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesBatch
    /// </summary>
    public const string LiteralTestscriptOperationCodesBatch = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#batch";

    /// <summary>
    /// Literal for code: Capabilities
    /// </summary>
    public const string LiteralCapabilities = "capabilities";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesCapabilities
    /// </summary>
    public const string LiteralTestscriptOperationCodesCapabilities = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#capabilities";

    /// <summary>
    /// Literal for code: Closure
    /// </summary>
    public const string LiteralClosure = "closure";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesClosure
    /// </summary>
    public const string LiteralTestscriptOperationCodesClosure = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#closure";

    /// <summary>
    /// Literal for code: Conforms
    /// </summary>
    public const string LiteralConforms = "conforms";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesConforms
    /// </summary>
    public const string LiteralTestscriptOperationCodesConforms = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#conforms";

    /// <summary>
    /// Literal for code: Create
    /// </summary>
    public const string LiteralCreate = "create";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesCreate
    /// </summary>
    public const string LiteralTestscriptOperationCodesCreate = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#create";

    /// <summary>
    /// Literal for code: DataRequirements
    /// </summary>
    public const string LiteralDataRequirements = "data-requirements";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesDataRequirements
    /// </summary>
    public const string LiteralTestscriptOperationCodesDataRequirements = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#data-requirements";

    /// <summary>
    /// Literal for code: Delete
    /// </summary>
    public const string LiteralDelete = "delete";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesDelete
    /// </summary>
    public const string LiteralTestscriptOperationCodesDelete = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#delete";

    /// <summary>
    /// Literal for code: DeleteCondMultiple
    /// </summary>
    public const string LiteralDeleteCondMultiple = "deleteCondMultiple";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesDeleteCondMultiple
    /// </summary>
    public const string LiteralTestscriptOperationCodesDeleteCondMultiple = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#deleteCondMultiple";

    /// <summary>
    /// Literal for code: DeleteCondSingle
    /// </summary>
    public const string LiteralDeleteCondSingle = "deleteCondSingle";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesDeleteCondSingle
    /// </summary>
    public const string LiteralTestscriptOperationCodesDeleteCondSingle = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#deleteCondSingle";

    /// <summary>
    /// Literal for code: Document
    /// </summary>
    public const string LiteralDocument = "document";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesDocument
    /// </summary>
    public const string LiteralTestscriptOperationCodesDocument = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#document";

    /// <summary>
    /// Literal for code: Evaluate
    /// </summary>
    public const string LiteralEvaluate = "evaluate";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesEvaluate
    /// </summary>
    public const string LiteralTestscriptOperationCodesEvaluate = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#evaluate";

    /// <summary>
    /// Literal for code: EvaluateMeasure
    /// </summary>
    public const string LiteralEvaluateMeasure = "evaluate-measure";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesEvaluateMeasure
    /// </summary>
    public const string LiteralTestscriptOperationCodesEvaluateMeasure = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#evaluate-measure";

    /// <summary>
    /// Literal for code: Everything
    /// </summary>
    public const string LiteralEverything = "everything";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesEverything
    /// </summary>
    public const string LiteralTestscriptOperationCodesEverything = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#everything";

    /// <summary>
    /// Literal for code: Expand
    /// </summary>
    public const string LiteralExpand = "expand";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesExpand
    /// </summary>
    public const string LiteralTestscriptOperationCodesExpand = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#expand";

    /// <summary>
    /// Literal for code: Find
    /// </summary>
    public const string LiteralFind = "find";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesFind
    /// </summary>
    public const string LiteralTestscriptOperationCodesFind = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#find";

    /// <summary>
    /// Literal for code: FindMatches
    /// </summary>
    public const string LiteralFindMatches = "find-matches";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesFindMatches
    /// </summary>
    public const string LiteralTestscriptOperationCodesFindMatches = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#find-matches";

    /// <summary>
    /// Literal for code: Graphql
    /// </summary>
    public const string LiteralGraphql = "graphql";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesGraphql
    /// </summary>
    public const string LiteralTestscriptOperationCodesGraphql = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#graphql";

    /// <summary>
    /// Literal for code: History
    /// </summary>
    public const string LiteralHistory = "history";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesHistory
    /// </summary>
    public const string LiteralTestscriptOperationCodesHistory = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#history";

    /// <summary>
    /// Literal for code: Implements
    /// </summary>
    public const string LiteralImplements = "implements";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesImplements
    /// </summary>
    public const string LiteralTestscriptOperationCodesImplements = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#implements";

    /// <summary>
    /// Literal for code: Lastn
    /// </summary>
    public const string LiteralLastn = "lastn";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesLastn
    /// </summary>
    public const string LiteralTestscriptOperationCodesLastn = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#lastn";

    /// <summary>
    /// Literal for code: Lookup
    /// </summary>
    public const string LiteralLookup = "lookup";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesLookup
    /// </summary>
    public const string LiteralTestscriptOperationCodesLookup = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#lookup";

    /// <summary>
    /// Literal for code: Match
    /// </summary>
    public const string LiteralMatch = "match";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesMatch
    /// </summary>
    public const string LiteralTestscriptOperationCodesMatch = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#match";

    /// <summary>
    /// Literal for code: Meta
    /// </summary>
    public const string LiteralMeta = "meta";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesMeta
    /// </summary>
    public const string LiteralTestscriptOperationCodesMeta = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#meta";

    /// <summary>
    /// Literal for code: MetaAdd
    /// </summary>
    public const string LiteralMetaAdd = "meta-add";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesMetaAdd
    /// </summary>
    public const string LiteralTestscriptOperationCodesMetaAdd = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#meta-add";

    /// <summary>
    /// Literal for code: MetaDelete
    /// </summary>
    public const string LiteralMetaDelete = "meta-delete";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesMetaDelete
    /// </summary>
    public const string LiteralTestscriptOperationCodesMetaDelete = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#meta-delete";

    /// <summary>
    /// Literal for code: Patch
    /// </summary>
    public const string LiteralPatch = "patch";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesPatch
    /// </summary>
    public const string LiteralTestscriptOperationCodesPatch = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#patch";

    /// <summary>
    /// Literal for code: Populate
    /// </summary>
    public const string LiteralPopulate = "populate";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesPopulate
    /// </summary>
    public const string LiteralTestscriptOperationCodesPopulate = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#populate";

    /// <summary>
    /// Literal for code: Populatehtml
    /// </summary>
    public const string LiteralPopulatehtml = "populatehtml";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesPopulatehtml
    /// </summary>
    public const string LiteralTestscriptOperationCodesPopulatehtml = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#populatehtml";

    /// <summary>
    /// Literal for code: Populatelink
    /// </summary>
    public const string LiteralPopulatelink = "populatelink";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesPopulatelink
    /// </summary>
    public const string LiteralTestscriptOperationCodesPopulatelink = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#populatelink";

    /// <summary>
    /// Literal for code: ProcessMessage
    /// </summary>
    public const string LiteralProcessMessage = "process-message";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesProcessMessage
    /// </summary>
    public const string LiteralTestscriptOperationCodesProcessMessage = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#process-message";

    /// <summary>
    /// Literal for code: Questionnaire
    /// </summary>
    public const string LiteralQuestionnaire = "questionnaire";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesQuestionnaire
    /// </summary>
    public const string LiteralTestscriptOperationCodesQuestionnaire = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#questionnaire";

    /// <summary>
    /// Literal for code: Read
    /// </summary>
    public const string LiteralRead = "read";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesRead
    /// </summary>
    public const string LiteralTestscriptOperationCodesRead = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#read";

    /// <summary>
    /// Literal for code: Search
    /// </summary>
    public const string LiteralSearch = "search";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesSearch
    /// </summary>
    public const string LiteralTestscriptOperationCodesSearch = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#search";

    /// <summary>
    /// Literal for code: Stats
    /// </summary>
    public const string LiteralStats = "stats";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesStats
    /// </summary>
    public const string LiteralTestscriptOperationCodesStats = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#stats";

    /// <summary>
    /// Literal for code: Subset
    /// </summary>
    public const string LiteralSubset = "subset";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesSubset
    /// </summary>
    public const string LiteralTestscriptOperationCodesSubset = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#subset";

    /// <summary>
    /// Literal for code: Subsumes
    /// </summary>
    public const string LiteralSubsumes = "subsumes";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesSubsumes
    /// </summary>
    public const string LiteralTestscriptOperationCodesSubsumes = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#subsumes";

    /// <summary>
    /// Literal for code: Transaction
    /// </summary>
    public const string LiteralTransaction = "transaction";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesTransaction
    /// </summary>
    public const string LiteralTestscriptOperationCodesTransaction = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#transaction";

    /// <summary>
    /// Literal for code: Transform
    /// </summary>
    public const string LiteralTransform = "transform";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesTransform
    /// </summary>
    public const string LiteralTestscriptOperationCodesTransform = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#transform";

    /// <summary>
    /// Literal for code: Translate
    /// </summary>
    public const string LiteralTranslate = "translate";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesTranslate
    /// </summary>
    public const string LiteralTestscriptOperationCodesTranslate = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#translate";

    /// <summary>
    /// Literal for code: Update
    /// </summary>
    public const string LiteralUpdate = "update";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesUpdate
    /// </summary>
    public const string LiteralTestscriptOperationCodesUpdate = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#update";

    /// <summary>
    /// Literal for code: UpdateCreate
    /// </summary>
    public const string LiteralUpdateCreate = "updateCreate";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesUpdateCreate
    /// </summary>
    public const string LiteralTestscriptOperationCodesUpdateCreate = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#updateCreate";

    /// <summary>
    /// Literal for code: Validate
    /// </summary>
    public const string LiteralValidate = "validate";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesValidate
    /// </summary>
    public const string LiteralTestscriptOperationCodesValidate = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#validate";

    /// <summary>
    /// Literal for code: ValidateCode
    /// </summary>
    public const string LiteralValidateCode = "validate-code";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesValidateCode
    /// </summary>
    public const string LiteralTestscriptOperationCodesValidateCode = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#validate-code";

    /// <summary>
    /// Literal for code: Vread
    /// </summary>
    public const string LiteralVread = "vread";

    /// <summary>
    /// Literal for code: TestscriptOperationCodesVread
    /// </summary>
    public const string LiteralTestscriptOperationCodesVread = "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#vread";

    /// <summary>
    /// Dictionary for looking up TestscriptOperationCodes Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "apply", Apply }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#apply", Apply }, 
      { "batch", Batch }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#batch", Batch }, 
      { "capabilities", Capabilities }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#capabilities", Capabilities }, 
      { "closure", Closure }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#closure", Closure }, 
      { "conforms", Conforms }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#conforms", Conforms }, 
      { "create", Create }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#create", Create }, 
      { "data-requirements", DataRequirements }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#data-requirements", DataRequirements }, 
      { "delete", Delete }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#delete", Delete }, 
      { "deleteCondMultiple", DeleteCondMultiple }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#deleteCondMultiple", DeleteCondMultiple }, 
      { "deleteCondSingle", DeleteCondSingle }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#deleteCondSingle", DeleteCondSingle }, 
      { "document", Document }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#document", Document }, 
      { "evaluate", Evaluate }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#evaluate", Evaluate }, 
      { "evaluate-measure", EvaluateMeasure }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#evaluate-measure", EvaluateMeasure }, 
      { "everything", Everything }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#everything", Everything }, 
      { "expand", Expand }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#expand", Expand }, 
      { "find", Find }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#find", Find }, 
      { "find-matches", FindMatches }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#find-matches", FindMatches }, 
      { "graphql", Graphql }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#graphql", Graphql }, 
      { "history", History }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#history", History }, 
      { "implements", Implements }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#implements", Implements }, 
      { "lastn", Lastn }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#lastn", Lastn }, 
      { "lookup", Lookup }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#lookup", Lookup }, 
      { "match", Match }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#match", Match }, 
      { "meta", Meta }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#meta", Meta }, 
      { "meta-add", MetaAdd }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#meta-add", MetaAdd }, 
      { "meta-delete", MetaDelete }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#meta-delete", MetaDelete }, 
      { "patch", Patch }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#patch", Patch }, 
      { "populate", Populate }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#populate", Populate }, 
      { "populatehtml", Populatehtml }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#populatehtml", Populatehtml }, 
      { "populatelink", Populatelink }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#populatelink", Populatelink }, 
      { "process-message", ProcessMessage }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#process-message", ProcessMessage }, 
      { "questionnaire", Questionnaire }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#questionnaire", Questionnaire }, 
      { "read", Read }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#read", Read }, 
      { "search", Search }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#search", Search }, 
      { "stats", Stats }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#stats", Stats }, 
      { "subset", Subset }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#subset", Subset }, 
      { "subsumes", Subsumes }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#subsumes", Subsumes }, 
      { "transaction", Transaction }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#transaction", Transaction }, 
      { "transform", Transform }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#transform", Transform }, 
      { "translate", Translate }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#translate", Translate }, 
      { "update", Update }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#update", Update }, 
      { "updateCreate", UpdateCreate }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#updateCreate", UpdateCreate }, 
      { "validate", Validate }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#validate", Validate }, 
      { "validate-code", ValidateCode }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#validate-code", ValidateCode }, 
      { "vread", Vread }, 
      { "http://terminology.hl7.org/CodeSystem/testscript-operation-codes#vread", Vread }, 
    };
  };
}
