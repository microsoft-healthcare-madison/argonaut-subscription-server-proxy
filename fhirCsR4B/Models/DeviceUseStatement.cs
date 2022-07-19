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
  /// A record of a device being used by a patient where the record is the result of a report from the patient or another clinician.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<DeviceUseStatement>))]
  public class DeviceUseStatement : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "DeviceUseStatement";
    /// <summary>
    /// A plan, proposal or order that is fulfilled in whole or in part by this DeviceUseStatement.
    /// </summary>
    public List<Reference> BasedOn { get; set; }
    /// <summary>
    /// Indicates the anotomic location on the subject's body where the device was used ( i.e. the target).
    /// </summary>
    public CodeableConcept BodySite { get; set; }
    /// <summary>
    /// The most common use cases for deriving a DeviceUseStatement comes from creating it from a request or from an observation or a claim. it should be noted that the amount of information that is available varies from the type resource that you derive the DeviceUseStatement from.
    /// </summary>
    public List<Reference> DerivedFrom { get; set; }
    /// <summary>
    /// The details of the device used.
    /// </summary>
    public Reference Device { get; set; }
    /// <summary>
    /// An external identifier for this statement such as an IRI.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Details about the device statement that were not represented at all or sufficiently in one of the attributes provided in a class. These may include for example a comment, an instruction, or a note associated with the statement.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Reason or justification for the use of the device.
    /// </summary>
    public List<CodeableConcept> ReasonCode { get; set; }
    /// <summary>
    /// Indicates another resource whose existence justifies this DeviceUseStatement.
    /// </summary>
    public List<Reference> ReasonReference { get; set; }
    /// <summary>
    /// The time at which the statement was made/recorded.
    /// </summary>
    public string RecordedOn { get; set; }
    /// <summary>
    /// Extension container element for RecordedOn
    /// </summary>
    public Element _RecordedOn { get; set; }
    /// <summary>
    /// Who reported the device was being used by the patient.
    /// </summary>
    public Reference Source { get; set; }
    /// <summary>
    /// DeviceUseStatment is a statement at a point in time.  The status is only representative at the point when it was asserted.  The value set for contains codes that assert the status of the use  by the patient (for example, stopped or on hold) as well as codes that assert the status of the resource itself (for example, entered in error).
    /// This element is labeled as a modifier because the status contains the codes that mark the statement as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The patient who used the device.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// How often the device was used.
    /// </summary>
    public Timing TimingTiming { get; set; }
    /// <summary>
    /// How often the device was used.
    /// </summary>
    public Period TimingPeriod { get; set; }
    /// <summary>
    /// How often the device was used.
    /// </summary>
    public string TimingDateTime { get; set; }
    /// <summary>
    /// Extension container element for TimingDateTime
    /// </summary>
    public Element _TimingDateTime { get; set; }
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

      if ((BasedOn != null) && (BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();

        foreach (Reference valBasedOn in BasedOn)
        {
          valBasedOn.SerializeJson(writer, options, true);
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

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if ((DerivedFrom != null) && (DerivedFrom.Count != 0))
      {
        writer.WritePropertyName("derivedFrom");
        writer.WriteStartArray();

        foreach (Reference valDerivedFrom in DerivedFrom)
        {
          valDerivedFrom.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (TimingTiming != null)
      {
        writer.WritePropertyName("timingTiming");
        TimingTiming.SerializeJson(writer, options);
      }

      if (TimingPeriod != null)
      {
        writer.WritePropertyName("timingPeriod");
        TimingPeriod.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(TimingDateTime))
      {
        writer.WriteString("timingDateTime", (string)TimingDateTime!);
      }

      if (_TimingDateTime != null)
      {
        writer.WritePropertyName("_timingDateTime");
        _TimingDateTime.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(RecordedOn))
      {
        writer.WriteString("recordedOn", (string)RecordedOn!);
      }

      if (_RecordedOn != null)
      {
        writer.WritePropertyName("_recordedOn");
        _RecordedOn.SerializeJson(writer, options);
      }

      if (Source != null)
      {
        writer.WritePropertyName("source");
        Source.SerializeJson(writer, options);
      }

      if (Device != null)
      {
        writer.WritePropertyName("device");
        Device.SerializeJson(writer, options);
      }

      if ((ReasonCode != null) && (ReasonCode.Count != 0))
      {
        writer.WritePropertyName("reasonCode");
        writer.WriteStartArray();

        foreach (CodeableConcept valReasonCode in ReasonCode)
        {
          valReasonCode.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ReasonReference != null) && (ReasonReference.Count != 0))
      {
        writer.WritePropertyName("reasonReference");
        writer.WriteStartArray();

        foreach (Reference valReasonReference in ReasonReference)
        {
          valReasonReference.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (BodySite != null)
      {
        writer.WritePropertyName("bodySite");
        BodySite.SerializeJson(writer, options);
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (Annotation valNote in Note)
        {
          valNote.SerializeJson(writer, options, true);
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
        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BasedOn = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.Reference objBasedOn = new fhirCsR4B.Models.Reference();
            objBasedOn.DeserializeJson(ref reader, options);
            BasedOn.Add(objBasedOn);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (BasedOn.Count == 0)
          {
            BasedOn = null;
          }

          break;

        case "bodySite":
          BodySite = new fhirCsR4B.Models.CodeableConcept();
          BodySite.DeserializeJson(ref reader, options);
          break;

        case "derivedFrom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DerivedFrom = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.Reference objDerivedFrom = new fhirCsR4B.Models.Reference();
            objDerivedFrom.DeserializeJson(ref reader, options);
            DerivedFrom.Add(objDerivedFrom);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DerivedFrom.Count == 0)
          {
            DerivedFrom = null;
          }

          break;

        case "device":
          Device = new fhirCsR4B.Models.Reference();
          Device.DeserializeJson(ref reader, options);
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

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.Annotation objNote = new fhirCsR4B.Models.Annotation();
            objNote.DeserializeJson(ref reader, options);
            Note.Add(objNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Note.Count == 0)
          {
            Note = null;
          }

          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.CodeableConcept objReasonCode = new fhirCsR4B.Models.CodeableConcept();
            objReasonCode.DeserializeJson(ref reader, options);
            ReasonCode.Add(objReasonCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonCode.Count == 0)
          {
            ReasonCode = null;
          }

          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonReference = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.Reference objReasonReference = new fhirCsR4B.Models.Reference();
            objReasonReference.DeserializeJson(ref reader, options);
            ReasonReference.Add(objReasonReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonReference.Count == 0)
          {
            ReasonReference = null;
          }

          break;

        case "recordedOn":
          RecordedOn = reader.GetString();
          break;

        case "_recordedOn":
          _RecordedOn = new fhirCsR4B.Models.Element();
          _RecordedOn.DeserializeJson(ref reader, options);
          break;

        case "source":
          Source = new fhirCsR4B.Models.Reference();
          Source.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR4B.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR4B.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "timingTiming":
          TimingTiming = new fhirCsR4B.Models.Timing();
          TimingTiming.DeserializeJson(ref reader, options);
          break;

        case "timingPeriod":
          TimingPeriod = new fhirCsR4B.Models.Period();
          TimingPeriod.DeserializeJson(ref reader, options);
          break;

        case "timingDateTime":
          TimingDateTime = reader.GetString();
          break;

        case "_timingDateTime":
          _TimingDateTime = new fhirCsR4B.Models.Element();
          _TimingDateTime.DeserializeJson(ref reader, options);
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
  /// Code Values for the DeviceUseStatement.status field
  /// </summary>
  public static class DeviceUseStatementStatusCodes {
    public const string ACTIVE = "active";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string INTENDED = "intended";
    public const string STOPPED = "stopped";
    public const string ON_HOLD = "on-hold";
    public static HashSet<string> Values = new HashSet<string>() {
      "active",
      "completed",
      "entered-in-error",
      "intended",
      "stopped",
      "on-hold",
    };
  }
}
