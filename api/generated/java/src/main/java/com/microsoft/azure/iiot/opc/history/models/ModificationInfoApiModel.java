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

import org.joda.time.DateTime;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Modification information.
 */
public class ModificationInfoApiModel {
    /**
     * Modification time.
     */
    @JsonProperty(value = "modificationTime")
    private DateTime modificationTime;

    /**
     * Operation. Possible values include: 'Insert', 'Replace', 'Update',
     * 'Delete'.
     */
    @JsonProperty(value = "updateType")
    private HistoryUpdateOperation updateType;

    /**
     * User who made the change.
     */
    @JsonProperty(value = "userName")
    private String userName;

    /**
     * Get modification time.
     *
     * @return the modificationTime value
     */
    public DateTime modificationTime() {
        return this.modificationTime;
    }

    /**
     * Set modification time.
     *
     * @param modificationTime the modificationTime value to set
     * @return the ModificationInfoApiModel object itself.
     */
    public ModificationInfoApiModel withModificationTime(DateTime modificationTime) {
        this.modificationTime = modificationTime;
        return this;
    }

    /**
     * Get operation. Possible values include: 'Insert', 'Replace', 'Update', 'Delete'.
     *
     * @return the updateType value
     */
    public HistoryUpdateOperation updateType() {
        return this.updateType;
    }

    /**
     * Set operation. Possible values include: 'Insert', 'Replace', 'Update', 'Delete'.
     *
     * @param updateType the updateType value to set
     * @return the ModificationInfoApiModel object itself.
     */
    public ModificationInfoApiModel withUpdateType(HistoryUpdateOperation updateType) {
        this.updateType = updateType;
        return this;
    }

    /**
     * Get user who made the change.
     *
     * @return the userName value
     */
    public String userName() {
        return this.userName;
    }

    /**
     * Set user who made the change.
     *
     * @param userName the userName value to set
     * @return the ModificationInfoApiModel object itself.
     */
    public ModificationInfoApiModel withUserName(String userName) {
        this.userName = userName;
        return this;
    }

}
