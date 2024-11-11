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
    
    public class Saml
    {

        [JsonProperty("status")]
        public SAMLVerificationStatus Status { get; set; } = default!;

        [JsonProperty("strategy")]
        public SAMLVerificationStrategy Strategy { get; set; } = default!;

        [JsonProperty("external_verification_redirect_url", NullValueHandling = NullValueHandling.Include)]
        public string? ExternalVerificationRedirectUrl { get; set; }

        [JsonProperty("error")]
        public VerificationError? Error { get; set; } = null;

        [JsonProperty("expire_at")]
        public long ExpireAt { get; set; } = default!;

        [JsonProperty("attempts")]
        public long? Attempts { get; set; } = null;
    }
}