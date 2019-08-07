/** GENERATED FILE on: 7/31/2019 4:41:19 PM **/

using System;
using System.Collections.Generic;

namespace fhir
{
    ///<summary>
    ///An address expressed using postal conventions (as opposed to GPS or other location definition formats).  This data type may be used to convey addresses for use in delivering mail as well as for visiting locations which might not be valid for mail delivery.  There are a variety of postal address formats defined around the world.
    ///</summary>
    ///<source-file>address.xml</source-file>
    public class Address : Element
    {
        ///<summary>The name of the city, town, suburb, village or other community or delivery center</summary>
        public string City { get; set; }
        ///<summary>May contain extended information for property: 'City'</summary>
        public Element _City { get; set; }
        ///<summary>Country - a nation as commonly understood or generally accepted</summary>
        public string Country { get; set; }
        ///<summary>May contain extended information for property: 'Country'</summary>
        public Element _Country { get; set; }
        ///<summary>The name of the administrative area (county)</summary>
        public string District { get; set; }
        ///<summary>May contain extended information for property: 'District'</summary>
        public Element _District { get; set; }
        ///<summary>This component contains the house number, apartment number, street name, street direction,  P.O. Box number, delivery hints, and similar address information</summary>
        public string[] Line { get; set; }
        ///<summary>May contain extended information for property: 'Line'</summary>
        public Element[] _Line { get; set; }
        ///<summary>Time period when address was/is in use</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>A postal code designating a region defined by the postal service</summary>
        public string PostalCode { get; set; }
        ///<summary>May contain extended information for property: 'PostalCode'</summary>
        public Element _PostalCode { get; set; }
        ///<summary>Sub-unit of a country with limited sovereignty in a federally organized country. A code may be used if codes are in common use (e.g. US 2 letter state codes)</summary>
        public string State { get; set; }
        ///<summary>May contain extended information for property: 'State'</summary>
        public Element _State { get; set; }
        ///<summary>Specifies the entire address as it should be displayed e.g. on a postal label. This may be provided instead of or as well as the specific parts</summary>
        public string Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>Distinguishes between physical addresses (those you can visit) and mailing addresses (e.g. PO Boxes and care-of addresses). Most addresses are both</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
        ///<summary>The purpose of this address</summary>
        public string Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
    }
    ///<summary>
    ///A  text note which also  contains information about who made the statement and when
    ///</summary>
    ///<source-file>annotation.xml</source-file>
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
        ///<summary>The text of the annotation in markdown format</summary>
        public string Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>Indicates when this particular annotation was made</summary>
        public string Time { get; set; }
        ///<summary>May contain extended information for property: 'Time'</summary>
        public Element _Time { get; set; }
    }
    ///<summary>
    ///For referring to data content defined in other formats.
    ///</summary>
    ///<source-file>attachment.xml</source-file>
    public class Attachment : Element
    {
        ///<summary>Identifies the type of the data in the attachment and allows a method to be chosen to interpret or render the data. Includes mime type parameters such as charset where appropriate</summary>
        public string ContentType { get; set; }
        ///<summary>May contain extended information for property: 'ContentType'</summary>
        public Element _ContentType { get; set; }
        ///<summary>The date that the attachment was first created</summary>
        public string Creation { get; set; }
        ///<summary>May contain extended information for property: 'Creation'</summary>
        public Element _Creation { get; set; }
        ///<summary>The actual data of the attachment - a sequence of bytes, base64 encoded</summary>
        public string Data { get; set; }
        ///<summary>May contain extended information for property: 'Data'</summary>
        public Element _Data { get; set; }
        ///<summary>The calculated hash of the data using SHA-1. Represented using base64.</summary>
        public string Hash { get; set; }
        ///<summary>May contain extended information for property: 'Hash'</summary>
        public Element _Hash { get; set; }
        ///<summary>The human language of the content. The value can be any valid value according to BCP 47</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>The number of bytes of data that make up this attachment (before base64 encoding, if that is done).</summary>
        public decimal Size { get; set; }
        ///<summary>May contain extended information for property: 'Size'</summary>
        public Element _Size { get; set; }
        ///<summary>A label or set of text to display in place of the data</summary>
        public string Title { get; set; }
        ///<summary>May contain extended information for property: 'Title'</summary>
        public Element _Title { get; set; }
        ///<summary>A location where the data can be accessed</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
    }
    ///<summary>
    ///Base definition for all elements that are defined inside a resource - but not those in a data type
    ///</summary>
    ///<source-file>backboneelement.xml</source-file>
    public class BackboneElement : Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself)</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
    }
    ///<summary>
    ///A container for a collection of resources.
    ///</summary>
    ///<source-file>bundle-spreadsheet.xml</source-file>
    public class Bundle : Resource
    {
        ///<summary>An entry in a bundle resource - will either contain a resource or information about a resource (transactions and history only)</summary>
        public BundleEntry[] Entry { get; set; }
        ///<summary>May contain extended information for property: 'Entry'</summary>
        public Element[] _Entry { get; set; }
        ///<summary>A persistent identifier for the bundle that won't change as a bundle is copied from server to server. </summary>
        public Identifier Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element _Identifier { get; set; }
        ///<summary>A series of links that provide context to this bundle </summary>
        public BundleLink[] Link { get; set; }
        ///<summary>May contain extended information for property: 'Link'</summary>
        public Element[] _Link { get; set; }
        ///<summary>Digital Signature - base64 encoded. XML-DSig or a JWT</summary>
        public Signature Signature { get; set; }
        ///<summary>May contain extended information for property: 'Signature'</summary>
        public Element _Signature { get; set; }
        ///<summary>The date/time that the bundle was assembled - i.e. when the resources were placed in the bundle</summary>
        public string Timestamp { get; set; }
        ///<summary>May contain extended information for property: 'Timestamp'</summary>
        public Element _Timestamp { get; set; }
        ///<summary>If a set of search matches, this is the total number of entries of type 'match' across all pages in the search.  It does not include search.mode = 'include' or 'outcome' entries and it does not provide a count of the number of entries in the Bundle</summary>
        public decimal Total { get; set; }
        ///<summary>May contain extended information for property: 'Total'</summary>
        public Element _Total { get; set; }
        ///<summary>Indicates the purpose of this bundle - how it is intended to be used</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///An entry in a bundle resource - will either contain a resource or information about a resource (transactions and history only)
    ///</summary>
    ///<source-file>bundle-spreadsheet.xml</source-file>
    public class BundleEntry : Element
    {
        ///<summary>The Absolute URL for the resource.  The fullUrl SHALL NOT disagree with the id in the resource - i.e. if the fullUrl is not a urn:uuid, the URL shall be version-independent URL consistent with the Resource.id. The fullUrl is a version independent reference to the resource. The fullUrl element SHALL have a value except that: 
        /// * fullUrl can be empty on a POST (although it does not need to when specifying a temporary id for reference in the bundle)
        /// * Results from operations might involve resources that are not identified.</summary>
        public string FullUrl { get; set; }
        ///<summary>May contain extended information for property: 'FullUrl'</summary>
        public Element _FullUrl { get; set; }
        ///<summary>A series of links that provide context to this entry </summary>
        public BundleLink[] Link { get; set; }
        ///<summary>May contain extended information for property: 'Link'</summary>
        public Element[] _Link { get; set; }
        ///<summary>Additional information about how this entry should be processed as part of a transaction or batch.  For history, it shows how the entry was processed to create the version contained in the entry</summary>
        public BundleEntryRequest Request { get; set; }
        ///<summary>May contain extended information for property: 'Request'</summary>
        public Element _Request { get; set; }
        ///<summary>The Resource for the entry. The purpose/meaning of the resource is determined by the Bundle.type</summary>
        public Resource Resource { get; set; }
        ///<summary>May contain extended information for property: 'Resource'</summary>
        public Element _Resource { get; set; }
        ///<summary>Indicates the results of processing the corresponding 'request' entry in the batch or transaction being responded to or what the results of an operation where when returning history</summary>
        public BundleEntryResponse Response { get; set; }
        ///<summary>May contain extended information for property: 'Response'</summary>
        public Element _Response { get; set; }
        ///<summary>Information about the search process that lead to the creation of this entry</summary>
        public BundleEntrySearch Search { get; set; }
        ///<summary>May contain extended information for property: 'Search'</summary>
        public Element _Search { get; set; }
    }
    ///<summary>
    ///Additional information about how this entry should be processed as part of a transaction or batch.  For history, it shows how the entry was processed to create the version contained in the entry
    ///</summary>
    ///<source-file>bundle-spreadsheet.xml</source-file>
    public class BundleEntryRequest : Element
    {
        ///<summary>Only perform the operation if the Etag value matches. For more information, see the API section ["Managing Resource Contention"](http.html#concurrency)</summary>
        public string IfMatch { get; set; }
        ///<summary>May contain extended information for property: 'IfMatch'</summary>
        public Element _IfMatch { get; set; }
        ///<summary>Only perform the operation if the last updated date matches. See the API documentation for ["Conditional Read"](http.html#cread)</summary>
        public string IfModifiedSince { get; set; }
        ///<summary>May contain extended information for property: 'IfModifiedSince'</summary>
        public Element _IfModifiedSince { get; set; }
        ///<summary>Instruct the server not to perform the create if a specified resource already exists. For further information, see the API documentation for ["Conditional Create"](http.html#ccreate). This is just the query portion of the URL - what follows the "?" (not including the "?")</summary>
        public string IfNoneExist { get; set; }
        ///<summary>May contain extended information for property: 'IfNoneExist'</summary>
        public Element _IfNoneExist { get; set; }
        ///<summary>If the ETag values match, return a 304 Not Modified status. See the API documentation for ["Conditional Read"](http.html#cread)</summary>
        public string IfNoneMatch { get; set; }
        ///<summary>May contain extended information for property: 'IfNoneMatch'</summary>
        public Element _IfNoneMatch { get; set; }
        ///<summary>In a transaction or batch, this is the HTTP action to be executed for this entry. In a history bundle, this indicates the HTTP action that occurred.</summary>
        public string Method { get; set; }
        ///<summary>May contain extended information for property: 'Method'</summary>
        public Element _Method { get; set; }
        ///<summary>The URL for this entry, relative to the root (the address to which the request is posted)</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
    }
    ///<summary>
    ///Indicates the results of processing the corresponding 'request' entry in the batch or transaction being responded to or what the results of an operation where when returning history
    ///</summary>
    ///<source-file>bundle-spreadsheet.xml</source-file>
    public class BundleEntryResponse : Element
    {
        ///<summary>The Etag for the resource, if the operation for the entry produced a versioned resource (see [Resource Metadata and Versioning](http.html#versioning) and [Managing Resource Contention](http.html#concurrency))</summary>
        public string Etag { get; set; }
        ///<summary>May contain extended information for property: 'Etag'</summary>
        public Element _Etag { get; set; }
        ///<summary>The date/time that the resource was modified on the server</summary>
        public string LastModified { get; set; }
        ///<summary>May contain extended information for property: 'LastModified'</summary>
        public Element _LastModified { get; set; }
        ///<summary>The location header created by processing this operation, populated if the operation returns a location</summary>
        public string Location { get; set; }
        ///<summary>May contain extended information for property: 'Location'</summary>
        public Element _Location { get; set; }
        ///<summary>An OperationOutcome containing hints and warnings produced as part of processing this entry in a batch or transaction</summary>
        public Resource Outcome { get; set; }
        ///<summary>May contain extended information for property: 'Outcome'</summary>
        public Element _Outcome { get; set; }
        ///<summary>The status code returned by processing this entry. The status SHALL start with a 3 digit HTTP code (e.g. 404) and may contain the standard HTTP description associated with the status code</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
    }
    ///<summary>
    ///Information about the search process that lead to the creation of this entry
    ///</summary>
    ///<source-file>bundle-spreadsheet.xml</source-file>
    public class BundleEntrySearch : Element
    {
        ///<summary>Why this entry is in the result set - whether it's included as a match or because of an _include requirement, or to convey information or warning information about the search process</summary>
        public string Mode { get; set; }
        ///<summary>May contain extended information for property: 'Mode'</summary>
        public Element _Mode { get; set; }
        ///<summary>When searching, the server's search ranking score for the entry</summary>
        public decimal Score { get; set; }
        ///<summary>May contain extended information for property: 'Score'</summary>
        public Element _Score { get; set; }
    }
    ///<summary>
    ///A series of links that provide context to this bundle 
    ///</summary>
    ///<source-file>bundle-spreadsheet.xml</source-file>
    public class BundleLink : Element
    {
        ///<summary>A name which details the functional use for this link - see [http://www.iana.org/assignments/link-relations/link-relations.xhtml#link-relations-1](http://www.iana.org/assignments/link-relations/link-relations.xhtml#link-relations-1)</summary>
        public string Relation { get; set; }
        ///<summary>May contain extended information for property: 'Relation'</summary>
        public Element _Relation { get; set; }
        ///<summary>The reference details for the link</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
    }
    ///<summary>
    ///A concept that may be defined by a formal reference to a terminology or ontology or may be provided by text
    ///</summary>
    ///<source-file>codeableconcept.xml</source-file>
    public class CodeableConcept : Element
    {
        ///<summary>A reference to a code defined by a terminology system </summary>
        public Coding[] Coding { get; set; }
        ///<summary>May contain extended information for property: 'Coding'</summary>
        public Element[] _Coding { get; set; }
        ///<summary>A human language representation of the concept as seen/selected/uttered by the user who entered the data and/or which represents the intended meaning of the user</summary>
        public string Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
    }
    ///<summary>
    ///A reference to a code defined by a terminology system 
    ///</summary>
    ///<source-file>coding.xml</source-file>
    public class Coding : Element
    {
        ///<summary>A symbol in syntax defined by the system. The symbol may be a predefined code or an expression in a syntax defined by the coding system (e.g. post-coordination)</summary>
        public string Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>A representation of the meaning of the code in the system, following the rules of the system</summary>
        public string Display { get; set; }
        ///<summary>May contain extended information for property: 'Display'</summary>
        public Element _Display { get; set; }
        ///<summary>The identification of the code system that defines the meaning of the symbol in the code. </summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>Indicates that this coding was chosen by a user directly - e.g. off a pick list of available items (codes or displays)</summary>
        public bool UserSelected { get; set; }
        ///<summary>May contain extended information for property: 'UserSelected'</summary>
        public Element _UserSelected { get; set; }
        ///<summary>The version of the code system which was used when choosing this code. Note that a well-maintained code system does not need the version reported, because the meaning of codes is consistent across versions. However this cannot consistently be assured, and when the meaning is not guaranteed to be consistent, the version SHOULD be exchanged</summary>
        public string Version { get; set; }
        ///<summary>May contain extended information for property: 'Version'</summary>
        public Element _Version { get; set; }
    }
    ///<summary>
    ///Specifies contact information for a person or organization
    ///</summary>
    ///<source-file>contactdetail.xml</source-file>
    public class ContactDetail : Element
    {
        ///<summary>The name of an individual to contact</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>The contact details for the individual (if a name was provided) or the organization</summary>
        public ContactPoint[] Telecom { get; set; }
        ///<summary>May contain extended information for property: 'Telecom'</summary>
        public Element[] _Telecom { get; set; }
    }
    ///<summary>
    ///Details for all kinds of technology mediated contact points for a person or organization, including telephone, email, etc.
    ///</summary>
    ///<source-file>contactpoint.xml</source-file>
    public class ContactPoint : Element
    {
        ///<summary>Time period when the contact point was/is in use</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>Specifies a preferred order in which to use a set of contacts. ContactPoints with lower rank values are more preferred than those with higher rank values</summary>
        public decimal Rank { get; set; }
        ///<summary>May contain extended information for property: 'Rank'</summary>
        public Element _Rank { get; set; }
        ///<summary>Telecommunications form for contact point - what communications system is required to make use of the contact</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>Identifies the purpose for the contact point</summary>
        public string Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
        ///<summary>The actual contact point details, in a form that is meaningful to the designated communication system (i.e. phone number or email address).</summary>
        public string Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///A contributor to the content of a knowledge asset, including authors, editors, reviewers, and endorsers
    ///</summary>
    ///<source-file>contributor.xml</source-file>
    public class Contributor : Element
    {
        ///<summary>Contact details to assist a user in finding and communicating with the contributor</summary>
        public ContactDetail[] Contact { get; set; }
        ///<summary>May contain extended information for property: 'Contact'</summary>
        public Element[] _Contact { get; set; }
        ///<summary>The name of the individual or organization responsible for the contribution</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>The type of contributor</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data
    ///</summary>
    ///<source-file>datarequirement.xml</source-file>
    public class DataRequirement : Element
    {
        ///<summary>Code filters specify additional constraints on the data, specifying the value set of interest for a particular element of the data. Each code filter defines an additional constraint on the data, i.e. code filters are AND'ed, not OR'ed</summary>
        public DataRequirementCodeFilter[] CodeFilter { get; set; }
        ///<summary>May contain extended information for property: 'CodeFilter'</summary>
        public Element[] _CodeFilter { get; set; }
        ///<summary>Date filters specify additional constraints on the data in terms of the applicable date range for specific elements. Each date filter specifies an additional constraint on the data, i.e. date filters are AND'ed, not OR'ed</summary>
        public DataRequirementDateFilter[] DateFilter { get; set; }
        ///<summary>May contain extended information for property: 'DateFilter'</summary>
        public Element[] _DateFilter { get; set; }
        ///<summary>Specifies a maximum number of results that are required (uses the _count search parameter)</summary>
        public decimal Limit { get; set; }
        ///<summary>May contain extended information for property: 'Limit'</summary>
        public Element _Limit { get; set; }
        ///<summary>Indicates that specific elements of the type are referenced by the knowledge module and must be supported by the consumer in order to obtain an effective evaluation. This does not mean that a value is required for this element, only that the consuming system must understand the element and be able to provide values for it if they are available. 
        /// 
        /// The value of mustSupport SHALL be a FHIRPath resolveable on the type of the DataRequirement. The path SHALL consist only of identifiers, constant indexers, and .resolve() (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details)</summary>
        public string[] MustSupport { get; set; }
        ///<summary>May contain extended information for property: 'MustSupport'</summary>
        public Element[] _MustSupport { get; set; }
        ///<summary>The profile of the required data, specified as the uri of the profile definition</summary>
        public string[] Profile { get; set; }
        ///<summary>May contain extended information for property: 'Profile'</summary>
        public Element[] _Profile { get; set; }
        ///<summary>Specifies the order of the results to be returned</summary>
        public DataRequirementSort[] Sort { get; set; }
        ///<summary>May contain extended information for property: 'Sort'</summary>
        public Element[] _Sort { get; set; }
        ///<summary>The intended subjects of the data requirement. If this element is not provided, a Patient subject is assumed</summary>
        public CodeableConcept SubjectCodeableConcept { get; set; }
        ///<summary>May contain extended information for property: 'SubjectCodeableConcept'</summary>
        public Element _SubjectCodeableConcept { get; set; }
        ///<summary>The intended subjects of the data requirement. If this element is not provided, a Patient subject is assumed</summary>
        public Reference SubjectReference { get; set; }
        ///<summary>May contain extended information for property: 'SubjectReference'</summary>
        public Element _SubjectReference { get; set; }
        ///<summary>The type of the required data, specified as the type name of a resource. For profiles, this value is set to the type of the base resource of the profile</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Code filters specify additional constraints on the data, specifying the value set of interest for a particular element of the data. Each code filter defines an additional constraint on the data, i.e. code filters are AND'ed, not OR'ed
    ///</summary>
    ///<source-file>datarequirement.xml</source-file>
    public class DataRequirementCodeFilter : Element
    {
        ///<summary>The codes for the code filter. If values are given, the filter will return only those data items for which the code-valued attribute specified by the path has a value that is one of the specified codes. If codes are specified in addition to a value set, the filter returns items matching a code in the value set or one of the specified codes</summary>
        public Coding[] Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element[] _Code { get; set; }
        ///<summary>The code-valued attribute of the filter. The specified path SHALL be a FHIRPath resolveable on the specified type of the DataRequirement, and SHALL consist only of identifiers, constant indexers, and .resolve(). The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details). Note that the index must be an integer constant. The path must resolve to an element of type code, Coding, or CodeableConcept</summary>
        public string Path { get; set; }
        ///<summary>May contain extended information for property: 'Path'</summary>
        public Element _Path { get; set; }
        ///<summary>A token parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type code, Coding, or CodeableConcept</summary>
        public string SearchParam { get; set; }
        ///<summary>May contain extended information for property: 'SearchParam'</summary>
        public Element _SearchParam { get; set; }
        ///<summary>The valueset for the code filter. The valueSet and code elements are additive. If valueSet is specified, the filter will return only those data items for which the value of the code-valued element specified in the path is a member of the specified valueset</summary>
        public string ValueSet { get; set; }
        ///<summary>May contain extended information for property: 'ValueSet'</summary>
        public Element _ValueSet { get; set; }
    }
    ///<summary>
    ///Date filters specify additional constraints on the data in terms of the applicable date range for specific elements. Each date filter specifies an additional constraint on the data, i.e. date filters are AND'ed, not OR'ed
    ///</summary>
    ///<source-file>datarequirement.xml</source-file>
    public class DataRequirementDateFilter : Element
    {
        ///<summary>The date-valued attribute of the filter. The specified path SHALL be a FHIRPath resolveable on the specified type of the DataRequirement, and SHALL consist only of identifiers, constant indexers, and .resolve(). The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details). Note that the index must be an integer constant. The path must resolve to an element of type date, dateTime, Period, Schedule, or Timing</summary>
        public string Path { get; set; }
        ///<summary>May contain extended information for property: 'Path'</summary>
        public Element _Path { get; set; }
        ///<summary>A date parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type date, dateTime, Period, Schedule, or Timing</summary>
        public string SearchParam { get; set; }
        ///<summary>May contain extended information for property: 'SearchParam'</summary>
        public Element _SearchParam { get; set; }
        ///<summary>The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now</summary>
        public string ValueDateTime { get; set; }
        ///<summary>May contain extended information for property: 'ValueDateTime'</summary>
        public Element _ValueDateTime { get; set; }
        ///<summary>The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now</summary>
        public Duration ValueDuration { get; set; }
        ///<summary>May contain extended information for property: 'ValueDuration'</summary>
        public Element _ValueDuration { get; set; }
        ///<summary>The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now</summary>
        public Period ValuePeriod { get; set; }
        ///<summary>May contain extended information for property: 'ValuePeriod'</summary>
        public Element _ValuePeriod { get; set; }
    }
    ///<summary>
    ///Specifies the order of the results to be returned
    ///</summary>
    ///<source-file>datarequirement.xml</source-file>
    public class DataRequirementSort : Element
    {
        ///<summary>The direction of the sort, ascending or descending</summary>
        public string Direction { get; set; }
        ///<summary>May contain extended information for property: 'Direction'</summary>
        public Element _Direction { get; set; }
        ///<summary>The attribute of the sort. The specified path must be resolvable from the type of the required data. The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements. Note that the index must be an integer constant</summary>
        public string Path { get; set; }
        ///<summary>May contain extended information for property: 'Path'</summary>
        public Element _Path { get; set; }
    }
    ///<summary>
    ///A resource that includes narrative, extensions, and contained resources.
    ///</summary>
    ///<source-file>domainresource-spreadsheet.xml</source-file>
    public class DomainResource : Resource
    {
        ///<summary>These resources do not have an independent existence apart from the resource that contains them - they cannot be identified independently, and nor can they have their own independent transaction scope</summary>
        public Resource[] Contained { get; set; }
        ///<summary>May contain extended information for property: 'Contained'</summary>
        public Element[] _Contained { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>May be used to represent additional information that is not part of the basic definition of the resource and that modifies the understanding of the element that contains it and/or the understanding of the containing element's descendants. Usually modifier elements provide negation or qualification. To make the use of extensions safe and manageable, there is a strict set of governance applied to the definition and use of extensions. Though any implementer is allowed to define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension. Applications processing a resource are required to check for modifier extensions.
        /// 
        /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource (including cannot change the meaning of modifierExtension itself)</summary>
        public Extension[] ModifierExtension { get; set; }
        ///<summary>May contain extended information for property: 'ModifierExtension'</summary>
        public Element[] _ModifierExtension { get; set; }
        ///<summary>A human-readable narrative that contains a summary of the resource and can be used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it "clinically safe" for a human to just read the narrative. Resource definitions may define what content should be represented in the narrative to ensure clinical safety</summary>
        public Narrative Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
    }
    ///<summary>
    ///A length of time
    ///</summary>
    ///<source-file>duration.xml</source-file>
    public class Duration : Quantity
    {
    }
    ///<summary>
    ///Base definition for all elements in a resource
    ///</summary>
    ///<source-file>element.xml</source-file>
    public class Element
    {
        ///<summary>May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension</summary>
        public Extension[] Extension { get; set; }
        ///<summary>May contain extended information for property: 'Extension'</summary>
        public Element[] _Extension { get; set; }
        ///<summary>Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
    }
    ///<summary>
    ///A expression that is evaluated in a specified context and returns a value. The context of use of the expression must specify the context in which the expression is evaluated, and how the result of the expression is used
    ///</summary>
    ///<source-file>expression.xml</source-file>
    public class Expression : Element
    {
        ///<summary>A brief, natural language description of the condition that effectively communicates the intended semantics </summary>
        public string Description { get; set; }
        ///<summary>May contain extended information for property: 'Description'</summary>
        public Element _Description { get; set; }
        ///<summary>An expression in the specified language that returns a value</summary>
        public string expression { get; set; }
        ///<summary>May contain extended information for property: 'expression'</summary>
        public Element _expression { get; set; }
        ///<summary>The media type of the language for the expression</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>A short name assigned to the expression to allow for multiple reuse of the expression in the context where it is defined</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>A URI that defines where the expression is found</summary>
        public string Reference { get; set; }
        ///<summary>May contain extended information for property: 'Reference'</summary>
        public Element _Reference { get; set; }
    }
    ///<summary>
    ///Optional Extension Element - found in all resources
    ///</summary>
    ///<source-file>extension.xml</source-file>
    public class Extension : Element
    {
        ///<summary>Source of the definition for the extension code - a logical name or a URL</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Structure ValueActionDefinition { get; set; }
        ///<summary>May contain extended information for property: 'ValueActionDefinition'</summary>
        public Element _ValueActionDefinition { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueActionDefinitionBehavior { get; set; }
        ///<summary>May contain extended information for property: 'ValueActionDefinitionBehavior'</summary>
        public Element _ValueActionDefinitionBehavior { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueActionDefinitionCustomization { get; set; }
        ///<summary>May contain extended information for property: 'ValueActionDefinitionCustomization'</summary>
        public Element _ValueActionDefinitionCustomization { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueActionDefinitionRelatedAction { get; set; }
        ///<summary>May contain extended information for property: 'ValueActionDefinitionRelatedAction'</summary>
        public Element _ValueActionDefinitionRelatedAction { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Address ValueAddress { get; set; }
        ///<summary>May contain extended information for property: 'ValueAddress'</summary>
        public Element _ValueAddress { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Quantity ValueAge { get; set; }
        ///<summary>May contain extended information for property: 'ValueAge'</summary>
        public Element _ValueAge { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Annotation ValueAnnotation { get; set; }
        ///<summary>May contain extended information for property: 'ValueAnnotation'</summary>
        public Element _ValueAnnotation { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Attachment ValueAttachment { get; set; }
        ///<summary>May contain extended information for property: 'ValueAttachment'</summary>
        public Element _ValueAttachment { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueBackboneElement { get; set; }
        ///<summary>May contain extended information for property: 'ValueBackboneElement'</summary>
        public Element _ValueBackboneElement { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueBase64Binary { get; set; }
        ///<summary>May contain extended information for property: 'ValueBase64Binary'</summary>
        public Element _ValueBase64Binary { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public bool ValueBoolean { get; set; }
        ///<summary>May contain extended information for property: 'ValueBoolean'</summary>
        public Element _ValueBoolean { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueCanonical { get; set; }
        ///<summary>May contain extended information for property: 'ValueCanonical'</summary>
        public Element _ValueCanonical { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueCode { get; set; }
        ///<summary>May contain extended information for property: 'ValueCode'</summary>
        public Element _ValueCode { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public CodeableConcept ValueCodeableConcept { get; set; }
        ///<summary>May contain extended information for property: 'ValueCodeableConcept'</summary>
        public Element _ValueCodeableConcept { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Coding ValueCoding { get; set; }
        ///<summary>May contain extended information for property: 'ValueCoding'</summary>
        public Element _ValueCoding { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public ContactDetail ValueContactDetail { get; set; }
        ///<summary>May contain extended information for property: 'ValueContactDetail'</summary>
        public Element _ValueContactDetail { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public ContactPoint ValueContactPoint { get; set; }
        ///<summary>May contain extended information for property: 'ValueContactPoint'</summary>
        public Element _ValueContactPoint { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Contributor ValueContributor { get; set; }
        ///<summary>May contain extended information for property: 'ValueContributor'</summary>
        public Element _ValueContributor { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Quantity ValueCount { get; set; }
        ///<summary>May contain extended information for property: 'ValueCount'</summary>
        public Element _ValueCount { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public DataRequirement ValueDataRequirement { get; set; }
        ///<summary>May contain extended information for property: 'ValueDataRequirement'</summary>
        public Element _ValueDataRequirement { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueDataRequirementCodeFilter { get; set; }
        ///<summary>May contain extended information for property: 'ValueDataRequirementCodeFilter'</summary>
        public Element _ValueDataRequirementCodeFilter { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueDataRequirementDateFilter { get; set; }
        ///<summary>May contain extended information for property: 'ValueDataRequirementDateFilter'</summary>
        public Element _ValueDataRequirementDateFilter { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueDataRequirementSort { get; set; }
        ///<summary>May contain extended information for property: 'ValueDataRequirementSort'</summary>
        public Element _ValueDataRequirementSort { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueDate { get; set; }
        ///<summary>May contain extended information for property: 'ValueDate'</summary>
        public Element _ValueDate { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueDateTime { get; set; }
        ///<summary>May contain extended information for property: 'ValueDateTime'</summary>
        public Element _ValueDateTime { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public decimal ValueDecimal { get; set; }
        ///<summary>May contain extended information for property: 'ValueDecimal'</summary>
        public Element _ValueDecimal { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Quantity ValueDistance { get; set; }
        ///<summary>May contain extended information for property: 'ValueDistance'</summary>
        public Element _ValueDistance { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public BackboneElement ValueDosage { get; set; }
        ///<summary>May contain extended information for property: 'ValueDosage'</summary>
        public Element _ValueDosage { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueDosageDoseAndRate { get; set; }
        ///<summary>May contain extended information for property: 'ValueDosageDoseAndRate'</summary>
        public Element _ValueDosageDoseAndRate { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Quantity ValueDuration { get; set; }
        ///<summary>May contain extended information for property: 'ValueDuration'</summary>
        public Element _ValueDuration { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public BackboneElement ValueElementDefinition { get; set; }
        ///<summary>May contain extended information for property: 'ValueElementDefinition'</summary>
        public Element _ValueElementDefinition { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueElementDefinitionBase { get; set; }
        ///<summary>May contain extended information for property: 'ValueElementDefinitionBase'</summary>
        public Element _ValueElementDefinitionBase { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueElementDefinitionBinding { get; set; }
        ///<summary>May contain extended information for property: 'ValueElementDefinitionBinding'</summary>
        public Element _ValueElementDefinitionBinding { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueElementDefinitionConstraint { get; set; }
        ///<summary>May contain extended information for property: 'ValueElementDefinitionConstraint'</summary>
        public Element _ValueElementDefinitionConstraint { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueElementDefinitionExample { get; set; }
        ///<summary>May contain extended information for property: 'ValueElementDefinitionExample'</summary>
        public Element _ValueElementDefinitionExample { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueElementDefinitionMapping { get; set; }
        ///<summary>May contain extended information for property: 'ValueElementDefinitionMapping'</summary>
        public Element _ValueElementDefinitionMapping { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueElementDefinitionSlicing { get; set; }
        ///<summary>May contain extended information for property: 'ValueElementDefinitionSlicing'</summary>
        public Element _ValueElementDefinitionSlicing { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueElementDefinitionSlicingDiscriminator { get; set; }
        ///<summary>May contain extended information for property: 'ValueElementDefinitionSlicingDiscriminator'</summary>
        public Element _ValueElementDefinitionSlicingDiscriminator { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueElementDefinitionType { get; set; }
        ///<summary>May contain extended information for property: 'ValueElementDefinitionType'</summary>
        public Element _ValueElementDefinitionType { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueExpression { get; set; }
        ///<summary>May contain extended information for property: 'ValueExpression'</summary>
        public Element _ValueExpression { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Extension ValueExtension { get; set; }
        ///<summary>May contain extended information for property: 'ValueExtension'</summary>
        public Element _ValueExtension { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public HumanName ValueHumanName { get; set; }
        ///<summary>May contain extended information for property: 'ValueHumanName'</summary>
        public Element _ValueHumanName { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueId { get; set; }
        ///<summary>May contain extended information for property: 'ValueId'</summary>
        public Element _ValueId { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Identifier ValueIdentifier { get; set; }
        ///<summary>May contain extended information for property: 'ValueIdentifier'</summary>
        public Element _ValueIdentifier { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueInstant { get; set; }
        ///<summary>May contain extended information for property: 'ValueInstant'</summary>
        public Element _ValueInstant { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public decimal ValueInteger { get; set; }
        ///<summary>May contain extended information for property: 'ValueInteger'</summary>
        public Element _ValueInteger { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueMarkdown { get; set; }
        ///<summary>May contain extended information for property: 'ValueMarkdown'</summary>
        public Element _ValueMarkdown { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public BackboneElement ValueMarketingStatus { get; set; }
        ///<summary>May contain extended information for property: 'ValueMarketingStatus'</summary>
        public Element _ValueMarketingStatus { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueMeta { get; set; }
        ///<summary>May contain extended information for property: 'ValueMeta'</summary>
        public Element _ValueMeta { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public ModuleMetadata ValueModuleMetadata { get; set; }
        ///<summary>May contain extended information for property: 'ValueModuleMetadata'</summary>
        public Element _ValueModuleMetadata { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Money ValueMoney { get; set; }
        ///<summary>May contain extended information for property: 'ValueMoney'</summary>
        public Element _ValueMoney { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Narrative ValueNarrative { get; set; }
        ///<summary>May contain extended information for property: 'ValueNarrative'</summary>
        public Element _ValueNarrative { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueOid { get; set; }
        ///<summary>May contain extended information for property: 'ValueOid'</summary>
        public Element _ValueOid { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public ParameterDefinition ValueParameterDefinition { get; set; }
        ///<summary>May contain extended information for property: 'ValueParameterDefinition'</summary>
        public Element _ValueParameterDefinition { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Period ValuePeriod { get; set; }
        ///<summary>May contain extended information for property: 'ValuePeriod'</summary>
        public Element _ValuePeriod { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public BackboneElement ValuePopulation { get; set; }
        ///<summary>May contain extended information for property: 'ValuePopulation'</summary>
        public Element _ValuePopulation { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public decimal ValuePositiveInt { get; set; }
        ///<summary>May contain extended information for property: 'ValuePositiveInt'</summary>
        public Element _ValuePositiveInt { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public BackboneElement ValueProdCharacteristic { get; set; }
        ///<summary>May contain extended information for property: 'ValueProdCharacteristic'</summary>
        public Element _ValueProdCharacteristic { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public BackboneElement ValueProductShelfLife { get; set; }
        ///<summary>May contain extended information for property: 'ValueProductShelfLife'</summary>
        public Element _ValueProductShelfLife { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Quantity ValueQuantity { get; set; }
        ///<summary>May contain extended information for property: 'ValueQuantity'</summary>
        public Element _ValueQuantity { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Range ValueRange { get; set; }
        ///<summary>May contain extended information for property: 'ValueRange'</summary>
        public Element _ValueRange { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Ratio ValueRatio { get; set; }
        ///<summary>May contain extended information for property: 'ValueRatio'</summary>
        public Element _ValueRatio { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Reference ValueReference { get; set; }
        ///<summary>May contain extended information for property: 'ValueReference'</summary>
        public Element _ValueReference { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public RelatedArtifact ValueRelatedArtifact { get; set; }
        ///<summary>May contain extended information for property: 'ValueRelatedArtifact'</summary>
        public Element _ValueRelatedArtifact { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public SampledData ValueSampledData { get; set; }
        ///<summary>May contain extended information for property: 'ValueSampledData'</summary>
        public Element _ValueSampledData { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Signature ValueSignature { get; set; }
        ///<summary>May contain extended information for property: 'ValueSignature'</summary>
        public Element _ValueSignature { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueString { get; set; }
        ///<summary>May contain extended information for property: 'ValueString'</summary>
        public Element _ValueString { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public BackboneElement ValueSubstanceAmount { get; set; }
        ///<summary>May contain extended information for property: 'ValueSubstanceAmount'</summary>
        public Element _ValueSubstanceAmount { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueSubstanceAmountReferenceRange { get; set; }
        ///<summary>May contain extended information for property: 'ValueSubstanceAmountReferenceRange'</summary>
        public Element _ValueSubstanceAmountReferenceRange { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public BackboneElement ValueSubstanceMoiety { get; set; }
        ///<summary>May contain extended information for property: 'ValueSubstanceMoiety'</summary>
        public Element _ValueSubstanceMoiety { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueTime { get; set; }
        ///<summary>May contain extended information for property: 'ValueTime'</summary>
        public Element _ValueTime { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public BackboneElement ValueTiming { get; set; }
        ///<summary>May contain extended information for property: 'ValueTiming'</summary>
        public Element _ValueTiming { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public Element ValueTimingRepeat { get; set; }
        ///<summary>May contain extended information for property: 'ValueTimingRepeat'</summary>
        public Element _ValueTimingRepeat { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public TriggerDefinition ValueTriggerDefinition { get; set; }
        ///<summary>May contain extended information for property: 'ValueTriggerDefinition'</summary>
        public Element _ValueTriggerDefinition { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public decimal ValueUnsignedInt { get; set; }
        ///<summary>May contain extended information for property: 'ValueUnsignedInt'</summary>
        public Element _ValueUnsignedInt { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueUri { get; set; }
        ///<summary>May contain extended information for property: 'ValueUri'</summary>
        public Element _ValueUri { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueUrl { get; set; }
        ///<summary>May contain extended information for property: 'ValueUrl'</summary>
        public Element _ValueUrl { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public UsageContext ValueUsageContext { get; set; }
        ///<summary>May contain extended information for property: 'ValueUsageContext'</summary>
        public Element _ValueUsageContext { get; set; }
        ///<summary>Value of extension - must be one of a constrained set of the data types (see [Extensibility](extensibility.html) for a list)</summary>
        public string ValueUuid { get; set; }
        ///<summary>May contain extended information for property: 'ValueUuid'</summary>
        public Element _ValueUuid { get; set; }
    }
    ///<summary>
    ///A human's name with the ability to identify parts and usage
    ///</summary>
    ///<source-file>humanname.xml</source-file>
    public class HumanName : Element
    {
        ///<summary>The part of a name that links to the genealogy. In some cultures (e.g. Eritrea) the family name of a son is the first name of his father.</summary>
        public string Family { get; set; }
        ///<summary>May contain extended information for property: 'Family'</summary>
        public Element _Family { get; set; }
        ///<summary>Given name</summary>
        public string[] Given { get; set; }
        ///<summary>May contain extended information for property: 'Given'</summary>
        public Element[] _Given { get; set; }
        ///<summary>Indicates the period of time when this name was valid for the named person.</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the start of the name</summary>
        public string[] Prefix { get; set; }
        ///<summary>May contain extended information for property: 'Prefix'</summary>
        public Element[] _Prefix { get; set; }
        ///<summary>Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the end of the name</summary>
        public string[] Suffix { get; set; }
        ///<summary>May contain extended information for property: 'Suffix'</summary>
        public Element[] _Suffix { get; set; }
        ///<summary>Specifies the entire name as it should be displayed e.g. on an application UI. This may be provided instead of or as well as the specific parts</summary>
        public string Text { get; set; }
        ///<summary>May contain extended information for property: 'Text'</summary>
        public Element _Text { get; set; }
        ///<summary>Identifies the purpose for this name</summary>
        public string Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
    }
    ///<summary>
    ///An identifier - identifies some entity uniquely and unambiguously. Typically this is used for business identifiers
    ///</summary>
    ///<source-file>identifier.xml</source-file>
    public class Identifier : Element
    {
        ///<summary>Organization that issued/manages the identifier</summary>
        public Reference Assigner { get; set; }
        ///<summary>May contain extended information for property: 'Assigner'</summary>
        public Element _Assigner { get; set; }
        ///<summary>Time period during which identifier is/was valid for use</summary>
        public Period Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>Establishes the namespace for the value - that is, a URL that describes a set values that are unique.</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>A coded type for the identifier that can be used to determine which identifier to use for a specific purpose</summary>
        public CodeableConcept Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
        ///<summary>The purpose of this identifier</summary>
        public string Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
        ///<summary>The portion of the identifier typically relevant to the user and which is unique within the context of the system</summary>
        public string Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///The metadata about a resource. This is content in the resource that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource
    ///</summary>
    ///<source-file>meta.xml</source-file>
    public class Meta : Element
    {
        ///<summary>When the resource last changed - e.g. when the version changed</summary>
        public string LastUpdated { get; set; }
        ///<summary>May contain extended information for property: 'LastUpdated'</summary>
        public Element _LastUpdated { get; set; }
        ///<summary>A list of profiles (references to [[[StructureDefinition]]] resources) that this resource claims to conform to. The URL is a reference to [[[StructureDefinition.url]]]</summary>
        public string[] Profile { get; set; }
        ///<summary>May contain extended information for property: 'Profile'</summary>
        public Element[] _Profile { get; set; }
        ///<summary>Security labels applied to this resource. These tags connect specific resources to the overall security policy and infrastructure</summary>
        public Coding[] Security { get; set; }
        ///<summary>May contain extended information for property: 'Security'</summary>
        public Element[] _Security { get; set; }
        ///<summary>A uri that identifies the source system of the resource. This provides a minimal amount of [[[Provenance]]] information that can be used to track or differentiate the source of information in the resource. The source may identify another FHIR server, document, message, database, etc.</summary>
        public string Source { get; set; }
        ///<summary>May contain extended information for property: 'Source'</summary>
        public Element _Source { get; set; }
        ///<summary>Tags applied to this resource. Tags are intended to be used to identify and relate resources to process and workflow, and applications are not required to consider the tags when interpreting the meaning of a resource</summary>
        public Coding[] Tag { get; set; }
        ///<summary>May contain extended information for property: 'Tag'</summary>
        public Element[] _Tag { get; set; }
        ///<summary>The version specific identifier, as it appears in the version portion of the URL. This value changes when the resource is created, updated, or deleted</summary>
        public string VersionId { get; set; }
        ///<summary>May contain extended information for property: 'VersionId'</summary>
        public Element _VersionId { get; set; }
    }
    ///<summary>
    ///The ModuleMetadata structure defines the common metadata elements used by quality improvement artifacts. This information includes descriptive and topical metadata to enable repository searches, as well as governance and evidentiary support information
    ///</summary>
    ///<source-file>modulemetadata.xml</source-file>
    public class ModuleMetadata : Element
    {
        ///<summary>Contact details to assist a user in finding and communicating with the publisher</summary>
        public ContactDetail[] Contact { get; set; }
        ///<summary>May contain extended information for property: 'Contact'</summary>
        public Element[] _Contact { get; set; }
        ///<summary>A contributor to the content of the module, including authors, editors, reviewers, and endorsers</summary>
        public Contributor[] Contributor { get; set; }
        ///<summary>May contain extended information for property: 'Contributor'</summary>
        public Element[] _Contributor { get; set; }
        ///<summary>A copyright statement relating to the module and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the module</summary>
        public string Copyright { get; set; }
        ///<summary>May contain extended information for property: 'Copyright'</summary>
        public Element _Copyright { get; set; }
        ///<summary>Specifies various attributes of the patient population for whom and/or environment of care in which the knowledge module is applicable</summary>
        public UsageContext[] Coverage { get; set; }
        ///<summary>May contain extended information for property: 'Coverage'</summary>
        public Element[] _Coverage { get; set; }
        ///<summary>A free text natural language description of the module from the consumer's perspective</summary>
        public string Description { get; set; }
        ///<summary>May contain extended information for property: 'Description'</summary>
        public Element _Description { get; set; }
        ///<summary>The period during which the module content is effective</summary>
        public Period EffectivePeriod { get; set; }
        ///<summary>May contain extended information for property: 'EffectivePeriod'</summary>
        public Element _EffectivePeriod { get; set; }
        ///<summary>Determines whether the module was developed for testing purposes (or education/evaluation/marketing), and is not intended to be used in production environments</summary>
        public bool Experimental { get; set; }
        ///<summary>May contain extended information for property: 'Experimental'</summary>
        public Element _Experimental { get; set; }
        ///<summary>A logical identifier for the module such as the CMS or NQF identifiers for a measure artifact. Note that at least one identifier is required for non-experimental active artifacts</summary>
        public Identifier[] Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element[] _Identifier { get; set; }
        ///<summary>The date on which the module content was last reviewed</summary>
        public string LastReviewDate { get; set; }
        ///<summary>May contain extended information for property: 'LastReviewDate'</summary>
        public Element _LastReviewDate { get; set; }
        ///<summary>A machine-friendly name for the module. This name should be usable as an identifier for the module by machine processing applications such as code generation</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>The date on which the module was published</summary>
        public string PublicationDate { get; set; }
        ///<summary>May contain extended information for property: 'PublicationDate'</summary>
        public Element _PublicationDate { get; set; }
        ///<summary>The name of the individual or organization that published the module (also known as the steward for the module). This information is required for non-experimental published artifacts</summary>
        public string Publisher { get; set; }
        ///<summary>May contain extended information for property: 'Publisher'</summary>
        public Element _Publisher { get; set; }
        ///<summary>A brief description of the purpose of the module</summary>
        public string Purpose { get; set; }
        ///<summary>May contain extended information for property: 'Purpose'</summary>
        public Element _Purpose { get; set; }
        ///<summary>Related resources such as additional documentation, justification, or bibliographic references</summary>
        public RelatedArtifact[] RelatedArtifact { get; set; }
        ///<summary>May contain extended information for property: 'RelatedArtifact'</summary>
        public Element[] _RelatedArtifact { get; set; }
        ///<summary>The status of the module</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
        ///<summary>A short, descriptive, user-friendly title for the module</summary>
        public string Title { get; set; }
        ///<summary>May contain extended information for property: 'Title'</summary>
        public Element _Title { get; set; }
        ///<summary>Clinical topics related to the content of the module</summary>
        public CodeableConcept[] Topic { get; set; }
        ///<summary>May contain extended information for property: 'Topic'</summary>
        public Element[] _Topic { get; set; }
        ///<summary>Identifies the type of knowledge module, such as a rule, library, documentation template, or measure</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
        ///<summary>An absolute URL that is used to identify this module when it is referenced. This SHALL be a URL, SHOULD be globally unique, and SHOULD be an address at which this module definition is (or will be) published</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
        ///<summary>A detailed description of how the module is used from a clinical perspective</summary>
        public string Usage { get; set; }
        ///<summary>May contain extended information for property: 'Usage'</summary>
        public Element _Usage { get; set; }
        ///<summary>The version of the module, if any. To provide a version consistent with the Decision Support Service specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning knowledge modules, refer to the Decision Support Service specification. Note that a version is required for non-experimental active artifacts</summary>
        public string Version { get; set; }
        ///<summary>May contain extended information for property: 'Version'</summary>
        public Element _Version { get; set; }
    }
    ///<summary>
    ///An amount of economic utility in some recognized currency
    ///</summary>
    ///<source-file>money.xml</source-file>
    public class Money : Element
    {
        ///<summary>ISO 4217 Currency Code</summary>
        public string Currency { get; set; }
        ///<summary>May contain extended information for property: 'Currency'</summary>
        public Element _Currency { get; set; }
        ///<summary>Numerical value (with implicit precision)</summary>
        public decimal Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///A human-readable summary of the resource conveying the essential clinical and business information for the resource
    ///</summary>
    ///<source-file>narrative.xml</source-file>
    public class Narrative : Element
    {
        ///<summary>The actual narrative content, a stripped down version of XHTML</summary>
        public string Div { get; set; }
        ///<summary>May contain extended information for property: 'Div'</summary>
        public Element _Div { get; set; }
        ///<summary>The status of the narrative - whether it's entirely generated (from just the defined data or the extensions too), or whether a human authored it and it may contain additional data</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
    }
    ///<summary>
    ///The parameters to the module. This collection specifies both the input and output parameters. Input parameters are provided by the caller as part of the $evaluate operation. Output parameters are included in the GuidanceResponse
    ///</summary>
    ///<source-file>parameterdefinition.xml</source-file>
    public class ParameterDefinition : Element
    {
        ///<summary>A brief discussion of what the parameter is for and how it is used by the module</summary>
        public string Documentation { get; set; }
        ///<summary>May contain extended information for property: 'Documentation'</summary>
        public Element _Documentation { get; set; }
        ///<summary>The maximum number of times this element is permitted to appear in the request or response</summary>
        public string Max { get; set; }
        ///<summary>May contain extended information for property: 'Max'</summary>
        public Element _Max { get; set; }
        ///<summary>The minimum number of times this parameter SHALL appear in the request or response</summary>
        public decimal Min { get; set; }
        ///<summary>May contain extended information for property: 'Min'</summary>
        public Element _Min { get; set; }
        ///<summary>The name of the parameter used to allow access to the value of the parameter in evaluation contexts</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>If specified, this indicates a profile that the input data must conform to, or that the output data will conform to</summary>
        public string Profile { get; set; }
        ///<summary>May contain extended information for property: 'Profile'</summary>
        public Element _Profile { get; set; }
        ///<summary>The type of the parameter</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
        ///<summary>Whether the parameter is input or output for the module</summary>
        public string Use { get; set; }
        ///<summary>May contain extended information for property: 'Use'</summary>
        public Element _Use { get; set; }
    }
    ///<summary>
    ///A time period defined by a start and end date and optionally time.
    ///</summary>
    ///<source-file>period.xml</source-file>
    public class Period : Element
    {
        ///<summary>The end of the period. If the end of the period is missing, it means no end was known or planned at the time the instance was created. The start may be in the past, and the end date in the future, which means that period is expected/planned to end at that time</summary>
        public string End { get; set; }
        ///<summary>May contain extended information for property: 'End'</summary>
        public Element _End { get; set; }
        ///<summary>The start of the period. The boundary is inclusive.</summary>
        public string Start { get; set; }
        ///<summary>May contain extended information for property: 'Start'</summary>
        public Element _Start { get; set; }
    }
    ///<summary>
    ///A measured amount (or an amount that can potentially be measured). Note that measured amounts include amounts that are not precisely quantified, including amounts involving arbitrary units and floating currencies
    ///</summary>
    ///<source-file>quantity.xml</source-file>
    public class Quantity : Element
    {
        ///<summary>A computer processable form of the unit in some unit representation system</summary>
        public string Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>How the value should be understood and represented - whether the actual value is greater or less than the stated value due to measurement issues; e.g. if the comparator is "<" , then the real value is < stated value</summary>
        public string Comparator { get; set; }
        ///<summary>May contain extended information for property: 'Comparator'</summary>
        public Element _Comparator { get; set; }
        ///<summary>The identification of the system that provides the coded form of the unit</summary>
        public string System { get; set; }
        ///<summary>May contain extended information for property: 'System'</summary>
        public Element _System { get; set; }
        ///<summary>A human-readable form of the unit</summary>
        public string Unit { get; set; }
        ///<summary>May contain extended information for property: 'Unit'</summary>
        public Element _Unit { get; set; }
        ///<summary>The value of the measured amount. The value includes an implicit precision in the presentation of the value</summary>
        public decimal Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///A set of ordered Quantities defined by a low and high limit. 
    ///</summary>
    ///<source-file>range.xml</source-file>
    public class Range : Element
    {
        ///<summary>The high limit. The boundary is inclusive. </summary>
        public SimpleQuantity High { get; set; }
        ///<summary>May contain extended information for property: 'High'</summary>
        public Element _High { get; set; }
        ///<summary>The low limit. The boundary is inclusive.</summary>
        public SimpleQuantity Low { get; set; }
        ///<summary>May contain extended information for property: 'Low'</summary>
        public Element _Low { get; set; }
    }
    ///<summary>
    ///A relationship of two Quantity values - expressed as a numerator and a denominator. 
    ///</summary>
    ///<source-file>ratio.xml</source-file>
    public class Ratio : Element
    {
        ///<summary>The value of the denominator</summary>
        public Quantity Denominator { get; set; }
        ///<summary>May contain extended information for property: 'Denominator'</summary>
        public Element _Denominator { get; set; }
        ///<summary>The value of the numerator</summary>
        public Quantity Numerator { get; set; }
        ///<summary>May contain extended information for property: 'Numerator'</summary>
        public Element _Numerator { get; set; }
    }
    ///<summary>
    ///A reference from one resource to another
    ///</summary>
    ///<source-file>reference.xml</source-file>
    public class Reference : Element
    {
        ///<summary>Plain text narrative that identifies the resource in addition to the resource reference </summary>
        public string Display { get; set; }
        ///<summary>May contain extended information for property: 'Display'</summary>
        public Element _Display { get; set; }
        ///<summary>An identifier for the target resource. This is used when there is no way to reference the other resource directly, either because the entity it represents is not available through a FHIR server, or because there is no way for the author of the resource to convert a known identifier to an actual location. There is no requirement that a Reference.identifier point to something that is actually exposed as a FHIR instance, but it SHALL point to a business concept that would be expected to be exposed as a FHIR instance, and that instance would need to be of a FHIR resource type allowed by the reference</summary>
        public Identifier Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element _Identifier { get; set; }
        ///<summary>A reference to a location at which the other resource is found. The reference may be a relative reference, in which case it is relative to the service base URL, or an absolute URL that resolves to the location where the resource is found. The reference may be version specific or not. If the reference is not to a FHIR RESTful server, then it should be assumed to be version specific. Internal fragment references (start with '#') refer to contained resources</summary>
        public string reference { get; set; }
        ///<summary>May contain extended information for property: 'reference'</summary>
        public Element _reference { get; set; }
        ///<summary>The expected type of the target of the reference. If both Reference.type and Reference.reference are populated and Reference.reference is a FHIR URL, both SHALL be consistent.
        /// 
        /// The type is the Canonical URL of Resource Definition that is the type this reference refers to. References are URLs that are relative to http://hl7.org/fhir/StructureDefinition/ e.g. "Patient" is a reference to http://hl7.org/fhir/StructureDefinition/Patient. Absolute URLs are only allowed for logical models (and can only be used in references in logical models, not resources)</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Related artifacts such as additional documentation, justification, or bibliographic references
    ///</summary>
    ///<source-file>relatedartifact.xml</source-file>
    public class RelatedArtifact : Element
    {
        ///<summary>A bibliographic citation for the related artifact. This text SHOULD be formatted according to an accepted citation format</summary>
        public string Citation { get; set; }
        ///<summary>May contain extended information for property: 'Citation'</summary>
        public Element _Citation { get; set; }
        ///<summary>A brief description of the document or knowledge resource being referenced, suitable for display to a consumer</summary>
        public string Display { get; set; }
        ///<summary>May contain extended information for property: 'Display'</summary>
        public Element _Display { get; set; }
        ///<summary>The document being referenced, represented as an attachment. This is exclusive with the resource element</summary>
        public Attachment Document { get; set; }
        ///<summary>May contain extended information for property: 'Document'</summary>
        public Element _Document { get; set; }
        ///<summary>A short label that can be used to reference the citation from elsewhere in the containing artifact, such as a footnote index</summary>
        public string Label { get; set; }
        ///<summary>May contain extended information for property: 'Label'</summary>
        public Element _Label { get; set; }
        ///<summary>The related resource, such as a library, value set, profile, or other knowledge resource</summary>
        public string Resource { get; set; }
        ///<summary>May contain extended information for property: 'Resource'</summary>
        public Element _Resource { get; set; }
        ///<summary>The type of relationship to the related artifact</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
        ///<summary>A url for the artifact that can be followed to access the actual content</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
    }
    ///<summary>
    ///This is the base resource type for everything.
    ///</summary>
    ///<source-file>resource-spreadsheet.xml</source-file>
    public class Resource
    {
        public string ResourceType { get; set; }
        ///<summary>The logical id of the resource, as used in the URL for the resource. Once assigned, this value never changes</summary>
        public string Id { get; set; }
        ///<summary>May contain extended information for property: 'Id'</summary>
        public Element _Id { get; set; }
        ///<summary>A reference to a set of rules that were followed when the resource was constructed, and which must be understood when processing the content. Often, this is a reference to an implementation guide that defines the special rules along with other profiles etc.</summary>
        public string ImplicitRules { get; set; }
        ///<summary>May contain extended information for property: 'ImplicitRules'</summary>
        public Element _ImplicitRules { get; set; }
        ///<summary>The base language in which the resource is written</summary>
        public string Language { get; set; }
        ///<summary>May contain extended information for property: 'Language'</summary>
        public Element _Language { get; set; }
        ///<summary>The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource</summary>
        public Meta Meta { get; set; }
        ///<summary>May contain extended information for property: 'Meta'</summary>
        public Element _Meta { get; set; }
    }
    ///<summary>
    ///A series of measurements taken by a device, with upper and lower limits. There may be more than one dimension in the data
    ///</summary>
    ///<source-file>sampleddata.xml</source-file>
    public class SampledData : Element
    {
        ///<summary>A series of data points which are decimal values separated by a single space (character u20). The special values "E" (error), "L" (below detection limit) and "U" (above detection limit) can also be used in place of a decimal value</summary>
        public string Data { get; set; }
        ///<summary>May contain extended information for property: 'Data'</summary>
        public Element _Data { get; set; }
        ///<summary>The number of sample points at each time point. If this value is greater than one, then the dimensions will be interlaced - all the sample points for a point in time will be recorded at once</summary>
        public decimal Dimensions { get; set; }
        ///<summary>May contain extended information for property: 'Dimensions'</summary>
        public Element _Dimensions { get; set; }
        ///<summary>A correction factor that is applied to the sampled data points before they are added to the origin</summary>
        public decimal Factor { get; set; }
        ///<summary>May contain extended information for property: 'Factor'</summary>
        public Element _Factor { get; set; }
        ///<summary>The lower limit of detection of the measured points. This is needed if any of the data points have the value "L" (lower than detection limit)</summary>
        public decimal LowerLimit { get; set; }
        ///<summary>May contain extended information for property: 'LowerLimit'</summary>
        public Element _LowerLimit { get; set; }
        ///<summary>The base quantity that a measured value of zero represents. In addition, this provides the units of the entire measurement series</summary>
        public SimpleQuantity Origin { get; set; }
        ///<summary>May contain extended information for property: 'Origin'</summary>
        public Element _Origin { get; set; }
        ///<summary>The length of time between sampling times, measured in milliseconds</summary>
        public decimal Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>The upper limit of detection of the measured points. This is needed if any of the data points have the value "U" (higher than detection limit)</summary>
        public decimal UpperLimit { get; set; }
        ///<summary>May contain extended information for property: 'UpperLimit'</summary>
        public Element _UpperLimit { get; set; }
    }
    ///<summary>
    ///A signature along with supporting context. The signature may be a digital signature that is cryptographic in nature, or some other signature acceptable to the domain. This other signature may be as simple as a graphical image representing a hand-written signature, or a signature ceremony Different signature approaches have different utilities.
    ///</summary>
    ///<source-file>signature.xml</source-file>
    public class Signature : Element
    {
        ///<summary>The base64 encoding of the Signature content. When signature is not recorded electronically this element would be empty.</summary>
        public string Data { get; set; }
        ///<summary>May contain extended information for property: 'Data'</summary>
        public Element _Data { get; set; }
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
        ///<summary>An indication of the reason that the entity signed this document. This may be explicitly included as part of the signature information and can be used when determining accountability for various actions concerning the document. </summary>
        public Coding[] Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element[] _Type { get; set; }
        ///<summary>When the digital signature was signed. </summary>
        public string When { get; set; }
        ///<summary>May contain extended information for property: 'When'</summary>
        public Element _When { get; set; }
        ///<summary>A reference to an application-usable description of the identity that signed  (e.g. the signature used their private key)</summary>
        public Reference Who { get; set; }
        ///<summary>May contain extended information for property: 'Who'</summary>
        public Element _Who { get; set; }
    }
    ///<summary>
    ///WARN: SimpleQuantity definition cannot be found!
    ///</summary>
    ///<source-file>definition-file-not-found.xml</source-file>
    public class SimpleQuantity : Quantity
    {
    }
    ///<summary>
    ///WARN: Structure definition cannot be found!
    ///</summary>
    ///<source-file>definition-file-not-found.xml</source-file>
    public class Structure : Element
    {
    }
    ///<summary>
    ///The subscription resource describes a particular client's request to be notified about a Topic
    ///</summary>
    ///<source-file>subscription-spreadsheet.xml</source-file>
    public class Subscription : DomainResource
    {
        ///<summary>Details where to send notifications when resources are received that meet the criteria</summary>
        public SubscriptionChannel Channel { get; set; }
        ///<summary>May contain extended information for property: 'Channel'</summary>
        public Element _Channel { get; set; }
        ///<summary>Contact details for a human to contact about the subscription. The primary use of this for system administrator troubleshooting</summary>
        public ContactPoint[] Contact { get; set; }
        ///<summary>May contain extended information for property: 'Contact'</summary>
        public Element[] _Contact { get; set; }
        ///<summary>The time for the server to turn the subscription off</summary>
        public string End { get; set; }
        ///<summary>May contain extended information for property: 'End'</summary>
        public Element _End { get; set; }
        ///<summary>A record of the last error that occurred when the server processed a notification</summary>
        public CodeableConcept[] Error { get; set; }
        ///<summary>May contain extended information for property: 'Error'</summary>
        public Element[] _Error { get; set; }
        ///<summary>A record of  the number of events for which the server has attempted delivery on this subscription (i.e., the number of events that occurred while the subscription is in an "active" or "error" state -- not "requested" or "off").   Server Initializes to 0 for a new subscription.  Repeated attempts at delivery of the *same* event notification do not increment this counter.</summary>
        public decimal EventCount { get; set; }
        ///<summary>May contain extended information for property: 'EventCount'</summary>
        public Element _EventCount { get; set; }
        ///<summary>The filter properties to be applied to narrow the topic stream.  When multiple filters are applied, evaluates to true if all the conditions are met; otherwise it returns false.   (i.e., logical AND)</summary>
        public SubscriptionFilterBy[] FilterBy { get; set; }
        ///<summary>May contain extended information for property: 'FilterBy'</summary>
        public Element[] _FilterBy { get; set; }
        ///<summary>A formal identifier that is used to identify this code system when it is represented in other formats, or referenced in a specification, model, design or an instance.</summary>
        public Identifier[] Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element[] _Identifier { get; set; }
        ///<summary>A natural language name identifying the subscription.</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>A description of why this subscription is defined</summary>
        public string Reason { get; set; }
        ///<summary>May contain extended information for property: 'Reason'</summary>
        public Element _Reason { get; set; }
        ///<summary>The status of the subscription, which marks the server state for managing the subscription</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
        ///<summary>The reference to the topic to be notified about.</summary>
        public Reference Topic { get; set; }
        ///<summary>May contain extended information for property: 'Topic'</summary>
        public Element _Topic { get; set; }
    }
    ///<summary>
    ///Details where to send notifications when resources are received that meet the criteria
    ///</summary>
    ///<source-file>subscription-spreadsheet.xml</source-file>
    public class SubscriptionChannel : Element
    {
        ///<summary>The url that describes the actual end-point to send messages to</summary>
        public string Endpoint { get; set; }
        ///<summary>May contain extended information for property: 'Endpoint'</summary>
        public Element _Endpoint { get; set; }
        ///<summary>Additional headers / information to send as part of the notification</summary>
        public string[] Header { get; set; }
        ///<summary>May contain extended information for property: 'Header'</summary>
        public Element[] _Header { get; set; }
        ///<summary>If present,  a 'hearbeat" notification (keepalive) is sent via this channel with an the interval period equal to this elements integer value in seconds.    If not present, a heartbeat notification is not sent.</summary>
        public decimal HeartbeatPeriod { get; set; }
        ///<summary>May contain extended information for property: 'HeartbeatPeriod'</summary>
        public Element _HeartbeatPeriod { get; set; }
        ///<summary>The payload mimetype and content.  If the payload is not present, then there is no payload in the notification, just a notification. </summary>
        public SubscriptionChannelPayload Payload { get; set; }
        ///<summary>May contain extended information for property: 'Payload'</summary>
        public Element _Payload { get; set; }
        ///<summary>The type of channel to send notifications on</summary>
        public CodeableConcept Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///The payload mimetype and content.  If the payload is not present, then there is no payload in the notification, just a notification. 
    ///</summary>
    ///<source-file>subscription-spreadsheet.xml</source-file>
    public class SubscriptionChannelPayload : Element
    {
        ///<summary>How much of the resource content to deliver in the notification payload. The choices are an empty payload, only the resource id, or the full resource content.</summary>
        public string Content { get; set; }
        ///<summary>May contain extended information for property: 'Content'</summary>
        public Element _Content { get; set; }
        ///<summary>The mime type to send the payload in - either application/fhir+xml, or application/fhir+json. The mime type "text/plain" may also be used for Email and SMS subscriptions</summary>
        public string ContentType { get; set; }
        ///<summary>May contain extended information for property: 'ContentType'</summary>
        public Element _ContentType { get; set; }
    }
    ///<summary>
    ///The filter properties to be applied to narrow the topic stream.  When multiple filters are applied, evaluates to true if all the conditions are met; otherwise it returns false.   (i.e., logical AND)
    ///</summary>
    ///<source-file>subscription-spreadsheet.xml</source-file>
    public class SubscriptionFilterBy : Element
    {
        ///<summary>The operator to apply to the filter value. </summary>
        public string MatchType { get; set; }
        ///<summary>May contain extended information for property: 'MatchType'</summary>
        public Element _MatchType { get; set; }
        ///<summary>The filter label (=key) as defined in the `Topic.canFilterBy.name`  element</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>The literal value or resource path as is legal in search - for example, "Patient/123" or "le1950".</summary>
        public string Value { get; set; }
        ///<summary>May contain extended information for property: 'Value'</summary>
        public Element _Value { get; set; }
    }
    ///<summary>
    ///Specifies an event that may occur multiple times. Timing schedules are used to record when things are planned, expected or requested to occur. The most common usage is in dosage instructions for medications. They are also used when planning care of various kinds, and may be used for reporting the schedule to which past regular activities were carried out
    ///</summary>
    ///<source-file>timing.xml</source-file>
    public class Timing : BackboneElement
    {
        ///<summary>A code for the timing schedule (or just text in code.text). Some codes such as BID are ubiquitous, but many institutions define their own additional codes. If a code is provided, the code is understood to be a complete statement of whatever is specified in the structured timing data, and either the code or the data may be used to interpret the Timing, with the exception that .repeat.bounds still applies over the code (and is not contained in the code)</summary>
        public CodeableConcept Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>Identifies specific times when the event occurs</summary>
        public string[] Event { get; set; }
        ///<summary>May contain extended information for property: 'Event'</summary>
        public Element[] _Event { get; set; }
        ///<summary>A set of rules that describe when the event is scheduled</summary>
        public TimingRepeat Repeat { get; set; }
        ///<summary>May contain extended information for property: 'Repeat'</summary>
        public Element _Repeat { get; set; }
    }
    ///<summary>
    ///A set of rules that describe when the event is scheduled
    ///</summary>
    ///<source-file>timing.xml</source-file>
    public class TimingRepeat : Element
    {
        ///<summary>Either a duration for the length of the timing schedule, a range of possible length, or outer bounds for start and/or end limits of the timing schedule</summary>
        public Duration BoundsDuration { get; set; }
        ///<summary>May contain extended information for property: 'BoundsDuration'</summary>
        public Element _BoundsDuration { get; set; }
        ///<summary>Either a duration for the length of the timing schedule, a range of possible length, or outer bounds for start and/or end limits of the timing schedule</summary>
        public Period BoundsPeriod { get; set; }
        ///<summary>May contain extended information for property: 'BoundsPeriod'</summary>
        public Element _BoundsPeriod { get; set; }
        ///<summary>Either a duration for the length of the timing schedule, a range of possible length, or outer bounds for start and/or end limits of the timing schedule</summary>
        public Range BoundsRange { get; set; }
        ///<summary>May contain extended information for property: 'BoundsRange'</summary>
        public Element _BoundsRange { get; set; }
        ///<summary>A total count of the desired number of repetitions across the duration of the entire timing specification. If countMax is present, this element indicates the lower bound of the allowed range of count values</summary>
        public decimal Count { get; set; }
        ///<summary>May contain extended information for property: 'Count'</summary>
        public Element _Count { get; set; }
        ///<summary>If present, indicates that the count is a range - so to perform the action between [count] and [countMax] times</summary>
        public decimal CountMax { get; set; }
        ///<summary>May contain extended information for property: 'CountMax'</summary>
        public Element _CountMax { get; set; }
        ///<summary>If one or more days of week is provided, then the action happens only on the specified day(s)</summary>
        public string[] DayOfWeek { get; set; }
        ///<summary>May contain extended information for property: 'DayOfWeek'</summary>
        public Element[] _DayOfWeek { get; set; }
        ///<summary>How long this thing happens for when it happens. If durationMax is present, this element indicates the lower bound of the allowed range of the duration</summary>
        public decimal Duration { get; set; }
        ///<summary>May contain extended information for property: 'Duration'</summary>
        public Element _Duration { get; set; }
        ///<summary>If present, indicates that the duration is a range - so to perform the action between [duration] and [durationMax] time length</summary>
        public decimal DurationMax { get; set; }
        ///<summary>May contain extended information for property: 'DurationMax'</summary>
        public Element _DurationMax { get; set; }
        ///<summary>The units of time for the duration, in UCUM units</summary>
        public string DurationUnit { get; set; }
        ///<summary>May contain extended information for property: 'DurationUnit'</summary>
        public Element _DurationUnit { get; set; }
        ///<summary>The number of times to repeat the action within the specified period. If frequencyMax is present, this element indicates the lower bound of the allowed range of the frequency</summary>
        public decimal Frequency { get; set; }
        ///<summary>May contain extended information for property: 'Frequency'</summary>
        public Element _Frequency { get; set; }
        ///<summary>If present, indicates that the frequency is a range - so to repeat between [frequency] and [frequencyMax] times within the period or period range</summary>
        public decimal FrequencyMax { get; set; }
        ///<summary>May contain extended information for property: 'FrequencyMax'</summary>
        public Element _FrequencyMax { get; set; }
        ///<summary>The number of minutes from the event. If the event code does not indicate whether the minutes is before or after the event, then the offset is assumed to be after the event</summary>
        public decimal Offset { get; set; }
        ///<summary>May contain extended information for property: 'Offset'</summary>
        public Element _Offset { get; set; }
        ///<summary>Indicates the duration of time over which repetitions are to occur; e.g. to express "3 times per day", 3 would be the frequency and "1 day" would be the period. If periodMax is present, this element indicates the lower bound of the allowed range of the period length</summary>
        public decimal Period { get; set; }
        ///<summary>May contain extended information for property: 'Period'</summary>
        public Element _Period { get; set; }
        ///<summary>If present, indicates that the period is a range from [period] to [periodMax], allowing expressing concepts such as "do this once every 3-5 days</summary>
        public decimal PeriodMax { get; set; }
        ///<summary>May contain extended information for property: 'PeriodMax'</summary>
        public Element _PeriodMax { get; set; }
        ///<summary>The units of time for the period in UCUM units</summary>
        public string PeriodUnit { get; set; }
        ///<summary>May contain extended information for property: 'PeriodUnit'</summary>
        public Element _PeriodUnit { get; set; }
        ///<summary>Specified time of day for action to take place</summary>
        public string[] TimeOfDay { get; set; }
        ///<summary>May contain extended information for property: 'TimeOfDay'</summary>
        public Element[] _TimeOfDay { get; set; }
        ///<summary>An approximate time period during the day, potentially linked to an event of daily living that indicates when the action should occur</summary>
        public string[] When { get; set; }
        ///<summary>May contain extended information for property: 'When'</summary>
        public Element[] _When { get; set; }
    }
    ///<summary>
    ///Describes a stream of resource state changes identified by trigger criteria and annotated with labels useful to filter projections from this topic
    ///</summary>
    ///<source-file>topic-spreadsheet.xml</source-file>
    public class Topic : DomainResource
    {
        ///<summary>The date on which the asset content was approved by the publisher. Approval happens once when the content is officially approved for usage</summary>
        public string ApprovalDate { get; set; }
        ///<summary>May contain extended information for property: 'ApprovalDate'</summary>
        public Element _ApprovalDate { get; set; }
        ///<summary>List of properties by which messages on the topic can be filtered</summary>
        public TopicCanFilterBy[] CanFilterBy { get; set; }
        ///<summary>May contain extended information for property: 'CanFilterBy'</summary>
        public Element[] _CanFilterBy { get; set; }
        ///<summary>Contact details to assist a user in finding and communicating with the publisher</summary>
        public ContactDetail[] Contact { get; set; }
        ///<summary>May contain extended information for property: 'Contact'</summary>
        public Element[] _Contact { get; set; }
        ///<summary>A copyright statement relating to the Topic and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the Topic</summary>
        public string Copyright { get; set; }
        ///<summary>May contain extended information for property: 'Copyright'</summary>
        public Element _Copyright { get; set; }
        ///<summary>For draft definitions, indicates the date of initial creation.  For active definitions, represents the date of activation.  For withdrawn definitions, indicates the date of withdrawal.</summary>
        public string Date { get; set; }
        ///<summary>May contain extended information for property: 'Date'</summary>
        public Element _Date { get; set; }
        ///<summary>The canonical URL pointing to another FHIR-defined Topic that is adhered to in whole or in part by this Topic</summary>
        public string[] DerivedFromCanonical { get; set; }
        ///<summary>May contain extended information for property: 'DerivedFromCanonical'</summary>
        public Element[] _DerivedFromCanonical { get; set; }
        ///<summary>The URL pointing to an externally-defined subscription topic or other definition that is adhered to in whole or in part by this definition.</summary>
        public string[] DerivedFromUri { get; set; }
        ///<summary>May contain extended information for property: 'DerivedFromUri'</summary>
        public Element[] _DerivedFromUri { get; set; }
        ///<summary>A free text natural language description of the Topic from the consumer's perspective</summary>
        public string Description { get; set; }
        ///<summary>May contain extended information for property: 'Description'</summary>
        public Element _Description { get; set; }
        ///<summary>The period during which the Topic content was or is planned to be effective</summary>
        public Period EffectivePeriod { get; set; }
        ///<summary>May contain extended information for property: 'EffectivePeriod'</summary>
        public Element _EffectivePeriod { get; set; }
        ///<summary>A flag to indicate that this Topic is authored for testing purposes (or education/evaluation/marketing), and is not intended to be used for genuine usage</summary>
        public bool Experimental { get; set; }
        ///<summary>May contain extended information for property: 'Experimental'</summary>
        public Element _Experimental { get; set; }
        ///<summary>Business identifiers assigned to this Topic by the performer and/or other systems.  These identifiers remain constant as the resource is updated and propagates from server to server</summary>
        public Identifier[] Identifier { get; set; }
        ///<summary>May contain extended information for property: 'Identifier'</summary>
        public Element[] _Identifier { get; set; }
        ///<summary>A jurisdiction in which the Topic is intended to be used</summary>
        public CodeableConcept[] Jurisdiction { get; set; }
        ///<summary>May contain extended information for property: 'Jurisdiction'</summary>
        public Element[] _Jurisdiction { get; set; }
        ///<summary>The date on which the asset content was last reviewed. Review happens periodically after that, but doesn't change the original approval date.</summary>
        public string LastReviewDate { get; set; }
        ///<summary>May contain extended information for property: 'LastReviewDate'</summary>
        public Element _LastReviewDate { get; set; }
        ///<summary>Helps establish the "authority/credibility" of the Topic.  May also allow for contact</summary>
        public Reference Publisher { get; set; }
        ///<summary>May contain extended information for property: 'Publisher'</summary>
        public Element _Publisher { get; set; }
        ///<summary>Explains why this Topic is needed and why it has been designed as it has</summary>
        public string Purpose { get; set; }
        ///<summary>May contain extended information for property: 'Purpose'</summary>
        public Element _Purpose { get; set; }
        ///<summary>Completed or terminated request(s) whose function is taken by this new request</summary>
        public string[] Replaces { get; set; }
        ///<summary>May contain extended information for property: 'Replaces'</summary>
        public Element[] _Replaces { get; set; }
        ///<summary>The criteria for including updates to a nominated resource in the topic.  Thie criteria may be just a human readable description and/or a full FHIR search string or FHIRPath expression.</summary>
        public TopicResourceTrigger ResourceTrigger { get; set; }
        ///<summary>May contain extended information for property: 'ResourceTrigger'</summary>
        public Element _ResourceTrigger { get; set; }
        ///<summary>The current state of the Topic</summary>
        public string Status { get; set; }
        ///<summary>May contain extended information for property: 'Status'</summary>
        public Element _Status { get; set; }
        ///<summary>A short, descriptive, user-friendly title for the Topic, for example, "admission".</summary>
        public string Title { get; set; }
        ///<summary>May contain extended information for property: 'Title'</summary>
        public Element _Title { get; set; }
        ///<summary>An absolute URL that is used to identify this Topic when it is referenced in a specification, model, design or an instance. This SHALL be a URL, SHOULD be globally unique, and SHOULD be an address at which this Topic is (or will be) published. The URL SHOULD include the major version of the Topic. For more information see [Technical and Business Versions](resource.html#versions)</summary>
        public string Url { get; set; }
        ///<summary>May contain extended information for property: 'Url'</summary>
        public Element _Url { get; set; }
        ///<summary>The content was developed with a focus and intent of supporting the contexts that are listed. These terms may be used to assist with indexing and searching of code system definitions.</summary>
        public UsageContext[] UseContext { get; set; }
        ///<summary>May contain extended information for property: 'UseContext'</summary>
        public Element[] _UseContext { get; set; }
        ///<summary>The identifier that is used to identify this version of the Topic when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the Topic author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions are orderable</summary>
        public string Version { get; set; }
        ///<summary>May contain extended information for property: 'Version'</summary>
        public Element _Version { get; set; }
    }
    ///<summary>
    ///List of properties by which messages on the topic can be filtered
    ///</summary>
    ///<source-file>topic-spreadsheet.xml</source-file>
    public class TopicCanFilterBy : Element
    {
        ///<summary>Description of how this filter parameter is intended to be used.</summary>
        public string Documentation { get; set; }
        ///<summary>May contain extended information for property: 'Documentation'</summary>
        public Element _Documentation { get; set; }
        ///<summary>A search parameter (like "patient") which is a label for the filter.</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
    }
    ///<summary>
    ///The criteria for including updates to a nominated resource in the topic.  Thie criteria may be just a human readable description and/or a full FHIR search string or FHIRPath expression.
    ///</summary>
    ///<source-file>topic-spreadsheet.xml</source-file>
    public class TopicResourceTrigger : Element
    {
        ///<summary>The human readable description of what triggers inclusion into this topic -  for example, "Beginning of a clinical encounter".</summary>
        public string Description { get; set; }
        ///<summary>May contain extended information for property: 'Description'</summary>
        public Element _Description { get; set; }
        ///<summary>The FHIRPath based rules that the server should use to determine when to trigger a notification for this topic.</summary>
        public string FhirPathCriteria { get; set; }
        ///<summary>May contain extended information for property: 'FhirPathCriteria'</summary>
        public Element _FhirPathCriteria { get; set; }
        ///<summary>The REST interaction based rules that the server should use to determine when to trigger a notification for this topic.</summary>
        public string[] MethodCriteria { get; set; }
        ///<summary>May contain extended information for property: 'MethodCriteria'</summary>
        public Element[] _MethodCriteria { get; set; }
        ///<summary>The FHIR query based rules that the server should use to determine when to trigger a notification for this topic.</summary>
        public TopicResourceTriggerQueryCriteria QueryCriteria { get; set; }
        ///<summary>May contain extended information for property: 'QueryCriteria'</summary>
        public Element _QueryCriteria { get; set; }
        ///<summary>The list of resource types that are candidates for this topic.  For example, the Encounter resource is updated in an 'admission' topic</summary>
        public string[] ResourceType { get; set; }
        ///<summary>May contain extended information for property: 'ResourceType'</summary>
        public Element[] _ResourceType { get; set; }
    }
    ///<summary>
    ///The FHIR query based rules that the server should use to determine when to trigger a notification for this topic.
    ///</summary>
    ///<source-file>topic-spreadsheet.xml</source-file>
    public class TopicResourceTriggerQueryCriteria : Element
    {
        ///<summary>The FHIR query based rules are applied to the current resource state.</summary>
        public string Current { get; set; }
        ///<summary>May contain extended information for property: 'Current'</summary>
        public Element _Current { get; set; }
        ///<summary>The FHIR query based rules are applied to the previous resource state.</summary>
        public string Previous { get; set; }
        ///<summary>May contain extended information for property: 'Previous'</summary>
        public Element _Previous { get; set; }
        ///<summary> If set to true, both current and previous criteria must evaluate true to  trigger a notification for this topic.  Otherwise a notification for this topic will be triggered if either one evaluates to true</summary>
        public bool RequireBoth { get; set; }
        ///<summary>May contain extended information for property: 'RequireBoth'</summary>
        public Element _RequireBoth { get; set; }
    }
    ///<summary>
    ///A description of a triggering event. Triggering events can be named events, data events, or periodic, as determined by the type element
    ///</summary>
    ///<source-file>triggerdefinition.xml</source-file>
    public class TriggerDefinition : Element
    {
        ///<summary>A boolean-valued expression that is evaluated in the context of the container of the trigger definition and returns whether or not the trigger fires</summary>
        public Expression Condition { get; set; }
        ///<summary>May contain extended information for property: 'Condition'</summary>
        public Element _Condition { get; set; }
        ///<summary>The triggering data of the event (if this is a data trigger). If more than one data is requirement is specified, then all the data requirements must be true</summary>
        public DataRequirement[] Data { get; set; }
        ///<summary>May contain extended information for property: 'Data'</summary>
        public Element[] _Data { get; set; }
        ///<summary>A formal name for the event. This may be an absolute URI that identifies the event formally (e.g. from a trigger registry), or a simple relative URI that identifies the event in a local context</summary>
        public string Name { get; set; }
        ///<summary>May contain extended information for property: 'Name'</summary>
        public Element _Name { get; set; }
        ///<summary>The timing of the event (if this is a periodic trigger)</summary>
        public string TimingDate { get; set; }
        ///<summary>May contain extended information for property: 'TimingDate'</summary>
        public Element _TimingDate { get; set; }
        ///<summary>The timing of the event (if this is a periodic trigger)</summary>
        public string TimingDateTime { get; set; }
        ///<summary>May contain extended information for property: 'TimingDateTime'</summary>
        public Element _TimingDateTime { get; set; }
        ///<summary>The timing of the event (if this is a periodic trigger)</summary>
        public Reference TimingReference { get; set; }
        ///<summary>May contain extended information for property: 'TimingReference'</summary>
        public Element _TimingReference { get; set; }
        ///<summary>The timing of the event (if this is a periodic trigger)</summary>
        public Timing TimingTiming { get; set; }
        ///<summary>May contain extended information for property: 'TimingTiming'</summary>
        public Element _TimingTiming { get; set; }
        ///<summary>The type of triggering event</summary>
        public string Type { get; set; }
        ///<summary>May contain extended information for property: 'Type'</summary>
        public Element _Type { get; set; }
    }
    ///<summary>
    ///Specifies clinical/business/etc. metadata that can be used to retrieve, index and/or categorize an artifact. This metadata can either be specific to the applicable population (e.g., age category, DRG) or the specific context of care (e.g., venue, care setting, provider of care)
    ///</summary>
    ///<source-file>usagecontext.xml</source-file>
    public class UsageContext : Element
    {
        ///<summary>A code that identifies the type of context being specified by this usage context</summary>
        public Coding Code { get; set; }
        ///<summary>May contain extended information for property: 'Code'</summary>
        public Element _Code { get; set; }
        ///<summary>A value that defines the context specified in this context of use. The interpretation of the value is defined by the code</summary>
        public CodeableConcept ValueCodeableConcept { get; set; }
        ///<summary>May contain extended information for property: 'ValueCodeableConcept'</summary>
        public Element _ValueCodeableConcept { get; set; }
        ///<summary>A value that defines the context specified in this context of use. The interpretation of the value is defined by the code</summary>
        public Quantity ValueQuantity { get; set; }
        ///<summary>May contain extended information for property: 'ValueQuantity'</summary>
        public Element _ValueQuantity { get; set; }
        ///<summary>A value that defines the context specified in this context of use. The interpretation of the value is defined by the code</summary>
        public Range ValueRange { get; set; }
        ///<summary>May contain extended information for property: 'ValueRange'</summary>
        public Element _ValueRange { get; set; }
        ///<summary>A value that defines the context specified in this context of use. The interpretation of the value is defined by the code</summary>
        public Reference ValueReference { get; set; }
        ///<summary>May contain extended information for property: 'ValueReference'</summary>
        public Element _ValueReference { get; set; }
    }
} // close namespace: fhir
