/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.history.models;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * Defines values for CallbackMethodType.
 */
public enum CallbackMethodType {
    /** Enum value Get. */
    GET("Get"),

    /** Enum value Post. */
    POST("Post"),

    /** Enum value Put. */
    PUT("Put"),

    /** Enum value Delete. */
    DELETE("Delete");

    /** The actual serialized value for a CallbackMethodType instance. */
    private String value;

    CallbackMethodType(String value) {
        this.value = value;
    }

    /**
     * Parses a serialized value to a CallbackMethodType instance.
     *
     * @param value the serialized value to parse.
     * @return the parsed CallbackMethodType object, or null if unable to parse.
     */
    @JsonCreator
    public static CallbackMethodType fromString(String value) {
        CallbackMethodType[] items = CallbackMethodType.values();
        for (CallbackMethodType item : items) {
            if (item.toString().equalsIgnoreCase(value)) {
                return item;
            }
        }
        return null;
    }

    @JsonValue
    @Override
    public String toString() {
        return this.value;
    }
}
