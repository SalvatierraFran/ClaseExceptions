using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase24DeMayo
{
    class Portafolio
    {
        public List<Documento> listado;

        public Portafolio()
        {
            listado = new List<Documento>();
        }

        public void imprimirPortafolio()
        {
            try
            {
                foreach (Documento itemDocumento in listado)
                {
                    itemDocumento.imprimirInstancia();
                }
            }
            catch (ImprimirException ex)
            {
                MiException nueva = new MiException("ImprimirPortafolio()", ex);
                throw nueva;
                //throw ex;
            }

            finally
            {
                Console.WriteLine("Finallly imprimirPortafolio");
            }
        }

        
    }
}
