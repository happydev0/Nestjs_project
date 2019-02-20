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
 * reference model.
 */
public class NodeReferenceApiModel {
    /**
     * Reference Type identifier.
     */
    @JsonProperty(value = "typeId")
    private String typeId;

    /**
     * Browse name of reference.
     */
    @JsonProperty(value = "browseName")
    private String browseName;

    /**
     * Browse direction of reference. Possible values include: 'Forward',
     * 'Backward', 'Both'.
     */
    @JsonProperty(value = "direction")
    private BrowseDirection direction;

    /**
     * Display name of reference.
     */
    @JsonProperty(value = "displayName")
    private String displayName;

    /**
     * Target node.
     */
    @JsonProperty(value = "target", required = true)
    private NodeApiModel target;

    /**
     * Optional type definition of the reference.
     */
    @JsonProperty(value = "typeDefinition")
    private String typeDefinition;

    /**
     * Get reference Type identifier.
     *
     * @return the typeId value
     */
    public String typeId() {
        return this.typeId;
    }

    /**
     * Set reference Type identifier.
     *
     * @param typeId the typeId value to set
     * @return the NodeReferenceApiModel object itself.
     */
    public NodeReferenceApiModel withTypeId(String typeId) {
        this.typeId = typeId;
        return this;
    }

    /**
     * Get browse name of reference.
     *
     * @return the browseName value
     */
    public String browseName() {
        return this.browseName;
    }

    /**
     * Set browse name of reference.
     *
     * @param browseName the browseName value to set
     * @return the NodeReferenceApiModel object itself.
     */
    public NodeReferenceApiModel withBrowseName(String browseName) {
        this.browseName = browseName;
        return this;
    }

    /**
     * Get browse direction of reference. Possible values include: 'Forward', 'Backward', 'Both'.
     *
     * @return the direction value
     */
    public BrowseDirection direction() {
        return this.direction;
    }

    /**
     * Set browse direction of reference. Possible values include: 'Forward', 'Backward', 'Both'.
     *
     * @param direction the direction value to set
     * @return the NodeReferenceApiModel object itself.
     */
    public NodeReferenceApiModel withDirection(BrowseDirection direction) {
        this.direction = direction;
        return this;
    }

    /**
     * Get display name of reference.
     *
     * @return the displayName value
     */
    public String displayName() {
        return this.displayName;
    }

    /**
     * Set display name of reference.
     *
     * @param displayName the displayName value to set
     * @return the NodeReferenceApiModel object itself.
     */
    public NodeReferenceApiModel withDisplayName(String displayName) {
        this.displayName = displayName;
        return this;
    }

    /**
     * Get target node.
     *
     * @return the target value
     */
    public NodeApiModel target() {
        return this.target;
    }

    /**
     * Set target node.
     *
     * @param target the target value to set
     * @return the NodeReferenceApiModel object itself.
     */
    public NodeReferenceApiModel withTarget(NodeApiModel target) {
        this.target = target;
        return this;
    }

    /**
     * Get optional type definition of the reference.
     *
     * @return the typeDefinition value
     */
    public String typeDefinition() {
        return this.typeDefinition;
    }

    /**
     * Set optional type definition of the reference.
     *
     * @param typeDefinition the typeDefinition value to set
     * @return the NodeReferenceApiModel object itself.
     */
    public NodeReferenceApiModel withTypeDefinition(String typeDefinition) {
        this.typeDefinition = typeDefinition;
        return this;
    }

}
