using SP23.P03.Web.Features.TrainCarts;
namespace SP23.P03.Web.Features.Trains;


public class Train
{
    public int Id { get; set; }

    public TrainCart? TrainCart1 { get; set; }


    public TrainCart? TrainCart2 { get; set; }

    public TrainCart? TrainCart3 { get; set; }

    public TrainCart? TrainCart4 { get; set; }
}

