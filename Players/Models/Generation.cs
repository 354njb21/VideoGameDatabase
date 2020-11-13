using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players.Models
{
    public class Generation
    {
        public int GenerationId { get; }

        public string GenerationName { get; }

        public int Players { get; }

        public Generation(int generationId, string generationName, int players)
        {
            GenerationId = generationId;
            GenerationName = generationName;
            Players = players;
        }
    }
}
