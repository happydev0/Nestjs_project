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

from msrest.service_client import ServiceClient
from msrest import Configuration, Serializer, Deserializer
from .version import VERSION
from msrest.pipeline import ClientRawResponse
from msrest.exceptions import HttpOperationError
from . import models


class AzureOpcTwinClientConfiguration(Configuration):
    """Configuration for AzureOpcTwinClient
    Note that all parameters used to create this instance are saved as instance
    attributes.

    :param credentials: Subscription credentials which uniquely identify
     client subscription.
    :type credentials: None
    :param str base_url: Service URL
    """

    def __init__(
            self, credentials, base_url=None):

        if credentials is None:
            raise ValueError("Parameter 'credentials' must not be None.")
        if not base_url:
            base_url = '/twin'

        super(AzureOpcTwinClientConfiguration, self).__init__(base_url)

        self.add_user_agent('azureopctwinclient/{}'.format(VERSION))

        self.credentials = credentials


class AzureOpcTwinClient(object):
    """Azure Industrial IoT OPC UA Twin Service

    :ivar config: Configuration for client.
    :vartype config: AzureOpcTwinClientConfiguration

    :param credentials: Subscription credentials which uniquely identify
     client subscription.
    :type credentials: None
    :param str base_url: Service URL
    """

    def __init__(
            self, credentials, base_url=None):

        self.config = AzureOpcTwinClientConfiguration(credentials, base_url)
        self._client = ServiceClient(self.config.credentials, self.config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self.api_version = 'v2'
        self._serialize = Serializer(client_models)
        self._deserialize = Deserializer(client_models)


    def get_set_of_unique_nodes(
            self, endpoint_id, node_id=None, custom_headers=None, raw=False, **operation_config):
        """Browse set of unique target nodes.

        Browse the set of unique hierarchically referenced target nodes on the
        endpoint.
        The endpoint must be activated and connected and the module client
        and server must trust each other.
        The root node id to browse from can be provided as part of the query
        parameters.
        If it is not provided, the RootFolder node is browsed. Note that this
        is the same as the POST method with the model containing the node id
        and the targetNodesOnly flag set to true.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param node_id: The node to browse or omit to browse the root node
         (i=84)
        :type node_id: str
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: BrowseResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.BrowseResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.get_set_of_unique_nodes.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}
        if node_id is not None:
            query_parameters['nodeId'] = self._serialize.query("node_id", node_id, 'str')

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('BrowseResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    get_set_of_unique_nodes.metadata = {'url': '/v2/browse/{endpointId}'}

    def browse(
            self, endpoint_id, request, custom_headers=None, raw=False, **operation_config):
        """Browse node references.

        Browse a node on the specified endpoint.
        The endpoint must be activated and connected and the module client
        and server must trust each other.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param request: The browse request
        :type request: ~azure-iiot-opc-twin.models.BrowseRequestApiModel
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: BrowseResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.BrowseResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.browse.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json-patch+json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        body_content = self._serialize.body(request, 'BrowseRequestApiModel')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('BrowseResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    browse.metadata = {'url': '/v2/browse/{endpointId}'}

    def get_next_set_of_unique_nodes(
            self, endpoint_id, continuation_token, custom_headers=None, raw=False, **operation_config):
        """Browse next set of unique target nodes.

        Browse the next set of unique hierarchically referenced target nodes on
        the
        endpoint.
        The endpoint must be activated and connected and the module client
        and server must trust each other.
        Note that this is the same as the POST method with the model containing
        the continuation token and the targetNodesOnly flag set to true.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param continuation_token: Continuation token from GetSetOfUniqueNodes
         operation
        :type continuation_token: str
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: BrowseNextResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.BrowseNextResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.get_next_set_of_unique_nodes.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}
        query_parameters['continuationToken'] = self._serialize.query("continuation_token", continuation_token, 'str')

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('BrowseNextResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    get_next_set_of_unique_nodes.metadata = {'url': '/v2/browse/{endpointId}/next'}

    def browse_next(
            self, endpoint_id, request, custom_headers=None, raw=False, **operation_config):
        """Browse next set of references.

        Browse next set of references on the endpoint.
        The endpoint must be activated and connected and the module client
        and server must trust each other.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param request: The request body with continuation token.
        :type request: ~azure-iiot-opc-twin.models.BrowseNextRequestApiModel
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: BrowseNextResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.BrowseNextResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.browse_next.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json-patch+json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        body_content = self._serialize.body(request, 'BrowseNextRequestApiModel')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('BrowseNextResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    browse_next.metadata = {'url': '/v2/browse/{endpointId}/next'}

    def browse_using_path(
            self, endpoint_id, request, custom_headers=None, raw=False, **operation_config):
        """Browse using a browse path.

        Browse using a path from the specified node id.
        This call uses TranslateBrowsePathsToNodeIds service under the hood.
        The endpoint must be activated and connected and the module client
        and server must trust each other.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param request: The browse path request
        :type request: ~azure-iiot-opc-twin.models.BrowsePathRequestApiModel
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: BrowsePathResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.BrowsePathResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.browse_using_path.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json-patch+json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        body_content = self._serialize.body(request, 'BrowsePathRequestApiModel')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('BrowsePathResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    browse_using_path.metadata = {'url': '/v2/browse/{endpointId}/path'}

    def get_call_metadata(
            self, endpoint_id, request, custom_headers=None, raw=False, **operation_config):
        """Get method meta data.

        Return method meta data to support a user interface displaying forms to
        input and output arguments.
        The endpoint must be activated and connected and the module client
        and server must trust each other.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param request: The method metadata request
        :type request:
         ~azure-iiot-opc-twin.models.MethodMetadataRequestApiModel
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: MethodMetadataResponseApiModel or ClientRawResponse if
         raw=true
        :rtype: ~azure-iiot-opc-twin.models.MethodMetadataResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.get_call_metadata.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json-patch+json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        body_content = self._serialize.body(request, 'MethodMetadataRequestApiModel')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('MethodMetadataResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    get_call_metadata.metadata = {'url': '/v2/call/{endpointId}/metadata'}

    def call_method(
            self, endpoint_id, request, custom_headers=None, raw=False, **operation_config):
        """Call a method.

        Invoke method node with specified input arguments.
        The endpoint must be activated and connected and the module client
        and server must trust each other.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param request: The method call request
        :type request: ~azure-iiot-opc-twin.models.MethodCallRequestApiModel
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: MethodCallResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.MethodCallResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.call_method.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json-patch+json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        body_content = self._serialize.body(request, 'MethodCallRequestApiModel')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('MethodCallResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    call_method.metadata = {'url': '/v2/call/{endpointId}'}

    def get_value(
            self, endpoint_id, node_id, custom_headers=None, raw=False, **operation_config):
        """Get variable value.

        Get a variable node's value using its node id.
        The endpoint must be activated and connected and the module client
        and server must trust each other.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param node_id: The node to read
        :type node_id: str
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: ValueReadResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.ValueReadResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.get_value.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}
        query_parameters['nodeId'] = self._serialize.query("node_id", node_id, 'str')

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('ValueReadResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    get_value.metadata = {'url': '/v2/read/{endpointId}'}

    def read_value(
            self, endpoint_id, request, custom_headers=None, raw=False, **operation_config):
        """Read variable value.

        Read a variable node's value.
        The endpoint must be activated and connected and the module client
        and server must trust each other.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param request: The read value request
        :type request: ~azure-iiot-opc-twin.models.ValueReadRequestApiModel
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: ValueReadResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.ValueReadResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.read_value.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json-patch+json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        body_content = self._serialize.body(request, 'ValueReadRequestApiModel')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('ValueReadResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    read_value.metadata = {'url': '/v2/read/{endpointId}'}

    def read_attributes(
            self, endpoint_id, request, custom_headers=None, raw=False, **operation_config):
        """Read node attributes.

        Read attributes of a node.
        The endpoint must be activated and connected and the module client
        and server must trust each other.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param request: The read request
        :type request: ~azure-iiot-opc-twin.models.ReadRequestApiModel
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: ReadResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.ReadResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.read_attributes.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json-patch+json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        body_content = self._serialize.body(request, 'ReadRequestApiModel')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('ReadResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    read_attributes.metadata = {'url': '/v2/read/{endpointId}/attributes'}

    def get_status(
            self, custom_headers=None, raw=False, **operation_config):
        """Return the service status in the form of the service status
        api model.

        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: StatusResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.StatusResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.get_status.metadata['url']

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('StatusResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    get_status.metadata = {'url': '/v2/status'}

    def write_value(
            self, endpoint_id, request, custom_headers=None, raw=False, **operation_config):
        """Write variable value.

        Write variable node's value.
        The endpoint must be activated and connected and the module client
        and server must trust each other.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param request: The write value request
        :type request: ~azure-iiot-opc-twin.models.ValueWriteRequestApiModel
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: ValueWriteResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.ValueWriteResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.write_value.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json-patch+json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        body_content = self._serialize.body(request, 'ValueWriteRequestApiModel')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('ValueWriteResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    write_value.metadata = {'url': '/v2/write/{endpointId}'}

    def write_attributes(
            self, endpoint_id, request, custom_headers=None, raw=False, **operation_config):
        """Write node attributes.

        Write any attribute of a node.
        The endpoint must be activated and connected and the module client
        and server must trust each other.

        :param endpoint_id: The identifier of the activated endpoint.
        :type endpoint_id: str
        :param request: The batch write request
        :type request: ~azure-iiot-opc-twin.models.WriteRequestApiModel
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :return: WriteResponseApiModel or ClientRawResponse if raw=true
        :rtype: ~azure-iiot-opc-twin.models.WriteResponseApiModel or
         ~msrest.pipeline.ClientRawResponse
        :raises:
         :class:`HttpOperationError<msrest.exceptions.HttpOperationError>`
        """
        # Construct URL
        url = self.write_attributes.metadata['url']
        path_format_arguments = {
            'endpointId': self._serialize.url("endpoint_id", endpoint_id, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json-patch+json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        body_content = self._serialize.body(request, 'WriteRequestApiModel')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, stream=False, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('WriteResponseApiModel', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
    write_attributes.metadata = {'url': '/v2/write/{endpointId}/attributes'}
