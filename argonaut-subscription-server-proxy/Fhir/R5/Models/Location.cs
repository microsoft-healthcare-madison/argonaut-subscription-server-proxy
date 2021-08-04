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
  /// The absolute geographic location of the Location, expressed using the WGS84 datum (This is the same co-ordinate system used in KML).
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<LocationPosition>))]
  public class LocationPosition : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Altitude. The value domain and the interpretation are the same as for the text of the altitude element in KML (see notes below).
    /// </summary>
    public decimal? Altitude { get; set; }
    /// <summary>
    /// Extension container element for Altitude
    /// </summary>
    public Element _Altitude { get; set; }
    /// <summary>
    /// Latitude. The value domain and the interpretation are the same as for the text of the latitude element in KML (see notes below).
    /// </summary>
    public decimal Latitude { get; set; }
    /// <summary>
    /// Extension container element for Latitude
    /// </summary>
    public Element _Latitude { get; set; }
    /// <summary>
    /// Longitude. The value domain and the interpretation are the same as for the text of the longitude element in KML (see notes below).
    /// </summary>
    public decimal Longitude { get; set; }
    /// <summary>
    /// Extension container element for Longitude
    /// </summary>
    public Element _Longitude { get; set; }
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

      writer.WriteNumber("longitude", Longitude);

      if (_Longitude != null)
      {
        writer.WritePropertyName("_longitude");
        _Longitude.SerializeJson(writer, options);
      }

      writer.WriteNumber("latitude", Latitude);

      if (_Latitude != null)
      {
        writer.WritePropertyName("_latitude");
        _Latitude.SerializeJson(writer, options);
      }

      if (Altitude != null)
      {
        writer.WriteNumber("altitude", (decimal)Altitude!);
      }

      if (_Altitude != null)
      {
        writer.WritePropertyName("_altitude");
        _Altitude.SerializeJson(writer, options);
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
        case "altitude":
          Altitude = reader.GetDecimal();
          break;

        case "_altitude":
          _Altitude = new fhirCsR5.Models.Element();
          _Altitude.DeserializeJson(ref reader, options);
          break;

        case "latitude":
          Latitude = reader.GetDecimal();
          break;

        case "_latitude":
          _Latitude = new fhirCsR5.Models.Element();
          _Latitude.DeserializeJson(ref reader, options);
          break;

        case "longitude":
          Longitude = reader.GetDecimal();
          break;

        case "_longitude":
          _Longitude = new fhirCsR5.Models.Element();
          _Longitude.DeserializeJson(ref reader, options);
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
  /// This type of information is commonly found published in directories and on websites informing customers when the facility is available.
  /// Specific services within the location may have their own hours which could be shorter (or longer) than the locations hours.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<LocationHoursOfOperation>))]
  public class LocationHoursOfOperation : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The Location is open all day.
    /// </summary>
    public bool? AllDay { get; set; }
    /// <summary>
    /// Time that the Location closes.
    /// </summary>
    public string ClosingTime { get; set; }
    /// <summary>
    /// Extension container element for ClosingTime
    /// </summary>
    public Element _ClosingTime { get; set; }
    /// <summary>
    /// Indicates which days of the week are available between the start and end Times.
    /// </summary>
    public List<string> DaysOfWeek { get; set; }
    /// <summary>
    /// Extension container element for DaysOfWeek
    /// </summary>
    public List<Element> _DaysOfWeek { get; set; }
    /// <summary>
    /// Time that the Location opens.
    /// </summary>
    public string OpeningTime { get; set; }
    /// <summary>
    /// Extension container element for OpeningTime
    /// </summary>
    public Element _OpeningTime { get; set; }
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

      if ((DaysOfWeek != null) && (DaysOfWeek.Count != 0))
      {
        writer.WritePropertyName("daysOfWeek");
        writer.WriteStartArray();

        foreach (string valDaysOfWeek in DaysOfWeek)
        {
          writer.WriteStringValue(valDaysOfWeek);
        }

        writer.WriteEndArray();
      }

      if ((_DaysOfWeek != null) && (_DaysOfWeek.Count != 0))
      {
        writer.WritePropertyName("_daysOfWeek");
        writer.WriteStartArray();

        foreach (Element val_DaysOfWeek in _DaysOfWeek)
        {
          val_DaysOfWeek.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (AllDay != null)
      {
        writer.WriteBoolean("allDay", (bool)AllDay!);
      }

      if (!string.IsNullOrEmpty(OpeningTime))
      {
        writer.WriteString("openingTime", (string)OpeningTime!);
      }

      if (_OpeningTime != null)
      {
        writer.WritePropertyName("_openingTime");
        _OpeningTime.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ClosingTime))
      {
        writer.WriteString("closingTime", (string)ClosingTime!);
      }

      if (_ClosingTime != null)
      {
        writer.WritePropertyName("_closingTime");
        _ClosingTime.SerializeJson(writer, options);
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
        case "allDay":
          AllDay = reader.GetBoolean();
          break;

        case "closingTime":
          ClosingTime = reader.GetString();
          break;

        case "_closingTime":
          _ClosingTime = new fhirCsR5.Models.Element();
          _ClosingTime.DeserializeJson(ref reader, options);
          break;

        case "daysOfWeek":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DaysOfWeek = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            DaysOfWeek.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DaysOfWeek.Count == 0)
          {
            DaysOfWeek = null;
          }

          break;

        case "_daysOfWeek":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _DaysOfWeek = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_DaysOfWeek = new fhirCsR5.Models.Element();
            obj_DaysOfWeek.DeserializeJson(ref reader, options);
            _DaysOfWeek.Add(obj_DaysOfWeek);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_DaysOfWeek.Count == 0)
          {
            _DaysOfWeek = null;
          }

          break;

        case "openingTime":
          OpeningTime = reader.GetString();
          break;

        case "_openingTime":
          _OpeningTime = new fhirCsR5.Models.Element();
          _OpeningTime.DeserializeJson(ref reader, options);
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
  /// Code Values for the Location.hoursOfOperation.daysOfWeek field
  /// </summary>
  public static class LocationHoursOfOperationDaysOfWeekCodes {
    public const string MON = "mon";
    public const string TUE = "tue";
    public const string WED = "wed";
    public const string THU = "thu";
    public const string FRI = "fri";
    public const string SAT = "sat";
    public const string SUN = "sun";
  }
  /// <summary>
  /// Details and position information for a physical place where services are provided and resources and participants may be stored, found, contained, or accommodated.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<Location>))]
  public class Location : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Location";
    /// <summary>
    /// Additional addresses should be recorded using another instance of the Location resource, or via the Organization.
    /// </summary>
    public Address Address { get; set; }
    /// <summary>
    /// There are no dates associated with the alias/historic names, as this is not intended to track when names were used, but to assist in searching so that older names can still result in identifying the location.
    /// </summary>
    public List<string> Alias { get; set; }
    /// <summary>
    /// Extension container element for Alias
    /// </summary>
    public List<Element> _Alias { get; set; }
    /// <summary>
    /// A description of when the locations opening ours are different to normal, e.g. public holiday availability. Succinctly describing all possible exceptions to normal site availability as detailed in the opening hours Times.
    /// </summary>
    public string AvailabilityExceptions { get; set; }
    /// <summary>
    /// Extension container element for AvailabilityExceptions
    /// </summary>
    public Element _AvailabilityExceptions { get; set; }
    /// <summary>
    /// Description of the Location, which helps in finding or referencing the place.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Technical endpoints providing access to services operated for the location.
    /// </summary>
    public List<Reference> Endpoint { get; set; }
    /// <summary>
    /// This type of information is commonly found published in directories and on websites informing customers when the facility is available.
    /// Specific services within the location may have their own hours which could be shorter (or longer) than the locations hours.
    /// </summary>
    public List<LocationHoursOfOperation> HoursOfOperation { get; set; }
    /// <summary>
    /// Unique code or number identifying the location to its users.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// This can also be used as the part of the organization hierarchy where this location provides services. These services can be defined through the HealthcareService resource.
    /// </summary>
    public Reference ManagingOrganization { get; set; }
    /// <summary>
    /// This is labeled as a modifier because whether or not the location is a class of locations changes how it can be used and understood.
    /// </summary>
    public string Mode { get; set; }
    /// <summary>
    /// Extension container element for Mode
    /// </summary>
    public Element _Mode { get; set; }
    /// <summary>
    /// If the name of a location changes, consider putting the old name in the alias column so that it can still be located through searches.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// The operational status covers operation values most relevant to beds (but can also apply to rooms/units/chairs/etc. such as an isolation unit/dialysis chair). This typically covers concepts such as contamination, housekeeping, and other activities like maintenance.
    /// </summary>
    public Coding OperationalStatus { get; set; }
    /// <summary>
    /// Another Location of which this Location is physically a part of.
    /// </summary>
    public Reference PartOf { get; set; }
    /// <summary>
    /// Physical form of the location, e.g. building, room, vehicle, road.
    /// </summary>
    public CodeableConcept PhysicalType { get; set; }
    /// <summary>
    /// The absolute geographic location of the Location, expressed using the WGS84 datum (This is the same co-ordinate system used in KML).
    /// </summary>
    public LocationPosition Position { get; set; }
    /// <summary>
    /// The status property covers the general availability of the resource, not the current value which may be covered by the operationStatus, or by a schedule/slots if they are configured for the location.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The contact details of communication devices available at the location. This can include phone numbers, fax numbers, mobile numbers, email addresses and web sites.
    /// </summary>
    public List<ContactPoint> Telecom { get; set; }
    /// <summary>
    /// Indicates the type of function performed at the location.
    /// </summary>
    public List<CodeableConcept> Type { get; set; }
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

      if (OperationalStatus != null)
      {
        writer.WritePropertyName("operationalStatus");
        OperationalStatus.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(writer, options);
      }

      if ((Alias != null) && (Alias.Count != 0))
      {
        writer.WritePropertyName("alias");
        writer.WriteStartArray();

        foreach (string valAlias in Alias)
        {
          writer.WriteStringValue(valAlias);
        }

        writer.WriteEndArray();
      }

      if ((_Alias != null) && (_Alias.Count != 0))
      {
        writer.WritePropertyName("_alias");
        writer.WriteStartArray();

        foreach (Element val_Alias in _Alias)
        {
          val_Alias.SerializeJson(writer, options, true);
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

      if (!string.IsNullOrEmpty(Mode))
      {
        writer.WriteString("mode", (string)Mode!);
      }

      if (_Mode != null)
      {
        writer.WritePropertyName("_mode");
        _Mode.SerializeJson(writer, options);
      }

      if ((Type != null) && (Type.Count != 0))
      {
        writer.WritePropertyName("type");
        writer.WriteStartArray();

        foreach (CodeableConcept valType in Type)
        {
          valType.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Telecom != null) && (Telecom.Count != 0))
      {
        writer.WritePropertyName("telecom");
        writer.WriteStartArray();

        foreach (ContactPoint valTelecom in Telecom)
        {
          valTelecom.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Address != null)
      {
        writer.WritePropertyName("address");
        Address.SerializeJson(writer, options);
      }

      if (PhysicalType != null)
      {
        writer.WritePropertyName("physicalType");
        PhysicalType.SerializeJson(writer, options);
      }

      if (Position != null)
      {
        writer.WritePropertyName("position");
        Position.SerializeJson(writer, options);
      }

      if (ManagingOrganization != null)
      {
        writer.WritePropertyName("managingOrganization");
        ManagingOrganization.SerializeJson(writer, options);
      }

      if (PartOf != null)
      {
        writer.WritePropertyName("partOf");
        PartOf.SerializeJson(writer, options);
      }

      if ((HoursOfOperation != null) && (HoursOfOperation.Count != 0))
      {
        writer.WritePropertyName("hoursOfOperation");
        writer.WriteStartArray();

        foreach (LocationHoursOfOperation valHoursOfOperation in HoursOfOperation)
        {
          valHoursOfOperation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(AvailabilityExceptions))
      {
        writer.WriteString("availabilityExceptions", (string)AvailabilityExceptions!);
      }

      if (_AvailabilityExceptions != null)
      {
        writer.WritePropertyName("_availabilityExceptions");
        _AvailabilityExceptions.SerializeJson(writer, options);
      }

      if ((Endpoint != null) && (Endpoint.Count != 0))
      {
        writer.WritePropertyName("endpoint");
        writer.WriteStartArray();

        foreach (Reference valEndpoint in Endpoint)
        {
          valEndpoint.SerializeJson(writer, options, true);
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
        case "address":
          Address = new fhirCsR5.Models.Address();
          Address.DeserializeJson(ref reader, options);
          break;

        case "alias":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Alias = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Alias.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Alias.Count == 0)
          {
            Alias = null;
          }

          break;

        case "_alias":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Alias = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_Alias = new fhirCsR5.Models.Element();
            obj_Alias.DeserializeJson(ref reader, options);
            _Alias.Add(obj_Alias);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Alias.Count == 0)
          {
            _Alias = null;
          }

          break;

        case "availabilityExceptions":
          AvailabilityExceptions = reader.GetString();
          break;

        case "_availabilityExceptions":
          _AvailabilityExceptions = new fhirCsR5.Models.Element();
          _AvailabilityExceptions.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR5.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "endpoint":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Endpoint = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objEndpoint = new fhirCsR5.Models.Reference();
            objEndpoint.DeserializeJson(ref reader, options);
            Endpoint.Add(objEndpoint);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Endpoint.Count == 0)
          {
            Endpoint = null;
          }

          break;

        case "hoursOfOperation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          HoursOfOperation = new List<LocationHoursOfOperation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.LocationHoursOfOperation objHoursOfOperation = new fhirCsR5.Models.LocationHoursOfOperation();
            objHoursOfOperation.DeserializeJson(ref reader, options);
            HoursOfOperation.Add(objHoursOfOperation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (HoursOfOperation.Count == 0)
          {
            HoursOfOperation = null;
          }

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

        case "managingOrganization":
          ManagingOrganization = new fhirCsR5.Models.Reference();
          ManagingOrganization.DeserializeJson(ref reader, options);
          break;

        case "mode":
          Mode = reader.GetString();
          break;

        case "_mode":
          _Mode = new fhirCsR5.Models.Element();
          _Mode.DeserializeJson(ref reader, options);
          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new fhirCsR5.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "operationalStatus":
          OperationalStatus = new fhirCsR5.Models.Coding();
          OperationalStatus.DeserializeJson(ref reader, options);
          break;

        case "partOf":
          PartOf = new fhirCsR5.Models.Reference();
          PartOf.DeserializeJson(ref reader, options);
          break;

        case "physicalType":
          PhysicalType = new fhirCsR5.Models.CodeableConcept();
          PhysicalType.DeserializeJson(ref reader, options);
          break;

        case "position":
          Position = new fhirCsR5.Models.LocationPosition();
          Position.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "telecom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Telecom = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ContactPoint objTelecom = new fhirCsR5.Models.ContactPoint();
            objTelecom.DeserializeJson(ref reader, options);
            Telecom.Add(objTelecom);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Telecom.Count == 0)
          {
            Telecom = null;
          }

          break;

        case "type":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Type = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objType = new fhirCsR5.Models.CodeableConcept();
            objType.DeserializeJson(ref reader, options);
            Type.Add(objType);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Type.Count == 0)
          {
            Type = null;
          }

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
  /// Code Values for the Location.mode field
  /// </summary>
  public static class LocationModeCodes {
    public const string INSTANCE = "instance";
    public const string KIND = "kind";
  }
  /// <summary>
  /// Code Values for the Location.status field
  /// </summary>
  public static class LocationStatusCodes {
    public const string ACTIVE = "active";
    public const string SUSPENDED = "suspended";
    public const string INACTIVE = "inactive";
  }
}
