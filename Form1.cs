using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cliente1 = new CuentaBancaria("Lus Mercedez  ", 1200,"1234"); //pin de 4 digitos
            tbUsuario.Text = cliente1.mostrarNombre();
            tbSaldoActual.Text = Convert.ToString(cliente1.mostrarSaldo());
        }

        CuentaBancaria cliente1;
        private void btnDepositar_Click(object sender, EventArgs e)
        {//call method valid()
            //prepararDtaosinformacionMovimientos(0);
            //AddInfoTransferencia(0);
            valid(0);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {//call method valid()
            //prepararDtaosinformacionMovimientos(1);
            //AddInfoTransferencia(1);
            valid(1);
        }
        //method validate registerTransfe.
        public void valid(int opc){
            //code get pin(password) of textPIN 
            if ( cliente1.isEqualsPIN(/*code-getText*/tbPIN.Text) ){
                prepararDtaosinformacionMovimientos(opc);
                AddInfoTransferencia(opc);
                return;
            }
            MessageBox.Show("error:not authorized!");
        }

        //event add info transferencias
        int numberDeposito = 1;
        private void AddInfoTransferencia(int tipo)//0=deposito,1=retiro
        {
            cliente1.EventoMovimiento(tipo);
            rtbHistorialMovimientos.Clear();
            rtbHistorialMovimientos.AppendText(cliente1.publicarMovimientos());
        }
        public void prepararDtaosinformacionMovimientos(int number)
        {
            double a = double.Parse(tbMonto.Text);
            if (number==0) {
                cliente1.depositar(a);
            } else
            {
                cliente1.retirar(a);
            }
            cliente1.ingresarMontor(double.Parse(tbMonto.Text));//refactor
            tbMonto.Clear();//refactor
            tbSaldoActual.Text = Convert.ToString(cliente1.mostrarSaldo());//refactor

            if (number == 0)
            {
                MessageBox.Show("usted ah depositado un monto de $/." + a + "\n"
                           + "saldo total: " + "$/" + cliente1.mostrarSaldo());
                return;
            }
            MessageBox.Show("usted ah retirado un monto de $/." + a);
        }

        

        private void btnCambiarPIN_Click(object sender, EventArgs e)
        {
           string newPin= tbCambiarPIN.Text;
            string oldPin = tbPIN.Text;
           if (cliente1.updatePin(oldPin, newPin))
            {

                MessageBox.Show("Credenciales actualizadas");
                return;
            }

            MessageBox.Show("Credenciales no validas");
        }

        
    }
}
