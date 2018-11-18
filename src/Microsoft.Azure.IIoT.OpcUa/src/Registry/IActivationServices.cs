// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Registry {
    using System.Threading.Tasks;

    /// <summary>
    /// Endpoint activation services
    /// </summary>
    public interface IActivationServices<T> {

        /// <summary>
        /// Activate endpoint
        /// </summary>
        /// <param name="id"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        Task ActivateEndpointAsync(T id, string secret);

        /// <summary>
        /// Deactivate endpoint
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeactivateEndpointAsync(T id);
    }
}
