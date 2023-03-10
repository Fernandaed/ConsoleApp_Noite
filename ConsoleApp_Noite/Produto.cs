using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Produto
    {
        private int Id;
        private decimal Valor;
        private string Descricao;

        public Produto(int id, decimal valor, string descricao) 
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
        
        }

        public string getDescricao() 
        {
            return Descricao;
        }

        public decimal getValor() 
        {
            return Valor;
        }

        public int getId() 
        {
            return Id;
        }

    }
}
