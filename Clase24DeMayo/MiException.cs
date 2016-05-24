using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase24DeMayo
{
    class MiException:Exception
    {
        public MiException(string mensaje, Exception ex):base(mensaje, ex)
        { 
        }
    }
}
