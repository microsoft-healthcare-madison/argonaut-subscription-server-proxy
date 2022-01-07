// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// General characteristics of this item.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ManufacturedItemDefinitionProperty>))]
  public class ManufacturedItemDefinitionProperty : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A code expressing the type of characteristic.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// A value for the characteristic.
    /// </summary>
    public CodeableConcept ValueCodeableConcept { get; set; }
    /// <summary>
    /// A value for the characteristic.
    /// </summary>
    public Quantity ValueQuantity { get; set; }
    /// <summary>
    /// A value for the characteristic.
    /// </summary>
    public string ValueDate { get; set; }
    /// <summary>
    /// Extension container element for ValueDate
    /// </summary>
    public Element _ValueDate { get; set; }
    /// <summary>
    /// A value for the characteristic.
    /// </summary>
    public bool? ValueBoolean { get; set; }
    /// <summary>
    /// Extension container element for ValueBoolean
    /// </summary>
    public Element _ValueBoolean { get; set; }
    /// <summary>
    /// A value for the characteristic.
    /// </summary>
    public Attachment ValueAttachment { get; set; }
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

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (ValueCodeableConcept != null)
      {
        writer.WritePropertyName("valueCodeableConcept");
        ValueCodeableConcept.SerializeJson(writer, options);
      }

      if (ValueQuantity != null)
      {
        writer.WritePropertyName("valueQuantity");
        ValueQuantity.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueDate))
      {
        writer.WriteString("valueDate", (string)ValueDate!);
      }

      if (_ValueDate != null)
      {
        writer.WritePropertyName("_valueDate");
        _ValueDate.SerializeJson(writer, options);
      }

      if (ValueBoolean != null)
      {
        writer.WriteBoolean("valueBoolean", (bool)ValueBoolean!);
      }

      if (_ValueBoolean != null)
      {
        writer.WritePropertyName("_valueBoolean");
        _ValueBoolean.SerializeJson(writer, options);
      }

      if (ValueAttachment != null)
      {
        writer.WritePropertyName("valueAttachment");
        ValueAttachment.SerializeJson(writer, options);
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
        case "type":
          Type = new fhirCsR5.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        case "valueCodeableConcept":
          ValueCodeableConcept = new fhirCsR5.Models.CodeableConcept();
          ValueCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "valueQuantity":
          ValueQuantity = new fhirCsR5.Models.Quantity();
          ValueQuantity.DeserializeJson(ref reader, options);
          break;

        case "valueDate":
          ValueDate = reader.GetString();
          break;

        case "_valueDate":
          _ValueDate = new fhirCsR5.Models.Element();
          _ValueDate.DeserializeJson(ref reader, options);
          break;

        case "valueBoolean":
          ValueBoolean = reader.GetBoolean();
          break;

        case "_valueBoolean":
          _ValueBoolean = new fhirCsR5.Models.Element();
          _ValueBoolean.DeserializeJson(ref reader, options);
          break;

        case "valueAttachment":
          ValueAttachment = new fhirCsR5.Models.Attachment();
          ValueAttachment.DeserializeJson(ref reader, options);
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
  /// The definition and characteristics of a medicinal manufactured item, such as a tablet or capsule, as contained in a packaged medicinal product.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ManufacturedItemDefinition>))]
  public class ManufacturedItemDefinition : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "ManufacturedItemDefinition";
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The ingredients of this manufactured item. This is only needed if the ingredients are not specified by incoming references from the Ingredient resource.
    /// </summary>
    public List<CodeableConcept> Ingredient { get; set; }
    /// <summary>
    /// Dose form as manufactured and before any transformation into the pharmaceutical product.
    /// </summary>
    public CodeableConcept ManufacturedDoseForm { get; set; }
    /// <summary>
    /// Manufacturer of the item (Note that this should be named "manufacturer" but it currently causes technical issues).
    /// </summary>
    public List<Reference> Manufacturer { get; set; }
    /// <summary>
    /// General characteristics of this item.
    /// </summary>
    public List<ManufacturedItemDefinitionProperty> Property { get; set; }
    /// <summary>
    /// Allows filtering of manufactured items that are appropriate for use versus not.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The “real world” units in which the quantity of the manufactured item is described.
    /// </summary>
    public CodeableConcept UnitOfPresentation { get; set; }
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

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (ManufacturedDoseForm != null)
      {
        writer.WritePropertyName("manufacturedDoseForm");
        ManufacturedDoseForm.SerializeJson(writer, options);
      }

      if (UnitOfPresentation != null)
      {
        writer.WritePropertyName("unitOfPresentation");
        UnitOfPresentation.SerializeJson(writer, options);
      }

      if ((Manufacturer != null) && (Manufacturer.Count != 0))
      {
        writer.WritePropertyName("manufacturer");
        writer.WriteStartArray();

        foreach (Reference valManufacturer in Manufacturer)
        {
          valManufacturer.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Ingredient != null) && (Ingredient.Count != 0))
      {
        writer.WritePropertyName("ingredient");
        writer.WriteStartArray();

        foreach (CodeableConcept valIngredient in Ingredient)
        {
          valIngredient.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Property != null) && (Property.Count != 0))
      {
        writer.WritePropertyName("property");
        writer.WriteStartArray();

        foreach (ManufacturedItemDefinitionProperty valProperty in Property)
        {
          valProperty.SerializeJson(writer, options, true);
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

          Ingredient = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objIngredient = new fhirCsR5.Models.CodeableConcept();
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

        case "manufacturedDoseForm":
          ManufacturedDoseForm = new fhirCsR5.Models.CodeableConcept();
          ManufacturedDoseForm.DeserializeJson(ref reader, options);
          break;

        case "manufacturer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Manufacturer = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objManufacturer = new fhirCsR5.Models.Reference();
            objManufacturer.DeserializeJson(ref reader, options);
            Manufacturer.Add(objManufacturer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Manufacturer.Count == 0)
          {
            Manufacturer = null;
          }

          break;

        case "property":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Property = new List<ManufacturedItemDefinitionProperty>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ManufacturedItemDefinitionProperty objProperty = new fhirCsR5.Models.ManufacturedItemDefinitionProperty();
            objProperty.DeserializeJson(ref reader, options);
            Property.Add(objProperty);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Property.Count == 0)
          {
            Property = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "unitOfPresentation":
          UnitOfPresentation = new fhirCsR5.Models.CodeableConcept();
          UnitOfPresentation.DeserializeJson(ref reader, options);
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
  /// Code Values for the ManufacturedItemDefinition.status field
  /// </summary>
  public static class ManufacturedItemDefinitionStatusCodes {
    public const string DRAFT = "draft";
    public const string ACTIVE = "active";
    public const string RETIRED = "retired";
    public const string UNKNOWN = "unknown";
    public static HashSet<string> Values = new HashSet<string>() {
      "draft",
      "active",
      "retired",
      "unknown",
    };
  }
}
