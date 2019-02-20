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
    /// Defines values for NodeAccessLevel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NodeAccessLevel
    {
        [EnumMember(Value = "CurrentRead")]
        CurrentRead,
        [EnumMember(Value = "CurrentWrite")]
        CurrentWrite,
        [EnumMember(Value = "HistoryRead")]
        HistoryRead,
        [EnumMember(Value = "HistoryWrite")]
        HistoryWrite,
        [EnumMember(Value = "SemanticChange")]
        SemanticChange,
        [EnumMember(Value = "StatusWrite")]
        StatusWrite,
        [EnumMember(Value = "TimestampWrite")]
        TimestampWrite,
        [EnumMember(Value = "NonatomicRead")]
        NonatomicRead,
        [EnumMember(Value = "NonatomicWrite")]
        NonatomicWrite,
        [EnumMember(Value = "WriteFullArrayOnly")]
        WriteFullArrayOnly
    }
    internal static class NodeAccessLevelEnumExtension
    {
        internal static string ToSerializedValue(this NodeAccessLevel? value)
        {
            return value == null ? null : ((NodeAccessLevel)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this NodeAccessLevel value)
        {
            switch( value )
            {
                case NodeAccessLevel.CurrentRead:
                    return "CurrentRead";
                case NodeAccessLevel.CurrentWrite:
                    return "CurrentWrite";
                case NodeAccessLevel.HistoryRead:
                    return "HistoryRead";
                case NodeAccessLevel.HistoryWrite:
                    return "HistoryWrite";
                case NodeAccessLevel.SemanticChange:
                    return "SemanticChange";
                case NodeAccessLevel.StatusWrite:
                    return "StatusWrite";
                case NodeAccessLevel.TimestampWrite:
                    return "TimestampWrite";
                case NodeAccessLevel.NonatomicRead:
                    return "NonatomicRead";
                case NodeAccessLevel.NonatomicWrite:
                    return "NonatomicWrite";
                case NodeAccessLevel.WriteFullArrayOnly:
                    return "WriteFullArrayOnly";
            }
            return null;
        }

        internal static NodeAccessLevel? ParseNodeAccessLevel(this string value)
        {
            switch( value )
            {
                case "CurrentRead":
                    return NodeAccessLevel.CurrentRead;
                case "CurrentWrite":
                    return NodeAccessLevel.CurrentWrite;
                case "HistoryRead":
                    return NodeAccessLevel.HistoryRead;
                case "HistoryWrite":
                    return NodeAccessLevel.HistoryWrite;
                case "SemanticChange":
                    return NodeAccessLevel.SemanticChange;
                case "StatusWrite":
                    return NodeAccessLevel.StatusWrite;
                case "TimestampWrite":
                    return NodeAccessLevel.TimestampWrite;
                case "NonatomicRead":
                    return NodeAccessLevel.NonatomicRead;
                case "NonatomicWrite":
                    return NodeAccessLevel.NonatomicWrite;
                case "WriteFullArrayOnly":
                    return NodeAccessLevel.WriteFullArrayOnly;
            }
            return null;
        }
    }
}
