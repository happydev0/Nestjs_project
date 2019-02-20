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
 * Attribute write result.
 */
public class AttributeWriteResponseApiModel {
    /**
     * Service result in case of error.
     */
    @JsonProperty(value = "errorInfo")
    private ServiceResultApiModel errorInfo;

    /**
     * Get service result in case of error.
     *
     * @return the errorInfo value
     */
    public ServiceResultApiModel errorInfo() {
        return this.errorInfo;
    }

    /**
     * Set service result in case of error.
     *
     * @param errorInfo the errorInfo value to set
     * @return the AttributeWriteResponseApiModel object itself.
     */
    public AttributeWriteResponseApiModel withErrorInfo(ServiceResultApiModel errorInfo) {
        this.errorInfo = errorInfo;
        return this;
    }

}
