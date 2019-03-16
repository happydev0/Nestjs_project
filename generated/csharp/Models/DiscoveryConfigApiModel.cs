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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Discovery configuration
    /// </summary>
    public partial class DiscoveryConfigApiModel
    {
        /// <summary>
        /// Initializes a new instance of the DiscoveryConfigApiModel class.
        /// </summary>
        public DiscoveryConfigApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiscoveryConfigApiModel class.
        /// </summary>
        /// <param name="addressRangesToScan">Address ranges to scan (null ==
        /// all wired nics)</param>
        /// <param name="networkProbeTimeoutMs">Network probe timeout</param>
        /// <param name="maxNetworkProbes">Max network probes that should ever
        /// run.</param>
        /// <param name="portRangesToScan">Port ranges to scan (null == all
        /// unassigned)</param>
        /// <param name="portProbeTimeoutMs">Port probe timeout</param>
        /// <param name="maxPortProbes">Max port probes that should ever
        /// run.</param>
        /// <param name="minPortProbesPercent">Probes that must always be there
        /// as percent of max.</param>
        /// <param name="idleTimeBetweenScansSec">Delay time between discovery
        /// sweeps in seconds</param>
        /// <param name="discoveryUrls">List of preset discovery urls to
        /// use</param>
        /// <param name="locales">List of locales to filter with during
        /// discovery</param>
        /// <param name="callbacks">Callbacks to invoke once onboarding
        /// finishes</param>
        /// <param name="activationFilter">Activate all twins with this filter
        /// during onboarding.</param>
        public DiscoveryConfigApiModel(string addressRangesToScan = default(string), int? networkProbeTimeoutMs = default(int?), int? maxNetworkProbes = default(int?), string portRangesToScan = default(string), int? portProbeTimeoutMs = default(int?), int? maxPortProbes = default(int?), int? minPortProbesPercent = default(int?), int? idleTimeBetweenScansSec = default(int?), IList<string> discoveryUrls = default(IList<string>), IList<string> locales = default(IList<string>), IList<CallbackApiModel> callbacks = default(IList<CallbackApiModel>), EndpointActivationFilterApiModel activationFilter = default(EndpointActivationFilterApiModel))
        {
            AddressRangesToScan = addressRangesToScan;
            NetworkProbeTimeoutMs = networkProbeTimeoutMs;
            MaxNetworkProbes = maxNetworkProbes;
            PortRangesToScan = portRangesToScan;
            PortProbeTimeoutMs = portProbeTimeoutMs;
            MaxPortProbes = maxPortProbes;
            MinPortProbesPercent = minPortProbesPercent;
            IdleTimeBetweenScansSec = idleTimeBetweenScansSec;
            DiscoveryUrls = discoveryUrls;
            Locales = locales;
            Callbacks = callbacks;
            ActivationFilter = activationFilter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets address ranges to scan (null == all wired nics)
        /// </summary>
        [JsonProperty(PropertyName = "addressRangesToScan")]
        public string AddressRangesToScan { get; set; }

        /// <summary>
        /// Gets or sets network probe timeout
        /// </summary>
        [JsonProperty(PropertyName = "networkProbeTimeoutMs")]
        public int? NetworkProbeTimeoutMs { get; set; }

        /// <summary>
        /// Gets or sets max network probes that should ever run.
        /// </summary>
        [JsonProperty(PropertyName = "maxNetworkProbes")]
        public int? MaxNetworkProbes { get; set; }

        /// <summary>
        /// Gets or sets port ranges to scan (null == all unassigned)
        /// </summary>
        [JsonProperty(PropertyName = "portRangesToScan")]
        public string PortRangesToScan { get; set; }

        /// <summary>
        /// Gets or sets port probe timeout
        /// </summary>
        [JsonProperty(PropertyName = "portProbeTimeoutMs")]
        public int? PortProbeTimeoutMs { get; set; }

        /// <summary>
        /// Gets or sets max port probes that should ever run.
        /// </summary>
        [JsonProperty(PropertyName = "maxPortProbes")]
        public int? MaxPortProbes { get; set; }

        /// <summary>
        /// Gets or sets probes that must always be there as percent of max.
        /// </summary>
        [JsonProperty(PropertyName = "minPortProbesPercent")]
        public int? MinPortProbesPercent { get; set; }

        /// <summary>
        /// Gets or sets delay time between discovery sweeps in seconds
        /// </summary>
        [JsonProperty(PropertyName = "idleTimeBetweenScansSec")]
        public int? IdleTimeBetweenScansSec { get; set; }

        /// <summary>
        /// Gets or sets list of preset discovery urls to use
        /// </summary>
        [JsonProperty(PropertyName = "discoveryUrls")]
        public IList<string> DiscoveryUrls { get; set; }

        /// <summary>
        /// Gets or sets list of locales to filter with during discovery
        /// </summary>
        [JsonProperty(PropertyName = "locales")]
        public IList<string> Locales { get; set; }

        /// <summary>
        /// Gets or sets callbacks to invoke once onboarding finishes
        /// </summary>
        [JsonProperty(PropertyName = "callbacks")]
        public IList<CallbackApiModel> Callbacks { get; set; }

        /// <summary>
        /// Gets or sets activate all twins with this filter during onboarding.
        /// </summary>
        [JsonProperty(PropertyName = "activationFilter")]
        public EndpointActivationFilterApiModel ActivationFilter { get; set; }

    }
}
