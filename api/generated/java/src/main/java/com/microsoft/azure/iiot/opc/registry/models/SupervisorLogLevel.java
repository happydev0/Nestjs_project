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

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * Defines values for SupervisorLogLevel.
 */
public enum SupervisorLogLevel {
    /** Enum value Error. */
    ERROR("Error"),

    /** Enum value Information. */
    INFORMATION("Information"),

    /** Enum value Debug. */
    DEBUG("Debug"),

    /** Enum value Verbose. */
    VERBOSE("Verbose");

    /** The actual serialized value for a SupervisorLogLevel instance. */
    private String value;

    SupervisorLogLevel(String value) {
        this.value = value;
    }

    /**
     * Parses a serialized value to a SupervisorLogLevel instance.
     *
     * @param value the serialized value to parse.
     * @return the parsed SupervisorLogLevel object, or null if unable to parse.
     */
    @JsonCreator
    public static SupervisorLogLevel fromString(String value) {
        SupervisorLogLevel[] items = SupervisorLogLevel.values();
        for (SupervisorLogLevel item : items) {
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