public class Cliente{
    public int codigo { get; set; }
    public string razaoSocial { get; set; }
    public string endereco { get; set; }
    public string cnpj { get; set; }
    public string complemento { get; set; }
    public string bairro { get; set; }
    public string cidade { get; set; }
    public string estado { get; set; }
    
    public Cliente(int codigo, string cnpj, string razaoSocial, string endereco, string complemento, string bairro, string estado, string cidade){
        this.codigo = codigo;
	    this.razaoSocial = razaoSocial;
        this.cnpj = cnpj;
	    this.endereco = endereco;
        this.complemento = complemento;
        this.bairro = bairro;
        this.estado = estado;
        this.cidade = cidade;
    }
}
