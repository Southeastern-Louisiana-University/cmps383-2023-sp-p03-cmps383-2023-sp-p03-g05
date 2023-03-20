using System.Security.Claims;

using SP23.P03.Web.Features.TrainStations;

namespace SP23.P03.Web.Features.Tickets;

public class StartingDestinationDto
{
    public int Id { get; set; }

    public int TrainStationId { get; set; }



    public TrainStationDto? TrainStationDto { get; set; }





}

