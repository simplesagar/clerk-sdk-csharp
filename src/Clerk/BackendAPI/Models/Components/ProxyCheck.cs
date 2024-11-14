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
    
    /// <summary>
    /// Health check information about a domain&apos;s proxy configuration validation attempt.
    /// </summary>
    public class ProxyCheck
    {

        [JsonProperty("object")]
        public ProxyCheckObject Object { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("domain_id")]
        public string DomainId { get; set; } = default!;

        [JsonProperty("last_run_at")]
        public long LastRunAt { get; set; } = default!;

        [JsonProperty("proxy_url")]
        public string ProxyUrl { get; set; } = default!;

        [JsonProperty("successful")]
        public bool Successful { get; set; } = default!;

        [JsonProperty("created_at")]
        public long CreatedAt { get; set; } = default!;

        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; } = default!;
    }
}