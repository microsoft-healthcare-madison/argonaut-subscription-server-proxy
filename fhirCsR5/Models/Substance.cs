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
  /// A substance can be composed of other substances.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SubstanceIngredient>))]
  public class SubstanceIngredient : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The amount of the ingredient in the substance - a concentration ratio.
    /// </summary>
    public Ratio Quantity { get; set; }
    /// <summary>
    /// Another substance that is a component of this substance.
    /// </summary>
    public CodeableConcept SubstanceCodeableConcept { get; set; }
    /// <summary>
    /// Another substance that is a component of this substance.
    /// </summary>
    public Reference SubstanceReference { get; set; }
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

      if (Quantity != null)
      {
        writer.WritePropertyName("quantity");
        Quantity.SerializeJson(writer, options);
      }

      if (SubstanceCodeableConcept != null)
      {
        writer.WritePropertyName("substanceCodeableConcept");
        SubstanceCodeableConcept.SerializeJson(writer, options);
      }

      if (SubstanceReference != null)
      {
        writer.WritePropertyName("substanceReference");
        SubstanceReference.SerializeJson(writer, options);
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
        case "quantity":
          Quantity = new fhirCsR5.Models.Ratio();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "substanceCodeableConcept":
          SubstanceCodeableConcept = new fhirCsR5.Models.CodeableConcept();
          SubstanceCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "substanceReference":
          SubstanceReference = new fhirCsR5.Models.Reference();
          SubstanceReference.DeserializeJson(ref reader, options);
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
  /// A homogeneous material with a definite composition.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<Substance>))]
  public class Substance : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Substance";
    /// <summary>
    /// The level of granularity is defined by the category concepts in the value set.   More fine-grained filtering can be performed using the metadata and/or terminology hierarchy in Substance.code.
    /// </summary>
    public List<CodeableConcept> Category { get; set; }
    /// <summary>
    /// This could be a reference to an externally defined code.  It could also be a locally assigned code (e.g. a formulary),  optionally with translations to the standard drug codes.
    /// </summary>
    public CodeableReference Code { get; set; }
    /// <summary>
    /// A description of the substance - its appearance, handling requirements, and other usage notes.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// When the substance is no longer valid to use. For some substances, a single arbitrary date is used for expiry.
    /// </summary>
    public string Expiry { get; set; }
    /// <summary>
    /// Extension container element for Expiry
    /// </summary>
    public Element _Expiry { get; set; }
    /// <summary>
    /// This identifier is associated with the kind of substance in contrast to the  Substance.instance.identifier which is associated with the package/container.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// A substance can be composed of other substances.
    /// </summary>
    public List<SubstanceIngredient> Ingredient { get; set; }
    /// <summary>
    /// A boolean to indicate if this an instance of a substance or a kind of one (a definition).
    /// </summary>
    public bool Instance { get; set; }
    /// <summary>
    /// Extension container element for Instance
    /// </summary>
    public Element _Instance { get; set; }
    /// <summary>
    /// The amount of the substance.
    /// </summary>
    public Quantity Quantity { get; set; }
    /// <summary>
    /// A code to indicate if the substance is actively used.
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

      writer.WriteBoolean("instance", Instance);

      if (_Instance != null)
      {
        writer.WritePropertyName("_instance");
        _Instance.SerializeJson(writer, options);
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

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
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

      if (!string.IsNullOrEmpty(Expiry))
      {
        writer.WriteString("expiry", (string)Expiry!);
      }

      if (_Expiry != null)
      {
        writer.WritePropertyName("_expiry");
        _Expiry.SerializeJson(writer, options);
      }

      if (Quantity != null)
      {
        writer.WritePropertyName("quantity");
        Quantity.SerializeJson(writer, options);
      }

      if ((Ingredient != null) && (Ingredient.Count != 0))
      {
        writer.WritePropertyName("ingredient");
        writer.WriteStartArray();

        foreach (SubstanceIngredient valIngredient in Ingredient)
        {
          valIngredient.SerializeJson(writer, options, true);
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

        case "code":
          Code = new fhirCsR5.Models.CodeableReference();
          Code.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR5.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "expiry":
          Expiry = reader.GetString();
          break;

        case "_expiry":
          _Expiry = new fhirCsR5.Models.Element();
          _Expiry.DeserializeJson(ref reader, options);
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

        case "ingredient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Ingredient = new List<SubstanceIngredient>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.SubstanceIngredient objIngredient = new fhirCsR5.Models.SubstanceIngredient();
            objIngredient.DeserializeJson(ref reader, options);
            Ingredient.Add(objIngredient);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Ingredient.Count == 0)
          {
            Ingredient = null;
          }

          break;

        case "instance":
          Instance = reader.GetBoolean();
          break;

        case "_instance":
          _Instance = new fhirCsR5.Models.Element();
          _Instance.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          Quantity = new fhirCsR5.Models.Quantity();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
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
  /// Code Values for the Substance.status field
  /// </summary>
  public static class SubstanceStatusCodes {
    public const string ACTIVE = "active";
    public const string INACTIVE = "inactive";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "active",
      "inactive",
      "entered-in-error",
    };
  }
}
