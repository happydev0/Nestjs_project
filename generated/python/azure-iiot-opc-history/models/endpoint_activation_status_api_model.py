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


class EndpointActivationStatusApiModel(Model):
    """Endpoint Activation status model.

    :param id: Identifier of the endoint
    :type id: str
    :param activation_state: Activation state. Possible values include:
     'Deactivated', 'Activated', 'ActivatedAndConnected'
    :type activation_state: str or
     ~azure-iiot-opc-history.models.EndpointActivationState
    """

    _validation = {
        'id': {'required': True},
    }

    _attribute_map = {
        'id': {'key': 'id', 'type': 'str'},
        'activation_state': {'key': 'activationState', 'type': 'EndpointActivationState'},
    }

    def __init__(self, id, activation_state=None):
        super(EndpointActivationStatusApiModel, self).__init__()
        self.id = id
        self.activation_state = activation_state
