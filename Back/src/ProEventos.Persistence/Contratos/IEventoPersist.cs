using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fullstack.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        
        //EVENTOS

        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);

        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);

        Task<Evento> GetAllEventoByIdAsync(int eventoId, bool includePalestrantes = false);
        


    }
}