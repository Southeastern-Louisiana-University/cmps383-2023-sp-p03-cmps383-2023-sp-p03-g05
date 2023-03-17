using SP23.P03.Web.Features.Tickets;

namespace SP23.P03.Web.Features.Ticket;

public class Ticket 
{
    public int Id { get; set; }

    public int startingDestination { get; set; }

    public int endingDestination { get; set; }

    public List<TicketDestination>? TicketDestination { get; set; }
}




