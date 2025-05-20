namespace gregslist_dotnet.Controllers;

[ApiController]
[Route("api/houses")]
public class HousesController : ControllerBase
{

  public HousesController(HousesService housesService)
  {
    _housesService = housesService;
  }

  private readonly HousesService _housesService;

  [HttpGet]
  public ActionResult<List<House>> GetAllHouses()
  {
    try
    {
      List<House> houses = _housesService.GetAllHouses();
      return Ok(houses);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpGet("{houseId}")]

  public ActionResult<House> GetHouseById(int houseId)
  {
    try
    {
      House house = _housesService.GetHouseById(houseId);
      return Ok(house);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }
}