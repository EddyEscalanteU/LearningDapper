using Backend.Core.Entities;
using Backend.Core.Exceptions;
using Backend.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Api.Controllers
{
    [Route("api/Inscripcion")]
    [ApiController]
    public class InscripcionDapperAsyncController : ControllerBase
    {
        readonly IInscripcionDapperRepositoryAsync _inscripcionDapperRepositoryAsync;
        readonly ILogger<InscripcionDapperAsyncController> _logger;
        public InscripcionDapperAsyncController(IInscripcionDapperRepositoryAsync inscripcionDapperRepositoryAsync,
            ILogger<InscripcionDapperAsyncController> logger)
        {
            _inscripcionDapperRepositoryAsync = inscripcionDapperRepositoryAsync;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetInscripciones")]
        public async Task<IActionResult> GetInscripciones()
        {
            var per = await _inscripcionDapperRepositoryAsync.GetInscripcionesBDAsync();

            _logger.LogInformation("Iniciando Controlador");

            return Ok(per);
        }

        [HttpPost]
        [Route("AddInscripcion")]
        public async Task<IActionResult> AddInscripcionesAsync(Inscripcion inscripcion)
        {
            //?IdMateria=1&IdEstudiante=2612617&Descripcion=123&Monto=10.10&Fecha=10-10-2000
            var per = await _inscripcionDapperRepositoryAsync.AddInscripcionesAsync(inscripcion);
            _logger.LogInformation("Iniciando Controlador");
            return Ok(per);
        }
    }
}
