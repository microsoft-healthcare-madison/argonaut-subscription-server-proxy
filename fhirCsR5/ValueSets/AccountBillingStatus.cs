// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Indicates whether the account is available to be used for billing purposes.
  /// </summary>
  public static class AccountBillingStatusCodes
  {
    /// <summary>
    /// Indicates that all transactions are recorded and the finance system can perform the billing process, including preparing insurance claims, scrubbing charges, invoicing etc. During this time any new charges will not be included in the current billing run/cycle. (account.status is active)
    /// </summary>
    public static readonly Coding Billing = new Coding
    {
      Code = "billing",
      Display = "Billing",
      System = "http://hl7.org/fhir/account-billing-status"
    };
    /// <summary>
    /// The account.status is still active and may have charges recorded against it (only for events in the servicePeriod), however the encounters associated are completed. (Also known as Discharged not billed) This BillingStatus is often not used in ongoing accounts. (account.status is active)
    /// </summary>
    public static readonly Coding CareCompleteNotBilled = new Coding
    {
      Code = "carecomplete-notbilled",
      Display = "CareComplete/Not Billed",
      System = "http://hl7.org/fhir/account-billing-status"
    };
    /// <summary>
    /// The balance of this debt has not been able to be recovered, and the organization has decided not to persue debt recovery. (account.status is in-active)
    /// </summary>
    public static readonly Coding ClosedBadDebt = new Coding
    {
      Code = "closed-baddebt",
      Display = "Closed-Bad Debt",
      System = "http://hl7.org/fhir/account-billing-status"
    };
    /// <summary>
    /// This account has been merged into another account, all charged have been migrated. This account should no longer be used, and will not be billed. (account.status is i n-active)
    /// </summary>
    public static readonly Coding ClosedCombined = new Coding
    {
      Code = "closed-combined",
      Display = "Closed-Combined",
      System = "http://hl7.org/fhir/account-billing-status"
    };
    /// <summary>
    /// The account is closed and all charges are processed and accounted for. (account.status is i n-active)
    /// </summary>
    public static readonly Coding ClosedCompleted = new Coding
    {
      Code = "closed-completed",
      Display = "Closed-Completed",
      System = "http://hl7.org/fhir/account-billing-status"
    };
    /// <summary>
    /// The account was not created in error, however the organization has decided that it will not be charging any transactions associated. (account.status is i n-active)
    /// </summary>
    public static readonly Coding ClosedVoided = new Coding
    {
      Code = "closed-voided",
      Display = "Closed-Voided",
      System = "http://hl7.org/fhir/account-billing-status"
    };
    /// <summary>
    /// The account is open for charging transactions (account.status is active)
    /// </summary>
    public static readonly Coding Open = new Coding
    {
      Code = "open",
      Display = "Open",
      System = "http://hl7.org/fhir/account-billing-status"
    };

    /// <summary>
    /// Literal for code: Billing
    /// </summary>
    public const string LiteralBilling = "billing";

    /// <summary>
    /// Literal for code: AccountBillingStatusBilling
    /// </summary>
    public const string LiteralAccountBillingStatusBilling = "http://hl7.org/fhir/account-billing-status#billing";

    /// <summary>
    /// Literal for code: CareCompleteNotBilled
    /// </summary>
    public const string LiteralCareCompleteNotBilled = "carecomplete-notbilled";

    /// <summary>
    /// Literal for code: AccountBillingStatusCareCompleteNotBilled
    /// </summary>
    public const string LiteralAccountBillingStatusCareCompleteNotBilled = "http://hl7.org/fhir/account-billing-status#carecomplete-notbilled";

    /// <summary>
    /// Literal for code: ClosedBadDebt
    /// </summary>
    public const string LiteralClosedBadDebt = "closed-baddebt";

    /// <summary>
    /// Literal for code: AccountBillingStatusClosedBadDebt
    /// </summary>
    public const string LiteralAccountBillingStatusClosedBadDebt = "http://hl7.org/fhir/account-billing-status#closed-baddebt";

    /// <summary>
    /// Literal for code: ClosedCombined
    /// </summary>
    public const string LiteralClosedCombined = "closed-combined";

    /// <summary>
    /// Literal for code: AccountBillingStatusClosedCombined
    /// </summary>
    public const string LiteralAccountBillingStatusClosedCombined = "http://hl7.org/fhir/account-billing-status#closed-combined";

    /// <summary>
    /// Literal for code: ClosedCompleted
    /// </summary>
    public const string LiteralClosedCompleted = "closed-completed";

    /// <summary>
    /// Literal for code: AccountBillingStatusClosedCompleted
    /// </summary>
    public const string LiteralAccountBillingStatusClosedCompleted = "http://hl7.org/fhir/account-billing-status#closed-completed";

    /// <summary>
    /// Literal for code: ClosedVoided
    /// </summary>
    public const string LiteralClosedVoided = "closed-voided";

    /// <summary>
    /// Literal for code: AccountBillingStatusClosedVoided
    /// </summary>
    public const string LiteralAccountBillingStatusClosedVoided = "http://hl7.org/fhir/account-billing-status#closed-voided";

    /// <summary>
    /// Literal for code: Open
    /// </summary>
    public const string LiteralOpen = "open";

    /// <summary>
    /// Literal for code: AccountBillingStatusOpen
    /// </summary>
    public const string LiteralAccountBillingStatusOpen = "http://hl7.org/fhir/account-billing-status#open";

    /// <summary>
    /// Dictionary for looking up AccountBillingStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "billing", Billing }, 
      { "http://hl7.org/fhir/account-billing-status#billing", Billing }, 
      { "carecomplete-notbilled", CareCompleteNotBilled }, 
      { "http://hl7.org/fhir/account-billing-status#carecomplete-notbilled", CareCompleteNotBilled }, 
      { "closed-baddebt", ClosedBadDebt }, 
      { "http://hl7.org/fhir/account-billing-status#closed-baddebt", ClosedBadDebt }, 
      { "closed-combined", ClosedCombined }, 
      { "http://hl7.org/fhir/account-billing-status#closed-combined", ClosedCombined }, 
      { "closed-completed", ClosedCompleted }, 
      { "http://hl7.org/fhir/account-billing-status#closed-completed", ClosedCompleted }, 
      { "closed-voided", ClosedVoided }, 
      { "http://hl7.org/fhir/account-billing-status#closed-voided", ClosedVoided }, 
      { "open", Open }, 
      { "http://hl7.org/fhir/account-billing-status#open", Open }, 
    };
  };
}
