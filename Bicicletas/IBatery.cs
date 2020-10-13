using System;
using System.Collections.Generic;
using System.Text;

namespace Bicicletas
{
    interface IBatery
    {
        float cantBatery();
        void cargarBatery(float cant);
    }
}
