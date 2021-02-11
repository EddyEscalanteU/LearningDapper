using Backend.Core.Entities;
using System.Threading.Tasks;

namespace Backend.Core.Interfaces
{
    public interface IMateriaDapperRepositoryAsync
    {
        Task<object> GetMateriasBDAsync();
    }
}
