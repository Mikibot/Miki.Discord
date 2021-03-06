﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Miki.Discord.Rest
{
    [DataContract]
    public class EmojiModifyArgs
    {
        [JsonPropertyName("name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [JsonPropertyName("roles")]
        [DataMember(Name = "roles")]
        public ulong[] Roles { get; set; }

        public EmojiModifyArgs(string name, params ulong[] roles)
        {
            Name = name;
            Roles = roles;
        }
    }
}