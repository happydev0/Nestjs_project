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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request node history read continuation
    /// </summary>
    public partial class HistoryReadNextRequestApiModel
    {
        /// <summary>
        /// Initializes a new instance of the HistoryReadNextRequestApiModel
        /// class.
        /// </summary>
        public HistoryReadNextRequestApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HistoryReadNextRequestApiModel
        /// class.
        /// </summary>
        /// <param name="continuationToken">Continuation token to continue
        /// reading more
        /// results.</param>
        /// <param name="abort">Abort reading after this read</param>
        /// <param name="elevation">Optional User elevation</param>
        /// <param name="diagnostics">Optional diagnostics
        /// configuration</param>
        public HistoryReadNextRequestApiModel(string continuationToken, bool? abort = default(bool?), CredentialApiModel elevation = default(CredentialApiModel), DiagnosticsApiModel diagnostics = default(DiagnosticsApiModel))
        {
            ContinuationToken = continuationToken;
            Abort = abort;
            Elevation = elevation;
            Diagnostics = diagnostics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets continuation token to continue reading more
        /// results.
        /// </summary>
        [JsonProperty(PropertyName = "continuationToken")]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// Gets or sets abort reading after this read
        /// </summary>
        [JsonProperty(PropertyName = "abort")]
        public bool? Abort { get; set; }

        /// <summary>
        /// Gets or sets optional User elevation
        /// </summary>
        [JsonProperty(PropertyName = "elevation")]
        public CredentialApiModel Elevation { get; set; }

        /// <summary>
        /// Gets or sets optional diagnostics configuration
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics")]
        public DiagnosticsApiModel Diagnostics { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContinuationToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContinuationToken");
            }
        }
    }
}
