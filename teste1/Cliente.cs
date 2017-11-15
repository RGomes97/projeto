using System.ComponentModel.DataAnnotations;

namespace teste
{
    public class Cliente{
        public int ClienteId { get; set; }
       
        [StringLength(100)]
         public string endereco { get; set; }
        
        [StringLength(15)]
        public string cep { get; set; }
        
        [StringLength(100)]
        public string complemento { get; set; }
        
        [StringLength(50)]
        public string bairro { get; set; }
        
        [StringLength(50)]
        public string cidade { get; set; }
        
        [StringLength(2)]
        public string estado { get; set; }
        
        [StringLength(20)]
        public string tel1 { get; set; }
        
        [StringLength(20)]
        public string tel2 { get; set; }
        
        [StringLength(20)]
        public string tel3 { get; set; }
        
        [StringLength(20)]
        public string contato { get; set; }
        
        [StringLength(20)]
        public string dataCadastro { get; set; }

        [StringLength(100)]
        public string observacao { get; set; }

        [StringLength(100)]
        public string situacaoDeCompra { get; set; }
    }
}