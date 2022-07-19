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
  /// An amount of economic utility in some recognized currency.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<Money>))]
  public class Money : Element,  IFhirJsonSerializable {
    /// <summary>
    /// ISO 4217 Currency Code.
    /// </summary>
    public string Currency { get; set; }
    /// <summary>
    /// Extension container element for Currency
    /// </summary>
    public Element _Currency { get; set; }
    /// <summary>
    /// Monetary values have their own rules for handling precision (refer to standard accounting text books).
    /// </summary>
    public decimal? Value { get; set; }
    /// <summary>
    /// Extension container element for Value
    /// </summary>
    public Element _Value { get; set; }
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

      if (Value != null)
      {
        writer.WriteNumber("value", (decimal)Value!);
      }

      if (_Value != null)
      {
        writer.WritePropertyName("_value");
        _Value.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Currency))
      {
        writer.WriteString("currency", (string)Currency!);
      }

      if (_Currency != null)
      {
        writer.WritePropertyName("_currency");
        _Currency.SerializeJson(writer, options);
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
        case "currency":
          Currency = reader.GetString();
          break;

        case "_currency":
          _Currency = new fhirCsR4B.Models.Element();
          _Currency.DeserializeJson(ref reader, options);
          break;

        case "value":
          Value = reader.GetDecimal();
          break;

        case "_value":
          _Value = new fhirCsR4B.Models.Element();
          _Value.DeserializeJson(ref reader, options);
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
