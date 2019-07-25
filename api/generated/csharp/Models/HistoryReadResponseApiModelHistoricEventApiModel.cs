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
    /// History read results
    /// </summary>
    public partial class HistoryReadResponseApiModelHistoricEventApiModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HistoryReadResponseApiModelHistoricEventApiModel class.
        /// </summary>
        public HistoryReadResponseApiModelHistoricEventApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HistoryReadResponseApiModelHistoricEventApiModel class.
        /// </summary>
        /// <param name="history">History as json encoded extension
        /// object</param>
        /// <param name="continuationToken">Continuation token if more results
        /// pending.</param>
        /// <param name="errorInfo">Service result in case of error</param>
        public HistoryReadResponseApiModelHistoricEventApiModel(IList<HistoricEventApiModel> history = default(IList<HistoricEventApiModel>), string continuationToken = default(string), ServiceResultApiModel errorInfo = default(ServiceResultApiModel))
        {
            History = history;
            ContinuationToken = continuationToken;
            ErrorInfo = errorInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets history as json encoded extension object
        /// </summary>
        [JsonProperty(PropertyName = "history")]
        public IList<HistoricEventApiModel> History { get; set; }

        /// <summary>
        /// Gets or sets continuation token if more results pending.
        /// </summary>
        [JsonProperty(PropertyName = "continuationToken")]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// Gets or sets service result in case of error
        /// </summary>
        [JsonProperty(PropertyName = "errorInfo")]
        public ServiceResultApiModel ErrorInfo { get; set; }

    }
}
