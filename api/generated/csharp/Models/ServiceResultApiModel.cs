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
    using System.Linq;

    /// <summary>
    /// Service result
    /// </summary>
    public partial class ServiceResultApiModel
    {
        /// <summary>
        /// Initializes a new instance of the ServiceResultApiModel class.
        /// </summary>
        public ServiceResultApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceResultApiModel class.
        /// </summary>
        /// <param name="statusCode">Error code - if null operation
        /// succeeded.</param>
        /// <param name="errorMessage">Error message in case of error or
        /// null.</param>
        /// <param name="diagnostics">Additional diagnostics
        /// information</param>
        public ServiceResultApiModel(int? statusCode = default(int?), string errorMessage = default(string), object diagnostics = default(object))
        {
            StatusCode = statusCode;
            ErrorMessage = errorMessage;
            Diagnostics = diagnostics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code - if null operation succeeded.
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Gets or sets error message in case of error or null.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets additional diagnostics information
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics")]
        public object Diagnostics { get; set; }

    }
}
