# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 2.3.33.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class ApplicationRegistrationApiModel(Model):
    """Application with list of endpoints.

    :param application: Application information
    :type application: ~azure-iiot-opc-registry.models.ApplicationInfoApiModel
    :param endpoints: List of endpoint twins
    :type endpoints:
     list[~azure-iiot-opc-registry.models.EndpointRegistrationApiModel]
    :param security_assessment: Application security assessment. Possible
     values include: 'Unknown', 'Low', 'Medium', 'High'
    :type security_assessment: str or
     ~azure-iiot-opc-registry.models.SecurityAssessment
    """

    _validation = {
        'application': {'required': True},
    }

    _attribute_map = {
        'application': {'key': 'application', 'type': 'ApplicationInfoApiModel'},
        'endpoints': {'key': 'endpoints', 'type': '[EndpointRegistrationApiModel]'},
        'security_assessment': {'key': 'securityAssessment', 'type': 'SecurityAssessment'},
    }

    def __init__(self, application, endpoints=None, security_assessment=None):
        super(ApplicationRegistrationApiModel, self).__init__()
        self.application = application
        self.endpoints = endpoints
        self.security_assessment = security_assessment
