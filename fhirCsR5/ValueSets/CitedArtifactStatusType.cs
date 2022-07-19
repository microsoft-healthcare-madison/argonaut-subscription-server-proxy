// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Cited Artifact Status Type
  /// </summary>
  public static class CitedArtifactStatusTypeCodes
  {
    /// <summary>
    /// The content that was not published yet has been approved for publication by the publisher and/or editor.
    /// </summary>
    public static readonly Coding Accepted = new Coding
    {
      Code = "accepted",
      Display = "Accepted",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content is considered complete for its current state by the content creator.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content has been approved for a state transition, with the focus of approval described in the text associated with this coding.
    /// </summary>
    public static readonly Coding Approved = new Coding
    {
      Code = "approved",
      Display = "Approved",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content is retired or considered no longer current but still available as part of the public record.
    /// </summary>
    public static readonly Coding Archived = new Coding
    {
      Code = "archived",
      Display = "Archived",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content was originally constructed or composed.
    /// </summary>
    public static readonly Coding Created = new Coding
    {
      Code = "created",
      Display = "Created",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content is considered unfinished or incomplete and not representative of the current state desired by the content creator.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content is in a state between the review(s) being completed and being published.
    /// </summary>
    public static readonly Coding PostReviewPrePublished = new Coding
    {
      Code = "post-review-pre-published",
      Display = "Post review pre published",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content is awaiting assignment and delivery to reviewer(s).
    /// </summary>
    public static readonly Coding PreReview = new Coding
    {
      Code = "pre-review",
      Display = "Pre review",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content is published but future changes to the published version are expected.
    /// </summary>
    public static readonly Coding PublishedEarlyForm = new Coding
    {
      Code = "published-early-form",
      Display = "Published early form",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content is published and further changes to the content are not expected.
    /// </summary>
    public static readonly Coding PublishedFinalForm = new Coding
    {
      Code = "published-final-form",
      Display = "Published final form",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content that was not published has been removed from consideration for publishing by a publisher or editor.
    /// </summary>
    public static readonly Coding Rejected = new Coding
    {
      Code = "rejected",
      Display = "Rejected",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content that was published is removed from publication and should no longer be considered part of the public record.
    /// </summary>
    public static readonly Coding Retracted = new Coding
    {
      Code = "retracted",
      Display = "Retracted",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content was sent to the publisher for consideration of publication.
    /// </summary>
    public static readonly Coding Submitted = new Coding
    {
      Code = "submitted",
      Display = "Submitted",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content is in a state of being reviewed.
    /// </summary>
    public static readonly Coding UnderReview = new Coding
    {
      Code = "under-review",
      Display = "Under review",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The status of the content is not recorded in the metadata.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };
    /// <summary>
    /// The content that was not published has been removed from consideration for publishing by the submitter.
    /// </summary>
    public static readonly Coding Withdrawn = new Coding
    {
      Code = "withdrawn",
      Display = "Withdrawn",
      System = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type"
    };

    /// <summary>
    /// Literal for code: Accepted
    /// </summary>
    public const string LiteralAccepted = "accepted";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeAccepted
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeAccepted = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#accepted";

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeActive
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeActive = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#active";

    /// <summary>
    /// Literal for code: Approved
    /// </summary>
    public const string LiteralApproved = "approved";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeApproved
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeApproved = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#approved";

    /// <summary>
    /// Literal for code: Archived
    /// </summary>
    public const string LiteralArchived = "archived";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeArchived
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeArchived = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#archived";

    /// <summary>
    /// Literal for code: Created
    /// </summary>
    public const string LiteralCreated = "created";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeCreated
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeCreated = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#created";

    /// <summary>
    /// Literal for code: Draft
    /// </summary>
    public const string LiteralDraft = "draft";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeDraft
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeDraft = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#draft";

    /// <summary>
    /// Literal for code: PostReviewPrePublished
    /// </summary>
    public const string LiteralPostReviewPrePublished = "post-review-pre-published";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypePostReviewPrePublished
    /// </summary>
    public const string LiteralCitedArtifactStatusTypePostReviewPrePublished = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#post-review-pre-published";

    /// <summary>
    /// Literal for code: PreReview
    /// </summary>
    public const string LiteralPreReview = "pre-review";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypePreReview
    /// </summary>
    public const string LiteralCitedArtifactStatusTypePreReview = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#pre-review";

    /// <summary>
    /// Literal for code: PublishedEarlyForm
    /// </summary>
    public const string LiteralPublishedEarlyForm = "published-early-form";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypePublishedEarlyForm
    /// </summary>
    public const string LiteralCitedArtifactStatusTypePublishedEarlyForm = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#published-early-form";

    /// <summary>
    /// Literal for code: PublishedFinalForm
    /// </summary>
    public const string LiteralPublishedFinalForm = "published-final-form";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypePublishedFinalForm
    /// </summary>
    public const string LiteralCitedArtifactStatusTypePublishedFinalForm = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#published-final-form";

    /// <summary>
    /// Literal for code: Rejected
    /// </summary>
    public const string LiteralRejected = "rejected";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeRejected
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeRejected = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#rejected";

    /// <summary>
    /// Literal for code: Retracted
    /// </summary>
    public const string LiteralRetracted = "retracted";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeRetracted
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeRetracted = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#retracted";

    /// <summary>
    /// Literal for code: Submitted
    /// </summary>
    public const string LiteralSubmitted = "submitted";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeSubmitted
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeSubmitted = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#submitted";

    /// <summary>
    /// Literal for code: UnderReview
    /// </summary>
    public const string LiteralUnderReview = "under-review";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeUnderReview
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeUnderReview = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#under-review";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeUnknown
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeUnknown = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#unknown";

    /// <summary>
    /// Literal for code: Withdrawn
    /// </summary>
    public const string LiteralWithdrawn = "withdrawn";

    /// <summary>
    /// Literal for code: CitedArtifactStatusTypeWithdrawn
    /// </summary>
    public const string LiteralCitedArtifactStatusTypeWithdrawn = "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#withdrawn";

    /// <summary>
    /// Dictionary for looking up CitedArtifactStatusType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "accepted", Accepted }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#accepted", Accepted }, 
      { "active", Active }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#active", Active }, 
      { "approved", Approved }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#approved", Approved }, 
      { "archived", Archived }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#archived", Archived }, 
      { "created", Created }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#created", Created }, 
      { "draft", Draft }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#draft", Draft }, 
      { "post-review-pre-published", PostReviewPrePublished }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#post-review-pre-published", PostReviewPrePublished }, 
      { "pre-review", PreReview }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#pre-review", PreReview }, 
      { "published-early-form", PublishedEarlyForm }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#published-early-form", PublishedEarlyForm }, 
      { "published-final-form", PublishedFinalForm }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#published-final-form", PublishedFinalForm }, 
      { "rejected", Rejected }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#rejected", Rejected }, 
      { "retracted", Retracted }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#retracted", Retracted }, 
      { "submitted", Submitted }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#submitted", Submitted }, 
      { "under-review", UnderReview }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#under-review", UnderReview }, 
      { "unknown", Unknown }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#unknown", Unknown }, 
      { "withdrawn", Withdrawn }, 
      { "http://terminology.hl7.org/CodeSystem/cited-artifact-status-type#withdrawn", Withdrawn }, 
    };
  };
}
