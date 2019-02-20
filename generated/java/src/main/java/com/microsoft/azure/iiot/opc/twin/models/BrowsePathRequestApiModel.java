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

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Browse nodes by path.
 */
public class BrowsePathRequestApiModel {
    /**
     * Node to browse.
     * (default: RootFolder).
     */
    @JsonProperty(value = "nodeId")
    private String nodeId;

    /**
     * The path elements of the path to browse from node.
     * (mandatory).
     */
    @JsonProperty(value = "pathElements", required = true)
    private List<String> pathElements;

    /**
     * Whether to read variable values on target nodes.
     * (default is false).
     */
    @JsonProperty(value = "readVariableValues")
    private Boolean readVariableValues;

    /**
     * Optional request header.
     */
    @JsonProperty(value = "header")
    private RequestHeaderApiModel headerProperty;

    /**
     * Get node to browse.
     (default: RootFolder).
     *
     * @return the nodeId value
     */
    public String nodeId() {
        return this.nodeId;
    }

    /**
     * Set node to browse.
     (default: RootFolder).
     *
     * @param nodeId the nodeId value to set
     * @return the BrowsePathRequestApiModel object itself.
     */
    public BrowsePathRequestApiModel withNodeId(String nodeId) {
        this.nodeId = nodeId;
        return this;
    }

    /**
     * Get the path elements of the path to browse from node.
     (mandatory).
     *
     * @return the pathElements value
     */
    public List<String> pathElements() {
        return this.pathElements;
    }

    /**
     * Set the path elements of the path to browse from node.
     (mandatory).
     *
     * @param pathElements the pathElements value to set
     * @return the BrowsePathRequestApiModel object itself.
     */
    public BrowsePathRequestApiModel withPathElements(List<String> pathElements) {
        this.pathElements = pathElements;
        return this;
    }

    /**
     * Get whether to read variable values on target nodes.
     (default is false).
     *
     * @return the readVariableValues value
     */
    public Boolean readVariableValues() {
        return this.readVariableValues;
    }

    /**
     * Set whether to read variable values on target nodes.
     (default is false).
     *
     * @param readVariableValues the readVariableValues value to set
     * @return the BrowsePathRequestApiModel object itself.
     */
    public BrowsePathRequestApiModel withReadVariableValues(Boolean readVariableValues) {
        this.readVariableValues = readVariableValues;
        return this;
    }

    /**
     * Get optional request header.
     *
     * @return the headerProperty value
     */
    public RequestHeaderApiModel headerProperty() {
        return this.headerProperty;
    }

    /**
     * Set optional request header.
     *
     * @param headerProperty the headerProperty value to set
     * @return the BrowsePathRequestApiModel object itself.
     */
    public BrowsePathRequestApiModel withHeaderProperty(RequestHeaderApiModel headerProperty) {
        this.headerProperty = headerProperty;
        return this;
    }

}
