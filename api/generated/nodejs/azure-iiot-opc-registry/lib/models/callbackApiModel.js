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
 * A registered callback
 *
 */
class CallbackApiModel {
  /**
   * Create a CallbackApiModel.
   * @property {string} [uri] Uri to call - should use https scheme in which
   * case security is enforced.
   * @property {string} [method] Http Method to use for callback. Possible
   * values include: 'Get', 'Post', 'Put', 'Delete'
   * @property {string} [authenticationHeader] Authentication header to add or
   * null if not needed
   */
  constructor() {
  }

  /**
   * Defines the metadata of CallbackApiModel
   *
   * @returns {object} metadata of CallbackApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'CallbackApiModel',
      type: {
        name: 'Composite',
        className: 'CallbackApiModel',
        modelProperties: {
          uri: {
            required: false,
            serializedName: 'uri',
            type: {
              name: 'String'
            }
          },
          method: {
            required: false,
            serializedName: 'method',
            type: {
              name: 'Enum',
              allowedValues: [ 'Get', 'Post', 'Put', 'Delete' ]
            }
          },
          authenticationHeader: {
            required: false,
            serializedName: 'authenticationHeader',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = CallbackApiModel;
