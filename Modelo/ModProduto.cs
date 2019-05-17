namespace Modelo
{
    public class ModProduto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public char Ativo { get; set; }
        public ModMarca Marca { get; set; }
    }
}
