namespace WreckerCar
{
    partial class Control
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEncenderCarro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstadoOBSTACULO = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnLucesDelanteras = new System.Windows.Forms.Button();
            this.btnLucesTraceras = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnEntradaSerial = new System.Windows.Forms.Button();
            this.panelSerial = new System.Windows.Forms.Panel();
            this.txtHUMO = new System.Windows.Forms.Label();
            this.txtFLAMA = new System.Windows.Forms.Label();
            this.txtOBSTACULO = new System.Windows.Forms.Label();
            this.panelSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "COCHE ROBOT DE AUXILIO";
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(406, 237);
            this.btnAvanzar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(96, 107);
            this.btnAvanzar.TabIndex = 3;
            this.btnAvanzar.Text = "ADELANTE";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAvanzar_MouseDown);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(509, 352);
            this.btnDerecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(96, 107);
            this.btnDerecha.TabIndex = 4;
            this.btnDerecha.Text = "DERECHA";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDerecha_MouseDown);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(303, 352);
            this.btnIzquierda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(96, 107);
            this.btnIzquierda.TabIndex = 5;
            this.btnIzquierda.Text = "IZQUIERDA";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIzquierda_MouseDown);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(406, 467);
            this.btnRetroceder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(96, 107);
            this.btnRetroceder.TabIndex = 6;
            this.btnRetroceder.Text = "ATRAS";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRetroceder_MouseDown);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(406, 352);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(96, 107);
            this.btnDetener.TabIndex = 7;
            this.btnDetener.Text = "DETENER";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDetener_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(805, 21);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 48);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnEncenderCarro
            // 
            this.btnEncenderCarro.BackColor = System.Drawing.Color.Transparent;
            this.btnEncenderCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncenderCarro.Location = new System.Drawing.Point(17, 621);
            this.btnEncenderCarro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncenderCarro.Name = "btnEncenderCarro";
            this.btnEncenderCarro.Size = new System.Drawing.Size(149, 48);
            this.btnEncenderCarro.TabIndex = 9;
            this.btnEncenderCarro.Text = "ENCENDER CARRO";
            this.btnEncenderCarro.UseVisualStyleBackColor = false;
            this.btnEncenderCarro.Click += new System.EventHandler(this.btnEncenderCarro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Detección de Humo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Detección de Flama: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(432, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Detección de Obstaculo: ";
            // 
            // txtEstadoOBSTACULO
            // 
            this.txtEstadoOBSTACULO.AutoSize = true;
            this.txtEstadoOBSTACULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEstadoOBSTACULO.Location = new System.Drawing.Point(658, 143);
            this.txtEstadoOBSTACULO.Name = "txtEstadoOBSTACULO";
            this.txtEstadoOBSTACULO.Size = new System.Drawing.Size(0, 20);
            this.txtEstadoOBSTACULO.TabIndex = 18;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(16, 14);
            this.txtCadena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCadena.Size = new System.Drawing.Size(409, 581);
            this.txtCadena.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(301, 620);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 48);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnLucesDelanteras
            // 
            this.btnLucesDelanteras.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLucesDelanteras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLucesDelanteras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLucesDelanteras.Location = new System.Drawing.Point(189, 243);
            this.btnLucesDelanteras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLucesDelanteras.Name = "btnLucesDelanteras";
            this.btnLucesDelanteras.Size = new System.Drawing.Size(148, 84);
            this.btnLucesDelanteras.TabIndex = 21;
            this.btnLucesDelanteras.Text = "PRENDER LUCES DELANTERAS";
            this.btnLucesDelanteras.UseVisualStyleBackColor = false;
            this.btnLucesDelanteras.Click += new System.EventHandler(this.btnLucesDelanteras_Click);
            // 
            // btnLucesTraceras
            // 
            this.btnLucesTraceras.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLucesTraceras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLucesTraceras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLucesTraceras.Location = new System.Drawing.Point(563, 248);
            this.btnLucesTraceras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLucesTraceras.Name = "btnLucesTraceras";
            this.btnLucesTraceras.Size = new System.Drawing.Size(148, 78);
            this.btnLucesTraceras.TabIndex = 23;
            this.btnLucesTraceras.Text = "PRENDER LUCES TRASERAS";
            this.btnLucesTraceras.UseVisualStyleBackColor = false;
            this.btnLucesTraceras.Click += new System.EventHandler(this.btnLucesTraceras_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Location = new System.Drawing.Point(663, 21);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(125, 48);
            this.btnDesconectar.TabIndex = 2;
            this.btnDesconectar.Text = "DESCONECTAR";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnEntradaSerial
            // 
            this.btnEntradaSerial.BackColor = System.Drawing.Color.Transparent;
            this.btnEntradaSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradaSerial.Location = new System.Drawing.Point(759, 621);
            this.btnEntradaSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntradaSerial.Name = "btnEntradaSerial";
            this.btnEntradaSerial.Size = new System.Drawing.Size(170, 48);
            this.btnEntradaSerial.TabIndex = 24;
            this.btnEntradaSerial.Text = "Mostrar Entrada Serial";
            this.btnEntradaSerial.UseVisualStyleBackColor = false;
            this.btnEntradaSerial.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSerial
            // 
            this.panelSerial.Controls.Add(this.btnLimpiar);
            this.panelSerial.Controls.Add(this.txtCadena);
            this.panelSerial.Location = new System.Drawing.Point(957, 4);
            this.panelSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSerial.Name = "panelSerial";
            this.panelSerial.Size = new System.Drawing.Size(441, 684);
            this.panelSerial.TabIndex = 25;
            // 
            // txtHUMO
            // 
            this.txtHUMO.AutoSize = true;
            this.txtHUMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHUMO.Location = new System.Drawing.Point(232, 110);
            this.txtHUMO.Name = "txtHUMO";
            this.txtHUMO.Size = new System.Drawing.Size(104, 20);
            this.txtHUMO.TabIndex = 26;
            this.txtHUMO.Text = "No disponible";
            // 
            // txtFLAMA
            // 
            this.txtFLAMA.AutoSize = true;
            this.txtFLAMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFLAMA.Location = new System.Drawing.Point(232, 156);
            this.txtFLAMA.Name = "txtFLAMA";
            this.txtFLAMA.Size = new System.Drawing.Size(104, 20);
            this.txtFLAMA.TabIndex = 27;
            this.txtFLAMA.Text = "No disponible";
            // 
            // txtOBSTACULO
            // 
            this.txtOBSTACULO.AutoSize = true;
            this.txtOBSTACULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOBSTACULO.Location = new System.Drawing.Point(658, 110);
            this.txtOBSTACULO.Name = "txtOBSTACULO";
            this.txtOBSTACULO.Size = new System.Drawing.Size(104, 20);
            this.txtOBSTACULO.TabIndex = 28;
            this.txtOBSTACULO.Text = "No disponible";
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1400, 690);
            this.Controls.Add(this.txtOBSTACULO);
            this.Controls.Add(this.txtFLAMA);
            this.Controls.Add(this.txtHUMO);
            this.Controls.Add(this.panelSerial);
            this.Controls.Add(this.btnEntradaSerial);
            this.Controls.Add(this.btnLucesTraceras);
            this.Controls.Add(this.btnLucesDelanteras);
            this.Controls.Add(this.txtEstadoOBSTACULO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEncenderCarro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSerial.ResumeLayout(false);
            this.panelSerial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEncenderCarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtEstadoOBSTACULO;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnLucesDelanteras;
        private System.Windows.Forms.Button btnLucesTraceras;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnEntradaSerial;
        private System.Windows.Forms.Panel panelSerial;
        private System.Windows.Forms.Label txtHUMO;
        private System.Windows.Forms.Label txtFLAMA;
        private System.Windows.Forms.Label txtOBSTACULO;
    }
}

