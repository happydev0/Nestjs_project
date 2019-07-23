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
 * browse view model
 *
 */
class BrowseViewApiModel {
  /**
   * Create a BrowseViewApiModel.
   * @property {string} viewId Node of the view to browse
   * @property {number} [version] Browses specific version of the view.
   * @property {date} [timestamp] Browses at or before this timestamp.
   */
  constructor() {
  }

  /**
   * Defines the metadata of BrowseViewApiModel
   *
   * @returns {object} metadata of BrowseViewApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'BrowseViewApiModel',
      type: {
        name: 'Composite',
        className: 'BrowseViewApiModel',
        modelProperties: {
          viewId: {
            required: true,
            serializedName: 'viewId',
            type: {
              name: 'String'
            }
          },
          version: {
            required: false,
            serializedName: 'version',
            type: {
              name: 'Number'
            }
          },
          timestamp: {
            required: false,
            serializedName: 'timestamp',
            type: {
              name: 'DateTime'
            }
          }
        }
      }
    };
  }
}

module.exports = BrowseViewApiModel;
