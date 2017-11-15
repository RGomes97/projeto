using System.ComponentModel.DataAnnotations;

namespace teste
{
   public class ClientePessoaJuridica : Cliente {
      [StringLength(100)]
      public string razaoSocial { get; set; }   

      [StringLength(20)]
      public string cnpj { get; set; }     

      [StringLength(20)]
      public string inscricaoEstadual { get; set; }
   }
}