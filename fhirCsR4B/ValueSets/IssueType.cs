// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// A code that describes the type of issue.
  /// </summary>
  public static class IssueTypeCodes
  {
    /// <summary>
    /// The content/operation failed to pass some business rule and so could not proceed.
    /// </summary>
    public static readonly Coding BusinessRuleViolation = new Coding
    {
      Code = "business-rule",
      Display = "Business Rule Violation",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// The code or system could not be understood, or it was not valid in the context of a particular ValueSet.code.
    /// </summary>
    public static readonly Coding InvalidCode = new Coding
    {
      Code = "code-invalid",
      Display = "Invalid Code",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// Content could not be accepted because of an edit conflict (i.e. version aware updates). (In a pure RESTful environment, this would be an HTTP 409 error, but this code may be used where the conflict is discovered further into the application architecture.).
    /// </summary>
    public static readonly Coding EditVersionConflict = new Coding
    {
      Code = "conflict",
      Display = "Edit Version Conflict",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// The reference pointed to content (usually a resource) that has been deleted.
    /// </summary>
    public static readonly Coding Deleted = new Coding
    {
      Code = "deleted",
      Display = "Deleted",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// An attempt was made to create a duplicate record.
    /// </summary>
    public static readonly Coding Duplicate = new Coding
    {
      Code = "duplicate",
      Display = "Duplicate",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// An unexpected internal error has occurred.
    /// </summary>
    public static readonly Coding Exception = new Coding
    {
      Code = "exception",
      Display = "Exception",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// User session expired; a login may be required.
    /// </summary>
    public static readonly Coding SessionExpired = new Coding
    {
      Code = "expired",
      Display = "Session Expired",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// An extension was found that was not acceptable, could not be resolved, or a modifierExtension was not recognized.
    /// </summary>
    public static readonly Coding UnacceptableExtension = new Coding
    {
      Code = "extension",
      Display = "Unacceptable Extension",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// The user does not have the rights to perform this action.
    /// </summary>
    public static readonly Coding Forbidden = new Coding
    {
      Code = "forbidden",
      Display = "Forbidden",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// Not all data sources typically accessed could be reached or responded in time, so the returned information might not be complete (applies to search interactions and some operations).
    /// </summary>
    public static readonly Coding IncompleteResults = new Coding
    {
      Code = "incomplete",
      Display = "Incomplete Results",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// A message unrelated to the processing success of the completed operation (examples of the latter include things like reminders of password expiry, system maintenance times, etc.).
    /// </summary>
    public static readonly Coding InformationalNote = new Coding
    {
      Code = "informational",
      Display = "Informational Note",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// Content invalid against the specification or a profile.
    /// </summary>
    public static readonly Coding InvalidContent = new Coding
    {
      Code = "invalid",
      Display = "Invalid Content",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// A content validation rule failed - e.g. a schematron rule.
    /// </summary>
    public static readonly Coding ValidationRuleFailed = new Coding
    {
      Code = "invariant",
      Display = "Validation rule failed",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// A resource/record locking failure (usually in an underlying database).
    /// </summary>
    public static readonly Coding LockError = new Coding
    {
      Code = "lock-error",
      Display = "Lock Error",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// The client needs to initiate an authentication process.
    /// </summary>
    public static readonly Coding LoginRequired = new Coding
    {
      Code = "login",
      Display = "Login Required",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// Multiple matching records were found when the operation required only one match.
    /// </summary>
    public static readonly Coding MultipleMatches = new Coding
    {
      Code = "multiple-matches",
      Display = "Multiple Matches",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// The persistent store is unavailable; e.g. the database is down for maintenance or similar action, and the interaction or operation cannot be processed.
    /// </summary>
    public static readonly Coding NoStoreAvailable = new Coding
    {
      Code = "no-store",
      Display = "No Store Available",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// The reference provided was not found. In a pure RESTful environment, this would be an HTTP 404 error, but this code may be used where the content is not found further into the application architecture.
    /// </summary>
    public static readonly Coding NotFound = new Coding
    {
      Code = "not-found",
      Display = "Not Found",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// The interaction, operation, resource or profile is not supported.
    /// </summary>
    public static readonly Coding ContentNotSupported = new Coding
    {
      Code = "not-supported",
      Display = "Content not supported",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// Processing issues. These are expected to be final e.g. there is no point resubmitting the same content unchanged.
    /// </summary>
    public static readonly Coding ProcessingFailure = new Coding
    {
      Code = "processing",
      Display = "Processing Failure",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// A required element is missing.
    /// </summary>
    public static readonly Coding RequiredElementMissing = new Coding
    {
      Code = "required",
      Display = "Required element missing",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// An authentication/authorization/permissions issue of some kind.
    /// </summary>
    public static readonly Coding SecurityProblem = new Coding
    {
      Code = "security",
      Display = "Security Problem",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// A structural issue in the content such as wrong namespace, unable to parse the content completely, invalid syntax, etc.
    /// </summary>
    public static readonly Coding StructuralIssue = new Coding
    {
      Code = "structure",
      Display = "Structural Issue",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// Some information was not or might not have been returned due to business rules, consent or privacy rules, or access permission constraints.  This information may be accessible through alternate processes.
    /// </summary>
    public static readonly Coding InformationSuppressed = new Coding
    {
      Code = "suppressed",
      Display = "Information  Suppressed",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// The system is not prepared to handle this request due to load management.
    /// </summary>
    public static readonly Coding Throttled = new Coding
    {
      Code = "throttled",
      Display = "Throttled",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// An internal timeout has occurred.
    /// </summary>
    public static readonly Coding Timeout = new Coding
    {
      Code = "timeout",
      Display = "Timeout",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// The operation was stopped to protect server resources; e.g. a request for a value set expansion on all of SNOMED CT.
    /// </summary>
    public static readonly Coding OperationTooCostly = new Coding
    {
      Code = "too-costly",
      Display = "Operation Too Costly",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// Provided content is too long (typically, this is a denial of service protection type of error).
    /// </summary>
    public static readonly Coding ContentTooLong = new Coding
    {
      Code = "too-long",
      Display = "Content Too Long",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// Transient processing issues. The system receiving the message may be able to resubmit the same content once an underlying issue is resolved.
    /// </summary>
    public static readonly Coding TransientIssue = new Coding
    {
      Code = "transient",
      Display = "Transient Issue",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// The user or system was not able to be authenticated (either there is no process, or the proferred token is unacceptable).
    /// </summary>
    public static readonly Coding UnknownUser = new Coding
    {
      Code = "unknown",
      Display = "Unknown User",
      System = "http://hl7.org/fhir/issue-type"
    };
    /// <summary>
    /// An element or header value is invalid.
    /// </summary>
    public static readonly Coding ElementValueInvalid = new Coding
    {
      Code = "value",
      Display = "Element value invalid",
      System = "http://hl7.org/fhir/issue-type"
    };

    /// <summary>
    /// Literal for code: BusinessRuleViolation
    /// </summary>
    public const string LiteralBusinessRuleViolation = "business-rule";

    /// <summary>
    /// Literal for code: InvalidCode
    /// </summary>
    public const string LiteralInvalidCode = "code-invalid";

    /// <summary>
    /// Literal for code: EditVersionConflict
    /// </summary>
    public const string LiteralEditVersionConflict = "conflict";

    /// <summary>
    /// Literal for code: Deleted
    /// </summary>
    public const string LiteralDeleted = "deleted";

    /// <summary>
    /// Literal for code: Duplicate
    /// </summary>
    public const string LiteralDuplicate = "duplicate";

    /// <summary>
    /// Literal for code: Exception
    /// </summary>
    public const string LiteralException = "exception";

    /// <summary>
    /// Literal for code: SessionExpired
    /// </summary>
    public const string LiteralSessionExpired = "expired";

    /// <summary>
    /// Literal for code: UnacceptableExtension
    /// </summary>
    public const string LiteralUnacceptableExtension = "extension";

    /// <summary>
    /// Literal for code: Forbidden
    /// </summary>
    public const string LiteralForbidden = "forbidden";

    /// <summary>
    /// Literal for code: IncompleteResults
    /// </summary>
    public const string LiteralIncompleteResults = "incomplete";

    /// <summary>
    /// Literal for code: InformationalNote
    /// </summary>
    public const string LiteralInformationalNote = "informational";

    /// <summary>
    /// Literal for code: InvalidContent
    /// </summary>
    public const string LiteralInvalidContent = "invalid";

    /// <summary>
    /// Literal for code: ValidationRuleFailed
    /// </summary>
    public const string LiteralValidationRuleFailed = "invariant";

    /// <summary>
    /// Literal for code: LockError
    /// </summary>
    public const string LiteralLockError = "lock-error";

    /// <summary>
    /// Literal for code: LoginRequired
    /// </summary>
    public const string LiteralLoginRequired = "login";

    /// <summary>
    /// Literal for code: MultipleMatches
    /// </summary>
    public const string LiteralMultipleMatches = "multiple-matches";

    /// <summary>
    /// Literal for code: NoStoreAvailable
    /// </summary>
    public const string LiteralNoStoreAvailable = "no-store";

    /// <summary>
    /// Literal for code: NotFound
    /// </summary>
    public const string LiteralNotFound = "not-found";

    /// <summary>
    /// Literal for code: ContentNotSupported
    /// </summary>
    public const string LiteralContentNotSupported = "not-supported";

    /// <summary>
    /// Literal for code: ProcessingFailure
    /// </summary>
    public const string LiteralProcessingFailure = "processing";

    /// <summary>
    /// Literal for code: RequiredElementMissing
    /// </summary>
    public const string LiteralRequiredElementMissing = "required";

    /// <summary>
    /// Literal for code: SecurityProblem
    /// </summary>
    public const string LiteralSecurityProblem = "security";

    /// <summary>
    /// Literal for code: StructuralIssue
    /// </summary>
    public const string LiteralStructuralIssue = "structure";

    /// <summary>
    /// Literal for code: InformationSuppressed
    /// </summary>
    public const string LiteralInformationSuppressed = "suppressed";

    /// <summary>
    /// Literal for code: Throttled
    /// </summary>
    public const string LiteralThrottled = "throttled";

    /// <summary>
    /// Literal for code: Timeout
    /// </summary>
    public const string LiteralTimeout = "timeout";

    /// <summary>
    /// Literal for code: OperationTooCostly
    /// </summary>
    public const string LiteralOperationTooCostly = "too-costly";

    /// <summary>
    /// Literal for code: ContentTooLong
    /// </summary>
    public const string LiteralContentTooLong = "too-long";

    /// <summary>
    /// Literal for code: TransientIssue
    /// </summary>
    public const string LiteralTransientIssue = "transient";

    /// <summary>
    /// Literal for code: UnknownUser
    /// </summary>
    public const string LiteralUnknownUser = "unknown";

    /// <summary>
    /// Literal for code: ElementValueInvalid
    /// </summary>
    public const string LiteralElementValueInvalid = "value";
  };
}
