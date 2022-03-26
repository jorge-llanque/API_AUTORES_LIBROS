using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Filtros
{
    /// <summary>
    /// This is a custom filter to execute for an endpoint, you can see the response in the 
    /// console when you call endpoint Autor> get
    /// </summary>
    public class MiFiltroDeAccion : IActionFilter
    {
        private readonly ILogger logger;

        public MiFiltroDeAccion(ILogger<MiFiltroDeAccion> logger)
        {
            this.logger = logger;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            logger.LogInformation("Before execute action");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            logger.LogInformation("After execute action");
        }

    }
}
