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
  /// Only list each attester once.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<DocumentReferenceAttester>))]
  public class DocumentReferenceAttester : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The type of attestation the authenticator offers.
    /// </summary>
    public string Mode { get; set; }
    /// <summary>
    /// Extension container element for Mode
    /// </summary>
    public Element _Mode { get; set; }
    /// <summary>
    /// Who attested the composition in the specified way.
    /// </summary>
    public Reference Party { get; set; }
    /// <summary>
    /// When the composition was attested by the party.
    /// </summary>
    public string Time { get; set; }
    /// <summary>
    /// Extension container element for Time
    /// </summary>
    public Element _Time { get; set; }
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

      if (!string.IsNullOrEmpty(Mode))
      {
        writer.WriteString("mode", (string)Mode!);
      }

      if (_Mode != null)
      {
        writer.WritePropertyName("_mode");
        _Mode.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Time))
      {
        writer.WriteString("time", (string)Time!);
      }

      if (_Time != null)
      {
        writer.WritePropertyName("_time");
        _Time.SerializeJson(writer, options);
      }

      if (Party != null)
      {
        writer.WritePropertyName("party");
        Party.SerializeJson(writer, options);
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
        case "mode":
          Mode = reader.GetString();
          break;

        case "_mode":
          _Mode = new fhirCsR5.Models.Element();
          _Mode.DeserializeJson(ref reader, options);
          break;

        case "party":
          Party = new fhirCsR5.Models.Reference();
          Party.DeserializeJson(ref reader, options);
          break;

        case "time":
          Time = reader.GetString();
          break;

        case "_time":
          _Time = new fhirCsR5.Models.Element();
          _Time.DeserializeJson(ref reader, options);
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
  /// Code Values for the DocumentReference.attester.mode field
  /// </summary>
  public static class DocumentReferenceAttesterModeCodes {
    public const string PERSONAL = "personal";
    public const string PROFESSIONAL = "professional";
    public const string LEGAL = "legal";
    public const string OFFICIAL = "official";
    public static HashSet<string> Values = new HashSet<string>() {
      "personal",
      "professional",
      "legal",
      "official",
    };
  }
  /// <summary>
  /// This element is labeled as a modifier because documents that append to other documents are incomplete on their own.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<DocumentReferenceRelatesTo>))]
  public class DocumentReferenceRelatesTo : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// If this document appends another document, then the document cannot be fully understood without also accessing the referenced document.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// The target document of this relationship.
    /// </summary>
    public Reference Target { get; set; }
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

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (Target != null)
      {
        writer.WritePropertyName("target");
        Target.SerializeJson(writer, options);
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
        case "code":
          Code = new fhirCsR5.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "target":
          Target = new fhirCsR5.Models.Reference();
          Target.DeserializeJson(ref reader, options);
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
  /// content element shall not contain different versions of the same content. For version handling use multiple DocumentReference with .relatesTo.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<DocumentReferenceContent>))]
  public class DocumentReferenceContent : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The document or URL of the document along with critical metadata to prove content has integrity.
    /// </summary>
    public Attachment Attachment { get; set; }
    /// <summary>
    /// Note that while IHE mostly issues URNs for format types, not all documents can be identified by a URI.
    /// </summary>
    public Coding Format { get; set; }
    /// <summary>
    /// CDA Document Id extension and root.
    /// </summary>
    public Identifier Identifier { get; set; }
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

      if (Attachment != null)
      {
        writer.WritePropertyName("attachment");
        Attachment.SerializeJson(writer, options);
      }

      if (Format != null)
      {
        writer.WritePropertyName("format");
        Format.SerializeJson(writer, options);
      }

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
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
        case "attachment":
          Attachment = new fhirCsR5.Models.Attachment();
          Attachment.DeserializeJson(ref reader, options);
          break;

        case "format":
          Format = new fhirCsR5.Models.Coding();
          Format.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new fhirCsR5.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
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
  /// A reference to a document of any kind for any purpose. While the term “document” implies a more narrow focus, for this resource this "document" encompasses *any* serialized object with a mime-type, it includes formal patient-centric documents (CDA), clinical notes, scanned paper, non-patient specific documents like policy text, as well as a photo, video, or audio recording acquired or used in healthcare.  The DocumentReference resource provides metadata about the document so that the document can be discovered and managed.  The actual content may be inline base64 encoded data or provided by direct reference.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<DocumentReference>))]
  public class DocumentReference : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "DocumentReference";
    /// <summary>
    /// Only list each attester once.
    /// </summary>
    public List<DocumentReferenceAttester> Attester { get; set; }
    /// <summary>
    /// Not necessarily who did the actual data entry (i.e. typist) or who was the source (informant).
    /// </summary>
    public List<Reference> Author { get; set; }
    /// <summary>
    /// A procedure that is fulfilled in whole or in part by the creation of this media.
    /// </summary>
    public List<Reference> BasedOn { get; set; }
    /// <summary>
    /// Key metadata element describing the the category or classification of the document. This is a broader perspective that groups similar documents based on how they would be used. This is a primary key used in searching.
    /// </summary>
    public List<CodeableConcept> Category { get; set; }
    /// <summary>
    /// content element shall not contain different versions of the same content. For version handling use multiple DocumentReference with .relatesTo.
    /// </summary>
    public List<DocumentReferenceContent> Content { get; set; }
    /// <summary>
    /// Identifies the logical organization (software system, vendor, or department) to go to find the current version, where to report issues, etc. This is different from the physical location (URL, disk drive, or server) of the document, which is the technical location of the document, which host may be delegated to the management of some other organization.
    /// </summary>
    public Reference Custodian { get; set; }
    /// <summary>
    /// Referencing/indexing time is used for tracking, organizing versions and searching.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// What the document is about,  a terse summary of the document.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// The document that is pointed to might be in various lifecycle states.
    /// </summary>
    public string DocStatus { get; set; }
    /// <summary>
    /// Extension container element for DocStatus
    /// </summary>
    public Element _DocStatus { get; set; }
    /// <summary>
    /// Describes the clinical encounter or type of care that the document content is associated with.
    /// </summary>
    public List<Reference> Encounter { get; set; }
    /// <summary>
    /// An event can further specialize the act inherent in the type, such as  where it is simply "Procedure Report" and the procedure was a "colonoscopy". If one or more event codes are included, they shall not conflict with the values inherent in the class or type elements as such a conflict would create an ambiguous situation.
    /// </summary>
    public List<CodeableConcept> Event { get; set; }
    /// <summary>
    /// The kind of facility where the patient was seen.
    /// </summary>
    public CodeableConcept FacilityType { get; set; }
    /// <summary>
    /// Other identifiers associated with the document, including version independent identifiers.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The time period over which the service that is described by the document was provided.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// This element should be based on a coarse classification system for the class of specialty practice. Recommend the use of the classification system for Practice Setting, such as that described by the Subject Matter Domain in LOINC.
    /// </summary>
    public CodeableConcept PracticeSetting { get; set; }
    /// <summary>
    /// May be identifiers or resources that caused the DocumentReference or referenced Document to be created.
    /// </summary>
    public List<Reference> Related { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because documents that append to other documents are incomplete on their own.
    /// </summary>
    public List<DocumentReferenceRelatesTo> RelatesTo { get; set; }
    /// <summary>
    /// The confidentiality codes can carry multiple vocabulary items. HL7 has developed an understanding of security and privacy tags that might be desirable in a Document Sharing environment, called HL7 Healthcare Privacy and Security Classification System (HCS). The following specification is recommended but not mandated, as the vocabulary bindings are an administrative domain responsibility. The use of this method is up to the policy domain such as the XDS Affinity Domain or other Trust Domain where all parties including sender and recipients are trusted to appropriately tag and enforce.   
    /// In the HL7 Healthcare Privacy and Security Classification (HCS) there are code systems specific to Confidentiality, Sensitivity, Integrity, and Handling Caveats. Some values would come from a local vocabulary as they are related to workflow roles and special projects.
    /// </summary>
    public List<CodeableConcept> SecurityLabel { get; set; }
    /// <summary>
    /// The Patient Information as known when the document was published. May be a reference to a version specific, or contained.
    /// </summary>
    public Reference SourcePatientInfo { get; set; }
    /// <summary>
    /// This is the status of the DocumentReference object, which might be independent from the docStatus element.
    /// This element is labeled as a modifier because the status contains the codes that mark the document or reference as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Who or what the document is about. The document can be about a person, (patient or healthcare practitioner), a device (e.g. a machine) or even a group of subjects (such as a document about a herd of farm animals, or a set of patients that share a common exposure).
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Key metadata element describing the document that describes he exact type of document. Helps humans to assess whether the document is of interest when viewing a list of documents.
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

      if (!string.IsNullOrEmpty(DocStatus))
      {
        writer.WriteString("docStatus", (string)DocStatus!);
      }

      if (_DocStatus != null)
      {
        writer.WritePropertyName("_docStatus");
        _DocStatus.SerializeJson(writer, options);
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
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

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if ((Encounter != null) && (Encounter.Count != 0))
      {
        writer.WritePropertyName("encounter");
        writer.WriteStartArray();

        foreach (Reference valEncounter in Encounter)
        {
          valEncounter.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Event != null) && (Event.Count != 0))
      {
        writer.WritePropertyName("event");
        writer.WriteStartArray();

        foreach (CodeableConcept valEvent in Event)
        {
          valEvent.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (FacilityType != null)
      {
        writer.WritePropertyName("facilityType");
        FacilityType.SerializeJson(writer, options);
      }

      if (PracticeSetting != null)
      {
        writer.WritePropertyName("practiceSetting");
        PracticeSetting.SerializeJson(writer, options);
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
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

      if ((Author != null) && (Author.Count != 0))
      {
        writer.WritePropertyName("author");
        writer.WriteStartArray();

        foreach (Reference valAuthor in Author)
        {
          valAuthor.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Attester != null) && (Attester.Count != 0))
      {
        writer.WritePropertyName("attester");
        writer.WriteStartArray();

        foreach (DocumentReferenceAttester valAttester in Attester)
        {
          valAttester.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Custodian != null)
      {
        writer.WritePropertyName("custodian");
        Custodian.SerializeJson(writer, options);
      }

      if ((RelatesTo != null) && (RelatesTo.Count != 0))
      {
        writer.WritePropertyName("relatesTo");
        writer.WriteStartArray();

        foreach (DocumentReferenceRelatesTo valRelatesTo in RelatesTo)
        {
          valRelatesTo.SerializeJson(writer, options, true);
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

      if ((SecurityLabel != null) && (SecurityLabel.Count != 0))
      {
        writer.WritePropertyName("securityLabel");
        writer.WriteStartArray();

        foreach (CodeableConcept valSecurityLabel in SecurityLabel)
        {
          valSecurityLabel.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Content != null) && (Content.Count != 0))
      {
        writer.WritePropertyName("content");
        writer.WriteStartArray();

        foreach (DocumentReferenceContent valContent in Content)
        {
          valContent.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (SourcePatientInfo != null)
      {
        writer.WritePropertyName("sourcePatientInfo");
        SourcePatientInfo.SerializeJson(writer, options);
      }

      if ((Related != null) && (Related.Count != 0))
      {
        writer.WritePropertyName("related");
        writer.WriteStartArray();

        foreach (Reference valRelated in Related)
        {
          valRelated.SerializeJson(writer, options, true);
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
        case "attester":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Attester = new List<DocumentReferenceAttester>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.DocumentReferenceAttester objAttester = new fhirCsR5.Models.DocumentReferenceAttester();
            objAttester.DeserializeJson(ref reader, options);
            Attester.Add(objAttester);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Attester.Count == 0)
          {
            Attester = null;
          }

          break;

        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Author = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objAuthor = new fhirCsR5.Models.Reference();
            objAuthor.DeserializeJson(ref reader, options);
            Author.Add(objAuthor);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Author.Count == 0)
          {
            Author = null;
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

        case "content":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Content = new List<DocumentReferenceContent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.DocumentReferenceContent objContent = new fhirCsR5.Models.DocumentReferenceContent();
            objContent.DeserializeJson(ref reader, options);
            Content.Add(objContent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Content.Count == 0)
          {
            Content = null;
          }

          break;

        case "custodian":
          Custodian = new fhirCsR5.Models.Reference();
          Custodian.DeserializeJson(ref reader, options);
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

        case "docStatus":
          DocStatus = reader.GetString();
          break;

        case "_docStatus":
          _DocStatus = new fhirCsR5.Models.Element();
          _DocStatus.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Encounter = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objEncounter = new fhirCsR5.Models.Reference();
            objEncounter.DeserializeJson(ref reader, options);
            Encounter.Add(objEncounter);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Encounter.Count == 0)
          {
            Encounter = null;
          }

          break;

        case "event":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Event = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objEvent = new fhirCsR5.Models.CodeableConcept();
            objEvent.DeserializeJson(ref reader, options);
            Event.Add(objEvent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Event.Count == 0)
          {
            Event = null;
          }

          break;

        case "facilityType":
          FacilityType = new fhirCsR5.Models.CodeableConcept();
          FacilityType.DeserializeJson(ref reader, options);
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

        case "period":
          Period = new fhirCsR5.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "practiceSetting":
          PracticeSetting = new fhirCsR5.Models.CodeableConcept();
          PracticeSetting.DeserializeJson(ref reader, options);
          break;

        case "related":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Related = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objRelated = new fhirCsR5.Models.Reference();
            objRelated.DeserializeJson(ref reader, options);
            Related.Add(objRelated);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Related.Count == 0)
          {
            Related = null;
          }

          break;

        case "relatesTo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          RelatesTo = new List<DocumentReferenceRelatesTo>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.DocumentReferenceRelatesTo objRelatesTo = new fhirCsR5.Models.DocumentReferenceRelatesTo();
            objRelatesTo.DeserializeJson(ref reader, options);
            RelatesTo.Add(objRelatesTo);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (RelatesTo.Count == 0)
          {
            RelatesTo = null;
          }

          break;

        case "securityLabel":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SecurityLabel = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objSecurityLabel = new fhirCsR5.Models.CodeableConcept();
            objSecurityLabel.DeserializeJson(ref reader, options);
            SecurityLabel.Add(objSecurityLabel);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SecurityLabel.Count == 0)
          {
            SecurityLabel = null;
          }

          break;

        case "sourcePatientInfo":
          SourcePatientInfo = new fhirCsR5.Models.Reference();
          SourcePatientInfo.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR5.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR5.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
  /// Code Values for the DocumentReference.docStatus field
  /// </summary>
  public static class DocumentReferenceDocStatusCodes {
    public const string PRELIMINARY = "preliminary";
    public const string FINAL = "final";
    public const string AMENDED = "amended";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string DEPRECATED = "deprecated";
    public static HashSet<string> Values = new HashSet<string>() {
      "preliminary",
      "final",
      "amended",
      "entered-in-error",
      "deprecated",
    };
  }
  /// <summary>
  /// Code Values for the DocumentReference.status field
  /// </summary>
  public static class DocumentReferenceStatusCodes {
    public const string CURRENT = "current";
    public const string SUPERSEDED = "superseded";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "current",
      "superseded",
      "entered-in-error",
    };
  }
}
