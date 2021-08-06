// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This example FHIR value set is comprised of example Actor Type codes, which can be used to value FHIR agents, actors, and other role         elements such as those specified in financial transactions. The FHIR Actor value set is based on    DICOM Audit Message, C402;   ASTM Standard, E1762-95 [2013]; selected codes and          derived actor roles from HL7 RoleClass OID 2.16.840.1.113883.5.110;    HL7 Role Code 2.16.840.1.113883.5.111, including AgentRoleType;          HL7 ParticipationType OID: 2.16.840.1.113883.5.90; and    HL7 ParticipationFunction codes OID: 2.16.840.1.113883.5.88.           This value set includes, by reference, role codes from external code systems: NUCC Health Care Provider Taxonomy OID: 2.16.840.1.113883.6.101;          North American Industry Classification System [NAICS]OID: 2.16.840.1.113883.6.85; IndustryClassificationSystem 2.16.840.1.113883.1.11.16039;          and US Census Occupation Code OID: 2.16.840.1.113883.6.243 for relevant recipient or custodian codes not included in this value set.            If no source is indicated in the definition comments, then these are example FHIR codes.          It can be extended with appropriate roles described by SNOMED as well as those described in the HL7 Role Based Access Control Catalog and the          HL7 Healthcare (Security and Privacy) Access Control Catalog.            In Role-Based Access Control (RBAC), permissions are operations on an object that a user wishes to access. Permissions are grouped into roles.          A role characterizes the functions a user is allowed to perform. Roles are assigned to users. If the user's role has the appropriate permissions          to access an object, then that user is granted access to the object. FHIR readily enables RBAC, as FHIR Resources are object types and the CRUDE          events (the FHIR equivalent to permissions in the RBAC scheme) are operations on those objects.          In Attribute-Based Access Control (ABAC), a user requests to perform operations on objects. That user's access request is granted or denied          based on a set of access control policies that are specified in terms of attributes and conditions. FHIR readily enables ABAC, as instances of          a Resource in FHIR (again, Resources are object types) can have attributes associated with them. These attributes include security tags,          environment conditions, and a host of user and object characteristics, which are the same attributes as those used in ABAC. Attributes help          define the access control policies that determine the operations a user may perform on a Resource (in FHIR) or object (in ABAC). For example,          a tag (or attribute) may specify that the identified Resource (object) is not to be further disclosed without explicit consent from the patient.
  /// </summary>
  public static class SecurityRoleTypeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CitizenRoleType = new Coding
    {
      Code = "_CitizenRoleType",
      Display = "CitizenRoleType",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AFFL = new Coding
    {
      Code = "AFFL",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AGNT = new Coding
    {
      Code = "AGNT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AMENDER = new Coding
    {
      Code = "AMENDER",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ASSIGNED = new Coding
    {
      Code = "ASSIGNED",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AUCG = new Coding
    {
      Code = "AUCG",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationFunction"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AULR = new Coding
    {
      Code = "AULR",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationFunction"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AUT = new Coding
    {
      Code = "AUT",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AuthorizationServer = new Coding
    {
      Code = "authserver",
      Display = "Authorization Server",
      System = "http://terminology.hl7.org/CodeSystem/extra-security-role-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AUTM = new Coding
    {
      Code = "AUTM",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationFunction"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AUWA = new Coding
    {
      Code = "AUWA",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationFunction"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AsylumSeeker = new Coding
    {
      Code = "CAS",
      Display = "asylum seeker",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SingleMinorAsylumSeeker = new Coding
    {
      Code = "CASM",
      Display = "single minor asylum seeker",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CLAIM = new Coding
    {
      Code = "CLAIM",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CLASSIFIER = new Coding
    {
      Code = "CLASSIFIER",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding National = new Coding
    {
      Code = "CN",
      Display = "national",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonCountryMemberWithoutResidencePermit = new Coding
    {
      Code = "CNRP",
      Display = "non-country member without residence permit",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonCountryMemberMinorWithoutResidencePermit = new Coding
    {
      Code = "CNRPM",
      Display = "non-country member minor without residence permit",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding COAUTH = new Coding
    {
      Code = "COAUTH",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CONSENTER = new Coding
    {
      Code = "CONSENTER",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CONSWIT = new Coding
    {
      Code = "CONSWIT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CONT = new Coding
    {
      Code = "CONT",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding COPART = new Coding
    {
      Code = "COPART",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding COVPTY = new Coding
    {
      Code = "COVPTY",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PermitCardApplicant = new Coding
    {
      Code = "CPCA",
      Display = "permit card applicant",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonCountryMemberWithResidencePermit = new Coding
    {
      Code = "CRP",
      Display = "non-country member with residence permit",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonCountryMemberMinorWithResidencePermit = new Coding
    {
      Code = "CRPM",
      Display = "non-country member minor with residence permit",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CST = new Coding
    {
      Code = "CST",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DataCollector = new Coding
    {
      Code = "datacollector",
      Display = "Data Collector",
      System = "http://terminology.hl7.org/CodeSystem/extra-security-role-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DataProcessor = new Coding
    {
      Code = "dataprocessor",
      Display = "Data Processor",
      System = "http://terminology.hl7.org/CodeSystem/extra-security-role-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DataSubject = new Coding
    {
      Code = "datasubject",
      Display = "Data Subject",
      System = "http://terminology.hl7.org/CodeSystem/extra-security-role-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DECLASSIFIER = new Coding
    {
      Code = "DECLASSIFIER",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DELEGATEE = new Coding
    {
      Code = "DELEGATEE",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DELEGATOR = new Coding
    {
      Code = "DELEGATOR",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DEPEN = new Coding
    {
      Code = "DEPEN",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DOWNGRDER = new Coding
    {
      Code = "DOWNGRDER",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DPOWATT = new Coding
    {
      Code = "DPOWATT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ECON = new Coding
    {
      Code = "ECON",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EMP = new Coding
    {
      Code = "EMP",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EVTWIT = new Coding
    {
      Code = "EVTWIT",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EXCEST = new Coding
    {
      Code = "EXCEST",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GRANTEE = new Coding
    {
      Code = "GRANTEE",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GRANTOR = new Coding
    {
      Code = "GRANTOR",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GT = new Coding
    {
      Code = "GT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GUADLTM = new Coding
    {
      Code = "GUADLTM",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GUARD = new Coding
    {
      Code = "GUARD",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding HPOWATT = new Coding
    {
      Code = "HPOWATT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding HumanUser = new Coding
    {
      Code = "humanuser",
      Display = "Human User",
      System = "http://terminology.hl7.org/CodeSystem/extra-security-role-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding INF = new Coding
    {
      Code = "INF",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding INTPRTER = new Coding
    {
      Code = "INTPRTER",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding INVSBJ = new Coding
    {
      Code = "INVSBJ",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding IRCP = new Coding
    {
      Code = "IRCP",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding LA = new Coding
    {
      Code = "LA",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NAMED = new Coding
    {
      Code = "NAMED",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NOK = new Coding
    {
      Code = "NOK",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NOT = new Coding
    {
      Code = "NOT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PAT = new Coding
    {
      Code = "PAT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding POWATT = new Coding
    {
      Code = "POWATT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PRIMAUTH = new Coding
    {
      Code = "PRIMAUTH",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PROMSK = new Coding
    {
      Code = "PROMSK",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationFunction"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PROV = new Coding
    {
      Code = "PROV",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleClass"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding RESPRSN = new Coding
    {
      Code = "RESPRSN",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding REVIEWER = new Coding
    {
      Code = "REVIEWER",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SOURCE = new Coding
    {
      Code = "SOURCE",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SPOWATT = new Coding
    {
      Code = "SPOWATT",
      System = "http://terminology.hl7.org/CodeSystem/v3-RoleCode"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TRANS = new Coding
    {
      Code = "TRANS",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TRC = new Coding
    {
      Code = "TRC",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VALID = new Coding
    {
      Code = "VALID",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VERF = new Coding
    {
      Code = "VERF",
      System = "http://terminology.hl7.org/CodeSystem/contractsignertypecodes"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding WIT = new Coding
    {
      Code = "WIT",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };

    /// <summary>
    /// Literal for code: CitizenRoleType
    /// </summary>
    public const string LiteralCitizenRoleType = "_CitizenRoleType";

    /// <summary>
    /// Literal for code: AFFL
    /// </summary>
    public const string LiteralAFFL = "AFFL";

    /// <summary>
    /// Literal for code: AGNT
    /// </summary>
    public const string LiteralAGNT = "AGNT";

    /// <summary>
    /// Literal for code: AMENDER
    /// </summary>
    public const string LiteralAMENDER = "AMENDER";

    /// <summary>
    /// Literal for code: ASSIGNED
    /// </summary>
    public const string LiteralASSIGNED = "ASSIGNED";

    /// <summary>
    /// Literal for code: AUCG
    /// </summary>
    public const string LiteralAUCG = "AUCG";

    /// <summary>
    /// Literal for code: AULR
    /// </summary>
    public const string LiteralAULR = "AULR";

    /// <summary>
    /// Literal for code: AUT
    /// </summary>
    public const string LiteralAUT = "AUT";

    /// <summary>
    /// Literal for code: AuthorizationServer
    /// </summary>
    public const string LiteralAuthorizationServer = "authserver";

    /// <summary>
    /// Literal for code: AUTM
    /// </summary>
    public const string LiteralAUTM = "AUTM";

    /// <summary>
    /// Literal for code: AUWA
    /// </summary>
    public const string LiteralAUWA = "AUWA";

    /// <summary>
    /// Literal for code: AsylumSeeker
    /// </summary>
    public const string LiteralAsylumSeeker = "CAS";

    /// <summary>
    /// Literal for code: SingleMinorAsylumSeeker
    /// </summary>
    public const string LiteralSingleMinorAsylumSeeker = "CASM";

    /// <summary>
    /// Literal for code: CLAIM
    /// </summary>
    public const string LiteralCLAIM = "CLAIM";

    /// <summary>
    /// Literal for code: CLASSIFIER
    /// </summary>
    public const string LiteralCLASSIFIER = "CLASSIFIER";

    /// <summary>
    /// Literal for code: National
    /// </summary>
    public const string LiteralNational = "CN";

    /// <summary>
    /// Literal for code: NonCountryMemberWithoutResidencePermit
    /// </summary>
    public const string LiteralNonCountryMemberWithoutResidencePermit = "CNRP";

    /// <summary>
    /// Literal for code: NonCountryMemberMinorWithoutResidencePermit
    /// </summary>
    public const string LiteralNonCountryMemberMinorWithoutResidencePermit = "CNRPM";

    /// <summary>
    /// Literal for code: COAUTH
    /// </summary>
    public const string LiteralCOAUTH = "COAUTH";

    /// <summary>
    /// Literal for code: CONSENTER
    /// </summary>
    public const string LiteralCONSENTER = "CONSENTER";

    /// <summary>
    /// Literal for code: CONSWIT
    /// </summary>
    public const string LiteralCONSWIT = "CONSWIT";

    /// <summary>
    /// Literal for code: CONT
    /// </summary>
    public const string LiteralCONT = "CONT";

    /// <summary>
    /// Literal for code: COPART
    /// </summary>
    public const string LiteralCOPART = "COPART";

    /// <summary>
    /// Literal for code: COVPTY
    /// </summary>
    public const string LiteralCOVPTY = "COVPTY";

    /// <summary>
    /// Literal for code: PermitCardApplicant
    /// </summary>
    public const string LiteralPermitCardApplicant = "CPCA";

    /// <summary>
    /// Literal for code: NonCountryMemberWithResidencePermit
    /// </summary>
    public const string LiteralNonCountryMemberWithResidencePermit = "CRP";

    /// <summary>
    /// Literal for code: NonCountryMemberMinorWithResidencePermit
    /// </summary>
    public const string LiteralNonCountryMemberMinorWithResidencePermit = "CRPM";

    /// <summary>
    /// Literal for code: CST
    /// </summary>
    public const string LiteralCST = "CST";

    /// <summary>
    /// Literal for code: DataCollector
    /// </summary>
    public const string LiteralDataCollector = "datacollector";

    /// <summary>
    /// Literal for code: DataProcessor
    /// </summary>
    public const string LiteralDataProcessor = "dataprocessor";

    /// <summary>
    /// Literal for code: DataSubject
    /// </summary>
    public const string LiteralDataSubject = "datasubject";

    /// <summary>
    /// Literal for code: DECLASSIFIER
    /// </summary>
    public const string LiteralDECLASSIFIER = "DECLASSIFIER";

    /// <summary>
    /// Literal for code: DELEGATEE
    /// </summary>
    public const string LiteralDELEGATEE = "DELEGATEE";

    /// <summary>
    /// Literal for code: DELEGATOR
    /// </summary>
    public const string LiteralDELEGATOR = "DELEGATOR";

    /// <summary>
    /// Literal for code: DEPEN
    /// </summary>
    public const string LiteralDEPEN = "DEPEN";

    /// <summary>
    /// Literal for code: DOWNGRDER
    /// </summary>
    public const string LiteralDOWNGRDER = "DOWNGRDER";

    /// <summary>
    /// Literal for code: DPOWATT
    /// </summary>
    public const string LiteralDPOWATT = "DPOWATT";

    /// <summary>
    /// Literal for code: ECON
    /// </summary>
    public const string LiteralECON = "ECON";

    /// <summary>
    /// Literal for code: EMP
    /// </summary>
    public const string LiteralEMP = "EMP";

    /// <summary>
    /// Literal for code: EVTWIT
    /// </summary>
    public const string LiteralEVTWIT = "EVTWIT";

    /// <summary>
    /// Literal for code: EXCEST
    /// </summary>
    public const string LiteralEXCEST = "EXCEST";

    /// <summary>
    /// Literal for code: GRANTEE
    /// </summary>
    public const string LiteralGRANTEE = "GRANTEE";

    /// <summary>
    /// Literal for code: GRANTOR
    /// </summary>
    public const string LiteralGRANTOR = "GRANTOR";

    /// <summary>
    /// Literal for code: GT
    /// </summary>
    public const string LiteralGT = "GT";

    /// <summary>
    /// Literal for code: GUADLTM
    /// </summary>
    public const string LiteralGUADLTM = "GUADLTM";

    /// <summary>
    /// Literal for code: GUARD
    /// </summary>
    public const string LiteralGUARD = "GUARD";

    /// <summary>
    /// Literal for code: HPOWATT
    /// </summary>
    public const string LiteralHPOWATT = "HPOWATT";

    /// <summary>
    /// Literal for code: HumanUser
    /// </summary>
    public const string LiteralHumanUser = "humanuser";

    /// <summary>
    /// Literal for code: INF
    /// </summary>
    public const string LiteralINF = "INF";

    /// <summary>
    /// Literal for code: INTPRTER
    /// </summary>
    public const string LiteralINTPRTER = "INTPRTER";

    /// <summary>
    /// Literal for code: INVSBJ
    /// </summary>
    public const string LiteralINVSBJ = "INVSBJ";

    /// <summary>
    /// Literal for code: IRCP
    /// </summary>
    public const string LiteralIRCP = "IRCP";

    /// <summary>
    /// Literal for code: LA
    /// </summary>
    public const string LiteralLA = "LA";

    /// <summary>
    /// Literal for code: NAMED
    /// </summary>
    public const string LiteralNAMED = "NAMED";

    /// <summary>
    /// Literal for code: NOK
    /// </summary>
    public const string LiteralNOK = "NOK";

    /// <summary>
    /// Literal for code: NOT
    /// </summary>
    public const string LiteralNOT = "NOT";

    /// <summary>
    /// Literal for code: PAT
    /// </summary>
    public const string LiteralPAT = "PAT";

    /// <summary>
    /// Literal for code: POWATT
    /// </summary>
    public const string LiteralPOWATT = "POWATT";

    /// <summary>
    /// Literal for code: PRIMAUTH
    /// </summary>
    public const string LiteralPRIMAUTH = "PRIMAUTH";

    /// <summary>
    /// Literal for code: PROMSK
    /// </summary>
    public const string LiteralPROMSK = "PROMSK";

    /// <summary>
    /// Literal for code: PROV
    /// </summary>
    public const string LiteralPROV = "PROV";

    /// <summary>
    /// Literal for code: RESPRSN
    /// </summary>
    public const string LiteralRESPRSN = "RESPRSN";

    /// <summary>
    /// Literal for code: REVIEWER
    /// </summary>
    public const string LiteralREVIEWER = "REVIEWER";

    /// <summary>
    /// Literal for code: SOURCE
    /// </summary>
    public const string LiteralSOURCE = "SOURCE";

    /// <summary>
    /// Literal for code: SPOWATT
    /// </summary>
    public const string LiteralSPOWATT = "SPOWATT";

    /// <summary>
    /// Literal for code: TRANS
    /// </summary>
    public const string LiteralTRANS = "TRANS";

    /// <summary>
    /// Literal for code: TRC
    /// </summary>
    public const string LiteralTRC = "TRC";

    /// <summary>
    /// Literal for code: VALID
    /// </summary>
    public const string LiteralVALID = "VALID";

    /// <summary>
    /// Literal for code: VERF
    /// </summary>
    public const string LiteralVERF = "VERF";

    /// <summary>
    /// Literal for code: WIT
    /// </summary>
    public const string LiteralWIT = "WIT";
  };
}