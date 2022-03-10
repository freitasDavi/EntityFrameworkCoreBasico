namespace CursoEFCore.Domain
{
    //[Table("Clientes")]Data anotation para nome diferente de tabela
    public class Cliente
    {
        //[Key] Data anotation pra PK
        public int Id { get; set; }
        //[Required] Data anotation para requerido
        public string Nome { get; set; }
        // [Column("Phone")]Data anotation para nome diferente no banco
        public string Telefone { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
    }
}