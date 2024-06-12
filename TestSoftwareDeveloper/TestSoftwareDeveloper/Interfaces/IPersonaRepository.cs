using TestSoftwareDeveloper.Models;

namespace TestSoftwareDeveloper.Interfaces
{
    public interface IPersonaRepository
    {
        Task<Persona> findPersonaByIndentificador(int id);
        Task<IEnumerable<Persona>> findPersonas();
        Task<bool> storePersona(Persona entity);
        Task<bool> deletePersonaByIdenttificador(Persona entity);

    }
}
