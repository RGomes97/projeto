public class Cliente{
    public int codigo { get; set; }
    public string endereco { get; set; }
    public string cep { get; set; }
    public string complemento { get; set; }
    public string bairro { get; set; }
    public string cidade { get; set; }
    public string estado { get; set; }
    public string tel1 { get; set; }
    public string tel2 { get; set; }
    public string tel3 { get; set; }
    public string contato { get; set; }
    public Vendedor vendedor { get; set; }
    public Representante representante { get; set; }
    public string dataCadastro { get; set; }
}
