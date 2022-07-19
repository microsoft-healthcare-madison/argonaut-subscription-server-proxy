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
  /// Describes a comparison of an immunization event against published recommendations to determine if the administration is "valid" in relation to those  recommendations.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ImmunizationEvaluation>))]
  public class ImmunizationEvaluation : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "ImmunizationEvaluation";
    /// <summary>
    /// Indicates the authority who published the protocol (e.g. ACIP).
    /// </summary>
    public Reference Authority { get; set; }
    /// <summary>
    /// The date the evaluation of the vaccine administration event was performed.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// Additional information about the evaluation.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// The use of an integer is preferred if known. A string should only be used in cases where an integer is not available (such as when documenting a recurring booster dose).
    /// </summary>
    public string DoseNumber { get; set; }
    /// <summary>
    /// Extension container element for DoseNumber
    /// </summary>
    public Element _DoseNumber { get; set; }
    /// <summary>
    /// Indicates if the dose is valid or not valid with respect to the published recommendations.
    /// </summary>
    public CodeableConcept DoseStatus { get; set; }
    /// <summary>
    /// Provides an explanation as to why the vaccine administration event is valid or not relative to the published recommendations.
    /// </summary>
    public List<CodeableConcept> DoseStatusReason { get; set; }
    /// <summary>
    /// A unique identifier assigned to this immunization evaluation record.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The vaccine administration event being evaluated.
    /// </summary>
    public Reference ImmunizationEvent { get; set; }
    /// <summary>
    /// The individual for whom the evaluation is being done.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// One possible path to achieve presumed immunity against a disease - within the context of an authority.
    /// </summary>
    public string Series { get; set; }
    /// <summary>
    /// Extension container element for Series
    /// </summary>
    public Element _Series { get; set; }
    /// <summary>
    /// The use of an integer is preferred if known.
    /// </summary>
    public string SeriesDoses { get; set; }
    /// <summary>
    /// Extension container element for SeriesDoses
    /// </summary>
    public Element _SeriesDoses { get; set; }
    /// <summary>
    /// Indicates the current status of the evaluation of the vaccination administration event.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The vaccine preventable disease the dose is being evaluated against.
    /// </summary>
    public CodeableConcept TargetDisease { get; set; }
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

      if (Patient != null)
      {
        writer.WritePropertyName("patient");
        Patient.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (Authority != null)
      {
        writer.WritePropertyName("authority");
        Authority.SerializeJson(writer, options);
      }

      if (TargetDisease != null)
      {
        writer.WritePropertyName("targetDisease");
        TargetDisease.SerializeJson(writer, options);
      }

      if (ImmunizationEvent != null)
      {
        writer.WritePropertyName("immunizationEvent");
        ImmunizationEvent.SerializeJson(writer, options);
      }

      if (DoseStatus != null)
      {
        writer.WritePropertyName("doseStatus");
        DoseStatus.SerializeJson(writer, options);
      }

      if ((DoseStatusReason != null) && (DoseStatusReason.Count != 0))
      {
        writer.WritePropertyName("doseStatusReason");
        writer.WriteStartArray();

        foreach (CodeableConcept valDoseStatusReason in DoseStatusReason)
        {
          valDoseStatusReason.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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

      if (!string.IsNullOrEmpty(Series))
      {
        writer.WriteString("series", (string)Series!);
      }

      if (_Series != null)
      {
        writer.WritePropertyName("_series");
        _Series.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(DoseNumber))
      {
        writer.WriteString("doseNumber", (string)DoseNumber!);
      }

      if (_DoseNumber != null)
      {
        writer.WritePropertyName("_doseNumber");
        _DoseNumber.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SeriesDoses))
      {
        writer.WriteString("seriesDoses", (string)SeriesDoses!);
      }

      if (_SeriesDoses != null)
      {
        writer.WritePropertyName("_seriesDoses");
        _SeriesDoses.SerializeJson(writer, options);
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
        case "authority":
          Authority = new fhirCsR5.Models.Reference();
          Authority.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR5.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR5.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "doseNumber":
          DoseNumber = reader.GetString();
          break;

        case "_doseNumber":
          _DoseNumber = new fhirCsR5.Models.Element();
          _DoseNumber.DeserializeJson(ref reader, options);
          break;

        case "doseStatus":
          DoseStatus = new fhirCsR5.Models.CodeableConcept();
          DoseStatus.DeserializeJson(ref reader, options);
          break;

        case "doseStatusReason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DoseStatusReason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objDoseStatusReason = new fhirCsR5.Models.CodeableConcept();
            objDoseStatusReason.DeserializeJson(ref reader, options);
            DoseStatusReason.Add(objDoseStatusReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DoseStatusReason.Count == 0)
          {
            DoseStatusReason = null;
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
            fhirCsR5.Models.Identifier objIdentifier = new fhirCsR5.Models.Identifier();
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

        case "immunizationEvent":
          ImmunizationEvent = new fhirCsR5.Models.Reference();
          ImmunizationEvent.DeserializeJson(ref reader, options);
          break;

        case "patient":
          Patient = new fhirCsR5.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "series":
          Series = reader.GetString();
          break;

        case "_series":
          _Series = new fhirCsR5.Models.Element();
          _Series.DeserializeJson(ref reader, options);
          break;

        case "seriesDoses":
          SeriesDoses = reader.GetString();
          break;

        case "_seriesDoses":
          _SeriesDoses = new fhirCsR5.Models.Element();
          _SeriesDoses.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "targetDisease":
          TargetDisease = new fhirCsR5.Models.CodeableConcept();
          TargetDisease.DeserializeJson(ref reader, options);
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
  /// Code Values for the ImmunizationEvaluation.status field
  /// </summary>
  public static class ImmunizationEvaluationStatusCodes {
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "completed",
      "entered-in-error",
    };
  }
}
