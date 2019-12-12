using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdAndSubstract.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [Route("api/Values")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/Add")]
        public ActionResult<string> Add(string op1, string op2)
        {
            int n1, n2;
            if (int.TryParse(op1, out n1) && int.TryParse(op2, out n2))
            {
                return (n1 + n2).ToString();
            }

            return "Invalid operands";
        }

        [HttpGet]
        [Route("api/Substract")]
        public ActionResult<string> Substract(string op1, string op2)
        {
            int n1, n2;
            if (int.TryParse(op1, out n1) && int.TryParse(op2, out n2))
            {
                return (n1 - n2).ToString();
            }

            return "Invalid operands";
        }
    }
}
