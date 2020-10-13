using System;
using System.Collections.Generic;
using System.Text;

namespace Bicicletas
{
    public abstract class Acctions
    {
        protected string type;
        protected void Advance()
        {
            Console.WriteLine(" avanzando .. \n");
        }

        protected void Brake()
        {
            Console.WriteLine(" parando ..\n");
        }
    }
}
