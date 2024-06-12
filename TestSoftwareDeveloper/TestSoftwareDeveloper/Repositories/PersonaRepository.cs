using LiteDB;
using TestSoftwareDeveloper.Interfaces;
using TestSoftwareDeveloper.Models;


namespace TestSoftwareDeveloper.Repositories
{
    public abstract class PersonaRepository : IPersonaRepository
    {
        protected readonly LiteDatabase _dbContext;

        protected PersonaRepository(LiteDatabase context)
        {
            context = new LiteDatabase("myDatabase.db");
            _dbContext = context;
        }

        public async Task<Persona> findPersonaByIndentificador(int id)
        {
            var collection = _dbContext.GetCollection<Persona>("personas");

            return collection.FindById(id);
        }

        public async Task<IEnumerable<Persona>> findPersonas()
        {
            var collection = _dbContext.GetCollection<Persona>("personas");

            return collection.Query().ToList();
        }

        public async Task<bool> storePersona(Persona inPersona)
        {
            var col = _dbContext.GetCollection<Persona>("personas");

            col.Insert(inPersona);

            return true;
        }

        public async Task<bool> deletePersonaByIdenttificador(Persona delPersona)
        {
            var col = _dbContext.GetCollection<Persona>("personas");
            var collection = _dbContext.GetCollection<Factura>("facturas").Query().Where(x => x.IdPersona == delPersona.Id).ToList();
            var collectionDel = _dbContext.GetCollection<Factura>("facturas");

            col.Delete(delPersona.Id);
            foreach(var r in collection)
            {
                collectionDel.Delete(r.Id);
            }

            return true;
        }
    }
}
