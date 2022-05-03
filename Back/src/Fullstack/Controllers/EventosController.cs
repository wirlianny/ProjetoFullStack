using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fullstack.Persistence;
using Fullstack.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Fullstack.Persistence.Contextos;

namespace Fullstack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {

               
        private readonly ProEventosContext _context;

        public EventosController(ProEventosContext context)
        {
           _context = context;
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _context.Eventos;
        }

         [HttpGet("{id}")]
        public Evento GetById(int id)
        {
           return _context.Eventos. FirstOrDefault(evento => evento.Id == id);
        }

         [HttpPost]
        public string Post()
        {
           return "Exemplo 2";
        }

         [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo 3 = {id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo apagado = {id}";
        }

        

        
    }
}
