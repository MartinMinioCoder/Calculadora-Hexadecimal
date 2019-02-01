using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class ResultadoDeOperacion
    {
        public Int32 resultado { get; set; }
        public bool reportaError { get; set; }
        public string descripcionError { get; set; }

        public ResultadoDeOperacion(Int32 resultadoParametro, bool reportaErrorParametro, string descripcionErrorParametro)
        {
            try
            {
                this.resultado = resultadoParametro;
                this.reportaError = reportaErrorParametro;
                this.descripcionError = descripcionErrorParametro;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
