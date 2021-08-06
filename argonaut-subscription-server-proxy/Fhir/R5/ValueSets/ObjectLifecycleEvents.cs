// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This FHIR value set is comprised of lifecycle event codes. The FHIR Actor value set is based on    DICOM Audit Message, ParticipantObjectDataLifeCycle;   ISO Standard, TS 21089-2017;  
  /// </summary>
  public static class ObjectLifecycleEventsCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OriginationCreation = new Coding
    {
      Code = "1",
      Display = "Origination / Creation",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Export = new Coding
    {
      Code = "10",
      Display = "Export",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Disclosure = new Coding
    {
      Code = "11",
      Display = "Disclosure",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ReceiptOfDisclosure = new Coding
    {
      Code = "12",
      Display = "Receipt of disclosure",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Archiving = new Coding
    {
      Code = "13",
      Display = "Archiving",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding LogicalDeletion = new Coding
    {
      Code = "14",
      Display = "Logical deletion",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PermanentErasurePhysicalDestruction = new Coding
    {
      Code = "15",
      Display = "Permanent erasure / Physical destruction",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ImportCopy = new Coding
    {
      Code = "2",
      Display = "Import / Copy",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Amendment = new Coding
    {
      Code = "3",
      Display = "Amendment",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Verification = new Coding
    {
      Code = "4",
      Display = "Verification",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Translation = new Coding
    {
      Code = "5",
      Display = "Translation",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AccessUse = new Coding
    {
      Code = "6",
      Display = "Access / Use",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DeIdentification = new Coding
    {
      Code = "7",
      Display = "De-identification",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AggregationSummarizationDerivation = new Coding
    {
      Code = "8",
      Display = "Aggregation / summarization / derivation",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Report = new Coding
    {
      Code = "9",
      Display = "Report",
      System = "http://terminology.hl7.org/CodeSystem/dicom-audit-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AccessViewRecordLifecycleEvent = new Coding
    {
      Code = "access",
      Display = "Access/View Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AmendUpdateRecordLifecycleEvent = new Coding
    {
      Code = "amend",
      Display = "Amend (Update) Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ArchiveRecordLifecycleEvent = new Coding
    {
      Code = "archive",
      Display = "Archive Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AttestRecordLifecycleEvent = new Coding
    {
      Code = "attest",
      Display = "Attest Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DecryptRecordLifecycleEvent = new Coding
    {
      Code = "decrypt",
      Display = "Decrypt Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DeIdentifyAnononymizeRecordLifecycleEvent = new Coding
    {
      Code = "deidentify",
      Display = "De-Identify (Anononymize) Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DeprecateRecordLifecycleEvent = new Coding
    {
      Code = "deprecate",
      Display = "Deprecate Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DestroyDeleteRecordLifecycleEvent = new Coding
    {
      Code = "destroy",
      Display = "Destroy/Delete Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DiscloseRecordLifecycleEvent = new Coding
    {
      Code = "disclose",
      Display = "Disclose Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EncryptRecordLifecycleEvent = new Coding
    {
      Code = "encrypt",
      Display = "Encrypt Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ExtractRecordLifecycleEvent = new Coding
    {
      Code = "extract",
      Display = "Extract Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AddLegalHoldRecordLifecycleEvent = new Coding
    {
      Code = "hold",
      Display = "Add Legal Hold Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding LinkRecordLifecycleEvent = new Coding
    {
      Code = "link",
      Display = "Link Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding MergeRecordLifecycleEvent = new Coding
    {
      Code = "merge",
      Display = "Merge Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OriginateRetainRecordLifecycleEvent = new Coding
    {
      Code = "originate",
      Display = "Originate/Retain Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PseudonymizeRecordLifecycleEvent = new Coding
    {
      Code = "pseudonymize",
      Display = "Pseudonymize Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ReActivateRecordLifecycleEvent = new Coding
    {
      Code = "reactivate",
      Display = "Re-activate Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ReceiveRetainRecordLifecycleEvent = new Coding
    {
      Code = "receive",
      Display = "Receive/Retain Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ReIdentifyRecordLifecycleEvent = new Coding
    {
      Code = "reidentify",
      Display = "Re-identify Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ReportOutputRecordLifecycleEvent = new Coding
    {
      Code = "report",
      Display = "Report (Output) Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding RestoreRecordLifecycleEvent = new Coding
    {
      Code = "restore",
      Display = "Restore Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TransformTranslateRecordLifecycleEvent = new Coding
    {
      Code = "transform",
      Display = "Transform/Translate Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TransmitRecordLifecycleEvent = new Coding
    {
      Code = "transmit",
      Display = "Transmit Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding RemoveLegalHoldRecordLifecycleEvent = new Coding
    {
      Code = "unhold",
      Display = "Remove Legal Hold Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding UnlinkRecordLifecycleEvent = new Coding
    {
      Code = "unlink",
      Display = "Unlink Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding UnmergeRecordLifecycleEvent = new Coding
    {
      Code = "unmerge",
      Display = "Unmerge Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding VerifyRecordLifecycleEvent = new Coding
    {
      Code = "verify",
      Display = "Verify Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };

    /// <summary>
    /// Literal for code: OriginationCreation
    /// </summary>
    public const string LiteralOriginationCreation = "1";

    /// <summary>
    /// Literal for code: Export
    /// </summary>
    public const string LiteralExport = "10";

    /// <summary>
    /// Literal for code: Disclosure
    /// </summary>
    public const string LiteralDisclosure = "11";

    /// <summary>
    /// Literal for code: ReceiptOfDisclosure
    /// </summary>
    public const string LiteralReceiptOfDisclosure = "12";

    /// <summary>
    /// Literal for code: Archiving
    /// </summary>
    public const string LiteralArchiving = "13";

    /// <summary>
    /// Literal for code: LogicalDeletion
    /// </summary>
    public const string LiteralLogicalDeletion = "14";

    /// <summary>
    /// Literal for code: PermanentErasurePhysicalDestruction
    /// </summary>
    public const string LiteralPermanentErasurePhysicalDestruction = "15";

    /// <summary>
    /// Literal for code: ImportCopy
    /// </summary>
    public const string LiteralImportCopy = "2";

    /// <summary>
    /// Literal for code: Amendment
    /// </summary>
    public const string LiteralAmendment = "3";

    /// <summary>
    /// Literal for code: Verification
    /// </summary>
    public const string LiteralVerification = "4";

    /// <summary>
    /// Literal for code: Translation
    /// </summary>
    public const string LiteralTranslation = "5";

    /// <summary>
    /// Literal for code: AccessUse
    /// </summary>
    public const string LiteralAccessUse = "6";

    /// <summary>
    /// Literal for code: DeIdentification
    /// </summary>
    public const string LiteralDeIdentification = "7";

    /// <summary>
    /// Literal for code: AggregationSummarizationDerivation
    /// </summary>
    public const string LiteralAggregationSummarizationDerivation = "8";

    /// <summary>
    /// Literal for code: Report
    /// </summary>
    public const string LiteralReport = "9";

    /// <summary>
    /// Literal for code: AccessViewRecordLifecycleEvent
    /// </summary>
    public const string LiteralAccessViewRecordLifecycleEvent = "access";

    /// <summary>
    /// Literal for code: AmendUpdateRecordLifecycleEvent
    /// </summary>
    public const string LiteralAmendUpdateRecordLifecycleEvent = "amend";

    /// <summary>
    /// Literal for code: ArchiveRecordLifecycleEvent
    /// </summary>
    public const string LiteralArchiveRecordLifecycleEvent = "archive";

    /// <summary>
    /// Literal for code: AttestRecordLifecycleEvent
    /// </summary>
    public const string LiteralAttestRecordLifecycleEvent = "attest";

    /// <summary>
    /// Literal for code: DecryptRecordLifecycleEvent
    /// </summary>
    public const string LiteralDecryptRecordLifecycleEvent = "decrypt";

    /// <summary>
    /// Literal for code: DeIdentifyAnononymizeRecordLifecycleEvent
    /// </summary>
    public const string LiteralDeIdentifyAnononymizeRecordLifecycleEvent = "deidentify";

    /// <summary>
    /// Literal for code: DeprecateRecordLifecycleEvent
    /// </summary>
    public const string LiteralDeprecateRecordLifecycleEvent = "deprecate";

    /// <summary>
    /// Literal for code: DestroyDeleteRecordLifecycleEvent
    /// </summary>
    public const string LiteralDestroyDeleteRecordLifecycleEvent = "destroy";

    /// <summary>
    /// Literal for code: DiscloseRecordLifecycleEvent
    /// </summary>
    public const string LiteralDiscloseRecordLifecycleEvent = "disclose";

    /// <summary>
    /// Literal for code: EncryptRecordLifecycleEvent
    /// </summary>
    public const string LiteralEncryptRecordLifecycleEvent = "encrypt";

    /// <summary>
    /// Literal for code: ExtractRecordLifecycleEvent
    /// </summary>
    public const string LiteralExtractRecordLifecycleEvent = "extract";

    /// <summary>
    /// Literal for code: AddLegalHoldRecordLifecycleEvent
    /// </summary>
    public const string LiteralAddLegalHoldRecordLifecycleEvent = "hold";

    /// <summary>
    /// Literal for code: LinkRecordLifecycleEvent
    /// </summary>
    public const string LiteralLinkRecordLifecycleEvent = "link";

    /// <summary>
    /// Literal for code: MergeRecordLifecycleEvent
    /// </summary>
    public const string LiteralMergeRecordLifecycleEvent = "merge";

    /// <summary>
    /// Literal for code: OriginateRetainRecordLifecycleEvent
    /// </summary>
    public const string LiteralOriginateRetainRecordLifecycleEvent = "originate";

    /// <summary>
    /// Literal for code: PseudonymizeRecordLifecycleEvent
    /// </summary>
    public const string LiteralPseudonymizeRecordLifecycleEvent = "pseudonymize";

    /// <summary>
    /// Literal for code: ReActivateRecordLifecycleEvent
    /// </summary>
    public const string LiteralReActivateRecordLifecycleEvent = "reactivate";

    /// <summary>
    /// Literal for code: ReceiveRetainRecordLifecycleEvent
    /// </summary>
    public const string LiteralReceiveRetainRecordLifecycleEvent = "receive";

    /// <summary>
    /// Literal for code: ReIdentifyRecordLifecycleEvent
    /// </summary>
    public const string LiteralReIdentifyRecordLifecycleEvent = "reidentify";

    /// <summary>
    /// Literal for code: ReportOutputRecordLifecycleEvent
    /// </summary>
    public const string LiteralReportOutputRecordLifecycleEvent = "report";

    /// <summary>
    /// Literal for code: RestoreRecordLifecycleEvent
    /// </summary>
    public const string LiteralRestoreRecordLifecycleEvent = "restore";

    /// <summary>
    /// Literal for code: TransformTranslateRecordLifecycleEvent
    /// </summary>
    public const string LiteralTransformTranslateRecordLifecycleEvent = "transform";

    /// <summary>
    /// Literal for code: TransmitRecordLifecycleEvent
    /// </summary>
    public const string LiteralTransmitRecordLifecycleEvent = "transmit";

    /// <summary>
    /// Literal for code: RemoveLegalHoldRecordLifecycleEvent
    /// </summary>
    public const string LiteralRemoveLegalHoldRecordLifecycleEvent = "unhold";

    /// <summary>
    /// Literal for code: UnlinkRecordLifecycleEvent
    /// </summary>
    public const string LiteralUnlinkRecordLifecycleEvent = "unlink";

    /// <summary>
    /// Literal for code: UnmergeRecordLifecycleEvent
    /// </summary>
    public const string LiteralUnmergeRecordLifecycleEvent = "unmerge";

    /// <summary>
    /// Literal for code: VerifyRecordLifecycleEvent
    /// </summary>
    public const string LiteralVerifyRecordLifecycleEvent = "verify";
  };
}