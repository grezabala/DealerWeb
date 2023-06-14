using DealerWebApp.DealertWeb.Aplication.Dtos;

namespace DealerWebApp.DealertWeb.Aplication.Interfaces.Services
{
    public interface IContactosService
    {
        Task<ContactosDto> Add(ContactosDto dto);
        Task<ContactosDto> Update(int Id, ContactosDto dto);
        Task Delete(int Id);
        Task<IEnumerable<ContactosDto>> GetAll();
        Task<ContactosDto> Get(int Id);
    }
}
