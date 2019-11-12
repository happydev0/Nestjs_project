// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Registry {
    using Microsoft.Azure.IIoT.OpcUa.Api.Registry.Models;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Registry api calls
    /// </summary>
    public interface IRegistryServiceApi {

        /// <summary>
        /// Returns status of the service
        /// </summary>
        /// <returns></returns>
        Task<StatusResponseApiModel> GetServiceStatusAsync(
            CancellationToken ct = default);

        /// <summary>
        /// Kick off onboarding of new server
        /// </summary>
        /// <param name="request"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task RegisterAsync(ServerRegistrationRequestApiModel request,
            CancellationToken ct = default);

        /// <summary>
        /// Kick off a one time discovery on all supervisors
        /// </summary>
        /// <param name="request"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DiscoverAsync(DiscoveryRequestApiModel request,
            CancellationToken ct = default);

        /// <summary>
        /// Cancel a discovery request with a particular id
        /// </summary>
        /// <param name="request"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task CancelAsync(DiscoveryCancelApiModel request,
            CancellationToken ct = default);

        /// <summary>
        /// Register new application.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<ApplicationRegistrationResponseApiModel> RegisterAsync(
            ApplicationRegistrationRequestApiModel request,
            CancellationToken ct = default);

        /// <summary>
        /// Get application for specified unique application id
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<ApplicationRegistrationApiModel> GetApplicationAsync(
            string applicationId, CancellationToken ct = default);

        /// <summary>
        /// Update an application' properties.
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="request"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UpdateApplicationAsync(string applicationId,
            ApplicationRegistrationUpdateApiModel request,
            CancellationToken ct = default);

        /// <summary>
        /// List all Application sites to visually group applications.
        /// </summary>
        /// <param name="continuation"></param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<ApplicationSiteListApiModel> ListSitesAsync(
            string continuation = null, int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// List all applications or continue a QueryApplications
        /// call.
        /// </summary>
        /// <param name="continuation"></param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<ApplicationInfoListApiModel> ListApplicationsAsync(
            string continuation = null, int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Find applications based on specified criteria. Pass
        /// continuation token if any returned to ListApplications to
        /// retrieve remaining items.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<ApplicationInfoListApiModel> QueryApplicationsAsync(
            ApplicationRegistrationQueryApiModel query, int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Enable the application
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task EnableApplicationAsync(string applicationId,
            CancellationToken ct = default);

        /// <summary>
        /// Disable the application
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DisableApplicationAsync(string applicationId,
            CancellationToken ct = default);

        /// <summary>
        /// Unregister and delete application and all endpoints.
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UnregisterApplicationAsync(string applicationId,
            CancellationToken ct = default);

        /// <summary>
        /// Unregister disabled applications not seen since specified
        /// amount of time.
        /// </summary>
        /// <param name="notSeenSince"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PurgeDisabledApplicationsAsync(TimeSpan notSeenSince,
            CancellationToken ct = default);

        /// <summary>
        /// Subscribe client to application events
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task SubscribeApplicationEventsAsync(string userId,
            CancellationToken ct = default);

        /// <summary>
        /// Unsubscribe client from application events
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UnsubscribeApplicationEventsAsync(string userId,
            CancellationToken ct = default);

        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="onlyServerState"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<EndpointInfoApiModel> GetEndpointAsync(
            string endpointId, bool? onlyServerState = null,
            CancellationToken ct = default);

        /// <summary>
        /// Set endpoint activation state to activated
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task ActivateEndpointAsync(string endpointId,
            CancellationToken ct = default);

        /// <summary>
        /// Set endpoint activation state to deactivated
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeactivateEndpointAsync(string endpointId,
            CancellationToken ct = default);

        /// <summary>
        /// List all endpoints
        /// </summary>
        /// <param name="continuation"></param>
        /// <param name="onlyServerState"></param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<EndpointInfoListApiModel> ListEndpointsAsync(
            string continuation = null, bool? onlyServerState = null,
            int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Find endpoint based on specified critiria. Pass continuation
        /// token if any is returned to ListTwins to retrieve
        /// the remaining items
        /// </summary>
        /// <param name="query"></param>
        /// <param name="onlyServerState"></param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<EndpointInfoListApiModel> QueryEndpointsAsync(
            EndpointRegistrationQueryApiModel query,
            bool? onlyServerState = null, int? pageSize = null,
            CancellationToken ct = default);

        /// <summary>
        /// Subscribe client to endpoint events
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task SubscribeEndpointEventsAsync(string userId,
            CancellationToken ct = default);

        /// <summary>
        /// Unsubscribe client from endpoint events
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UnsubscribeEndpointEventsAsync(string userId,
            CancellationToken ct = default);

        /// <summary>
        /// Get supervisor runtime status
        /// </summary>
        /// <param name="supervisorId"></param>
        /// <param name="ct"></param>
        /// <returns>Supervisor diagnostics</returns>
        Task<SupervisorStatusApiModel> GetSupervisorStatusAsync(
            string supervisorId, CancellationToken ct = default);

        /// <summary>
        /// Reset and restart supervisor
        /// </summary>
        /// <param name="supervisorId"></param>
        /// <param name="ct"></param>
        Task ResetSupervisorAsync(string supervisorId,
            CancellationToken ct = default);

        /// <summary>
        /// Get supervisor
        /// </summary>
        /// <param name="supervisorId"></param>
        /// <param name="onlyServerState"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<SupervisorApiModel> GetSupervisorAsync(
            string supervisorId, bool? onlyServerState = null,
            CancellationToken ct = default);

        /// <summary>
        /// Update supervisor including config updates.
        /// </summary>
        /// <param name="supervisorId"></param>
        /// <param name="request"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UpdateSupervisorAsync(string supervisorId,
            SupervisorUpdateApiModel request,
            CancellationToken ct = default);

        /// <summary>
        /// List all supervisors
        /// </summary>
        /// <param name="continuation"></param>
        /// <param name="onlyServerState"></param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<SupervisorListApiModel> ListSupervisorsAsync(
            string continuation = null, bool? onlyServerState = null,
            int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Find supervisors based on specified criteria. Pass
        /// continuation token if any returned to ListSupervisors to
        /// retrieve remaining items.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="onlyServerState"></param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<SupervisorListApiModel> QuerySupervisorsAsync(
            SupervisorQueryApiModel query, bool? onlyServerState = null,
            int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Subscribe client to supervisor events
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task SubscribeSupervisorEventsAsync(string userId,
            CancellationToken ct = default);

        /// <summary>
        /// Unsubscribe client from supervisor events
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UnsubscribeSupervisorEventsAsync(string userId,
            CancellationToken ct = default);

        /// <summary>
        /// Subscribe client to discovery progress from supervisor
        /// </summary>
        /// <param name="supervisorId"></param>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task SubscribeDiscoveryProgressBySupervisorsIdAsync(string supervisorId,
            string userId, CancellationToken ct = default);

        /// <summary>
        /// Subscribe client to progress on specifiy request
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task SubscribeDiscoveryProgressByRequestIdAsync(string requestId,
            string userId, CancellationToken ct = default);

        /// <summary>
        /// Enable or disable discovery with optional configuration
        /// </summary>
        /// <param name="supervisorId"></param>
        /// <param name="mode"></param>
        /// <param name="config"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task SetDiscoveryModeAsync(string supervisorId,
            DiscoveryMode mode, DiscoveryConfigApiModel config = null,
            CancellationToken ct = default);

        /// <summary>
        /// Unsubscribe client from discovery progress for specified request
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UnsubscribeDiscoveryProgressByRequestIdAsync(string requestId,
            string userId, CancellationToken ct = default);

        /// <summary>
        /// Unsubscribe client from discovery events
        /// </summary>
        /// <param name="supervisorId"></param>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UnsubscribeDiscoveryProgressBySupervisorsIdAsync(string supervisorId,
            string userId, CancellationToken ct = default);

        /// <summary>
        /// Get publisher
        /// </summary>
        /// <param name="publisherId"></param>
        /// <param name="onlyServerState"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<PublisherApiModel> GetPublisherAsync(
            string publisherId, bool? onlyServerState = null,
            CancellationToken ct = default);

        /// <summary>
        /// Update Publisher including config updates.
        /// </summary>
        /// <param name="publisherId"></param>
        /// <param name="request"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UpdatePublisherAsync(string publisherId,
            PublisherUpdateApiModel request,
            CancellationToken ct = default);

        /// <summary>
        /// List all publishers
        /// </summary>
        /// <param name="continuation"></param>
        /// <param name="onlyServerState"></param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<PublisherListApiModel> ListPublishersAsync(
            string continuation = null, bool? onlyServerState = null,
            int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Find publishers based on specified criteria. Pass
        /// continuation token if any returned to ListPublishers to
        /// retrieve remaining items.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="onlyServerState"></param>
        /// <param name="pageSize"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<PublisherListApiModel> QueryPublishersAsync(
            PublisherQueryApiModel query, bool? onlyServerState = null,
            int? pageSize = null, CancellationToken ct = default);

        /// <summary>
        /// Subscribe client to publisher events
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task SubscribePublisherEventsAsync(string userId,
            CancellationToken ct = default);

        /// <summary>
        /// Unsubscribe client from publisher events
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UnsubscribePublisherEventsAsync(string userId,
            CancellationToken ct = default);
    }
}
