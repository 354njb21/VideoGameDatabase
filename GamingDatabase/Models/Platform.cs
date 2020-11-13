using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDatabase.Models
{
    public class Platform
    {
        public int PlatformId { get; }

        public string PlatformName { get; }

        public int OnlinePlayers { get; }

        public Platform(int platformId, string platformName, int onlinePlayers)
        {
            PlatformId = platformId;
            PlatformName = platformName;
            OnlinePlayers = onlinePlayers;
        }
    }
}
