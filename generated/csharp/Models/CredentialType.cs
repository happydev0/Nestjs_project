// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Registry.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CredentialType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CredentialType
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "UserName")]
        UserName,
        [EnumMember(Value = "X509Certificate")]
        X509Certificate,
        [EnumMember(Value = "JwtToken")]
        JwtToken
    }
    internal static class CredentialTypeEnumExtension
    {
        internal static string ToSerializedValue(this CredentialType? value)
        {
            return value == null ? null : ((CredentialType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CredentialType value)
        {
            switch( value )
            {
                case CredentialType.None:
                    return "None";
                case CredentialType.UserName:
                    return "UserName";
                case CredentialType.X509Certificate:
                    return "X509Certificate";
                case CredentialType.JwtToken:
                    return "JwtToken";
            }
            return null;
        }

        internal static CredentialType? ParseCredentialType(this string value)
        {
            switch( value )
            {
                case "None":
                    return CredentialType.None;
                case "UserName":
                    return CredentialType.UserName;
                case "X509Certificate":
                    return CredentialType.X509Certificate;
                case "JwtToken":
                    return CredentialType.JwtToken;
            }
            return null;
        }
    }
}
