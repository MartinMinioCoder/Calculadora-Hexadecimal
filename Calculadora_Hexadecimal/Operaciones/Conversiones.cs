using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Conversiones
    {
        public int Hex_a_Decimal(string termino)
        {
            try
            {
                int valorDecimal = int.Parse(termino, System.Globalization.NumberStyles.HexNumber);
                return valorDecimal;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Decimal_a_Hex(long resultado)
        {
            try
            {
                string valorHex = resultado.ToString("X");
                return valorHex;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}
