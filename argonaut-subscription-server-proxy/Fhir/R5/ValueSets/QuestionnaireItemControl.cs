// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Starter set of user interface control/display mechanisms that might be used when rendering an item in a questionnaire.
  /// </summary>
  public static class QuestionnaireItemControlCodes
  {
    /// <summary>
    /// A control which provides a list of potential matches based on text entered into a control.  Used for large choice sets where text-matching is an appropriate discovery mechanism.
    /// </summary>
    public static readonly Coding AutoComplete = new Coding
    {
      Code = "autocomplete",
      Display = "Auto-complete",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// A control where choices are listed with a box beside them.  The box can be toggled to select or de-select a given choice.  Multiple selections may be possible.
    /// </summary>
    public static readonly Coding CheckBox = new Coding
    {
      Code = "check-box",
      Display = "Check-box",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// UI controls relevant to rendering questionnaire display items
    /// </summary>
    public static readonly Coding Display = new Coding
    {
      Code = "display",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// A control where an item (or multiple items) can be selected from a list that is only displayed when the user is editing the field.
    /// </summary>
    public static readonly Coding DropDown = new Coding
    {
      Code = "drop-down",
      Display = "Drop down",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Display item is temporarily visible over top of an item if the mouse is positioned over top of the text for the containing item
    /// </summary>
    public static readonly Coding FlyOver = new Coding
    {
      Code = "flyover",
      Display = "Fly-over",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// The group is to be continuously visible at the bottom of the questionnaire
    /// </summary>
    public static readonly Coding Footer = new Coding
    {
      Code = "footer",
      Display = "Footer",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Child items of type='group' within the a 'grid' group are rows, and questions beneath the 'row' groups are organized as columns in the grid. The grid might be fully populated, but could be sparse. Questions may support different data types and/or different answer choices.
    /// </summary>
    public static readonly Coding GroupGrid = new Coding
    {
      Code = "grid",
      Display = "Group Grid",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// UI controls relevant to organizing groups of questions
    /// </summary>
    public static readonly Coding Group = new Coding
    {
      Code = "group",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Questions within the group are columns in the table with each group repetition as a row.  Used for single-answer questions.
    /// </summary>
    public static readonly Coding GroupTable = new Coding
    {
      Code = "gtable",
      Display = "Group Table",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// The group is to be continuously visible at the top of the questionnaire
    /// </summary>
    public static readonly Coding Header = new Coding
    {
      Code = "header",
      Display = "Header",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Display item is rendered in a dialog box or similar control if invoked by pushing a button or some other UI-appropriate action to request 'help' for a question, group or the questionnaire as a whole (depending what the display item is nested within)
    /// </summary>
    public static readonly Coding HelpButton = new Coding
    {
      Code = "help",
      Display = "Help-Button",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Questions within the group are columns in the table with possible answers as rows.  Used for 'choice' questions.
    /// </summary>
    public static readonly Coding HorizontalAnswerTable = new Coding
    {
      Code = "htable",
      Display = "Horizontal Answer Table",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Display item is rendered as a paragraph in a sequential position between sibling items (default behavior)
    /// </summary>
    public static readonly Coding InLine = new Coding
    {
      Code = "inline",
      Display = "In-line",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Display item is rendered in a dialog box or similar control if invoked by pushing a button or some other UI-appropriate action to request 'legal' info for a question, group or the questionnaire as a whole (depending what the display item is nested within)
    /// </summary>
    public static readonly Coding LegalButton = new Coding
    {
      Code = "legal",
      Display = "legal-Button",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Questions within the group should be listed sequentially
    /// </summary>
    public static readonly Coding List = new Coding
    {
      Code = "list",
      Display = "List",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// A control where editing an item spawns a separate dialog box or screen permitting a user to navigate, filter or otherwise discover an appropriate match.  Useful for large choice sets where text matching is not an appropriate discovery mechanism.  Such screens must generally be tuned for the specific choice list structure.
    /// </summary>
    public static readonly Coding Lookup = new Coding
    {
      Code = "lookup",
      Display = "Lookup",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Display item is rendered to the left of the set of answer choices or a scaling control for the parent question item to indicate the meaning of the 'lower' bound.  E.g. 'Strongly disagree'
    /// </summary>
    public static readonly Coding LowerBound = new Coding
    {
      Code = "lower",
      Display = "Lower-bound",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Indicates that the content within the group should appear as a logical "page" when rendering the form, such that all enabled items        within the page are displayed at once, but items in subsequent groups are not displayed until the user indicates a desire to move to the 'next' group.        (Header and footer items may still be displayed.) This designation may also influence pagination when printing questionnaires. If there are items at the same        level as a 'page' group that are listed before the 'page' group, they will be treated as a separate page.  Header and footer groups for a questionnaire will be rendered on all pages.
    /// </summary>
    public static readonly Coding Page = new Coding
    {
      Code = "page",
      Display = "Page",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// UI controls relevant to capturing question data
    /// </summary>
    public static readonly Coding Question = new Coding
    {
      Code = "question",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// A control where choices are listed with a button beside them.  The button can be toggled to select or de-select a given choice.  Selecting one item deselects all others.
    /// </summary>
    public static readonly Coding RadioButton = new Coding
    {
      Code = "radio-button",
      Display = "Radio Button",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// A control where an axis is displayed between the high and low values and the control can be visually manipulated to select a value anywhere on the axis.
    /// </summary>
    public static readonly Coding Slider = new Coding
    {
      Code = "slider",
      Display = "Slider",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// A control where a list of numeric or other ordered values can be scrolled through via arrows.
    /// </summary>
    public static readonly Coding Spinner = new Coding
    {
      Code = "spinner",
      Display = "Spinner",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Questions within the group are rows in the table with possible answers as columns.  Used for 'choice' questions.
    /// </summary>
    public static readonly Coding VerticalAnswerTable = new Coding
    {
      Code = "table",
      Display = "Vertical Answer Table",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// A control where a user can type in their answer freely.
    /// </summary>
    public static readonly Coding TextBox = new Coding
    {
      Code = "text-box",
      Display = "Text Box",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Display item is rendered adjacent (horizontally or vertically) to the answer space for the parent question, typically to indicate a unit of measure
    /// </summary>
    public static readonly Coding Unit = new Coding
    {
      Code = "unit",
      Display = "Unit",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };
    /// <summary>
    /// Display item is rendered to the right of the set of answer choices or a scaling control for the parent question item to indicate the meaning of the 'upper' bound.  E.g. 'Strongly agree'
    /// </summary>
    public static readonly Coding UpperBound = new Coding
    {
      Code = "upper",
      Display = "Upper-bound",
      System = "http://hl7.org/fhir/questionnaire-item-control"
    };

    /// <summary>
    /// Literal for code: AutoComplete
    /// </summary>
    public const string LiteralAutoComplete = "autocomplete";

    /// <summary>
    /// Literal for code: CheckBox
    /// </summary>
    public const string LiteralCheckBox = "check-box";

    /// <summary>
    /// Literal for code: Display
    /// </summary>
    public const string LiteralDisplay = "display";

    /// <summary>
    /// Literal for code: DropDown
    /// </summary>
    public const string LiteralDropDown = "drop-down";

    /// <summary>
    /// Literal for code: FlyOver
    /// </summary>
    public const string LiteralFlyOver = "flyover";

    /// <summary>
    /// Literal for code: Footer
    /// </summary>
    public const string LiteralFooter = "footer";

    /// <summary>
    /// Literal for code: GroupGrid
    /// </summary>
    public const string LiteralGroupGrid = "grid";

    /// <summary>
    /// Literal for code: Group
    /// </summary>
    public const string LiteralGroup = "group";

    /// <summary>
    /// Literal for code: GroupTable
    /// </summary>
    public const string LiteralGroupTable = "gtable";

    /// <summary>
    /// Literal for code: Header
    /// </summary>
    public const string LiteralHeader = "header";

    /// <summary>
    /// Literal for code: HelpButton
    /// </summary>
    public const string LiteralHelpButton = "help";

    /// <summary>
    /// Literal for code: HorizontalAnswerTable
    /// </summary>
    public const string LiteralHorizontalAnswerTable = "htable";

    /// <summary>
    /// Literal for code: InLine
    /// </summary>
    public const string LiteralInLine = "inline";

    /// <summary>
    /// Literal for code: LegalButton
    /// </summary>
    public const string LiteralLegalButton = "legal";

    /// <summary>
    /// Literal for code: List
    /// </summary>
    public const string LiteralList = "list";

    /// <summary>
    /// Literal for code: Lookup
    /// </summary>
    public const string LiteralLookup = "lookup";

    /// <summary>
    /// Literal for code: LowerBound
    /// </summary>
    public const string LiteralLowerBound = "lower";

    /// <summary>
    /// Literal for code: Page
    /// </summary>
    public const string LiteralPage = "page";

    /// <summary>
    /// Literal for code: Question
    /// </summary>
    public const string LiteralQuestion = "question";

    /// <summary>
    /// Literal for code: RadioButton
    /// </summary>
    public const string LiteralRadioButton = "radio-button";

    /// <summary>
    /// Literal for code: Slider
    /// </summary>
    public const string LiteralSlider = "slider";

    /// <summary>
    /// Literal for code: Spinner
    /// </summary>
    public const string LiteralSpinner = "spinner";

    /// <summary>
    /// Literal for code: VerticalAnswerTable
    /// </summary>
    public const string LiteralVerticalAnswerTable = "table";

    /// <summary>
    /// Literal for code: TextBox
    /// </summary>
    public const string LiteralTextBox = "text-box";

    /// <summary>
    /// Literal for code: Unit
    /// </summary>
    public const string LiteralUnit = "unit";

    /// <summary>
    /// Literal for code: UpperBound
    /// </summary>
    public const string LiteralUpperBound = "upper";
  };
}