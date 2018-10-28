﻿using Miki.Discord.Common.Packets;
using Newtonsoft.Json;

namespace Miki.Discord.Common.Events
{
	public class RoleEventArgs
	{
		[JsonProperty("guild_id")]
		public ulong GuildId;

		[JsonProperty("role")]
		public DiscordRolePacket Role;
	}
}