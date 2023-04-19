using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SP23.P03.Web.Data;
using SP23.P03.Web.Extensions;
using SP23.P03.Web.Features.Authorization;
using SP23.P03.Web.Features.TrainCarts;
using SP23.P03.Web.Features.TrainStations;

namespace SP23.P03.Web.Controllers;

[Route("api/traincarts")]
[ApiController]
public class TrainCartsController : ControllerBase
{
    private readonly DbSet<TrainCart> trainCarts;
    private readonly DataContext dataContext;

    public TrainCartsController(DataContext dataContext)
    {
        this.dataContext = dataContext;
        trainCarts = dataContext.Set<TrainCart>();
    }

    [HttpGet]
    public IQueryable<TrainCartDto> GetAllStations()
    {
        return GetTrainCartDto(trainCarts);
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult<TrainCartDto> GetTrainCartById(int id)
    {
        var result = GetTrainCartDto(trainCarts.Where(x => x.Id == id)).FirstOrDefault();
        if (result == null)
        {
            return NotFound();
        }

        return Ok(result);
    }

    //[HttpPost]
    //[Authorize(Roles = RoleNames.Admin)]
    //public ActionResult<TrainCartDto> CreateTrainCart(TrainCartDto dto)
    //{
    //    if (IsInvalid(dto))
    //    {
    //        return BadRequest();
    //    }

    //    var trainCart = new TrainCart
    //    {
    //        ClassLetter = dto.ClassLetter,
    //        coach = dto.coach,
    //        ManagerId = dto.ManagerId,
    //    };
    //    trainCart.Add(trainCart);

    //    dataContext.SaveChanges();

    //    dto.Id = trainCart.Id;

    //    return CreatedAtAction(nameof(GetTrainCartById), new { id = dto.Id }, dto);
    //}

    //private bool IsInvalid(TrainCartDto dto)
    //{
    //    return string.IsNullOrWhiteSpace(dto.ClassLetter);
              
               
    //}


    private static IQueryable<TrainCartDto> GetTrainCartDto(IQueryable<TrainCart> stations)
    {
        return stations
            .Select(x => new TrainCartDto
            {
                Id = x.Id,
                ClassLetter = x.ClassLetter,
                coach = x.coach,
                firstClass = x.firstClass,
                roomlet = x.roomlet,
                sleeper = x.sleeper, 
                dining = x.dining

               
            });
    }
}

