// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Citation artifact classifier
  /// </summary>
  public static class CitationArtifactClassifierCodes
  {
    /// <summary>
    /// Used with articles which include video files or clips, or for articles which are entirely video.
    /// </summary>
    public static readonly Coding VideoAudioMedia = new Coding
    {
      Code = "68059040",
      Display = "Video-Audio Media",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The article cited is an audio file.
    /// </summary>
    public static readonly Coding AudioFile = new Coding
    {
      Code = "audio",
      Display = "Audio file",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Citation Resource containing value added data that is openly shared
    /// </summary>
    public static readonly Coding CommonShare = new Coding
    {
      Code = "common-share",
      Display = "Common Share",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Scientific manuscript made available prior to PEER REVIEW.
    /// </summary>
    public static readonly Coding Preprint = new Coding
    {
      Code = "D000076942",
      Display = "Preprint",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Non-periodical written or printed works consisting of sheets of pages fastened or bound together within covers.
    /// </summary>
    public static readonly Coding Book = new Coding
    {
      Code = "D001877",
      Display = "Book",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Comment
    /// </summary>
    public static readonly Coding Comment = new Coding
    {
      Code = "D016420",
      Display = "Comment",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Letter
    /// </summary>
    public static readonly Coding Letter = new Coding
    {
      Code = "D016422",
      Display = "Letter",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Published Erratum
    /// </summary>
    public static readonly Coding PublishedErratum = new Coding
    {
      Code = "D016425",
      Display = "Published Erratum",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Journal Article
    /// </summary>
    public static readonly Coding JournalArticle = new Coding
    {
      Code = "D016428",
      Display = "Journal Article",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// A structured file of information or a set of logically related data stored and retrieved using computer-based means.
    /// </summary>
    public static readonly Coding Database = new Coding
    {
      Code = "D019991",
      Display = "Database",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Works consisting of organized collections of data, which have been stored permanently in a formalized manner suitable for communication, interpretation, or processing.
    /// </summary>
    public static readonly Coding Dataset = new Coding
    {
      Code = "D064886",
      Display = "Dataset",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// the journal is published in electronic format only
    /// </summary>
    public static readonly Coding Electronic = new Coding
    {
      Code = "Electronic",
      Display = "Electronic",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// used for electronic-only journals that publish individual articles first and then later collect them into an "issue" date that is typically called an eCollection.
    /// </summary>
    public static readonly Coding ElectronicECollection = new Coding
    {
      Code = "Electronic-eCollection",
      Display = "Electronic-eCollection",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// the journal is published first in electronic format followed by print (this value is currently used for just one journal, Nucleic Acids Research)
    /// </summary>
    public static readonly Coding ElectronicPrint = new Coding
    {
      Code = "Electronic-Print",
      Display = "Electronic-Print",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Executable app
    /// </summary>
    public static readonly Coding ExecutableApp = new Coding
    {
      Code = "executable-app",
      Display = "Executable app",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The article cited is a FHIR resource.
    /// </summary>
    public static readonly Coding FHIRResource = new Coding
    {
      Code = "fhir-resource",
      Display = "FHIR Resource",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The article cited is an audio file.
    /// </summary>
    public static readonly Coding ImageFile = new Coding
    {
      Code = "image",
      Display = "Image file",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The article cited is machine code.
    /// </summary>
    public static readonly Coding MachineCode = new Coding
    {
      Code = "machine-code",
      Display = "Machine code",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Citation Resource containing only data from Medline
    /// </summary>
    public static readonly Coding MedlineBase = new Coding
    {
      Code = "medline-base",
      Display = "Medline Base",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// the journal is published in print format only
    /// </summary>
    public static readonly Coding Print = new Coding
    {
      Code = "Print",
      Display = "Print",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// the journal is published in both print and electronic format
    /// </summary>
    public static readonly Coding PrintElectronic = new Coding
    {
      Code = "Print-Electronic",
      Display = "Print Electronic",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Citation Resource containing value added data specific to a project
    /// </summary>
    public static readonly Coding ProjectSpecific = new Coding
    {
      Code = "project-specific",
      Display = "Project Specific",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// The article cited is the protocol of an activity and not the results or findings.
    /// </summary>
    public static readonly Coding Protocol = new Coding
    {
      Code = "protocol",
      Display = "Protocol",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };
    /// <summary>
    /// Webpage
    /// </summary>
    public static readonly Coding Webpage = new Coding
    {
      Code = "webpage",
      Display = "Webpage",
      System = "http://terminology.hl7.org/CodeSystem/citation-artifact-classifier"
    };

    /// <summary>
    /// Literal for code: VideoAudioMedia
    /// </summary>
    public const string LiteralVideoAudioMedia = "68059040";

    /// <summary>
    /// Literal for code: AudioFile
    /// </summary>
    public const string LiteralAudioFile = "audio";

    /// <summary>
    /// Literal for code: CommonShare
    /// </summary>
    public const string LiteralCommonShare = "common-share";

    /// <summary>
    /// Literal for code: Preprint
    /// </summary>
    public const string LiteralPreprint = "D000076942";

    /// <summary>
    /// Literal for code: Book
    /// </summary>
    public const string LiteralBook = "D001877";

    /// <summary>
    /// Literal for code: Comment
    /// </summary>
    public const string LiteralComment = "D016420";

    /// <summary>
    /// Literal for code: Letter
    /// </summary>
    public const string LiteralLetter = "D016422";

    /// <summary>
    /// Literal for code: PublishedErratum
    /// </summary>
    public const string LiteralPublishedErratum = "D016425";

    /// <summary>
    /// Literal for code: JournalArticle
    /// </summary>
    public const string LiteralJournalArticle = "D016428";

    /// <summary>
    /// Literal for code: Database
    /// </summary>
    public const string LiteralDatabase = "D019991";

    /// <summary>
    /// Literal for code: Dataset
    /// </summary>
    public const string LiteralDataset = "D064886";

    /// <summary>
    /// Literal for code: Electronic
    /// </summary>
    public const string LiteralElectronic = "Electronic";

    /// <summary>
    /// Literal for code: ElectronicECollection
    /// </summary>
    public const string LiteralElectronicECollection = "Electronic-eCollection";

    /// <summary>
    /// Literal for code: ElectronicPrint
    /// </summary>
    public const string LiteralElectronicPrint = "Electronic-Print";

    /// <summary>
    /// Literal for code: ExecutableApp
    /// </summary>
    public const string LiteralExecutableApp = "executable-app";

    /// <summary>
    /// Literal for code: FHIRResource
    /// </summary>
    public const string LiteralFHIRResource = "fhir-resource";

    /// <summary>
    /// Literal for code: ImageFile
    /// </summary>
    public const string LiteralImageFile = "image";

    /// <summary>
    /// Literal for code: MachineCode
    /// </summary>
    public const string LiteralMachineCode = "machine-code";

    /// <summary>
    /// Literal for code: MedlineBase
    /// </summary>
    public const string LiteralMedlineBase = "medline-base";

    /// <summary>
    /// Literal for code: Print
    /// </summary>
    public const string LiteralPrint = "Print";

    /// <summary>
    /// Literal for code: PrintElectronic
    /// </summary>
    public const string LiteralPrintElectronic = "Print-Electronic";

    /// <summary>
    /// Literal for code: ProjectSpecific
    /// </summary>
    public const string LiteralProjectSpecific = "project-specific";

    /// <summary>
    /// Literal for code: Protocol
    /// </summary>
    public const string LiteralProtocol = "protocol";

    /// <summary>
    /// Literal for code: Webpage
    /// </summary>
    public const string LiteralWebpage = "webpage";
  };
}
