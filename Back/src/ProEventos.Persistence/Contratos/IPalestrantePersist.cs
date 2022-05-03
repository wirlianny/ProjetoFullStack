using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        //PALESTRANTES

        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventoss);

        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventoss);

        Task<Palestrante> GetAllPalestranteByIdAsync(int PalestranteId, bool includeEventoss);



    }
}