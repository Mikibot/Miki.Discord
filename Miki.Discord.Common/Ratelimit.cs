﻿using ProtoBuf;
using System;

namespace Miki.Discord.Rest
{
	[ProtoContract]
	public class Ratelimit
	{
		[ProtoMember(1)]
		public int Remaining { get; set; }

		[ProtoMember(2)]
		public int Limit { get; set; }

		[ProtoMember(3)]
		public long Reset { get; set; }

		[ProtoMember(4)]
		public int? Global { get; set; }

		public bool IsRatelimited()
		{
			return IsRatelimited(this);
		}

		public static bool IsRatelimited(Ratelimit rl)
		{
			return ((rl?.Global ?? 1) <= 0 
					|| (rl?.Remaining ?? 1) <= 0) 
				&& DateTime.UtcNow <= DateTimeOffset.FromUnixTimeSeconds(rl?.Reset ?? 0);
		}
	}
}