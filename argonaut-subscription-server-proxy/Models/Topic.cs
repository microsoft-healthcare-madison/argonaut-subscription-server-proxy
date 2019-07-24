using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace argonaut_subscription_server_proxy.Models
{
    public class Topic
    {
        /// <summary>Type of the resource.</summary>
        public readonly string resourceType = "Topic";

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Inherited from Resource</summary>
        ///
        /// <value>The identifier.</value>
        ///-------------------------------------------------------------------------------------------------

        public string id { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets or sets the URL for the definition of this Topic.</summary>
        ///
        /// <value>The URL.</value>
        ///-------------------------------------------------------------------------------------------------

        public FhirUri url { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets or sets the identifier.</summary>
        ///
        /// <value>The identifier.</value>
        ///-------------------------------------------------------------------------------------------------

        public List<Identifier> identifier { get; set; }

        public string version { get; set; }

        public string title { get; set; }

        public List<Canonical> derivedFromCanonical { get; set; }

        public List<FhirUri> derivedFromUri { get; set; }

        public Canonical replaces { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Status of Topic: draft | active | retired | unknown</summary>
        ///
        /// <value>The status.</value>
        ///-------------------------------------------------------------------------------------------------

        public Code status { get; set; }

        public bool experimental { get; set; }

        public FhirDateTime date { get; set; }

        // TODO: this is supposed to be Reference(Practitioner|PractitionerRole|Organization)
        public string publisher { get; set; }

        public List<ContactDetail> contact;

        public string description { get; set; }

        public List<UsageContext> useContext { get; set; }

        public List<CodeableConcept> jurisdiction { get; set; }

        public string purpose { get; set; }

        public string copyright { get; set; }

        public Date approvalDate { get; set; }

        public Date lastReviewDate { get; set; }

        public Period effectivePeriod { get; set; }



        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets or sets the list of available search parameters.
        /// See http://www.hl7.org/fhir/searchparameter-registry.html for list of available names.
        /// </summary>
        ///
        /// <value>Amount to can filter by.</value>
        ///-------------------------------------------------------------------------------------------------

        public List<FilterSpecification> canFilterBy { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets or sets the resource trigger (computable definition of state change for this Topic).
        /// </summary>
        ///
        /// <value>The resource trigger.</value>
        ///-------------------------------------------------------------------------------------------------

        public ResourceTrigger resourceTrigger { get; set; }

    }
}

