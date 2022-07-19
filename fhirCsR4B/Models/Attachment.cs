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
  /// For referring to data content defined in other formats.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<Attachment>))]
  public class Attachment : Element,  IFhirJsonSerializable {
    /// <summary>
    /// Identifies the type of the data in the attachment and allows a method to be chosen to interpret or render the data. Includes mime type parameters such as charset where appropriate.
    /// </summary>
    public string ContentType { get; set; }
    /// <summary>
    /// Extension container element for ContentType
    /// </summary>
    public Element _ContentType { get; set; }
    /// <summary>
    /// The date that the attachment was first created.
    /// </summary>
    public string Creation { get; set; }
    /// <summary>
    /// Extension container element for Creation
    /// </summary>
    public Element _Creation { get; set; }
    /// <summary>
    /// The base64-encoded data SHALL be expressed in the same character set as the base resource XML or JSON.
    /// </summary>
    public byte[] Data { get; set; }
    /// <summary>
    /// The hash is calculated on the data prior to base64 encoding, if the data is based64 encoded. The hash is not intended to support digital signatures. Where protection against malicious threats a digital signature should be considered, see [Provenance.signature](provenance-definitions.html#Provenance.signature) for mechanism to protect a resource with a digital signature.
    /// </summary>
    public byte[] Hash { get; set; }
    /// <summary>
    /// The human language of the content. The value can be any valid value according to BCP 47.
    /// </summary>
    public string Language { get; set; }
    /// <summary>
    /// Extension container element for Language
    /// </summary>
    public Element _Language { get; set; }
    /// <summary>
    /// The number of bytes is redundant if the data is provided as a base64binary, but is useful if the data is provided as a url reference.
    /// </summary>
    public uint? Size { get; set; }
    /// <summary>
    /// A label or set of text to display in place of the data.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Extension container element for Title
    /// </summary>
    public Element _Title { get; set; }
    /// <summary>
    /// If both data and url are provided, the url SHALL point to the same content as the data contains. Urls may be relative references or may reference transient locations such as a wrapping envelope using cid: though this has ramifications for using signatures. Relative URLs are interpreted relative to the service url, like a resource reference, rather than relative to the resource itself. If a URL is provided, it SHALL resolve to actual data.
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    /// Extension container element for Url
    /// </summary>
    public Element _Url { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4B.Models.Element)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(ContentType))
      {
        writer.WriteString("contentType", (string)ContentType!);
      }

      if (_ContentType != null)
      {
        writer.WritePropertyName("_contentType");
        _ContentType.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Language))
      {
        writer.WriteString("language", (string)Language!);
      }

      if (_Language != null)
      {
        writer.WritePropertyName("_language");
        _Language.SerializeJson(writer, options);
      }

      if (Data != null)
      {
        writer.WriteString("data", System.Convert.ToBase64String(Data));
      }

      if (!string.IsNullOrEmpty(Url))
      {
        writer.WriteString("url", (string)Url!);
      }

      if (_Url != null)
      {
        writer.WritePropertyName("_url");
        _Url.SerializeJson(writer, options);
      }

      if (Size != null)
      {
        writer.WriteNumber("size", (uint)Size!);
      }

      if (Hash != null)
      {
        writer.WriteString("hash", System.Convert.ToBase64String(Hash));
      }

      if (!string.IsNullOrEmpty(Title))
      {
        writer.WriteString("title", (string)Title!);
      }

      if (_Title != null)
      {
        writer.WritePropertyName("_title");
        _Title.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Creation))
      {
        writer.WriteString("creation", (string)Creation!);
      }

      if (_Creation != null)
      {
        writer.WritePropertyName("_creation");
        _Creation.SerializeJson(writer, options);
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
        case "contentType":
          ContentType = reader.GetString();
          break;

        case "_contentType":
          _ContentType = new fhirCsR4B.Models.Element();
          _ContentType.DeserializeJson(ref reader, options);
          break;

        case "creation":
          Creation = reader.GetString();
          break;

        case "_creation":
          _Creation = new fhirCsR4B.Models.Element();
          _Creation.DeserializeJson(ref reader, options);
          break;

        case "data":
          Data = System.Convert.FromBase64String(reader.GetString());
          break;

        case "hash":
          Hash = System.Convert.FromBase64String(reader.GetString());
          break;

        case "language":
          Language = reader.GetString();
          break;

        case "_language":
          _Language = new fhirCsR4B.Models.Element();
          _Language.DeserializeJson(ref reader, options);
          break;

        case "size":
          Size = reader.GetUInt32();
          break;

        case "title":
          Title = reader.GetString();
          break;

        case "_title":
          _Title = new fhirCsR4B.Models.Element();
          _Title.DeserializeJson(ref reader, options);
          break;

        case "url":
          Url = reader.GetString();
          break;

        case "_url":
          _Url = new fhirCsR4B.Models.Element();
          _Url.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4B.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
}
