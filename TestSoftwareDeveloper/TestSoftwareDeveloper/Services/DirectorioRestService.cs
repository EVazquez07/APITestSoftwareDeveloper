using TestSoftwareDeveloper.Models;

namespace TestSoftwareDeveloper.Services
{
    public class DirectorioRestService
    {
        public Directorio _directorio;

        public DirectorioRestService(Directorio directorio)
        {
            _directorio = directorio;
        }

        public async Task<bool> CrearPersona(Persona persona)
        {
            try
            {
                var result = await _directorio.storePersona(persona);
                return result;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> EliminarPersona(int personaId)
        {
            try
            {
                var result = await _directorio.deletePersonaByIdenttificador(personaId);
                return result;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<Persona>> ObtenerPersonas()
        {
            try
            {
                var result = await _directorio.findPersonas();
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Persona> ObtenerPesonaPorId(int personaId)
        {
            try
            {
                var result = await _directorio.findPersonaByIndentificador(personaId);
                return result;
            }
            catch
            {
                return null;
            }
        }


    }
}
