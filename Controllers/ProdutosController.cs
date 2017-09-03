using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_test.Controllers
{

    [Route("api/produtos")]
    public class ProdutosController : Controller
    {
        public static List<Produto> vetor = new List<Produto>();
        
        // GET api/values
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return vetor;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Produto Get(int id)
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
        public IEnumerable<Produto> Post([FromBody]Produto produto)
        {
            vetor.Add(new Produto(produto.nome, produto.codigo, produto.quantidade, produto.foto));
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
