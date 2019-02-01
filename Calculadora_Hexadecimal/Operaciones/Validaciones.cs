using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Validaciones
    {
        public bool DivisionPorCero (long divisor)
        {
            try
            {
                if(divisor == 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }


        
    }
}
