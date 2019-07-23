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
 * Defines values for CredentialType.
 */
public enum CredentialType {
    /** Enum value None. */
    NONE("None"),

    /** Enum value UserName. */
    USER_NAME("UserName"),

    /** Enum value X509Certificate. */
    X509CERTIFICATE("X509Certificate"),

    /** Enum value JwtToken. */
    JWT_TOKEN("JwtToken");

    /** The actual serialized value for a CredentialType instance. */
    private String value;

    CredentialType(String value) {
        this.value = value;
    }

    /**
     * Parses a serialized value to a CredentialType instance.
     *
     * @param value the serialized value to parse.
     * @return the parsed CredentialType object, or null if unable to parse.
     */
    @JsonCreator
    public static CredentialType fromString(String value) {
        CredentialType[] items = CredentialType.values();
        for (CredentialType item : items) {
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
