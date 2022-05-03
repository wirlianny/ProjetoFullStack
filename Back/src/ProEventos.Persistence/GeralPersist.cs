using System.Threading.Tasks;
using ProEventos.Persistence.Contratos;
using Fullstack.Persistence.Contextos;

namespace ProEventos.Persistence
{
    public class GeralPersist : IGeralPersist
    {
        private readonly ProEventosContext _context;

        public GeralPersist(ProEventosContext context){
            _context = context;
        }

        public void Add<T>(T entity) where T: class 
        {
            _context.AddAsync(entity);
        }

        public void Update<T>(T entity) where T : class 
        {
            _context.Update(entity);
        }
        

        public void DeleteRange<T>(T[] entityArray) where T: class 
        {
            _context.RemoveRange(entityArray);
        }    

         public void Delete<T>(T entity) where T: class 
        {
            _context.Remove(entity);
        }   

        public async Task<bool> SaveChangesAsync() {
            return (await _context.SaveChangesAsync()) > 0;
        } 
    }
    
}