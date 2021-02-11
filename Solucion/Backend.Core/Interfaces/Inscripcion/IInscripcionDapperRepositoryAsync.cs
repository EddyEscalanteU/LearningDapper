
using Backend.Core.Entities;
using System.Threading.Tasks;

namespace Backend.Core.Interfaces
{
    public interface IInscripcionDapperRepositoryAsync
    {
        Task<object> GetInscripcionesBDAsync();

        Task<bool> AddInscripcionesAsync(Inscripcion inscripcion);
    }
}
