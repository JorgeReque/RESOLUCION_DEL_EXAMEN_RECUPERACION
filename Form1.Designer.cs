namespace Banco1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSaldoActual = new System.Windows.Forms.TextBox();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.rtbHistorialMovimientos = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCambiarPIN = new System.Windows.Forms.Button();
            this.tbCambiarPIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(233, 60);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(138, 20);
            this.tbUsuario.TabIndex = 0;
            // 
            // tbSaldoActual
            // 
            this.tbSaldoActual.Location = new System.Drawing.Point(233, 125);
            this.tbSaldoActual.Name = "tbSaldoActual";
            this.tbSaldoActual.Size = new System.Drawing.Size(137, 20);
            this.tbSaldoActual.TabIndex = 1;
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(233, 188);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(136, 20);
            this.tbMonto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo actutal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(35, 277);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(104, 44);
            this.btnDepositar.TabIndex = 6;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(233, 277);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(104, 44);
            this.btnRetirar.TabIndex = 7;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // rtbHistorialMovimientos
            // 
            this.rtbHistorialMovimientos.Location = new System.Drawing.Point(402, 60);
            this.rtbHistorialMovimientos.Name = "rtbHistorialMovimientos";
            this.rtbHistorialMovimientos.Size = new System.Drawing.Size(404, 148);
            this.rtbHistorialMovimientos.TabIndex = 8;
            this.rtbHistorialMovimientos.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Movimientos";
            // 
            // tbPIN
            // 
            this.tbPIN.Location = new System.Drawing.Point(233, 12);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(136, 20);
            this.tbPIN.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PIN";
            // 
            // btnCambiarPIN
            // 
            this.btnCambiarPIN.Location = new System.Drawing.Point(12, 15);
            this.btnCambiarPIN.Name = "btnCambiarPIN";
            this.btnCambiarPIN.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarPIN.TabIndex = 12;
            this.btnCambiarPIN.Text = "Cambiar PIN";
            this.btnCambiarPIN.UseVisualStyleBackColor = true;
            this.btnCambiarPIN.Click += new System.EventHandler(this.btnCambiarPIN_Click);
            // 
            // tbCambiarPIN
            // 
            this.tbCambiarPIN.Location = new System.Drawing.Point(12, 56);
            this.tbCambiarPIN.Name = "tbCambiarPIN";
            this.tbCambiarPIN.Size = new System.Drawing.Size(86, 20);
            this.tbCambiarPIN.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 400);
            this.Controls.Add(this.tbCambiarPIN);
            this.Controls.Add(this.btnCambiarPIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbHistorialMovimientos);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.tbSaldoActual);
            this.Controls.Add(this.tbUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbSaldoActual;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.RichTextBox rtbHistorialMovimientos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCambiarPIN;
        private System.Windows.Forms.TextBox tbCambiarPIN;
    }
}

