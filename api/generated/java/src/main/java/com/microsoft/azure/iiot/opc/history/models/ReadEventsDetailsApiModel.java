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
 * Read event data.
 */
public class ReadEventsDetailsApiModel {
    /**
     * Start time to read from.
     */
    @JsonProperty(value = "startTime")
    private DateTime startTime;

    /**
     * End time to read to.
     */
    @JsonProperty(value = "endTime")
    private DateTime endTime;

    /**
     * Number of events to read.
     */
    @JsonProperty(value = "numEvents")
    private Integer numEvents;

    /**
     * The filter to use to select the event fields.
     */
    @JsonProperty(value = "filter")
    private Object filter;

    /**
     * Get start time to read from.
     *
     * @return the startTime value
     */
    public DateTime startTime() {
        return this.startTime;
    }

    /**
     * Set start time to read from.
     *
     * @param startTime the startTime value to set
     * @return the ReadEventsDetailsApiModel object itself.
     */
    public ReadEventsDetailsApiModel withStartTime(DateTime startTime) {
        this.startTime = startTime;
        return this;
    }

    /**
     * Get end time to read to.
     *
     * @return the endTime value
     */
    public DateTime endTime() {
        return this.endTime;
    }

    /**
     * Set end time to read to.
     *
     * @param endTime the endTime value to set
     * @return the ReadEventsDetailsApiModel object itself.
     */
    public ReadEventsDetailsApiModel withEndTime(DateTime endTime) {
        this.endTime = endTime;
        return this;
    }

    /**
     * Get number of events to read.
     *
     * @return the numEvents value
     */
    public Integer numEvents() {
        return this.numEvents;
    }

    /**
     * Set number of events to read.
     *
     * @param numEvents the numEvents value to set
     * @return the ReadEventsDetailsApiModel object itself.
     */
    public ReadEventsDetailsApiModel withNumEvents(Integer numEvents) {
        this.numEvents = numEvents;
        return this;
    }

    /**
     * Get the filter to use to select the event fields.
     *
     * @return the filter value
     */
    public Object filter() {
        return this.filter;
    }

    /**
     * Set the filter to use to select the event fields.
     *
     * @param filter the filter value to set
     * @return the ReadEventsDetailsApiModel object itself.
     */
    public ReadEventsDetailsApiModel withFilter(Object filter) {
        this.filter = filter;
        return this;
    }

}
