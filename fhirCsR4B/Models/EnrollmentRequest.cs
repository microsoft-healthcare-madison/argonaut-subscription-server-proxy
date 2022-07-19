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
  /// This resource provides the insurance enrollment details to the insurer regarding a specified coverage.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<EnrollmentRequest>))]
  public class EnrollmentRequest : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "EnrollmentRequest";
    /// <summary>
    /// Patient Resource.
    /// </summary>
    public Reference Candidate { get; set; }
    /// <summary>
    /// Reference to the program or plan identification, underwriter or payor.
    /// </summary>
    public Reference Coverage { get; set; }
    /// <summary>
    /// The date when this resource was created.
    /// </summary>
    public string Created { get; set; }
    /// <summary>
    /// Extension container element for Created
    /// </summary>
    public Element _Created { get; set; }
    /// <summary>
    /// The Response business identifier.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The Insurer who is target  of the request.
    /// </summary>
    public Reference Insurer { get; set; }
    /// <summary>
    /// The practitioner who is responsible for the services rendered to the patient.
    /// </summary>
    public Reference Provider { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the request as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
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

      if (!string.IsNullOrEmpty(Created))
      {
        writer.WriteString("created", (string)Created!);
      }

      if (_Created != null)
      {
        writer.WritePropertyName("_created");
        _Created.SerializeJson(writer, options);
      }

      if (Insurer != null)
      {
        writer.WritePropertyName("insurer");
        Insurer.SerializeJson(writer, options);
      }

      if (Provider != null)
      {
        writer.WritePropertyName("provider");
        Provider.SerializeJson(writer, options);
      }

      if (Candidate != null)
      {
        writer.WritePropertyName("candidate");
        Candidate.SerializeJson(writer, options);
      }

      if (Coverage != null)
      {
        writer.WritePropertyName("coverage");
        Coverage.SerializeJson(writer, options);
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
        case "candidate":
          Candidate = new fhirCsR4B.Models.Reference();
          Candidate.DeserializeJson(ref reader, options);
          break;

        case "coverage":
          Coverage = new fhirCsR4B.Models.Reference();
          Coverage.DeserializeJson(ref reader, options);
          break;

        case "created":
          Created = reader.GetString();
          break;

        case "_created":
          _Created = new fhirCsR4B.Models.Element();
          _Created.DeserializeJson(ref reader, options);
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

        case "insurer":
          Insurer = new fhirCsR4B.Models.Reference();
          Insurer.DeserializeJson(ref reader, options);
          break;

        case "provider":
          Provider = new fhirCsR4B.Models.Reference();
          Provider.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR4B.Models.Element();
          _Status.DeserializeJson(ref reader, options);
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
  /// Code Values for the EnrollmentRequest.status field
  /// </summary>
  public static class EnrollmentRequestStatusCodes {
    public const string ACTIVE = "active";
    public const string CANCELLED = "cancelled";
    public const string DRAFT = "draft";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "active",
      "cancelled",
      "draft",
      "entered-in-error",
    };
  }
}
