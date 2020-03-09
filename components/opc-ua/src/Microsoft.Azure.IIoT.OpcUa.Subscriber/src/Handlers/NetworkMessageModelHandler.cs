﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Subscriber.Handlers {
    using Microsoft.Azure.IIoT.OpcUa.Subscriber;
    using Microsoft.Azure.IIoT.OpcUa.Subscriber.Models;
    using Microsoft.Azure.IIoT.Hub;
    using Newtonsoft.Json;
    using Serilog;
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Publisher message handling
    /// </summary>
    public sealed class NetworkMessageModelHandler : IDeviceTelemetryHandler {

        /// <inheritdoc/>
        public string MessageSchema => Core.MessageSchemaTypes.NetworkMessageModelJson;

        /// <summary>
        /// Create handler
        /// </summary>
        /// <param name="handlers"></param>
        /// <param name="logger"></param>
        public NetworkMessageModelHandler(IEnumerable<ISubscriberMessageProcessor> handlers, ILogger logger) {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _handlers = handlers?.ToList() ?? throw new ArgumentNullException(nameof(handlers));
        }

        /// <inheritdoc/>
        public async Task HandleAsync(string deviceId, string moduleId,
            byte[] payload, IDictionary<string, string> properties, Func<Task> checkpoint) {
            var json = Encoding.UTF8.GetString(payload);
            try {
                var message = JsonConvertEx.DeserializeObject<DataSetMessageModel>(json);
                await Task.WhenAll(_handlers.Select(h => h.HandleMessageAsync(message)));
            }
            catch (Exception ex) {
                _logger.Error(ex,
                    "Exception handling sample from {deviceId}-{moduleId} with payload {json}",
                    deviceId, moduleId, json);
            }
        }

        /// <inheritdoc/>
        public Task OnBatchCompleteAsync() {
            return Task.CompletedTask;
        }

        private readonly ILogger _logger;
        private readonly List<ISubscriberMessageProcessor> _handlers;
    }
}
