using Backend.Core.Entities;
using Backend.Core.Exceptions;
using Backend.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Backend.Api.Controllers
{
    [Route("api/Estudiante")]
    [ApiController]
    public class EstudianteDapperAsyncController : ControllerBase
    {
        readonly IEstudianteDapperRepositoryAsync _personaDapperRepositoryAsync;
        readonly ILogger<EstudianteDapperAsyncController> _logger;
        public EstudianteDapperAsyncController(IEstudianteDapperRepositoryAsync personaDapperRepositoryAsync,
            ILogger<EstudianteDapperAsyncController> logger)
        {
            _personaDapperRepositoryAsync = personaDapperRepositoryAsync;
            _logger = logger;
        }


        [HttpGet]
        [Route("GetEstudiantes")]
        public async Task<IActionResult> GetPersonas()
        {
            var per = await _personaDapperRepositoryAsync.GetEstudiantesBDAsync();

            _logger.LogInformation("Iniciando Controlador");
            try
            {
                for (int i = 0; i < 11; i++)
                {
                    if (i == 11)
                    {
                        throw new Exception("Lanzando Excepcion");
                    }
                    else
                    {
                        _logger.LogInformation("El Valor de i es {ContadorVariable}", i);
                    }
                }
            }
            catch (Exception err)
            {
                _logger.LogError(err, "Excepcion Capturada");
                throw new BussinesException(err.Message);
            }

            return Ok(per);
        }


        [HttpPost]
        [Route("AddEstudiante")]
        public async Task<IActionResult> PostPersona(Estudiante persona)
        {
            var per = await _personaDapperRepositoryAsync.AddEstudianteAsync(persona);
            return Ok(per);
        }
    }
}
