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
        private readonly DbSet<TrainStation> stations;
        private readonly DbSet<Ticket> tickets;
        private readonly DataContext dataContext;

        public TicketController(DataContext dataContext)
        {
            this.dataContext = dataContext;
            tickets = dataContext.Set<Ticket>();
            stations = dataContext.Set<TrainStation>();

    }

    [HttpGet]
        public IQueryable<TicketDto> GetAllTickets()
        {
            return GetTicketDtos(tickets);
        }

        [HttpGet]
        [Route("GetAllForUser")]
        public ActionResult<TicketDto> GetAllTicketsForUser() {
            var userId = User.GetCurrentUserId();
            if (userId == null) {
                return Unauthorized();
            }
            return Ok(GetTicketDtos(tickets.Where(x => x.Passenger.Id == userId)));
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<TicketDto> GetTicketById(int id)
        {
            var result = GetTicketDtos(tickets.Where(x => x.Id == id)).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = RoleNames.User)]
        public ActionResult<TicketDto> CreateTicket(TicketDto dto) {
            if (IsInvalid(dto)) {
                return BadRequest();
            }

            var ticket = new Ticket {
                StartingTrainStation = GetTrainStation(dto.StartingTrainStation.Id),
                EndingTrainStation =  GetTrainStation(dto.EndingTrainStation.Id)
            };
            tickets.Add(ticket);

            dataContext.SaveChanges();

            dto.Id = ticket.Id;

            return CreatedAtAction(nameof(GetTicketById), new { id = dto.Id }, dto);
        }




    private static IQueryable<TicketDto> GetTicketDtos(IQueryable<Ticket> tickets)
        {
        return tickets
            .Select(x => new TicketDto
            {
                Id = x.Id,
                StartingTrainStation = new TrainStation
                {
                    Id = x.StartingTrainStation.Id,
                    Name = x.StartingTrainStation.Name,
                    Address = x.StartingTrainStation.Address
                },
                EndingTrainStation = new TrainStation
                {
                    Id = x.EndingTrainStation.Id,
                    Name = x.EndingTrainStation.Name,
                    Address = x.EndingTrainStation.Address
                },
            });
        }
    private TrainStation GetTrainStation(int Id) {
        return stations.Where(x => x.Id == Id).FirstOrDefault();
    }

    private bool IsInvalid(TicketDto dto) {
        return dto.StartingTrainStation.Id == null ||
               dto.EndingTrainStation.Id == null;
    }


}