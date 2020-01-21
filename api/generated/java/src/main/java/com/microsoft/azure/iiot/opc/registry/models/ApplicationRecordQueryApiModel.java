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

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Query by id.
 */
public class ApplicationRecordQueryApiModel {
    /**
     * Starting record id.
     */
    @JsonProperty(value = "startingRecordId")
    private Integer startingRecordId;

    /**
     * Max records to return.
     */
    @JsonProperty(value = "maxRecordsToReturn")
    private Integer maxRecordsToReturn;

    /**
     * Application name.
     */
    @JsonProperty(value = "applicationName")
    private String applicationName;

    /**
     * Application uri.
     */
    @JsonProperty(value = "applicationUri")
    private String applicationUri;

    /**
     * Possible values include: 'Server', 'Client', 'ClientAndServer',
     * 'DiscoveryServer'.
     */
    @JsonProperty(value = "applicationType")
    private ApplicationType applicationType;

    /**
     * Product uri.
     */
    @JsonProperty(value = "productUri")
    private String productUri;

    /**
     * Server capabilities.
     */
    @JsonProperty(value = "serverCapabilities")
    private List<String> serverCapabilities;

    /**
     * Get starting record id.
     *
     * @return the startingRecordId value
     */
    public Integer startingRecordId() {
        return this.startingRecordId;
    }

    /**
     * Set starting record id.
     *
     * @param startingRecordId the startingRecordId value to set
     * @return the ApplicationRecordQueryApiModel object itself.
     */
    public ApplicationRecordQueryApiModel withStartingRecordId(Integer startingRecordId) {
        this.startingRecordId = startingRecordId;
        return this;
    }

    /**
     * Get max records to return.
     *
     * @return the maxRecordsToReturn value
     */
    public Integer maxRecordsToReturn() {
        return this.maxRecordsToReturn;
    }

    /**
     * Set max records to return.
     *
     * @param maxRecordsToReturn the maxRecordsToReturn value to set
     * @return the ApplicationRecordQueryApiModel object itself.
     */
    public ApplicationRecordQueryApiModel withMaxRecordsToReturn(Integer maxRecordsToReturn) {
        this.maxRecordsToReturn = maxRecordsToReturn;
        return this;
    }

    /**
     * Get application name.
     *
     * @return the applicationName value
     */
    public String applicationName() {
        return this.applicationName;
    }

    /**
     * Set application name.
     *
     * @param applicationName the applicationName value to set
     * @return the ApplicationRecordQueryApiModel object itself.
     */
    public ApplicationRecordQueryApiModel withApplicationName(String applicationName) {
        this.applicationName = applicationName;
        return this;
    }

    /**
     * Get application uri.
     *
     * @return the applicationUri value
     */
    public String applicationUri() {
        return this.applicationUri;
    }

    /**
     * Set application uri.
     *
     * @param applicationUri the applicationUri value to set
     * @return the ApplicationRecordQueryApiModel object itself.
     */
    public ApplicationRecordQueryApiModel withApplicationUri(String applicationUri) {
        this.applicationUri = applicationUri;
        return this;
    }

    /**
     * Get possible values include: 'Server', 'Client', 'ClientAndServer', 'DiscoveryServer'.
     *
     * @return the applicationType value
     */
    public ApplicationType applicationType() {
        return this.applicationType;
    }

    /**
     * Set possible values include: 'Server', 'Client', 'ClientAndServer', 'DiscoveryServer'.
     *
     * @param applicationType the applicationType value to set
     * @return the ApplicationRecordQueryApiModel object itself.
     */
    public ApplicationRecordQueryApiModel withApplicationType(ApplicationType applicationType) {
        this.applicationType = applicationType;
        return this;
    }

    /**
     * Get product uri.
     *
     * @return the productUri value
     */
    public String productUri() {
        return this.productUri;
    }

    /**
     * Set product uri.
     *
     * @param productUri the productUri value to set
     * @return the ApplicationRecordQueryApiModel object itself.
     */
    public ApplicationRecordQueryApiModel withProductUri(String productUri) {
        this.productUri = productUri;
        return this;
    }

    /**
     * Get server capabilities.
     *
     * @return the serverCapabilities value
     */
    public List<String> serverCapabilities() {
        return this.serverCapabilities;
    }

    /**
     * Set server capabilities.
     *
     * @param serverCapabilities the serverCapabilities value to set
     * @return the ApplicationRecordQueryApiModel object itself.
     */
    public ApplicationRecordQueryApiModel withServerCapabilities(List<String> serverCapabilities) {
        this.serverCapabilities = serverCapabilities;
        return this;
    }

}
