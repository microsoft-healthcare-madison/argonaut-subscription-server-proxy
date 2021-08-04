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
  /// For referring to data content defined in other formats.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<Attachment>))]
  public class Attachment : DataType,  IFhirJsonSerializable {
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
    /// The duration might differ from occurrencePeriod if recording was paused.
    /// </summary>
    public decimal? Duration { get; set; }
    /// <summary>
    /// Extension container element for Duration
    /// </summary>
    public Element _Duration { get; set; }
    /// <summary>
    /// if the number of frames is not supplied, the value may be unknown. Applications should not assume that there is only one frame unless it is explicitly stated.
    /// </summary>
    public uint? Frames { get; set; }
    /// <summary>
    /// The hash is calculated on the data prior to base64 encoding, if the data is based64 encoded. The hash is not intended to support digital signatures. Where protection against malicious threats a digital signature should be considered, see [Provenance.signature](provenance-definitions.html#Provenance.signature) for mechanism to protect a resource with a digital signature.
    /// </summary>
    public byte[] Hash { get; set; }
    /// <summary>
    /// Height of the image in pixels (photo/video).
    /// </summary>
    public uint? Height { get; set; }
    /// <summary>
    /// The human language of the content. The value can be any valid value according to BCP 47.
    /// </summary>
    public string Language { get; set; }
    /// <summary>
    /// Extension container element for Language
    /// </summary>
    public Element _Language { get; set; }
    /// <summary>
    /// The number of pages when printed.
    /// </summary>
    public uint? Pages { get; set; }
    /// <summary>
    /// The number of bytes is redundant if the data is provided as a base64binary, but is useful if the data is provided as a url reference.
    /// </summary>
    public long? Size { get; set; }
    /// <summary>
    /// May sometimes be derived from the source filename.
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
    /// Width of the image in pixels (photo/video).
    /// </summary>
    public uint? Width { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.DataType)this).SerializeJson(writer, options, false);

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
        writer.WriteString("size", Size.ToString());
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

      if (Height != null)
      {
        writer.WriteNumber("height", (uint)Height!);
      }

      if (Width != null)
      {
        writer.WriteNumber("width", (uint)Width!);
      }

      if (Frames != null)
      {
        writer.WriteNumber("frames", (uint)Frames!);
      }

      if (Duration != null)
      {
        writer.WriteNumber("duration", (decimal)Duration!);
      }

      if (_Duration != null)
      {
        writer.WritePropertyName("_duration");
        _Duration.SerializeJson(writer, options);
      }

      if (Pages != null)
      {
        writer.WriteNumber("pages", (uint)Pages!);
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
          _ContentType = new fhirCsR5.Models.Element();
          _ContentType.DeserializeJson(ref reader, options);
          break;

        case "creation":
          Creation = reader.GetString();
          break;

        case "_creation":
          _Creation = new fhirCsR5.Models.Element();
          _Creation.DeserializeJson(ref reader, options);
          break;

        case "data":
          Data = System.Convert.FromBase64String(reader.GetString());
          break;

        case "duration":
          Duration = reader.GetDecimal();
          break;

        case "_duration":
          _Duration = new fhirCsR5.Models.Element();
          _Duration.DeserializeJson(ref reader, options);
          break;

        case "frames":
          Frames = reader.GetUInt32();
          break;

        case "hash":
          Hash = System.Convert.FromBase64String(reader.GetString());
          break;

        case "height":
          Height = reader.GetUInt32();
          break;

        case "language":
          Language = reader.GetString();
          break;

        case "_language":
          _Language = new fhirCsR5.Models.Element();
          _Language.DeserializeJson(ref reader, options);
          break;

        case "pages":
          Pages = reader.GetUInt32();
          break;

        case "size":
          string strValSize = reader.GetString();
          if (long.TryParse(strValSize, out long longValSize))
          {
            Size = longValSize;
          }

          break;

        case "title":
          Title = reader.GetString();
          break;

        case "_title":
          _Title = new fhirCsR5.Models.Element();
          _Title.DeserializeJson(ref reader, options);
          break;

        case "url":
          Url = reader.GetString();
          break;

        case "_url":
          _Url = new fhirCsR5.Models.Element();
          _Url.DeserializeJson(ref reader, options);
          break;

        case "width":
          Width = reader.GetUInt32();
          break;

        default:
          ((fhirCsR5.Models.DataType)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
