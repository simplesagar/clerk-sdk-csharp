//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Models.Components
{
    using Newtonsoft.Json;
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Utils;
    using System;
    
    /// <summary>
    /// String representing the object&apos;s type. Objects of the same type share the same value.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum OrganizationInvitationWithPublicOrganizationDataObject
    {
        [JsonProperty("organization_invitation")]
        OrganizationInvitation,
    }

    public static class OrganizationInvitationWithPublicOrganizationDataObjectExtension
    {
        public static string Value(this OrganizationInvitationWithPublicOrganizationDataObject value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static OrganizationInvitationWithPublicOrganizationDataObject ToEnum(this string value)
        {
            foreach(var field in typeof(OrganizationInvitationWithPublicOrganizationDataObject).GetFields())
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

                    if (enumVal is OrganizationInvitationWithPublicOrganizationDataObject)
                    {
                        return (OrganizationInvitationWithPublicOrganizationDataObject)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum OrganizationInvitationWithPublicOrganizationDataObject");
        }
    }

}