/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.twin.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Request list of published items.
 */
public class PublishedItemListRequestApiModel {
    /**
     * Continuation token or null to start.
     */
    @JsonProperty(value = "continuationToken")
    private String continuationToken;

    /**
     * Get continuation token or null to start.
     *
     * @return the continuationToken value
     */
    public String continuationToken() {
        return this.continuationToken;
    }

    /**
     * Set continuation token or null to start.
     *
     * @param continuationToken the continuationToken value to set
     * @return the PublishedItemListRequestApiModel object itself.
     */
    public PublishedItemListRequestApiModel withContinuationToken(String continuationToken) {
        this.continuationToken = continuationToken;
        return this;
    }

}
