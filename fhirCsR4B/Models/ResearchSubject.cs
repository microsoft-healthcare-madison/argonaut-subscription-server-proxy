// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4B.Serialization;

namespace fhirCsR4B.Models
{
  /// <summary>
  /// A physical entity which is the primary unit of operational and/or administrative interest in a study.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<ResearchSubject>))]
  public class ResearchSubject : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "ResearchSubject";
    /// <summary>
    /// The name of the arm in the study the subject actually followed as part of this study.
    /// </summary>
    public string ActualArm { get; set; }
    /// <summary>
    /// Extension container element for ActualArm
    /// </summary>
    public Element _ActualArm { get; set; }
    /// <summary>
    /// The name of the arm in the study the subject is expected to follow as part of this study.
    /// </summary>
    public string AssignedArm { get; set; }
    /// <summary>
    /// Extension container element for AssignedArm
    /// </summary>
    public Element _AssignedArm { get; set; }
    /// <summary>
    /// A record of the patient's informed agreement to participate in the study.
    /// </summary>
    public Reference Consent { get; set; }
    /// <summary>
    /// Identifiers assigned to this research subject for a study.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The record of the person or animal who is involved in the study.
    /// </summary>
    public Reference Individual { get; set; }
    /// <summary>
    /// The dates the subject began and ended their participation in the study.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// The current state of the subject.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Reference to the study the subject is participating in.
    /// </summary>
    public Reference Study { get; set; }
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

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
      }

      if (Study != null)
      {
        writer.WritePropertyName("study");
        Study.SerializeJson(writer, options);
      }

      if (Individual != null)
      {
        writer.WritePropertyName("individual");
        Individual.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(AssignedArm))
      {
        writer.WriteString("assignedArm", (string)AssignedArm!);
      }

      if (_AssignedArm != null)
      {
        writer.WritePropertyName("_assignedArm");
        _AssignedArm.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ActualArm))
      {
        writer.WriteString("actualArm", (string)ActualArm!);
      }

      if (_ActualArm != null)
      {
        writer.WritePropertyName("_actualArm");
        _ActualArm.SerializeJson(writer, options);
      }

      if (Consent != null)
      {
        writer.WritePropertyName("consent");
        Consent.SerializeJson(writer, options);
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
        case "actualArm":
          ActualArm = reader.GetString();
          break;

        case "_actualArm":
          _ActualArm = new fhirCsR4B.Models.Element();
          _ActualArm.DeserializeJson(ref reader, options);
          break;

        case "assignedArm":
          AssignedArm = reader.GetString();
          break;

        case "_assignedArm":
          _AssignedArm = new fhirCsR4B.Models.Element();
          _AssignedArm.DeserializeJson(ref reader, options);
          break;

        case "consent":
          Consent = new fhirCsR4B.Models.Reference();
          Consent.DeserializeJson(ref reader, options);
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

        case "individual":
          Individual = new fhirCsR4B.Models.Reference();
          Individual.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new fhirCsR4B.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR4B.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "study":
          Study = new fhirCsR4B.Models.Reference();
          Study.DeserializeJson(ref reader, options);
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
  /// Code Values for the ResearchSubject.status field
  /// </summary>
  public static class ResearchSubjectStatusCodes {
    public const string CANDIDATE = "candidate";
    public const string ELIGIBLE = "eligible";
    public const string FOLLOW_UP = "follow-up";
    public const string INELIGIBLE = "ineligible";
    public const string NOT_REGISTERED = "not-registered";
    public const string OFF_STUDY = "off-study";
    public const string ON_STUDY = "on-study";
    public const string ON_STUDY_INTERVENTION = "on-study-intervention";
    public const string ON_STUDY_OBSERVATION = "on-study-observation";
    public const string PENDING_ON_STUDY = "pending-on-study";
    public const string POTENTIAL_CANDIDATE = "potential-candidate";
    public const string SCREENING = "screening";
    public const string WITHDRAWN = "withdrawn";
  }
}