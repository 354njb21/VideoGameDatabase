using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDatabase.Models
{
    public class Game
    {
        public int GameId { get; }

        public int CompanyId { get; }

        public int PlatformId { get; }

        public string Name { get; }

        public double Price { get; }

        public DateTime ReleaseDate { get; }

        public char Rating { get; }


        public Game(int gameId, int companyId, int platformId, string name, double price, DateTime releaseDate, char rating)
        {
            GameId = gameId;
            CompanyId = companyId;
            PlatformId = platformId;
            Name = name;
            Price = price;
            ReleaseDate = releaseDate;
            Rating = rating;
        }
    }
}
