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
 * Node value read request webservice api model.
 */
public class ValueReadRequestApiModel {
    /**
     * Node to read from (mandatory).
     */
    @JsonProperty(value = "nodeId", required = true)
    private String nodeId;

    /**
     * An optional path from NodeId instance to
     * the actual node.
     */
    @JsonProperty(value = "browsePath")
    private List<String> browsePath;

    /**
     * Index range to read, e.g. 1:2,0:1 for 2 slices
     * out of a matrix or 0:1 for the first item in
     * an array, string or bytestring.
     * See 7.22 of part 4: NumericRange.
     */
    @JsonProperty(value = "indexRange")
    private String indexRange;

    /**
     * Optional request header.
     */
    @JsonProperty(value = "header")
    private RequestHeaderApiModel headerProperty;

    /**
     * Get node to read from (mandatory).
     *
     * @return the nodeId value
     */
    public String nodeId() {
        return this.nodeId;
    }

    /**
     * Set node to read from (mandatory).
     *
     * @param nodeId the nodeId value to set
     * @return the ValueReadRequestApiModel object itself.
     */
    public ValueReadRequestApiModel withNodeId(String nodeId) {
        this.nodeId = nodeId;
        return this;
    }

    /**
     * Get an optional path from NodeId instance to
     the actual node.
     *
     * @return the browsePath value
     */
    public List<String> browsePath() {
        return this.browsePath;
    }

    /**
     * Set an optional path from NodeId instance to
     the actual node.
     *
     * @param browsePath the browsePath value to set
     * @return the ValueReadRequestApiModel object itself.
     */
    public ValueReadRequestApiModel withBrowsePath(List<String> browsePath) {
        this.browsePath = browsePath;
        return this;
    }

    /**
     * Get index range to read, e.g. 1:2,0:1 for 2 slices
     out of a matrix or 0:1 for the first item in
     an array, string or bytestring.
     See 7.22 of part 4: NumericRange.
     *
     * @return the indexRange value
     */
    public String indexRange() {
        return this.indexRange;
    }

    /**
     * Set index range to read, e.g. 1:2,0:1 for 2 slices
     out of a matrix or 0:1 for the first item in
     an array, string or bytestring.
     See 7.22 of part 4: NumericRange.
     *
     * @param indexRange the indexRange value to set
     * @return the ValueReadRequestApiModel object itself.
     */
    public ValueReadRequestApiModel withIndexRange(String indexRange) {
        this.indexRange = indexRange;
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
     * @return the ValueReadRequestApiModel object itself.
     */
    public ValueReadRequestApiModel withHeaderProperty(RequestHeaderApiModel headerProperty) {
        this.headerProperty = headerProperty;
        return this;
    }

}
