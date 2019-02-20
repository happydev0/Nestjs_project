// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Registry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Supervisor runtime status
    /// </summary>
    public partial class SupervisorStatusApiModel
    {
        /// <summary>
        /// Initializes a new instance of the SupervisorStatusApiModel class.
        /// </summary>
        public SupervisorStatusApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SupervisorStatusApiModel class.
        /// </summary>
        /// <param name="deviceId">Edge device id</param>
        /// <param name="moduleId">Module id</param>
        /// <param name="siteId">Site id</param>
        /// <param name="endpoints">Endpoint activation status</param>
        public SupervisorStatusApiModel(string deviceId, string moduleId = default(string), string siteId = default(string), IList<EndpointActivationStatusApiModel> endpoints = default(IList<EndpointActivationStatusApiModel>))
        {
            DeviceId = deviceId;
            ModuleId = moduleId;
            SiteId = siteId;
            Endpoints = endpoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets edge device id
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets module id
        /// </summary>
        [JsonProperty(PropertyName = "moduleId")]
        public string ModuleId { get; set; }

        /// <summary>
        /// Gets or sets site id
        /// </summary>
        [JsonProperty(PropertyName = "siteId")]
        public string SiteId { get; set; }

        /// <summary>
        /// Gets or sets endpoint activation status
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<EndpointActivationStatusApiModel> Endpoints { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeviceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeviceId");
            }
            if (Endpoints != null)
            {
                foreach (var element in Endpoints)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
