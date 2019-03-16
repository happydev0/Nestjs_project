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
 * Defines values for ApplicationType.
 */
public enum ApplicationType {
    /** Enum value Server. */
    SERVER("Server"),

    /** Enum value Client. */
    CLIENT("Client"),

    /** Enum value ClientAndServer. */
    CLIENT_AND_SERVER("ClientAndServer");

    /** The actual serialized value for a ApplicationType instance. */
    private String value;

    ApplicationType(String value) {
        this.value = value;
    }

    /**
     * Parses a serialized value to a ApplicationType instance.
     *
     * @param value the serialized value to parse.
     * @return the parsed ApplicationType object, or null if unable to parse.
     */
    @JsonCreator
    public static ApplicationType fromString(String value) {
        ApplicationType[] items = ApplicationType.values();
        for (ApplicationType item : items) {
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
