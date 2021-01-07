using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace WreckerCar{
    public partial class Control : Form{
        SerialPort puertoArduino; //Se define la instancia de un puerto serial
        bool encendido = false; //variable para verificar que el carro está encendido
        string situacionHumo;
        string situacionFuego;
        string situacionObstaculo;
        bool IsClosed = false;
        string cadena2;

        //Tamaño de pantalla
        
        public Control()
        {
            InitializeComponent();
            puertoArduino = new SerialPort();
            puertoArduino.PortName = "COM2";
            puertoArduino.BaudRate = 9600;
            puertoArduino.ReadTimeout = 500;
            this.Size = new System.Drawing.Size(827, 567);
            panelSerial.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(EscucharSerial);
            Hilo.Start();
        }
        
        private void EscucharSerial(){
            while (!IsClosed){
                try{
                    string cadena = puertoArduino.ReadLine();
                    txtCadena.Invoke(new MethodInvoker(
                        delegate
                        {
                            cadena2 += cadena + "\n";
                            txtCadena.Text = cadena2;
                            txtCadena.SelectionStart = txtCadena.TextLength;
                            txtCadena.ScrollToCaret();
                            string[] datos = cadena.Split('-');
                            if (datos.Length > 2)
                            {
                                situacionFuego = datos[0];
                                situacionHumo = datos[1];
                                situacionObstaculo = datos[2];
                                if (situacionFuego == "fval:1")
                                {
                                    txtFLAMA.Text = "DETECTADO";
                                    txtFLAMA.ForeColor = Color.Red;
                                    txtFLAMA.Font = new Font(txtFLAMA.Font, FontStyle.Bold);
                                }
                                if (situacionFuego == "fval:0")
                                {
                                    txtFLAMA.Text = "SIN DETECTAR";
                                    txtFLAMA.ForeColor = Color.Black;
                                    txtFLAMA.Font = new Font(txtFLAMA.Font, FontStyle.Regular);
                                }
                                if (situacionHumo == "sval:1")
                                {
                                    txtHUMO.ForeColor = Color.Red;
                                    txtHUMO.Text = "DETECTADO";
                                    txtHUMO.Font = new Font(txtFLAMA.Font, FontStyle.Bold);
                                }
                                if (situacionHumo == "sval:0")
                                {
                                    txtHUMO.Text = "SIN DETECTAR";
                                    txtHUMO.ForeColor = Color.Black;
                                    txtHUMO.Font = new Font(txtFLAMA.Font, FontStyle.Regular);
                                }
                                if (situacionObstaculo == "obst:1")
                                {
                                    txtOBSTACULO.ForeColor = Color.Red;
                                    txtOBSTACULO.Text = "DETECTADO";
                                    txtOBSTACULO.Font = new Font(txtFLAMA.Font, FontStyle.Bold);
                                    txtEstadoOBSTACULO.Text = "Evadiendo...";
                                    txtEstadoOBSTACULO.ForeColor = Color.Blue;
                                    txtEstadoOBSTACULO.Font = new Font(txtFLAMA.Font, FontStyle.Bold);
                                }
                                if (situacionObstaculo == "obst:0")
                                {
                                    txtOBSTACULO.Text = "SIN DETECTAR";
                                    txtOBSTACULO.Font = new Font(txtFLAMA.Font, FontStyle.Regular);
                                    txtEstadoOBSTACULO.Text = "";
                                    txtOBSTACULO.ForeColor = Color.Black;
                                }
                            }
                        }));
                }
                catch
                {

                }
            }

        }

        private void button8_Click(object sender, EventArgs e) //SALIR
        {
            if (puertoArduino.IsOpen)
            {
                puertoArduino.Close(); //Se cierra la conexión serial con el arduino
            }
            Application.Exit();
        }

        private void btnAvanzar_MouseDown(object sender, MouseEventArgs e)
        {
            if (encendido)
            {
                puertoArduino.Write("w"); //Envia el caracter al puerto del arduino por bluetooth
            }
            else
            {
                MessageBox.Show("Se debe encender el carro primero.");
            }
        }
        private void btnEncenderCarro_Click(object sender, EventArgs e)
        {
            if (!encendido)
            {
                encendido = true;
                if (!puertoArduino.IsOpen)
                {
                    puertoArduino.Open(); //Se abre conexión al puerto
                }
                MessageBox.Show("Carro Encendido");
                btnEncenderCarro.Text = "APAGAR CARRO";
            }
            else
            {
                puertoArduino.Write("z");
                encendido = false;
                txtCadena.Text = "";
                cadena2 = "";
                txtFLAMA.Text = "No disponible";
                txtHUMO.Text = "No disponible";
                txtOBSTACULO.Text = "No disponible";
                puertoArduino.Write("o");
                isOnLucesDelanteras = false;
                btnLucesDelanteras.Text = "PRENDER LUCES DELANTERAS";
                btnLucesDelanteras.BackColor = Color.LightSlateGray;
                puertoArduino.Write("u");
                isOnLucesTraceras = false;
                btnLucesTraceras.Text = "PRENDER LUCES TRACERAS";
                btnLucesTraceras.BackColor = Color.LightSlateGray;
                if (puertoArduino.IsOpen)
                {
                    puertoArduino.Close(); //Se cierra la conexión serial con el arduino
                }
                MessageBox.Show("Carro Apagado");
                btnEncenderCarro.Text = "ENCENDER CARRO";
            }
            
            
            
        }

        private void btnIzquierda_MouseDown(object sender, MouseEventArgs e)
        {
            if (encendido)
            {
                puertoArduino.Write("a"); //Envia el caracter al puerto del arduino por bluetooth
            }
            else
            {
                MessageBox.Show("Se debe encender el carro primero.");
            }
        }

        private void btnDerecha_MouseDown(object sender, MouseEventArgs e)
        {
            if (encendido)
            {
                puertoArduino.Write("d"); //Envia el caracter al puerto del arduino por bluetooth
            }
            else
            {
                MessageBox.Show("Se debe encender el carro primero.");
            }
        }

        private void btnRetroceder_MouseDown(object sender, MouseEventArgs e)
        {
            if (encendido)
            {
                puertoArduino.Write("s"); //Envia el caracter al puerto del arduino por bluetooth
            }
            else
            {
                MessageBox.Show("Se debe encender el carro primero.");
            }
        }

        private void btnDetener_MouseDown(object sender, MouseEventArgs e)
        {
            if (encendido)
            {
                puertoArduino.Write("z"); //Envia el caracter al puerto del arduino por bluetooth
            }
            else
            {
                MessageBox.Show("Se debe encender el carro primero.");
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (puertoArduino.IsOpen)
            {
                puertoArduino.Close(); //Se cierra la conexión serial con el arduino
            }
            Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
            this.Hide();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Text="";
            cadena2 = "";
        }

        bool isOnLucesDelanteras = false;
        bool isOnLucesTraceras = false;
        private void btnLucesDelanteras_Click(object sender, EventArgs e)
        {
            if (encendido)
            {
                if (!isOnLucesDelanteras)
                {
                    puertoArduino.Write("p");
                    isOnLucesDelanteras = true;
                    btnLucesDelanteras.Text = "APAGAR LUCES DELANTERAS";
                    btnLucesDelanteras.BackColor = Color.Yellow;
                }
                else
                {
                    puertoArduino.Write("o");
                    isOnLucesDelanteras = false;
                    btnLucesDelanteras.Text = "PRENDER LUCES DELANTERAS";
                    btnLucesDelanteras.BackColor = Color.LightSlateGray;
                }
            }
            else
            {
                MessageBox.Show("Se debe encender el carro primero.");
            }

        }

        private void btnLucesTraceras_Click(object sender, EventArgs e)
        {
            if (encendido)
            {
                if (!isOnLucesTraceras)
                {
                    puertoArduino.Write("i");
                    isOnLucesTraceras = true;
                    btnLucesTraceras.Text = "APAGAR LUCES TRACERAS";
                    btnLucesTraceras.BackColor = Color.Yellow;
                }
                else
                {
                    puertoArduino.Write("u");
                    isOnLucesTraceras = false;
                    btnLucesTraceras.Text = "PRENDER LUCES TRACERAS";
                    btnLucesTraceras.BackColor = Color.LightSlateGray;
                }
            }
            else
            {
                MessageBox.Show("Se debe encender el carro primero.");
            }
        }

        bool EntradaSerialisOpen = false;

        //Entrada serial animacion
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 827;
            int y = 567;
            if (!EntradaSerialisOpen)
            {
                EntradaSerialisOpen = true;
                btnEntradaSerial.Text = "Ocultar Entrada Serial";
                this.Size = new System.Drawing.Size(x + 389, y);
                panelSerial.Show();
            }else
            {
                EntradaSerialisOpen = false;
                btnEntradaSerial.Text = "Mostrar Entrada Serial";
                this.Size = new System.Drawing.Size(827, y);
                panelSerial.Hide();
            }
        }
    }
}
