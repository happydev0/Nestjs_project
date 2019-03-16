# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

require 'uri'
require 'cgi'
require 'date'
require 'json'
require 'base64'
require 'erb'
require 'securerandom'
require 'time'
require 'timeliness'
require 'faraday'
require 'faraday-cookie_jar'
require 'concurrent'
require 'ms_rest'
require 'generated/swagger/module_definition'

module azure.iiot.opc.registry
  autoload :AzureOpcRegistryClient,                             'generated/swagger/azure_opc_registry_client.rb'

  module Models
    autoload :ApplicationRegistrationApiModel,                    'generated/swagger/models/application_registration_api_model.rb'
    autoload :ApplicationRegistrationUpdateApiModel,              'generated/swagger/models/application_registration_update_api_model.rb'
    autoload :EndpointActivationFilterApiModel,                   'generated/swagger/models/endpoint_activation_filter_api_model.rb'
    autoload :ApplicationSiteListApiModel,                        'generated/swagger/models/application_site_list_api_model.rb'
    autoload :ApplicationRegistrationRequestApiModel,             'generated/swagger/models/application_registration_request_api_model.rb'
    autoload :ApplicationRegistrationQueryApiModel,               'generated/swagger/models/application_registration_query_api_model.rb'
    autoload :ApplicationInfoApiModel,                            'generated/swagger/models/application_info_api_model.rb'
    autoload :EndpointRegistrationUpdateApiModel,                 'generated/swagger/models/endpoint_registration_update_api_model.rb'
    autoload :DiscoveryConfigApiModel,                            'generated/swagger/models/discovery_config_api_model.rb'
    autoload :EndpointInfoApiModel,                               'generated/swagger/models/endpoint_info_api_model.rb'
    autoload :CredentialApiModel,                                 'generated/swagger/models/credential_api_model.rb'
    autoload :EndpointInfoListApiModel,                           'generated/swagger/models/endpoint_info_list_api_model.rb'
    autoload :AuthenticationMethodApiModel,                       'generated/swagger/models/authentication_method_api_model.rb'
    autoload :EndpointRegistrationQueryApiModel,                  'generated/swagger/models/endpoint_registration_query_api_model.rb'
    autoload :CallbackApiModel,                                   'generated/swagger/models/callback_api_model.rb'
    autoload :StatusResponseApiModel,                             'generated/swagger/models/status_response_api_model.rb'
    autoload :ApplicationRegistrationResponseApiModel,            'generated/swagger/models/application_registration_response_api_model.rb'
    autoload :SupervisorApiModel,                                 'generated/swagger/models/supervisor_api_model.rb'
    autoload :DiscoveryRequestApiModel,                           'generated/swagger/models/discovery_request_api_model.rb'
    autoload :SupervisorUpdateApiModel,                           'generated/swagger/models/supervisor_update_api_model.rb'
    autoload :EndpointRegistrationApiModel,                       'generated/swagger/models/endpoint_registration_api_model.rb'
    autoload :EndpointActivationStatusApiModel,                   'generated/swagger/models/endpoint_activation_status_api_model.rb'
    autoload :ApplicationInfoListApiModel,                        'generated/swagger/models/application_info_list_api_model.rb'
    autoload :SupervisorStatusApiModel,                           'generated/swagger/models/supervisor_status_api_model.rb'
    autoload :ServerRegistrationRequestApiModel,                  'generated/swagger/models/server_registration_request_api_model.rb'
    autoload :SupervisorListApiModel,                             'generated/swagger/models/supervisor_list_api_model.rb'
    autoload :EndpointApiModel,                                   'generated/swagger/models/endpoint_api_model.rb'
    autoload :SupervisorQueryApiModel,                            'generated/swagger/models/supervisor_query_api_model.rb'
    autoload :CallbackMethodType,                                 'generated/swagger/models/callback_method_type.rb'
    autoload :SecurityMode,                                       'generated/swagger/models/security_mode.rb'
    autoload :ApplicationType,                                    'generated/swagger/models/application_type.rb'
    autoload :DiscoveryMode,                                      'generated/swagger/models/discovery_mode.rb'
    autoload :CredentialType,                                     'generated/swagger/models/credential_type.rb'
    autoload :SecurityAssessment,                                 'generated/swagger/models/security_assessment.rb'
    autoload :EndpointActivationState,                            'generated/swagger/models/endpoint_activation_state.rb'
    autoload :EndpointConnectivityState,                          'generated/swagger/models/endpoint_connectivity_state.rb'
  end
end
