using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Exceptions
{
    public class CapacidadeException : Exception
    {
        public CapacidadeException()
        {
            Console.WriteLine("O número de hóspedes é maior que a capacidade da suíte");
        }
    }
}