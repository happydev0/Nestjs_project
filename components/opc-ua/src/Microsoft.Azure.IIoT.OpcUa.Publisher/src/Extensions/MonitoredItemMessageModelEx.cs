﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Publisher.Models {
    using System;
    using System.Linq;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Publisher sample model extensions
    /// </summary>
    public static class MonitoredItemMessageModelEx {

        /// <summary>
        /// Clone sample
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static MonitoredItemMessageModel Clone(this MonitoredItemMessageModel model) {
            if (model == null) {
                return null;
            }
            return new MonitoredItemMessageModel {
                SubscriptionId = model.SubscriptionId,
                EndpointId = model.EndpointId,
                DataSetId = model.DataSetId,
                NodeId = model.NodeId,
                ServerPicoseconds = model.ServerPicoseconds,
                ServerTimestamp = model.ServerTimestamp,
                SourcePicoseconds = model.SourcePicoseconds,
                SourceTimestamp = model.SourceTimestamp,
                Timestamp = model.Timestamp,
                TypeId = model.TypeId,
                Value = model.Value
            };
        }

        /// <summary>
        /// Try to convert json to sample model
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        internal static MonitoredItemMessageModel ToServiceModel(this JToken message) {
            if (message.Type != JTokenType.Object || !(message is JObject sampleRoot)) {
                // Not a publisher sample object - not accepted
                return null;
            }

            var value = sampleRoot.Property("Value", StringComparison.InvariantCultureIgnoreCase)?
                .Value;
            if (value == null) {
                // No value
                return null;
            }

            //
            // Check if the value is a data value or if the value was flattened into the root.
            //
            var dataValue = sampleRoot;
            if (IsDataValue(value)) {
                dataValue = value as JObject;
                value = dataValue.GetValueOrDefault<JToken>("Value",
                    StringComparison.InvariantCultureIgnoreCase);
            }

            return new MonitoredItemMessageModel {
                Value = GetValue(value, out var typeId),
                TypeId = typeId?.ToString(),
                DataSetId = sampleRoot.GetValueOrDefault<string>(
                    nameof(MonitoredItemMessageModel.DataSetId),
                        StringComparison.InvariantCultureIgnoreCase),
                Timestamp = sampleRoot.GetValueOrDefault<DateTime?>(
                    nameof(MonitoredItemMessageModel.Timestamp),
                        StringComparison.InvariantCultureIgnoreCase),
                SubscriptionId = sampleRoot.GetValueOrDefault<string>(
                    nameof(MonitoredItemMessageModel.SubscriptionId),
                        StringComparison.InvariantCultureIgnoreCase),
                EndpointId = sampleRoot.GetValueOrDefault<string>(
                    nameof(MonitoredItemMessageModel.EndpointId),
                        StringComparison.InvariantCultureIgnoreCase),
                NodeId = sampleRoot.GetValueOrDefault<string>(
                    nameof(MonitoredItemMessageModel.NodeId),
                        StringComparison.InvariantCultureIgnoreCase),
                SourcePicoseconds = dataValue.GetValueOrDefault<ushort?>(
                    nameof(MonitoredItemMessageModel.SourcePicoseconds),
                        StringComparison.InvariantCultureIgnoreCase),
                ServerPicoseconds = dataValue.GetValueOrDefault<ushort?>(
                    nameof(MonitoredItemMessageModel.ServerPicoseconds),
                        StringComparison.InvariantCultureIgnoreCase),
                SourceTimestamp = dataValue.GetValueOrDefault<DateTime?>(
                    nameof(MonitoredItemMessageModel.SourceTimestamp),
                        StringComparison.InvariantCultureIgnoreCase),
                ServerTimestamp = dataValue.GetValueOrDefault<DateTime?>(
                    nameof(MonitoredItemMessageModel.ServerTimestamp),
                        StringComparison.InvariantCultureIgnoreCase),
            };
        }

        /// <summary>
        /// Get value from value object
        /// </summary>
        /// <param name="token"></param>
        /// <param name="typeId"></param>
        /// <returns></returns>
        private static JToken GetValue(JToken token, out JToken typeId) {
            if (token.Type != JTokenType.Object || !(token is JObject variant)) {
                typeId = null;
            }
            else if (variant.TryGetValue("Type",
                    StringComparison.InvariantCultureIgnoreCase, out typeId)) {

                variant.TryGetValue("Body",
                    StringComparison.InvariantCultureIgnoreCase, out token);
            }
            return token;
        }

        /// <summary>
        /// Is this a datavalue object?
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private static bool IsDataValue(this JToken token) {
            var properties = new[] {
                "SourcePicoseconds", "ServerPicoseconds",
                "ServerTimestamp", "SourceTimestamp",
            };
            if (token.Type != JTokenType.Object || !(token is JObject dataValue)) {
                // Not a publisher sample object - not accepted
                return false;
            }
            return dataValue.Properties().Any(p => p.Name.AnyOf(properties, true));
        }
    }
}
