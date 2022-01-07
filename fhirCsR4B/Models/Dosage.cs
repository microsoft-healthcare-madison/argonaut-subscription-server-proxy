// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4B.Serialization;

namespace fhirCsR4B.Models
{
  /// <summary>
  /// The amount of medication administered.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<DosageDoseAndRate>))]
  public class DosageDoseAndRate : Element,  IFhirJsonSerializable {
    /// <summary>
    /// Note that this specifies the quantity of the specified medication, not the quantity for each active ingredient(s). Each ingredient amount can be communicated in the Medication resource. For example, if one wants to communicate that a tablet was 375 mg, where the dose was one tablet, you can use the Medication resource to document that the tablet was comprised of 375 mg of drug XYZ. Alternatively if the dose was 375 mg, then you may only need to use the Medication resource to indicate this was a tablet. If the example were an IV such as dopamine and you wanted to communicate that 400mg of dopamine was mixed in 500 ml of some IV solution, then this would all be communicated in the Medication resource. If the administration is not intended to be instantaneous (rate is present or timing has a duration), this can be specified to convey the total amount to be administered over the period of time as indicated by the schedule e.g. 500 ml in dose, with timing used to convey that this should be done over 4 hours.
    /// </summary>
    public Range DoseRange { get; set; }
    /// <summary>
    /// Note that this specifies the quantity of the specified medication, not the quantity for each active ingredient(s). Each ingredient amount can be communicated in the Medication resource. For example, if one wants to communicate that a tablet was 375 mg, where the dose was one tablet, you can use the Medication resource to document that the tablet was comprised of 375 mg of drug XYZ. Alternatively if the dose was 375 mg, then you may only need to use the Medication resource to indicate this was a tablet. If the example were an IV such as dopamine and you wanted to communicate that 400mg of dopamine was mixed in 500 ml of some IV solution, then this would all be communicated in the Medication resource. If the administration is not intended to be instantaneous (rate is present or timing has a duration), this can be specified to convey the total amount to be administered over the period of time as indicated by the schedule e.g. 500 ml in dose, with timing used to convey that this should be done over 4 hours.
    /// </summary>
    public Quantity DoseQuantity { get; set; }
    /// <summary>
    /// It is possible to supply both a rate and a doseQuantity to provide full details about how the medication is to be administered and supplied. If the rate is intended to change over time, depending on local rules/regulations, each change should be captured as a new version of the MedicationRequest with an updated rate, or captured with a new MedicationRequest with the new rate.
    /// It is possible to specify a rate over time (for example, 100 ml/hour) using either the rateRatio and rateQuantity.  The rateQuantity approach requires systems to have the capability to parse UCUM grammer where ml/hour is included rather than a specific ratio where the time is specified as the denominator.  Where a rate such as 500ml over 2 hours is specified, the use of rateRatio may be more semantically correct than specifying using a rateQuantity of 250 mg/hour.
    /// </summary>
    public Ratio RateRatio { get; set; }
    /// <summary>
    /// It is possible to supply both a rate and a doseQuantity to provide full details about how the medication is to be administered and supplied. If the rate is intended to change over time, depending on local rules/regulations, each change should be captured as a new version of the MedicationRequest with an updated rate, or captured with a new MedicationRequest with the new rate.
    /// It is possible to specify a rate over time (for example, 100 ml/hour) using either the rateRatio and rateQuantity.  The rateQuantity approach requires systems to have the capability to parse UCUM grammer where ml/hour is included rather than a specific ratio where the time is specified as the denominator.  Where a rate such as 500ml over 2 hours is specified, the use of rateRatio may be more semantically correct than specifying using a rateQuantity of 250 mg/hour.
    /// </summary>
    public Range RateRange { get; set; }
    /// <summary>
    /// It is possible to supply both a rate and a doseQuantity to provide full details about how the medication is to be administered and supplied. If the rate is intended to change over time, depending on local rules/regulations, each change should be captured as a new version of the MedicationRequest with an updated rate, or captured with a new MedicationRequest with the new rate.
    /// It is possible to specify a rate over time (for example, 100 ml/hour) using either the rateRatio and rateQuantity.  The rateQuantity approach requires systems to have the capability to parse UCUM grammer where ml/hour is included rather than a specific ratio where the time is specified as the denominator.  Where a rate such as 500ml over 2 hours is specified, the use of rateRatio may be more semantically correct than specifying using a rateQuantity of 250 mg/hour.
    /// </summary>
    public Quantity RateQuantity { get; set; }
    /// <summary>
    /// The kind of dose or rate specified, for example, ordered or calculated.
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
      ((fhirCsR4B.Models.Element)this).SerializeJson(writer, options, false);

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (DoseRange != null)
      {
        writer.WritePropertyName("doseRange");
        DoseRange.SerializeJson(writer, options);
      }

      if (DoseQuantity != null)
      {
        writer.WritePropertyName("doseQuantity");
        DoseQuantity.SerializeJson(writer, options);
      }

      if (RateRatio != null)
      {
        writer.WritePropertyName("rateRatio");
        RateRatio.SerializeJson(writer, options);
      }

      if (RateRange != null)
      {
        writer.WritePropertyName("rateRange");
        RateRange.SerializeJson(writer, options);
      }

      if (RateQuantity != null)
      {
        writer.WritePropertyName("rateQuantity");
        RateQuantity.SerializeJson(writer, options);
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
        case "doseRange":
          DoseRange = new fhirCsR4B.Models.Range();
          DoseRange.DeserializeJson(ref reader, options);
          break;

        case "doseQuantity":
          DoseQuantity = new fhirCsR4B.Models.Quantity();
          DoseQuantity.DeserializeJson(ref reader, options);
          break;

        case "rateRatio":
          RateRatio = new fhirCsR4B.Models.Ratio();
          RateRatio.DeserializeJson(ref reader, options);
          break;

        case "rateRange":
          RateRange = new fhirCsR4B.Models.Range();
          RateRange.DeserializeJson(ref reader, options);
          break;

        case "rateQuantity":
          RateQuantity = new fhirCsR4B.Models.Quantity();
          RateQuantity.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR4B.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
  /// <summary>
  /// Indicates how the medication is/was taken or should be taken by the patient.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<Dosage>))]
  public class Dosage : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Information about administration or preparation of the medication (e.g. "infuse as rapidly as possibly via intraperitoneal port" or "immediately following drug x") should be populated in dosage.text.
    /// </summary>
    public List<CodeableConcept> AdditionalInstruction { get; set; }
    /// <summary>
    /// Can express "as needed" without a reason by setting the Boolean = True.  In this case the CodeableConcept is not populated.  Or you can express "as needed" with a reason by including the CodeableConcept.  In this case the Boolean is assumed to be True.  If you set the Boolean to False, then the dose is given according to the schedule and is not "prn" or "as needed".
    /// </summary>
    public bool? AsNeededBoolean { get; set; }
    /// <summary>
    /// Can express "as needed" without a reason by setting the Boolean = True.  In this case the CodeableConcept is not populated.  Or you can express "as needed" with a reason by including the CodeableConcept.  In this case the Boolean is assumed to be True.  If you set the Boolean to False, then the dose is given according to the schedule and is not "prn" or "as needed".
    /// </summary>
    public CodeableConcept AsNeededCodeableConcept { get; set; }
    /// <summary>
    /// The amount of medication administered.
    /// </summary>
    public List<DosageDoseAndRate> DoseAndRate { get; set; }
    /// <summary>
    /// This is intended for use as an adjunct to the dosage when there is an upper cap.  For example, a body surface area related dose with a maximum amount, such as 1.5 mg/m2 (maximum 2 mg) IV over 5 – 10 minutes would have doseQuantity of 1.5 mg/m2 and maxDosePerAdministration of 2 mg.
    /// </summary>
    public Quantity MaxDosePerAdministration { get; set; }
    /// <summary>
    /// Upper limit on medication per lifetime of the patient.
    /// </summary>
    public Quantity MaxDosePerLifetime { get; set; }
    /// <summary>
    /// This is intended for use as an adjunct to the dosage when there is an upper cap.  For example "2 tablets every 4 hours to a maximum of 8/day".
    /// </summary>
    public Ratio MaxDosePerPeriod { get; set; }
    /// <summary>
    /// Terminologies used often pre-coordinate this term with the route and or form of administration.
    /// </summary>
    public CodeableConcept Method { get; set; }
    /// <summary>
    /// Instructions in terms that are understood by the patient or consumer.
    /// </summary>
    public string PatientInstruction { get; set; }
    /// <summary>
    /// Extension container element for PatientInstruction
    /// </summary>
    public Element _PatientInstruction { get; set; }
    /// <summary>
    /// How drug should enter body.
    /// </summary>
    public CodeableConcept Route { get; set; }
    /// <summary>
    /// Indicates the order in which the dosage instructions should be applied or interpreted.
    /// </summary>
    public int? Sequence { get; set; }
    /// <summary>
    /// If the use case requires attributes from the BodySite resource (e.g. to identify and track separately) then use the standard extension [bodySite](extension-bodysite.html).  May be a summary code, or a reference to a very precise definition of the location, or both.
    /// </summary>
    public CodeableConcept Site { get; set; }
    /// <summary>
    /// Free text dosage instructions e.g. SIG.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// This attribute might not always be populated while the Dosage.text is expected to be populated.  If both are populated, then the Dosage.text should reflect the content of the Dosage.timing.
    /// </summary>
    public Timing Timing { get; set; }
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

      if (Sequence != null)
      {
        writer.WriteNumber("sequence", (int)Sequence!);
      }

      if (!string.IsNullOrEmpty(Text))
      {
        writer.WriteString("text", (string)Text!);
      }

      if (_Text != null)
      {
        writer.WritePropertyName("_text");
        _Text.SerializeJson(writer, options);
      }

      if ((AdditionalInstruction != null) && (AdditionalInstruction.Count != 0))
      {
        writer.WritePropertyName("additionalInstruction");
        writer.WriteStartArray();

        foreach (CodeableConcept valAdditionalInstruction in AdditionalInstruction)
        {
          valAdditionalInstruction.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(PatientInstruction))
      {
        writer.WriteString("patientInstruction", (string)PatientInstruction!);
      }

      if (_PatientInstruction != null)
      {
        writer.WritePropertyName("_patientInstruction");
        _PatientInstruction.SerializeJson(writer, options);
      }

      if (Timing != null)
      {
        writer.WritePropertyName("timing");
        Timing.SerializeJson(writer, options);
      }

      if (AsNeededBoolean != null)
      {
        writer.WriteBoolean("asNeededBoolean", (bool)AsNeededBoolean!);
      }

      if (AsNeededCodeableConcept != null)
      {
        writer.WritePropertyName("asNeededCodeableConcept");
        AsNeededCodeableConcept.SerializeJson(writer, options);
      }

      if (Site != null)
      {
        writer.WritePropertyName("site");
        Site.SerializeJson(writer, options);
      }

      if (Route != null)
      {
        writer.WritePropertyName("route");
        Route.SerializeJson(writer, options);
      }

      if (Method != null)
      {
        writer.WritePropertyName("method");
        Method.SerializeJson(writer, options);
      }

      if ((DoseAndRate != null) && (DoseAndRate.Count != 0))
      {
        writer.WritePropertyName("doseAndRate");
        writer.WriteStartArray();

        foreach (DosageDoseAndRate valDoseAndRate in DoseAndRate)
        {
          valDoseAndRate.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (MaxDosePerPeriod != null)
      {
        writer.WritePropertyName("maxDosePerPeriod");
        MaxDosePerPeriod.SerializeJson(writer, options);
      }

      if (MaxDosePerAdministration != null)
      {
        writer.WritePropertyName("maxDosePerAdministration");
        MaxDosePerAdministration.SerializeJson(writer, options);
      }

      if (MaxDosePerLifetime != null)
      {
        writer.WritePropertyName("maxDosePerLifetime");
        MaxDosePerLifetime.SerializeJson(writer, options);
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
        case "additionalInstruction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          AdditionalInstruction = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.CodeableConcept objAdditionalInstruction = new fhirCsR4B.Models.CodeableConcept();
            objAdditionalInstruction.DeserializeJson(ref reader, options);
            AdditionalInstruction.Add(objAdditionalInstruction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (AdditionalInstruction.Count == 0)
          {
            AdditionalInstruction = null;
          }

          break;

        case "asNeededBoolean":
          AsNeededBoolean = reader.GetBoolean();
          break;

        case "asNeededCodeableConcept":
          AsNeededCodeableConcept = new fhirCsR4B.Models.CodeableConcept();
          AsNeededCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "doseAndRate":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DoseAndRate = new List<DosageDoseAndRate>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.DosageDoseAndRate objDoseAndRate = new fhirCsR4B.Models.DosageDoseAndRate();
            objDoseAndRate.DeserializeJson(ref reader, options);
            DoseAndRate.Add(objDoseAndRate);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DoseAndRate.Count == 0)
          {
            DoseAndRate = null;
          }

          break;

        case "maxDosePerAdministration":
          MaxDosePerAdministration = new fhirCsR4B.Models.Quantity();
          MaxDosePerAdministration.DeserializeJson(ref reader, options);
          break;

        case "maxDosePerLifetime":
          MaxDosePerLifetime = new fhirCsR4B.Models.Quantity();
          MaxDosePerLifetime.DeserializeJson(ref reader, options);
          break;

        case "maxDosePerPeriod":
          MaxDosePerPeriod = new fhirCsR4B.Models.Ratio();
          MaxDosePerPeriod.DeserializeJson(ref reader, options);
          break;

        case "method":
          Method = new fhirCsR4B.Models.CodeableConcept();
          Method.DeserializeJson(ref reader, options);
          break;

        case "patientInstruction":
          PatientInstruction = reader.GetString();
          break;

        case "_patientInstruction":
          _PatientInstruction = new fhirCsR4B.Models.Element();
          _PatientInstruction.DeserializeJson(ref reader, options);
          break;

        case "route":
          Route = new fhirCsR4B.Models.CodeableConcept();
          Route.DeserializeJson(ref reader, options);
          break;

        case "sequence":
          Sequence = reader.GetInt32();
          break;

        case "site":
          Site = new fhirCsR4B.Models.CodeableConcept();
          Site.DeserializeJson(ref reader, options);
          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new fhirCsR4B.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        case "timing":
          Timing = new fhirCsR4B.Models.Timing();
          Timing.DeserializeJson(ref reader, options);
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
}
