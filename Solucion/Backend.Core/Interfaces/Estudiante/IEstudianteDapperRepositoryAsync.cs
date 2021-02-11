using Backend.Core.Entities;
using System.Threading.Tasks;

namespace Backend.Core.Interfaces
{
    public interface IEstudianteDapperRepositoryAsync
    {
        Task<object> GetEstudiantesBDAsync();
        Task<bool> AddEstudianteAsync(Estudiante persona);
    }
}