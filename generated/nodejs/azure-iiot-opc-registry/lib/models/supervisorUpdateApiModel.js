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
 * Supervisor registration update request
 *
 */
class SupervisorUpdateApiModel {
  /**
   * Create a SupervisorUpdateApiModel.
   * @property {string} [siteId] Site of the supervisor
   * @property {string} [discovery] Whether the supervisor is in discovery
   * mode.
   * If null, does not change. Possible values include: 'Off', 'Local',
   * 'Network', 'Fast', 'Scan'. Default value: 'Off' .
   * @property {object} [discoveryConfig] Supervisor discovery configuration
   * @property {string} [discoveryConfig.addressRangesToScan] Address ranges to
   * scan (null == all wired nics)
   * @property {number} [discoveryConfig.networkProbeTimeoutMs] Networking
   * probe timeout
   * @property {number} [discoveryConfig.maxNetworkProbes] Max network probes
   * that should ever run.
   * @property {string} [discoveryConfig.portRangesToScan] Port ranges to scan
   * (null == all unassigned)
   * @property {number} [discoveryConfig.portProbeTimeoutMs] Port probe timeout
   * @property {number} [discoveryConfig.maxPortProbes] Max port probes that
   * should ever run.
   * @property {number} [discoveryConfig.minPortProbesPercent] Probes that must
   * always be there as percent of max.
   * @property {number} [discoveryConfig.idleTimeBetweenScansSec] Delay time
   * between discovery sweeps in seconds
   * @property {array} [discoveryConfig.discoveryUrls] List of preset discovery
   * urls to use
   * @property {array} [discoveryConfig.locales] List of locales to filter with
   * during discovery
   * @property {array} [discoveryConfig.callbacks] Callbacks to invoke once
   * onboarding finishes
   * @property {object} [discoveryConfig.activationFilter] Activate all twins
   * with this filter during onboarding.
   * @property {array} [discoveryConfig.activationFilter.trustLists]
   * Certificate trust list identifiers to use for
   * activation, if null, all certificates are
   * trusted.  If empty list, no certificates are
   * trusted which is equal to no filter.
   * @property {array} [discoveryConfig.activationFilter.securityPolicies]
   * Endpoint security policies to filter against.
   * If set to null, all policies are in scope.
   * @property {string} [discoveryConfig.activationFilter.securityMode]
   * Security mode level to activate. If null,
   * then Microsoft.Azure.IIoT.OpcUa.Registry.Models.SecurityMode.Best is
   * assumed. Possible values include: 'Best', 'Sign', 'SignAndEncrypt', 'None'
   * @property {array} [discoveryCallbacks] Callbacks to add or remove (see
   * below)
   * @property {boolean} [removeDiscoveryCallbacks] Whether to add or remove
   * callbacks
   */
  constructor() {
  }

  /**
   * Defines the metadata of SupervisorUpdateApiModel
   *
   * @returns {object} metadata of SupervisorUpdateApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'SupervisorUpdateApiModel',
      type: {
        name: 'Composite',
        className: 'SupervisorUpdateApiModel',
        modelProperties: {
          siteId: {
            required: false,
            serializedName: 'siteId',
            type: {
              name: 'String'
            }
          },
          discovery: {
            required: false,
            serializedName: 'discovery',
            defaultValue: 'Off',
            type: {
              name: 'Enum',
              allowedValues: [ 'Off', 'Local', 'Network', 'Fast', 'Scan' ]
            }
          },
          discoveryConfig: {
            required: false,
            serializedName: 'discoveryConfig',
            type: {
              name: 'Composite',
              className: 'DiscoveryConfigApiModel'
            }
          },
          discoveryCallbacks: {
            required: false,
            serializedName: 'discoveryCallbacks',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'CallbackApiModelElementType',
                  type: {
                    name: 'Composite',
                    className: 'CallbackApiModel'
                  }
              }
            }
          },
          removeDiscoveryCallbacks: {
            required: false,
            serializedName: 'removeDiscoveryCallbacks',
            type: {
              name: 'Boolean'
            }
          }
        }
      }
    };
  }
}

module.exports = SupervisorUpdateApiModel;
