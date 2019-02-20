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
 * Application information.
 */
public class ApplicationRegistrationRequestApiModel {
    /**
     * Unique application uri.
     */
    @JsonProperty(value = "applicationUri", required = true)
    private String applicationUri;

    /**
     * Type of application. Possible values include: 'Server', 'Client',
     * 'ClientAndServer'.
     */
    @JsonProperty(value = "applicationType")
    private ApplicationType applicationType;

    /**
     * Product uri of the application.
     */
    @JsonProperty(value = "productUri")
    private String productUri;

    /**
     * Name of the server or client.
     */
    @JsonProperty(value = "applicationName")
    private String applicationName;

    /**
     * Locale of name.
     */
    @JsonProperty(value = "locale")
    private String locale;

    /**
     * The OPC UA defined capabilities of the server.
     */
    @JsonProperty(value = "capabilities")
    private List<String> capabilities;

    /**
     * Discovery urls of the server.
     */
    @JsonProperty(value = "discoveryUrls")
    private List<String> discoveryUrls;

    /**
     * The discovery profile uri of the server.
     */
    @JsonProperty(value = "discoveryProfileUri")
    private String discoveryProfileUri;

    /**
     * Get unique application uri.
     *
     * @return the applicationUri value
     */
    public String applicationUri() {
        return this.applicationUri;
    }

    /**
     * Set unique application uri.
     *
     * @param applicationUri the applicationUri value to set
     * @return the ApplicationRegistrationRequestApiModel object itself.
     */
    public ApplicationRegistrationRequestApiModel withApplicationUri(String applicationUri) {
        this.applicationUri = applicationUri;
        return this;
    }

    /**
     * Get type of application. Possible values include: 'Server', 'Client', 'ClientAndServer'.
     *
     * @return the applicationType value
     */
    public ApplicationType applicationType() {
        return this.applicationType;
    }

    /**
     * Set type of application. Possible values include: 'Server', 'Client', 'ClientAndServer'.
     *
     * @param applicationType the applicationType value to set
     * @return the ApplicationRegistrationRequestApiModel object itself.
     */
    public ApplicationRegistrationRequestApiModel withApplicationType(ApplicationType applicationType) {
        this.applicationType = applicationType;
        return this;
    }

    /**
     * Get product uri of the application.
     *
     * @return the productUri value
     */
    public String productUri() {
        return this.productUri;
    }

    /**
     * Set product uri of the application.
     *
     * @param productUri the productUri value to set
     * @return the ApplicationRegistrationRequestApiModel object itself.
     */
    public ApplicationRegistrationRequestApiModel withProductUri(String productUri) {
        this.productUri = productUri;
        return this;
    }

    /**
     * Get name of the server or client.
     *
     * @return the applicationName value
     */
    public String applicationName() {
        return this.applicationName;
    }

    /**
     * Set name of the server or client.
     *
     * @param applicationName the applicationName value to set
     * @return the ApplicationRegistrationRequestApiModel object itself.
     */
    public ApplicationRegistrationRequestApiModel withApplicationName(String applicationName) {
        this.applicationName = applicationName;
        return this;
    }

    /**
     * Get locale of name.
     *
     * @return the locale value
     */
    public String locale() {
        return this.locale;
    }

    /**
     * Set locale of name.
     *
     * @param locale the locale value to set
     * @return the ApplicationRegistrationRequestApiModel object itself.
     */
    public ApplicationRegistrationRequestApiModel withLocale(String locale) {
        this.locale = locale;
        return this;
    }

    /**
     * Get the OPC UA defined capabilities of the server.
     *
     * @return the capabilities value
     */
    public List<String> capabilities() {
        return this.capabilities;
    }

    /**
     * Set the OPC UA defined capabilities of the server.
     *
     * @param capabilities the capabilities value to set
     * @return the ApplicationRegistrationRequestApiModel object itself.
     */
    public ApplicationRegistrationRequestApiModel withCapabilities(List<String> capabilities) {
        this.capabilities = capabilities;
        return this;
    }

    /**
     * Get discovery urls of the server.
     *
     * @return the discoveryUrls value
     */
    public List<String> discoveryUrls() {
        return this.discoveryUrls;
    }

    /**
     * Set discovery urls of the server.
     *
     * @param discoveryUrls the discoveryUrls value to set
     * @return the ApplicationRegistrationRequestApiModel object itself.
     */
    public ApplicationRegistrationRequestApiModel withDiscoveryUrls(List<String> discoveryUrls) {
        this.discoveryUrls = discoveryUrls;
        return this;
    }

    /**
     * Get the discovery profile uri of the server.
     *
     * @return the discoveryProfileUri value
     */
    public String discoveryProfileUri() {
        return this.discoveryProfileUri;
    }

    /**
     * Set the discovery profile uri of the server.
     *
     * @param discoveryProfileUri the discoveryProfileUri value to set
     * @return the ApplicationRegistrationRequestApiModel object itself.
     */
    public ApplicationRegistrationRequestApiModel withDiscoveryProfileUri(String discoveryProfileUri) {
        this.discoveryProfileUri = discoveryProfileUri;
        return this;
    }

}
