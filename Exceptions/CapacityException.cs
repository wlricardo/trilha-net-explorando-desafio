using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Exceptions
{
    public class CapacdadeException : Exception
    {
        public CapacdadeException(string mensagem) : base(mensagem) { }
    }
}