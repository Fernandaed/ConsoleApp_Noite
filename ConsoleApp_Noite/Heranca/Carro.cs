using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite.Heranca
{
    public class Carro : Veiculo
    {
        public bool CintoSeguranca;
        public bool ArCondicionado;
        public string marcaRadio;
        public string fabricante;

        
        public string ExibirMarca() 
        {
            return "O fabricante deste veículo é: " + fabricante;
        }
    }
}
