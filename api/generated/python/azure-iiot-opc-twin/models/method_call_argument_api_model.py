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


class MethodCallArgumentApiModel(Model):
    """method arg model.

    :param value: Initial value or value to use
    :type value: object
    :param data_type: Data type Id of the value (from meta data)
    :type data_type: str
    """

    _attribute_map = {
        'value': {'key': 'value', 'type': 'object'},
        'data_type': {'key': 'dataType', 'type': 'str'},
    }

    def __init__(self, value=None, data_type=None):
        super(MethodCallArgumentApiModel, self).__init__()
        self.value = value
        self.data_type = data_type
