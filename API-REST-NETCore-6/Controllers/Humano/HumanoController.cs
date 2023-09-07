using Core.BL.Interfaces;
using Microsoft.AspNetCore.Http;
using Models.API.Request;
using Microsoft.AspNetCore.Mvc;


namespace API_REST_NETCore_6.Controllers.Humano
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanoController : ControllerBase
    {
        #region PROPIEDADES
        /// <summary>
        /// Inicializamos la estancia de la interface
        /// </summary>
        private readonly IHumano _HumanoServices;
        #endregion

        #region CONSTRUCTOR
        public HumanoController(IHumano HumanoServices)
        {
            _HumanoServices = HumanoServices;
        }
        #endregion

        #region METODO

        #region SELECT METODO GET
        /// <summary>
        /// Metodo para busqueda Todo o individual GET
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        //[HttpPost("SELECTHumanoGeneral")]
        //public async Task<IActionResult> SELECTHumanoGeneral([FromBody] HumanoRequestViewModel x)
        //{
        //    var resultado = await _HumanoServices.SELECTHumanoGeneral(x);
        //    return Ok(resultado);
        //
        // GET api/<OperacionMatematicaController>/5/10/15
        [HttpGet("SELECTHumanoGeneral/{intAccion}/{intHumanoKey}")]
        public async Task<IActionResult> SELECTHumanoGeneral (int intAccion, int intHumanoKey)
        {
            var resultado = await _HumanoServices.SELECTHumanoGeneral(intAccion, intHumanoKey);
            return Ok(resultado);
        }

        #endregion

        #region INSERT METODO POST
        /// <summary>
        /// Metodo para insertar POST
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        [HttpPost("CRUDHumanoGeneral/Insert")]
        public async Task<IActionResult> CRUDHumanoGeneral([FromBody] CRUDHumanoRequestViewModel x)
        {
            var resultado = await _HumanoServices.CRUDHumanoGeneral(x);
            return Ok(resultado);
        }
        #endregion

        #region UPDATE METODO PUT
        /// <summary>
        /// Metodo para actualizar PUT
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        [HttpPut("{intHumanoKey}")]
        public async Task<IActionResult> UPDATEHumanoGeneral (int intAccion, int intHumanoKey, [FromBody] CRUDHumanoRequestViewModel x)
        {
            var resultado = await _HumanoServices.UPDATEHumanoGeneral(intAccion, intHumanoKey, x);
            return Ok(resultado);
        }
        #endregion

        #endregion
    }
}
