using System;
using System.Collections.Generic;
using System.Text;
using WC_Draw_FIFAOB.Models;

namespace WC_Draw_FIFAOB.Data
{
    public static class DbInitializer
    {
        public static void Initialize(WorldCupDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Teams.Any()) return; // if BD contains already the data

            var teams = new List<Team>
            {
                // Pot 1
                new() { Name = "Brazil", Confederation = Confederation.CONCACAF, PotNumber = 1 },
                new() { Name = "Argentina", Confederation = Confederation.CONCACAF, PotNumber = 1 },
                new() { Name = "France", Confederation = Confederation.UEFA, PotNumber = 1 },
                new() { Name = "Spain", Confederation = Confederation.UEFA, PotNumber = 1 },
                new() { Name = "Portugal", Confederation = Confederation.UEFA, PotNumber = 1 },
                new() { Name = "Germany", Confederation = Confederation.UEFA, PotNumber = 1 },
                new() { Name = "England", Confederation = Confederation.UEFA, PotNumber = 1 },
                new() { Name = "Colombia", Confederation = Confederation.CONCACAF, PotNumber = 1 },

                // Pot 2
                new() { Name = "Netherlands", Confederation = Confederation.UEFA, PotNumber = 2 },
                new() { Name = "Morroco", Confederation = Confederation.CAF, PotNumber = 2 },
                new() { Name = "Norway", Confederation = Confederation.UEFA, PotNumber = 2 },
                new() { Name = "Mexico", Confederation = Confederation.CONCACAF, PotNumber = 2 },
                new() { Name = "Japan", Confederation = Confederation.AFC, PotNumber = 2 },
                new() { Name = "Croatia", Confederation = Confederation.UEFA, PotNumber = 2 },
                new() { Name = "Belguim", Confederation = Confederation.UEFA, PotNumber = 2 },
                new() { Name = "Uruguay", Confederation = Confederation.CONCACAF, PotNumber = 2 },

                // Pot 3
                new() { Name = "Swizerland", Confederation = Confederation.UEFA, PotNumber = 3 },
                new() { Name = "Algeria", Confederation = Confederation.CAF, PotNumber = 3 },
                new() { Name = "Australia", Confederation = Confederation.AFC, PotNumber = 3 },
                new() { Name = "Senegal", Confederation = Confederation.CAF, PotNumber = 3 },
                new() { Name = "Nigera", Confederation = Confederation.CAF, PotNumber = 3 },
                new() { Name = "Serbia", Confederation = Confederation.UEFA, PotNumber = 3 },
                new() { Name = "South Corea", Confederation = Confederation.AFC, PotNumber = 3 },
                new() { Name = "USA", Confederation = Confederation.CONCACAF, PotNumber = 3 },

                // Pot 4
                new() { Name = "Poland", Confederation = Confederation.UEFA, PotNumber = 4 },
                new() { Name = "Ivory Cost", Confederation = Confederation.CAF, PotNumber = 4 },
                new() { Name = "Iran", Confederation = Confederation.AFC, PotNumber = 4 },
                new() { Name = "Ghana", Confederation = Confederation.CAF, PotNumber = 4 },
                new() { Name = "Costa Rica", Confederation = Confederation.CONCACAF, PotNumber = 4 },
                new() { Name = "Italy", Confederation = Confederation.UEFA, PotNumber = 4 },
                new() { Name = "Jamaica", Confederation = Confederation.CONCACAF, PotNumber = 4 },
                new() { Name = "Saudi Arabia", Confederation = Confederation.AFC, PotNumber = 2 },
            };

            context.Teams.AddRange(teams);
            context.SaveChanges();
    }
}
