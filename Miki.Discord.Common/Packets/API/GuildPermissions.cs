﻿using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Miki.Discord.Common
{
    [DataContract]
    public class PermissionOverwrite
    {
        [JsonPropertyName("id")]
        [DataMember(Name = "id")]
        public ulong Id { get; set; }

        [JsonPropertyName("type")]
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [JsonPropertyName("allow")]
        [DataMember(Name = "allow")]
        public GuildPermission AllowedPermissions { get; set; }

        [JsonPropertyName("deny")]
        [DataMember(Name = "deny")]
        public GuildPermission DeniedPermissions { get; set; }
    }

    [Flags]
    public enum GuildPermission : ulong
    {
        // General
        CreateInstantInvite = 0x00_00_00_01,

        KickMembers = 0x00_00_00_02,
        BanMembers = 0x00_00_00_04,
        Administrator = 0x00_00_00_08,
        ManageChannels = 0x00_00_00_10,
        ManageGuild = 0x00_00_00_20,

        // Text
        AddReactions = 0x00_00_00_40,

        ViewAuditLog = 0x00_00_00_80,
        ViewChannel = 0x00_00_04_00,
        SendMessages = 0x00_00_08_00,
        SendTTSMessages = 0x00_00_10_00,
        ManageMessages = 0x00_00_20_00,
        EmbedLinks = 0x00_00_40_00,
        AttachFiles = 0x00_00_80_00,
        ReadMessageHistory = 0x00_01_00_00,
        MentionEveryone = 0x00_02_00_00,
        UseExternalEmojis = 0x00_04_00_00,

        // Voice
        Connect = 0x00_10_00_00,

        Speak = 0x00_20_00_00,
        MuteMembers = 0x00_40_00_00,
        DeafenMembers = 0x00_80_00_00,
        MoveMembers = 0x01_00_00_00,
        UseVAD = 0x02_00_00_00,

        // General 2
        ChangeNickname = 0x04_00_00_00,

        ManageNicknames = 0x08_00_00_00,
        ManageRoles = 0x10_00_00_00,
        ManageWebhooks = 0x20_00_00_00,
        ManageEmojis = 0x40_00_00_00,

        All = 0xff_ff_ff_ff,
        None = 0x00_00_00_00
    }

    [Flags]
    public enum TextOverrides : ulong
    {
        // General
        CreateInstantInvite = 0x00_00_00_01,

        ManageChannels = 0x00_00_00_10,

        // Text
        AddReactions = 0x00_00_00_40,

        ViewChannel = 0x00_00_04_00,
        SendMessages = 0x00_00_08_00,
        SendTTSMessages = 0x00_00_10_00,
        ManageMessages = 0x00_00_20_00,
        EmbedLinks = 0x00_00_40_00,
        AttachFiles = 0x00_00_80_00,
        ReadMessageHistory = 0x00_01_00_00,
        MentionEveryone = 0x00_02_00_00,
        UseExternalEmojis = 0x00_04_00_00,

        ManageRoles = 0x10_00_00_00,
        ManageWebhooks = 0x20_00_00_00,

        All = 0xff_ff_ff_ff,
        None = 0x00_00_00_00
    }

    [Flags]
    public enum VoiceOverrides : ulong
    {
        // General
        CreateInstantInvite = 0x00_00_00_01,

        ManageChannels = 0x00_00_00_10,

        // Text
        ViewChannel = 0x00_00_04_00,

        // Voice
        Connect = 0x00_10_00_00,

        Speak = 0x00_20_00_00,
        MuteMembers = 0x00_40_00_00,
        DeafenMembers = 0x00_80_00_00,
        MoveMembers = 0x01_00_00_00,
        UseVAD = 0x02_00_00_00,

        // General 2
        ManageRoles = 0x10_00_00_00,

        ManageWebhooks = 0x20_00_00_00,

        All = 0xff_ff_ff_ff,
        None = 0x00_00_00_00
    }
}