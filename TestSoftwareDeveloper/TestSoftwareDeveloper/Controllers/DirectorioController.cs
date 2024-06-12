using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestSoftwareDeveloper.Models;
using TestSoftwareDeveloper.Services;

namespace TestSoftwareDeveloper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorioController : ControllerBase
    {
        public readonly DirectorioRestService _directorioService;
        public DirectorioController(DirectorioRestService directorioService)
        {
            _directorioService = directorioService;
        }

        /// <summary>
        /// Obtiene las personas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPersonas()
        {
            var personaDetailsList = await _directorioService.ObtenerPersonas();
            if (personaDetailsList == null)
            {
                return NotFound();
            }
            return Ok(personaDetailsList);
        }

        /// <summary>
        /// Obtiene datos de una persona
        /// </summary>
        /// <param name="personaId"></param>
        /// <returns></returns>
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetPersonaById(int personaId)
        {
            var personaDetails = await _directorioService.ObtenerPesonaPorId(personaId);

            if (personaDetails != null)
            {
                return Ok(personaDetails);
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Agregar persona
        /// </summary>
        /// <param name="personaDetails"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreatePersona(Persona personaDetails)
        {
            var isPersonaCreated = await _directorioService.CrearPersona(personaDetails);

            if (isPersonaCreated)
            {
                return Ok(isPersonaCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Delete product by id
        /// </summary>
        /// <param name="personaId"></param>
        /// <returns></returns>
        [HttpDelete("{productId}")]
        public async Task<IActionResult> DeletePersona(int personaId)
        {
            var isPersonaCreated = await _directorioService.EliminarPersona(personaId);

            if (isPersonaCreated)
            {
                return Ok(isPersonaCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
