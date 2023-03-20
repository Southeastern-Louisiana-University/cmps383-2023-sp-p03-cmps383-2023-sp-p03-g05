using SP23.P03.Web.Features.Tickets;
using SP23.P03.Web.Features.TrainStations;

namespace SP23.P03.Web.Features.Ticket;

public class Ticket 
{
    public int Id { get; set; }

    public int StartingTrainStationId { get; set; }

    public TrainStation? StartingTrainStation { get; set; }
}




//save