

namespace gregslist_dotnet.Services;

public class HousesService
{

  public HousesService(HousesRepository repository)
  {
    _repository = repository;
  }

  private readonly HousesRepository _repository;

  internal List<House> GetAllHouses()
  {
    List<House> houses = _repository.GetAllHouses();
    return houses;
  }

  internal House GetHouseById(int houseId)
  {
    House house = _repository.GetHouseById(houseId);

    if (house == null) throw new Exception($"Invalid house id: {houseId}!");

    return house;
  }
}
