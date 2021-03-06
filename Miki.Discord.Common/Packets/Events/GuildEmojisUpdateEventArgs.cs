﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Miki.Discord.Common.Events
{
    [DataContract]
    public class GuildEmojisUpdateEventArgs
    {
        [JsonPropertyName("guild_id")]
        [DataMember(Name = "guild_id")]
        public ulong GuildId { get; set; }

        [JsonPropertyName("emojis")]
        [DataMember(Name = "emojis")]
        public IReadOnlyList<DiscordEmoji> Emojis { get; set; }
    }
}