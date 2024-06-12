using TestSoftwareDeveloper.Models;
using TestSoftwareDeveloper.Repositories;

namespace TestSoftwareDeveloper.Services
{
    public class Directorio
    {
        public PersonaRepository _persona;

        public Directorio(PersonaRepository persona)
        {
            _persona = persona;
        }

        public async Task<bool> storePersona(Persona personaDetails)
        {
            if (personaDetails != null)
            {
                if (await _persona.storePersona(personaDetails))
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<Persona> findPersonaByIndentificador(int personaId)
        {
            if (personaId > 0)
            {
                var personaDetails = await _persona.findPersonaByIndentificador(personaId);
                if (personaDetails != null)
                {
                    return personaDetails;
                }
            }
            return null;
        }

        public async Task<bool> deletePersonaByIdenttificador(int personaId)
        {
            if (personaId > 0)
            {
                var productDetails = await _persona.findPersonaByIndentificador(personaId);
                if (productDetails != null)
                {
                    if (await _persona.deletePersonaByIdenttificador(productDetails))
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Persona>> findPersonas()
        {
            var productDetailsList = await _persona.findPersonas();
            return productDetailsList;
        }
    }
}
