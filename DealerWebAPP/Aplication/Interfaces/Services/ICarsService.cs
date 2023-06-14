using DealerWebApp.DealertWeb.Aplication.Dtos;

namespace DealerWebApp.DealertWeb.Aplication.Interfaces.Services
{
    public interface ICarsService
    {
        Task<CarsDto> Add(CarsDto carsDto);
        Task<CarsDto> Update(int Id, CarsDto carsDto);
        Task Delete(int Id);
        Task<CarsDto> Get(int Id);
        Task<List<CarsDto>> Get();
    }
}
