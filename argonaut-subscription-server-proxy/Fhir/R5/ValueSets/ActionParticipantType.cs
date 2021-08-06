// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of participant for the action.
  /// </summary>
  public static class ActionParticipantTypeCodes
  {
    /// <summary>
    /// The participant is a care team caring for the patient under evaluation.
    /// </summary>
    public static readonly Coding CareTeam = new Coding
    {
      Code = "careteam",
      Display = "CareTeam",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a system or device used in the care of the patient.
    /// </summary>
    public static readonly Coding Device = new Coding
    {
      Code = "device",
      Display = "Device",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a group of participants involved in the care of the patient.
    /// </summary>
    public static readonly Coding Group = new Coding
    {
      Code = "group",
      Display = "Group",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is an institution that can provide the given healthcare service used in the care of the patient.
    /// </summary>
    public static readonly Coding HealthcareService = new Coding
    {
      Code = "healthcareservice",
      Display = "HealthcareService",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a location involved in the care of the patient.
    /// </summary>
    public static readonly Coding Location = new Coding
    {
      Code = "location",
      Display = "Location",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is an organization involved in the care of the patient.
    /// </summary>
    public static readonly Coding Organization = new Coding
    {
      Code = "organization",
      Display = "Organization",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is the patient under evaluation.
    /// </summary>
    public static readonly Coding Patient = new Coding
    {
      Code = "patient",
      Display = "Patient",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a practitioner involved in the patient's care.
    /// </summary>
    public static readonly Coding Practitioner = new Coding
    {
      Code = "practitioner",
      Display = "Practitioner",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a particular practitioner role involved in the patient's care.
    /// </summary>
    public static readonly Coding PractitionerRole = new Coding
    {
      Code = "practitionerrole",
      Display = "PractitionerRole",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a person related to the patient.
    /// </summary>
    public static readonly Coding RelatedPerson = new Coding
    {
      Code = "relatedperson",
      Display = "RelatedPerson",
      System = "http://hl7.org/fhir/action-participant-type"
    };

    /// <summary>
    /// Literal for code: CareTeam
    /// </summary>
    public const string LiteralCareTeam = "careteam";

    /// <summary>
    /// Literal for code: Device
    /// </summary>
    public const string LiteralDevice = "device";

    /// <summary>
    /// Literal for code: Group
    /// </summary>
    public const string LiteralGroup = "group";

    /// <summary>
    /// Literal for code: HealthcareService
    /// </summary>
    public const string LiteralHealthcareService = "healthcareservice";

    /// <summary>
    /// Literal for code: Location
    /// </summary>
    public const string LiteralLocation = "location";

    /// <summary>
    /// Literal for code: Organization
    /// </summary>
    public const string LiteralOrganization = "organization";

    /// <summary>
    /// Literal for code: Patient
    /// </summary>
    public const string LiteralPatient = "patient";

    /// <summary>
    /// Literal for code: Practitioner
    /// </summary>
    public const string LiteralPractitioner = "practitioner";

    /// <summary>
    /// Literal for code: PractitionerRole
    /// </summary>
    public const string LiteralPractitionerRole = "practitionerrole";

    /// <summary>
    /// Literal for code: RelatedPerson
    /// </summary>
    public const string LiteralRelatedPerson = "relatedperson";
  };
}