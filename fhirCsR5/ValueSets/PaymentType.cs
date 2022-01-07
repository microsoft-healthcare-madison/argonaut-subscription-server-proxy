// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes sample Payment Type codes.
  /// </summary>
  public static class PaymentTypeCodes
  {
    /// <summary>
    /// Adjustment
    /// </summary>
    public static readonly Coding Adjustment = new Coding
    {
      Code = "adjustment",
      Display = "Adjustment",
      System = "http://terminology.hl7.org/CodeSystem/payment-type"
    };
    /// <summary>
    /// Advance
    /// </summary>
    public static readonly Coding Advance = new Coding
    {
      Code = "advance",
      Display = "Advance",
      System = "http://terminology.hl7.org/CodeSystem/payment-type"
    };
    /// <summary>
    /// Payment
    /// </summary>
    public static readonly Coding Payment = new Coding
    {
      Code = "payment",
      Display = "Payment",
      System = "http://terminology.hl7.org/CodeSystem/payment-type"
    };

    /// <summary>
    /// Literal for code: Adjustment
    /// </summary>
    public const string LiteralAdjustment = "adjustment";

    /// <summary>
    /// Literal for code: PaymentTypeAdjustment
    /// </summary>
    public const string LiteralPaymentTypeAdjustment = "http://terminology.hl7.org/CodeSystem/payment-type#adjustment";

    /// <summary>
    /// Literal for code: Advance
    /// </summary>
    public const string LiteralAdvance = "advance";

    /// <summary>
    /// Literal for code: PaymentTypeAdvance
    /// </summary>
    public const string LiteralPaymentTypeAdvance = "http://terminology.hl7.org/CodeSystem/payment-type#advance";

    /// <summary>
    /// Literal for code: Payment
    /// </summary>
    public const string LiteralPayment = "payment";

    /// <summary>
    /// Literal for code: PaymentTypePayment
    /// </summary>
    public const string LiteralPaymentTypePayment = "http://terminology.hl7.org/CodeSystem/payment-type#payment";

    /// <summary>
    /// Dictionary for looking up PaymentType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "adjustment", Adjustment }, 
      { "http://terminology.hl7.org/CodeSystem/payment-type#adjustment", Adjustment }, 
      { "advance", Advance }, 
      { "http://terminology.hl7.org/CodeSystem/payment-type#advance", Advance }, 
      { "payment", Payment }, 
      { "http://terminology.hl7.org/CodeSystem/payment-type#payment", Payment }, 
    };
  };
}
