using GameLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Data
{
    public class GameContext : DbContext
    {
        public DbSet<BoardGameModel> BoardGames { get; set; }
        public DbSet<PublisherModel> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=GameLibrary;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PublisherModelBoardGameModel>()
           .HasKey(t => new { t.PublisherID, t.BoardGameId });
           
            modelBuilder.Entity<BoardGameModel>().HasData(
                new BoardGameModel()
                {
                    Id = 1,
                    Name = "SmallWorld",
                    Publisher = "Days of Wonder",
                    Description = "Control one fantasy race after another to expand throught the land",
                    ImageURL = "https://cf.geekdo-images.com/aoPM07XzoceB-RydLh08zA__imagepage/img/lHmv0ddOrUvpiLcPeQbZdT5yCEA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic428828.jpg"
                },
                new BoardGameModel()
                {
                    Id = 2,
                    Name = "WingSpan",
                    Publisher = "Stonemaier Games",
                    Description = "Attract a beautiful and diverse" +
                    "collection of birds to your wildlife preserve.",
                    ImageURL = "https://cf.geekdo-images.com/yLZJCVLlIx4c7eJEWUNJ7w__imagepagezoom/img/yS4vL6iTCvHSvGySxyOjV_-R3dI=/fit-in/1200x900/filters:no_upscale():strip_icc()/pic4458123.jpg"
                });
            modelBuilder.Entity<PublisherModel>().HasData(
                new PublisherModel()
                {
                    Id = 1,
                    Name = "Days of Wonder"
                },
                new PublisherModel()
                {
                    Id = 2,
                    Name = "Stonemaier Games"
                });
            modelBuilder.Entity<PublisherModelBoardGameModel>().HasData(
                new PublisherModelBoardGameModel()
                {
                    BoardGameId = 1,
                    PublisherID = 1
                },
                new PublisherModelBoardGameModel()
                {
                    BoardGameId = 2,
                    PublisherID = 2
                });
        
        }





    }

    
}
