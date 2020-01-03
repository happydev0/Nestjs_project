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
 * Discovery configuration.
 */
public class DiscoveryConfigApiModel {
    /**
     * Address ranges to scan (null == all wired nics).
     */
    @JsonProperty(value = "addressRangesToScan")
    private String addressRangesToScan;

    /**
     * Network probe timeout.
     */
    @JsonProperty(value = "networkProbeTimeoutMs")
    private Integer networkProbeTimeoutMs;

    /**
     * Max network probes that should ever run.
     */
    @JsonProperty(value = "maxNetworkProbes")
    private Integer maxNetworkProbes;

    /**
     * Port ranges to scan (null == all unassigned).
     */
    @JsonProperty(value = "portRangesToScan")
    private String portRangesToScan;

    /**
     * Port probe timeout.
     */
    @JsonProperty(value = "portProbeTimeoutMs")
    private Integer portProbeTimeoutMs;

    /**
     * Max port probes that should ever run.
     */
    @JsonProperty(value = "maxPortProbes")
    private Integer maxPortProbes;

    /**
     * Probes that must always be there as percent of max.
     */
    @JsonProperty(value = "minPortProbesPercent")
    private Integer minPortProbesPercent;

    /**
     * Delay time between discovery sweeps in seconds.
     */
    @JsonProperty(value = "idleTimeBetweenScansSec")
    private Integer idleTimeBetweenScansSec;

    /**
     * List of preset discovery urls to use.
     */
    @JsonProperty(value = "discoveryUrls")
    private List<String> discoveryUrls;

    /**
     * List of locales to filter with during discovery.
     */
    @JsonProperty(value = "locales")
    private List<String> locales;

    /**
     * Activate all twins with this filter during onboarding.
     */
    @JsonProperty(value = "activationFilter")
    private EndpointActivationFilterApiModel activationFilter;

    /**
     * Get address ranges to scan (null == all wired nics).
     *
     * @return the addressRangesToScan value
     */
    public String addressRangesToScan() {
        return this.addressRangesToScan;
    }

    /**
     * Set address ranges to scan (null == all wired nics).
     *
     * @param addressRangesToScan the addressRangesToScan value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withAddressRangesToScan(String addressRangesToScan) {
        this.addressRangesToScan = addressRangesToScan;
        return this;
    }

    /**
     * Get network probe timeout.
     *
     * @return the networkProbeTimeoutMs value
     */
    public Integer networkProbeTimeoutMs() {
        return this.networkProbeTimeoutMs;
    }

    /**
     * Set network probe timeout.
     *
     * @param networkProbeTimeoutMs the networkProbeTimeoutMs value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withNetworkProbeTimeoutMs(Integer networkProbeTimeoutMs) {
        this.networkProbeTimeoutMs = networkProbeTimeoutMs;
        return this;
    }

    /**
     * Get max network probes that should ever run.
     *
     * @return the maxNetworkProbes value
     */
    public Integer maxNetworkProbes() {
        return this.maxNetworkProbes;
    }

    /**
     * Set max network probes that should ever run.
     *
     * @param maxNetworkProbes the maxNetworkProbes value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withMaxNetworkProbes(Integer maxNetworkProbes) {
        this.maxNetworkProbes = maxNetworkProbes;
        return this;
    }

    /**
     * Get port ranges to scan (null == all unassigned).
     *
     * @return the portRangesToScan value
     */
    public String portRangesToScan() {
        return this.portRangesToScan;
    }

    /**
     * Set port ranges to scan (null == all unassigned).
     *
     * @param portRangesToScan the portRangesToScan value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withPortRangesToScan(String portRangesToScan) {
        this.portRangesToScan = portRangesToScan;
        return this;
    }

    /**
     * Get port probe timeout.
     *
     * @return the portProbeTimeoutMs value
     */
    public Integer portProbeTimeoutMs() {
        return this.portProbeTimeoutMs;
    }

    /**
     * Set port probe timeout.
     *
     * @param portProbeTimeoutMs the portProbeTimeoutMs value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withPortProbeTimeoutMs(Integer portProbeTimeoutMs) {
        this.portProbeTimeoutMs = portProbeTimeoutMs;
        return this;
    }

    /**
     * Get max port probes that should ever run.
     *
     * @return the maxPortProbes value
     */
    public Integer maxPortProbes() {
        return this.maxPortProbes;
    }

    /**
     * Set max port probes that should ever run.
     *
     * @param maxPortProbes the maxPortProbes value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withMaxPortProbes(Integer maxPortProbes) {
        this.maxPortProbes = maxPortProbes;
        return this;
    }

    /**
     * Get probes that must always be there as percent of max.
     *
     * @return the minPortProbesPercent value
     */
    public Integer minPortProbesPercent() {
        return this.minPortProbesPercent;
    }

    /**
     * Set probes that must always be there as percent of max.
     *
     * @param minPortProbesPercent the minPortProbesPercent value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withMinPortProbesPercent(Integer minPortProbesPercent) {
        this.minPortProbesPercent = minPortProbesPercent;
        return this;
    }

    /**
     * Get delay time between discovery sweeps in seconds.
     *
     * @return the idleTimeBetweenScansSec value
     */
    public Integer idleTimeBetweenScansSec() {
        return this.idleTimeBetweenScansSec;
    }

    /**
     * Set delay time between discovery sweeps in seconds.
     *
     * @param idleTimeBetweenScansSec the idleTimeBetweenScansSec value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withIdleTimeBetweenScansSec(Integer idleTimeBetweenScansSec) {
        this.idleTimeBetweenScansSec = idleTimeBetweenScansSec;
        return this;
    }

    /**
     * Get list of preset discovery urls to use.
     *
     * @return the discoveryUrls value
     */
    public List<String> discoveryUrls() {
        return this.discoveryUrls;
    }

    /**
     * Set list of preset discovery urls to use.
     *
     * @param discoveryUrls the discoveryUrls value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withDiscoveryUrls(List<String> discoveryUrls) {
        this.discoveryUrls = discoveryUrls;
        return this;
    }

    /**
     * Get list of locales to filter with during discovery.
     *
     * @return the locales value
     */
    public List<String> locales() {
        return this.locales;
    }

    /**
     * Set list of locales to filter with during discovery.
     *
     * @param locales the locales value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withLocales(List<String> locales) {
        this.locales = locales;
        return this;
    }

    /**
     * Get activate all twins with this filter during onboarding.
     *
     * @return the activationFilter value
     */
    public EndpointActivationFilterApiModel activationFilter() {
        return this.activationFilter;
    }

    /**
     * Set activate all twins with this filter during onboarding.
     *
     * @param activationFilter the activationFilter value to set
     * @return the DiscoveryConfigApiModel object itself.
     */
    public DiscoveryConfigApiModel withActivationFilter(EndpointActivationFilterApiModel activationFilter) {
        this.activationFilter = activationFilter;
        return this;
    }

}
