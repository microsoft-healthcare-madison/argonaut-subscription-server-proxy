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
  /// A resource that represents the data of a single raw artifact as digital content accessible in its native format.  A Binary resource can contain any content, whether text, image, pdf, zip archive, etc.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<Binary>))]
  public class Binary : Resource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Binary";
    /// <summary>
    /// MimeType of the binary content represented as a standard MimeType (BCP 13).
    /// </summary>
    public string ContentType { get; set; }
    /// <summary>
    /// Extension container element for ContentType
    /// </summary>
    public Element _ContentType { get; set; }
    /// <summary>
    /// If the content type is itself base64 encoding, then this will be base64 encoded twice - what is created by un-base64ing the content must be the specified content type.
    /// </summary>
    public byte[] Data { get; set; }
    /// <summary>
    /// Very often, a server will also know of a resource that references the binary, and can automatically apply the appropriate access rules based on that reference. However, there are some circumstances where this is not appropriate, e.g. the binary is uploaded directly to the server without any linking resource, the binary is referred to from multiple different resources, and/or the binary is content such as an application logo that has less protection than any of the resources that reference it.
    /// </summary>
    public Reference SecurityContext { get; set; }
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


      ((fhirCsR5.Models.Resource)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(ContentType))
      {
        writer.WriteString("contentType", (string)ContentType!);
      }

      if (_ContentType != null)
      {
        writer.WritePropertyName("_contentType");
        _ContentType.SerializeJson(writer, options);
      }

      if (SecurityContext != null)
      {
        writer.WritePropertyName("securityContext");
        SecurityContext.SerializeJson(writer, options);
      }

      if (Data != null)
      {
        writer.WriteString("data", System.Convert.ToBase64String(Data));
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

        case "data":
          Data = System.Convert.FromBase64String(reader.GetString());
          break;

        case "securityContext":
          SecurityContext = new fhirCsR5.Models.Reference();
          SecurityContext.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.Resource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
