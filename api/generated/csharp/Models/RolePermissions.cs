// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Twin.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RolePermissions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RolePermissions
    {
        [EnumMember(Value = "Browse")]
        Browse,
        [EnumMember(Value = "ReadRolePermissions")]
        ReadRolePermissions,
        [EnumMember(Value = "WriteAttribute")]
        WriteAttribute,
        [EnumMember(Value = "WriteRolePermissions")]
        WriteRolePermissions,
        [EnumMember(Value = "WriteHistorizing")]
        WriteHistorizing,
        [EnumMember(Value = "Read")]
        Read,
        [EnumMember(Value = "Write")]
        Write,
        [EnumMember(Value = "ReadHistory")]
        ReadHistory,
        [EnumMember(Value = "InsertHistory")]
        InsertHistory,
        [EnumMember(Value = "ModifyHistory")]
        ModifyHistory,
        [EnumMember(Value = "DeleteHistory")]
        DeleteHistory,
        [EnumMember(Value = "ReceiveEvents")]
        ReceiveEvents,
        [EnumMember(Value = "Call")]
        Call,
        [EnumMember(Value = "AddReference")]
        AddReference,
        [EnumMember(Value = "RemoveReference")]
        RemoveReference,
        [EnumMember(Value = "DeleteNode")]
        DeleteNode,
        [EnumMember(Value = "AddNode")]
        AddNode
    }
    internal static class RolePermissionsEnumExtension
    {
        internal static string ToSerializedValue(this RolePermissions? value)
        {
            return value == null ? null : ((RolePermissions)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RolePermissions value)
        {
            switch( value )
            {
                case RolePermissions.Browse:
                    return "Browse";
                case RolePermissions.ReadRolePermissions:
                    return "ReadRolePermissions";
                case RolePermissions.WriteAttribute:
                    return "WriteAttribute";
                case RolePermissions.WriteRolePermissions:
                    return "WriteRolePermissions";
                case RolePermissions.WriteHistorizing:
                    return "WriteHistorizing";
                case RolePermissions.Read:
                    return "Read";
                case RolePermissions.Write:
                    return "Write";
                case RolePermissions.ReadHistory:
                    return "ReadHistory";
                case RolePermissions.InsertHistory:
                    return "InsertHistory";
                case RolePermissions.ModifyHistory:
                    return "ModifyHistory";
                case RolePermissions.DeleteHistory:
                    return "DeleteHistory";
                case RolePermissions.ReceiveEvents:
                    return "ReceiveEvents";
                case RolePermissions.Call:
                    return "Call";
                case RolePermissions.AddReference:
                    return "AddReference";
                case RolePermissions.RemoveReference:
                    return "RemoveReference";
                case RolePermissions.DeleteNode:
                    return "DeleteNode";
                case RolePermissions.AddNode:
                    return "AddNode";
            }
            return null;
        }

        internal static RolePermissions? ParseRolePermissions(this string value)
        {
            switch( value )
            {
                case "Browse":
                    return RolePermissions.Browse;
                case "ReadRolePermissions":
                    return RolePermissions.ReadRolePermissions;
                case "WriteAttribute":
                    return RolePermissions.WriteAttribute;
                case "WriteRolePermissions":
                    return RolePermissions.WriteRolePermissions;
                case "WriteHistorizing":
                    return RolePermissions.WriteHistorizing;
                case "Read":
                    return RolePermissions.Read;
                case "Write":
                    return RolePermissions.Write;
                case "ReadHistory":
                    return RolePermissions.ReadHistory;
                case "InsertHistory":
                    return RolePermissions.InsertHistory;
                case "ModifyHistory":
                    return RolePermissions.ModifyHistory;
                case "DeleteHistory":
                    return RolePermissions.DeleteHistory;
                case "ReceiveEvents":
                    return RolePermissions.ReceiveEvents;
                case "Call":
                    return RolePermissions.Call;
                case "AddReference":
                    return RolePermissions.AddReference;
                case "RemoveReference":
                    return RolePermissions.RemoveReference;
                case "DeleteNode":
                    return RolePermissions.DeleteNode;
                case "AddNode":
                    return RolePermissions.AddNode;
            }
            return null;
        }
    }
}
