/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.registry.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Gateway registration query.
 */
public class GatewayQueryApiModel {
    /**
     * Site of the Gateway.
     */
    @JsonProperty(value = "siteId")
    private String siteId;

    /**
     * Included connected or disconnected.
     */
    @JsonProperty(value = "connected")
    private Boolean connected;

    /**
     * Get site of the Gateway.
     *
     * @return the siteId value
     */
    public String siteId() {
        return this.siteId;
    }

    /**
     * Set site of the Gateway.
     *
     * @param siteId the siteId value to set
     * @return the GatewayQueryApiModel object itself.
     */
    public GatewayQueryApiModel withSiteId(String siteId) {
        this.siteId = siteId;
        return this;
    }

    /**
     * Get included connected or disconnected.
     *
     * @return the connected value
     */
    public Boolean connected() {
        return this.connected;
    }

    /**
     * Set included connected or disconnected.
     *
     * @param connected the connected value to set
     * @return the GatewayQueryApiModel object itself.
     */
    public GatewayQueryApiModel withConnected(Boolean connected) {
        this.connected = connected;
        return this;
    }

}
