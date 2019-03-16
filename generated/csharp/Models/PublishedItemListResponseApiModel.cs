// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Twin.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of published nodes
    /// </summary>
    public partial class PublishedItemListResponseApiModel
    {
        /// <summary>
        /// Initializes a new instance of the PublishedItemListResponseApiModel
        /// class.
        /// </summary>
        public PublishedItemListResponseApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublishedItemListResponseApiModel
        /// class.
        /// </summary>
        /// <param name="items">Monitored items</param>
        /// <param name="continuationToken">Continuation or null if
        /// final</param>
        public PublishedItemListResponseApiModel(IList<PublishedItemApiModel> items = default(IList<PublishedItemApiModel>), string continuationToken = default(string))
        {
            Items = items;
            ContinuationToken = continuationToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets monitored items
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<PublishedItemApiModel> Items { get; set; }

        /// <summary>
        /// Gets or sets continuation or null if final
        /// </summary>
        [JsonProperty(PropertyName = "continuationToken")]
        public string ContinuationToken { get; set; }

    }
}
