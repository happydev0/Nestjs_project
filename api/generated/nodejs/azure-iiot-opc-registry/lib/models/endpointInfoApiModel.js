/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * Endpoint registration model
 *
 */
class EndpointInfoApiModel {
  /**
   * Create a EndpointInfoApiModel.
   * @property {object} registration
   * @property {string} [registration.id] Registered identifier of the endpoint
   * @property {string} [registration.endpointUrl] Original endpoint url of the
   * endpoint
   * @property {string} [registration.siteId] Registered site of the endpoint
   * @property {string} [registration.supervisorId] Supervisor that manages the
   * endpoint.
   * @property {string} [registration.discovererId] Discoverer that registered
   * the endpoint
   * @property {object} [registration.endpoint]
   * @property {string} [registration.endpoint.url] Endpoint url to use to
   * connect with
   * @property {array} [registration.endpoint.alternativeUrls] Alternative
   * endpoint urls that can be used for
   * accessing and validating the server
   * @property {string} [registration.endpoint.securityMode] Possible values
   * include: 'Best', 'Sign', 'SignAndEncrypt', 'None'
   * @property {string} [registration.endpoint.securityPolicy] Security policy
   * uri to use for communication
   * default to best.
   * @property {buffer} [registration.endpoint.certificate] Endpoint
   * certificate that was registered.
   * @property {number} [registration.securityLevel] Security level of the
   * endpoint
   * @property {array} [registration.authenticationMethods] Supported
   * authentication methods that can be selected to
   * obtain a credential and used to interact with the endpoint.
   * @property {string} applicationId Application id endpoint is registered
   * under.
   * @property {string} [activationState] Possible values include:
   * 'Deactivated', 'Activated', 'ActivatedAndConnected'
   * @property {string} [endpointState] Possible values include: 'Connecting',
   * 'NotReachable', 'Busy', 'NoTrust', 'CertificateInvalid', 'Ready', 'Error'
   * @property {boolean} [outOfSync] Whether the registration is out of sync
   * @property {date} [notSeenSince] Last time endpoint was seen
   */
  constructor() {
  }

  /**
   * Defines the metadata of EndpointInfoApiModel
   *
   * @returns {object} metadata of EndpointInfoApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'EndpointInfoApiModel',
      type: {
        name: 'Composite',
        className: 'EndpointInfoApiModel',
        modelProperties: {
          registration: {
            required: true,
            serializedName: 'registration',
            type: {
              name: 'Composite',
              className: 'EndpointRegistrationApiModel'
            }
          },
          applicationId: {
            required: true,
            serializedName: 'applicationId',
            type: {
              name: 'String'
            }
          },
          activationState: {
            required: false,
            serializedName: 'activationState',
            type: {
              name: 'Enum',
              allowedValues: [ 'Deactivated', 'Activated', 'ActivatedAndConnected' ]
            }
          },
          endpointState: {
            required: false,
            serializedName: 'endpointState',
            type: {
              name: 'Enum',
              allowedValues: [ 'Connecting', 'NotReachable', 'Busy', 'NoTrust', 'CertificateInvalid', 'Ready', 'Error' ]
            }
          },
          outOfSync: {
            required: false,
            serializedName: 'outOfSync',
            type: {
              name: 'Boolean'
            }
          },
          notSeenSince: {
            required: false,
            serializedName: 'notSeenSince',
            type: {
              name: 'DateTime'
            }
          }
        }
      }
    };
  }
}

module.exports = EndpointInfoApiModel;
