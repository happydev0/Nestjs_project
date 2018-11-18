// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Services.Twin.v1.Controllers {
    using Microsoft.Azure.IIoT.OpcUa.Services.Twin.v1.Auth;
    using Microsoft.Azure.IIoT.OpcUa.Services.Twin.v1.Filters;
    using Microsoft.Azure.IIoT.OpcUa.Services.Twin.v1.Models;
    using Microsoft.Azure.IIoT.OpcUa.Twin;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Read value controller
    /// </summary>
    [Route(VersionInfo.PATH + "/read")]
    [ExceptionsFilter]
    [Produces(ContentEncodings.MimeTypeJson)]
    [Authorize(Policy = Policies.CanBrowse)]
    public class ReadController : Controller {

        /// <summary>
        /// Create controller with service
        /// </summary>
        /// <param name="nodes"></param>
        public ReadController(INodeServices<string> nodes) {
            _nodes = nodes;
        }

        /// <summary>
        /// Read node value as specified in the read value request on the server
        /// endpoint specified by the twin id.
        /// The twin must be activated and connected and twin and server must trust
        /// each other.
        /// </summary>
        /// <param name="id">The identifier of the endpoint.</param>
        /// <param name="request">The read value request</param>
        /// <returns>The read value response</returns>
        [HttpPost("{id}")]
        public async Task<ValueReadResponseApiModel> ReadAsync(string id,
            [FromBody] ValueReadRequestApiModel request) {
            if (request == null) {
                throw new ArgumentNullException(nameof(request));
            }
            var readresult = await _nodes.NodeValueReadAsync(
                id, request.ToServiceModel());
            return new ValueReadResponseApiModel(readresult);
        }

        /// <summary>
        /// Read any node attribute as batches. This allows reading attributes
        /// of any node in batch fashion.
        /// </summary>
        /// <param name="id">The identifier of the endpoint.</param>
        /// <param name="request">The batch read request</param>
        /// <returns>The batch read response</returns>
        [HttpPost("{id}/batch")]
        public async Task<BatchReadResponseApiModel> ReadBatchAsync(string id,
            [FromBody] BatchReadRequestApiModel request) {
            if (request == null) {
                throw new ArgumentNullException(nameof(request));
            }
            var readresult = await _nodes.NodeBatchReadAsync(
                id, request.ToServiceModel());
            return new BatchReadResponseApiModel(readresult);
        }

        /// <summary>
        /// Get node value from the node id passed through query on the server
        /// endpoint specified by the twin id.
        /// The twin must be activated and connected and twin and server must trust
        /// each other.
        /// </summary>
        /// <param name="id">The identifier of the endpoint.</param>
        /// <param name="nodeId">The node to read</param>
        /// <returns>The read value response</returns>
        [HttpGet("{id}")]
        public async Task<ValueReadResponseApiModel> ReadAsGetAsync(string id,
            [FromQuery] string nodeId) {
            if (string.IsNullOrEmpty(nodeId)) {
                throw new ArgumentNullException(nameof(nodeId));
            }
            var request = new ValueReadRequestApiModel { NodeId = nodeId };
            var readresult = await _nodes.NodeValueReadAsync(
                id, request.ToServiceModel());
            return new ValueReadResponseApiModel(readresult);
        }

        private readonly INodeServices<string> _nodes;
    }
}
