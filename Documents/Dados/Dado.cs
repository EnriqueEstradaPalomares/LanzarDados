using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzarDados
{
    class Dado
    {
        private Random rdn = new Random(); 
        

        public int Lanzar()
        {
            int valor = rdn.Next(1,7);
            if (valor == 1)
                return 1;
            else if (valor == 2)
                return 2;
            else if (valor == 3)
                return 3;
            else if (valor == 4)
                return 4;
            else if (valor == 5)
                return 5;
            else
                return 6;
        }


    }
}
