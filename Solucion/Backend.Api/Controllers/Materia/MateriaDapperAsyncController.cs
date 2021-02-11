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
    [Route("api/Materia")]
    [ApiController]
    public class MateriaDapperAsyncController : ControllerBase
    {
        readonly IMateriaDapperRepositoryAsync _materiaDapperRepositoryAsync;
        readonly ILogger<MateriaDapperAsyncController> _logger;
        public MateriaDapperAsyncController(IMateriaDapperRepositoryAsync materiaDapperRepositoryAsync,
            ILogger<MateriaDapperAsyncController> logger)
        {
            _materiaDapperRepositoryAsync = materiaDapperRepositoryAsync;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetMaterias")]
        public async Task<IActionResult> GetMaterias()
        {
            var per = await _materiaDapperRepositoryAsync.GetMateriasBDAsync();

            _logger.LogInformation("Iniciando Controlador");

            return Ok(per);
        }
    }
}
