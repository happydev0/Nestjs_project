﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------


namespace Microsoft.Azure.IIoT.OpcUa.Services.Protocol {
    using Microsoft.Azure.IIoT.Hub;

    /// <summary>
    /// Configuration for client
    /// </summary>
    public interface IOpcUaConfig : IIoTHubConfig {

        /// <summary>
        /// Bypass the use of proxy - for development
        /// </summary>
        bool BypassProxy { get; }
    }
}
