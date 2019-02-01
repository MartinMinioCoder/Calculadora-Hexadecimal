using Comun;
using Logica;
using Operaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class frm_CalculadoraHexadecimal : Form
    {
        bool recalculaSobreResultadoObetenido = false;





        public frm_CalculadoraHexadecimal()
        {
            InitializeComponent();
        }


        private void btn_suma_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Text != "")
                {
                    lbl_terminoUno.Text = txb_visor.Text;
                    txb_visor.Text = "";
                    lbl_operador.Text = btn_suma.Text;
                    this.txb_visor.Focus();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Text != "")
                {
                    lbl_terminoUno.Text = txb_visor.Text;
                    txb_visor.Text = "";
                    lbl_operador.Text = btn_resta.Text;
                    this.txb_visor.Focus();


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Text != "")
                {
                    lbl_terminoUno.Text = txb_visor.Text;
                    txb_visor.Text = "";
                    lbl_operador.Text = btn_multiplicacion.Text;
                    this.txb_visor.Focus();


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Text != "")
                {
                    lbl_terminoUno.Text = txb_visor.Text;
                    txb_visor.Text = "";
                    lbl_operador.Text = btn_division.Text;
                    this.txb_visor.Focus();


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            try
            {
                /*inicializo el conversor y el operador que me permitiran llevar a delante la logica del calculo*/

                Conversiones conversor = new Conversiones();
                Operacion operador = new Operacion();

                if (txb_visor.Text != "" && lbl_terminoUno.Text != "")
                {
                    lbl_terminoDos.Text = txb_visor.Text; /*se almacena este dato en el caso de luego querer incorporar alguna 
                                                            funcionalidad relacionada al recalculo en base a un resultado ya obtenido*/

                    switch (lbl_operador.Text)
                    {                                   /*se convierte a decimal lo ingresado en el visor. Luego en una variable de tipo
                                                          ResultadoDeOPeracion se guarda el resultado de la operacion, ya sea un error o el total numerico*/
                        case "X":
                            {

                                int factor1 = conversor.Hex_a_Decimal(lbl_terminoUno.Text);
                                int factor2 = conversor.Hex_a_Decimal(lbl_terminoDos.Text);
                                ResultadoDeOperacion producto;
                                producto = operador.Multiplicacion(factor1, factor2);
                                if (!producto.reportaError)
                                {
                                    txb_visor.MaxLength = 32;                                       /* Si no da error la operacion se convierte el resultado a hexadecimal*/
                                    txb_visor.Text = conversor.Decimal_a_Hex(producto.resultado);   /*y se muestra en pantalla*/

                                    lbl_terminoUno.Text = "";
                                    lbl_operador.Text = "";

                                    txb_visor.Enabled = false;
                                    this.ActiveControl = btn_reestablece;
                                    btn_reestablece.Focus();
                                    btn_suma.Enabled = false;
                                    btn_resta.Enabled = false;
                                    btn_division.Enabled = false;
                                    btn_multiplicacion.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show(producto.descripcionError, "Aviso", MessageBoxButtons.OK); /* caso contrario se dispara un aviso*/
                                }

                                break;
                            }

                        case "/":
                            {
                                Validaciones validador = new Validaciones();

                                int dividendo = conversor.Hex_a_Decimal(lbl_terminoUno.Text);
                                int divisor = conversor.Hex_a_Decimal(lbl_terminoDos.Text);
                                if (!validador.DivisionPorCero(divisor))
                                {
                                    ResultadoDeOperacion cociente;
                                    cociente = operador.Division(dividendo, divisor);
                                    if (!cociente.reportaError)
                                    {
                                        txb_visor.MaxLength = 32;
                                        txb_visor.Text = conversor.Decimal_a_Hex(cociente.resultado);
                                        

                                        lbl_terminoUno.Text = "";
                                        lbl_operador.Text = "";

                                        txb_visor.Enabled = false;
                                        this.ActiveControl = btn_reestablece;
                                        btn_reestablece.Focus();
                                        btn_suma.Enabled = false;
                                        btn_resta.Enabled = false;
                                        btn_division.Enabled = false;
                                        btn_multiplicacion.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show(cociente.descripcionError, "Aviso", MessageBoxButtons.OK);
                                    }

                                }
                                else
                                {
                                    txb_visor.Text = "Error division por cero";
                                    txb_visor.Enabled = false;
                                    lbl_terminoUno.Text = "";
                                    lbl_terminoDos.Text = "";
                                    lbl_operador.Text = "";
                                    this.ActiveControl = btn_reestablece;
                                    btn_reestablece.Focus();
                                    btn_suma.Enabled = false;
                                    btn_resta.Enabled = false;
                                    btn_division.Enabled = false;
                                    btn_multiplicacion.Enabled = false;
                                }
                                break;
                            }

                        case "+":
                            {


                                int sumando1 = conversor.Hex_a_Decimal(lbl_terminoUno.Text);
                                int sumando2 = conversor.Hex_a_Decimal(lbl_terminoDos.Text);

                                ResultadoDeOperacion suma = operador.Suma(sumando1, sumando2);


                                if (!suma.reportaError)
                                {
                                    txb_visor.MaxLength = 32;
                                    txb_visor.Text = conversor.Decimal_a_Hex(suma.resultado);

                                   

                                    lbl_terminoUno.Text = "";
                                    lbl_operador.Text = "";

                                    txb_visor.Enabled = false;
                                    this.ActiveControl = btn_reestablece;
                                    btn_reestablece.Focus();
                                    btn_suma.Enabled = false;
                                    btn_resta.Enabled = false;
                                    btn_division.Enabled = false;
                                    btn_multiplicacion.Enabled = false;

                                }
                                else
                                {
                                    MessageBox.Show(suma.descripcionError, "Aviso", MessageBoxButtons.OK);
                                }
                                break;
                            }

                        case "-":
                            {

                                int minuendo = conversor.Hex_a_Decimal(lbl_terminoUno.Text);
                                int sustraendo = conversor.Hex_a_Decimal(lbl_terminoDos.Text);


                                ResultadoDeOperacion diferencia = operador.Resta(minuendo, sustraendo);
                                if (!diferencia.reportaError)
                                {

                                    txb_visor.MaxLength = 32;
                                    txb_visor.Text = conversor.Decimal_a_Hex(diferencia.resultado);

                                   

                                    lbl_terminoUno.Text = "";
                                    lbl_operador.Text = "";

                                    txb_visor.Enabled = false;
                                    this.ActiveControl = btn_reestablece;
                                    btn_reestablece.Focus();
                                    btn_suma.Enabled = false;
                                    btn_resta.Enabled = false;
                                    btn_division.Enabled = false;
                                    btn_multiplicacion.Enabled = false;

                                }
                                else
                                {
                                    MessageBox.Show(diferencia.descripcionError, "Aviso", MessageBoxButtons.OK);
                                }
                                break;
                            }

                        default:
                            break;
                    }
                }

            }


            catch (Exception)
            {

                throw;
            }
        }

        private void btn_reestablece_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_operador.Text = "";
                lbl_terminoUno.Text = "";
                lbl_terminoDos.Text = "";
                txb_visor.Text = "0";
                txb_visor.MaxLength = 8;
                txb_visor.Enabled = true;
                this.txb_visor.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txb_visor_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*permito solamente ingresar ciertos caracteres del teclado*/
            try
            {


                string keyChar = e.KeyChar.ToString().ToUpper();
                if (keyChar == "\b" ||
                    keyChar == ConsoleKey.A.ToString() ||
                    keyChar == ConsoleKey.B.ToString() ||
                    keyChar == ConsoleKey.C.ToString() ||
                    keyChar == ConsoleKey.D.ToString() ||
                    keyChar == ConsoleKey.E.ToString() ||
                    keyChar == ConsoleKey.F.ToString() ||
                    char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                    return;
                }

                e.Handled = true;
                return;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frm_CalculadoraHexadecimal_Load(object sender, EventArgs e)
        {
            try
            {
                txb_visor.CharacterCasing = CharacterCasing.Upper;
                ContextMenuStrip menuContextualInactivo = new ContextMenuStrip();    /* se crea un menu contextual ficticio para invalidar el copiado y pegado de valores
                                                                                        en el visor */
                menuContextualInactivo.Items.Add("");
                menuContextualInactivo.Enabled = false;
                txb_visor.ContextMenuStrip = menuContextualInactivo;


                btn_division.Enabled = false;
                btn_multiplicacion.Enabled = false;
                btn_resta.Enabled = false;
                btn_suma.Enabled = false;
                lbl_terminoUno.Text = "";
                lbl_terminoDos.Text = "";
                lbl_operador.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txb_visor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Text != "" && txb_visor.Text != "NO SE PUEDE DIVIDIR POR CERO" && txb_visor.Enabled)
                {
                    btn_suma.Enabled = true;
                    btn_division.Enabled = true;
                    btn_multiplicacion.Enabled = true;
                    btn_resta.Enabled = true;
                }
                else
                {
                    btn_suma.Enabled = false;
                    btn_division.Enabled = false;
                    btn_multiplicacion.Enabled = false;
                    btn_resta.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("1");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("2");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("3");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("4");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("5");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("6");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("7");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("8");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("9");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("A");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("B");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("C");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("D");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("E");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("F");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_visor.Enabled && txb_visor.Text.Length < 8)
                {

                    txb_visor.AppendText("0");
                    txb_visor.Focus();
                    txb_visor.DeselectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txb_visor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == Keys.Add.ToString())
                    btn_suma_Click(null, null);
                if (e.KeyCode.ToString() == Keys.Subtract.ToString())
                    btn_resta_Click(null, null);
                if (e.KeyCode.ToString() == Keys.Multiply.ToString())
                    btn_multiplicacion_Click(null, null);
                if (e.KeyCode.ToString() == Keys.Divide.ToString())
                    btn_division_Click(null, null);
                if (e.KeyCode.ToString() == Keys.Enter.ToString())
                    btn_igual_Click(null, null);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
