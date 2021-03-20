using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Parcial1_VictorCastro.Controllers
{
    public class SumaController : ApiController
    {
        [HttpGet]
        public int Suma(int a, int b)
        {
            return a + b;
        }

        [HttpPost]
        public int Suma2([FromBody] int a, int b)
        {
            return a + b;
        }

    }
}
