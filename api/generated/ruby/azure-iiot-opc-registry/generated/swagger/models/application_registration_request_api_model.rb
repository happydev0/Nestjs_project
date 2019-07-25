# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.registry
  module Models
    #
    # Application information
    #
    class ApplicationRegistrationRequestApiModel
      # @return [String] Unique application uri
      attr_accessor :application_uri

      # @return [ApplicationType] Type of application. Possible values include:
      # 'Server', 'Client', 'ClientAndServer', 'DiscoveryServer'
      attr_accessor :application_type

      # @return [String] Product uri of the application.
      attr_accessor :product_uri

      # @return [String] Default name of the server or client.
      attr_accessor :application_name

      # @return [String] Locale of default name
      attr_accessor :locale

      # @return [String] Site of the application
      attr_accessor :site_id

      # @return [Hash{String => String}] Localized names key off locale id.
      attr_accessor :localized_names

      # @return [Array<String>] The OPC UA defined capabilities of the server.
      attr_accessor :capabilities

      # @return [Array<String>] Discovery urls of the server.
      attr_accessor :discovery_urls

      # @return [String] The discovery profile uri of the server.
      attr_accessor :discovery_profile_uri

      # @return [String] Gateway server uri
      attr_accessor :gateway_server_uri


      #
      # Mapper for ApplicationRegistrationRequestApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'ApplicationRegistrationRequestApiModel',
          type: {
            name: 'Composite',
            class_name: 'ApplicationRegistrationRequestApiModel',
            model_properties: {
              application_uri: {
                client_side_validation: true,
                required: true,
                serialized_name: 'applicationUri',
                type: {
                  name: 'String'
                }
              },
              application_type: {
                client_side_validation: true,
                required: false,
                serialized_name: 'applicationType',
                type: {
                  name: 'Enum',
                  module: 'ApplicationType'
                }
              },
              product_uri: {
                client_side_validation: true,
                required: false,
                serialized_name: 'productUri',
                type: {
                  name: 'String'
                }
              },
              application_name: {
                client_side_validation: true,
                required: false,
                serialized_name: 'applicationName',
                type: {
                  name: 'String'
                }
              },
              locale: {
                client_side_validation: true,
                required: false,
                serialized_name: 'locale',
                type: {
                  name: 'String'
                }
              },
              site_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'siteId',
                type: {
                  name: 'String'
                }
              },
              localized_names: {
                client_side_validation: true,
                required: false,
                serialized_name: 'localizedNames',
                type: {
                  name: 'Dictionary',
                  value: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'StringElementType',
                      type: {
                        name: 'String'
                      }
                  }
                }
              },
              capabilities: {
                client_side_validation: true,
                required: false,
                serialized_name: 'capabilities',
                constraints: {
                  UniqueItems: true
                },
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'StringElementType',
                      type: {
                        name: 'String'
                      }
                  }
                }
              },
              discovery_urls: {
                client_side_validation: true,
                required: false,
                serialized_name: 'discoveryUrls',
                constraints: {
                  UniqueItems: true
                },
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'StringElementType',
                      type: {
                        name: 'String'
                      }
                  }
                }
              },
              discovery_profile_uri: {
                client_side_validation: true,
                required: false,
                serialized_name: 'discoveryProfileUri',
                type: {
                  name: 'String'
                }
              },
              gateway_server_uri: {
                client_side_validation: true,
                required: false,
                serialized_name: 'gatewayServerUri',
                type: {
                  name: 'String'
                }
              }
            }
          }
        }
      end
    end
  end
end
