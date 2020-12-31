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
            cliente1 = new CuentaBancaria("Lus Mercedez  ", 1200);
            tbUsuario.Text = cliente1.mostrarNombre();
            tbSaldoActual.Text = Convert.ToString(cliente1.mostrarSaldo());
        }

        CuentaBancaria cliente1;
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            prepararDtaosinformacionMovimientos(0);
            AddInfoTransferencia(0);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            prepararDtaosinformacionMovimientos(1);
            AddInfoTransferencia(1);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
