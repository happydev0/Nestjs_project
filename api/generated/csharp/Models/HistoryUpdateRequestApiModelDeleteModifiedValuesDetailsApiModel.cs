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
    /// Request node history update
    /// </summary>
    public partial class HistoryUpdateRequestApiModelDeleteModifiedValuesDetailsApiModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HistoryUpdateRequestApiModelDeleteModifiedValuesDetailsApiModel
        /// class.
        /// </summary>
        public HistoryUpdateRequestApiModelDeleteModifiedValuesDetailsApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HistoryUpdateRequestApiModelDeleteModifiedValuesDetailsApiModel
        /// class.
        /// </summary>
        /// <param name="details">The HistoryUpdateDetailsType extension object
        /// encoded as json Variant and containing the tunneled
        /// update request for the Historian server. The value
        /// is updated at edge using above node address.</param>
        /// <param name="nodeId">Node to update</param>
        /// <param name="browsePath">An optional path from NodeId instance to
        /// the actual node.</param>
        /// <param name="header">Optional request header</param>
        public HistoryUpdateRequestApiModelDeleteModifiedValuesDetailsApiModel(DeleteModifiedValuesDetailsApiModel details, string nodeId = default(string), IList<string> browsePath = default(IList<string>), RequestHeaderApiModel header = default(RequestHeaderApiModel))
        {
            NodeId = nodeId;
            BrowsePath = browsePath;
            Details = details;
            Header = header;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets node to update
        /// </summary>
        [JsonProperty(PropertyName = "nodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets an optional path from NodeId instance to
        /// the actual node.
        /// </summary>
        [JsonProperty(PropertyName = "browsePath")]
        public IList<string> BrowsePath { get; set; }

        /// <summary>
        /// Gets or sets the HistoryUpdateDetailsType extension object
        /// encoded as json Variant and containing the tunneled
        /// update request for the Historian server. The value
        /// is updated at edge using above node address.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public DeleteModifiedValuesDetailsApiModel Details { get; set; }

        /// <summary>
        /// Gets or sets optional request header
        /// </summary>
        [JsonProperty(PropertyName = "header")]
        public RequestHeaderApiModel Header { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Details == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Details");
            }
        }
    }
}
