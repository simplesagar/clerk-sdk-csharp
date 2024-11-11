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
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Models.Components;
    using OpenapiClerk.BackendAPI.SDKClerk.BackendAPI.SDKsas.Utils;
    
    /// <summary>
    /// Verification details for the domain
    /// </summary>
    public class OrganizationDomainVerification
    {

        /// <summary>
        /// Status of the verification. It can be `unverified` or `verified`
        /// </summary>
        [JsonProperty("status")]
        public OrganizationDomainStatus? Status { get; set; }

        /// <summary>
        /// Name of the strategy used to verify the domain
        /// </summary>
        [JsonProperty("strategy")]
        public string? Strategy { get; set; }

        /// <summary>
        /// How many attempts have been made to verify the domain
        /// </summary>
        [JsonProperty("attempts")]
        public long? Attempts { get; set; }

        /// <summary>
        /// Unix timestamp of when the verification will expire
        /// </summary>
        [JsonProperty("expire_at")]
        public long? ExpireAt { get; set; } = null;
    }
}