// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// Text, attachment(s), or resource(s) that was communicated to the recipient.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<CommunicationPayload>))]
  public class CommunicationPayload : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The content can be codified or textual.  As an example of codified content, when working with machine generated communications, the payload may be drawn from a finite, terminology defined set of communications, especially for short, status update kinds of communications where more of a natural language approach isn't appropriate.
    /// If the content isn't codified, contentCodeableConcept.text can be used.  
    /// When using contentCodeableConcept, the CodeableConcept is what is being communicated and is not a categorization of the content.
    /// </summary>
    public Attachment ContentAttachment { get; set; }
    /// <summary>
    /// The content can be codified or textual.  As an example of codified content, when working with machine generated communications, the payload may be drawn from a finite, terminology defined set of communications, especially for short, status update kinds of communications where more of a natural language approach isn't appropriate.
    /// If the content isn't codified, contentCodeableConcept.text can be used.  
    /// When using contentCodeableConcept, the CodeableConcept is what is being communicated and is not a categorization of the content.
    /// </summary>
    public Reference ContentReference { get; set; }
    /// <summary>
    /// The content can be codified or textual.  As an example of codified content, when working with machine generated communications, the payload may be drawn from a finite, terminology defined set of communications, especially for short, status update kinds of communications where more of a natural language approach isn't appropriate.
    /// If the content isn't codified, contentCodeableConcept.text can be used.  
    /// When using contentCodeableConcept, the CodeableConcept is what is being communicated and is not a categorization of the content.
    /// </summary>
    public CodeableConcept ContentCodeableConcept { get; set; }
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

      if (ContentAttachment != null)
      {
        writer.WritePropertyName("contentAttachment");
        ContentAttachment.SerializeJson(writer, options);
      }

      if (ContentReference != null)
      {
        writer.WritePropertyName("contentReference");
        ContentReference.SerializeJson(writer, options);
      }

      if (ContentCodeableConcept != null)
      {
        writer.WritePropertyName("contentCodeableConcept");
        ContentCodeableConcept.SerializeJson(writer, options);
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
        case "contentAttachment":
          ContentAttachment = new fhirCsR5.Models.Attachment();
          ContentAttachment.DeserializeJson(ref reader, options);
          break;

        case "contentReference":
          ContentReference = new fhirCsR5.Models.Reference();
          ContentReference.DeserializeJson(ref reader, options);
          break;

        case "contentCodeableConcept":
          ContentCodeableConcept = new fhirCsR5.Models.CodeableConcept();
          ContentCodeableConcept.DeserializeJson(ref reader, options);
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
  /// A clinical or business level record of information being transmitted or shared; e.g. an alert that was sent to a responsible provider, a public health agency communication to a provider/reporter in response to a case report for a reportable condition.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<Communication>))]
  public class Communication : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Communication";
    /// <summary>
    /// Don't use Communication.about element when a more specific element exists, such as basedOn or reasonReference.
    /// </summary>
    public List<Reference> About { get; set; }
    /// <summary>
    /// This must point to some sort of a 'Request' resource, such as CarePlan, CommunicationRequest, ServiceRequest, MedicationRequest, etc.
    /// </summary>
    public List<Reference> BasedOn { get; set; }
    /// <summary>
    /// There may be multiple axes of categorization and one communication may serve multiple purposes.
    /// </summary>
    public List<CodeableConcept> Category { get; set; }
    /// <summary>
    /// This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Prior communication that this communication is in response to.
    /// </summary>
    public List<Reference> InResponseTo { get; set; }
    /// <summary>
    /// The URL pointing to a FHIR-defined protocol, guideline, orderset or other definition that is adhered to in whole or in part by this Communication.
    /// </summary>
    public List<string> InstantiatesCanonical { get; set; }
    /// <summary>
    /// Extension container element for InstantiatesCanonical
    /// </summary>
    public List<Element> _InstantiatesCanonical { get; set; }
    /// <summary>
    /// This might be an HTML page, PDF, etc. or could just be a non-resolvable URI identifier.
    /// </summary>
    public List<string> InstantiatesUri { get; set; }
    /// <summary>
    /// Extension container element for InstantiatesUri
    /// </summary>
    public List<Element> _InstantiatesUri { get; set; }
    /// <summary>
    /// A channel that was used for this communication (e.g. email, fax).
    /// </summary>
    public List<CodeableConcept> Medium { get; set; }
    /// <summary>
    /// Additional notes or commentary about the communication by the sender, receiver or other interested parties.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// The event the communication was part of - e.g. if you disclosed as "part" of counselling, it would be partOf that Procedure.
    /// </summary>
    public List<Reference> PartOf { get; set; }
    /// <summary>
    /// Text, attachment(s), or resource(s) that was communicated to the recipient.
    /// </summary>
    public List<CommunicationPayload> Payload { get; set; }
    /// <summary>
    /// Used to prioritize workflow (such as which communication to read first) when the communication is planned or in progress.
    /// </summary>
    public string Priority { get; set; }
    /// <summary>
    /// Extension container element for Priority
    /// </summary>
    public Element _Priority { get; set; }
    /// <summary>
    /// Textual reasons can be captured using reason.concept.text.
    /// </summary>
    public List<CodeableReference> Reason { get; set; }
    /// <summary>
    /// The time when this communication arrived at the destination.
    /// </summary>
    public string Received { get; set; }
    /// <summary>
    /// Extension container element for Received
    /// </summary>
    public Element _Received { get; set; }
    /// <summary>
    /// If receipts need to be tracked by an individual, a separate resource instance will need to be created for each recipient.  Multiple recipient communications are intended where either receipts are not tracked (e.g. a mass mail-out) or a receipt is captured in aggregate (all emails confirmed received by a particular time).
    /// </summary>
    public List<Reference> Recipient { get; set; }
    /// <summary>
    /// The entity (e.g. person, organization, clinical information system, or device) which is the source of the communication.
    /// </summary>
    public Reference Sender { get; set; }
    /// <summary>
    /// The time when this communication was sent.
    /// </summary>
    public string Sent { get; set; }
    /// <summary>
    /// Extension container element for Sent
    /// </summary>
    public Element _Sent { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains the codes aborted and entered-in-error that mark the communication as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// This is generally only used for "exception" statuses such as "not-done", "suspended" or "aborted". The reason for performing the event at all is captured in reasonCode, not here.
    /// </summary>
    public CodeableConcept StatusReason { get; set; }
    /// <summary>
    /// The patient or group that was the focus of this communication.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Communication.topic.text can be used without any codings.
    /// </summary>
    public CodeableConcept Topic { get; set; }
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

      if ((InstantiatesCanonical != null) && (InstantiatesCanonical.Count != 0))
      {
        writer.WritePropertyName("instantiatesCanonical");
        writer.WriteStartArray();

        foreach (string valInstantiatesCanonical in InstantiatesCanonical)
        {
          writer.WriteStringValue(valInstantiatesCanonical);
        }

        writer.WriteEndArray();
      }

      if ((_InstantiatesCanonical != null) && (_InstantiatesCanonical.Count != 0))
      {
        writer.WritePropertyName("_instantiatesCanonical");
        writer.WriteStartArray();

        foreach (Element val_InstantiatesCanonical in _InstantiatesCanonical)
        {
          val_InstantiatesCanonical.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((InstantiatesUri != null) && (InstantiatesUri.Count != 0))
      {
        writer.WritePropertyName("instantiatesUri");
        writer.WriteStartArray();

        foreach (string valInstantiatesUri in InstantiatesUri)
        {
          writer.WriteStringValue(valInstantiatesUri);
        }

        writer.WriteEndArray();
      }

      if ((_InstantiatesUri != null) && (_InstantiatesUri.Count != 0))
      {
        writer.WritePropertyName("_instantiatesUri");
        writer.WriteStartArray();

        foreach (Element val_InstantiatesUri in _InstantiatesUri)
        {
          val_InstantiatesUri.SerializeJson(writer, options, true);
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

      if ((PartOf != null) && (PartOf.Count != 0))
      {
        writer.WritePropertyName("partOf");
        writer.WriteStartArray();

        foreach (Reference valPartOf in PartOf)
        {
          valPartOf.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((InResponseTo != null) && (InResponseTo.Count != 0))
      {
        writer.WritePropertyName("inResponseTo");
        writer.WriteStartArray();

        foreach (Reference valInResponseTo in InResponseTo)
        {
          valInResponseTo.SerializeJson(writer, options, true);
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

      if (StatusReason != null)
      {
        writer.WritePropertyName("statusReason");
        StatusReason.SerializeJson(writer, options);
      }

      if ((Category != null) && (Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();

        foreach (CodeableConcept valCategory in Category)
        {
          valCategory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Priority))
      {
        writer.WriteString("priority", (string)Priority!);
      }

      if (_Priority != null)
      {
        writer.WritePropertyName("_priority");
        _Priority.SerializeJson(writer, options);
      }

      if ((Medium != null) && (Medium.Count != 0))
      {
        writer.WritePropertyName("medium");
        writer.WriteStartArray();

        foreach (CodeableConcept valMedium in Medium)
        {
          valMedium.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Topic != null)
      {
        writer.WritePropertyName("topic");
        Topic.SerializeJson(writer, options);
      }

      if ((About != null) && (About.Count != 0))
      {
        writer.WritePropertyName("about");
        writer.WriteStartArray();

        foreach (Reference valAbout in About)
        {
          valAbout.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Sent))
      {
        writer.WriteString("sent", (string)Sent!);
      }

      if (_Sent != null)
      {
        writer.WritePropertyName("_sent");
        _Sent.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Received))
      {
        writer.WriteString("received", (string)Received!);
      }

      if (_Received != null)
      {
        writer.WritePropertyName("_received");
        _Received.SerializeJson(writer, options);
      }

      if ((Recipient != null) && (Recipient.Count != 0))
      {
        writer.WritePropertyName("recipient");
        writer.WriteStartArray();

        foreach (Reference valRecipient in Recipient)
        {
          valRecipient.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Sender != null)
      {
        writer.WritePropertyName("sender");
        Sender.SerializeJson(writer, options);
      }

      if ((Reason != null) && (Reason.Count != 0))
      {
        writer.WritePropertyName("reason");
        writer.WriteStartArray();

        foreach (CodeableReference valReason in Reason)
        {
          valReason.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Payload != null) && (Payload.Count != 0))
      {
        writer.WritePropertyName("payload");
        writer.WriteStartArray();

        foreach (CommunicationPayload valPayload in Payload)
        {
          valPayload.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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
        case "about":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          About = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objAbout = new fhirCsR5.Models.Reference();
            objAbout.DeserializeJson(ref reader, options);
            About.Add(objAbout);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (About.Count == 0)
          {
            About = null;
          }

          break;

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BasedOn = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objBasedOn = new fhirCsR5.Models.Reference();
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

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objCategory = new fhirCsR5.Models.CodeableConcept();
            objCategory.DeserializeJson(ref reader, options);
            Category.Add(objCategory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Category.Count == 0)
          {
            Category = null;
          }

          break;

        case "encounter":
          Encounter = new fhirCsR5.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
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

        case "inResponseTo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          InResponseTo = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objInResponseTo = new fhirCsR5.Models.Reference();
            objInResponseTo.DeserializeJson(ref reader, options);
            InResponseTo.Add(objInResponseTo);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (InResponseTo.Count == 0)
          {
            InResponseTo = null;
          }

          break;

        case "instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          InstantiatesCanonical = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            InstantiatesCanonical.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (InstantiatesCanonical.Count == 0)
          {
            InstantiatesCanonical = null;
          }

          break;

        case "_instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _InstantiatesCanonical = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_InstantiatesCanonical = new fhirCsR5.Models.Element();
            obj_InstantiatesCanonical.DeserializeJson(ref reader, options);
            _InstantiatesCanonical.Add(obj_InstantiatesCanonical);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_InstantiatesCanonical.Count == 0)
          {
            _InstantiatesCanonical = null;
          }

          break;

        case "instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          InstantiatesUri = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            InstantiatesUri.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (InstantiatesUri.Count == 0)
          {
            InstantiatesUri = null;
          }

          break;

        case "_instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _InstantiatesUri = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_InstantiatesUri = new fhirCsR5.Models.Element();
            obj_InstantiatesUri.DeserializeJson(ref reader, options);
            _InstantiatesUri.Add(obj_InstantiatesUri);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_InstantiatesUri.Count == 0)
          {
            _InstantiatesUri = null;
          }

          break;

        case "medium":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Medium = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objMedium = new fhirCsR5.Models.CodeableConcept();
            objMedium.DeserializeJson(ref reader, options);
            Medium.Add(objMedium);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Medium.Count == 0)
          {
            Medium = null;
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
            fhirCsR5.Models.Annotation objNote = new fhirCsR5.Models.Annotation();
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

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PartOf = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objPartOf = new fhirCsR5.Models.Reference();
            objPartOf.DeserializeJson(ref reader, options);
            PartOf.Add(objPartOf);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PartOf.Count == 0)
          {
            PartOf = null;
          }

          break;

        case "payload":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Payload = new List<CommunicationPayload>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CommunicationPayload objPayload = new fhirCsR5.Models.CommunicationPayload();
            objPayload.DeserializeJson(ref reader, options);
            Payload.Add(objPayload);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Payload.Count == 0)
          {
            Payload = null;
          }

          break;

        case "priority":
          Priority = reader.GetString();
          break;

        case "_priority":
          _Priority = new fhirCsR5.Models.Element();
          _Priority.DeserializeJson(ref reader, options);
          break;

        case "reason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reason = new List<CodeableReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableReference objReason = new fhirCsR5.Models.CodeableReference();
            objReason.DeserializeJson(ref reader, options);
            Reason.Add(objReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reason.Count == 0)
          {
            Reason = null;
          }

          break;

        case "received":
          Received = reader.GetString();
          break;

        case "_received":
          _Received = new fhirCsR5.Models.Element();
          _Received.DeserializeJson(ref reader, options);
          break;

        case "recipient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Recipient = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objRecipient = new fhirCsR5.Models.Reference();
            objRecipient.DeserializeJson(ref reader, options);
            Recipient.Add(objRecipient);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Recipient.Count == 0)
          {
            Recipient = null;
          }

          break;

        case "sender":
          Sender = new fhirCsR5.Models.Reference();
          Sender.DeserializeJson(ref reader, options);
          break;

        case "sent":
          Sent = reader.GetString();
          break;

        case "_sent":
          _Sent = new fhirCsR5.Models.Element();
          _Sent.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "statusReason":
          StatusReason = new fhirCsR5.Models.CodeableConcept();
          StatusReason.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR5.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "topic":
          Topic = new fhirCsR5.Models.CodeableConcept();
          Topic.DeserializeJson(ref reader, options);
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
  /// Code Values for the Communication.priority field
  /// </summary>
  public static class CommunicationPriorityCodes {
    public const string ROUTINE = "routine";
    public const string URGENT = "urgent";
    public const string ASAP = "asap";
    public const string STAT = "stat";
  }
  /// <summary>
  /// Code Values for the Communication.status field
  /// </summary>
  public static class CommunicationStatusCodes {
    public const string PREPARATION = "preparation";
    public const string IN_PROGRESS = "in-progress";
    public const string NOT_DONE = "not-done";
    public const string ON_HOLD = "on-hold";
    public const string STOPPED = "stopped";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string UNKNOWN = "unknown";
  }
}
