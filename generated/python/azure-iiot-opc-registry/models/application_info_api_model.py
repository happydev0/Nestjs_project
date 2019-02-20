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


class ApplicationInfoApiModel(Model):
    """Application model.

    :param application_id: Unique application id
    :type application_id: str
    :param application_type: Type of application. Possible values include:
     'Server', 'Client', 'ClientAndServer'
    :type application_type: str or
     ~azure-iiot-opc-registry.models.ApplicationType
    :param application_uri: Unique application uri
    :type application_uri: str
    :param product_uri: Product uri
    :type product_uri: str
    :param application_name: Name of server
    :type application_name: str
    :param locale: Locale of name - defaults to "en"
    :type locale: str
    :param certificate: Application public cert
    :type certificate: bytearray
    :param capabilities: The capabilities advertised by the server.
    :type capabilities: list[str]
    :param discovery_urls: Discovery urls of the server
    :type discovery_urls: list[str]
    :param discovery_profile_uri: Discovery profile uri
    :type discovery_profile_uri: str
    :param host_addresses: Host addresses of server application or null
    :type host_addresses: list[str]
    :param site_id: Site of the application
    :type site_id: str
    :param supervisor_id: Supervisor having registered the application
    :type supervisor_id: str
    :param not_seen_since: Last time application was seen
    :type not_seen_since: datetime
    """

    _validation = {
        'capabilities': {'unique': True},
        'discovery_urls': {'unique': True},
        'host_addresses': {'unique': True},
    }

    _attribute_map = {
        'application_id': {'key': 'applicationId', 'type': 'str'},
        'application_type': {'key': 'applicationType', 'type': 'ApplicationType'},
        'application_uri': {'key': 'applicationUri', 'type': 'str'},
        'product_uri': {'key': 'productUri', 'type': 'str'},
        'application_name': {'key': 'applicationName', 'type': 'str'},
        'locale': {'key': 'locale', 'type': 'str'},
        'certificate': {'key': 'certificate', 'type': 'bytearray'},
        'capabilities': {'key': 'capabilities', 'type': '[str]'},
        'discovery_urls': {'key': 'discoveryUrls', 'type': '[str]'},
        'discovery_profile_uri': {'key': 'discoveryProfileUri', 'type': 'str'},
        'host_addresses': {'key': 'hostAddresses', 'type': '[str]'},
        'site_id': {'key': 'siteId', 'type': 'str'},
        'supervisor_id': {'key': 'supervisorId', 'type': 'str'},
        'not_seen_since': {'key': 'notSeenSince', 'type': 'iso-8601'},
    }

    def __init__(self, application_id=None, application_type=None, application_uri=None, product_uri=None, application_name=None, locale=None, certificate=None, capabilities=None, discovery_urls=None, discovery_profile_uri=None, host_addresses=None, site_id=None, supervisor_id=None, not_seen_since=None):
        super(ApplicationInfoApiModel, self).__init__()
        self.application_id = application_id
        self.application_type = application_type
        self.application_uri = application_uri
        self.product_uri = product_uri
        self.application_name = application_name
        self.locale = locale
        self.certificate = certificate
        self.capabilities = capabilities
        self.discovery_urls = discovery_urls
        self.discovery_profile_uri = discovery_profile_uri
        self.host_addresses = host_addresses
        self.site_id = site_id
        self.supervisor_id = supervisor_id
        self.not_seen_since = not_seen_since
