using LiteDB;
using TestSoftwareDeveloper.Interfaces;
using TestSoftwareDeveloper.Models;

namespace TestSoftwareDeveloper.Repositories
{
    public abstract class FacturaRepository : IFacturaRepository
    {
        protected readonly LiteDatabase _dbContext;

        protected FacturaRepository(LiteDatabase context)
        {
            context = new LiteDatabase("myDatabase.db");
            _dbContext = context;
        }

        public async Task<Factura> findFactutasbyPersona(int id)
        {
            var collection = _dbContext.GetCollection<Factura>("facturas");

            return collection.FindById(id);
        }

        public async Task<bool> stoteFactura(Factura inFactura)
        {
            var col = _dbContext.GetCollection<Factura>("facturas");

            col.Insert(inFactura);

            return true;

        }
    }
}
