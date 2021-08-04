// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Indicates the purpose of a bundle - how it is intended to be used.
  /// </summary>
  public static class BundleTypeCodes
  {
    /// <summary>
    /// The bundle is a set of actions - intended to be processed by a server as a group of independent actions.
    /// </summary>
    public static readonly Coding Batch = new Coding
    {
      Code = "batch",
      Display = "Batch",
      System = "http://hl7.org/fhir/bundle-type"
    };
    /// <summary>
    /// The bundle is a batch response. Note that as a batch, some responses may indicate failure and others success.
    /// </summary>
    public static readonly Coding BatchResponse = new Coding
    {
      Code = "batch-response",
      Display = "Batch Response",
      System = "http://hl7.org/fhir/bundle-type"
    };
    /// <summary>
    /// The bundle is a set of resources collected into a single package for ease of distribution that imposes no processing obligations or behavioral rules beyond persistence.
    /// </summary>
    public static readonly Coding Collection = new Coding
    {
      Code = "collection",
      Display = "Collection",
      System = "http://hl7.org/fhir/bundle-type"
    };
    /// <summary>
    /// The bundle is a document. The first resource is a Composition.
    /// </summary>
    public static readonly Coding Document = new Coding
    {
      Code = "document",
      Display = "Document",
      System = "http://hl7.org/fhir/bundle-type"
    };
    /// <summary>
    /// The bundle is a list of resources from a history interaction on a server.
    /// </summary>
    public static readonly Coding HistoryList = new Coding
    {
      Code = "history",
      Display = "History List",
      System = "http://hl7.org/fhir/bundle-type"
    };
    /// <summary>
    /// The bundle is a message. The first resource is a MessageHeader.
    /// </summary>
    public static readonly Coding Message = new Coding
    {
      Code = "message",
      Display = "Message",
      System = "http://hl7.org/fhir/bundle-type"
    };
    /// <summary>
    /// The bundle is a list of resources returned as a result of a search/query interaction, operation, or message.
    /// </summary>
    public static readonly Coding SearchResults = new Coding
    {
      Code = "searchset",
      Display = "Search Results",
      System = "http://hl7.org/fhir/bundle-type"
    };
    /// <summary>
    /// The bundle has been generated by a Subscription to communicate information to a client.
    /// </summary>
    public static readonly Coding SubscriptionNotification = new Coding
    {
      Code = "subscription-notification",
      Display = "Subscription Notification",
      System = "http://hl7.org/fhir/bundle-type"
    };
    /// <summary>
    /// The bundle is a transaction - intended to be processed by a server as an atomic commit.
    /// </summary>
    public static readonly Coding Transaction = new Coding
    {
      Code = "transaction",
      Display = "Transaction",
      System = "http://hl7.org/fhir/bundle-type"
    };
    /// <summary>
    /// The bundle is a transaction response. Because the response is a transaction response, the transaction has succeeded, and all responses are error free.
    /// </summary>
    public static readonly Coding TransactionResponse = new Coding
    {
      Code = "transaction-response",
      Display = "Transaction Response",
      System = "http://hl7.org/fhir/bundle-type"
    };

    /// <summary>
    /// Literal for code: Batch
    /// </summary>
    public const string LiteralBatch = "batch";

    /// <summary>
    /// Literal for code: BatchResponse
    /// </summary>
    public const string LiteralBatchResponse = "batch-response";

    /// <summary>
    /// Literal for code: Collection
    /// </summary>
    public const string LiteralCollection = "collection";

    /// <summary>
    /// Literal for code: Document
    /// </summary>
    public const string LiteralDocument = "document";

    /// <summary>
    /// Literal for code: HistoryList
    /// </summary>
    public const string LiteralHistoryList = "history";

    /// <summary>
    /// Literal for code: Message
    /// </summary>
    public const string LiteralMessage = "message";

    /// <summary>
    /// Literal for code: SearchResults
    /// </summary>
    public const string LiteralSearchResults = "searchset";

    /// <summary>
    /// Literal for code: SubscriptionNotification
    /// </summary>
    public const string LiteralSubscriptionNotification = "subscription-notification";

    /// <summary>
    /// Literal for code: Transaction
    /// </summary>
    public const string LiteralTransaction = "transaction";

    /// <summary>
    /// Literal for code: TransactionResponse
    /// </summary>
    public const string LiteralTransactionResponse = "transaction-response";
  };
}
