using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SP23.P03.Web.Data;
using SP23.P03.Web.Extensions;
using SP23.P03.Web.Features.Authorization;
using SP23.P03.Web.Features.Ticket;
using SP23.P03.Web.Features.Tickets;
using SP23.P03.Web.Features.TrainStations;



namespace SP23.P03.Web.Controllers;

    [Route("api/tickets")]
    [ApiController]


    public class TicketController : ControllerBase
    {

        private readonly DbSet<Ticket> tickets;
        private readonly DataContext dataContext;

        public TicketController(DataContext dataContext)
        {
            this.dataContext = dataContext;
            tickets = dataContext.Set<Ticket>();
        }

        [HttpGet]
        public IQueryable<TicketDto> GetAllTickets()
        {
            return GetTicketDtos(tickets);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<TicketDto> GetStationById(int id)
        {
            var result = GetTicketDtos(tickets.Where(x => x.Id == id)).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            
            return Ok(result);
        }




        private static IQueryable<TicketDto> GetTicketDtos(IQueryable<Ticket> tickets)
        {
        return tickets
            .Select(x => new TicketDto
            {
                Id = x.Id,
                //StartingTrainStationId = x.StartingTrainStationId
                StartingTrainStation = new TrainStationDto
                {
                    Id = x.StartingTrainStation.Id,
                    Name = x.StartingTrainStation.Name,
                    Address = x.StartingTrainStation.Address
                },
                EndingTrainStation = new TrainStationDto
                {
                    Id = x.EndingTrainStation.Id,
                    Name = x.EndingTrainStation.Name,
                    Address = x.EndingTrainStation.Address
                },
            });
        }

    }