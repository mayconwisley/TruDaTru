using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
