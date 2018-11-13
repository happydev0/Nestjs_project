// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Services.Twin.v1.Models {
    using Microsoft.Azure.IIoT.OpcUa.Twin.Models;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// node model
    /// </summary>
    public class NodeApiModel {

        /// <summary>
        /// Default constructor
        /// </summary>
        public NodeApiModel() { }

        /// <summary>
        /// Create node api model from service model
        /// </summary>
        /// <param name="model"></param>
        public NodeApiModel(NodeModel model) {
            Id = model.Id;
            HasChildren = model.HasChildren;
            Name = model.Name;
            DisplayName = model.DisplayName;
            Description = model.Description;
            NodeClass = model.NodeClass;
            IsAbstract = model.IsAbstract;
            AccessLevel = model.AccessLevel;
            EventNotifier = model.EventNotifier;
            Executable = model.Executable;
            DataType = model.DataType;
            ValueRank = model.ValueRank;
            AccessRestrictions = model.AccessRestrictions;
            ArrayDimensions = model.ArrayDimensions;
            ContainsNoLoops = model.ContainsNoLoops;
            DataTypeDefinition = model.DataTypeDefinition;
            Value = model.Value;
            Historizing = model.Historizing;
            InverseName = model.InverseName;
            MinimumSamplingInterval = model.MinimumSamplingInterval;
            Symmetric = model.Symmetric;
            UserAccessLevel = model.UserAccessLevel;
            UserExecutable = model.UserExecutable;
            UserWriteMask = model.UserWriteMask;
            WriteMask = model.WriteMask;
        }

        /// <summary>
        /// Convert back to service model
        /// </summary>
        /// <returns></returns>
        public NodeModel ToServiceModel() {
            return new NodeModel {
                Id = Id,
                HasChildren = HasChildren,
                Name = Name,
                DisplayName = DisplayName,
                Description = Description,
                NodeClass = NodeClass,
                IsAbstract = IsAbstract,
                AccessLevel = AccessLevel,
                EventNotifier = EventNotifier,
                Executable = Executable,
                DataType = DataType,
                ValueRank = ValueRank,
                AccessRestrictions = AccessRestrictions,
                ArrayDimensions = ArrayDimensions,
                ContainsNoLoops = ContainsNoLoops,
                DataTypeDefinition = DataTypeDefinition,
                Value = Value,
                Historizing = Historizing,
                InverseName = InverseName,
                MinimumSamplingInterval = MinimumSamplingInterval,
                Symmetric = Symmetric,
                UserAccessLevel = UserAccessLevel,
                UserExecutable = UserExecutable,
                UserWriteMask = UserWriteMask,
                WriteMask = WriteMask
            };
        }

        /// <summary>
        /// Type of node
        /// </summary>
        [JsonProperty(PropertyName = "nodeClass",
            NullValueHandling = NullValueHandling.Ignore)]
        public NodeClass? NodeClass { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        [JsonProperty(PropertyName = "displayName",
            NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Id of node.
        /// (Mandatory).
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// Description if any
        /// </summary>
        [JsonProperty(PropertyName = "description",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Whether node has children which are defined as
        /// any forward hierarchical references.
        /// (default: unknown)
        /// </summary>
        [JsonProperty(PropertyName = "children",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasChildren { get; set; }

        /// <summary>
        /// Browse name
        /// </summary>
        [JsonProperty(PropertyName = "name",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Node access restrictions if any.
        /// (default: none)
        /// </summary>
        [JsonProperty(PropertyName = "accessRestrictions",
            NullValueHandling = NullValueHandling.Ignore)]
        public NodeAccessRestrictions? AccessRestrictions { get; set; }

        /// <summary>
        /// Default write mask for the node
        /// (default: 0)
        /// </summary>
        [JsonProperty(PropertyName = "writeMask",
            NullValueHandling = NullValueHandling.Ignore)]
        public uint? WriteMask { get; set; }

        /// <summary>
        /// User write mask for the node
        /// (default: 0)
        /// </summary>
        [JsonProperty(PropertyName = "userWriteMask",
            NullValueHandling = NullValueHandling.Ignore)]
        public uint? UserWriteMask { get; set; }

        /// <summary>
        /// Whether type is abstract, if type can
        /// be abstract.  Null if not type node.
        /// (default: false)
        /// </summary>
        [JsonProperty(PropertyName = "isAbstract",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAbstract { get; set; }

        /// <summary>
        /// Whether a view contains loops. Null if
        /// not a view.
        /// </summary>
        [JsonProperty(PropertyName = "containsNoLoops",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainsNoLoops { get; set; }

        /// <summary>
        /// If object or view and eventing, event notifier
        /// to subscribe to.
        /// (default: no events supported)
        /// </summary>
        [JsonProperty(PropertyName = "eventNotifier",
            NullValueHandling = NullValueHandling.Ignore)]
        public NodeEventNotifier? EventNotifier { get; set; }

        /// <summary>
        /// If method node class, whether method can
        /// be called.
        /// </summary>
        [JsonProperty(PropertyName = "executable",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Executable { get; set; }

        /// <summary>
        /// If method node class, whether method can
        /// be called by current user.
        /// (default: false if not executable)
        /// </summary>
        [JsonProperty(PropertyName = "userExecutable",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserExecutable { get; set; }

        /// <summary>
        /// Data type definition in case node is a
        /// data type node and definition is available,
        /// otherwise null.
        /// </summary>
        [JsonProperty(PropertyName = "dataTypeDefinition",
            NullValueHandling = NullValueHandling.Ignore)]
        public JToken DataTypeDefinition { get; set; }

        /// <summary>
        /// Default access level for variable node.
        /// (default: 0)
        /// </summary>
        [JsonProperty(PropertyName = "accessLevel",
            NullValueHandling = NullValueHandling.Ignore)]
        public NodeAccessLevel? AccessLevel { get; set; }

        /// <summary>
        /// User access level for variable node or null.
        /// (default: 0)
        /// </summary>
        [JsonProperty(PropertyName = "userAccessLevel",
            NullValueHandling = NullValueHandling.Ignore)]
        public NodeAccessLevel? UserAccessLevel { get; set; }

        /// <summary>
        /// If variable the datatype of the variable.
        /// (default: null)
        /// </summary>
        [JsonProperty(PropertyName = "dataType",
            NullValueHandling = NullValueHandling.Ignore)]
        public string DataType { get; set; }

        /// <summary>
        /// Value rank of the variable data of a variable
        /// or variable type, otherwise null.
        /// (default: scalar = -1)
        /// </summary>
        [JsonProperty(PropertyName = "valueRank",
            NullValueHandling = NullValueHandling.Ignore)]
        public NodeValueRank? ValueRank { get; set; }

        /// <summary>
        /// Array dimensions of variable or variable type.
        /// (default: empty array)
        /// </summary>
        [JsonProperty(PropertyName = "arrayDimensions",
            NullValueHandling = NullValueHandling.Ignore)]
        public uint[] ArrayDimensions { get; set; }

        /// <summary>
        /// Whether the value of a variable is historizing.
        /// (default: false)
        /// </summary>
        [JsonProperty(PropertyName = "historizing",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Historizing { get; set; }

        /// <summary>
        /// Minimum sampling interval for the variable
        /// value, otherwise null if not a variable node.
        /// (default: null)
        /// </summary>
        [JsonProperty(PropertyName = "minimumSamplingInterval",
            NullValueHandling = NullValueHandling.Ignore)]
        public double? MinimumSamplingInterval { get; set; }

        /// <summary>
        /// Value of variable or default value of the
        /// subtyped variable in case node is a variable
        /// type, otherwise null.
        /// </summary>
        [JsonProperty(PropertyName = "value",
            NullValueHandling = NullValueHandling.Ignore)]
        public JToken Value { get; set; }

        /// <summary>
        /// Inverse name of the reference if the node is
        /// a reference type, otherwise null.
        /// </summary>
        [JsonProperty(PropertyName = "inverseName",
            NullValueHandling = NullValueHandling.Ignore)]
        public string InverseName { get; set; }

        /// <summary>
        /// Whether the reference is symmetric in case
        /// the node is a reference type, otherwise
        /// null.
        /// </summary>
        [JsonProperty(PropertyName = "symmetric",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Symmetric { get; set; }
    }
}
