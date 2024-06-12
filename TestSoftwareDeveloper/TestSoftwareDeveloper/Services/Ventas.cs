using TestSoftwareDeveloper.Interfaces;
using TestSoftwareDeveloper.Models;
using TestSoftwareDeveloper.Repositories;

namespace TestSoftwareDeveloper.Services
{
    public class Ventas
    {
        public FacturaRepository _facturas;

        public Ventas(FacturaRepository facturas)
        {
            _facturas = facturas;
        }

        public async Task<bool> stoteFactura(Factura facturaDetails)
        {
            if (facturaDetails != null)
            {
                if (await _facturas.stoteFactura(facturaDetails))
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<Factura> findFactutasbyPersona(int facturaId)
        {
            if (facturaId > 0)
            {
                var facturaDetails = await _facturas.findFactutasbyPersona(facturaId);
                if (facturaDetails != null)
                {
                    return facturaDetails;
                }
            }
            return null;
        }
    }
}
