using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_test.Controllers
{

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public static List<User> vetor = new List<User>();
        
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return vetor;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            String[] teste = {"rubens", "fabio", "takuno"};            
            return teste[id];
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<User> Post([FromBody]User pessoa)
        {
            vetor.Add(new User(pessoa.nome));
            return vetor;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
