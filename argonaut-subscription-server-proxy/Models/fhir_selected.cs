/** GENERATED FILE on: 8/12/2019 4:07:19 PM **/

using System;
using System.Collections.Generic;

namespace fhir
{
    ///<summary>
    ///Base StructureDefinition for Address Type: An address expressed using postal conventions (as opposed to GPS or other location definition formats).  This data type may be used to convey addresses for use in delivering mail as well as for visiting locations which might not be valid for mail delivery.  There are a variety of postal address formats defined around the world.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\address.profile.canonical.json</source-file>
    public class Address : Element
    {
        ///<summary>The name of the city, town, suburb, village or other community or delivery center.</summary>
        public string City { get; set; }
        ///<summary>May contain extended information for property: 'City'</summary>
        public Element _City { get; set; }
        ///<summary>Country - a nation as commonly understood or generally accepted.</summary>
        public string Country { get; set; }
        ///<summary>May contain extended information for property: 'Country'</summary>
        public Element _Country { get; set; }
        ///<summary>The name of the administrative area (county).</summary>
        public string District { get; set; }
        ///<summary>May contain extended information for property: 'District'</summary>
        public Element _District { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>This component contains the house number, apartment number, street name, street direction,  P.O. Box number, delivery hints, and similar address information.</summary>
        public string[] Line { get; set; }
        ///<summary>May contain extended information for property: 'Line'</summary>
        public Element[] _Line { get; set; }
        ///<summary>Time period when address was/is in use.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>A postal code designating a region defined by the postal service.</summary>
        public string PostalCode { get; set; }
        ///<summary>May contain extended information for property: 'PostalCode'</summary>
        public Element _PostalCode { get; set; }
        ///<summary>Sub-unit of a country with limited sovereignty in a federally organized country. A code may be used if codes are in common use (e.g. US 2 letter state codes).</summary>
        public string State { get; set; }
        ///<summary>May contain extended information for property: 'State'</summary>
        public Element _State { get; set; }
        ///<summary>Specifies the entire address as it should be displayed e.g. on a postal label. This may be provided instead of or as well as the specific parts.</summary>
        public string Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>Distinguishes between physical addresses (those you can visit) and mailing addresses (e.g. PO Boxes and care-of addresses). Most addresses are both.</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
        ///<summary>The purpose of this address.</summary>
        public string Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Age Type: A duration of time during which an organism (or a process) has existed.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\age.profile.canonical.json</source-file>
    public class Age : Quantity
    {
        ///<summary>A computer processable form of the unit in some unit representation system.</summary>
        public string Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>How the value should be understood and represented - whether the actual value is greater or less than the stated value due to measurement issues; e.g. if the comparator is "<" , then the real value is < stated value.</summary>
        public string Comparator { get; set; }
        ///<summary>May contain extended information for property: 'Comparator'</summary>
        public Element _Comparator { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The identification of the system that provides the coded form of the unit.</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>A human-readable form of the unit.</summary>
        public string Unit { get; set; }
        ///<summary>May contain extended information for property: 'Unit'</summary>
        public Element _Unit { get; set; }
        ///<summary>The value of the measured amount. The value includes an implicit precision in the presentation of the value.</summary>
        public decimal Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Annotation Type: A  text note which also  contains information about who made the statement and when.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\annotation.profile.canonical.json</source-file>
    public class Annotation : Element
    {
        ///<summary>The individual responsible for making the annotation.</summary>
        public Reference AuthorReference { get; set; }
        ///<summary>May contain extended information for property: 'AuthorReference'</summary>
        public Element _AuthorReference { get; set; }
        ///<summary>The individual responsible for making the annotation.</summary>
        public string AuthorString { get; set; }
        ///<summary>May contain extended information for property: 'AuthorString'</summary>
        public Element _AuthorString { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The text of the annotation in markdown format.</summary>
        public string Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>Indicates when this particular annotation was made.</summary>
        public string Time { get; set; }
        ///<summary>May contain extended information for property: 'Time'</summary>
        public Element _Time { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Attachment Type: For referring to data content defined in other formats.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\attachment.profile.canonical.json</source-file>
    public class Attachment : Element
    {
        ///<summary>Identifies the type of the data in the attachment and allows a method to be chosen to interpret or render the data. Includes mime type parameters such as charset where appropriate.</summary>
        public string ContentType { get; set; }
        ///<summary>May contain extended information for property: 'ContentType'</summary>
        public Element _ContentType { get; set; }
        ///<summary>The date that the attachment was first created.</summary>
        public string Creation { get; set; }
        ///<summary>May contain extended information for property: 'Creation'</summary>
        public Element _Creation { get; set; }
        ///<summary>The actual data of the attachment - a sequence of bytes, base64 encoded.</summary>
        public string Data { get; set; }
        ///<summary>May contain extended information for property: 'Data'</summary>
        public Element _Data { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The calculated hash of the data using SHA-1. Represented using base64.</summary>
        public string Hash { get; set; }
        ///<summary>May contain extended information for property: 'Hash'</summary>
        public Element _Hash { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The human language of the content. The value can be any valid value according to BCP 47.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>The number of bytes of data that make up this attachment (before base64 encoding, if that is done).</summary>
        public decimal Size { get; set; }
        ///<summary>May contain extended information for property: 'Size'</summary>
        public Element _Size { get; set; }
        ///<summary>A label or set of text to display in place of the data.</summary>
        public string Title { get; set; }
        ///<summary>May contain extended information for property: 'Title'</summary>
        public Element _Title { get; set; }
        ///<summary>A location where the data can be accessed.</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for BackboneElement Type: Base definition for all elements that are defined inside a resource - but not those in a data type.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\backboneelement.profile.canonical.json</source-file>
    public class BackboneElement : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
    }
    ///<summary>
    ///A container for a collection of resources.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\bundle.profile.canonical.json</source-file>
    public class Bundle : Resource
    {
        ///<summary>Resource Type Name (for serialization)</summary>
        public string ResourceType => "Bundle";
        ///<summary>An entry in a bundle resource - will either contain a resource or information about a resource (transactions and history only).</summary>
        public BundleEntry[] Entry { get; set; }
        ///<summary>May contain extended information for property: 'Entry'</summary>
        public Element[] _Entry { get; set; }
        ///<summary>The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A persistent identifier for the bundle that won't change as a bundle is copied from server to server.</summary>
        public Identifier Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element _Identifier { get; set; }
        ///<summary>A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</summary>
        public string ImplicitRules { get; set; }
        ///<summary>May contain extended information for property: 'ImplicitRules'</summary>
        public Element _ImplicitRules { get; set; }
        ///<summary>The base language in which the resource is written.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>A series of links that provide context to this bundle.</summary>
        public BundleLink[] Link { get; set; }
        ///<summary>May contain extended information for property: 'Link'</summary>
        public Element[] _Link { get; set; }
        ///<summary>The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</summary>
        public Meta Meta { get; set; }
        ///<summary>May contain extended information for property: 'Meta'</summary>
        public Element _Meta { get; set; }
        ///<summary>Digital Signature - base64 encoded. XML-DSig or a JWT.</summary>
        public Signature Signature { get; set; }
        ///<summary>May contain extended information for property: 'Signature'</summary>
        public Element _Signature { get; set; }
        ///<summary>The date/time that the bundle was assembled - i.e. when the resources were placed in the bundle.</summary>
        public string Timestamp { get; set; }
        ///<summary>May contain extended information for property: 'Timestamp'</summary>
        public Element _Timestamp { get; set; }
        ///<summary>If a set of search matches, this is the total number of entries of type 'match' across all pages in the search.  It does not include search.mode = 'include' or 'outcome' entries and it does not provide a count of the number of entries in the Bundle.</summary>
        public decimal Total { get; set; }
        ///<summary>May contain extended information for property: 'Total'</summary>
        public Element _Total { get; set; }
        ///<summary>Indicates the purpose of this bundle - how it is intended to be used.</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///An entry in a bundle resource - will either contain a resource or information about a resource (transactions and history only).
    ///</summary>
    ///<source-file>c:/git/fhir\publish\bundle.profile.canonical.json</source-file>
    public class BundleEntry : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The Absolute URL for the resource.  The fullUrl SHALL NOT disagree with the id in the resource - i.e. if the fullUrl is not a urn:uuid, the URL shall be version-independent URL consistent with the Resource.id. The fullUrl is a version independent reference to the resource. The fullUrl element SHALL have a value except that: 
        /// * fullUrl can be empty on a POST (although it does not need to when specifying a temporary id for reference in the bundle)
        /// * Results from operations might involve resources that are not identified.</summary>
        public string FullUrl { get; set; }
        ///<summary>May contain extended information for property: 'FullUrl'</summary>
        public Element _FullUrl { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A series of links that provide context to this entry.</summary>
        public BundleLink[] Link { get; set; }
        ///<summary>May contain extended information for property: 'Link'</summary>
        public Element[] _Link { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Additional information about how this entry should be processed as part of a transaction or batch.  For history, it shows how the entry was processed to create the version contained in the entry.</summary>
        public BundleEntryRequest Request { get; set; }
        ///<summary>May contain extended information for property: 'Request'</summary>
        public Element _Request { get; set; }
        ///<summary>The Resource for the entry. The purpose/meaning of the resource is determined by the Bundle.type.</summary>
        public Resource Resource { get; set; }
        ///<summary>May contain extended information for property: 'Resource'</summary>
        public Element _Resource { get; set; }
        ///<summary>Indicates the results of processing the corresponding 'request' entry in the batch or transaction being responded to or what the results of an operation where when returning history.</summary>
        public BundleEntryResponse Response { get; set; }
        ///<summary>May contain extended information for property: 'Response'</summary>
        public Element _Response { get; set; }
        ///<summary>Information about the search process that lead to the creation of this entry.</summary>
        public BundleEntrySearch Search { get; set; }
        ///<summary>May contain extended information for property: 'Search'</summary>
        public Element _Search { get; set; }
    }
    ///<summary>
    ///Additional information about how this entry should be processed as part of a transaction or batch.  For history, it shows how the entry was processed to create the version contained in the entry.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\bundle.profile.canonical.json</source-file>
    public class BundleEntryRequest : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Only perform the operation if the Etag value matches. For more information, see the API section ["Managing Resource Contention"](http.html#concurrency).</summary>
        public string IfMatch { get; set; }
        ///<summary>May contain extended information for property: 'IfMatch'</summary>
        public Element _IfMatch { get; set; }
        ///<summary>Only perform the operation if the last updated date matches. See the API documentation for ["Conditional Read"](http.html#cread).</summary>
        public string IfModifiedSince { get; set; }
        ///<summary>May contain extended information for property: 'IfModifiedSince'</summary>
        public Element _IfModifiedSince { get; set; }
        ///<summary>Instruct the server not to perform the create if a specified resource already exists. For further information, see the API documentation for ["Conditional Create"](http.html#ccreate). This is just the query portion of the URL - what follows the "?" (not including the "?").</summary>
        public string IfNoneExist { get; set; }
        ///<summary>May contain extended information for property: 'IfNoneExist'</summary>
        public Element _IfNoneExist { get; set; }
        ///<summary>If the ETag values match, return a 304 Not Modified status. See the API documentation for ["Conditional Read"](http.html#cread).</summary>
        public string IfNoneMatch { get; set; }
        ///<summary>May contain extended information for property: 'IfNoneMatch'</summary>
        public Element _IfNoneMatch { get; set; }
        ///<summary>In a transaction or batch, this is the HTTP action to be executed for this entry. In a history bundle, this indicates the HTTP action that occurred.</summary>
        public string Method { get; set; }
        ///<summary>May contain extended information for property: 'Method'</summary>
        public Element _Method { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The URL for this entry, relative to the root (the address to which the request is posted).</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
    }
    ///<summary>
    ///Indicates the results of processing the corresponding 'request' entry in the batch or transaction being responded to or what the results of an operation where when returning history.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\bundle.profile.canonical.json</source-file>
    public class BundleEntryResponse : Element
    {
        ///<summary>The Etag for the resource, if the operation for the entry produced a versioned resource (see [Resource Metadata and Versioning](http.html#versioning) and [Managing Resource Contention](http.html#concurrency)).</summary>
        public string Etag { get; set; }
        ///<summary>May contain extended information for property: 'Etag'</summary>
        public Element _Etag { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The date/time that the resource was modified on the server.</summary>
        public string LastModified { get; set; }
        ///<summary>May contain extended information for property: 'LastModified'</summary>
        public Element _LastModified { get; set; }
        ///<summary>The location header created by processing this operation, populated if the operation returns a location.</summary>
        public string Location { get; set; }
        ///<summary>May contain extended information for property: 'Location'</summary>
        public Element _Location { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>An OperationOutcome containing hints and warnings produced as part of processing this entry in a batch or transaction.</summary>
        public Resource Outcome { get; set; }
        ///<summary>May contain extended information for property: 'Outcome'</summary>
        public Element _Outcome { get; set; }
        ///<summary>The status code returned by processing this entry. The status SHALL start with a 3 digit HTTP code (e.g. 404) and may contain the standard HTTP description associated with the status code.</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
    }
    ///<summary>
    ///Information about the search process that lead to the creation of this entry.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\bundle.profile.canonical.json</source-file>
    public class BundleEntrySearch : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Why this entry is in the result set - whether it's included as a match or because of an _include requirement, or to convey information or warning information about the search process.</summary>
        public string Mode { get; set; }
        ///<summary>May contain extended information for property: 'Mode'</summary>
        public Element _Mode { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>When searching, the server's search ranking score for the entry.</summary>
        public decimal Score { get; set; }
        ///<summary>May contain extended information for property: 'Score'</summary>
        public Element _Score { get; set; }
    }
    ///<summary>
    ///A series of links that provide context to this bundle.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\bundle.profile.canonical.json</source-file>
    public class BundleLink : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>A name which details the functional use for this link - see [http://www.iana.org/assignments/link-relations/link-relations.xhtml#link-relations-1](http://www.iana.org/assignments/link-relations/link-relations.xhtml#link-relations-1).</summary>
        public string Relation { get; set; }
        ///<summary>May contain extended information for property: 'Relation'</summary>
        public Element _Relation { get; set; }
        ///<summary>The reference details for the link.</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for CodeableConcept Type: A concept that may be defined by a formal reference to a terminology or ontology or may be provided by text.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\codeableconcept.profile.canonical.json</source-file>
    public class CodeableConcept : Element
    {
        ///<summary>A reference to a code defined by a terminology system.</summary>
        public Coding[] Coding { get; set; }
        ///<summary>May contain extended information for property: 'Coding'</summary>
        public Element[] _Coding { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A human language representation of the concept as seen/selected/uttered by the user who entered the data and/or which represents the intended meaning of the user.</summary>
        public string Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Coding Type: A reference to a code defined by a terminology system.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\coding.profile.canonical.json</source-file>
    public class Coding : Element
    {
        ///<summary>A symbol in syntax defined by the system. The symbol may be a predefined code or an expression in a syntax defined by the coding system (e.g. post-coordination).</summary>
        public string Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>A representation of the meaning of the code in the system, following the rules of the system.</summary>
        public string Display { get; set; }
        ///<summary>May contain extended information for property: 'Display'</summary>
        public Element _Display { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The identification of the code system that defines the meaning of the symbol in the code.</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>Indicates that this coding was chosen by a user directly - e.g. off a pick list of available items (codes or displays).</summary>
        public bool UserSelected { get; set; }
        ///<summary>May contain extended information for property: 'UserSelected'</summary>
        public Element _UserSelected { get; set; }
        ///<summary>The version of the code system which was used when choosing this code. Note that a well-maintained code system does not need the version reported, because the meaning of codes is consistent across versions. However this cannot consistently be assured, and when the meaning is not guaranteed to be consistent, the version SHOULD be exchanged.</summary>
        public string Version { get; set; }
        ///<summary>May contain extended information for property: 'Version'</summary>
        public Element _Version { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for ContactDetail Type: Specifies contact information for a person or organization.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\contactdetail.profile.canonical.json</source-file>
    public class ContactDetail : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The name of an individual to contact.</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>The contact details for the individual (if a name was provided) or the organization.</summary>
        public ContactPoint[] Telecom { get; set; }
        ///<summary>May contain extended information for property: 'Telecom'</summary>
        public Element[] _Telecom { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for ContactPoint Type: Details for all kinds of technology mediated contact points for a person or organization, including telephone, email, etc.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\contactpoint.profile.canonical.json</source-file>
    public class ContactPoint : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Time period when the contact point was/is in use.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>Specifies a preferred order in which to use a set of contacts. ContactPoints with lower rank values are more preferred than those with higher rank values.</summary>
        public decimal Rank { get; set; }
        ///<summary>May contain extended information for property: 'Rank'</summary>
        public Element _Rank { get; set; }
        ///<summary>Telecommunications form for contact point - what communications system is required to make use of the contact.</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>Identifies the purpose for the contact point.</summary>
        public string Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
        ///<summary>The actual contact point details, in a form that is meaningful to the designated communication system (i.e. phone number or email address).</summary>
        public string Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Contributor Type: A contributor to the content of a knowledge asset, including authors, editors, reviewers, and endorsers.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\contributor.profile.canonical.json</source-file>
    public class Contributor : Element
    {
        ///<summary>Contact details to assist a user in finding and communicating with the contributor.</summary>
        public ContactDetail[] Contact { get; set; }
        ///<summary>May contain extended information for property: 'Contact'</summary>
        public Element[] _Contact { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The name of the individual or organization responsible for the contribution.</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>The type of contributor.</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Count Type: A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\count.profile.canonical.json</source-file>
    public class Count : Quantity
    {
        ///<summary>A computer processable form of the unit in some unit representation system.</summary>
        public string Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>How the value should be understood and represented - whether the actual value is greater or less than the stated value due to measurement issues; e.g. if the comparator is "<" , then the real value is < stated value.</summary>
        public string Comparator { get; set; }
        ///<summary>May contain extended information for property: 'Comparator'</summary>
        public Element _Comparator { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The identification of the system that provides the coded form of the unit.</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>A human-readable form of the unit.</summary>
        public string Unit { get; set; }
        ///<summary>May contain extended information for property: 'Unit'</summary>
        public Element _Unit { get; set; }
        ///<summary>The value of the measured amount. The value includes an implicit precision in the presentation of the value.</summary>
        public decimal Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for DataRequirement Type: Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\datarequirement.profile.canonical.json</source-file>
    public class DataRequirement : Element
    {
        ///<summary>Code filters specify additional constraints on the data, specifying the value set of interest for a particular element of the data. Each code filter defines an additional constraint on the data, i.e. code filters are AND'ed, not OR'ed.</summary>
        public DataRequirementCodeFilter[] CodeFilter { get; set; }
        ///<summary>May contain extended information for property: 'CodeFilter'</summary>
        public Element[] _CodeFilter { get; set; }
        ///<summary>Date filters specify additional constraints on the data in terms of the applicable date range for specific elements. Each date filter specifies an additional constraint on the data, i.e. date filters are AND'ed, not OR'ed.</summary>
        public DataRequirementDateFilter[] DateFilter { get; set; }
        ///<summary>May contain extended information for property: 'DateFilter'</summary>
        public Element[] _DateFilter { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Specifies a maximum number of results that are required (uses the _count search parameter).</summary>
        public decimal Limit { get; set; }
        ///<summary>May contain extended information for property: 'Limit'</summary>
        public Element _Limit { get; set; }
        ///<summary>Indicates that specific elements of the type are referenced by the knowledge module and must be supported by the consumer in order to obtain an effective evaluation. This does not mean that a value is required for this element, only that the consuming system must understand the element and be able to provide values for it if they are available. 
        /// 
        /// The value of mustSupport SHALL be a FHIRPath resolveable on the type of the DataRequirement. The path SHALL consist only of identifiers, constant indexers, and .resolve() (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details).</summary>
        public string[] MustSupport { get; set; }
        ///<summary>May contain extended information for property: 'MustSupport'</summary>
        public Element[] _MustSupport { get; set; }
        ///<summary>The profile of the required data, specified as the uri of the profile definition.</summary>
        public string[] Profile { get; set; }
        ///<summary>May contain extended information for property: 'Profile'</summary>
        public Element[] _Profile { get; set; }
        ///<summary>Specifies the order of the results to be returned.</summary>
        public DataRequirementSort[] Sort { get; set; }
        ///<summary>May contain extended information for property: 'Sort'</summary>
        public Element[] _Sort { get; set; }
        ///<summary>The intended subjects of the data requirement. If this element is not provided, a Patient subject is assumed.</summary>
        public CodeableConcept SubjectCodeableConcept { get; set; }
        ///<summary>May contain extended information for property: 'SubjectCodeableConcept'</summary>
        public Element _SubjectCodeableConcept { get; set; }
        ///<summary>The intended subjects of the data requirement. If this element is not provided, a Patient subject is assumed.</summary>
        public Reference SubjectReference { get; set; }
        ///<summary>May contain extended information for property: 'SubjectReference'</summary>
        public Element _SubjectReference { get; set; }
        ///<summary>The type of the required data, specified as the type name of a resource. For profiles, this value is set to the type of the base resource of the profile.</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Code filters specify additional constraints on the data, specifying the value set of interest for a particular element of the data. Each code filter defines an additional constraint on the data, i.e. code filters are AND'ed, not OR'ed.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\datarequirement.profile.canonical.json</source-file>
    public class DataRequirementCodeFilter : Element
    {
        ///<summary>The codes for the code filter. If values are given, the filter will return only those data items for which the code-valued attribute specified by the path has a value that is one of the specified codes. If codes are specified in addition to a value set, the filter returns items matching a code in the value set or one of the specified codes.</summary>
        public Coding[] Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element[] _Code { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The code-valued attribute of the filter. The specified path SHALL be a FHIRPath resolveable on the specified type of the DataRequirement, and SHALL consist only of identifiers, constant indexers, and .resolve(). The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details). Note that the index must be an integer constant. The path must resolve to an element of type code, Coding, or CodeableConcept.</summary>
        public string Path { get; set; }
        ///<summary>May contain extended information for property: 'Path'</summary>
        public Element _Path { get; set; }
        ///<summary>A token parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type code, Coding, or CodeableConcept.</summary>
        public string SearchParam { get; set; }
        ///<summary>May contain extended information for property: 'SearchParam'</summary>
        public Element _SearchParam { get; set; }
        ///<summary>The valueset for the code filter. The valueSet and code elements are additive. If valueSet is specified, the filter will return only those data items for which the value of the code-valued element specified in the path is a member of the specified valueset.</summary>
        public string ValueSet { get; set; }
        ///<summary>May contain extended information for property: 'ValueSet'</summary>
        public Element _ValueSet { get; set; }
    }
    ///<summary>
    ///Date filters specify additional constraints on the data in terms of the applicable date range for specific elements. Each date filter specifies an additional constraint on the data, i.e. date filters are AND'ed, not OR'ed.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\datarequirement.profile.canonical.json</source-file>
    public class DataRequirementDateFilter : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The date-valued attribute of the filter. The specified path SHALL be a FHIRPath resolveable on the specified type of the DataRequirement, and SHALL consist only of identifiers, constant indexers, and .resolve(). The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details). Note that the index must be an integer constant. The path must resolve to an element of type date, dateTime, Period, Schedule, or Timing.</summary>
        public string Path { get; set; }
        ///<summary>May contain extended information for property: 'Path'</summary>
        public Element _Path { get; set; }
        ///<summary>A date parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type date, dateTime, Period, Schedule, or Timing.</summary>
        public string SearchParam { get; set; }
        ///<summary>May contain extended information for property: 'SearchParam'</summary>
        public Element _SearchParam { get; set; }
        ///<summary>The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now.</summary>
        public string ValueDateTime { get; set; }
        ///<summary>May contain extended information for property: 'ValueDateTime'</summary>
        public Element _ValueDateTime { get; set; }
        ///<summary>The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now.</summary>
        public Duration ValueDuration { get; set; }
        ///<summary>May contain extended information for property: 'ValueDuration'</summary>
        public Element _ValueDuration { get; set; }
        ///<summary>The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now.</summary>
        public Period ValuePeriod { get; set; }
        ///<summary>May contain extended information for property: 'ValuePeriod'</summary>
        public Element _ValuePeriod { get; set; }
    }
    ///<summary>
    ///Specifies the order of the results to be returned.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\datarequirement.profile.canonical.json</source-file>
    public class DataRequirementSort : Element
    {
        ///<summary>The direction of the sort, ascending or descending.</summary>
        public string Direction { get; set; }
        ///<summary>May contain extended information for property: 'Direction'</summary>
        public Element _Direction { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The attribute of the sort. The specified path must be resolvable from the type of the required data. The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements. Note that the index must be an integer constant.</summary>
        public string Path { get; set; }
        ///<summary>May contain extended information for property: 'Path'</summary>
        public Element _Path { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Distance Type: A length - a value with a unit that is a physical distance.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\distance.profile.canonical.json</source-file>
    public class Distance : Quantity
    {
        ///<summary>A computer processable form of the unit in some unit representation system.</summary>
        public string Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>How the value should be understood and represented - whether the actual value is greater or less than the stated value due to measurement issues; e.g. if the comparator is "<" , then the real value is < stated value.</summary>
        public string Comparator { get; set; }
        ///<summary>May contain extended information for property: 'Comparator'</summary>
        public Element _Comparator { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The identification of the system that provides the coded form of the unit.</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>A human-readable form of the unit.</summary>
        public string Unit { get; set; }
        ///<summary>May contain extended information for property: 'Unit'</summary>
        public Element _Unit { get; set; }
        ///<summary>The value of the measured amount. The value includes an implicit precision in the presentation of the value.</summary>
        public decimal Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///A resource that includes narrative, extensions, and contained resources.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\domainresource.profile.canonical.json</source-file>
    public class DomainResource : Resource
    {
        ///<summary>These resources do not have an independent existence apart from the resource that contains them - they cannot be identified independently, and nor can they have their own independent transaction scope.</summary>
        public Resource[] Contained { get; set; }
        ///<summary>May contain extended information for property: 'Contained'</summary>
        public Element[] _Contained { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</summary>
        public string ImplicitRules { get; set; }
        ///<summary>May contain extended information for property: 'ImplicitRules'</summary>
        public Element _ImplicitRules { get; set; }
        ///<summary>The base language in which the resource is written.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</summary>
        public Meta Meta { get; set; }
        ///<summary>May contain extended information for property: 'Meta'</summary>
        public Element _Meta { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource and that modifies the understanding of the element that contains it and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer is allowed to define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>A human-readable narrative that contains a summary of the resource and can be used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it "clinically safe" for a human to just read the narrative. Resource definitions may define what content should be represented in the narrative to ensure clinical safety.</summary>
        public Narrative Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Dosage Type: Indicates how the medication is/was taken or should be taken by the patient.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\dosage.profile.canonical.json</source-file>
    public class Dosage : BackboneElement
    {
        ///<summary>Supplemental instructions to the patient on how to take the medication  (e.g. "with meals" or"take half to one hour before food") or warnings for the patient about the medication (e.g. "may cause drowsiness" or "avoid exposure of skin to direct sunlight or sunlamps").</summary>
        public CodeableConcept[] AdditionalInstruction { get; set; }
        ///<summary>May contain extended information for property: 'AdditionalInstruction'</summary>
        public Element[] _AdditionalInstruction { get; set; }
        ///<summary>Indicates whether the Medication is only taken when needed within a specific dosing schedule (Boolean option), or it indicates the precondition for taking the Medication (CodeableConcept).</summary>
        public bool AsNeededBoolean { get; set; }
        ///<summary>May contain extended information for property: 'AsNeededBoolean'</summary>
        public Element _AsNeededBoolean { get; set; }
        ///<summary>Indicates whether the Medication is only taken when needed within a specific dosing schedule (Boolean option), or it indicates the precondition for taking the Medication (CodeableConcept).</summary>
        public CodeableConcept AsNeededCodeableConcept { get; set; }
        ///<summary>May contain extended information for property: 'AsNeededCodeableConcept'</summary>
        public Element _AsNeededCodeableConcept { get; set; }
        ///<summary>The amount of medication administered.</summary>
        public DosageDoseAndRate[] DoseAndRate { get; set; }
        ///<summary>May contain extended information for property: 'DoseAndRate'</summary>
        public Element[] _DoseAndRate { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Upper limit on medication per administration.</summary>
        public Quantity MaxDosePerAdministration { get; set; }
        ///<summary>May contain extended information for property: 'MaxDosePerAdministration'</summary>
        public Element _MaxDosePerAdministration { get; set; }
        ///<summary>Upper limit on medication per lifetime of the patient.</summary>
        public Quantity MaxDosePerLifetime { get; set; }
        ///<summary>May contain extended information for property: 'MaxDosePerLifetime'</summary>
        public Element _MaxDosePerLifetime { get; set; }
        ///<summary>Upper limit on medication per unit of time.</summary>
        public Ratio MaxDosePerPeriod { get; set; }
        ///<summary>May contain extended information for property: 'MaxDosePerPeriod'</summary>
        public Element _MaxDosePerPeriod { get; set; }
        ///<summary>Technique for administering medication.</summary>
        public CodeableConcept Method { get; set; }
        ///<summary>May contain extended information for property: 'Method'</summary>
        public Element _Method { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Instructions in terms that are understood by the patient or consumer.</summary>
        public string PatientInstruction { get; set; }
        ///<summary>May contain extended information for property: 'PatientInstruction'</summary>
        public Element _PatientInstruction { get; set; }
        ///<summary>How drug should enter body.</summary>
        public CodeableConcept Route { get; set; }
        ///<summary>May contain extended information for property: 'Route'</summary>
        public Element _Route { get; set; }
        ///<summary>Indicates the order in which the dosage instructions should be applied or interpreted.</summary>
        public decimal Sequence { get; set; }
        ///<summary>May contain extended information for property: 'Sequence'</summary>
        public Element _Sequence { get; set; }
        ///<summary>Body site to administer to.</summary>
        public CodeableConcept Site { get; set; }
        ///<summary>May contain extended information for property: 'Site'</summary>
        public Element _Site { get; set; }
        ///<summary>Free text dosage instructions e.g. SIG.</summary>
        public string Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>When medication should be administered.</summary>
        public Timing Timing { get; set; }
        ///<summary>May contain extended information for property: 'Timing'</summary>
        public Element _Timing { get; set; }
    }
    ///<summary>
    ///The amount of medication administered.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\dosage.profile.canonical.json</source-file>
    public class DosageDoseAndRate : Element
    {
        ///<summary>Amount of medication per dose.</summary>
        public Quantity DoseQuantity { get; set; }
        ///<summary>May contain extended information for property: 'DoseQuantity'</summary>
        public Element _DoseQuantity { get; set; }
        ///<summary>Amount of medication per dose.</summary>
        public Range DoseRange { get; set; }
        ///<summary>May contain extended information for property: 'DoseRange'</summary>
        public Element _DoseRange { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Amount of medication per unit of time.</summary>
        public Quantity RateQuantity { get; set; }
        ///<summary>May contain extended information for property: 'RateQuantity'</summary>
        public Element _RateQuantity { get; set; }
        ///<summary>Amount of medication per unit of time.</summary>
        public Range RateRange { get; set; }
        ///<summary>May contain extended information for property: 'RateRange'</summary>
        public Element _RateRange { get; set; }
        ///<summary>Amount of medication per unit of time.</summary>
        public Ratio RateRatio { get; set; }
        ///<summary>May contain extended information for property: 'RateRatio'</summary>
        public Element _RateRatio { get; set; }
        ///<summary>The kind of dose or rate specified, for example, ordered or calculated.</summary>
        public CodeableConcept Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Duration Type: A length of time.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\duration.profile.canonical.json</source-file>
    public class Duration : Quantity
    {
        ///<summary>A computer processable form of the unit in some unit representation system.</summary>
        public string Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>How the value should be understood and represented - whether the actual value is greater or less than the stated value due to measurement issues; e.g. if the comparator is "<" , then the real value is < stated value.</summary>
        public string Comparator { get; set; }
        ///<summary>May contain extended information for property: 'Comparator'</summary>
        public Element _Comparator { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The identification of the system that provides the coded form of the unit.</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>A human-readable form of the unit.</summary>
        public string Unit { get; set; }
        ///<summary>May contain extended information for property: 'Unit'</summary>
        public Element _Unit { get; set; }
        ///<summary>The value of the measured amount. The value includes an implicit precision in the presentation of the value.</summary>
        public decimal Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Element Type: Base definition for all elements in a resource.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\element.profile.canonical.json</source-file>
    public class Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
    }
    ///<summary>
    ///An interaction between a patient and healthcare provider(s) for the purpose of providing healthcare service(s) or assessing the health status of a patient.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\encounter.profile.canonical.json</source-file>
    public class Encounter : DomainResource
    {
        ///<summary>Resource Type Name (for serialization)</summary>
        public string ResourceType => "Encounter";
        ///<summary>The set of accounts that may be used for billing for this Encounter.</summary>
        public Reference[] Account { get; set; }
        ///<summary>May contain extended information for property: 'Account'</summary>
        public Element[] _Account { get; set; }
        ///<summary>The appointment that scheduled this encounter.</summary>
        public Reference[] Appointment { get; set; }
        ///<summary>May contain extended information for property: 'Appointment'</summary>
        public Element[] _Appointment { get; set; }
        ///<summary>The request this encounter satisfies (e.g. incoming referral or procedure request).</summary>
        public Reference[] BasedOn { get; set; }
        ///<summary>May contain extended information for property: 'BasedOn'</summary>
        public Element[] _BasedOn { get; set; }
        ///<summary>Concepts representing classification of patient encounter such as ambulatory (outpatient), inpatient, emergency, home health or others due to local variations.</summary>
        public Coding Class { get; set; }
        ///<summary>May contain extended information for property: 'Class'</summary>
        public Element _Class { get; set; }
        ///<summary>The class history permits the tracking of the encounters transitions without needing to go  through the resource history.  This would be used for a case where an admission starts of as an emergency encounter, then transitions into an inpatient scenario. Doing this and not restarting a new encounter ensures that any lab/diagnostic results can more easily follow the patient and not require re-processing and not get lost or cancelled during a kind of discharge from emergency to inpatient.</summary>
        public EncounterClassHistory[] ClassHistory { get; set; }
        ///<summary>May contain extended information for property: 'ClassHistory'</summary>
        public Element[] _ClassHistory { get; set; }
        ///<summary>These resources do not have an independent existence apart from the resource that contains them - they cannot be identified independently, and nor can they have their own independent transaction scope.</summary>
        public Resource[] Contained { get; set; }
        ///<summary>May contain extended information for property: 'Contained'</summary>
        public Element[] _Contained { get; set; }
        ///<summary>The list of diagnosis relevant to this encounter.</summary>
        public EncounterDiagnosis[] Diagnosis { get; set; }
        ///<summary>May contain extended information for property: 'Diagnosis'</summary>
        public Element[] _Diagnosis { get; set; }
        ///<summary>Where a specific encounter should be classified as a part of a specific episode(s) of care this field should be used. This association can facilitate grouping of related encounters together for a specific purpose, such as government reporting, issue tracking, association via a common problem.  The association is recorded on the encounter as these are typically created after the episode of care and grouped on entry rather than editing the episode of care to append another encounter to it (the episode of care could span years).</summary>
        public Reference[] EpisodeOfCare { get; set; }
        ///<summary>May contain extended information for property: 'EpisodeOfCare'</summary>
        public Element[] _EpisodeOfCare { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Details about the admission to a healthcare service.</summary>
        public EncounterHospitalization Hospitalization { get; set; }
        ///<summary>May contain extended information for property: 'Hospitalization'</summary>
        public Element _Hospitalization { get; set; }
        ///<summary>The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Identifier(s) by which this encounter is known.</summary>
        public Identifier[] Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element[] _Identifier { get; set; }
        ///<summary>A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</summary>
        public string ImplicitRules { get; set; }
        ///<summary>May contain extended information for property: 'ImplicitRules'</summary>
        public Element _ImplicitRules { get; set; }
        ///<summary>The base language in which the resource is written.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>Quantity of time the encounter lasted. This excludes the time during leaves of absence.</summary>
        public Duration Length { get; set; }
        ///<summary>May contain extended information for property: 'Length'</summary>
        public Element _Length { get; set; }
        ///<summary>List of locations where  the patient has been during this encounter.</summary>
        public EncounterLocation[] Location { get; set; }
        ///<summary>May contain extended information for property: 'Location'</summary>
        public Element[] _Location { get; set; }
        ///<summary>The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</summary>
        public Meta Meta { get; set; }
        ///<summary>May contain extended information for property: 'Meta'</summary>
        public Element _Meta { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource and that modifies the understanding of the element that contains it and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer is allowed to define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The list of people responsible for providing the service.</summary>
        public EncounterParticipant[] Participant { get; set; }
        ///<summary>May contain extended information for property: 'Participant'</summary>
        public Element[] _Participant { get; set; }
        ///<summary>Another Encounter of which this encounter is a part of (administratively or in time).</summary>
        public Reference PartOf { get; set; }
        ///<summary>May contain extended information for property: 'PartOf'</summary>
        public Element _PartOf { get; set; }
        ///<summary>The start and end time of the encounter.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>Indicates the urgency of the encounter.</summary>
        public CodeableConcept Priority { get; set; }
        ///<summary>May contain extended information for property: 'Priority'</summary>
        public Element _Priority { get; set; }
        ///<summary>Reason the encounter takes place, expressed as a code. For admissions, this can be used for a coded admission diagnosis.</summary>
        public CodeableConcept[] ReasonCode { get; set; }
        ///<summary>May contain extended information for property: 'ReasonCode'</summary>
        public Element[] _ReasonCode { get; set; }
        ///<summary>Reason the encounter takes place, expressed as a code. For admissions, this can be used for a coded admission diagnosis.</summary>
        public Reference[] ReasonReference { get; set; }
        ///<summary>May contain extended information for property: 'ReasonReference'</summary>
        public Element[] _ReasonReference { get; set; }
        ///<summary>The organization that is primarily responsible for this Encounter's services. This MAY be the same as the organization on the Patient record, however it could be different, such as if the actor performing the services was from an external organization (which may be billed seperately) for an external consultation.  Refer to the example bundle showing an abbreviated set of Encounters for a colonoscopy.</summary>
        public Reference ServiceProvider { get; set; }
        ///<summary>May contain extended information for property: 'ServiceProvider'</summary>
        public Element _ServiceProvider { get; set; }
        ///<summary>Broad categorization of the service that is to be provided (e.g. cardiology).</summary>
        public CodeableConcept ServiceType { get; set; }
        ///<summary>May contain extended information for property: 'ServiceType'</summary>
        public Element _ServiceType { get; set; }
        ///<summary>planned | in-progress | onhold | completed | cancelled | entered-in-error | unknown.</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
        ///<summary>The status history permits the encounter resource to contain the status history without needing to read through the historical versions of the resource, or even have the server store them.</summary>
        public EncounterStatusHistory[] StatusHistory { get; set; }
        ///<summary>May contain extended information for property: 'StatusHistory'</summary>
        public Element[] _StatusHistory { get; set; }
        ///<summary>The patient or group present at the encounter.</summary>
        public Reference Subject { get; set; }
        ///<summary>May contain extended information for property: 'Subject'</summary>
        public Element _Subject { get; set; }
        ///<summary>The subjectStatus value can be used to track the patient's status within the encounter. It details whether the patient has arrived or departed, has been triaged or is currently in a waiting status.</summary>
        public CodeableConcept SubjectStatus { get; set; }
        ///<summary>May contain extended information for property: 'SubjectStatus'</summary>
        public Element _SubjectStatus { get; set; }
        ///<summary>A human-readable narrative that contains a summary of the resource and can be used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it "clinically safe" for a human to just read the narrative. Resource definitions may define what content should be represented in the narrative to ensure clinical safety.</summary>
        public Narrative Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>Specific type of encounter (e.g. e-mail consultation, surgical day-care, skilled nursing, rehabilitation).</summary>
        public CodeableConcept[] Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element[] _Type { get; set; }
    }
    ///<summary>
    ///The class history permits the tracking of the encounters transitions without needing to go  through the resource history.  This would be used for a case where an admission starts of as an emergency encounter, then transitions into an inpatient scenario. Doing this and not restarting a new encounter ensures that any lab/diagnostic results can more easily follow the patient and not require re-processing and not get lost or cancelled during a kind of discharge from emergency to inpatient.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\encounter.profile.canonical.json</source-file>
    public class EncounterClassHistory : Element
    {
        ///<summary>inpatient | outpatient | ambulatory | emergency +.</summary>
        public Coding Class { get; set; }
        ///<summary>May contain extended information for property: 'Class'</summary>
        public Element _Class { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The time that the episode was in the specified class.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
    }
    ///<summary>
    ///The list of diagnosis relevant to this encounter.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\encounter.profile.canonical.json</source-file>
    public class EncounterDiagnosis : Element
    {
        ///<summary>Reason the encounter takes place, as specified using information from another resource. For admissions, this is the admission diagnosis. The indication will typically be a Condition (with other resources referenced in the evidence.detail), or a Procedure.</summary>
        public Reference Condition { get; set; }
        ///<summary>May contain extended information for property: 'Condition'</summary>
        public Element _Condition { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Ranking of the diagnosis (for each role type).</summary>
        public decimal Rank { get; set; }
        ///<summary>May contain extended information for property: 'Rank'</summary>
        public Element _Rank { get; set; }
        ///<summary>Role that this diagnosis has within the encounter (e.g. admission, billing, discharge …).</summary>
        public CodeableConcept Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
    }
    ///<summary>
    ///Details about the admission to a healthcare service.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\encounter.profile.canonical.json</source-file>
    public class EncounterHospitalization : Element
    {
        ///<summary>From where patient was admitted (physician referral, transfer).</summary>
        public CodeableConcept AdmitSource { get; set; }
        ///<summary>May contain extended information for property: 'AdmitSource'</summary>
        public Element _AdmitSource { get; set; }
        ///<summary>Location/organization to which the patient is discharged.</summary>
        public Reference Destination { get; set; }
        ///<summary>May contain extended information for property: 'Destination'</summary>
        public Element _Destination { get; set; }
        ///<summary>Diet preferences reported by the patient.</summary>
        public CodeableConcept[] DietPreference { get; set; }
        ///<summary>May contain extended information for property: 'DietPreference'</summary>
        public Element[] _DietPreference { get; set; }
        ///<summary>Category or kind of location after discharge.</summary>
        public CodeableConcept DischargeDisposition { get; set; }
        ///<summary>May contain extended information for property: 'DischargeDisposition'</summary>
        public Element _DischargeDisposition { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The location/organization from which the patient came before admission.</summary>
        public Reference Origin { get; set; }
        ///<summary>May contain extended information for property: 'Origin'</summary>
        public Element _Origin { get; set; }
        ///<summary>Pre-admission identifier.</summary>
        public Identifier PreAdmissionIdentifier { get; set; }
        ///<summary>May contain extended information for property: 'PreAdmissionIdentifier'</summary>
        public Element _PreAdmissionIdentifier { get; set; }
        ///<summary>Whether this hospitalization is a readmission and why if known.</summary>
        public CodeableConcept ReAdmission { get; set; }
        ///<summary>May contain extended information for property: 'ReAdmission'</summary>
        public Element _ReAdmission { get; set; }
        ///<summary>Any special requests that have been made for this hospitalization encounter, such as the provision of specific equipment or other things.</summary>
        public CodeableConcept[] SpecialArrangement { get; set; }
        ///<summary>May contain extended information for property: 'SpecialArrangement'</summary>
        public Element[] _SpecialArrangement { get; set; }
        ///<summary>Special courtesies (VIP, board member).</summary>
        public CodeableConcept[] SpecialCourtesy { get; set; }
        ///<summary>May contain extended information for property: 'SpecialCourtesy'</summary>
        public Element[] _SpecialCourtesy { get; set; }
    }
    ///<summary>
    ///List of locations where  the patient has been during this encounter.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\encounter.profile.canonical.json</source-file>
    public class EncounterLocation : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The location where the encounter takes place.</summary>
        public Reference Location { get; set; }
        ///<summary>May contain extended information for property: 'Location'</summary>
        public Element _Location { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Time period during which the patient was present at the location.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>This will be used to specify the required levels (bed/ward/room/etc.) desired to be recorded to simplify either messaging or query.</summary>
        public CodeableConcept PhysicalType { get; set; }
        ///<summary>May contain extended information for property: 'PhysicalType'</summary>
        public Element _PhysicalType { get; set; }
        ///<summary>The status of the participants' presence at the specified location during the period specified. If the participant is no longer at the location, then the period will have an end date/time.</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
    }
    ///<summary>
    ///The list of people responsible for providing the service.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\encounter.profile.canonical.json</source-file>
    public class EncounterParticipant : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Persons involved in the encounter other than the patient.</summary>
        public Reference Individual { get; set; }
        ///<summary>May contain extended information for property: 'Individual'</summary>
        public Element _Individual { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The period of time that the specified participant participated in the encounter. These can overlap or be sub-sets of the overall encounter's period.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>Role of participant in encounter.</summary>
        public CodeableConcept[] Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element[] _Type { get; set; }
    }
    ///<summary>
    ///The status history permits the encounter resource to contain the status history without needing to read through the historical versions of the resource, or even have the server store them.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\encounter.profile.canonical.json</source-file>
    public class EncounterStatusHistory : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The time that the episode was in the specified status.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>planned | in-progress | onhold | completed | cancelled | entered-in-error | unknown.</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Expression Type: A expression that is evaluated in a specified context and returns a value. The context of use of the expression must specify the context in which the expression is evaluated, and how the result of the expression is used.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\expression.profile.canonical.json</source-file>
    public class Expression : Element
    {
        ///<summary>A brief, natural language description of the condition that effectively communicates the intended semantics.</summary>
        public string Description { get; set; }
        ///<summary>May contain extended information for property: 'Description'</summary>
        public Element _Description { get; set; }
        ///<summary>An expression in the specified language that returns a value.</summary>
        public string expression { get; set; }
        ///<summary>May contain extended information for property: 'expression'</summary>
        public Element _expression { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The media type of the language for the expression.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>A short name assigned to the expression to allow for multiple reuse of the expression in the context where it is defined.</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>A URI that defines where the expression is found.</summary>
        public string Reference { get; set; }
        ///<summary>May contain extended information for property: 'Reference'</summary>
        public Element _Reference { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Extension Type: Optional Extension Element - found in all resources.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\extension.profile.canonical.json</source-file>
    public class Extension : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] extension { get; set; }
        ///<summary>May contain extended information for property: 'extension'</summary>
        public Element[] _extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Source of the definition for the extension code - a logical name or a URL.</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Address ValueAddress { get; set; }
        ///<summary>May contain extended information for property: 'ValueAddress'</summary>
        public Element _ValueAddress { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Age ValueAge { get; set; }
        ///<summary>May contain extended information for property: 'ValueAge'</summary>
        public Element _ValueAge { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Annotation ValueAnnotation { get; set; }
        ///<summary>May contain extended information for property: 'ValueAnnotation'</summary>
        public Element _ValueAnnotation { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Attachment ValueAttachment { get; set; }
        ///<summary>May contain extended information for property: 'ValueAttachment'</summary>
        public Element _ValueAttachment { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueBase64Binary { get; set; }
        ///<summary>May contain extended information for property: 'ValueBase64Binary'</summary>
        public Element _ValueBase64Binary { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public bool ValueBoolean { get; set; }
        ///<summary>May contain extended information for property: 'ValueBoolean'</summary>
        public Element _ValueBoolean { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueCanonical { get; set; }
        ///<summary>May contain extended information for property: 'ValueCanonical'</summary>
        public Element _ValueCanonical { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueCode { get; set; }
        ///<summary>May contain extended information for property: 'ValueCode'</summary>
        public Element _ValueCode { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public CodeableConcept ValueCodeableConcept { get; set; }
        ///<summary>May contain extended information for property: 'ValueCodeableConcept'</summary>
        public Element _ValueCodeableConcept { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Coding ValueCoding { get; set; }
        ///<summary>May contain extended information for property: 'ValueCoding'</summary>
        public Element _ValueCoding { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public ContactDetail ValueContactDetail { get; set; }
        ///<summary>May contain extended information for property: 'ValueContactDetail'</summary>
        public Element _ValueContactDetail { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public ContactPoint ValueContactPoint { get; set; }
        ///<summary>May contain extended information for property: 'ValueContactPoint'</summary>
        public Element _ValueContactPoint { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Contributor ValueContributor { get; set; }
        ///<summary>May contain extended information for property: 'ValueContributor'</summary>
        public Element _ValueContributor { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Count ValueCount { get; set; }
        ///<summary>May contain extended information for property: 'ValueCount'</summary>
        public Element _ValueCount { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public DataRequirement ValueDataRequirement { get; set; }
        ///<summary>May contain extended information for property: 'ValueDataRequirement'</summary>
        public Element _ValueDataRequirement { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueDate { get; set; }
        ///<summary>May contain extended information for property: 'ValueDate'</summary>
        public Element _ValueDate { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueDateTime { get; set; }
        ///<summary>May contain extended information for property: 'ValueDateTime'</summary>
        public Element _ValueDateTime { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public decimal ValueDecimal { get; set; }
        ///<summary>May contain extended information for property: 'ValueDecimal'</summary>
        public Element _ValueDecimal { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Distance ValueDistance { get; set; }
        ///<summary>May contain extended information for property: 'ValueDistance'</summary>
        public Element _ValueDistance { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Dosage ValueDosage { get; set; }
        ///<summary>May contain extended information for property: 'ValueDosage'</summary>
        public Element _ValueDosage { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Duration ValueDuration { get; set; }
        ///<summary>May contain extended information for property: 'ValueDuration'</summary>
        public Element _ValueDuration { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Expression ValueExpression { get; set; }
        ///<summary>May contain extended information for property: 'ValueExpression'</summary>
        public Element _ValueExpression { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public HumanName ValueHumanName { get; set; }
        ///<summary>May contain extended information for property: 'ValueHumanName'</summary>
        public Element _ValueHumanName { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueId { get; set; }
        ///<summary>May contain extended information for property: 'ValueId'</summary>
        public Element _ValueId { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Identifier ValueIdentifier { get; set; }
        ///<summary>May contain extended information for property: 'ValueIdentifier'</summary>
        public Element _ValueIdentifier { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueInstant { get; set; }
        ///<summary>May contain extended information for property: 'ValueInstant'</summary>
        public Element _ValueInstant { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public decimal ValueInteger { get; set; }
        ///<summary>May contain extended information for property: 'ValueInteger'</summary>
        public Element _ValueInteger { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueMarkdown { get; set; }
        ///<summary>May contain extended information for property: 'ValueMarkdown'</summary>
        public Element _ValueMarkdown { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Meta ValueMeta { get; set; }
        ///<summary>May contain extended information for property: 'ValueMeta'</summary>
        public Element _ValueMeta { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Money ValueMoney { get; set; }
        ///<summary>May contain extended information for property: 'ValueMoney'</summary>
        public Element _ValueMoney { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueOid { get; set; }
        ///<summary>May contain extended information for property: 'ValueOid'</summary>
        public Element _ValueOid { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public ParameterDefinition ValueParameterDefinition { get; set; }
        ///<summary>May contain extended information for property: 'ValueParameterDefinition'</summary>
        public Element _ValueParameterDefinition { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Period ValuePeriod { get; set; }
        ///<summary>May contain extended information for property: 'ValuePeriod'</summary>
        public Element _ValuePeriod { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public decimal ValuePositiveInt { get; set; }
        ///<summary>May contain extended information for property: 'ValuePositiveInt'</summary>
        public Element _ValuePositiveInt { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Quantity ValueQuantity { get; set; }
        ///<summary>May contain extended information for property: 'ValueQuantity'</summary>
        public Element _ValueQuantity { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Range ValueRange { get; set; }
        ///<summary>May contain extended information for property: 'ValueRange'</summary>
        public Element _ValueRange { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Ratio ValueRatio { get; set; }
        ///<summary>May contain extended information for property: 'ValueRatio'</summary>
        public Element _ValueRatio { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Reference ValueReference { get; set; }
        ///<summary>May contain extended information for property: 'ValueReference'</summary>
        public Element _ValueReference { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public RelatedArtifact ValueRelatedArtifact { get; set; }
        ///<summary>May contain extended information for property: 'ValueRelatedArtifact'</summary>
        public Element _ValueRelatedArtifact { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public SampledData ValueSampledData { get; set; }
        ///<summary>May contain extended information for property: 'ValueSampledData'</summary>
        public Element _ValueSampledData { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Signature ValueSignature { get; set; }
        ///<summary>May contain extended information for property: 'ValueSignature'</summary>
        public Element _ValueSignature { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueString { get; set; }
        ///<summary>May contain extended information for property: 'ValueString'</summary>
        public Element _ValueString { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueTime { get; set; }
        ///<summary>May contain extended information for property: 'ValueTime'</summary>
        public Element _ValueTime { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public Timing ValueTiming { get; set; }
        ///<summary>May contain extended information for property: 'ValueTiming'</summary>
        public Element _ValueTiming { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public TriggerDefinition ValueTriggerDefinition { get; set; }
        ///<summary>May contain extended information for property: 'ValueTriggerDefinition'</summary>
        public Element _ValueTriggerDefinition { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public decimal ValueUnsignedInt { get; set; }
        ///<summary>May contain extended information for property: 'ValueUnsignedInt'</summary>
        public Element _ValueUnsignedInt { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueUri { get; set; }
        ///<summary>May contain extended information for property: 'ValueUri'</summary>
        public Element _ValueUri { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueUrl { get; set; }
        ///<summary>May contain extended information for property: 'ValueUrl'</summary>
        public Element _ValueUrl { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public UsageContext ValueUsageContext { get; set; }
        ///<summary>May contain extended information for property: 'ValueUsageContext'</summary>
        public Element _ValueUsageContext { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list).</summary>
        public string ValueUuid { get; set; }
        ///<summary>May contain extended information for property: 'ValueUuid'</summary>
        public Element _ValueUuid { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for HumanName Type: A human's name with the ability to identify parts and usage.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\humanname.profile.canonical.json</source-file>
    public class HumanName : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The part of a name that links to the genealogy. In some cultures (e.g. Eritrea) the family name of a son is the first name of his father.</summary>
        public string Family { get; set; }
        ///<summary>May contain extended information for property: 'Family'</summary>
        public Element _Family { get; set; }
        ///<summary>Given name.</summary>
        public string[] Given { get; set; }
        ///<summary>May contain extended information for property: 'Given'</summary>
        public Element[] _Given { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Indicates the period of time when this name was valid for the named person.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the start of the name.</summary>
        public string[] Prefix { get; set; }
        ///<summary>May contain extended information for property: 'Prefix'</summary>
        public Element[] _Prefix { get; set; }
        ///<summary>Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the end of the name.</summary>
        public string[] Suffix { get; set; }
        ///<summary>May contain extended information for property: 'Suffix'</summary>
        public Element[] _Suffix { get; set; }
        ///<summary>Specifies the entire name as it should be displayed e.g. on an application UI. This may be provided instead of or as well as the specific parts.</summary>
        public string Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>Identifies the purpose for this name.</summary>
        public string Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Identifier Type: An identifier - identifies some entity uniquely and unambiguously. Typically this is used for business identifiers.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\identifier.profile.canonical.json</source-file>
    public class Identifier : Element
    {
        ///<summary>Organization that issued/manages the identifier.</summary>
        public Reference Assigner { get; set; }
        ///<summary>May contain extended information for property: 'Assigner'</summary>
        public Element _Assigner { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Time period during which identifier is/was valid for use.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>Establishes the namespace for the value - that is, a URL that describes a set values that are unique.</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>A coded type for the identifier that can be used to determine which identifier to use for a specific purpose.</summary>
        public CodeableConcept Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
        ///<summary>The purpose of this identifier.</summary>
        public string Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
        ///<summary>The portion of the identifier typically relevant to the user and which is unique within the context of the system.</summary>
        public string Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Meta Type: The metadata about a resource. This is content in the resource that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\meta.profile.canonical.json</source-file>
    public class Meta : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>When the resource last changed - e.g. when the version changed.</summary>
        public string LastUpdated { get; set; }
        ///<summary>May contain extended information for property: 'LastUpdated'</summary>
        public Element _LastUpdated { get; set; }
        ///<summary>A list of profiles (references to [StructureDefinition](structuredefinition.html#) resources) that this resource claims to conform to. The URL is a reference to [StructureDefinition.url](structuredefinition-definitions.html#StructureDefinition.url).</summary>
        public string[] Profile { get; set; }
        ///<summary>May contain extended information for property: 'Profile'</summary>
        public Element[] _Profile { get; set; }
        ///<summary>Security labels applied to this resource. These tags connect specific resources to the overall security policy and infrastructure.</summary>
        public Coding[] Security { get; set; }
        ///<summary>May contain extended information for property: 'Security'</summary>
        public Element[] _Security { get; set; }
        ///<summary>A uri that identifies the source system of the resource. This provides a minimal amount of [Provenance](provenance.html#) information that can be used to track or differentiate the source of information in the resource. The source may identify another FHIR server, document, message, database, etc.</summary>
        public string Source { get; set; }
        ///<summary>May contain extended information for property: 'Source'</summary>
        public Element _Source { get; set; }
        ///<summary>Tags applied to this resource. Tags are intended to be used to identify and relate resources to process and workflow, and applications are not required to consider the tags when interpreting the meaning of a resource.</summary>
        public Coding[] Tag { get; set; }
        ///<summary>May contain extended information for property: 'Tag'</summary>
        public Element[] _Tag { get; set; }
        ///<summary>The version specific identifier, as it appears in the version portion of the URL. This value changes when the resource is created, updated, or deleted.</summary>
        public string VersionId { get; set; }
        ///<summary>May contain extended information for property: 'VersionId'</summary>
        public Element _VersionId { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Money Type: An amount of economic utility in some recognized currency.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\money.profile.canonical.json</source-file>
    public class Money : Element
    {
        ///<summary>ISO 4217 Currency Code.</summary>
        public string Currency { get; set; }
        ///<summary>May contain extended information for property: 'Currency'</summary>
        public Element _Currency { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Numerical value (with implicit precision).</summary>
        public decimal Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Narrative Type: A human-readable summary of the resource conveying the essential clinical and business information for the resource.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\narrative.profile.canonical.json</source-file>
    public class Narrative : Element
    {
        ///<summary>The actual narrative content, a stripped down version of XHTML.</summary>
        public string Div { get; set; }
        ///<summary>May contain extended information for property: 'Div'</summary>
        public Element _Div { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The status of the narrative - whether it's entirely generated (from just the defined data or the extensions too), or whether a human authored it and it may contain additional data.</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
    }
    ///<summary>
    ///Measurements and simple assertions made about a patient, device or other subject.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\observation.profile.canonical.json</source-file>
    public class Observation : DomainResource
    {
        ///<summary>Resource Type Name (for serialization)</summary>
        public string ResourceType => "Observation";
        ///<summary>A plan, proposal or order that is fulfilled in whole or in part by this event.  For example, a MedicationRequest may require a patient to have laboratory test performed before  it is dispensed.</summary>
        public Reference[] BasedOn { get; set; }
        ///<summary>May contain extended information for property: 'BasedOn'</summary>
        public Element[] _BasedOn { get; set; }
        ///<summary>Indicates the site on the subject's body where the observation was made (i.e. the target site).</summary>
        public CodeableConcept BodySite { get; set; }
        ///<summary>May contain extended information for property: 'BodySite'</summary>
        public Element _BodySite { get; set; }
        ///<summary>A code that classifies the general type of observation being made.</summary>
        public CodeableConcept[] Category { get; set; }
        ///<summary>May contain extended information for property: 'Category'</summary>
        public Element[] _Category { get; set; }
        ///<summary>Describes what was observed. Sometimes this is called the observation "name".</summary>
        public CodeableConcept Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>Some observations have multiple component observations.  These component observations are expressed as separate code value pairs that share the same attributes.  Examples include systolic and diastolic component observations for blood pressure measurement and multiple component observations for genetics observations.</summary>
        public ObservationComponent[] Component { get; set; }
        ///<summary>May contain extended information for property: 'Component'</summary>
        public Element[] _Component { get; set; }
        ///<summary>These resources do not have an independent existence apart from the resource that contains them - they cannot be identified independently, and nor can they have their own independent transaction scope.</summary>
        public Resource[] Contained { get; set; }
        ///<summary>May contain extended information for property: 'Contained'</summary>
        public Element[] _Contained { get; set; }
        ///<summary>Provides a reason why the expected value in the element Observation.value[x] is missing.</summary>
        public CodeableConcept DataAbsentReason { get; set; }
        ///<summary>May contain extended information for property: 'DataAbsentReason'</summary>
        public Element _DataAbsentReason { get; set; }
        ///<summary>The target resource that represents a measurement from which this observation value is derived. For example, a calculated anion gap or a fetal measurement based on an ultrasound image.</summary>
        public Reference[] DerivedFrom { get; set; }
        ///<summary>May contain extended information for property: 'DerivedFrom'</summary>
        public Element[] _DerivedFrom { get; set; }
        ///<summary>The device used to generate the observation data.</summary>
        public Reference Device { get; set; }
        ///<summary>May contain extended information for property: 'Device'</summary>
        public Element _Device { get; set; }
        ///<summary>The time or time-period the observed value is asserted as being true. For biological subjects - e.g. human patients - this is usually called the "physiologically relevant time". This is usually either the time of the procedure or of specimen collection, but very often the source of the date/time is not known, only the date/time itself.</summary>
        public string EffectiveDateTime { get; set; }
        ///<summary>May contain extended information for property: 'EffectiveDateTime'</summary>
        public Element _EffectiveDateTime { get; set; }
        ///<summary>The time or time-period the observed value is asserted as being true. For biological subjects - e.g. human patients - this is usually called the "physiologically relevant time". This is usually either the time of the procedure or of specimen collection, but very often the source of the date/time is not known, only the date/time itself.</summary>
        public string EffectiveInstant { get; set; }
        ///<summary>May contain extended information for property: 'EffectiveInstant'</summary>
        public Element _EffectiveInstant { get; set; }
        ///<summary>The time or time-period the observed value is asserted as being true. For biological subjects - e.g. human patients - this is usually called the "physiologically relevant time". This is usually either the time of the procedure or of specimen collection, but very often the source of the date/time is not known, only the date/time itself.</summary>
        public Period EffectivePeriod { get; set; }
        ///<summary>May contain extended information for property: 'EffectivePeriod'</summary>
        public Element _EffectivePeriod { get; set; }
        ///<summary>The time or time-period the observed value is asserted as being true. For biological subjects - e.g. human patients - this is usually called the "physiologically relevant time". This is usually either the time of the procedure or of specimen collection, but very often the source of the date/time is not known, only the date/time itself.</summary>
        public Timing EffectiveTiming { get; set; }
        ///<summary>May contain extended information for property: 'EffectiveTiming'</summary>
        public Element _EffectiveTiming { get; set; }
        ///<summary>The healthcare event  (e.g. a patient and healthcare provider interaction) during which this observation is made.</summary>
        public Reference Encounter { get; set; }
        ///<summary>May contain extended information for property: 'Encounter'</summary>
        public Element _Encounter { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The actual focus of an observation when it is not the patient of record representing something or someone associated with the patient such as a spouse, parent, fetus, or donor. For example, fetus observations in a mother's record.  The focus of an observation could also be an existing condition,  an intervention, the subject's diet,  another observation of the subject,  or a body structure such as tumor or implanted device.   An example use case would be using the Observation resource to capture whether the mother is trained to change her child's tracheostomy tube. In this example, the child is the patient of record and the mother is the focus.</summary>
        public Reference[] Focus { get; set; }
        ///<summary>May contain extended information for property: 'Focus'</summary>
        public Element[] _Focus { get; set; }
        ///<summary>This observation is a group observation (e.g. a battery, a panel of tests, a set of vital sign measurements) that includes the target as a member of the group.</summary>
        public Reference[] HasMember { get; set; }
        ///<summary>May contain extended information for property: 'HasMember'</summary>
        public Element[] _HasMember { get; set; }
        ///<summary>The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A unique identifier assigned to this observation.</summary>
        public Identifier[] Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element[] _Identifier { get; set; }
        ///<summary>A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</summary>
        public string ImplicitRules { get; set; }
        ///<summary>May contain extended information for property: 'ImplicitRules'</summary>
        public Element _ImplicitRules { get; set; }
        ///<summary>A categorical assessment of an observation value.  For example, high, low, normal.</summary>
        public CodeableConcept[] Interpretation { get; set; }
        ///<summary>May contain extended information for property: 'Interpretation'</summary>
        public Element[] _Interpretation { get; set; }
        ///<summary>The date and time this version of the observation was made available to providers, typically after the results have been reviewed and verified.</summary>
        public string Issued { get; set; }
        ///<summary>May contain extended information for property: 'Issued'</summary>
        public Element _Issued { get; set; }
        ///<summary>The base language in which the resource is written.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</summary>
        public Meta Meta { get; set; }
        ///<summary>May contain extended information for property: 'Meta'</summary>
        public Element _Meta { get; set; }
        ///<summary>Indicates the mechanism used to perform the observation.</summary>
        public CodeableConcept Method { get; set; }
        ///<summary>May contain extended information for property: 'Method'</summary>
        public Element _Method { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource and that modifies the understanding of the element that contains it and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer is allowed to define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Comments about the observation or the results.</summary>
        public Annotation[] Note { get; set; }
        ///<summary>May contain extended information for property: 'Note'</summary>
        public Element[] _Note { get; set; }
        ///<summary>A larger event of which this particular Observation is a component or step.  For example,  an observation as part of a procedure.</summary>
        public Reference[] PartOf { get; set; }
        ///<summary>May contain extended information for property: 'PartOf'</summary>
        public Element[] _PartOf { get; set; }
        ///<summary>Who was responsible for asserting the observed value as "true".</summary>
        public Reference[] Performer { get; set; }
        ///<summary>May contain extended information for property: 'Performer'</summary>
        public Element[] _Performer { get; set; }
        ///<summary>Guidance on how to interpret the value by comparison to a normal or recommended range.  Multiple reference ranges are interpreted as an "OR".   In other words, to represent two distinct target populations, two `referenceRange` elements would be used.</summary>
        public ObservationReferenceRange[] ReferenceRange { get; set; }
        ///<summary>May contain extended information for property: 'ReferenceRange'</summary>
        public Element[] _ReferenceRange { get; set; }
        ///<summary>The specimen that was used when this observation was made.</summary>
        public Reference Specimen { get; set; }
        ///<summary>May contain extended information for property: 'Specimen'</summary>
        public Element _Specimen { get; set; }
        ///<summary>The status of the result value.</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
        ///<summary>The patient, or group of patients, location, or device this observation is about and into whose record the observation is placed. If the actual focus of the observation is different from the subject (or a sample of, part, or region of the subject), the `focus` element or the `code` itself specifies the actual focus of the observation.</summary>
        public Reference Subject { get; set; }
        ///<summary>May contain extended information for property: 'Subject'</summary>
        public Element _Subject { get; set; }
        ///<summary>A human-readable narrative that contains a summary of the resource and can be used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it "clinically safe" for a human to just read the narrative. Resource definitions may define what content should be represented in the narrative to ensure clinical safety.</summary>
        public Narrative Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public bool ValueBoolean { get; set; }
        ///<summary>May contain extended information for property: 'ValueBoolean'</summary>
        public Element _ValueBoolean { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public CodeableConcept ValueCodeableConcept { get; set; }
        ///<summary>May contain extended information for property: 'ValueCodeableConcept'</summary>
        public Element _ValueCodeableConcept { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public string ValueDateTime { get; set; }
        ///<summary>May contain extended information for property: 'ValueDateTime'</summary>
        public Element _ValueDateTime { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public decimal ValueInteger { get; set; }
        ///<summary>May contain extended information for property: 'ValueInteger'</summary>
        public Element _ValueInteger { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public Period ValuePeriod { get; set; }
        ///<summary>May contain extended information for property: 'ValuePeriod'</summary>
        public Element _ValuePeriod { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public Quantity ValueQuantity { get; set; }
        ///<summary>May contain extended information for property: 'ValueQuantity'</summary>
        public Element _ValueQuantity { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public Range ValueRange { get; set; }
        ///<summary>May contain extended information for property: 'ValueRange'</summary>
        public Element _ValueRange { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public Ratio ValueRatio { get; set; }
        ///<summary>May contain extended information for property: 'ValueRatio'</summary>
        public Element _ValueRatio { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public SampledData ValueSampledData { get; set; }
        ///<summary>May contain extended information for property: 'ValueSampledData'</summary>
        public Element _ValueSampledData { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public string ValueString { get; set; }
        ///<summary>May contain extended information for property: 'ValueString'</summary>
        public Element _ValueString { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public string ValueTime { get; set; }
        ///<summary>May contain extended information for property: 'ValueTime'</summary>
        public Element _ValueTime { get; set; }
    }
    ///<summary>
    ///Some observations have multiple component observations.  These component observations are expressed as separate code value pairs that share the same attributes.  Examples include systolic and diastolic component observations for blood pressure measurement and multiple component observations for genetics observations.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\observation.profile.canonical.json</source-file>
    public class ObservationComponent : Element
    {
        ///<summary>Describes what was observed. Sometimes this is called the observation "code".</summary>
        public CodeableConcept Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>Provides a reason why the expected value in the element Observation.component.value[x] is missing.</summary>
        public CodeableConcept DataAbsentReason { get; set; }
        ///<summary>May contain extended information for property: 'DataAbsentReason'</summary>
        public Element _DataAbsentReason { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A categorical assessment of an observation value.  For example, high, low, normal.</summary>
        public CodeableConcept[] Interpretation { get; set; }
        ///<summary>May contain extended information for property: 'Interpretation'</summary>
        public Element[] _Interpretation { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Guidance on how to interpret the value by comparison to a normal or recommended range.</summary>
        public ObservationReferenceRange[] ReferenceRange { get; set; }
        ///<summary>May contain extended information for property: 'ReferenceRange'</summary>
        public Element[] _ReferenceRange { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public bool ValueBoolean { get; set; }
        ///<summary>May contain extended information for property: 'ValueBoolean'</summary>
        public Element _ValueBoolean { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public CodeableConcept ValueCodeableConcept { get; set; }
        ///<summary>May contain extended information for property: 'ValueCodeableConcept'</summary>
        public Element _ValueCodeableConcept { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public string ValueDateTime { get; set; }
        ///<summary>May contain extended information for property: 'ValueDateTime'</summary>
        public Element _ValueDateTime { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public decimal ValueInteger { get; set; }
        ///<summary>May contain extended information for property: 'ValueInteger'</summary>
        public Element _ValueInteger { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public Period ValuePeriod { get; set; }
        ///<summary>May contain extended information for property: 'ValuePeriod'</summary>
        public Element _ValuePeriod { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public Quantity ValueQuantity { get; set; }
        ///<summary>May contain extended information for property: 'ValueQuantity'</summary>
        public Element _ValueQuantity { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public Range ValueRange { get; set; }
        ///<summary>May contain extended information for property: 'ValueRange'</summary>
        public Element _ValueRange { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public Ratio ValueRatio { get; set; }
        ///<summary>May contain extended information for property: 'ValueRatio'</summary>
        public Element _ValueRatio { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public SampledData ValueSampledData { get; set; }
        ///<summary>May contain extended information for property: 'ValueSampledData'</summary>
        public Element _ValueSampledData { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public string ValueString { get; set; }
        ///<summary>May contain extended information for property: 'ValueString'</summary>
        public Element _ValueString { get; set; }
        ///<summary>The information determined as a result of making the observation, if the information has a simple value.</summary>
        public string ValueTime { get; set; }
        ///<summary>May contain extended information for property: 'ValueTime'</summary>
        public Element _ValueTime { get; set; }
    }
    ///<summary>
    ///Guidance on how to interpret the value by comparison to a normal or recommended range.  Multiple reference ranges are interpreted as an "OR".   In other words, to represent two distinct target populations, two `referenceRange` elements would be used.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\observation.profile.canonical.json</source-file>
    public class ObservationReferenceRange : Element
    {
        ///<summary>The age at which this reference range is applicable. This is a neonatal age (e.g. number of weeks at term) if the meaning says so.</summary>
        public Range Age { get; set; }
        ///<summary>May contain extended information for property: 'Age'</summary>
        public Element _Age { get; set; }
        ///<summary>Codes to indicate the target population this reference range applies to.  For example, a reference range may be based on the normal population or a particular sex or race.  Multiple `appliesTo`  are interpreted as an "AND" of the target populations.  For example, to represent a target population of African American females, both a code of female and a code for African American would be used.</summary>
        public CodeableConcept[] AppliesTo { get; set; }
        ///<summary>May contain extended information for property: 'AppliesTo'</summary>
        public Element[] _AppliesTo { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The value of the high bound of the reference range.  The high bound of the reference range endpoint is inclusive of the value (e.g.  reference range is >=5 - <=9). If the high bound is omitted,  it is assumed to be meaningless (e.g. reference range is >= 2.3).</summary>
        public Quantity High { get; set; }
        ///<summary>May contain extended information for property: 'High'</summary>
        public Element _High { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The value of the low bound of the reference range.  The low bound of the reference range endpoint is inclusive of the value (e.g.  reference range is >=5 - <=9). If the low bound is omitted,  it is assumed to be meaningless (e.g. reference range is <=2.3).</summary>
        public Quantity Low { get; set; }
        ///<summary>May contain extended information for property: 'Low'</summary>
        public Element _Low { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Text based reference range in an observation which may be used when a quantitative range is not appropriate for an observation.  An example would be a reference value of "Negative" or a list or table of "normals".</summary>
        public string Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>Codes to indicate the what part of the targeted reference population it applies to. For example, the normal or therapeutic range.</summary>
        public CodeableConcept Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for ParameterDefinition Type: The parameters to the module. This collection specifies both the input and output parameters. Input parameters are provided by the caller as part of the $evaluate operation. Output parameters are included in the GuidanceResponse.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\parameterdefinition.profile.canonical.json</source-file>
    public class ParameterDefinition : Element
    {
        ///<summary>A brief discussion of what the parameter is for and how it is used by the module.</summary>
        public string Documentation { get; set; }
        ///<summary>May contain extended information for property: 'Documentation'</summary>
        public Element _Documentation { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The maximum number of times this element is permitted to appear in the request or response.</summary>
        public string Max { get; set; }
        ///<summary>May contain extended information for property: 'Max'</summary>
        public Element _Max { get; set; }
        ///<summary>The minimum number of times this parameter SHALL appear in the request or response.</summary>
        public decimal Min { get; set; }
        ///<summary>May contain extended information for property: 'Min'</summary>
        public Element _Min { get; set; }
        ///<summary>The name of the parameter used to allow access to the value of the parameter in evaluation contexts.</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>If specified, this indicates a profile that the input data must conform to, or that the output data will conform to.</summary>
        public string Profile { get; set; }
        ///<summary>May contain extended information for property: 'Profile'</summary>
        public Element _Profile { get; set; }
        ///<summary>The type of the parameter.</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
        ///<summary>Whether the parameter is input or output for the module.</summary>
        public string Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
    }
    ///<summary>
    ///Demographics and other administrative information about an individual or animal receiving care or other health-related services.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\patient.profile.canonical.json</source-file>
    public class Patient : DomainResource
    {
        ///<summary>Resource Type Name (for serialization)</summary>
        public string ResourceType => "Patient";
        ///<summary>Whether this patient record is in active use. 
        /// Many systems use this property to mark as non-current patients, such as those that have not been seen for a period of time based on an organization's business rules.
        /// 
        /// It is often used to filter patient lists to exclude inactive patients
        /// 
        /// Deceased patients may also be marked as inactive for the same reasons, but may be active for some time after death.</summary>
        public bool Active { get; set; }
        ///<summary>May contain extended information for property: 'Active'</summary>
        public Element _Active { get; set; }
        ///<summary>An address for the individual.</summary>
        public Address[] Address { get; set; }
        ///<summary>May contain extended information for property: 'Address'</summary>
        public Element[] _Address { get; set; }
        ///<summary>The date of birth for the individual.</summary>
        public string BirthDate { get; set; }
        ///<summary>May contain extended information for property: 'BirthDate'</summary>
        public Element _BirthDate { get; set; }
        ///<summary>A language which may be used to communicate with the patient about his or her health.</summary>
        public PatientCommunication[] Communication { get; set; }
        ///<summary>May contain extended information for property: 'Communication'</summary>
        public Element[] _Communication { get; set; }
        ///<summary>A contact party (e.g. guardian, partner, friend) for the patient.</summary>
        public PatientContact[] Contact { get; set; }
        ///<summary>May contain extended information for property: 'Contact'</summary>
        public Element[] _Contact { get; set; }
        ///<summary>These resources do not have an independent existence apart from the resource that contains them - they cannot be identified independently, and nor can they have their own independent transaction scope.</summary>
        public Resource[] Contained { get; set; }
        ///<summary>May contain extended information for property: 'Contained'</summary>
        public Element[] _Contained { get; set; }
        ///<summary>Indicates if the individual is deceased or not.</summary>
        public bool DeceasedBoolean { get; set; }
        ///<summary>May contain extended information for property: 'DeceasedBoolean'</summary>
        public Element _DeceasedBoolean { get; set; }
        ///<summary>Indicates if the individual is deceased or not.</summary>
        public string DeceasedDateTime { get; set; }
        ///<summary>May contain extended information for property: 'DeceasedDateTime'</summary>
        public Element _DeceasedDateTime { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Administrative Gender - the gender that the patient is considered to have for administration and record keeping purposes.</summary>
        public string Gender { get; set; }
        ///<summary>May contain extended information for property: 'Gender'</summary>
        public Element _Gender { get; set; }
        ///<summary>Patient's nominated care provider.</summary>
        public Reference[] GeneralPractitioner { get; set; }
        ///<summary>May contain extended information for property: 'GeneralPractitioner'</summary>
        public Element[] _GeneralPractitioner { get; set; }
        ///<summary>The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>An identifier for this patient.</summary>
        public Identifier[] Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element[] _Identifier { get; set; }
        ///<summary>A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</summary>
        public string ImplicitRules { get; set; }
        ///<summary>May contain extended information for property: 'ImplicitRules'</summary>
        public Element _ImplicitRules { get; set; }
        ///<summary>The base language in which the resource is written.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>Link to another patient resource that concerns the same actual patient.</summary>
        public PatientLink[] Link { get; set; }
        ///<summary>May contain extended information for property: 'Link'</summary>
        public Element[] _Link { get; set; }
        ///<summary>Organization that is the custodian of the patient record.</summary>
        public Reference ManagingOrganization { get; set; }
        ///<summary>May contain extended information for property: 'ManagingOrganization'</summary>
        public Element _ManagingOrganization { get; set; }
        ///<summary>This field contains a patient's most recent marital (civil) status.</summary>
        public CodeableConcept MaritalStatus { get; set; }
        ///<summary>May contain extended information for property: 'MaritalStatus'</summary>
        public Element _MaritalStatus { get; set; }
        ///<summary>The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</summary>
        public Meta Meta { get; set; }
        ///<summary>May contain extended information for property: 'Meta'</summary>
        public Element _Meta { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource and that modifies the understanding of the element that contains it and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer is allowed to define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Indicates whether the patient is part of a multiple (boolean) or indicates the actual birth order (integer).</summary>
        public bool MultipleBirthBoolean { get; set; }
        ///<summary>May contain extended information for property: 'MultipleBirthBoolean'</summary>
        public Element _MultipleBirthBoolean { get; set; }
        ///<summary>Indicates whether the patient is part of a multiple (boolean) or indicates the actual birth order (integer).</summary>
        public decimal MultipleBirthInteger { get; set; }
        ///<summary>May contain extended information for property: 'MultipleBirthInteger'</summary>
        public Element _MultipleBirthInteger { get; set; }
        ///<summary>A name associated with the individual.</summary>
        public HumanName[] Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element[] _Name { get; set; }
        ///<summary>Image of the patient.</summary>
        public Attachment[] Photo { get; set; }
        ///<summary>May contain extended information for property: 'Photo'</summary>
        public Element[] _Photo { get; set; }
        ///<summary>A contact detail (e.g. a telephone number or an email address) by which the individual may be contacted.</summary>
        public ContactPoint[] Telecom { get; set; }
        ///<summary>May contain extended information for property: 'Telecom'</summary>
        public Element[] _Telecom { get; set; }
        ///<summary>A human-readable narrative that contains a summary of the resource and can be used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it "clinically safe" for a human to just read the narrative. Resource definitions may define what content should be represented in the narrative to ensure clinical safety.</summary>
        public Narrative Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
    }
    ///<summary>
    ///A language which may be used to communicate with the patient about his or her health.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\patient.profile.canonical.json</source-file>
    public class PatientCommunication : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The ISO-639-1 alpha 2 code in lower case for the language, optionally followed by a hyphen and the ISO-3166-1 alpha 2 code for the region in upper case; e.g. "en" for English, or "en-US" for American English versus "en-EN" for England English.</summary>
        public CodeableConcept Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Indicates whether or not the patient prefers this language (over other languages he masters up a certain level).</summary>
        public bool Preferred { get; set; }
        ///<summary>May contain extended information for property: 'Preferred'</summary>
        public Element _Preferred { get; set; }
    }
    ///<summary>
    ///A contact party (e.g. guardian, partner, friend) for the patient.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\patient.profile.canonical.json</source-file>
    public class PatientContact : Element
    {
        ///<summary>Address for the contact person.</summary>
        public Address Address { get; set; }
        ///<summary>May contain extended information for property: 'Address'</summary>
        public Element _Address { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Administrative Gender - the gender that the contact person is considered to have for administration and record keeping purposes.</summary>
        public string Gender { get; set; }
        ///<summary>May contain extended information for property: 'Gender'</summary>
        public Element _Gender { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>A name associated with the contact person.</summary>
        public HumanName Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>Organization on behalf of which the contact is acting or for which the contact is working.</summary>
        public Reference Organization { get; set; }
        ///<summary>May contain extended information for property: 'Organization'</summary>
        public Element _Organization { get; set; }
        ///<summary>The period during which this contact person or organization is valid to be contacted relating to this patient.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>The nature of the relationship between the patient and the contact person.</summary>
        public CodeableConcept[] Relationship { get; set; }
        ///<summary>May contain extended information for property: 'Relationship'</summary>
        public Element[] _Relationship { get; set; }
        ///<summary>A contact detail for the person, e.g. a telephone number or an email address.</summary>
        public ContactPoint[] Telecom { get; set; }
        ///<summary>May contain extended information for property: 'Telecom'</summary>
        public Element[] _Telecom { get; set; }
    }
    ///<summary>
    ///Link to another patient resource that concerns the same actual patient.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\patient.profile.canonical.json</source-file>
    public class PatientLink : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The other patient resource that the link refers to.</summary>
        public Reference Other { get; set; }
        ///<summary>May contain extended information for property: 'Other'</summary>
        public Element _Other { get; set; }
        ///<summary>The type of link between this patient resource and another patient resource.</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Period Type: A time period defined by a start and end date and optionally time.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\period.profile.canonical.json</source-file>
    public class Period : Element
    {
        ///<summary>The end of the period. If the end of the period is missing, it means no end was known or planned at the time the instance was created. The start may be in the past, and the end date in the future, which means that period is expected/planned to end at that time.</summary>
        public string End { get; set; }
        ///<summary>May contain extended information for property: 'End'</summary>
        public Element _End { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The start of the period. The boundary is inclusive.</summary>
        public string Start { get; set; }
        ///<summary>May contain extended information for property: 'Start'</summary>
        public Element _Start { get; set; }
    }
    ///<summary>
    ///A person who is directly or indirectly involved in the provisioning of healthcare.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\practitioner.profile.canonical.json</source-file>
    public class Practitioner : DomainResource
    {
        ///<summary>Resource Type Name (for serialization)</summary>
        public string ResourceType => "Practitioner";
        ///<summary>Whether this practitioner's record is in active use.</summary>
        public bool Active { get; set; }
        ///<summary>May contain extended information for property: 'Active'</summary>
        public Element _Active { get; set; }
        ///<summary>Address(es) of the practitioner that are not role specific (typically home address). 
        /// Work addresses are not typically entered in this property as they are usually role dependent.</summary>
		public Address[] Address { get; set; }
        ///<summary>May contain extended information for property: 'Address'</summary>
        public Element[] _Address { get; set; }
        ///<summary>The date of birth for the practitioner.</summary>
        public string BirthDate { get; set; }
        ///<summary>May contain extended information for property: 'BirthDate'</summary>
        public Element _BirthDate { get; set; }
        ///<summary>A language the practitioner can use in patient communication.</summary>
        public CodeableConcept[] Communication { get; set; }
        ///<summary>May contain extended information for property: 'Communication'</summary>
        public Element[] _Communication { get; set; }
        ///<summary>These resources do not have an independent existence apart from the resource that contains them - they cannot be identified independently, and nor can they have their own independent transaction scope.</summary>
        public Resource[] Contained { get; set; }
        ///<summary>May contain extended information for property: 'Contained'</summary>
        public Element[] _Contained { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Administrative Gender - the gender that the person is considered to have for administration and record keeping purposes.</summary>
        public string Gender { get; set; }
        ///<summary>May contain extended information for property: 'Gender'</summary>
        public Element _Gender { get; set; }
        ///<summary>The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>An identifier that applies to this person in this role.</summary>
        public Identifier[] Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element[] _Identifier { get; set; }
        ///<summary>A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</summary>
        public string ImplicitRules { get; set; }
        ///<summary>May contain extended information for property: 'ImplicitRules'</summary>
        public Element _ImplicitRules { get; set; }
        ///<summary>The base language in which the resource is written.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</summary>
        public Meta Meta { get; set; }
        ///<summary>May contain extended information for property: 'Meta'</summary>
        public Element _Meta { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource and that modifies the understanding of the element that contains it and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer is allowed to define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The name(s) associated with the practitioner.</summary>
        public HumanName[] Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element[] _Name { get; set; }
        ///<summary>Image of the person.</summary>
        public Attachment[] Photo { get; set; }
        ///<summary>May contain extended information for property: 'Photo'</summary>
        public Element[] _Photo { get; set; }
        ///<summary>The official certifications, training, and licenses that authorize or otherwise pertain to the provision of care by the practitioner.  For example, a medical license issued by a medical board authorizing the practitioner to practice medicine within a certian locality.</summary>
        public PractitionerQualification[] Qualification { get; set; }
        ///<summary>May contain extended information for property: 'Qualification'</summary>
        public Element[] _Qualification { get; set; }
        ///<summary>A contact detail for the practitioner, e.g. a telephone number or an email address.</summary>
        public ContactPoint[] Telecom { get; set; }
        ///<summary>May contain extended information for property: 'Telecom'</summary>
        public Element[] _Telecom { get; set; }
        ///<summary>A human-readable narrative that contains a summary of the resource and can be used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it "clinically safe" for a human to just read the narrative. Resource definitions may define what content should be represented in the narrative to ensure clinical safety.</summary>
        public Narrative Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
    }
    ///<summary>
    ///The official certifications, training, and licenses that authorize or otherwise pertain to the provision of care by the practitioner.  For example, a medical license issued by a medical board authorizing the practitioner to practice medicine within a certian locality.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\practitioner.profile.canonical.json</source-file>
    public class PractitionerQualification : Element
    {
        ///<summary>Coded representation of the qualification.</summary>
        public CodeableConcept Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>An identifier that applies to this person's qualification in this role.</summary>
        public Identifier[] Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element[] _Identifier { get; set; }
        ///<summary>Organization that regulates and issues the qualification.</summary>
        public Reference Issuer { get; set; }
        ///<summary>May contain extended information for property: 'Issuer'</summary>
        public Element _Issuer { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Period during which the qualification is valid.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
    }
    ///<summary>
    ///There SHALL be a code if there is a value and it SHALL be an expression of currency.  If system is present, it SHALL be ISO 4217 (system = "urn:iso:std:iso:4217" - currency).
    ///</summary>
    ///<source-file>c:/git/fhir\publish\moneyquantity.profile.canonical.json</source-file>
    public class Quantity : Element
    {
        ///<summary>A computer processable form of the unit in some unit representation system.</summary>
        public string Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>How the value should be understood and represented - whether the actual value is greater or less than the stated value due to measurement issues; e.g. if the comparator is "<" , then the real value is < stated value.</summary>
        public string Comparator { get; set; }
        ///<summary>May contain extended information for property: 'Comparator'</summary>
        public Element _Comparator { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The identification of the system that provides the coded form of the unit.</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>A human-readable form of the unit.</summary>
        public string Unit { get; set; }
        ///<summary>May contain extended information for property: 'Unit'</summary>
        public Element _Unit { get; set; }
        ///<summary>The value of the measured amount. The value includes an implicit precision in the presentation of the value.</summary>
        public decimal Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Range Type: A set of ordered Quantities defined by a low and high limit.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\range.profile.canonical.json</source-file>
    public class Range : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The high limit. The boundary is inclusive.</summary>
        public Quantity High { get; set; }
        ///<summary>May contain extended information for property: 'High'</summary>
        public Element _High { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The low limit. The boundary is inclusive.</summary>
        public Quantity Low { get; set; }
        ///<summary>May contain extended information for property: 'Low'</summary>
        public Element _Low { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Ratio Type: A relationship of two Quantity values - expressed as a numerator and a denominator.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\ratio.profile.canonical.json</source-file>
    public class Ratio : Element
    {
        ///<summary>The value of the denominator.</summary>
        public Quantity Denominator { get; set; }
        ///<summary>May contain extended information for property: 'Denominator'</summary>
        public Element _Denominator { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The value of the numerator.</summary>
        public Quantity Numerator { get; set; }
        ///<summary>May contain extended information for property: 'Numerator'</summary>
        public Element _Numerator { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Reference Type: A reference from one resource to another.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\reference.profile.canonical.json</source-file>
    public class Reference : Element
    {
        ///<summary>Plain text narrative that identifies the resource in addition to the resource reference.</summary>
        public string Display { get; set; }
        ///<summary>May contain extended information for property: 'Display'</summary>
        public Element _Display { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>An identifier for the target resource. This is used when there is no way to reference the other resource directly, either because the entity it represents is not available through a FHIR server, or because there is no way for the author of the resource to convert a known identifier to an actual location. There is no requirement that a Reference.identifier point to something that is actually exposed as a FHIR instance, but it SHALL point to a business concept that would be expected to be exposed as a FHIR instance, and that instance would need to be of a FHIR resource type allowed by the reference.</summary>
        public Identifier Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element _Identifier { get; set; }
        ///<summary>A reference to a location at which the other resource is found. The reference may be a relative reference, in which case it is relative to the service base URL, or an absolute URL that resolves to the location where the resource is found. The reference may be version specific or not. If the reference is not to a FHIR RESTful server, then it should be assumed to be version specific. Internal fragment references (start with '#') refer to contained resources.</summary>
        public string reference { get; set; }
        ///<summary>May contain extended information for property: 'reference'</summary>
        public Element _reference { get; set; }
        ///<summary>The expected type of the target of the reference. If both Reference.type and Reference.reference are populated and Reference.reference is a FHIR URL, both SHALL be consistent.
        /// 
        /// The type is the Canonical URL of Resource Definition that is the type this reference refers to. References are URLs that are relative to http://hl7.org/fhir/StructureDefinition/ e.g. "Patient" is a reference to http://hl7.org/fhir/StructureDefinition/Patient. Absolute URLs are only allowed for logical models (and can only be used in references in logical models, not resources).</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for RelatedArtifact Type: Related artifacts such as additional documentation, justification, or bibliographic references.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\relatedartifact.profile.canonical.json</source-file>
    public class RelatedArtifact : Element
    {
        ///<summary>A bibliographic citation for the related artifact. This text SHOULD be formatted according to an accepted citation format.</summary>
        public string Citation { get; set; }
        ///<summary>May contain extended information for property: 'Citation'</summary>
        public Element _Citation { get; set; }
        ///<summary>A brief description of the document or knowledge resource being referenced, suitable for display to a consumer.</summary>
        public string Display { get; set; }
        ///<summary>May contain extended information for property: 'Display'</summary>
        public Element _Display { get; set; }
        ///<summary>The document being referenced, represented as an attachment. This is exclusive with the resource element.</summary>
        public Attachment Document { get; set; }
        ///<summary>May contain extended information for property: 'Document'</summary>
        public Element _Document { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A short label that can be used to reference the citation from elsewhere in the containing artifact, such as a footnote index.</summary>
        public string Label { get; set; }
        ///<summary>May contain extended information for property: 'Label'</summary>
        public Element _Label { get; set; }
        ///<summary>The related resource, such as a library, value set, profile, or other knowledge resource.</summary>
        public string Resource { get; set; }
        ///<summary>May contain extended information for property: 'Resource'</summary>
        public Element _Resource { get; set; }
        ///<summary>The type of relationship to the related artifact.</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
        ///<summary>A url for the artifact that can be followed to access the actual content.</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
    }
    ///<summary>
    ///This is the base resource type for everything.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\resource.profile.canonical.json</source-file>
    public class Resource
    {
        ///<summary>The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</summary>
        public string ImplicitRules { get; set; }
        ///<summary>May contain extended information for property: 'ImplicitRules'</summary>
        public Element _ImplicitRules { get; set; }
        ///<summary>The base language in which the resource is written.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</summary>
        public Meta Meta { get; set; }
        ///<summary>May contain extended information for property: 'Meta'</summary>
        public Element _Meta { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for SampledData Type: A series of measurements taken by a device, with upper and lower limits. There may be more than one dimension in the data.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\sampleddata.profile.canonical.json</source-file>
    public class SampledData : Element
    {
        ///<summary>A series of data points which are decimal values separated by a single space (character u20). The special values "E" (error), "L" (below detection limit) and "U" (above detection limit) can also be used in place of a decimal value.</summary>
        public string Data { get; set; }
        ///<summary>May contain extended information for property: 'Data'</summary>
        public Element _Data { get; set; }
        ///<summary>The number of sample points at each time point. If this value is greater than one, then the dimensions will be interlaced - all the sample points for a point in time will be recorded at once.</summary>
        public decimal Dimensions { get; set; }
        ///<summary>May contain extended information for property: 'Dimensions'</summary>
        public Element _Dimensions { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>A correction factor that is applied to the sampled data points before they are added to the origin.</summary>
        public decimal Factor { get; set; }
        ///<summary>May contain extended information for property: 'Factor'</summary>
        public Element _Factor { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The lower limit of detection of the measured points. This is needed if any of the data points have the value "L" (lower than detection limit).</summary>
        public decimal LowerLimit { get; set; }
        ///<summary>May contain extended information for property: 'LowerLimit'</summary>
        public Element _LowerLimit { get; set; }
        ///<summary>The base quantity that a measured value of zero represents. In addition, this provides the units of the entire measurement series.</summary>
        public Quantity Origin { get; set; }
        ///<summary>May contain extended information for property: 'Origin'</summary>
        public Element _Origin { get; set; }
        ///<summary>The length of time between sampling times, measured in milliseconds.</summary>
        public decimal Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>The upper limit of detection of the measured points. This is needed if any of the data points have the value "U" (higher than detection limit).</summary>
        public decimal UpperLimit { get; set; }
        ///<summary>May contain extended information for property: 'UpperLimit'</summary>
        public Element _UpperLimit { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Signature Type: A signature along with supporting context. The signature may be a digital signature that is cryptographic in nature, or some other signature acceptable to the domain. This other signature may be as simple as a graphical image representing a hand-written signature, or a signature ceremony Different signature approaches have different utilities.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\signature.profile.canonical.json</source-file>
    public class Signature : Element
    {
        ///<summary>The base64 encoding of the Signature content. When signature is not recorded electronically this element would be empty.</summary>
        public string Data { get; set; }
        ///<summary>May contain extended information for property: 'Data'</summary>
        public Element _Data { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A reference to an application-usable description of the identity that is represented by the signature.</summary>
        public Reference OnBehalfOf { get; set; }
        ///<summary>May contain extended information for property: 'OnBehalfOf'</summary>
        public Element _OnBehalfOf { get; set; }
        ///<summary>A mime type that indicates the technical format of the signature. Important mime types are application/signature+xml for X ML DigSig, application/jose for JWS, and image/* for a graphical image of a signature, etc.</summary>
        public string SigFormat { get; set; }
        ///<summary>May contain extended information for property: 'SigFormat'</summary>
        public Element _SigFormat { get; set; }
        ///<summary>A mime type that indicates the technical format of the target resources signed by the signature.</summary>
        public string TargetFormat { get; set; }
        ///<summary>May contain extended information for property: 'TargetFormat'</summary>
        public Element _TargetFormat { get; set; }
        ///<summary>An indication of the reason that the entity signed this document. This may be explicitly included as part of the signature information and can be used when determining accountability for various actions concerning the document.</summary>
        public Coding[] Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element[] _Type { get; set; }
        ///<summary>When the digital signature was signed.</summary>
        public string When { get; set; }
        ///<summary>May contain extended information for property: 'When'</summary>
        public Element _When { get; set; }
        ///<summary>A reference to an application-usable description of the identity that signed  (e.g. the signature used their private key).</summary>
        public Reference Who { get; set; }
        ///<summary>May contain extended information for property: 'Who'</summary>
        public Element _Who { get; set; }
    }
    ///<summary>
    ///The subscription resource describes a particular client's request to be notified about a Topic.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\subscription.profile.canonical.json</source-file>
    public class Subscription : DomainResource
    {
        ///<summary>Resource Type Name (for serialization)</summary>
        public string ResourceType => "Subscription";
        ///<summary>Details where to send notifications when resources are received that meet the criteria.</summary>
        public SubscriptionChannel Channel { get; set; }
        ///<summary>May contain extended information for property: 'Channel'</summary>
        public Element _Channel { get; set; }
        ///<summary>Contact details for a human to contact about the subscription. The primary use of this for system administrator troubleshooting.</summary>
        public ContactPoint[] Contact { get; set; }
        ///<summary>May contain extended information for property: 'Contact'</summary>
        public Element[] _Contact { get; set; }
        ///<summary>These resources do not have an independent existence apart from the resource that contains them - they cannot be identified independently, and nor can they have their own independent transaction scope.</summary>
        public Resource[] Contained { get; set; }
        ///<summary>May contain extended information for property: 'Contained'</summary>
        public Element[] _Contained { get; set; }
        ///<summary>The time for the server to turn the subscription off.</summary>
        public string End { get; set; }
        ///<summary>May contain extended information for property: 'End'</summary>
        public Element _End { get; set; }
        ///<summary>A record of the last error that occurred when the server processed a notification.</summary>
        public CodeableConcept[] Error { get; set; }
        ///<summary>May contain extended information for property: 'Error'</summary>
        public Element[] _Error { get; set; }
        ///<summary>A record of  the number of events for which the server has attempted delivery on this subscription (i.e., the number of events that occurred while the subscription is in an "active" or "error" state -- not "requested" or "off").   Server Initializes to 0 for a new subscription.  Repeated attempts at delivery of the *same* event notification do not increment this counter.</summary>
        public decimal EventCount { get; set; }
        ///<summary>May contain extended information for property: 'EventCount'</summary>
        public Element _EventCount { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The filter properties to be applied to narrow the topic stream.  When multiple filters are applied, evaluates to true if all the conditions are met; otherwise it returns false.   (i.e., logical AND).</summary>
        public SubscriptionFilterBy[] FilterBy { get; set; }
        ///<summary>May contain extended information for property: 'FilterBy'</summary>
        public Element[] _FilterBy { get; set; }
        ///<summary>The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A formal identifier that is used to identify this code system when it is represented in other formats, or referenced in a specification, model, design or an instance.</summary>
        public Identifier[] Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element[] _Identifier { get; set; }
        ///<summary>A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</summary>
        public string ImplicitRules { get; set; }
        ///<summary>May contain extended information for property: 'ImplicitRules'</summary>
        public Element _ImplicitRules { get; set; }
        ///<summary>The base language in which the resource is written.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</summary>
        public Meta Meta { get; set; }
        ///<summary>May contain extended information for property: 'Meta'</summary>
        public Element _Meta { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource and that modifies the understanding of the element that contains it and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer is allowed to define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>A natural language name identifying the subscription.</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>A description of why this subscription is defined.</summary>
        public string Reason { get; set; }
        ///<summary>May contain extended information for property: 'Reason'</summary>
        public Element _Reason { get; set; }
        ///<summary>The status of the subscription, which marks the server state for managing the subscription.</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
        ///<summary>A human-readable narrative that contains a summary of the resource and can be used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it "clinically safe" for a human to just read the narrative. Resource definitions may define what content should be represented in the narrative to ensure clinical safety.</summary>
        public Narrative Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>The reference to the topic to be notified about.</summary>
        public Reference Topic { get; set; }
        ///<summary>May contain extended information for property: 'Topic'</summary>
        public Element _Topic { get; set; }
    }
    ///<summary>
    ///Details where to send notifications when resources are received that meet the criteria.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\subscription.profile.canonical.json</source-file>
    public class SubscriptionChannel : Element
    {
        ///<summary>The url that describes the actual end-point to send messages to.</summary>
        public string Endpoint { get; set; }
        ///<summary>May contain extended information for property: 'Endpoint'</summary>
        public Element _Endpoint { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Additional headers / information to send as part of the notification.</summary>
        public string[] Header { get; set; }
        ///<summary>May contain extended information for property: 'Header'</summary>
        public Element[] _Header { get; set; }
        ///<summary>If present,  a 'hearbeat" notification (keepalive) is sent via this channel with an the interval period equal to this elements integer value in seconds.    If not present, a heartbeat notification is not sent.</summary>
        public decimal HeartbeatPeriod { get; set; }
        ///<summary>May contain extended information for property: 'HeartbeatPeriod'</summary>
        public Element _HeartbeatPeriod { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The payload mimetype and content.  If the payload is not present, then there is no payload in the notification, just a notification.</summary>
        public SubscriptionChannelPayload Payload { get; set; }
        ///<summary>May contain extended information for property: 'Payload'</summary>
        public Element _Payload { get; set; }
        ///<summary>The type of channel to send notifications on.</summary>
        public CodeableConcept Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///The payload mimetype and content.  If the payload is not present, then there is no payload in the notification, just a notification.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\subscription.profile.canonical.json</source-file>
    public class SubscriptionChannelPayload : Element
    {
        ///<summary>How much of the resource content to deliver in the notification payload. The choices are an empty payload, only the resource id, or the full resource content.</summary>
        public string Content { get; set; }
        ///<summary>May contain extended information for property: 'Content'</summary>
        public Element _Content { get; set; }
        ///<summary>The mime type to send the payload in - either application/fhir+xml, or application/fhir+json. The mime type "text/plain" may also be used for Email and SMS subscriptions.</summary>
        public string ContentType { get; set; }
        ///<summary>May contain extended information for property: 'ContentType'</summary>
        public Element _ContentType { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
    }
    ///<summary>
    ///The filter properties to be applied to narrow the topic stream.  When multiple filters are applied, evaluates to true if all the conditions are met; otherwise it returns false.   (i.e., logical AND).
    ///</summary>
    ///<source-file>c:/git/fhir\publish\subscription.profile.canonical.json</source-file>
    public class SubscriptionFilterBy : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The operator to apply to the filter value when determining matches (Search modifiers).</summary>
        public string MatchType { get; set; }
        ///<summary>May contain extended information for property: 'MatchType'</summary>
        public Element _MatchType { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The filter label (=key) as defined in the `Topic.canFilterBy.name`  element.</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>The literal value or resource path as is legal in search - for example, "Patient/123" or "le1950".</summary>
        public string Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for Timing Type: Specifies an event that may occur multiple times. Timing schedules are used to record when things are planned, expected or requested to occur. The most common usage is in dosage instructions for medications. They are also used when planning care of various kinds, and may be used for reporting the schedule to which past regular activities were carried out.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\timing.profile.canonical.json</source-file>
    public class Timing : BackboneElement
    {
        ///<summary>A code for the timing schedule (or just text in code.text). Some codes such as BID are ubiquitous, but many institutions define their own additional codes. If a code is provided, the code is understood to be a complete statement of whatever is specified in the structured timing data, and either the code or the data may be used to interpret the Timing, with the exception that .repeat.bounds still applies over the code (and is not contained in the code).</summary>
        public CodeableConcept Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>Identifies specific times when the event occurs.</summary>
        public string[] Event { get; set; }
        ///<summary>May contain extended information for property: 'Event'</summary>
        public Element[] _Event { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>A set of rules that describe when the event is scheduled.</summary>
        public TimingRepeat Repeat { get; set; }
        ///<summary>May contain extended information for property: 'Repeat'</summary>
        public Element _Repeat { get; set; }
    }
    ///<summary>
    ///A set of rules that describe when the event is scheduled.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\timing.profile.canonical.json</source-file>
    public class TimingRepeat : Element
    {
        ///<summary>Either a duration for the length of the timing schedule, a range of possible length, or outer bounds for start and/or end limits of the timing schedule.</summary>
        public Duration BoundsDuration { get; set; }
        ///<summary>May contain extended information for property: 'BoundsDuration'</summary>
        public Element _BoundsDuration { get; set; }
        ///<summary>Either a duration for the length of the timing schedule, a range of possible length, or outer bounds for start and/or end limits of the timing schedule.</summary>
        public Period BoundsPeriod { get; set; }
        ///<summary>May contain extended information for property: 'BoundsPeriod'</summary>
        public Element _BoundsPeriod { get; set; }
        ///<summary>Either a duration for the length of the timing schedule, a range of possible length, or outer bounds for start and/or end limits of the timing schedule.</summary>
        public Range BoundsRange { get; set; }
        ///<summary>May contain extended information for property: 'BoundsRange'</summary>
        public Element _BoundsRange { get; set; }
        ///<summary>A total count of the desired number of repetitions across the duration of the entire timing specification. If countMax is present, this element indicates the lower bound of the allowed range of count values.</summary>
        public decimal Count { get; set; }
        ///<summary>May contain extended information for property: 'Count'</summary>
        public Element _Count { get; set; }
        ///<summary>If present, indicates that the count is a range - so to perform the action between [count] and [countMax] times.</summary>
        public decimal CountMax { get; set; }
        ///<summary>May contain extended information for property: 'CountMax'</summary>
        public Element _CountMax { get; set; }
        ///<summary>If one or more days of week is provided, then the action happens only on the specified day(s).</summary>
        public string[] DayOfWeek { get; set; }
        ///<summary>May contain extended information for property: 'DayOfWeek'</summary>
        public Element[] _DayOfWeek { get; set; }
        ///<summary>How long this thing happens for when it happens. If durationMax is present, this element indicates the lower bound of the allowed range of the duration.</summary>
        public decimal Duration { get; set; }
        ///<summary>May contain extended information for property: 'Duration'</summary>
        public Element _Duration { get; set; }
        ///<summary>If present, indicates that the duration is a range - so to perform the action between [duration] and [durationMax] time length.</summary>
        public decimal DurationMax { get; set; }
        ///<summary>May contain extended information for property: 'DurationMax'</summary>
        public Element _DurationMax { get; set; }
        ///<summary>The units of time for the duration, in UCUM units.</summary>
        public string DurationUnit { get; set; }
        ///<summary>May contain extended information for property: 'DurationUnit'</summary>
        public Element _DurationUnit { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The number of times to repeat the action within the specified period. If frequencyMax is present, this element indicates the lower bound of the allowed range of the frequency.</summary>
        public decimal Frequency { get; set; }
        ///<summary>May contain extended information for property: 'Frequency'</summary>
        public Element _Frequency { get; set; }
        ///<summary>If present, indicates that the frequency is a range - so to repeat between [frequency] and [frequencyMax] times within the period or period range.</summary>
        public decimal FrequencyMax { get; set; }
        ///<summary>May contain extended information for property: 'FrequencyMax'</summary>
        public Element _FrequencyMax { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The number of minutes from the event. If the event code does not indicate whether the minutes is before or after the event, then the offset is assumed to be after the event.</summary>
        public decimal Offset { get; set; }
        ///<summary>May contain extended information for property: 'Offset'</summary>
        public Element _Offset { get; set; }
        ///<summary>Indicates the duration of time over which repetitions are to occur; e.g. to express "3 times per day", 3 would be the frequency and "1 day" would be the period. If periodMax is present, this element indicates the lower bound of the allowed range of the period length.</summary>
        public decimal Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>If present, indicates that the period is a range from [period] to [periodMax], allowing expressing concepts such as "do this once every 3-5 days.</summary>
        public decimal PeriodMax { get; set; }
        ///<summary>May contain extended information for property: 'PeriodMax'</summary>
        public Element _PeriodMax { get; set; }
        ///<summary>The units of time for the period in UCUM units.</summary>
        public string PeriodUnit { get; set; }
        ///<summary>May contain extended information for property: 'PeriodUnit'</summary>
        public Element _PeriodUnit { get; set; }
        ///<summary>Specified time of day for action to take place.</summary>
        public string[] TimeOfDay { get; set; }
        ///<summary>May contain extended information for property: 'TimeOfDay'</summary>
        public Element[] _TimeOfDay { get; set; }
        ///<summary>An approximate time period during the day, potentially linked to an event of daily living that indicates when the action should occur.</summary>
        public string[] When { get; set; }
        ///<summary>May contain extended information for property: 'When'</summary>
        public Element[] _When { get; set; }
    }
    ///<summary>
    ///Describes a stream of resource state changes identified by trigger criteria and annotated with labels useful to filter projections from this topic.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\topic.profile.canonical.json</source-file>
    public class Topic : DomainResource
    {
        ///<summary>Resource Type Name (for serialization)</summary>
        public string ResourceType => "Topic";
        ///<summary>The date on which the asset content was approved by the publisher. Approval happens once when the content is officially approved for usage.</summary>
        public string ApprovalDate { get; set; }
        ///<summary>May contain extended information for property: 'ApprovalDate'</summary>
        public Element _ApprovalDate { get; set; }
        ///<summary>List of properties by which messages on the topic can be filtered.</summary>
        public TopicCanFilterBy[] CanFilterBy { get; set; }
        ///<summary>May contain extended information for property: 'CanFilterBy'</summary>
        public Element[] _CanFilterBy { get; set; }
        ///<summary>Contact details to assist a user in finding and communicating with the publisher.</summary>
        public ContactDetail[] Contact { get; set; }
        ///<summary>May contain extended information for property: 'Contact'</summary>
        public Element[] _Contact { get; set; }
        ///<summary>These resources do not have an independent existence apart from the resource that contains them - they cannot be identified independently, and nor can they have their own independent transaction scope.</summary>
        public Resource[] Contained { get; set; }
        ///<summary>May contain extended information for property: 'Contained'</summary>
        public Element[] _Contained { get; set; }
        ///<summary>A copyright statement relating to the Topic and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the Topic.</summary>
        public string Copyright { get; set; }
        ///<summary>May contain extended information for property: 'Copyright'</summary>
        public Element _Copyright { get; set; }
        ///<summary>For draft definitions, indicates the date of initial creation.  For active definitions, represents the date of activation.  For withdrawn definitions, indicates the date of withdrawal.</summary>
        public string Date { get; set; }
        ///<summary>May contain extended information for property: 'Date'</summary>
        public Element _Date { get; set; }
        ///<summary>The canonical URL pointing to another FHIR-defined Topic that is adhered to in whole or in part by this Topic.</summary>
        public string[] DerivedFromCanonical { get; set; }
        ///<summary>May contain extended information for property: 'DerivedFromCanonical'</summary>
        public Element[] _DerivedFromCanonical { get; set; }
        ///<summary>The URL pointing to an externally-defined subscription topic or other definition that is adhered to in whole or in part by this definition.</summary>
        public string[] DerivedFromUri { get; set; }
        ///<summary>May contain extended information for property: 'DerivedFromUri'</summary>
        public Element[] _DerivedFromUri { get; set; }
        ///<summary>A free text natural language description of the Topic from the consumer's perspective.</summary>
        public string Description { get; set; }
        ///<summary>May contain extended information for property: 'Description'</summary>
        public Element _Description { get; set; }
        ///<summary>The period during which the Topic content was or is planned to be effective.</summary>
        public Period EffectivePeriod { get; set; }
        ///<summary>May contain extended information for property: 'EffectivePeriod'</summary>
        public Element _EffectivePeriod { get; set; }
        ///<summary>A flag to indicate that this Topic is authored for testing purposes (or education/evaluation/marketing), and is not intended to be used for genuine usage.</summary>
        public bool Experimental { get; set; }
        ///<summary>May contain extended information for property: 'Experimental'</summary>
        public Element _Experimental { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Business identifiers assigned to this Topic by the performer and/or other systems.  These identifiers remain constant as the resource is updated and propagates from server to server.</summary>
        public Identifier[] Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element[] _Identifier { get; set; }
        ///<summary>A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</summary>
        public string ImplicitRules { get; set; }
        ///<summary>May contain extended information for property: 'ImplicitRules'</summary>
        public Element _ImplicitRules { get; set; }
        ///<summary>A jurisdiction in which the Topic is intended to be used.</summary>
        public CodeableConcept[] Jurisdiction { get; set; }
        ///<summary>May contain extended information for property: 'Jurisdiction'</summary>
        public Element[] _Jurisdiction { get; set; }
        ///<summary>The base language in which the resource is written.</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>The date on which the asset content was last reviewed. Review happens periodically after that, but doesn't change the original approval date.</summary>
        public string LastReviewDate { get; set; }
        ///<summary>May contain extended information for property: 'LastReviewDate'</summary>
        public Element _LastReviewDate { get; set; }
        ///<summary>The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.</summary>
        public Meta Meta { get; set; }
        ///<summary>May contain extended information for property: 'Meta'</summary>
        public Element _Meta { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource and that modifies the understanding of the element that contains it and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer is allowed to define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>Helps establish the "authority/credibility" of the Topic.  May also allow for contact.</summary>
        public Reference Publisher { get; set; }
        ///<summary>May contain extended information for property: 'Publisher'</summary>
        public Element _Publisher { get; set; }
        ///<summary>Explains why this Topic is needed and why it has been designed as it has.</summary>
        public string Purpose { get; set; }
        ///<summary>May contain extended information for property: 'Purpose'</summary>
        public Element _Purpose { get; set; }
        ///<summary>The criteria for including updates to a nominated resource in the topic.  Thie criteria may be just a human readable description and/or a full FHIR search string or FHIRPath expression.</summary>
        public TopicResourceTrigger ResourceTrigger { get; set; }
        ///<summary>May contain extended information for property: 'ResourceTrigger'</summary>
        public Element _ResourceTrigger { get; set; }
        ///<summary>The current state of the Topic.</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
        ///<summary>A human-readable narrative that contains a summary of the resource and can be used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it "clinically safe" for a human to just read the narrative. Resource definitions may define what content should be represented in the narrative to ensure clinical safety.</summary>
        public Narrative Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>A short, descriptive, user-friendly title for the Topic, for example, "admission".</summary>
        public string Title { get; set; }
        ///<summary>May contain extended information for property: 'Title'</summary>
        public Element _Title { get; set; }
        ///<summary>An absolute URL that is used to identify this Topic when it is referenced in a specification, model, design or an instance. This SHALL be a URL, SHOULD be globally unique, and SHOULD be an address at which this Topic is (or will be) published. The URL SHOULD include the major version of the Topic. For more information see [Technical and Business Versions](resource.html#versions).</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
        ///<summary>The content was developed with a focus and intent of supporting the contexts that are listed. These terms may be used to assist with indexing and searching of code system definitions.</summary>
        public UsageContext[] UseContext { get; set; }
        ///<summary>May contain extended information for property: 'UseContext'</summary>
        public Element[] _UseContext { get; set; }
        ///<summary>The identifier that is used to identify this version of the Topic when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the Topic author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions are orderable.</summary>
        public string Version { get; set; }
        ///<summary>May contain extended information for property: 'Version'</summary>
        public Element _Version { get; set; }
    }
    ///<summary>
    ///List of properties by which messages on the topic can be filtered.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\topic.profile.canonical.json</source-file>
    public class TopicCanFilterBy : Element
    {
        ///<summary>Description of how this filter parameter is intended to be used.</summary>
        public string Documentation { get; set; }
        ///<summary>May contain extended information for property: 'Documentation'</summary>
        public Element _Documentation { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>Allowable operators to apply when determining matches (Search Modifiers).</summary>
        public string[] MatchType { get; set; }
        ///<summary>May contain extended information for property: 'MatchType'</summary>
        public Element[] _MatchType { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>A search parameter (like "patient") which is a label for the filter.</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
    }
    ///<summary>
    ///The criteria for including updates to a nominated resource in the topic.  Thie criteria may be just a human readable description and/or a full FHIR search string or FHIRPath expression.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\topic.profile.canonical.json</source-file>
    public class TopicResourceTrigger : Element
    {
        ///<summary>The human readable description of what triggers inclusion into this topic -  for example, "Beginning of a clinical encounter".</summary>
        public string Description { get; set; }
        ///<summary>May contain extended information for property: 'Description'</summary>
        public Element _Description { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>The FHIRPath based rules that the server should use to determine when to trigger a notification for this topic.</summary>
        public string FhirPathCriteria { get; set; }
        ///<summary>May contain extended information for property: 'FhirPathCriteria'</summary>
        public Element _FhirPathCriteria { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>The REST interaction based rules that the server should use to determine when to trigger a notification for this topic.</summary>
        public string[] MethodCriteria { get; set; }
        ///<summary>May contain extended information for property: 'MethodCriteria'</summary>
        public Element[] _MethodCriteria { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The FHIR query based rules that the server should use to determine when to trigger a notification for this topic.</summary>
        public TopicResourceTriggerQueryCriteria QueryCriteria { get; set; }
        ///<summary>May contain extended information for property: 'QueryCriteria'</summary>
        public Element _QueryCriteria { get; set; }
        ///<summary>The list of resource types that are candidates for this topic.  For example, the Encounter resource is updated in an 'admission' topic.</summary>
        public string[] ResourceType { get; set; }
        ///<summary>May contain extended information for property: 'ResourceType'</summary>
        public Element[] _ResourceType { get; set; }
    }
    ///<summary>
    ///The FHIR query based rules that the server should use to determine when to trigger a notification for this topic.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\topic.profile.canonical.json</source-file>
    public class TopicResourceTriggerQueryCriteria : Element
    {
        ///<summary>The FHIR query based rules are applied to the current resource state.</summary>
        public string Current { get; set; }
        ///<summary>May contain extended information for property: 'Current'</summary>
        public Element _Current { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself).</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>The FHIR query based rules are applied to the previous resource state.</summary>
        public string Previous { get; set; }
        ///<summary>May contain extended information for property: 'Previous'</summary>
        public Element _Previous { get; set; }
        ///<summary>If set to true, both current and previous criteria must evaluate true to  trigger a notification for this topic.  Otherwise a notification for this topic will be triggered if either one evaluates to true.</summary>
        public bool RequireBoth { get; set; }
        ///<summary>May contain extended information for property: 'RequireBoth'</summary>
        public Element _RequireBoth { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for TriggerDefinition Type: A description of a triggering event. Triggering events can be named events, data events, or periodic, as determined by the type element.
    ///</summary>
    ///<source-file>c:/git/fhir\publish\triggerdefinition.profile.canonical.json</source-file>
    public class TriggerDefinition : Element
    {
        ///<summary>A boolean-valued expression that is evaluated in the context of the container of the trigger definition and returns whether or not the trigger fires.</summary>
        public Expression Condition { get; set; }
        ///<summary>May contain extended information for property: 'Condition'</summary>
        public Element _Condition { get; set; }
        ///<summary>The triggering data of the event (if this is a data trigger). If more than one data is requirement is specified, then all the data requirements must be true.</summary>
        public DataRequirement[] Data { get; set; }
        ///<summary>May contain extended information for property: 'Data'</summary>
        public Element[] _Data { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A formal name for the event. This may be an absolute URI that identifies the event formally (e.g. from a trigger registry), or a simple relative URI that identifies the event in a local context.</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>The timing of the event (if this is a periodic trigger).</summary>
        public string TimingDate { get; set; }
        ///<summary>May contain extended information for property: 'TimingDate'</summary>
        public Element _TimingDate { get; set; }
        ///<summary>The timing of the event (if this is a periodic trigger).</summary>
        public string TimingDateTime { get; set; }
        ///<summary>May contain extended information for property: 'TimingDateTime'</summary>
        public Element _TimingDateTime { get; set; }
        ///<summary>The timing of the event (if this is a periodic trigger).</summary>
        public Reference TimingReference { get; set; }
        ///<summary>May contain extended information for property: 'TimingReference'</summary>
        public Element _TimingReference { get; set; }
        ///<summary>The timing of the event (if this is a periodic trigger).</summary>
        public Timing TimingTiming { get; set; }
        ///<summary>May contain extended information for property: 'TimingTiming'</summary>
        public Element _TimingTiming { get; set; }
        ///<summary>The type of triggering event.</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Base StructureDefinition for UsageContext Type: Specifies clinical/business/etc. metadata that can be used to retrieve, index and/or categorize an artifact. This metadata can either be specific to the applicable population (e.g., age category, DRG) or the specific context of care (e.g., venue, care setting, provider of care).
    ///</summary>
    ///<source-file>c:/git/fhir\publish\usagecontext.profile.canonical.json</source-file>
    public class UsageContext : Element
    {
        ///<summary>A code that identifies the type of context being specified by this usage context.</summary>
        public Coding Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A value that defines the context specified in this context of use. The interpretation of the value is defined by the code.</summary>
        public CodeableConcept ValueCodeableConcept { get; set; }
        ///<summary>May contain extended information for property: 'ValueCodeableConcept'</summary>
        public Element _ValueCodeableConcept { get; set; }
        ///<summary>A value that defines the context specified in this context of use. The interpretation of the value is defined by the code.</summary>
        public Quantity ValueQuantity { get; set; }
        ///<summary>May contain extended information for property: 'ValueQuantity'</summary>
        public Element _ValueQuantity { get; set; }
        ///<summary>A value that defines the context specified in this context of use. The interpretation of the value is defined by the code.</summary>
        public Range ValueRange { get; set; }
        ///<summary>May contain extended information for property: 'ValueRange'</summary>
        public Element _ValueRange { get; set; }
        ///<summary>A value that defines the context specified in this context of use. The interpretation of the value is defined by the code.</summary>
        public Reference ValueReference { get; set; }
        ///<summary>May contain extended information for property: 'ValueReference'</summary>
        public Element _ValueReference { get; set; }
    }
} // close namespace: fhir
