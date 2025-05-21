

namespace gregslist_dotnet.Services;

public class HousesService
{

  public HousesService(HousesRepository housesRepository)
  {
    _housesRepository = housesRepository;
  }

  private readonly HousesRepository _housesRepository;

  internal List<House> GetAllHouses()
  {
    List<House> houses = _housesRepository.GetAllHouses();
    return houses;
  }

  internal House GetHouseById(int houseId)
  {
    House house = _housesRepository.GetHouseById(houseId);

    if (house == null) throw new Exception($"Invalid house id: {houseId}!");

    return house;
  }

  internal House CreateHouse(House houseData)
  {
    House house = _housesRepository.CreateHouse(houseData);

    return house;
  }

  internal string DeleteHouse(int houseId, string userId)
  {
    House house = GetHouseById(houseId);
    if (house.CreatorId != userId) throw new Exception("This is not your House!");
    _housesRepository.DeleteHouse(houseId);
    return $"Deleted the {house.Description} {house.Year} listing!";
  }
}
