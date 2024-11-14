//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI.Models.Operations
{
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    using System;
    
    public enum CodeType
    {
        [JsonProperty("totp")]
        Totp,
        [JsonProperty("backup_code")]
        BackupCode,
    }

    public static class CodeTypeExtension
    {
        public static string Value(this CodeType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CodeType ToEnum(this string value)
        {
            foreach(var field in typeof(CodeType).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is CodeType)
                    {
                        return (CodeType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum CodeType");
        }
    }

}