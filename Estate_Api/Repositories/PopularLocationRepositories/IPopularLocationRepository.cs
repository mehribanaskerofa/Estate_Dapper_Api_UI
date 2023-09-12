using Estate_Api.Dtos.PopularLocationDtos;

namespace Estate_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
    }
}
