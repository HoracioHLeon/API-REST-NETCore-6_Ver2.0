using Microsoft.AspNetCore.Mvc;
using Models.API.Request;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_REST_NETCore_6.Controllers.OperacionMatematica
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionMatematicaController : ControllerBase
    {

        #region OPERECIONES MATEMATICAS METODO GET
        // GET api/<OperacionMatematicaController>/5/10/15
        [HttpGet("{TipoOperacion}/{ValoA}/{ValorB}")]
        public string Get(int TipoOperacion, double ValorA, double ValorB)
        {
            double resultado = 0;

            if (TipoOperacion == 1) 
            {
                //SUMA DE 2 VALORES
                resultado = ValorA + ValorB;
            }

            if (TipoOperacion == 2)
            {
                //RESTA DE 2 VALORES
                resultado = ValorA - ValorB;
            }

            if (TipoOperacion == 3)
            {
                //MULTIPLICACION DE 2 VALORES
                resultado = ValorA + ValorB;
            }

            if (TipoOperacion == 4)
            {
                //DIVISION DE 2 VALORES
                resultado = ValorA / ValorB;
            }

            return resultado.ToString();

        }
        #endregion
        #region OPERACIONES MATEMATICAS METODO POST
        // POST api/<OperacionMatematicaController>
        [HttpPost("{TipoOperacion}")]
        public string Post(int TipoOperacion, [FromBody] OperacionMatematicaVariablesViewModel x)
        {
            if (TipoOperacion == 1)
            {
                //SUMA DE 2 VALORES
                x.Resultado = x.ValorA + x.ValorB;
            }

            if (TipoOperacion == 2)
            {
                //RESTA DE 2 VALORES
                x.Resultado = x.ValorA - x.ValorB;
            }

            if (TipoOperacion == 3)
            {
                //MULTIPLICACION DE 2 VALORES
                x.Resultado = x.ValorA * x.ValorB;
            }

            if (TipoOperacion == 4)
            {
                //DIVISION DE 2 VALORES
                x.Resultado = x.ValorA / x.ValorB;
            }

            return x.Resultado.ToString();
        }
        #endregion

    }
}
