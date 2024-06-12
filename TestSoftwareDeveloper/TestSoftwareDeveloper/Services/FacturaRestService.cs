using TestSoftwareDeveloper.Models;

namespace TestSoftwareDeveloper.Services
{
    public class FacturaRestService
    {
        public Ventas _ventas;

        public FacturaRestService(Ventas ventas)
        {
            _ventas = ventas;
        }

        public async Task<bool> CrearFactura(Factura factura)
        {
            try
            {
                var result = await _ventas.stoteFactura(factura);
                return result;
            }
            catch
            {
                return false;
            }
        }

        public async Task<Factura> ObtenerFacturaPorId(int facturaId)
        {
            try
            {
                var result = await _ventas.findFactutasbyPersona(facturaId);
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
