using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Operacion
    {
        public ResultadoDeOperacion Suma(int sumandoX, int sumandoY)
        {
            try
            {
                /*se controlan los posibles errores de overflow*/
                if (Int32.MaxValue < sumandoX + sumandoY || Int32.MinValue > sumandoX + sumandoY)
                {
                    ResultadoDeOperacion suma = new ResultadoDeOperacion(0, true, "El valor de la operación se encuentra fuera de los límites de procesamiento de la calculadora");
                    return suma;
                }
                else
                {
                    int resultadoOperacion = sumandoX + sumandoY;
                    ResultadoDeOperacion suma = new ResultadoDeOperacion(resultadoOperacion, false, "");
                    return suma;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public ResultadoDeOperacion Resta(int minuendo, int substraendo)
        {
            try
            {
                if (Int32.MaxValue < minuendo - substraendo || Int32.MinValue > minuendo - substraendo)
                {
                    ResultadoDeOperacion diferencia = new ResultadoDeOperacion(0, true, "El valor de la operación se encuentra fuera de los límites de procesamiento de la calculadora");
                    return diferencia;
                }
                else
                {
                    int resultadoOperacion = minuendo - substraendo;
                    ResultadoDeOperacion diferencia = new ResultadoDeOperacion(resultadoOperacion, false, "");
                    return diferencia;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public ResultadoDeOperacion Multiplicacion(int factorX, int factorY)
        {
            try
            {
                
                if (Int32.MaxValue < factorX * factorY || Int32.MinValue > factorX * factorY)
                {
                    ResultadoDeOperacion producto = new ResultadoDeOperacion(0, true, "El valor de la operación se encuentra fuera de los límites de procesamiento de la calculadora");
                    return producto;
                }
                else
                {
                    int resultadoOperacion = factorX * factorY;
                    ResultadoDeOperacion producto = new ResultadoDeOperacion(resultadoOperacion, false, "");
                    return producto;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ResultadoDeOperacion Division(int dividendo, int divisor)
        {
            try
            {
                if (Int32.MaxValue < dividendo / dividendo || Int32.MinValue > dividendo * dividendo)
                {
                    ResultadoDeOperacion cociente = new ResultadoDeOperacion(0, true, "El valor de la operación se encuentra fuera de los límites de procesamiento de la calculadora");
                    return cociente;
                }
                else
                {
                    int resultadoOperacion = dividendo / dividendo;
                    ResultadoDeOperacion cociente = new ResultadoDeOperacion(resultadoOperacion, false, "");
                    return cociente;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
