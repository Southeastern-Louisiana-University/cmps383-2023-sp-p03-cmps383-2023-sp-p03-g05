using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SP23.P03.Web.Features.Authorization;
using SP23.P03.Web.Features.Ticket;
using SP23.P03.Web.Features.TrainStations;
using SP23.P03.Web.Features.Tickets;

namespace SP23.P03.Web.Data;

public static class SeedHelper
{
    public static async Task MigrateAndSeed(IServiceProvider serviceProvider)
    {
        var dataContext = serviceProvider.GetRequiredService<DataContext>();

        await dataContext.Database.MigrateAsync();

        await AddRoles(serviceProvider);
        await AddUsers(serviceProvider);

        await AddTrainStation(dataContext);
        await AddTicket(dataContext);
    }

    private static async Task AddUsers(IServiceProvider serviceProvider)
    {
        const string defaultPassword = "Password123!";
        var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

        if (userManager.Users.Any())
        {
            return;
        }

        var adminUser = new User
        {
            UserName = "galkadi"
        };
        await userManager.CreateAsync(adminUser, defaultPassword);
        await userManager.AddToRoleAsync(adminUser, RoleNames.Admin);

        var bob = new User
        {
            UserName = "bob"
        };
        await userManager.CreateAsync(bob, defaultPassword);
        await userManager.AddToRoleAsync(bob, RoleNames.User);

        var sue = new User
        {
            UserName = "sue"
        };
        await userManager.CreateAsync(sue, defaultPassword);
        await userManager.AddToRoleAsync(sue, RoleNames.User);
    }

    private static async Task AddRoles(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<Role>>();
        if (roleManager.Roles.Any())
        {
            return;
        }
        await roleManager.CreateAsync(new Role
        {
            Name = RoleNames.Admin
        });

        await roleManager.CreateAsync(new Role
        {
            Name = RoleNames.User
        });
    }

    private static async Task AddTicket(DataContext dataContext)
    {
        var tickets = dataContext.Set<Ticket>();

        if (await tickets.AnyAsync())
        {
            return;
        }

        dataContext.Set<Ticket>()
               .Add(new Ticket
               {
                   //StartingDestination = hammond
               });



        await dataContext.SaveChangesAsync();
    }

        private static async Task AddTrainStation(DataContext dataContext)
    {
        var trainStations = dataContext.Set<TrainStation>();

        if (await trainStations.AnyAsync())
        {
            return;
        }

        var hammond = new TrainStation
        {
            Name = "Hammond",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(hammond);

        var meridian = new TrainStation
        {
            Name = "Meridian",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(meridian);

        var laurel = new TrainStation
        {
            Name = "Laurel",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(laurel);

        var hattiesburg = new TrainStation
        {
            Name = "Hattiesburg",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(hattiesburg);


        var mobile = new TrainStation
        {
            Name = "Moblie",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(mobile);

        var boloxi = new TrainStation
        {
            Name = "Boloxi",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(boloxi);

        var slidell = new TrainStation
        {
            Name = "Slidell",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(slidell);

        var newOrleans = new TrainStation
        {
            Name = "New Orleans",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(newOrleans);

        var picayne= new TrainStation
        {
            Name = "Picayne",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(picayne);

        var yazooCity = new TrainStation
        {
            Name = "Yazoo City",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(yazooCity);

        var jackson = new TrainStation
        {
            Name = "Jackson",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(jackson);

        var hazelHurst= new TrainStation
        {
            Name = "HazleHurst",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(hazelHurst);

        var brookHaven = new TrainStation
        {
            Name = "BrookHaven",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(brookHaven);

        var mcComb = new TrainStation
        {
            Name = "McComb",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(mcComb);

        var batonRouge = new TrainStation
        {
            Name = "Baton Rouge",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(batonRouge);

        var schriever = new TrainStation
        {
            Name = "Schriever",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(schriever);

        var newIberia = new TrainStation
        {
            Name = "New Iberia",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(newIberia);

        var lafayette= new TrainStation
        {
            Name = "Lafayette",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(lafayette);


        var lakeCharles= new TrainStation
        {
            Name = "Lake Charles",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(lakeCharles);

        var beaumont = new TrainStation
        {
            Name = "Beaumont",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(beaumont);

        var Huston = new TrainStation
        {
            Name = "Huston",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(Huston);

        var galveston = new TrainStation
        {
            Name = "Galveston",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(galveston);

        var prairieView = new TrainStation
        {
            Name = "Prairie View",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(prairieView);

        var bryan = new TrainStation
        {
            Name = "Bryan",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(bryan);

        var waco = new TrainStation
        {
            Name = "Waco",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(waco);

        var nacogdoches = new TrainStation
        {
            Name = "Nacogdoches",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(nacogdoches);

        var shreveport = new TrainStation
        {
            Name = "Shreveport",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(shreveport);

        var marshall= new TrainStation
        {
            Name = "Marshall",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(marshall);

        var texarkana = new TrainStation
        {
            Name = "Texarkana",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(texarkana);

        var longView = new TrainStation
        {
            Name = "Long View",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(longView);

        var mineola= new TrainStation
        {
            Name = "Mineola",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(mineola);

        var tyler = new TrainStation
        {
            Name = "Tyler",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(tyler);

        var mesquiet = new TrainStation
        {
            Name = "MesQuiet",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(mesquiet);

        var dallas= new TrainStation
          {
              Name = "Dallas",
              Address = "1234 Place st"
          };

        dataContext.Set<TrainStation>()
                .Add(dallas);

        var fortWorth = new TrainStation
        {
            Name = "Fort Worth",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(fortWorth);

        var celburne = new TrainStation
        {
            Name = "Celburne",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(celburne);

        var killeen = new TrainStation
        {
            Name = "Killeen",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(killeen);

        var fortHood = new TrainStation
        {
            Name = "Fort Hood",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(fortHood);

        var temple = new TrainStation
        {
            Name = "Temple",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(temple);

        var austin = new TrainStation
        {
            Name = "Austin",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(austin);

        var sanMarcos = new TrainStation
        {
            Name = "McComb",
            Address = "1234 Place st"
        };

        var sanAntonio = new TrainStation
        {
            Name = "San Antonio",
            Address = "1234 Place st"
        };

        dataContext.Set<TrainStation>()
                .Add(sanAntonio);

        await dataContext.SaveChangesAsync();
    }
}