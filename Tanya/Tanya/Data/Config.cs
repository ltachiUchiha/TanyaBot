﻿using Discord;
using System.Collections.Generic;

namespace Tanya.DataStructs
{
    public class Config
    {
        public string DiscordToken { get; set; }
        public string DefaultPrefix { get; set; }
        public string Status { get; set; }
        public ActivityType Activity { get; set; }
        public readonly Color Tanya = new Color(227, 117, 108);
        public List<ulong> BlacklistedChannels { get; set; }
    }
}
