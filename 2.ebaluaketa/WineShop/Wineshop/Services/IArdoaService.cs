using Wineshop.Models;

namespace Wineshop.Services
{
    public interface IArdoaService
    {
        Task<IList<ArdoaUpeltegi>> GetMota(int id);
        //Task<IList<Ardoa>> GetArdoak(int id);
    }
}
