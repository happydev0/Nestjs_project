// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.History.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application information
    /// </summary>
    public partial class ApplicationRegistrationRequestApiModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationRegistrationRequestApiModel class.
        /// </summary>
        public ApplicationRegistrationRequestApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationRegistrationRequestApiModel class.
        /// </summary>
        /// <param name="applicationUri">Unique application uri</param>
        /// <param name="applicationType">Type of application. Possible values
        /// include: 'Server', 'Client', 'ClientAndServer'</param>
        /// <param name="productUri">Product uri of the application.</param>
        /// <param name="applicationName">Name of the server or client.</param>
        /// <param name="locale">Locale of name</param>
        /// <param name="capabilities">The OPC UA defined capabilities of the
        /// server.</param>
        /// <param name="discoveryUrls">Discovery urls of the server.</param>
        /// <param name="discoveryProfileUri">The discovery profile uri of the
        /// server.</param>
        public ApplicationRegistrationRequestApiModel(string applicationUri, ApplicationType? applicationType = default(ApplicationType?), string productUri = default(string), string applicationName = default(string), string locale = default(string), IList<string> capabilities = default(IList<string>), IList<string> discoveryUrls = default(IList<string>), string discoveryProfileUri = default(string))
        {
            ApplicationUri = applicationUri;
            ApplicationType = applicationType;
            ProductUri = productUri;
            ApplicationName = applicationName;
            Locale = locale;
            Capabilities = capabilities;
            DiscoveryUrls = discoveryUrls;
            DiscoveryProfileUri = discoveryProfileUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique application uri
        /// </summary>
        [JsonProperty(PropertyName = "applicationUri")]
        public string ApplicationUri { get; set; }

        /// <summary>
        /// Gets or sets type of application. Possible values include:
        /// 'Server', 'Client', 'ClientAndServer'
        /// </summary>
        [JsonProperty(PropertyName = "applicationType")]
        public ApplicationType? ApplicationType { get; set; }

        /// <summary>
        /// Gets or sets product uri of the application.
        /// </summary>
        [JsonProperty(PropertyName = "productUri")]
        public string ProductUri { get; set; }

        /// <summary>
        /// Gets or sets name of the server or client.
        /// </summary>
        [JsonProperty(PropertyName = "applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets locale of name
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the OPC UA defined capabilities of the server.
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<string> Capabilities { get; set; }

        /// <summary>
        /// Gets or sets discovery urls of the server.
        /// </summary>
        [JsonProperty(PropertyName = "discoveryUrls")]
        public IList<string> DiscoveryUrls { get; set; }

        /// <summary>
        /// Gets or sets the discovery profile uri of the server.
        /// </summary>
        [JsonProperty(PropertyName = "discoveryProfileUri")]
        public string DiscoveryProfileUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ApplicationUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApplicationUri");
            }
            if (Capabilities != null)
            {
                if (Capabilities.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Capabilities)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Capabilities");
                }
            }
            if (DiscoveryUrls != null)
            {
                if (DiscoveryUrls.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(DiscoveryUrls)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "DiscoveryUrls");
                }
            }
        }
    }
}
