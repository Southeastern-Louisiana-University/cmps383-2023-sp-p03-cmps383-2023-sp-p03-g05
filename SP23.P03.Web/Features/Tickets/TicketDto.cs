using SP23.P03.Web.Features.Authorization;
using SP23.P03.Web.Features.Tickets;
using SP23.P03.Web.Features.TrainStations;

namespace SP23.P03.Web.Features.Tickets;

public class TicketDto
{
	public int Id { get; set; }

    //public int StartingTrainStationId { get; set; }

    public TrainStationDto StartingTrainStation { get; set; }
    public TrainStationDto EndingTrainStation { get; set; }

    public UserDto Passenger { get; set; }

    public DateTimeOffset DepartureTime { get; set; }

}  


