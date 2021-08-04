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
  /// Information about the use of the medicinal product in relation to other therapies described as part of the contraindication.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ClinicalUseIssueContraindicationOtherTherapy>))]
  public class ClinicalUseIssueContraindicationOtherTherapy : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The type of relationship between the medicinal product indication or contraindication and another therapy.
    /// </summary>
    public CodeableConcept RelationshipType { get; set; }
    /// <summary>
    /// Reference to a specific medication (active substance, medicinal product or class of products) as part of an indication or contraindication.
    /// </summary>
    public CodeableReference Therapy { get; set; }
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

      if (RelationshipType != null)
      {
        writer.WritePropertyName("relationshipType");
        RelationshipType.SerializeJson(writer, options);
      }

      if (Therapy != null)
      {
        writer.WritePropertyName("therapy");
        Therapy.SerializeJson(writer, options);
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
        case "relationshipType":
          RelationshipType = new fhirCsR5.Models.CodeableConcept();
          RelationshipType.DeserializeJson(ref reader, options);
          break;

        case "therapy":
          Therapy = new fhirCsR5.Models.CodeableReference();
          Therapy.DeserializeJson(ref reader, options);
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
  /// Specifics for when this is a contraindication.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ClinicalUseIssueContraindication>))]
  public class ClinicalUseIssueContraindication : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A comorbidity (concurrent condition) or coinfection.
    /// </summary>
    public List<CodeableReference> Comorbidity { get; set; }
    /// <summary>
    /// The status of the disease or symptom for the contraindication.
    /// </summary>
    public CodeableReference DiseaseStatus { get; set; }
    /// <summary>
    /// The situation that is being documented as contraindicating against this item.
    /// </summary>
    public CodeableReference DiseaseSymptomProcedure { get; set; }
    /// <summary>
    /// The indication which this is a contraidication for.
    /// </summary>
    public List<Reference> Indication { get; set; }
    /// <summary>
    /// Information about the use of the medicinal product in relation to other therapies described as part of the contraindication.
    /// </summary>
    public List<ClinicalUseIssueContraindicationOtherTherapy> OtherTherapy { get; set; }
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

      if (DiseaseSymptomProcedure != null)
      {
        writer.WritePropertyName("diseaseSymptomProcedure");
        DiseaseSymptomProcedure.SerializeJson(writer, options);
      }

      if (DiseaseStatus != null)
      {
        writer.WritePropertyName("diseaseStatus");
        DiseaseStatus.SerializeJson(writer, options);
      }

      if ((Comorbidity != null) && (Comorbidity.Count != 0))
      {
        writer.WritePropertyName("comorbidity");
        writer.WriteStartArray();

        foreach (CodeableReference valComorbidity in Comorbidity)
        {
          valComorbidity.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Indication != null) && (Indication.Count != 0))
      {
        writer.WritePropertyName("indication");
        writer.WriteStartArray();

        foreach (Reference valIndication in Indication)
        {
          valIndication.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((OtherTherapy != null) && (OtherTherapy.Count != 0))
      {
        writer.WritePropertyName("otherTherapy");
        writer.WriteStartArray();

        foreach (ClinicalUseIssueContraindicationOtherTherapy valOtherTherapy in OtherTherapy)
        {
          valOtherTherapy.SerializeJson(writer, options, true);
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
        case "comorbidity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Comorbidity = new List<CodeableReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableReference objComorbidity = new fhirCsR5.Models.CodeableReference();
            objComorbidity.DeserializeJson(ref reader, options);
            Comorbidity.Add(objComorbidity);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Comorbidity.Count == 0)
          {
            Comorbidity = null;
          }

          break;

        case "diseaseStatus":
          DiseaseStatus = new fhirCsR5.Models.CodeableReference();
          DiseaseStatus.DeserializeJson(ref reader, options);
          break;

        case "diseaseSymptomProcedure":
          DiseaseSymptomProcedure = new fhirCsR5.Models.CodeableReference();
          DiseaseSymptomProcedure.DeserializeJson(ref reader, options);
          break;

        case "indication":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Indication = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objIndication = new fhirCsR5.Models.Reference();
            objIndication.DeserializeJson(ref reader, options);
            Indication.Add(objIndication);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Indication.Count == 0)
          {
            Indication = null;
          }

          break;

        case "otherTherapy":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          OtherTherapy = new List<ClinicalUseIssueContraindicationOtherTherapy>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ClinicalUseIssueContraindicationOtherTherapy objOtherTherapy = new fhirCsR5.Models.ClinicalUseIssueContraindicationOtherTherapy();
            objOtherTherapy.DeserializeJson(ref reader, options);
            OtherTherapy.Add(objOtherTherapy);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (OtherTherapy.Count == 0)
          {
            OtherTherapy = null;
          }

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
  /// Specifics for when this is an indication.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ClinicalUseIssueIndication>))]
  public class ClinicalUseIssueIndication : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A comorbidity (concurrent condition) or coinfection as part of the indication.
    /// </summary>
    public List<CodeableReference> Comorbidity { get; set; }
    /// <summary>
    /// The status of the disease or symptom for the indication.
    /// </summary>
    public CodeableReference DiseaseStatus { get; set; }
    /// <summary>
    /// The situation that is being documented as an indicaton for this item.
    /// </summary>
    public CodeableReference DiseaseSymptomProcedure { get; set; }
    /// <summary>
    /// Timing or duration information.
    /// </summary>
    public Quantity Duration { get; set; }
    /// <summary>
    /// The intended effect, aim or strategy to be achieved.
    /// </summary>
    public CodeableReference IntendedEffect { get; set; }
    /// <summary>
    /// Information about the use of the medicinal product in relation to other therapies described as part of the indication.
    /// </summary>
    public List<ClinicalUseIssueContraindicationOtherTherapy> OtherTherapy { get; set; }
    /// <summary>
    /// The specific undesirable effects of the medicinal product.
    /// </summary>
    public List<Reference> UndesirableEffect { get; set; }
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

      if (DiseaseSymptomProcedure != null)
      {
        writer.WritePropertyName("diseaseSymptomProcedure");
        DiseaseSymptomProcedure.SerializeJson(writer, options);
      }

      if (DiseaseStatus != null)
      {
        writer.WritePropertyName("diseaseStatus");
        DiseaseStatus.SerializeJson(writer, options);
      }

      if ((Comorbidity != null) && (Comorbidity.Count != 0))
      {
        writer.WritePropertyName("comorbidity");
        writer.WriteStartArray();

        foreach (CodeableReference valComorbidity in Comorbidity)
        {
          valComorbidity.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (IntendedEffect != null)
      {
        writer.WritePropertyName("intendedEffect");
        IntendedEffect.SerializeJson(writer, options);
      }

      if (Duration != null)
      {
        writer.WritePropertyName("duration");
        Duration.SerializeJson(writer, options);
      }

      if ((UndesirableEffect != null) && (UndesirableEffect.Count != 0))
      {
        writer.WritePropertyName("undesirableEffect");
        writer.WriteStartArray();

        foreach (Reference valUndesirableEffect in UndesirableEffect)
        {
          valUndesirableEffect.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((OtherTherapy != null) && (OtherTherapy.Count != 0))
      {
        writer.WritePropertyName("otherTherapy");
        writer.WriteStartArray();

        foreach (ClinicalUseIssueContraindicationOtherTherapy valOtherTherapy in OtherTherapy)
        {
          valOtherTherapy.SerializeJson(writer, options, true);
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
        case "comorbidity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Comorbidity = new List<CodeableReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableReference objComorbidity = new fhirCsR5.Models.CodeableReference();
            objComorbidity.DeserializeJson(ref reader, options);
            Comorbidity.Add(objComorbidity);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Comorbidity.Count == 0)
          {
            Comorbidity = null;
          }

          break;

        case "diseaseStatus":
          DiseaseStatus = new fhirCsR5.Models.CodeableReference();
          DiseaseStatus.DeserializeJson(ref reader, options);
          break;

        case "diseaseSymptomProcedure":
          DiseaseSymptomProcedure = new fhirCsR5.Models.CodeableReference();
          DiseaseSymptomProcedure.DeserializeJson(ref reader, options);
          break;

        case "duration":
          Duration = new fhirCsR5.Models.Quantity();
          Duration.DeserializeJson(ref reader, options);
          break;

        case "intendedEffect":
          IntendedEffect = new fhirCsR5.Models.CodeableReference();
          IntendedEffect.DeserializeJson(ref reader, options);
          break;

        case "otherTherapy":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          OtherTherapy = new List<ClinicalUseIssueContraindicationOtherTherapy>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ClinicalUseIssueContraindicationOtherTherapy objOtherTherapy = new fhirCsR5.Models.ClinicalUseIssueContraindicationOtherTherapy();
            objOtherTherapy.DeserializeJson(ref reader, options);
            OtherTherapy.Add(objOtherTherapy);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (OtherTherapy.Count == 0)
          {
            OtherTherapy = null;
          }

          break;

        case "undesirableEffect":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          UndesirableEffect = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objUndesirableEffect = new fhirCsR5.Models.Reference();
            objUndesirableEffect.DeserializeJson(ref reader, options);
            UndesirableEffect.Add(objUndesirableEffect);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (UndesirableEffect.Count == 0)
          {
            UndesirableEffect = null;
          }

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
  /// The specific medication, food, substance or laboratory test that interacts.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ClinicalUseIssueInteractionInteractant>))]
  public class ClinicalUseIssueInteractionInteractant : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The specific medication, food or laboratory test that interacts.
    /// </summary>
    public Reference ItemReference { get; set; }
    /// <summary>
    /// The specific medication, food or laboratory test that interacts.
    /// </summary>
    public CodeableConcept ItemCodeableConcept { get; set; }
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

      if (ItemReference != null)
      {
        writer.WritePropertyName("itemReference");
        ItemReference.SerializeJson(writer, options);
      }

      if (ItemCodeableConcept != null)
      {
        writer.WritePropertyName("itemCodeableConcept");
        ItemCodeableConcept.SerializeJson(writer, options);
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
        case "itemReference":
          ItemReference = new fhirCsR5.Models.Reference();
          ItemReference.DeserializeJson(ref reader, options);
          break;

        case "itemCodeableConcept":
          ItemCodeableConcept = new fhirCsR5.Models.CodeableConcept();
          ItemCodeableConcept.DeserializeJson(ref reader, options);
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
  /// Specifics for when this is an interaction.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ClinicalUseIssueInteraction>))]
  public class ClinicalUseIssueInteraction : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The effect of the interaction, for example "reduced gastric absorption of primary medication".
    /// </summary>
    public CodeableReference Effect { get; set; }
    /// <summary>
    /// The incidence of the interaction, e.g. theoretical, observed.
    /// </summary>
    public CodeableConcept Incidence { get; set; }
    /// <summary>
    /// The specific medication, food, substance or laboratory test that interacts.
    /// </summary>
    public List<ClinicalUseIssueInteractionInteractant> Interactant { get; set; }
    /// <summary>
    /// Actions for managing the interaction.
    /// </summary>
    public CodeableConcept Management { get; set; }
    /// <summary>
    /// The type of the interaction e.g. drug-drug interaction, drug-food interaction, drug-lab test interaction.
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
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if ((Interactant != null) && (Interactant.Count != 0))
      {
        writer.WritePropertyName("interactant");
        writer.WriteStartArray();

        foreach (ClinicalUseIssueInteractionInteractant valInteractant in Interactant)
        {
          valInteractant.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Effect != null)
      {
        writer.WritePropertyName("effect");
        Effect.SerializeJson(writer, options);
      }

      if (Incidence != null)
      {
        writer.WritePropertyName("incidence");
        Incidence.SerializeJson(writer, options);
      }

      if (Management != null)
      {
        writer.WritePropertyName("management");
        Management.SerializeJson(writer, options);
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
        case "effect":
          Effect = new fhirCsR5.Models.CodeableReference();
          Effect.DeserializeJson(ref reader, options);
          break;

        case "incidence":
          Incidence = new fhirCsR5.Models.CodeableConcept();
          Incidence.DeserializeJson(ref reader, options);
          break;

        case "interactant":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Interactant = new List<ClinicalUseIssueInteractionInteractant>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ClinicalUseIssueInteractionInteractant objInteractant = new fhirCsR5.Models.ClinicalUseIssueInteractionInteractant();
            objInteractant.DeserializeJson(ref reader, options);
            Interactant.Add(objInteractant);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Interactant.Count == 0)
          {
            Interactant = null;
          }

          break;

        case "management":
          Management = new fhirCsR5.Models.CodeableConcept();
          Management.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR5.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
  /// Describe the undesirable effects of the medicinal product.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ClinicalUseIssueUndesirableEffect>))]
  public class ClinicalUseIssueUndesirableEffect : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// High level classification of the effect.
    /// </summary>
    public CodeableConcept Classification { get; set; }
    /// <summary>
    /// How often the effect is seen.
    /// </summary>
    public CodeableConcept FrequencyOfOccurrence { get; set; }
    /// <summary>
    /// The situation in which the undesirable effect may manifest.
    /// </summary>
    public CodeableReference SymptomConditionEffect { get; set; }
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

      if (SymptomConditionEffect != null)
      {
        writer.WritePropertyName("symptomConditionEffect");
        SymptomConditionEffect.SerializeJson(writer, options);
      }

      if (Classification != null)
      {
        writer.WritePropertyName("classification");
        Classification.SerializeJson(writer, options);
      }

      if (FrequencyOfOccurrence != null)
      {
        writer.WritePropertyName("frequencyOfOccurrence");
        FrequencyOfOccurrence.SerializeJson(writer, options);
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
        case "classification":
          Classification = new fhirCsR5.Models.CodeableConcept();
          Classification.DeserializeJson(ref reader, options);
          break;

        case "frequencyOfOccurrence":
          FrequencyOfOccurrence = new fhirCsR5.Models.CodeableConcept();
          FrequencyOfOccurrence.DeserializeJson(ref reader, options);
          break;

        case "symptomConditionEffect":
          SymptomConditionEffect = new fhirCsR5.Models.CodeableReference();
          SymptomConditionEffect.DeserializeJson(ref reader, options);
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
  /// A single issue - either an indication, contraindication, interaction or an undesirable effect for a medicinal product, medication, device or procedure.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ClinicalUseIssue>))]
  public class ClinicalUseIssue : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "ClinicalUseIssue";
    /// <summary>
    /// A categorisation of the issue, primarily for dividing warnings into subject heading areas such as "Pregnancy and Lactation", "Overdose", "Effects on Ability to Drive and Use Machines".
    /// </summary>
    public CodeableConcept Category { get; set; }
    /// <summary>
    /// Specifics for when this is a contraindication.
    /// </summary>
    public ClinicalUseIssueContraindication Contraindication { get; set; }
    /// <summary>
    /// General description of an effect (particularly for a general warning, rather than any of the more specific types such as indication) for when a distinct coded or textual description is not appropriate using  Indication.diseaseSymptomProcedure.text, Contraindication.diseaseSymptomProcedure.text etc. For example "May affect ability to drive".
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Business identifier for this issue.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Specifics for when this is an indication.
    /// </summary>
    public ClinicalUseIssueIndication Indication { get; set; }
    /// <summary>
    /// Specifics for when this is an interaction.
    /// </summary>
    public ClinicalUseIssueInteraction Interaction { get; set; }
    /// <summary>
    /// The population group to which this applies.
    /// </summary>
    public List<Population> Population { get; set; }
    /// <summary>
    /// Whether this is a current issue or one that has been retired etc.
    /// </summary>
    public CodeableConcept Status { get; set; }
    /// <summary>
    /// The medication or procedure for which this is an indication.
    /// </summary>
    public List<Reference> Subject { get; set; }
    /// <summary>
    /// indication | contraindication | interaction | undesirable-effect | warning.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// Describe the undesirable effects of the medicinal product.
    /// </summary>
    public ClinicalUseIssueUndesirableEffect UndesirableEffect { get; set; }
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

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if (Category != null)
      {
        writer.WritePropertyName("category");
        Category.SerializeJson(writer, options);
      }

      if ((Subject != null) && (Subject.Count != 0))
      {
        writer.WritePropertyName("subject");
        writer.WriteStartArray();

        foreach (Reference valSubject in Subject)
        {
          valSubject.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Status != null)
      {
        writer.WritePropertyName("status");
        Status.SerializeJson(writer, options);
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

      if (Contraindication != null)
      {
        writer.WritePropertyName("contraindication");
        Contraindication.SerializeJson(writer, options);
      }

      if (Indication != null)
      {
        writer.WritePropertyName("indication");
        Indication.SerializeJson(writer, options);
      }

      if (Interaction != null)
      {
        writer.WritePropertyName("interaction");
        Interaction.SerializeJson(writer, options);
      }

      if ((Population != null) && (Population.Count != 0))
      {
        writer.WritePropertyName("population");
        writer.WriteStartArray();

        foreach (Population valPopulation in Population)
        {
          valPopulation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (UndesirableEffect != null)
      {
        writer.WritePropertyName("undesirableEffect");
        UndesirableEffect.SerializeJson(writer, options);
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
          Category = new fhirCsR5.Models.CodeableConcept();
          Category.DeserializeJson(ref reader, options);
          break;

        case "contraindication":
          Contraindication = new fhirCsR5.Models.ClinicalUseIssueContraindication();
          Contraindication.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR5.Models.Element();
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

        case "indication":
          Indication = new fhirCsR5.Models.ClinicalUseIssueIndication();
          Indication.DeserializeJson(ref reader, options);
          break;

        case "interaction":
          Interaction = new fhirCsR5.Models.ClinicalUseIssueInteraction();
          Interaction.DeserializeJson(ref reader, options);
          break;

        case "population":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Population = new List<Population>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Population objPopulation = new fhirCsR5.Models.Population();
            objPopulation.DeserializeJson(ref reader, options);
            Population.Add(objPopulation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Population.Count == 0)
          {
            Population = null;
          }

          break;

        case "status":
          Status = new fhirCsR5.Models.CodeableConcept();
          Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Subject = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objSubject = new fhirCsR5.Models.Reference();
            objSubject.DeserializeJson(ref reader, options);
            Subject.Add(objSubject);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Subject.Count == 0)
          {
            Subject = null;
          }

          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new fhirCsR5.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        case "undesirableEffect":
          UndesirableEffect = new fhirCsR5.Models.ClinicalUseIssueUndesirableEffect();
          UndesirableEffect.DeserializeJson(ref reader, options);
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
  /// Code Values for the ClinicalUseIssue.type field
  /// </summary>
  public static class ClinicalUseIssueTypeCodes {
    public const string INDICATION = "indication";
    public const string CONTRAINDICATION = "contraindication";
    public const string INTERACTION = "interaction";
    public const string UNDESIRABLE_EFFECT = "undesirable-effect";
    public const string WARNING = "warning";
  }
}
