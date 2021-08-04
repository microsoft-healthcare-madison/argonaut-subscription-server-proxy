// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Detailed information about the type of the image - its kind, purpose, or the kind of equipment used to generate it.
  /// </summary>
  public static class MediaModalityCodes
  {
    /// <summary>
    /// A diagram. Often used in diagnostic reports
    /// </summary>
    public static readonly Coding Diagram = new Coding
    {
      Code = "diagram",
      Display = "Diagram",
      System = "http://terminology.hl7.org/CodeSystem/media-modality"
    };
    /// <summary>
    /// A face scan used for identification purposes
    /// </summary>
    public static readonly Coding FaceScan = new Coding
    {
      Code = "face",
      Display = "Face Scan",
      System = "http://terminology.hl7.org/CodeSystem/media-modality"
    };
    /// <summary>
    /// A digital record of a fax document
    /// </summary>
    public static readonly Coding Fax = new Coding
    {
      Code = "fax",
      Display = "Fax",
      System = "http://terminology.hl7.org/CodeSystem/media-modality"
    };
    /// <summary>
    /// A finger print scan used for identification purposes
    /// </summary>
    public static readonly Coding Fingerprint = new Coding
    {
      Code = "fingerprint",
      Display = "Fingerprint",
      System = "http://terminology.hl7.org/CodeSystem/media-modality"
    };
    /// <summary>
    /// An iris scan used for identification purposes
    /// </summary>
    public static readonly Coding IrisScan = new Coding
    {
      Code = "iris",
      Display = "Iris Scan",
      System = "http://terminology.hl7.org/CodeSystem/media-modality"
    };
    /// <summary>
    /// A palm scan used for identification purposes
    /// </summary>
    public static readonly Coding PalmScan = new Coding
    {
      Code = "palm",
      Display = "Palm Scan",
      System = "http://terminology.hl7.org/CodeSystem/media-modality"
    };
    /// <summary>
    /// A retinal image used for identification purposes
    /// </summary>
    public static readonly Coding RetinaScan = new Coding
    {
      Code = "retina",
      Display = "Retina Scan",
      System = "http://terminology.hl7.org/CodeSystem/media-modality"
    };
    /// <summary>
    /// A digital scan of a document. This is reserved for when there is not enough metadata to create a document reference
    /// </summary>
    public static readonly Coding ScannedDocument = new Coding
    {
      Code = "scan",
      Display = "Scanned Document",
      System = "http://terminology.hl7.org/CodeSystem/media-modality"
    };

    /// <summary>
    /// Literal for code: Diagram
    /// </summary>
    public const string LiteralDiagram = "diagram";

    /// <summary>
    /// Literal for code: FaceScan
    /// </summary>
    public const string LiteralFaceScan = "face";

    /// <summary>
    /// Literal for code: Fax
    /// </summary>
    public const string LiteralFax = "fax";

    /// <summary>
    /// Literal for code: Fingerprint
    /// </summary>
    public const string LiteralFingerprint = "fingerprint";

    /// <summary>
    /// Literal for code: IrisScan
    /// </summary>
    public const string LiteralIrisScan = "iris";

    /// <summary>
    /// Literal for code: PalmScan
    /// </summary>
    public const string LiteralPalmScan = "palm";

    /// <summary>
    /// Literal for code: RetinaScan
    /// </summary>
    public const string LiteralRetinaScan = "retina";

    /// <summary>
    /// Literal for code: ScannedDocument
    /// </summary>
    public const string LiteralScannedDocument = "scan";
  };
}
