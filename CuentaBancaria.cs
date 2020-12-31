﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco1
{
    class CuentaBancaria
    {
        //Atributos
        private string nombreApellido;
        private double saldoActual;

        private List<string> movimientos = new List<string>();

        private DateTime date;
        private string[] transaccion = { "deposito","retiro"};
        private double monto;

        //Comportamientos
        public CuentaBancaria(string n, double s)
        {
            nombreApellido = n;
            saldoActual = s;
        }
        public void depositar(double deposito) //
        {
            saldoActual = saldoActual + deposito;
        }
        public void retirar(double retiro)
        {
            if (saldoActual >= retiro)
            {
                saldoActual = saldoActual - retiro; 
                
            }
        }

        public void ingresarMontor(double monto) //nuestro monto forzado dinamicamente
        {
            this.monto = monto;
        }


        public double mostrarSaldo()
        {
            return saldoActual;
        }
        public string mostrarNombre()
        {
            return nombreApellido;
        }

        public void EventoMovimiento(int transaccion){//number transaccion, tipo
            this.date = DateTime.Now;
            string simbolo = (transaccion == 0) ? "" : "-";
            this.movimientos.Add("fecha:"+this.date + " || " + "Transacciòn: " + this.transaccion[transaccion] + " || $/." + simbolo+this.monto);
        }

        public string publicarMovimientos() {//creado
            string informacion = "";
            foreach (var datos in movimientos)
            {
                informacion += datos+"\n";
            }
            return informacion;
        }


    }
}