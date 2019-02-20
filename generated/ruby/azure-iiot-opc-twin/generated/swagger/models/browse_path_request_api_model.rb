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
    # Browse nodes by path
    #
    class BrowsePathRequestApiModel
      # @return [String] Node to browse.
      # (default: RootFolder).
      attr_accessor :node_id

      # @return [Array<String>] The path elements of the path to browse from
      # node.
      # (mandatory)
      attr_accessor :path_elements

      # @return [Boolean] Whether to read variable values on target nodes.
      # (default is false). Default value: false .
      attr_accessor :read_variable_values

      # @return [RequestHeaderApiModel] Optional request header
      attr_accessor :header


      #
      # Mapper for BrowsePathRequestApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'BrowsePathRequestApiModel',
          type: {
            name: 'Composite',
            class_name: 'BrowsePathRequestApiModel',
            model_properties: {
              node_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'nodeId',
                type: {
                  name: 'String'
                }
              },
              path_elements: {
                client_side_validation: true,
                required: true,
                serialized_name: 'pathElements',
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
              read_variable_values: {
                client_side_validation: true,
                required: false,
                serialized_name: 'readVariableValues',
                default_value: false,
                type: {
                  name: 'Boolean'
                }
              },
              header: {
                client_side_validation: true,
                required: false,
                serialized_name: 'header',
                type: {
                  name: 'Composite',
                  class_name: 'RequestHeaderApiModel'
                }
              }
            }
          }
        }
      end
    end
  end
end
