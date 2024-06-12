using TestSoftwareDeveloper.Models;

namespace TestSoftwareDeveloper.Interfaces
{
    public interface IFacturaRepository
    {
        Task<Factura> findFactutasbyPersona(int id);
        Task<bool> stoteFactura(Factura entity);
    }
}
