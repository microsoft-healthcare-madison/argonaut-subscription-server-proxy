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
  /// Substance may be used to describe a kind of substance, or a specific package/container of the substance: an instance.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<SubstanceInstance>))]
  public class SubstanceInstance : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// When the substance is no longer valid to use. For some substances, a single arbitrary date is used for expiry.
    /// </summary>
    public string Expiry { get; set; }
    /// <summary>
    /// Extension container element for Expiry
    /// </summary>
    public Element _Expiry { get; set; }
    /// <summary>
    /// Identifier associated with the package/container (usually a label affixed directly).
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// The amount of the substance.
    /// </summary>
    public Quantity Quantity { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4B.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
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
        case "expiry":
          Expiry = reader.GetString();
          break;

        case "_expiry":
          _Expiry = new fhirCsR4B.Models.Element();
          _Expiry.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new fhirCsR4B.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          Quantity = new fhirCsR4B.Models.Quantity();
          Quantity.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4B.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// A substance can be composed of other substances.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<SubstanceIngredient>))]
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
      ((fhirCsR4B.Models.BackboneElement)this).SerializeJson(writer, options, false);

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
          Quantity = new fhirCsR4B.Models.Ratio();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "substanceCodeableConcept":
          SubstanceCodeableConcept = new fhirCsR4B.Models.CodeableConcept();
          SubstanceCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "substanceReference":
          SubstanceReference = new fhirCsR4B.Models.Reference();
          SubstanceReference.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4B.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<Substance>))]
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
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// A description of the substance - its appearance, handling requirements, and other usage notes.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// This identifier is associated with the kind of substance in contrast to the Substance.instance.identifier which is associated with the package/container.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// A substance can be composed of other substances.
    /// </summary>
    public List<SubstanceIngredient> Ingredient { get; set; }
    /// <summary>
    /// Substance may be used to describe a kind of substance, or a specific package/container of the substance: an instance.
    /// </summary>
    public List<SubstanceInstance> Instance { get; set; }
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

      if ((Instance != null) && (Instance.Count != 0))
      {
        writer.WritePropertyName("instance");
        writer.WriteStartArray();

        foreach (SubstanceInstance valInstance in Instance)
        {
          valInstance.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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
            fhirCsR4B.Models.CodeableConcept objCategory = new fhirCsR4B.Models.CodeableConcept();
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
          Code = new fhirCsR4B.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR4B.Models.Element();
          _Description.DeserializeJson(ref reader, options);
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

        case "ingredient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Ingredient = new List<SubstanceIngredient>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.SubstanceIngredient objIngredient = new fhirCsR4B.Models.SubstanceIngredient();
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
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Instance = new List<SubstanceInstance>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.SubstanceInstance objInstance = new fhirCsR4B.Models.SubstanceInstance();
            objInstance.DeserializeJson(ref reader, options);
            Instance.Add(objInstance);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Instance.Count == 0)
          {
            Instance = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR4B.Models.Element();
          _Status.DeserializeJson(ref reader, options);
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
