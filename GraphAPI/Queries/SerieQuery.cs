using GraphAPI.Models;

namespace GraphAPI.Queries
{
    public class SerieQuery
    {
        public Serie GetSerie()
        {
            return new Serie
            {
                Name = "One piece",
                ReleaseDate = DateTime.UtcNow.AddDays(-10),
                Platforms = new List<Platform>
                {
                    new Platform
                    {
                        Name = "Crunchyroll",
                        Followers = 1000
                    },
                    new Platform
                    {
                        Name = "Netflix",
                        Followers = 2000
                    }
                }
            };
        }

        public List<Serie> GetSeries()
        {
            return new List<Serie>
            {
                new Serie
                {
                    Name = "One piece",
                    ReleaseDate = DateTime.UtcNow.AddDays(-10),
                    Platforms = new List<Platform>
                    {
                        new Platform
                        {
                            Name = "Crunchyroll",
                            Followers = 1000
                        },
                        new Platform
                        {
                            Name = "Netflix",
                            Followers = 2000
                        }
                    }
                },
                new Serie
                {
                    Name = "Formula 1: Drive To Survive",
                    ReleaseDate = DateTime.UtcNow.AddDays(-20),
                    Platforms = new List<Platform>
                    {
                        new Platform
                        {
                            Name = "Crunchyroll",
                            Followers = 1500
                        },
                        new Platform
                        {
                            Name = "Netflix",
                            Followers = 2500
                        }
                    }
                }
            };
        }
        private List<Serie> series = new List<Serie>
        {
            new Serie
            {
                Id = 1,
                Name = "One piece",
                ReleaseDate = DateTime.UtcNow.AddDays(-10),
                Platforms = new List<Platform>
                {
                    new Platform
                    {
                        Name = "Crunchyroll",
                        Followers = 1000
                    },
                    new Platform
                    {
                        Name = "Netflix",
                        Followers = 2000
                    }
                }
            },
            new Serie
            {
                Id = 2,
                Name = "Formula 1: Drive To Survive",
                ReleaseDate = DateTime.UtcNow.AddDays(-20),
                Platforms = new List<Platform>
                {
                    new Platform
                    {
                        Name = "Crunchyroll",
                        Followers = 1500
                    },
                    new Platform
                    {
                        Name = "Netflix",
                        Followers = 2500
                    }
                }
            }
        };

        public Serie GetSerieById(int id)
        {
            return series.Find(serie => serie.Id == id);
        }
    }
}
