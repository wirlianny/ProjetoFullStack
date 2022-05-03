using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        
        //EVENTOS

        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);

        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);

        Task<Evento> GetAllEventoByIdAsync(int EventoId, bool includePalestrantes);
        


    }
}