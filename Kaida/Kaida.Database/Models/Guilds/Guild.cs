﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kaida.Database.Models.Guilds
{
    public class Guild
    {
        public ulong Id { get; set; }
        public string Prefix { get; set; }
        public IList<ulong> ModeratorIds { get; set; }
        public bool WarnModerator { get; set; }
        public bool MuteModerator { get; set; }
        public IList<Log> Logs { get; set; }
    }
}
