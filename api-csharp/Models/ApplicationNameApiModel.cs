// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.OpcUa.Api.Vault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ApplicationNameApiModel
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationNameApiModel class.
        /// </summary>
        public ApplicationNameApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNameApiModel class.
        /// </summary>
        public ApplicationNameApiModel(string locale = default(string), string text = default(string))
        {
            Locale = locale;
            Text = text;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Locale")]
        public string Locale { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Text")]
        public string Text { get; set; }

    }
}
