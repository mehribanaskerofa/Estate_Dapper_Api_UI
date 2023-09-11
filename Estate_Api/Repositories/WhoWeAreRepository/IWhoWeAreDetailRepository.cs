using Estate_Api.Dtos.WhoWeAre;
using Estate_Api.Dtos.WhoWeAreDetailDtos;

namespace Estate_Api.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto whoWeAreDetailDto);
        void DeleteWhoWeAreDetail(int id);
        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto whoWeAreDetailDto);
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
    }
}
