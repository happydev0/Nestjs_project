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
 * Value read response model
 *
 */
class ValueReadResponseApiModel {
  /**
   * Create a ValueReadResponseApiModel.
   * @property {object} [value] Value read
   * @property {string} [dataType] Built in data type of the value read.
   * @property {number} [sourcePicoseconds] Pico seconds part of when value was
   * read at source.
   * @property {date} [sourceTimestamp] Timestamp of when value was read at
   * source.
   * @property {number} [serverPicoseconds] Pico seconds part of when value was
   * read at server.
   * @property {date} [serverTimestamp] Timestamp of when value was read at
   * server.
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
   * Defines the metadata of ValueReadResponseApiModel
   *
   * @returns {object} metadata of ValueReadResponseApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'ValueReadResponseApiModel',
      type: {
        name: 'Composite',
        className: 'ValueReadResponseApiModel',
        modelProperties: {
          value: {
            required: false,
            serializedName: 'value',
            type: {
              name: 'Object'
            }
          },
          dataType: {
            required: false,
            serializedName: 'dataType',
            type: {
              name: 'String'
            }
          },
          sourcePicoseconds: {
            required: false,
            serializedName: 'sourcePicoseconds',
            type: {
              name: 'Number'
            }
          },
          sourceTimestamp: {
            required: false,
            serializedName: 'sourceTimestamp',
            type: {
              name: 'DateTime'
            }
          },
          serverPicoseconds: {
            required: false,
            serializedName: 'serverPicoseconds',
            type: {
              name: 'Number'
            }
          },
          serverTimestamp: {
            required: false,
            serializedName: 'serverTimestamp',
            type: {
              name: 'DateTime'
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

module.exports = ValueReadResponseApiModel;
