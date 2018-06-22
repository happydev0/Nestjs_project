﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api {

    /// <summary>
    /// Configuration for service
    /// </summary>
    public interface IOpcUaRegistryConfig {

        /// <summary>
        /// Opc registry service url
        /// </summary>
        string OpcUaRegistryServiceUrl { get; }

        /// <summary>
        /// Resource id of registry service
        /// </summary>
        string OpcUaRegistryServiceResourceId { get; }
    }
}
