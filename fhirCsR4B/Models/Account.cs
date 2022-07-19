// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0
  // Option: "NAMESPACE" = "fhirCsR4B"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using fhirCsR4B.Serialization;

namespace fhirCsR4B.Models
{
  /// <summary>
  /// Typically. this may be some form of insurance, internal charges, or self-pay.
  /// Local or jurisdictional business rules may determine which coverage covers which types of billable items charged to the account, and in which order.
  /// Where the order is important, a local/jurisdictional extension may be defined to specify the order for the type of charge.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<AccountCoverage>))]
  public class AccountCoverage : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The party(s) that contribute to payment (or part of) of the charges applied to this account (including self-pay).
    /// A coverage may only be responsible for specific types of charges, and the sequence of the coverages in the account could be important when processing billing.
    /// </summary>
    public Reference Coverage { get; set; }
    /// <summary>
    /// It is common in some jurisdictions for there to be multiple coverages allocated to an account, and a sequence is required to order the settling of the account (often with insurance claiming).
    /// </summary>
    public uint? Priority { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4B.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Coverage != null)
      {
        writer.WritePropertyName("coverage");
        Coverage.SerializeJson(writer, options);
      }

      if (Priority != null)
      {
        writer.WriteNumber("priority", (uint)Priority!);
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
        case "coverage":
          Coverage = new fhirCsR4B.Models.Reference();
          Coverage.DeserializeJson(ref reader, options);
          break;

        case "priority":
          Priority = reader.GetUInt32();
          break;

        default:
          ((fhirCsR4B.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// The parties responsible for balancing the account if other payment options fall short.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<AccountGuarantor>))]
  public class AccountGuarantor : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A guarantor may be placed on credit hold or otherwise have their role temporarily suspended.
    /// </summary>
    public bool? OnHold { get; set; }
    /// <summary>
    /// Extension container element for OnHold
    /// </summary>
    public Element _OnHold { get; set; }
    /// <summary>
    /// The entity who is responsible.
    /// </summary>
    public Reference Party { get; set; }
    /// <summary>
    /// The timeframe during which the guarantor accepts responsibility for the account.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4B.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Party != null)
      {
        writer.WritePropertyName("party");
        Party.SerializeJson(writer, options);
      }

      if (OnHold != null)
      {
        writer.WriteBoolean("onHold", (bool)OnHold!);
      }

      if (_OnHold != null)
      {
        writer.WritePropertyName("_onHold");
        _OnHold.SerializeJson(writer, options);
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
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
        case "onHold":
          OnHold = reader.GetBoolean();
          break;

        case "_onHold":
          _OnHold = new fhirCsR4B.Models.Element();
          _OnHold.DeserializeJson(ref reader, options);
          break;

        case "party":
          Party = new fhirCsR4B.Models.Reference();
          Party.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new fhirCsR4B.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4B.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// A financial tool for tracking value accrued for a particular purpose.  In the healthcare field, used to track charges for a patient, cost centers, etc.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<Account>))]
  public class Account : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Account";
    /// <summary>
    /// Typically. this may be some form of insurance, internal charges, or self-pay.
    /// Local or jurisdictional business rules may determine which coverage covers which types of billable items charged to the account, and in which order.
    /// Where the order is important, a local/jurisdictional extension may be defined to specify the order for the type of charge.
    /// </summary>
    public List<AccountCoverage> Coverage { get; set; }
    /// <summary>
    /// Provides additional information about what the account tracks and how it is used.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// The parties responsible for balancing the account if other payment options fall short.
    /// </summary>
    public List<AccountGuarantor> Guarantor { get; set; }
    /// <summary>
    /// Unique identifier used to reference the account.  Might or might not be intended for human use (e.g. credit card number).
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Name used for the account when displaying it to humans in reports, etc.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// Indicates the service area, hospital, department, etc. with responsibility for managing the Account.
    /// </summary>
    public Reference Owner { get; set; }
    /// <summary>
    /// Reference to a parent Account.
    /// </summary>
    public Reference PartOf { get; set; }
    /// <summary>
    /// It is possible for transactions to be posted outside the service period, as long as the service was provided within the defined service period.
    /// </summary>
    public Period ServicePeriod { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains the codes inactive and entered-in-error that mark the Account as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Accounts can be applied to non-patients for tracking other non-patient related activities, such as group services (patients not tracked, and costs charged to another body), or might not be allocated.
    /// </summary>
    public List<Reference> Subject { get; set; }
    /// <summary>
    /// Categorizes the account for reporting and searching purposes.
    /// </summary>
    public CodeableConcept Type { get; set; }
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


      ((fhirCsR4B.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(writer, options);
      }

      if ((Subject != null) && (Subject.Count != 0))
      {
        writer.WritePropertyName("subject");
        writer.WriteStartArray();

        foreach (Reference valSubject in Subject)
        {
          valSubject.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (ServicePeriod != null)
      {
        writer.WritePropertyName("servicePeriod");
        ServicePeriod.SerializeJson(writer, options);
      }

      if ((Coverage != null) && (Coverage.Count != 0))
      {
        writer.WritePropertyName("coverage");
        writer.WriteStartArray();

        foreach (AccountCoverage valCoverage in Coverage)
        {
          valCoverage.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Owner != null)
      {
        writer.WritePropertyName("owner");
        Owner.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
      }

      if ((Guarantor != null) && (Guarantor.Count != 0))
      {
        writer.WritePropertyName("guarantor");
        writer.WriteStartArray();

        foreach (AccountGuarantor valGuarantor in Guarantor)
        {
          valGuarantor.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (PartOf != null)
      {
        writer.WritePropertyName("partOf");
        PartOf.SerializeJson(writer, options);
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
        case "coverage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Coverage = new List<AccountCoverage>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.AccountCoverage objCoverage = new fhirCsR4B.Models.AccountCoverage();
            objCoverage.DeserializeJson(ref reader, options);
            Coverage.Add(objCoverage);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Coverage.Count == 0)
          {
            Coverage = null;
          }

          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR4B.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "guarantor":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Guarantor = new List<AccountGuarantor>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.AccountGuarantor objGuarantor = new fhirCsR4B.Models.AccountGuarantor();
            objGuarantor.DeserializeJson(ref reader, options);
            Guarantor.Add(objGuarantor);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Guarantor.Count == 0)
          {
            Guarantor = null;
          }

          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.Identifier objIdentifier = new fhirCsR4B.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new fhirCsR4B.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "owner":
          Owner = new fhirCsR4B.Models.Reference();
          Owner.DeserializeJson(ref reader, options);
          break;

        case "partOf":
          PartOf = new fhirCsR4B.Models.Reference();
          PartOf.DeserializeJson(ref reader, options);
          break;

        case "servicePeriod":
          ServicePeriod = new fhirCsR4B.Models.Period();
          ServicePeriod.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR4B.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Subject = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.Reference objSubject = new fhirCsR4B.Models.Reference();
            objSubject.DeserializeJson(ref reader, options);
            Subject.Add(objSubject);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Subject.Count == 0)
          {
            Subject = null;
          }

          break;

        case "type":
          Type = new fhirCsR4B.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4B.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the Account.status field
  /// </summary>
  public static class AccountStatusCodes {
    public const string ACTIVE = "active";
    public const string INACTIVE = "inactive";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string ON_HOLD = "on-hold";
    public const string UNKNOWN = "unknown";
    public static HashSet<string> Values = new HashSet<string>() {
      "active",
      "inactive",
      "entered-in-error",
      "on-hold",
      "unknown",
    };
  }
}
