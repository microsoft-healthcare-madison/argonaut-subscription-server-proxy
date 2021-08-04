// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The criteria by which a question is enabled.
  /// </summary>
  public static class QuestionnaireEnableOperatorCodes
  {
    /// <summary>
    /// True if no answer has a value that is equal to the enableWhen answer.
    /// </summary>
    public static readonly Coding NotEquals = new Coding
    {
      Code = "!=",
      Display = "Not Equals",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if at least one answer has a value that is less than the enableWhen answer.
    /// </summary>
    public static readonly Coding LessThan = new Coding
    {
      Code = "<",
      Display = "Less Than",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if at least one answer has a value that is less or equal to the enableWhen answer.
    /// </summary>
    public static readonly Coding LessOrEquals = new Coding
    {
      Code = "<=",
      Display = "Less or Equals",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if at least one answer has a value that is equal to the enableWhen answer.
    /// </summary>
    public static readonly new Coding Equals = new Coding
    {
      Code = "=",
      Display = "Equals",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if at least one answer has a value that is greater than the enableWhen answer.
    /// </summary>
    public static readonly Coding GreaterThan = new Coding
    {
      Code = ">",
      Display = "Greater Than",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if at least one answer has a value that is greater or equal to the enableWhen answer.
    /// </summary>
    public static readonly Coding GreaterOrEquals = new Coding
    {
      Code = ">=",
      Display = "Greater or Equals",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };
    /// <summary>
    /// True if the determination of 'whether an answer exists for the question' is equal to the enableWhen answer (which must be a boolean).
    /// </summary>
    public static readonly Coding Exists = new Coding
    {
      Code = "exists",
      Display = "Exists",
      System = "http://hl7.org/fhir/questionnaire-enable-operator"
    };

    /// <summary>
    /// Literal for code: NotEquals
    /// </summary>
    public const string LiteralNotEquals = "!=";

    /// <summary>
    /// Literal for code: LessThan
    /// </summary>
    public const string LiteralLessThan = "<";

    /// <summary>
    /// Literal for code: LessOrEquals
    /// </summary>
    public const string LiteralLessOrEquals = "<=";

    /// <summary>
    /// Literal for code: Equals
    /// </summary>
    public const string LiteralEquals = "=";

    /// <summary>
    /// Literal for code: GreaterThan
    /// </summary>
    public const string LiteralGreaterThan = ">";

    /// <summary>
    /// Literal for code: GreaterOrEquals
    /// </summary>
    public const string LiteralGreaterOrEquals = ">=";

    /// <summary>
    /// Literal for code: Exists
    /// </summary>
    public const string LiteralExists = "exists";
  };
}
