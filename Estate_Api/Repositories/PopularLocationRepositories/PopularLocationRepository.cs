using Dapper;
using Estate_Api.Dtos.PopularLocationDtos;
using Estate_Api.Models.DapperContext;

namespace Estate_Api.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository: IPopularLocationRepository
    {
        private readonly Context _context;
    public PopularLocationRepository(Context context)
    {
        _context = context;
    }
    public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
    {
        string query = "Select * From PopularLocation";
        using (var connection = _context.CreateConnection())
        {
            var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
            return values.ToList();
        }
    }
}
}
