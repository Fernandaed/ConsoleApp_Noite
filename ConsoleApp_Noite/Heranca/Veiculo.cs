﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite.Heranca
{
    public class Veiculo
    {
        public int numeroAssentos;
        public int numeroPortas;
        public bool temMotor;

        public string ExibirDados()
        {
            if(temMotor == true) 
            {
                return "Com motor, Assentos: " + numeroAssentos + " N° Portas: " + numeroPortas;
            }
            else
            {
                return "Assentos: " + numeroAssentos + " N° Portas: " + numeroPortas;
            }
           
        }
    }

  
}
