using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase24DeMayo
{
    class ImprimirException:Exception
    {
        public string Usuario;
        public string descripcion;
        public string mensaje;

        public ImprimirException(string mensaje):base(mensaje)
        {
            this.mensaje = mensaje;
        }

        public ImprimirException(string mensaje, Exception inner):base(mensaje, inner)
        {
            this.mensaje = mensaje;
        }

        public ImprimirException(string mensaje, string desc, string user):this(mensaje)//Vemos los constrcutores de la clase Exception
        {
            this.descripcion = desc;
            this.Usuario = user;
        }
    }
}
