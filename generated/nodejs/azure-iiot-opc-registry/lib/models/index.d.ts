/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is regenerated.
 */

import * as moment from "moment";

/**
 * A registered callback
 */
export interface CallbackApiModel {
  /**
   * Uri to call - should use https scheme in which
   * case security is enforced.
   */
  uri?: string;
  /**
   * Http Method to use for callback. Possible values include: 'Get', 'Post', 'Put', 'Delete'
   */
  method?: string;
  /**
   * Authentication header to add or null if not needed
   */
  authenticationHeader?: string;
}

/**
 * Endpoint Activation Filter model
 */
export interface EndpointActivationFilterApiModel {
  /**
   * Certificate trust list identifiers to use for
   * activation, if null, all certificates are
   * trusted.  If empty list, no certificates are
   * trusted which is equal to no filter.
   */
  trustLists?: string[];
  /**
   * Endpoint security policies to filter against.
   * If set to null, all policies are in scope.
   */
  securityPolicies?: string[];
  /**
   * Security mode level to activate. If null,
   * then Microsoft.Azure.IIoT.OpcUa.Registry.Models.SecurityMode.Best is assumed. Possible values
   * include: 'Best', 'Sign', 'SignAndEncrypt', 'None'
   */
  securityMode?: string;
}

/**
 * Application registration request
 */
export interface ServerRegistrationRequestApiModel {
  /**
   * Discovery url to use for registration
   */
  discoveryUrl: string;
  /**
   * Registration id
   */
  id?: string;
  /**
   * An optional callback hook to register.
   */
  callback?: CallbackApiModel;
  /**
   * Upon discovery, activate all endpoints with this filter.
   */
  activationFilter?: EndpointActivationFilterApiModel;
}

/**
 * Application information
 */
export interface ApplicationRegistrationRequestApiModel {
  /**
   * Unique application uri
   */
  applicationUri: string;
  /**
   * Type of application. Possible values include: 'Server', 'Client', 'ClientAndServer'
   */
  applicationType?: string;
  /**
   * Product uri of the application.
   */
  productUri?: string;
  /**
   * Name of the server or client.
   */
  applicationName?: string;
  /**
   * Locale of name
   */
  locale?: string;
  /**
   * The OPC UA defined capabilities of the server.
   */
  capabilities?: string[];
  /**
   * Discovery urls of the server.
   */
  discoveryUrls?: string[];
  /**
   * The discovery profile uri of the server.
   */
  discoveryProfileUri?: string;
}

/**
 * Result of an application registration
 */
export interface ApplicationRegistrationResponseApiModel {
  /**
   * New id application was registered under
   */
  id?: string;
}

/**
 * Application info model
 */
export interface ApplicationInfoApiModel {
  /**
   * Unique application id
   */
  applicationId?: string;
  /**
   * Type of application. Possible values include: 'Server', 'Client', 'ClientAndServer'
   */
  applicationType?: string;
  /**
   * Unique application uri
   */
  applicationUri?: string;
  /**
   * Product uri
   */
  productUri?: string;
  /**
   * Name of server
   */
  applicationName?: string;
  /**
   * Locale of name - defaults to "en"
   */
  locale?: string;
  /**
   * Application public cert
   */
  certificate?: Buffer;
  /**
   * The capabilities advertised by the server.
   */
  capabilities?: string[];
  /**
   * Discovery urls of the server
   */
  discoveryUrls?: string[];
  /**
   * Discovery profile uri
   */
  discoveryProfileUri?: string;
  /**
   * Host addresses of server application or null
   */
  hostAddresses?: string[];
  /**
   * Site of the application
   */
  siteId?: string;
  /**
   * Supervisor having registered the application
   */
  supervisorId?: string;
  /**
   * Last time application was seen
   */
  notSeenSince?: Date;
}

/**
 * List of registered applications
 */
export interface ApplicationInfoListApiModel {
  /**
   * Application infos
   */
  items?: ApplicationInfoApiModel[];
  /**
   * Continuation or null if final
   */
  continuationToken?: string;
}

/**
 * Discovery configuration
 */
export interface DiscoveryConfigApiModel {
  /**
   * Address ranges to scan (null == all wired nics)
   */
  addressRangesToScan?: string;
  /**
   * Network probe timeout
   */
  networkProbeTimeoutMs?: number;
  /**
   * Max network probes that should ever run.
   */
  maxNetworkProbes?: number;
  /**
   * Port ranges to scan (null == all unassigned)
   */
  portRangesToScan?: string;
  /**
   * Port probe timeout
   */
  portProbeTimeoutMs?: number;
  /**
   * Max port probes that should ever run.
   */
  maxPortProbes?: number;
  /**
   * Probes that must always be there as percent of max.
   */
  minPortProbesPercent?: number;
  /**
   * Delay time between discovery sweeps in seconds
   */
  idleTimeBetweenScansSec?: number;
  /**
   * List of preset discovery urls to use
   */
  discoveryUrls?: string[];
  /**
   * List of locales to filter with during discovery
   */
  locales?: string[];
  /**
   * Callbacks to invoke once onboarding finishes
   */
  callbacks?: CallbackApiModel[];
  /**
   * Activate all twins with this filter during onboarding.
   */
  activationFilter?: EndpointActivationFilterApiModel;
}

/**
 * Discovery request
 */
export interface DiscoveryRequestApiModel {
  /**
   * Id of discovery request
   */
  id?: string;
  /**
   * Discovery mode to use. Possible values include: 'Off', 'Local', 'Network', 'Fast', 'Scan'
   */
  discovery?: string;
  /**
   * Scan configuration to use
   */
  configuration?: DiscoveryConfigApiModel;
}

/**
 * Credential model
 */
export interface CredentialApiModel {
  /**
   * Type of credential. Possible values include: 'None', 'UserName', 'X509Certificate', 'JwtToken'
   */
  type?: string;
  /**
   * Value to pass to server
   */
  value?: any;
}

/**
 * Endpoint model
 */
export interface EndpointApiModel {
  /**
   * Endpoint
   */
  url: string;
  /**
   * User Authentication
   */
  user?: CredentialApiModel;
  /**
   * Security Mode to use for communication
   * default to best. Possible values include: 'Best', 'Sign', 'SignAndEncrypt', 'None'
   */
  securityMode?: string;
  /**
   * Security policy uri to use for communication
   * default to best.
   */
  securityPolicy?: string;
  /**
   * Thumbprint to validate against or null to trust any.
   */
  serverThumbprint?: Buffer;
}

/**
 * Authentication Method model
 */
export interface AuthenticationMethodApiModel {
  /**
   * Method id
   */
  id: string;
  /**
   * Type of credential. Possible values include: 'None', 'UserName', 'X509Certificate', 'JwtToken'
   */
  credentialType?: string;
  /**
   * Security policy to use when passing credential.
   */
  securityPolicy?: string;
  /**
   * Method specific configuration
   */
  configuration?: any;
}

/**
 * Endpoint registration model
 */
export interface EndpointRegistrationApiModel {
  /**
   * Registered identifier of the endpoint
   */
  id: string;
  /**
   * Registered site of the endpoint
   */
  siteId?: string;
  /**
   * Endpoint information of the registration
   */
  endpoint: EndpointApiModel;
  /**
   * Security level of the endpoint
   */
  securityLevel?: number;
  /**
   * Endpoint cert that was registered.
   */
  certificate?: Buffer;
  /**
   * Supported authentication methods that can be selected to
   * obtain a credential and used to interact with the endpoint.
   */
  authenticationMethods?: AuthenticationMethodApiModel[];
}

/**
 * Application with list of endpoints
 */
export interface ApplicationRegistrationApiModel {
  /**
   * Application information
   */
  application: ApplicationInfoApiModel;
  /**
   * List of endpoint twins
   */
  endpoints?: EndpointRegistrationApiModel[];
  /**
   * Application security assessment. Possible values include: 'Unknown', 'Low', 'Medium', 'High'
   */
  securityAssessment?: string;
}

/**
 * Application registration update request
 */
export interface ApplicationRegistrationUpdateApiModel {
  /**
   * Product uri
   */
  productUri?: string;
  /**
   * Application name
   */
  applicationName?: string;
  /**
   * Locale of name - defaults to "en"
   */
  locale?: string;
  /**
   * Application public cert
   */
  certificate?: Buffer;
  /**
   * Capabilities of the application
   */
  capabilities?: string[];
  /**
   * Discovery urls of the application
   */
  discoveryUrls?: string[];
  /**
   * Discovery profile uri
   */
  discoveryProfileUri?: string;
}

/**
 * List of application sites
 */
export interface ApplicationSiteListApiModel {
  /**
   * Distinct list of sites applications were registered in.
   */
  sites?: string[];
  /**
   * Continuation or null if final
   */
  continuationToken?: string;
}

/**
 * Application information
 */
export interface ApplicationRegistrationQueryApiModel {
  /**
   * Type of application. Possible values include: 'Server', 'Client', 'ClientAndServer'
   */
  applicationType?: string;
  /**
   * Application uri
   */
  applicationUri?: string;
  /**
   * Product uri
   */
  productUri?: string;
  /**
   * Name of application
   */
  applicationName?: string;
  /**
   * Locale of application name - default is "en"
   */
  locale?: string;
  /**
   * Application capability to query with
   */
  capability?: string;
  /**
   * Supervisor or site the application belongs to.
   */
  siteOrSupervisorId?: string;
  /**
   * Whether to include apps that were soft deleted
   */
  includeNotSeenSince?: boolean;
}

/**
 * Endpoint registration update request
 */
export interface EndpointRegistrationUpdateApiModel {
  /**
   * User authentication to change on the endpoint.
   */
  user?: CredentialApiModel;
}

/**
 * Endpoint registration model
 */
export interface EndpointInfoApiModel {
  /**
   * Endpoint registration
   */
  registration: EndpointRegistrationApiModel;
  /**
   * Application id endpoint is registered under.
   */
  applicationId: string;
  /**
   * Activation state of endpoint. Possible values include: 'Deactivated', 'Activated',
   * 'ActivatedAndConnected'
   */
  activationState?: string;
  /**
   * Last state of the activated endpoint. Possible values include: 'Connecting', 'NotReachable',
   * 'Busy', 'NoTrust', 'CertificateInvalid', 'Ready', 'Error'
   */
  endpointState?: string;
  /**
   * Whether the registration is out of sync
   */
  outOfSync?: boolean;
  /**
   * Last time endpoint was seen
   */
  notSeenSince?: Date;
}

/**
 * Endpoint registration list
 */
export interface EndpointInfoListApiModel {
  /**
   * Endpoint registrations
   */
  items?: EndpointInfoApiModel[];
  /**
   * Continuation or null if final
   */
  continuationToken?: string;
}

/**
 * Endpoint query
 */
export interface EndpointRegistrationQueryApiModel {
  /**
   * Endoint url for direct server access
   */
  url?: string;
  /**
   * Type of credential selected for authentication. Possible values include: 'None', 'UserName',
   * 'X509Certificate', 'JwtToken'
   */
  userAuthentication?: string;
  /**
   * Certificate of the endpoint
   */
  certificate?: Buffer;
  /**
   * Security Mode. Possible values include: 'Best', 'Sign', 'SignAndEncrypt', 'None'
   */
  securityMode?: string;
  /**
   * Security policy uri
   */
  securityPolicy?: string;
  /**
   * Whether the endpoint was activated
   */
  activated?: boolean;
  /**
   * Whether the endpoint is connected on supervisor.
   */
  connected?: boolean;
  /**
   * Whether to include endpoints that were soft deleted
   */
  includeNotSeenSince?: boolean;
}

/**
 * Status response model
 */
export interface StatusResponseApiModel {
  /**
   * Name of this service
   */
  readonly name?: string;
  /**
   * Operational status
   */
  status?: string;
  /**
   * Current time
   */
  readonly currentTime?: string;
  /**
   * Start time of service
   */
  readonly startTime?: string;
  /**
   * Up time of service
   */
  readonly upTime?: number;
  /**
   * Value generated at bootstrap by each instance of the service and
   * used to correlate logs coming from the same instance. The value
   * changes every time the service starts.
   */
  readonly uid?: string;
  /**
   * A property bag with details about the service
   */
  readonly properties?: { [propertyName: string]: string };
  /**
   * A property bag with details about the internal dependencies
   */
  readonly dependencies?: { [propertyName: string]: string };
  /**
   * Optional meta data.
   */
  readonly metadata?: { [propertyName: string]: string };
}

/**
 * Supervisor registration model
 */
export interface SupervisorApiModel {
  /**
   * Supervisor id
   */
  id: string;
  /**
   * Site of the supervisor
   */
  siteId?: string;
  /**
   * Whether the supervisor is in discovery mode. Possible values include: 'Off', 'Local',
   * 'Network', 'Fast', 'Scan'
   */
  discovery?: string;
  /**
   * Supervisor configuration
   */
  discoveryConfig?: DiscoveryConfigApiModel;
  /**
   * Supervisor public client cert
   */
  certificate?: Buffer;
  /**
   * Whether the registration is out of sync between
   * client (module) and server (service) (default: false).
   */
  outOfSync?: boolean;
  /**
   * Whether supervisor is connected on this registration
   */
  connected?: boolean;
}

/**
 * Supervisor registration update request
 */
export interface SupervisorUpdateApiModel {
  /**
   * Site of the supervisor
   */
  siteId?: string;
  /**
   * Whether the supervisor is in discovery mode.
   * If null, does not change. Possible values include: 'Off', 'Local', 'Network', 'Fast', 'Scan'
   */
  discovery?: string;
  /**
   * Supervisor discovery configuration
   */
  discoveryConfig?: DiscoveryConfigApiModel;
  /**
   * Callbacks to add or remove (see below)
   */
  discoveryCallbacks?: CallbackApiModel[];
  /**
   * Whether to add or remove callbacks
   */
  removeDiscoveryCallbacks?: boolean;
}

/**
 * Endpoint Activation status model
 */
export interface EndpointActivationStatusApiModel {
  /**
   * Identifier of the endoint
   */
  id: string;
  /**
   * Activation state. Possible values include: 'Deactivated', 'Activated', 'ActivatedAndConnected'
   */
  activationState?: string;
}

/**
 * Supervisor runtime status
 */
export interface SupervisorStatusApiModel {
  /**
   * Edge device id
   */
  deviceId: string;
  /**
   * Module id
   */
  moduleId?: string;
  /**
   * Site id
   */
  siteId?: string;
  /**
   * Endpoint activation status
   */
  endpoints?: EndpointActivationStatusApiModel[];
}

/**
 * Supervisor registration list
 */
export interface SupervisorListApiModel {
  /**
   * Registrations
   */
  items?: SupervisorApiModel[];
  /**
   * Continuation or null if final
   */
  continuationToken?: string;
}

/**
 * Supervisor registration query
 */
export interface SupervisorQueryApiModel {
  /**
   * Site of the supervisor
   */
  siteId?: string;
  /**
   * Discovery mode of supervisor. Possible values include: 'Off', 'Local', 'Network', 'Fast',
   * 'Scan'
   */
  discovery?: string;
  /**
   * Included connected or disconnected
   */
  connected?: boolean;
}
