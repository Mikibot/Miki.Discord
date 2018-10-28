﻿using Miki.Discord.Common.Packets;
using Newtonsoft.Json;

namespace Miki.Discord.Common.Events
{
	public class GuildMemberUpdateEventArgs
	{
		[JsonProperty("guild_id")]
		public ulong GuildId;

		[JsonProperty("roles")]
		public ulong[] RoleIds;

		[JsonProperty("user")]
		public DiscordUserPacket User;

		[JsonProperty("nick")]
		public string Nickname;
	}
}