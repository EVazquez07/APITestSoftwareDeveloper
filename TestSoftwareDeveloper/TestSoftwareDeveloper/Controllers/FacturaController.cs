using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestSoftwareDeveloper.Models;
using TestSoftwareDeveloper.Services;

namespace TestSoftwareDeveloper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        public readonly FacturaRestService _facturaService;
        public FacturaController(FacturaRestService facturaService)
        {
            _facturaService = facturaService;
        }

        /// <summary>
        /// Obtiene datos de una factura
        /// </summary>
        /// <param name="factutaId"></param>
        /// <returns></returns>
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetFacturaById(int factutaId)
        {
            var facturaDetails = await _facturaService.ObtenerFacturaPorId(factutaId);

            if (facturaDetails != null)
            {
                return Ok(facturaDetails);
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Agregar factura
        /// </summary>
        /// <param name="facturaDetails"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateFactura(Factura facturaDetails)
        {
            var isFacturaCreated = await _facturaService.CrearFactura(facturaDetails);

            if (isFacturaCreated)
            {
                return Ok(isFacturaCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
