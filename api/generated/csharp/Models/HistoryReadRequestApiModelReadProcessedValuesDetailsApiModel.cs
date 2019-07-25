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
    /// Request node history read
    /// </summary>
    public partial class HistoryReadRequestApiModelReadProcessedValuesDetailsApiModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HistoryReadRequestApiModelReadProcessedValuesDetailsApiModel class.
        /// </summary>
        public HistoryReadRequestApiModelReadProcessedValuesDetailsApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HistoryReadRequestApiModelReadProcessedValuesDetailsApiModel class.
        /// </summary>
        /// <param name="nodeId">Node to read from (mandatory)</param>
        /// <param name="browsePath">An optional path from NodeId instance to
        /// the actual node.</param>
        /// <param name="details">The HistoryReadDetailsType extension object
        /// encoded in json and containing the tunneled
        /// Historian reader request.</param>
        /// <param name="indexRange">Index range to read, e.g. 1:2,0:1 for 2
        /// slices
        /// out of a matrix or 0:1 for the first item in
        /// an array, string or bytestring.
        /// See 7.22 of part 4: NumericRange.</param>
        /// <param name="header">Optional request header</param>
        public HistoryReadRequestApiModelReadProcessedValuesDetailsApiModel(string nodeId = default(string), IList<string> browsePath = default(IList<string>), ReadProcessedValuesDetailsApiModel details = default(ReadProcessedValuesDetailsApiModel), string indexRange = default(string), RequestHeaderApiModel header = default(RequestHeaderApiModel))
        {
            NodeId = nodeId;
            BrowsePath = browsePath;
            Details = details;
            IndexRange = indexRange;
            Header = header;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets node to read from (mandatory)
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
        /// Gets or sets the HistoryReadDetailsType extension object
        /// encoded in json and containing the tunneled
        /// Historian reader request.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public ReadProcessedValuesDetailsApiModel Details { get; set; }

        /// <summary>
        /// Gets or sets index range to read, e.g. 1:2,0:1 for 2 slices
        /// out of a matrix or 0:1 for the first item in
        /// an array, string or bytestring.
        /// See 7.22 of part 4: NumericRange.
        /// </summary>
        [JsonProperty(PropertyName = "indexRange")]
        public string IndexRange { get; set; }

        /// <summary>
        /// Gets or sets optional request header
        /// </summary>
        [JsonProperty(PropertyName = "header")]
        public RequestHeaderApiModel Header { get; set; }

    }
}
