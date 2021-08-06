// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Description Needed Here
  /// </summary>
  public static class ExpansionParameterSourceCodes
  {
    /// <summary>
    /// The parameter was added from one the code systems used in the $expand operation.
    /// </summary>
    public static readonly Coding CodeSystem = new Coding
    {
      Code = "codesystem",
      Display = "Code System",
      System = "http://hl7.org/fhir/expansion-parameter-source"
    };
    /// <summary>
    /// The parameter was supplied by the client in the $expand request.
    /// </summary>
    public static readonly Coding ClientInput = new Coding
    {
      Code = "input",
      Display = "Client Input",
      System = "http://hl7.org/fhir/expansion-parameter-source"
    };
    /// <summary>
    /// The parameter was added by the expansion engine on the server.
    /// </summary>
    public static readonly Coding ServerEngine = new Coding
    {
      Code = "server",
      Display = "Server Engine",
      System = "http://hl7.org/fhir/expansion-parameter-source"
    };

    /// <summary>
    /// Literal for code: CodeSystem
    /// </summary>
    public const string LiteralCodeSystem = "codesystem";

    /// <summary>
    /// Literal for code: ClientInput
    /// </summary>
    public const string LiteralClientInput = "input";

    /// <summary>
    /// Literal for code: ServerEngine
    /// </summary>
    public const string LiteralServerEngine = "server";
  };
}