// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of information contained in a component of an artifact assessment.
  /// </summary>
  public static class ArtifactassessmentInformationTypeCodes
  {
    /// <summary>
    /// A change request for the artifact
    /// </summary>
    public static readonly Coding ChangeRequest = new Coding
    {
      Code = "change-request",
      Display = "Change Request",
      System = "http://hl7.org/fhir/artifactassessment-information-type"
    };
    /// <summary>
    /// A classifier of the artifact
    /// </summary>
    public static readonly Coding Classifier = new Coding
    {
      Code = "classifier",
      Display = "Classifier",
      System = "http://hl7.org/fhir/artifactassessment-information-type"
    };
    /// <summary>
    /// A comment on the artifact
    /// </summary>
    public static readonly Coding Comment = new Coding
    {
      Code = "comment",
      Display = "Comment",
      System = "http://hl7.org/fhir/artifactassessment-information-type"
    };
    /// <summary>
    /// A container for multiple components
    /// </summary>
    public static readonly Coding Container = new Coding
    {
      Code = "container",
      Display = "Container",
      System = "http://hl7.org/fhir/artifactassessment-information-type"
    };
    /// <summary>
    /// A rating of the artifact
    /// </summary>
    public static readonly Coding Rating = new Coding
    {
      Code = "rating",
      Display = "Rating",
      System = "http://hl7.org/fhir/artifactassessment-information-type"
    };
    /// <summary>
    /// A response to a comment
    /// </summary>
    public static readonly Coding Response = new Coding
    {
      Code = "response",
      Display = "Response",
      System = "http://hl7.org/fhir/artifactassessment-information-type"
    };

    /// <summary>
    /// Literal for code: ChangeRequest
    /// </summary>
    public const string LiteralChangeRequest = "change-request";

    /// <summary>
    /// Literal for code: ArtifactassessmentInformationTypeChangeRequest
    /// </summary>
    public const string LiteralArtifactassessmentInformationTypeChangeRequest = "http://hl7.org/fhir/artifactassessment-information-type#change-request";

    /// <summary>
    /// Literal for code: Classifier
    /// </summary>
    public const string LiteralClassifier = "classifier";

    /// <summary>
    /// Literal for code: ArtifactassessmentInformationTypeClassifier
    /// </summary>
    public const string LiteralArtifactassessmentInformationTypeClassifier = "http://hl7.org/fhir/artifactassessment-information-type#classifier";

    /// <summary>
    /// Literal for code: Comment
    /// </summary>
    public const string LiteralComment = "comment";

    /// <summary>
    /// Literal for code: ArtifactassessmentInformationTypeComment
    /// </summary>
    public const string LiteralArtifactassessmentInformationTypeComment = "http://hl7.org/fhir/artifactassessment-information-type#comment";

    /// <summary>
    /// Literal for code: Container
    /// </summary>
    public const string LiteralContainer = "container";

    /// <summary>
    /// Literal for code: ArtifactassessmentInformationTypeContainer
    /// </summary>
    public const string LiteralArtifactassessmentInformationTypeContainer = "http://hl7.org/fhir/artifactassessment-information-type#container";

    /// <summary>
    /// Literal for code: Rating
    /// </summary>
    public const string LiteralRating = "rating";

    /// <summary>
    /// Literal for code: ArtifactassessmentInformationTypeRating
    /// </summary>
    public const string LiteralArtifactassessmentInformationTypeRating = "http://hl7.org/fhir/artifactassessment-information-type#rating";

    /// <summary>
    /// Literal for code: Response
    /// </summary>
    public const string LiteralResponse = "response";

    /// <summary>
    /// Literal for code: ArtifactassessmentInformationTypeResponse
    /// </summary>
    public const string LiteralArtifactassessmentInformationTypeResponse = "http://hl7.org/fhir/artifactassessment-information-type#response";

    /// <summary>
    /// Dictionary for looking up ArtifactassessmentInformationType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "change-request", ChangeRequest }, 
      { "http://hl7.org/fhir/artifactassessment-information-type#change-request", ChangeRequest }, 
      { "classifier", Classifier }, 
      { "http://hl7.org/fhir/artifactassessment-information-type#classifier", Classifier }, 
      { "comment", Comment }, 
      { "http://hl7.org/fhir/artifactassessment-information-type#comment", Comment }, 
      { "container", Container }, 
      { "http://hl7.org/fhir/artifactassessment-information-type#container", Container }, 
      { "rating", Rating }, 
      { "http://hl7.org/fhir/artifactassessment-information-type#rating", Rating }, 
      { "response", Response }, 
      { "http://hl7.org/fhir/artifactassessment-information-type#response", Response }, 
    };
  };
}
