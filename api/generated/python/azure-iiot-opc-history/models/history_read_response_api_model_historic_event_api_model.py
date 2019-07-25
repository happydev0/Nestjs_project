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


class HistoryReadResponseApiModelHistoricEventApiModel(Model):
    """History read results.

    :param history: History as json encoded extension object
    :type history: list[~azure-iiot-opc-history.models.HistoricEventApiModel]
    :param continuation_token: Continuation token if more results pending.
    :type continuation_token: str
    :param error_info: Service result in case of error
    :type error_info: ~azure-iiot-opc-history.models.ServiceResultApiModel
    """

    _attribute_map = {
        'history': {'key': 'history', 'type': '[HistoricEventApiModel]'},
        'continuation_token': {'key': 'continuationToken', 'type': 'str'},
        'error_info': {'key': 'errorInfo', 'type': 'ServiceResultApiModel'},
    }

    def __init__(self, history=None, continuation_token=None, error_info=None):
        super(HistoryReadResponseApiModelHistoricEventApiModel, self).__init__()
        self.history = history
        self.continuation_token = continuation_token
        self.error_info = error_info
