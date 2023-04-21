using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SP23.P03.Web.Data;
using SP23.P03.Web.Extensions;
using SP23.P03.Web.Features.Authorization;
using SP23.P03.Web.Features.TrainCarts;
using SP23.P03.Web.Features.Trains;
using SP23.P03.Web.Features.TrainStations;



namespace SP23.P03.Web.Controllers;

[Route("api/trains")]
[ApiController]


public class TrainController : ControllerBase
{

    private readonly DbSet<Train> train;
    private readonly DataContext dataContext;

    public TrainController(DataContext dataContext)
    {
        this.dataContext = dataContext;
        train = dataContext.Set<Train>();
    }

    [HttpGet]
    public IQueryable<TrainDto> GetAllTickets()
    {
        return GetTicketDtos(train);
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult<TrainDto> GetStationById(int id)
    {
        var result = GetTicketDtos(train.Where(x => x.Id == id)).FirstOrDefault();
        if (result == null)
        {
            return NotFound();
        }

        return Ok(result);
    }




    private static IQueryable<TrainDto> GetTicketDtos(IQueryable<Train> trains)
    {
        return trains
            .Select(x => new TrainDto
            {
                Id = x.Id,
                TrainCart1 = new TrainCartDto
                {
                    Id = x.TrainCart1.Id,

                    ClassLetter = x.TrainCart1.ClassLetter,
                    
                    coach=x.TrainCart1.coach,

                    firstClass = x.TrainCart1.firstClass,

                    roomlet = x.TrainCart1.roomlet,

                    sleeper = x.TrainCart1.sleeper,

                    dining = x.TrainCart1.dining

                },
                TrainCart2 = new TrainCartDto
                {
                    Id = x.TrainCart2.Id,

                    ClassLetter = x.TrainCart2.ClassLetter,

                    coach = x.TrainCart2.coach,

                    firstClass = x.TrainCart2.firstClass,

                    roomlet = x.TrainCart2.roomlet,

                    sleeper = x.TrainCart2.sleeper,

                    dining = x.TrainCart2.dining

                },
                TrainCart3 = new TrainCartDto
                {
                    Id = x.TrainCart3.Id,

                    ClassLetter = x.TrainCart3.ClassLetter,

                    coach = x.TrainCart3.coach,

                    firstClass = x.TrainCart3.firstClass,

                    roomlet = x.TrainCart3.roomlet,

                    sleeper = x.TrainCart3.sleeper,

                    dining = x.TrainCart3.dining

                },
                TrainCart4 = new TrainCartDto
                {
                    Id = x.TrainCart4.Id,

                    ClassLetter = x.TrainCart4.ClassLetter,

                    coach = x.TrainCart4.coach,

                    firstClass = x.TrainCart4.firstClass,

                    roomlet = x.TrainCart4.roomlet,

                    sleeper = x.TrainCart4.sleeper,

                    dining = x.TrainCart4.dining

                }



            });

    }
}
