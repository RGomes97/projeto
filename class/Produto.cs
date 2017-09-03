public class Produto
{   
    public string nome { get; set; }
    public int codigo { get; set; }
    public int quantidade { get; set; }
    public string foto { get; set; }
    public Produto(string nome, int codigo, int quantidade, string foto){
        this.nome = nome;
        this.codigo = codigo;
        this.quantidade = quantidade;
        this.foto = foto;
    }
}