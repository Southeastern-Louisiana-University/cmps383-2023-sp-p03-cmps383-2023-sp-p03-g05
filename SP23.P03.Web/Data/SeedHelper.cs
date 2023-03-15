using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SP23.P03.Web.Features.Authorization;
using SP23.P03.Web.Features.Ticket;
using SP23.P03.Web.Features.TrainStations;

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
                    startingDestination = 1,
                    endingDestination = 3
                });
    }

        private static async Task AddTrainStation(DataContext dataContext)
    {
        var trainStations = dataContext.Set<TrainStation>();

        if (await trainStations.AnyAsync())
        {
            return;
        }

       
        dataContext.Set<TrainStation>()
                .Add(new TrainStation
                {
                    Name = "Hammond",
                    Address = "1234 Place st"
                });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Meridian",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Laurel",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Hattiesburg",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Mobile",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Biloxi",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Slidell",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "New Orleans",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Picayune",
                  Address = "1234 Place st"
              });


        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Yazoo City",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Jackson",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Hazelhurst",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "BrookHaven",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "McComb",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Hammond",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Baton Rouge",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Schriever",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "New Iberia",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Lafayette",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Lake Charles",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Beaumont",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Huston",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Galveston",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Prairie View",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Bryan",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Waco",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Nacogdoches",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Shreveport",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Marshall",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Texarkana",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Longview",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Mineola",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Tyler",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Mesquite",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Dallas",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "FortWorth",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Celburne",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Killeen",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Fort Hood",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Temple",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "Austin",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "San Marcos",
                  Address = "1234 Place st"
              });

        dataContext.Set<TrainStation>()
              .Add(new TrainStation
              {
                  Name = "San Antonio",
                  Address = "1234 Place st"
              });
        await dataContext.SaveChangesAsync();
    }
}