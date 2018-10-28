﻿using Miki.Discord.Common.Packets;
using System;

namespace Miki.Discord.Common
{
	public static class DiscordHelper
	{
		public const string DiscordUrl = "https://discordapp.com";
		public const string BaseUrl = "/api/v6";
		public const string CdnUrl = "https://cdn.discordapp.com";

		public static string GetAvatarUrl(DiscordUserPacket packet, ImageType type = ImageType.AUTO, ImageSize size = ImageSize.x256)
		{
			if (packet.Avatar != null)
			{
				return GetAvatarUrl(packet.Id, packet.Avatar, type, size);
			}
			return GetAvatarUrl(ushort.Parse(packet.Discriminator));
		}

		public static string GetAvatarUrl(ulong id, string hash, ImageType imageType = ImageType.AUTO, ImageSize size = ImageSize.x256)
		{
			if (imageType == ImageType.AUTO)
			{
				imageType = hash.StartsWith("a_")
					? ImageType.GIF
					: ImageType.PNG;
			}

			return $"{CdnUrl}/avatars/{id}/{hash}.{imageType.ToString().ToLower()}?size={Math.Pow(2, 4 + (int)size)}";
		}

		public static string GetAvatarUrl(ushort discriminator)
			=> $"{CdnUrl}/embed/avatars/{discriminator % 5}.png";
	}
}