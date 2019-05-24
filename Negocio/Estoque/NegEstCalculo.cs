namespace Negocio.Estoque
{
    public class NegEstCalculo
    {
        public decimal ValorTotal(int quantida, decimal valorUnitario)
        {
            return quantida * valorUnitario;
        }
    }
}
