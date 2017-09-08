using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_test.Controllers
{

    [Route("api/produtos")]
    public class ClientesController : Controller
    {
        public static List<Cliente> vetor = new List<Cliente>();
        
        // GET api/values
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return vetor;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            foreach(var i in vetor){
                if(i.codigo == id){
                    return i;
                }
            }
            return vetor[0];
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Cliente> Post([FromBody]Cliente cliente)
        {
            vetor.Add(new Cliente(cliente.codigo, cliente.razaoSocial, cliente.cnpj, cliente.endereco, cliente.complemento, cliente.bairro, cliente.estado, cliente.cidade));
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
