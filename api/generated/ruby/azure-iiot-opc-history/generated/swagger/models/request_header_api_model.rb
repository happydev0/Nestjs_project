# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.history
  module Models
    #
    # Request header model
    #
    class RequestHeaderApiModel
      # @return [CredentialApiModel]
      attr_accessor :elevation

      # @return [Array<String>] Optional list of locales in preference order.
      attr_accessor :locales

      # @return [DiagnosticsApiModel]
      attr_accessor :diagnostics


      #
      # Mapper for RequestHeaderApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'RequestHeaderApiModel',
          type: {
            name: 'Composite',
            class_name: 'RequestHeaderApiModel',
            model_properties: {
              elevation: {
                client_side_validation: true,
                required: false,
                serialized_name: 'elevation',
                type: {
                  name: 'Composite',
                  class_name: 'CredentialApiModel'
                }
              },
              locales: {
                client_side_validation: true,
                required: false,
                serialized_name: 'locales',
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
              diagnostics: {
                client_side_validation: true,
                required: false,
                serialized_name: 'diagnostics',
                type: {
                  name: 'Composite',
                  class_name: 'DiagnosticsApiModel'
                }
              }
            }
          }
        }
      end
    end
  end
end
