using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Forecast_1._0.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class saludoController : ControllerBase
    {
        [HttpGet]
        public string saludar() {
            return "Hola Bienvenido al API";
        
        }
            
    }
}
