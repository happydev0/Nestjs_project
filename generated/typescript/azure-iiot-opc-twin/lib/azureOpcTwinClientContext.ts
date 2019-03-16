/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import * as msRest from "@azure/ms-rest-js";
import * as Models from "./models";

const packageName = "";
const packageVersion = "";

export class AzureOpcTwinClientContext extends msRest.ServiceClient {
  credentials: msRest.ServiceClientCredentials;

  /**
   * Initializes a new instance of the AzureOpcTwinClientContext class.
   * @param credentials Subscription credentials which uniquely identify client subscription.
   * @param [options] The parameter options
   */
  constructor(credentials: msRest.ServiceClientCredentials, options?: Models.AzureOpcTwinClientOptions) {
    if (credentials === null || credentials === undefined) {
      throw new Error('\'credentials\' cannot be null.');
    }

    if (!options) {
      options = {};
    }
    if(!options.userAgent) {
      const defaultUserAgent = msRest.getDefaultUserAgentValue();
      options.userAgent = `${packageName}/${packageVersion} ${defaultUserAgent}`;
    }

    super(credentials, options);

    this.baseUri = options.baseUri || this.baseUri || "http://localhost";
    this.requestContentType = "application/json-patch+json; charset=utf-8";
    this.credentials = credentials;

  }
}
