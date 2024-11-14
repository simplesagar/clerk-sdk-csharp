//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI.Models.Components
{
    using Clerk.BackendAPI.Models.Components;
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    
    public class Oauth
    {

        [JsonProperty("status")]
        public OauthVerificationStatus Status { get; set; } = default!;

        [JsonProperty("strategy")]
        public OauthVerificationStrategy Strategy { get; set; } = default!;

        [JsonProperty("external_verification_redirect_url")]
        public string? ExternalVerificationRedirectUrl { get; set; }

        [JsonProperty("error")]
        public Error? Error { get; set; } = null;

        [JsonProperty("expire_at")]
        public long ExpireAt { get; set; } = default!;

        [JsonProperty("attempts")]
        public long? Attempts { get; set; } = null;
    }
}