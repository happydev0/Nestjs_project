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


class ValueReadRequestApiModel(Model):
    """Node value read request webservice api model.

    :param node_id: Node to read from (mandatory)
    :type node_id: str
    :param index_range: Index range to read, e.g. 1:2,0:1 for 2 slices
     out of a matrix or 0:1 for the first item in
     an array, string or bytestring.
     See 7.22 of part 4: NumericRange.
    :type index_range: str
    :param elevation: Optional User elevation
    :type elevation: ~azure-iiot-opc-twin.models.CredentialApiModel
    :param diagnostics: Optional diagnostics configuration
    :type diagnostics: ~azure-iiot-opc-twin.models.DiagnosticsApiModel
    """

    _validation = {
        'node_id': {'required': True},
    }

    _attribute_map = {
        'node_id': {'key': 'nodeId', 'type': 'str'},
        'index_range': {'key': 'indexRange', 'type': 'str'},
        'elevation': {'key': 'elevation', 'type': 'CredentialApiModel'},
        'diagnostics': {'key': 'diagnostics', 'type': 'DiagnosticsApiModel'},
    }

    def __init__(self, node_id, index_range=None, elevation=None, diagnostics=None):
        super(ValueReadRequestApiModel, self).__init__()
        self.node_id = node_id
        self.index_range = index_range
        self.elevation = elevation
        self.diagnostics = diagnostics
