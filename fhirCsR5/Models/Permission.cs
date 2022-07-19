// <auto-generated />
// Built from: hl7.fhir.r5.core version: 3.0.1
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// A description or definition of which activities are allowed to be done on the data.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<PermissionProcessingActivity>))]
  public class PermissionProcessingActivity : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// If the processing is a transfer, or involves another party, we must capture where it the data allowed or expected to be shared - with a party or person. This can be a party instance or party type
    /// § Purpose – a specific purpose of the data.
    /// </summary>
    public List<CodeableConcept> PartyCodeableConcept { get; set; }
    /// <summary>
    /// If the processing is a transfer, we must capture where it the data allowed or expected to be shared - with a party or person.
    /// </summary>
    public List<Reference> PartyReference { get; set; }
    /// <summary>
    /// The purpose for which the permission is given.
    /// </summary>
    public List<CodeableConcept> Purpose { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if ((PartyReference != null) && (PartyReference.Count != 0))
      {
        writer.WritePropertyName("partyReference");
        writer.WriteStartArray();

        foreach (Reference valPartyReference in PartyReference)
        {
          valPartyReference.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((PartyCodeableConcept != null) && (PartyCodeableConcept.Count != 0))
      {
        writer.WritePropertyName("partyCodeableConcept");
        writer.WriteStartArray();

        foreach (CodeableConcept valPartyCodeableConcept in PartyCodeableConcept)
        {
          valPartyCodeableConcept.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Purpose != null) && (Purpose.Count != 0))
      {
        writer.WritePropertyName("purpose");
        writer.WriteStartArray();

        foreach (CodeableConcept valPurpose in Purpose)
        {
          valPurpose.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "partyCodeableConcept":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PartyCodeableConcept = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objPartyCodeableConcept = new fhirCsR5.Models.CodeableConcept();
            objPartyCodeableConcept.DeserializeJson(ref reader, options);
            PartyCodeableConcept.Add(objPartyCodeableConcept);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PartyCodeableConcept.Count == 0)
          {
            PartyCodeableConcept = null;
          }

          break;

        case "partyReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PartyReference = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objPartyReference = new fhirCsR5.Models.Reference();
            objPartyReference.DeserializeJson(ref reader, options);
            PartyReference.Add(objPartyReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PartyReference.Count == 0)
          {
            PartyReference = null;
          }

          break;

        case "purpose":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Purpose = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objPurpose = new fhirCsR5.Models.CodeableConcept();
            objPurpose.DeserializeJson(ref reader, options);
            Purpose.Add(objPurpose);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Purpose.Count == 0)
          {
            Purpose = null;
          }

          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// The asserted justification for using the data.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<PermissionJustification>))]
  public class PermissionJustification : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Evidence – reference to consent, or a contract, or a policy, or a regulation, or an attachment that contains a screenshot.
    /// </summary>
    public List<Reference> Evidence { get; set; }
    /// <summary>
    /// This would be a codeableconcept, or a coding, which can be constrained to , for example, the 6 grounds for processing in GDPR.
    /// </summary>
    public List<CodeableConcept> Grounds { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if ((Evidence != null) && (Evidence.Count != 0))
      {
        writer.WritePropertyName("evidence");
        writer.WriteStartArray();

        foreach (Reference valEvidence in Evidence)
        {
          valEvidence.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Grounds != null) && (Grounds.Count != 0))
      {
        writer.WritePropertyName("grounds");
        writer.WriteStartArray();

        foreach (CodeableConcept valGrounds in Grounds)
        {
          valGrounds.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "evidence":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Evidence = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objEvidence = new fhirCsR5.Models.Reference();
            objEvidence.DeserializeJson(ref reader, options);
            Evidence.Add(objEvidence);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Evidence.Count == 0)
          {
            Evidence = null;
          }

          break;

        case "grounds":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Grounds = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objGrounds = new fhirCsR5.Models.CodeableConcept();
            objGrounds.DeserializeJson(ref reader, options);
            Grounds.Add(objGrounds);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Grounds.Count == 0)
          {
            Grounds = null;
          }

          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Permission.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<Permission>))]
  public class Permission : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Permission";
    /// <summary>
    /// The person or entity that asserts the permission.
    /// </summary>
    public Reference Asserter { get; set; }
    /// <summary>
    /// The date that permission was asserted.
    /// </summary>
    public List<string> AssertionDate { get; set; }
    /// <summary>
    /// Extension container element for AssertionDate
    /// </summary>
    public List<Element> _AssertionDate { get; set; }
    /// <summary>
    /// This can be 1) the definition of data elements, or 2) a category or label) e.g. “sensitive”. It could also be a c) graph-like definition of a set of data elements.
    /// </summary>
    public List<Expression> DataScope { get; set; }
    /// <summary>
    /// grant|refuse.
    /// </summary>
    public CodeableConcept Intent { get; set; }
    /// <summary>
    /// The asserted justification for using the data.
    /// </summary>
    public PermissionJustification Justification { get; set; }
    /// <summary>
    /// A description or definition of which activities are allowed to be done on the data.
    /// </summary>
    public List<PermissionProcessingActivity> ProcessingActivity { get; set; }
    /// <summary>
    /// The purpose for which the permission is given.
    /// </summary>
    public List<CodeableConcept> Purpose { get; set; }
    /// <summary>
    /// Status.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// What limits apply to the use of the data.
    /// </summary>
    public List<CodeableConcept> UsageLimitations { get; set; }
    /// <summary>
    /// The period in which the permission is active.
    /// </summary>
    public Period Validity { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR5.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (Intent != null)
      {
        writer.WritePropertyName("intent");
        Intent.SerializeJson(writer, options);
      }

      if (Asserter != null)
      {
        writer.WritePropertyName("asserter");
        Asserter.SerializeJson(writer, options);
      }

      if ((AssertionDate != null) && (AssertionDate.Count != 0))
      {
        writer.WritePropertyName("assertionDate");
        writer.WriteStartArray();

        foreach (string valAssertionDate in AssertionDate)
        {
          writer.WriteStringValue(valAssertionDate);
        }

        writer.WriteEndArray();
      }

      if ((_AssertionDate != null) && (_AssertionDate.Count != 0))
      {
        writer.WritePropertyName("_assertionDate");
        writer.WriteStartArray();

        foreach (Element val_AssertionDate in _AssertionDate)
        {
          val_AssertionDate.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Validity != null)
      {
        writer.WritePropertyName("validity");
        Validity.SerializeJson(writer, options);
      }

      if ((Purpose != null) && (Purpose.Count != 0))
      {
        writer.WritePropertyName("purpose");
        writer.WriteStartArray();

        foreach (CodeableConcept valPurpose in Purpose)
        {
          valPurpose.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((DataScope != null) && (DataScope.Count != 0))
      {
        writer.WritePropertyName("dataScope");
        writer.WriteStartArray();

        foreach (Expression valDataScope in DataScope)
        {
          valDataScope.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ProcessingActivity != null) && (ProcessingActivity.Count != 0))
      {
        writer.WritePropertyName("processingActivity");
        writer.WriteStartArray();

        foreach (PermissionProcessingActivity valProcessingActivity in ProcessingActivity)
        {
          valProcessingActivity.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Justification != null)
      {
        writer.WritePropertyName("justification");
        Justification.SerializeJson(writer, options);
      }

      if ((UsageLimitations != null) && (UsageLimitations.Count != 0))
      {
        writer.WritePropertyName("usageLimitations");
        writer.WriteStartArray();

        foreach (CodeableConcept valUsageLimitations in UsageLimitations)
        {
          valUsageLimitations.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "asserter":
          Asserter = new fhirCsR5.Models.Reference();
          Asserter.DeserializeJson(ref reader, options);
          break;

        case "assertionDate":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          AssertionDate = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            AssertionDate.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (AssertionDate.Count == 0)
          {
            AssertionDate = null;
          }

          break;

        case "_assertionDate":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _AssertionDate = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_AssertionDate = new fhirCsR5.Models.Element();
            obj_AssertionDate.DeserializeJson(ref reader, options);
            _AssertionDate.Add(obj_AssertionDate);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_AssertionDate.Count == 0)
          {
            _AssertionDate = null;
          }

          break;

        case "dataScope":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DataScope = new List<Expression>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Expression objDataScope = new fhirCsR5.Models.Expression();
            objDataScope.DeserializeJson(ref reader, options);
            DataScope.Add(objDataScope);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DataScope.Count == 0)
          {
            DataScope = null;
          }

          break;

        case "intent":
          Intent = new fhirCsR5.Models.CodeableConcept();
          Intent.DeserializeJson(ref reader, options);
          break;

        case "justification":
          Justification = new fhirCsR5.Models.PermissionJustification();
          Justification.DeserializeJson(ref reader, options);
          break;

        case "processingActivity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ProcessingActivity = new List<PermissionProcessingActivity>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.PermissionProcessingActivity objProcessingActivity = new fhirCsR5.Models.PermissionProcessingActivity();
            objProcessingActivity.DeserializeJson(ref reader, options);
            ProcessingActivity.Add(objProcessingActivity);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ProcessingActivity.Count == 0)
          {
            ProcessingActivity = null;
          }

          break;

        case "purpose":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Purpose = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objPurpose = new fhirCsR5.Models.CodeableConcept();
            objPurpose.DeserializeJson(ref reader, options);
            Purpose.Add(objPurpose);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Purpose.Count == 0)
          {
            Purpose = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "usageLimitations":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          UsageLimitations = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objUsageLimitations = new fhirCsR5.Models.CodeableConcept();
            objUsageLimitations.DeserializeJson(ref reader, options);
            UsageLimitations.Add(objUsageLimitations);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (UsageLimitations.Count == 0)
          {
            UsageLimitations = null;
          }

          break;

        case "validity":
          Validity = new fhirCsR5.Models.Period();
          Validity.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the Permission.status field
  /// </summary>
  public static class PermissionStatusCodes {
    public const string ACTIVE = "active";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string DRAFT = "draft";
    public const string REJECTED = "rejected";
    public static HashSet<string> Values = new HashSet<string>() {
      "active",
      "entered-in-error",
      "draft",
      "rejected",
    };
  }
}
