using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Dados_Hotel
{
    internal class Dados
    {
        public string Cliente {  get; private set; }
        public string Email {  get; private set; }
        public string Cpf {   get; private set; }

        public Dados(string cliente,string email ,string cpf)
        {
            Cliente = cliente;
            Email = email;
            Cpf = cpf;
        }
        public override string ToString() 
        {
            return Cliente +"; " + Email;
        }
    }
}


