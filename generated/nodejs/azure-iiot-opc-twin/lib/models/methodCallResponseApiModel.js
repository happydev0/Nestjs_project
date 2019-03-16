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
 * Method call response model
 *
 */
class MethodCallResponseApiModel {
  /**
   * Create a MethodCallResponseApiModel.
   * @property {array} [results] Output results
   * @property {object} [errorInfo] Service result in case of error
   * @property {number} [errorInfo.statusCode] Error code - if null operation
   * succeeded.
   * @property {string} [errorInfo.errorMessage] Error message in case of error
   * or null.
   * @property {object} [errorInfo.diagnostics] Additional diagnostics
   * information
   */
  constructor() {
  }

  /**
   * Defines the metadata of MethodCallResponseApiModel
   *
   * @returns {object} metadata of MethodCallResponseApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'MethodCallResponseApiModel',
      type: {
        name: 'Composite',
        className: 'MethodCallResponseApiModel',
        modelProperties: {
          results: {
            required: false,
            serializedName: 'results',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'MethodCallArgumentApiModelElementType',
                  type: {
                    name: 'Composite',
                    className: 'MethodCallArgumentApiModel'
                  }
              }
            }
          },
          errorInfo: {
            required: false,
            serializedName: 'errorInfo',
            type: {
              name: 'Composite',
              className: 'ServiceResultApiModel'
            }
          }
        }
      }
    };
  }
}

module.exports = MethodCallResponseApiModel;
