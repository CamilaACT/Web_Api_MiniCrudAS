using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Web_Api_MiniCrud_AS.model.Request;
using Web_Api_MiniCrud_AS.model.Response;

namespace Web_Api_MiniCrud_AS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        [HttpPost]

        [Route("tareasFecha")]
        public Respuesta tareasPorFecha([FromBody] Tarea_fechas fechas)
        {
            Respuesta res = model.proc.p_Tarea.listaMenu(fechas);
            return res;
        }
    }
}
