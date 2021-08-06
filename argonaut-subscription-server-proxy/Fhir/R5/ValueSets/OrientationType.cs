// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Type for orientation.
  /// </summary>
  public static class OrientationTypeCodes
  {
    /// <summary>
    /// Antisense orientation of reference sequence.
    /// </summary>
    public static readonly Coding AntisenseOrientationOfReferenceSeq = new Coding
    {
      Code = "antisense",
      Display = "Antisense orientation of referenceSeq",
      System = "http://hl7.org/fhir/orientation-type"
    };
    /// <summary>
    /// Sense orientation of reference sequence.
    /// </summary>
    public static readonly Coding SenseOrientationOfReferenceSeq = new Coding
    {
      Code = "sense",
      Display = "Sense orientation of referenceSeq",
      System = "http://hl7.org/fhir/orientation-type"
    };

    /// <summary>
    /// Literal for code: AntisenseOrientationOfReferenceSeq
    /// </summary>
    public const string LiteralAntisenseOrientationOfReferenceSeq = "antisense";

    /// <summary>
    /// Literal for code: SenseOrientationOfReferenceSeq
    /// </summary>
    public const string LiteralSenseOrientationOfReferenceSeq = "sense";
  };
}