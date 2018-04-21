﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcTwin.Services.Models {
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Result of value write
    /// </summary>
    public class ValueWriteResultModel {

        /// <summary>
        /// Diagnostics data in case of error
        /// </summary>
        public JToken Diagnostics { get; set; }
    }
}
