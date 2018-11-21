// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Twin.Clients {
    using Microsoft.Azure.IIoT.OpcUa.Api.Twin.Models;
    using Microsoft.Azure.IIoT.Diagnostics;
    using Microsoft.Azure.IIoT.Http;
    using Newtonsoft.Json;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementation of v1 twin service api.
    /// </summary>
    public class TwinServiceClient : ITwinServiceApi {

        /// <summary>
        /// Create service client
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="config"></param>
        /// <param name="logger"></param>
        public TwinServiceClient(IHttpClient httpClient, ITwinConfig config,
            ILogger logger) :
            this(httpClient, config.OpcUaTwinServiceUrl,
                config.OpcUaTwinServiceResourceId, logger) {
        }

        /// <summary>
        /// Create service client
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="serviceUri"></param>
        /// <param name="resourceId"></param>
        /// <param name="logger"></param>
        public TwinServiceClient(IHttpClient httpClient, string serviceUri,
            string resourceId, ILogger logger) {
            if (string.IsNullOrEmpty(serviceUri)) {
                throw new ArgumentNullException(nameof(serviceUri),
                    "Please configure the Url of the endpoint micro service.");
            }
            _serviceUri = serviceUri;
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _resourceId = resourceId;
        }

        /// <inheritdoc/>
        public async Task<StatusResponseApiModel> GetServiceStatusAsync() {
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/status",
                _resourceId);
            var response = await _httpClient.GetAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<StatusResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<BrowseResponseApiModel> NodeBrowseAsync(string endpointId,
            BrowseRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/browse/{endpointId}",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<BrowseResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<BrowseNextResponseApiModel> NodeBrowseNextAsync(string endpointId,
            BrowseNextRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.ContinuationToken == null) {
                throw new ArgumentNullException(nameof(content.ContinuationToken));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/browse/{endpointId}/next",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<BrowseNextResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<BrowsePathResponseApiModel> NodeBrowsePathAsync(string endpointId,
            BrowsePathRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.PathElements == null || content.PathElements.Length == 0) {
                throw new ArgumentNullException(nameof(content.PathElements));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/browse/{endpointId}/path",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<BrowsePathResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<PublishStartResponseApiModel> NodePublishStartAsync(string endpointId,
            PublishStartRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.Item == null) {
                throw new ArgumentNullException(nameof(content.Item));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/publish/{endpointId}/start",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<PublishStartResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<PublishedItemListResponseApiModel> NodePublishListAsync(
            string endpointId, PublishedItemListRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/publish/{endpointId}",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<PublishedItemListResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<PublishStopResponseApiModel> NodePublishStopAsync(string endpointId,
            PublishStopRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.NodeId == null) {
                throw new ArgumentNullException(nameof(content.NodeId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/publish/{endpointId}/stop",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<PublishStopResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<ReadResponseApiModel> NodeReadAsync(string endpointId,
            ReadRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.Attributes == null || content.Attributes.Count == 0) {
                throw new ArgumentException(nameof(content.Attributes));
            }
            var request = _httpClient.NewRequest(
                $"{_serviceUri}/v1/read/{endpointId}/attributes", _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<ReadResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<WriteResponseApiModel> NodeWriteAsync(string endpointId,
            WriteRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.Attributes == null || content.Attributes.Count == 0) {
                throw new ArgumentException(nameof(content.Attributes));
            }
            var request = _httpClient.NewRequest(
                $"{_serviceUri}/v1/write/{endpointId}/attributes", _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<WriteResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<ValueReadResponseApiModel> NodeValueReadAsync(string endpointId,
            ValueReadRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (string.IsNullOrEmpty(content.NodeId)) {
                throw new ArgumentException(nameof(content.NodeId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/read/{endpointId}",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<ValueReadResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<ValueWriteResponseApiModel> NodeValueWriteAsync(string endpointId,
            ValueWriteRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.Value == null) {
                throw new ArgumentNullException(nameof(content.Value));
            }
            if (string.IsNullOrEmpty(content.NodeId)) {
                throw new ArgumentException(nameof(content.NodeId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/write/{endpointId}",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<ValueWriteResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<MethodMetadataResponseApiModel> NodeMethodGetMetadataAsync(
            string endpointId, MethodMetadataRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (string.IsNullOrEmpty(content.MethodId)) {
                throw new ArgumentNullException(nameof(content.MethodId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/call/{endpointId}/$metadata",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<MethodMetadataResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<MethodCallResponseApiModel> NodeMethodCallAsync(
            string endpointId, MethodCallRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (string.IsNullOrEmpty(content.MethodId)) {
                throw new ArgumentNullException(nameof(content.MethodId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/call/{endpointId}",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<MethodCallResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<HistoryReadResponseApiModel> NodeHistoryReadAsync(
            string endpointId, HistoryReadRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.Request == null) {
                throw new ArgumentNullException(nameof(content.Request));
            }
            if (string.IsNullOrEmpty(content.NodeId)) {
                throw new ArgumentNullException(nameof(content.NodeId));
            }
            var request = _httpClient.NewRequest(
                $"{_serviceUri}/v1/read/{endpointId}/history", _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<HistoryReadResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<HistoryReadNextResponseApiModel> NodeHistoryReadNextAsync(
            string endpointId, HistoryReadNextRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (string.IsNullOrEmpty(content.ContinuationToken)) {
                throw new ArgumentNullException(nameof(content.ContinuationToken));
            }
            var request = _httpClient.NewRequest(
                $"{_serviceUri}/v1/read/{endpointId}/history/next", _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<HistoryReadNextResponseApiModel>(
                response.GetContentAsString());
        }

        /// <inheritdoc/>
        public async Task<HistoryUpdateResponseApiModel> NodeHistoryUpdateAsync(
            string endpointId, HistoryUpdateRequestApiModel content) {
            if (string.IsNullOrEmpty(endpointId)) {
                throw new ArgumentNullException(nameof(endpointId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.Request == null) {
                throw new ArgumentNullException(nameof(content.Request));
            }
            var request = _httpClient.NewRequest(
                $"{_serviceUri}/v1/write/{endpointId}/history", _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<HistoryUpdateResponseApiModel>(
                response.GetContentAsString());
        }

        private const string kContinuationTokenHeaderKey = "x-ms-continuation";
        private const string kPageSizeHeaderKey = "x-ms-max-item-count";
        private readonly IHttpClient _httpClient;
        private readonly ILogger _logger;
        private readonly string _serviceUri;
        private readonly string _resourceId;
    }
}
