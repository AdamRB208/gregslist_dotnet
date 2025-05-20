

namespace gregslist_dotnet.Repositories;

public class HousesRepository
{

  public HousesRepository(IDbConnection db)
  {
    _db = db;
  }

  private readonly IDbConnection _db;

  internal List<House> GetAllHouses()
  {
    string sql = @"SELECT houses.*, accounts.*
                  FROM houses
                  JOIN accounts ON houses.creator_id = accounts.id;";
    List<House> houses = _db.Query(sql, (House house, Account account) =>
    {
      house.Creator = account;
      return house;
    }).ToList();
    return houses;
  }

  internal House GetHouseById(int houseId)
  {
    string sql = @"SELECT * FROM houses WHERE id = @houseId;";

    House house = _db.Query<House>(sql, new { houseId }).SingleOrDefault();
    return house;
  }
}