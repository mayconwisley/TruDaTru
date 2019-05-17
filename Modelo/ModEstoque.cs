namespace Modelo
{
    public class ModEstoque
    {
        public int Id { get; set; }
        public char TipoES { get; set; }
        public int QtdProduto { get; set; }
        public decimal ValorProduto { get; set; }
        public ModCompetencia Competencia { get; set; }
        public ModProduto Produto { get; set; }
    }
}
