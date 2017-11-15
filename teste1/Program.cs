using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new TesteContext())
            {
                var cliente = new ClientePessoaJuridica 
                {
                    razaoSocial = "Loja do seu Joao",
                    endereco = "Rua 2",
                    cep = "71111-010",
                    complemento = "Loja 8, 2o andar",
                    bairro = "centro",
                    cidade = "Brasilandia",
                    estado = "MS",
                    tel1 = "(67) 1234-5678",
                    tel2 = "(67) 4321-5678",
                    tel3 = "(67) 4312-5678",
                    contato = "Jorge",
                    dataCadastro = "11/03/1979",
                    cnpj = "321.321.3210001-32",
                    inscricaoEstadual = "321.321.321.321-123"
                };
                context.Add(cliente);
                context.SaveChanges();
            }
        }
    }
}
