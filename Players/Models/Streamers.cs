using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players.Models
{
    public class Streamers
    {
        public int StreamerId { get; }

        public string StreamerName { get; }

        public int Income { get; }

        public string StreamPlatform { get; }

        public int Subscribers { get; }

        public Streamers(int streamerId, string streamerName, int income, string streamPlatform, int subscribers)
        {
            StreamerId = streamerId;
            StreamerName = streamerName;
            Income = income;
            StreamPlatform = streamPlatform;
            Subscribers = subscribers;
        }
    }
}
