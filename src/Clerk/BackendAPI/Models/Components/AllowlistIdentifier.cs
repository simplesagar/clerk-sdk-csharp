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
    /// Success
    /// </summary>
    public class AllowlistIdentifier
    {

        /// <summary>
        /// String representing the object&apos;s type. Objects of the same type share the same value.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("object")]
        public AllowlistIdentifierObject? Object { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("invitation_id")]
        public string? InvitationId { get; set; }

        /// <summary>
        /// An email address or a phone number.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("identifier")]
        public string? Identifier { get; set; }

        [JsonProperty("identifier_type")]
        public IdentifierType? IdentifierType { get; set; }

        [JsonProperty("instance_id")]
        public string? InstanceId { get; set; }

        /// <summary>
        /// Unix timestamp of creation<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Unix timestamp of last update.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}