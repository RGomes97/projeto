using System.ComponentModel.DataAnnotations;

namespace teste
{
   public class ClientePessoaFisica : Cliente {
      [StringLength(100)]
      public string nome { get; set; }

      [StringLength(20)]
      public string cpf { get; set; }

      [StringLength(20)]
      public string rg { get; set; }
   }
}