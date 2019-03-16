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
 * Endpoint Activation Filter model.
 */
public class EndpointActivationFilterApiModel {
    /**
     * Certificate trust list identifiers to use for
     * activation, if null, all certificates are
     * trusted.  If empty list, no certificates are
     * trusted which is equal to no filter.
     */
    @JsonProperty(value = "trustLists")
    private List<String> trustLists;

    /**
     * Endpoint security policies to filter against.
     * If set to null, all policies are in scope.
     */
    @JsonProperty(value = "securityPolicies")
    private List<String> securityPolicies;

    /**
     * Security mode level to activate. If null,
     * then Microsoft.Azure.IIoT.OpcUa.Registry.Models.SecurityMode.Best is
     * assumed. Possible values include: 'Best', 'Sign', 'SignAndEncrypt',
     * 'None'.
     */
    @JsonProperty(value = "securityMode")
    private SecurityMode securityMode;

    /**
     * Get certificate trust list identifiers to use for
     activation, if null, all certificates are
     trusted.  If empty list, no certificates are
     trusted which is equal to no filter.
     *
     * @return the trustLists value
     */
    public List<String> trustLists() {
        return this.trustLists;
    }

    /**
     * Set certificate trust list identifiers to use for
     activation, if null, all certificates are
     trusted.  If empty list, no certificates are
     trusted which is equal to no filter.
     *
     * @param trustLists the trustLists value to set
     * @return the EndpointActivationFilterApiModel object itself.
     */
    public EndpointActivationFilterApiModel withTrustLists(List<String> trustLists) {
        this.trustLists = trustLists;
        return this;
    }

    /**
     * Get endpoint security policies to filter against.
     If set to null, all policies are in scope.
     *
     * @return the securityPolicies value
     */
    public List<String> securityPolicies() {
        return this.securityPolicies;
    }

    /**
     * Set endpoint security policies to filter against.
     If set to null, all policies are in scope.
     *
     * @param securityPolicies the securityPolicies value to set
     * @return the EndpointActivationFilterApiModel object itself.
     */
    public EndpointActivationFilterApiModel withSecurityPolicies(List<String> securityPolicies) {
        this.securityPolicies = securityPolicies;
        return this;
    }

    /**
     * Get security mode level to activate. If null,
     then Microsoft.Azure.IIoT.OpcUa.Registry.Models.SecurityMode.Best is assumed. Possible values include: 'Best', 'Sign', 'SignAndEncrypt', 'None'.
     *
     * @return the securityMode value
     */
    public SecurityMode securityMode() {
        return this.securityMode;
    }

    /**
     * Set security mode level to activate. If null,
     then Microsoft.Azure.IIoT.OpcUa.Registry.Models.SecurityMode.Best is assumed. Possible values include: 'Best', 'Sign', 'SignAndEncrypt', 'None'.
     *
     * @param securityMode the securityMode value to set
     * @return the EndpointActivationFilterApiModel object itself.
     */
    public EndpointActivationFilterApiModel withSecurityMode(SecurityMode securityMode) {
        this.securityMode = securityMode;
        return this;
    }

}
