using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.DTOs
{
    public class ColeccionDeRecursos<T>: Recurso where T: Recurso
    {
        public List<T> Valores { get; set; }
    }
}
