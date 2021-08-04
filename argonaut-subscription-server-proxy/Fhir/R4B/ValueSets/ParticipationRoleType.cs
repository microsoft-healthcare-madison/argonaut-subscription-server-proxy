// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This FHIR value set is comprised of Actor participation Type codes, which can be used to value FHIR agents, actors, and other role         elements. The FHIR Actor participation type value set is based on    DICOM Audit Message, C402;   ASTM Standard, E1762-95 [2013]; selected codes and          derived actor roles from HL7 RoleClass OID 2.16.840.1.113883.5.110;    HL7 Role Code 2.16.840.1.113883.5.111, including AgentRoleType;          HL7 ParticipationType OID: 2.16.840.1.113883.5.90; and    HL7 ParticipationFunction codes OID: 2.16.840.1.113883.5.88.           This value set includes, by reference, role codes from external code systems: NUCC Health Care Provider Taxonomy OID: 2.16.840.1.113883.6.101;          North American Industry Classification System [NAICS]OID: 2.16.840.1.113883.6.85; IndustryClassificationSystem 2.16.840.1.113883.1.11.16039;          and US Census Occupation Code OID: 2.16.840.1.113883.6.243 for relevant recipient or custodian codes not included in this value set.            If no source is indicated in the definition comments, then these are example FHIR codes.
  /// </summary>
  public static class ParticipationRoleTypeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CitizenRoleType_v3_RoleCode = new Coding
    {
      Code = "_CitizenRoleType",
      Display = "CitizenRoleType",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// Audit participant role ID of software application
    /// </summary>
    public static readonly Coding Application_dicom_dcim = new Coding
    {
      Code = "110150",
      Display = "Application",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit participant role ID of software application launcher, i.e., the entity that started or stopped an application
    /// </summary>
    public static readonly Coding ApplicationLauncher_dicom_dcim = new Coding
    {
      Code = "110151",
      Display = "Application Launcher",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit participant role ID of the receiver of data
    /// </summary>
    public static readonly Coding DestinationRoleID_dicom_dcim = new Coding
    {
      Code = "110152",
      Display = "Destination Role ID",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit participant role ID of the sender of data
    /// </summary>
    public static readonly Coding SourceRoleID_dicom_dcim = new Coding
    {
      Code = "110153",
      Display = "Source Role ID",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit participant role ID of media receiving data during an export
    /// </summary>
    public static readonly Coding DestinationMedia_dicom_dcim = new Coding
    {
      Code = "110154",
      Display = "Destination Media",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit participant role ID of media providing data during an import
    /// </summary>
    public static readonly Coding SourceMedia_dicom_dcim = new Coding
    {
      Code = "110155",
      Display = "Source Media",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AFFL_v3_RoleClass = new Coding
    {
      Code = "AFFL",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AGNT_v3_RoleClass = new Coding
    {
      Code = "AGNT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AMENDER_contractsignertypecodes = new Coding
    {
      Code = "AMENDER",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ASSIGNED_v3_RoleClass = new Coding
    {
      Code = "ASSIGNED",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AUCG_v3_ParticipationFunction = new Coding
    {
      Code = "AUCG",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationFunction"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AULR_v3_ParticipationFunction = new Coding
    {
      Code = "AULR",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationFunction"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AUT_v3_ParticipationType = new Coding
    {
      Code = "AUT",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// An entity providing authorization services to enable the electronic sharing of health-related information based on resource owner's preapproved permissions. For example, an UMA Authorization Server[UMA]
    /// </summary>
    public static readonly Coding AuthorizationServer_extra_security_role_type = new Coding
    {
      Code = "authserver",
      Display = "authorization server",
      System = "http://terminology.hl7.org/CodeSystem/extra-security-role-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AUTM_v3_ParticipationFunction = new Coding
    {
      Code = "AUTM",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationFunction"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AUWA_v3_ParticipationFunction = new Coding
    {
      Code = "AUWA",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationFunction"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AsylumSeeker_v3_RoleCode = new Coding
    {
      Code = "CAS",
      Display = "asylum seeker",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SingleMinorAsylumSeeker_v3_RoleCode = new Coding
    {
      Code = "CASM",
      Display = "single minor asylum seeker",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CLAIM_v3_RoleClass = new Coding
    {
      Code = "CLAIM",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CLASSIFIER_v3_RoleCode = new Coding
    {
      Code = "CLASSIFIER",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding National_v3_RoleCode = new Coding
    {
      Code = "CN",
      Display = "national",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonCountryMemberWithoutResidencePermit_v3_RoleCode = new Coding
    {
      Code = "CNRP",
      Display = "non-country member without residence permit",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonCountryMemberMinorWithoutResidencePermit_v3_RoleCode = new Coding
    {
      Code = "CNRPM",
      Display = "non-country member minor without residence permit",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding COAUTH_contractsignertypecodes = new Coding
    {
      Code = "COAUTH",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CONSENTER_v3_RoleCode = new Coding
    {
      Code = "CONSENTER",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CONSWIT_v3_RoleCode = new Coding
    {
      Code = "CONSWIT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CONT_contractsignertypecodes = new Coding
    {
      Code = "CONT",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding COPART_v3_RoleCode = new Coding
    {
      Code = "COPART",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding COVPTY_v3_RoleClass = new Coding
    {
      Code = "COVPTY",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PermitCardApplicant_v3_RoleCode = new Coding
    {
      Code = "CPCA",
      Display = "permit card applicant",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonCountryMemberWithResidencePermit_v3_RoleCode = new Coding
    {
      Code = "CRP",
      Display = "non-country member with residence permit",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonCountryMemberMinorWithResidencePermit_v3_RoleCode = new Coding
    {
      Code = "CRPM",
      Display = "non-country member minor with residence permit",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CST_v3_ParticipationType = new Coding
    {
      Code = "CST",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// An entity that collects information over which the data subject may have certain rights under policy or law to control that information's management and distribution by data collectors, including the right to access, retrieve, distribute, or delete that information. 
    /// </summary>
    public static readonly Coding DataCollector_extra_security_role_type = new Coding
    {
      Code = "datacollector",
      Display = "data collector",
      System = "http://terminology.hl7.org/CodeSystem/extra-security-role-type"
    };
    /// <summary>
    /// An entity that processes collected information over which the data subject may have certain rights under policy or law to control that information's management and distribution by data processors, including the right to access, retrieve, distribute, or delete that information.
    /// </summary>
    public static readonly Coding DataProcessor_extra_security_role_type = new Coding
    {
      Code = "dataprocessor",
      Display = "data processor",
      System = "http://terminology.hl7.org/CodeSystem/extra-security-role-type"
    };
    /// <summary>
    /// A person whose personal information is collected or processed, and who may have certain rights under policy or law to control that information's management and distribution by data collectors or processors, including the right to access, retrieve, distribute, or delete that information.
    /// </summary>
    public static readonly Coding DataSubject_extra_security_role_type = new Coding
    {
      Code = "datasubject",
      Display = "data subject",
      System = "http://terminology.hl7.org/CodeSystem/extra-security-role-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DECLASSIFIER_v3_RoleCode = new Coding
    {
      Code = "DECLASSIFIER",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DELEGATEE_v3_RoleCode = new Coding
    {
      Code = "DELEGATEE",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DELEGATOR_v3_RoleCode = new Coding
    {
      Code = "DELEGATOR",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DEPEN_v3_RoleClass = new Coding
    {
      Code = "DEPEN",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DOWNGRDER_v3_RoleCode = new Coding
    {
      Code = "DOWNGRDER",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DPOWATT_v3_RoleCode = new Coding
    {
      Code = "DPOWATT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ECON_v3_RoleClass = new Coding
    {
      Code = "ECON",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EMP_v3_RoleClass = new Coding
    {
      Code = "EMP",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EVTWIT_contractsignertypecodes = new Coding
    {
      Code = "EVTWIT",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EXCEST_v3_RoleCode = new Coding
    {
      Code = "EXCEST",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GRANTEE_v3_RoleCode = new Coding
    {
      Code = "GRANTEE",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GRANTOR_v3_RoleCode = new Coding
    {
      Code = "GRANTOR",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GT_v3_RoleCode = new Coding
    {
      Code = "GT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GUADLTM_v3_RoleCode = new Coding
    {
      Code = "GUADLTM",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GUARD_v3_RoleClass = new Coding
    {
      Code = "GUARD",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding HPOWATT_v3_RoleCode = new Coding
    {
      Code = "HPOWATT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// The human user that has participated.
    /// </summary>
    public static readonly Coding HumanUser_extra_security_role_type = new Coding
    {
      Code = "humanuser",
      Display = "human user",
      System = "http://terminology.hl7.org/CodeSystem/extra-security-role-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding INF_v3_ParticipationType = new Coding
    {
      Code = "INF",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding INTPRTER_v3_RoleCode = new Coding
    {
      Code = "INTPRTER",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding INVSBJ_v3_RoleClass = new Coding
    {
      Code = "INVSBJ",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding IRCP_v3_ParticipationType = new Coding
    {
      Code = "IRCP",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding LA_v3_ParticipationType = new Coding
    {
      Code = "LA",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NAMED_v3_RoleClass = new Coding
    {
      Code = "NAMED",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NOK_v3_RoleClass = new Coding
    {
      Code = "NOK",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NOT_v3_RoleClass = new Coding
    {
      Code = "NOT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PAT_v3_RoleClass = new Coding
    {
      Code = "PAT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding POWATT_v3_RoleCode = new Coding
    {
      Code = "POWATT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PRIMAUTH_contractsignertypecodes = new Coding
    {
      Code = "PRIMAUTH",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PROMSK_v3_ParticipationFunction = new Coding
    {
      Code = "PROMSK",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationFunction"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PROV_v3_RoleClass = new Coding
    {
      Code = "PROV",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding RESPRSN_v3_RoleCode = new Coding
    {
      Code = "RESPRSN",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding REVIEWER_contractsignertypecodes = new Coding
    {
      Code = "REVIEWER",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SOURCE_contractsignertypecodes = new Coding
    {
      Code = "SOURCE",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SPOWATT_v3_RoleCode = new Coding
    {
      Code = "SPOWATT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TRANS_contractsignertypecodes = new Coding
    {
      Code = "TRANS",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TRC_v3_ParticipationType = new Coding
    {
      Code = "TRC",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VALID_contractsignertypecodes = new Coding
    {
      Code = "VALID",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VERF_contractsignertypecodes = new Coding
    {
      Code = "VERF",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding WIT_v3_ParticipationType = new Coding
    {
      Code = "WIT",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };

    /// <summary>
    /// Literal for code: CitizenRoleType_v3_RoleCode
    /// </summary>
    public const string LiteralCitizenRoleType_v3_RoleCode = "_CitizenRoleType";

    /// <summary>
    /// Literal for code: Application_dicom_dcim
    /// </summary>
    public const string LiteralApplication_dicom_dcim = "110150";

    /// <summary>
    /// Literal for code: ApplicationLauncher_dicom_dcim
    /// </summary>
    public const string LiteralApplicationLauncher_dicom_dcim = "110151";

    /// <summary>
    /// Literal for code: DestinationRoleID_dicom_dcim
    /// </summary>
    public const string LiteralDestinationRoleID_dicom_dcim = "110152";

    /// <summary>
    /// Literal for code: SourceRoleID_dicom_dcim
    /// </summary>
    public const string LiteralSourceRoleID_dicom_dcim = "110153";

    /// <summary>
    /// Literal for code: DestinationMedia_dicom_dcim
    /// </summary>
    public const string LiteralDestinationMedia_dicom_dcim = "110154";

    /// <summary>
    /// Literal for code: SourceMedia_dicom_dcim
    /// </summary>
    public const string LiteralSourceMedia_dicom_dcim = "110155";

    /// <summary>
    /// Literal for code: AFFL_v3_RoleClass
    /// </summary>
    public const string LiteralAFFL_v3_RoleClass = "AFFL";

    /// <summary>
    /// Literal for code: AGNT_v3_RoleClass
    /// </summary>
    public const string LiteralAGNT_v3_RoleClass = "AGNT";

    /// <summary>
    /// Literal for code: AMENDER_contractsignertypecodes
    /// </summary>
    public const string LiteralAMENDER_contractsignertypecodes = "AMENDER";

    /// <summary>
    /// Literal for code: ASSIGNED_v3_RoleClass
    /// </summary>
    public const string LiteralASSIGNED_v3_RoleClass = "ASSIGNED";

    /// <summary>
    /// Literal for code: AUCG_v3_ParticipationFunction
    /// </summary>
    public const string LiteralAUCG_v3_ParticipationFunction = "AUCG";

    /// <summary>
    /// Literal for code: AULR_v3_ParticipationFunction
    /// </summary>
    public const string LiteralAULR_v3_ParticipationFunction = "AULR";

    /// <summary>
    /// Literal for code: AUT_v3_ParticipationType
    /// </summary>
    public const string LiteralAUT_v3_ParticipationType = "AUT";

    /// <summary>
    /// Literal for code: AuthorizationServer_extra_security_role_type
    /// </summary>
    public const string LiteralAuthorizationServer_extra_security_role_type = "authserver";

    /// <summary>
    /// Literal for code: AUTM_v3_ParticipationFunction
    /// </summary>
    public const string LiteralAUTM_v3_ParticipationFunction = "AUTM";

    /// <summary>
    /// Literal for code: AUWA_v3_ParticipationFunction
    /// </summary>
    public const string LiteralAUWA_v3_ParticipationFunction = "AUWA";

    /// <summary>
    /// Literal for code: AsylumSeeker_v3_RoleCode
    /// </summary>
    public const string LiteralAsylumSeeker_v3_RoleCode = "CAS";

    /// <summary>
    /// Literal for code: SingleMinorAsylumSeeker_v3_RoleCode
    /// </summary>
    public const string LiteralSingleMinorAsylumSeeker_v3_RoleCode = "CASM";

    /// <summary>
    /// Literal for code: CLAIM_v3_RoleClass
    /// </summary>
    public const string LiteralCLAIM_v3_RoleClass = "CLAIM";

    /// <summary>
    /// Literal for code: CLASSIFIER_v3_RoleCode
    /// </summary>
    public const string LiteralCLASSIFIER_v3_RoleCode = "CLASSIFIER";

    /// <summary>
    /// Literal for code: National_v3_RoleCode
    /// </summary>
    public const string LiteralNational_v3_RoleCode = "CN";

    /// <summary>
    /// Literal for code: NonCountryMemberWithoutResidencePermit_v3_RoleCode
    /// </summary>
    public const string LiteralNonCountryMemberWithoutResidencePermit_v3_RoleCode = "CNRP";

    /// <summary>
    /// Literal for code: NonCountryMemberMinorWithoutResidencePermit_v3_RoleCode
    /// </summary>
    public const string LiteralNonCountryMemberMinorWithoutResidencePermit_v3_RoleCode = "CNRPM";

    /// <summary>
    /// Literal for code: COAUTH_contractsignertypecodes
    /// </summary>
    public const string LiteralCOAUTH_contractsignertypecodes = "COAUTH";

    /// <summary>
    /// Literal for code: CONSENTER_v3_RoleCode
    /// </summary>
    public const string LiteralCONSENTER_v3_RoleCode = "CONSENTER";

    /// <summary>
    /// Literal for code: CONSWIT_v3_RoleCode
    /// </summary>
    public const string LiteralCONSWIT_v3_RoleCode = "CONSWIT";

    /// <summary>
    /// Literal for code: CONT_contractsignertypecodes
    /// </summary>
    public const string LiteralCONT_contractsignertypecodes = "CONT";

    /// <summary>
    /// Literal for code: COPART_v3_RoleCode
    /// </summary>
    public const string LiteralCOPART_v3_RoleCode = "COPART";

    /// <summary>
    /// Literal for code: COVPTY_v3_RoleClass
    /// </summary>
    public const string LiteralCOVPTY_v3_RoleClass = "COVPTY";

    /// <summary>
    /// Literal for code: PermitCardApplicant_v3_RoleCode
    /// </summary>
    public const string LiteralPermitCardApplicant_v3_RoleCode = "CPCA";

    /// <summary>
    /// Literal for code: NonCountryMemberWithResidencePermit_v3_RoleCode
    /// </summary>
    public const string LiteralNonCountryMemberWithResidencePermit_v3_RoleCode = "CRP";

    /// <summary>
    /// Literal for code: NonCountryMemberMinorWithResidencePermit_v3_RoleCode
    /// </summary>
    public const string LiteralNonCountryMemberMinorWithResidencePermit_v3_RoleCode = "CRPM";

    /// <summary>
    /// Literal for code: CST_v3_ParticipationType
    /// </summary>
    public const string LiteralCST_v3_ParticipationType = "CST";

    /// <summary>
    /// Literal for code: DataCollector_extra_security_role_type
    /// </summary>
    public const string LiteralDataCollector_extra_security_role_type = "datacollector";

    /// <summary>
    /// Literal for code: DataProcessor_extra_security_role_type
    /// </summary>
    public const string LiteralDataProcessor_extra_security_role_type = "dataprocessor";

    /// <summary>
    /// Literal for code: DataSubject_extra_security_role_type
    /// </summary>
    public const string LiteralDataSubject_extra_security_role_type = "datasubject";

    /// <summary>
    /// Literal for code: DECLASSIFIER_v3_RoleCode
    /// </summary>
    public const string LiteralDECLASSIFIER_v3_RoleCode = "DECLASSIFIER";

    /// <summary>
    /// Literal for code: DELEGATEE_v3_RoleCode
    /// </summary>
    public const string LiteralDELEGATEE_v3_RoleCode = "DELEGATEE";

    /// <summary>
    /// Literal for code: DELEGATOR_v3_RoleCode
    /// </summary>
    public const string LiteralDELEGATOR_v3_RoleCode = "DELEGATOR";

    /// <summary>
    /// Literal for code: DEPEN_v3_RoleClass
    /// </summary>
    public const string LiteralDEPEN_v3_RoleClass = "DEPEN";

    /// <summary>
    /// Literal for code: DOWNGRDER_v3_RoleCode
    /// </summary>
    public const string LiteralDOWNGRDER_v3_RoleCode = "DOWNGRDER";

    /// <summary>
    /// Literal for code: DPOWATT_v3_RoleCode
    /// </summary>
    public const string LiteralDPOWATT_v3_RoleCode = "DPOWATT";

    /// <summary>
    /// Literal for code: ECON_v3_RoleClass
    /// </summary>
    public const string LiteralECON_v3_RoleClass = "ECON";

    /// <summary>
    /// Literal for code: EMP_v3_RoleClass
    /// </summary>
    public const string LiteralEMP_v3_RoleClass = "EMP";

    /// <summary>
    /// Literal for code: EVTWIT_contractsignertypecodes
    /// </summary>
    public const string LiteralEVTWIT_contractsignertypecodes = "EVTWIT";

    /// <summary>
    /// Literal for code: EXCEST_v3_RoleCode
    /// </summary>
    public const string LiteralEXCEST_v3_RoleCode = "EXCEST";

    /// <summary>
    /// Literal for code: GRANTEE_v3_RoleCode
    /// </summary>
    public const string LiteralGRANTEE_v3_RoleCode = "GRANTEE";

    /// <summary>
    /// Literal for code: GRANTOR_v3_RoleCode
    /// </summary>
    public const string LiteralGRANTOR_v3_RoleCode = "GRANTOR";

    /// <summary>
    /// Literal for code: GT_v3_RoleCode
    /// </summary>
    public const string LiteralGT_v3_RoleCode = "GT";

    /// <summary>
    /// Literal for code: GUADLTM_v3_RoleCode
    /// </summary>
    public const string LiteralGUADLTM_v3_RoleCode = "GUADLTM";

    /// <summary>
    /// Literal for code: GUARD_v3_RoleClass
    /// </summary>
    public const string LiteralGUARD_v3_RoleClass = "GUARD";

    /// <summary>
    /// Literal for code: HPOWATT_v3_RoleCode
    /// </summary>
    public const string LiteralHPOWATT_v3_RoleCode = "HPOWATT";

    /// <summary>
    /// Literal for code: HumanUser_extra_security_role_type
    /// </summary>
    public const string LiteralHumanUser_extra_security_role_type = "humanuser";

    /// <summary>
    /// Literal for code: INF_v3_ParticipationType
    /// </summary>
    public const string LiteralINF_v3_ParticipationType = "INF";

    /// <summary>
    /// Literal for code: INTPRTER_v3_RoleCode
    /// </summary>
    public const string LiteralINTPRTER_v3_RoleCode = "INTPRTER";

    /// <summary>
    /// Literal for code: INVSBJ_v3_RoleClass
    /// </summary>
    public const string LiteralINVSBJ_v3_RoleClass = "INVSBJ";

    /// <summary>
    /// Literal for code: IRCP_v3_ParticipationType
    /// </summary>
    public const string LiteralIRCP_v3_ParticipationType = "IRCP";

    /// <summary>
    /// Literal for code: LA_v3_ParticipationType
    /// </summary>
    public const string LiteralLA_v3_ParticipationType = "LA";

    /// <summary>
    /// Literal for code: NAMED_v3_RoleClass
    /// </summary>
    public const string LiteralNAMED_v3_RoleClass = "NAMED";

    /// <summary>
    /// Literal for code: NOK_v3_RoleClass
    /// </summary>
    public const string LiteralNOK_v3_RoleClass = "NOK";

    /// <summary>
    /// Literal for code: NOT_v3_RoleClass
    /// </summary>
    public const string LiteralNOT_v3_RoleClass = "NOT";

    /// <summary>
    /// Literal for code: PAT_v3_RoleClass
    /// </summary>
    public const string LiteralPAT_v3_RoleClass = "PAT";

    /// <summary>
    /// Literal for code: POWATT_v3_RoleCode
    /// </summary>
    public const string LiteralPOWATT_v3_RoleCode = "POWATT";

    /// <summary>
    /// Literal for code: PRIMAUTH_contractsignertypecodes
    /// </summary>
    public const string LiteralPRIMAUTH_contractsignertypecodes = "PRIMAUTH";

    /// <summary>
    /// Literal for code: PROMSK_v3_ParticipationFunction
    /// </summary>
    public const string LiteralPROMSK_v3_ParticipationFunction = "PROMSK";

    /// <summary>
    /// Literal for code: PROV_v3_RoleClass
    /// </summary>
    public const string LiteralPROV_v3_RoleClass = "PROV";

    /// <summary>
    /// Literal for code: RESPRSN_v3_RoleCode
    /// </summary>
    public const string LiteralRESPRSN_v3_RoleCode = "RESPRSN";

    /// <summary>
    /// Literal for code: REVIEWER_contractsignertypecodes
    /// </summary>
    public const string LiteralREVIEWER_contractsignertypecodes = "REVIEWER";

    /// <summary>
    /// Literal for code: SOURCE_contractsignertypecodes
    /// </summary>
    public const string LiteralSOURCE_contractsignertypecodes = "SOURCE";

    /// <summary>
    /// Literal for code: SPOWATT_v3_RoleCode
    /// </summary>
    public const string LiteralSPOWATT_v3_RoleCode = "SPOWATT";

    /// <summary>
    /// Literal for code: TRANS_contractsignertypecodes
    /// </summary>
    public const string LiteralTRANS_contractsignertypecodes = "TRANS";

    /// <summary>
    /// Literal for code: TRC_v3_ParticipationType
    /// </summary>
    public const string LiteralTRC_v3_ParticipationType = "TRC";

    /// <summary>
    /// Literal for code: VALID_contractsignertypecodes
    /// </summary>
    public const string LiteralVALID_contractsignertypecodes = "VALID";

    /// <summary>
    /// Literal for code: VERF_contractsignertypecodes
    /// </summary>
    public const string LiteralVERF_contractsignertypecodes = "VERF";

    /// <summary>
    /// Literal for code: WIT_v3_ParticipationType
    /// </summary>
    public const string LiteralWIT_v3_ParticipationType = "WIT";
  };
}
