using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string Bairro;
        private string CEP;
        private string Cidade;
        private string Estado;

        public Endereco(string rua, string numero, string bairro, string cep, string cidade, string estado) 
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
        }

        public string getRua(string rua) 
        {
            return Rua;
        
        }
         
        public string getNumero(string numero) 
        { 
            return Numero; 
        }

        public string getBairro(string bairro) 
        {
            return Bairro;
        }

        public string getCEP(string cep) 
        {
            return CEP;
        
        }

        public string getCidade(string cidade) 
        {
            return Cidade;
        }

        public string getEstado(string estado) 
        {
            return Estado;
        }

        public void setRua(string rua)
        {  
            Rua = rua; 
        }

        public void setNumero(string numero) 
        {  
            Numero = numero; 
        }

        public void setBairro(string bairro) 
        {  
            Bairro = bairro; 
        }

        public void setCEP(string cep) 
        {
            CEP = cep;
        }

        public void setCidade(string cidade) 
        {
            Cidade = cidade;
        
        }

        public void setEstado(string estado) 
        {
            Estado = estado;
        }


    }
}
