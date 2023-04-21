using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SP23.P03.Web.Features.Authorization;
using SP23.P03.Web.Features.Ticket;
using SP23.P03.Web.Features.TrainStations;
using SP23.P03.Web.Features.Tickets;
using SP23.P03.Web.Features.TrainCarts;
using SP23.P03.Web.Features.Trains;

namespace SP23.P03.Web.Data;

public static class SeedHelper
{
    public static User bob;
    public static User adminUser;
    public static User sue;
    public static async Task MigrateAndSeed(IServiceProvider serviceProvider)
    {
        var dataContext = serviceProvider.GetRequiredService<DataContext>();

        await dataContext.Database.MigrateAsync();

        await AddRoles(serviceProvider);
        await AddUsers(serviceProvider);

        await AddTrainStationAndTickets(dataContext);
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

        adminUser = new User
        {
            UserName = "galkadi"
        };
        await userManager.CreateAsync(adminUser, defaultPassword);
        await userManager.AddToRoleAsync(adminUser, RoleNames.Admin);

        bob = new User
        {
            UserName = "bob"
        };
        await userManager.CreateAsync(bob, defaultPassword);
        await userManager.AddToRoleAsync(bob, RoleNames.User);

        sue = new User
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

/*        if (await tickets.AnyAsync())
        {
            return;
        }*/



        await dataContext.SaveChangesAsync();
    }

    private static async Task AddTrainStationAndTickets(DataContext dataContext)
    {
        var trainStations = dataContext.Set<TrainStation>();

/*        if (await trainStations.AnyAsync())
        { 
            return;
        }*/

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

        var Ticket1 = new Ticket {
            StartingTrainStation = hammond,
            EndingTrainStation = mcComb,
            Passenger = sue,
            DepartureTime = new DateTimeOffset(2023, 4, 30, 10, 30,0,new TimeSpan(-6,0,0))
        };
        var Ticket2 = new Ticket {
            StartingTrainStation = lafayette,
            EndingTrainStation = newIberia,
            Passenger = bob,
            DepartureTime = new DateTimeOffset(2023, 4, 29, 9, 30, 0, new TimeSpan(-6, 0, 0))

        };
        var Ticket3 = new Ticket {
            StartingTrainStation = lakeCharles,
            EndingTrainStation = batonRouge,
            Passenger = bob,
            DepartureTime = new DateTimeOffset(2023, 5, 10, 12, 00, 0, new TimeSpan(-6, 0, 0))

        };
        var Ticket4 = new Ticket {
            StartingTrainStation = jackson,
            EndingTrainStation = mobile,
            Passenger = adminUser,
            DepartureTime = new DateTimeOffset(2023, 4, 27, 17, 30, 0, new TimeSpan(-6, 0, 0))

        };
        var Ticket5 = new Ticket {
            StartingTrainStation = shreveport,
            EndingTrainStation = dallas,
            Passenger = sue,
            DepartureTime = new DateTimeOffset(2023, 5, 27, 7, 15, 0, new TimeSpan(-6, 0, 0))

        };
        var Ticket6 = new Ticket {
            StartingTrainStation = hattiesburg,
            EndingTrainStation = austin,
            Passenger = sue,
            DepartureTime = new DateTimeOffset(2023, 6, 15, 9, 45, 0, new TimeSpan(-6, 0, 0))

        };

        dataContext.Set<Ticket>().Add(Ticket1);
        dataContext.Set<Ticket>().Add(Ticket2);
        dataContext.Set<Ticket>().Add(Ticket3);
        dataContext.Set<Ticket>().Add(Ticket4);
        dataContext.Set<Ticket>().Add(Ticket5);
        dataContext.Set<Ticket>().Add(Ticket6);


        var ClassA = new TrainCart
        {
            ClassLetter = "A",
            coach = 168,
        };

        dataContext.Set<TrainCart>()
               .Add(ClassA);

        var ClassB = new TrainCart
        {
            ClassLetter = "B",
            coach = 84,
            firstClass = 42
        };

        dataContext.Set<TrainCart>()
                .Add(ClassB);

        var ClassC = new TrainCart
        {
            ClassLetter = "C",
            coach = 42,
            firstClass = 62,
            dining = true
        };

        dataContext.Set<TrainCart>()
                .Add(ClassC);

        var ClassD = new TrainCart
        {
            ClassLetter = "D",
            firstClass = 42,
            dining = true,
            sleeper = 10,
            roomlet = 4

        };
        dataContext.Set<TrainCart>()
               .Add(ClassD);

        var Train1 = new Train
        {

            TrainCart1 = ClassA,
            TrainCart2 = ClassB,
            TrainCart3 = ClassC,
            TrainCart4 = ClassD

        };

        dataContext.Set<Train>()
               .Add(Train1);

        await dataContext.SaveChangesAsync();
    }
}