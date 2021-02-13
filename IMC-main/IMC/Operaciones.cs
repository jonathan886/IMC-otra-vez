using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Operaciones
    {
        public double Convertidor(double a)
        {
            return a / 2.20;
        }
      
        public double IMC(double a, double b)
        {
            return (a / (b*b))*10000;
        }
    }
}
