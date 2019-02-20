# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.twin
  module Models
    #
    # browse response model
    #
    class BrowseResponseApiModel
      # @return [NodeApiModel] Node info for the currently browsed node
      attr_accessor :node

      # @return [Array<NodeReferenceApiModel>] References, if included,
      # otherwise null.
      attr_accessor :references

      # @return [String] Continuation token if more results pending.
      attr_accessor :continuation_token

      # @return [ServiceResultApiModel] Service result in case of error
      attr_accessor :error_info


      #
      # Mapper for BrowseResponseApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'BrowseResponseApiModel',
          type: {
            name: 'Composite',
            class_name: 'BrowseResponseApiModel',
            model_properties: {
              node: {
                client_side_validation: true,
                required: false,
                serialized_name: 'node',
                type: {
                  name: 'Composite',
                  class_name: 'NodeApiModel'
                }
              },
              references: {
                client_side_validation: true,
                required: false,
                serialized_name: 'references',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'NodeReferenceApiModelElementType',
                      type: {
                        name: 'Composite',
                        class_name: 'NodeReferenceApiModel'
                      }
                  }
                }
              },
              continuation_token: {
                client_side_validation: true,
                required: false,
                serialized_name: 'continuationToken',
                type: {
                  name: 'String'
                }
              },
              error_info: {
                client_side_validation: true,
                required: false,
                serialized_name: 'errorInfo',
                type: {
                  name: 'Composite',
                  class_name: 'ServiceResultApiModel'
                }
              }
            }
          }
        }
      end
    end
  end
end
