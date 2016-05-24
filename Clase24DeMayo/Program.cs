using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase24DeMayo
{
    class Program
    {
        static void Main(string[] args)
        {        
            try
            {
                //int NumeroUno = 0;
                //int NumeroDos = 10;
                //float resultado = NumeroDos / NumeroUno;

                //string dato = Console.ReadLine();
                //NumeroDos = int.Parse(dato);

                //Documento.imprimirStatic();

                Portafolio unPorta = new Portafolio();
                Documento unDoc = new Documento();

                unPorta.listado.Add(unDoc);

                //Exception nueva = new Exception();

                unPorta.imprimirPortafolio();
            }
            catch (FormatException ex)//Entra cuando se ingresa un formato distinto al solicitado.
            {
                Console.WriteLine(ex.Message);
            }

            catch (DivideByZeroException ex)//Entra cuando se intenta dividir por cero.
            {
                Console.WriteLine(ex.Message);
            }

            catch (ImprimirException ex)
            {
                Console.WriteLine(ex.Message + ex.Usuario);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
