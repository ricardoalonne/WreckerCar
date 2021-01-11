using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

using PeinWorkWFA;
using PeinCoreWFA;
using PeinCoreWFA.Application;
using System.Media;

namespace WreckerCar
{
    public partial class CommandControl : Form
    {
        public CommandControl() => InitializeComponent();

        private SerialPort puertoArduino; //Se define la instancia de un puerto serial
        private string situacionHumo, situacionFuego, situacionObstaculo, cadena;
        private List<string> vocesSystem = new List<string>();
        private bool IsClosed = false;
        private SpeechSynthesizer voz = new SpeechSynthesizer();
        private Thread hilo;
        private Window window;
        private ControlController controller = new ControlController();

        //protected override CreateParams CreateParams { get { CreateParams cp = base.CreateParams; cp.ExStyle |= 0x02000000; return cp; } }

        private void CommandControl_Load(object sender, EventArgs e){
            window = new Window(this);
            foreach (InstalledVoice voice in voz.GetInstalledVoices()){
                VoiceInfo info = voice.VoiceInfo;
                vocesSystem.Add(info.Name);
            }
            voz.SelectVoice(vocesSystem.ElementAt(0));
            puertoArduino = new SerialPort();
            puertoArduino.PortName = "COM2";
            puertoArduino.BaudRate = 9600;
            puertoArduino.ReadTimeout = 500;
            hilo = new Thread(EscucharSerial);
            hilo.Start();
        }

        private void Button_Cerrar_Click(object sender, EventArgs e) => this.Close();
        private void Button_Minimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void CheckBox_ModoOscuro_CheckedChanged(object sender, EventArgs e) => this.ModeDark = CheckBox_ModoOscuro.Checked;
        private void CheckBox_LucesTraseras_CheckedChanged(object sender, EventArgs e) => this.TaillightsOn = CheckBox_LucesTraseras.Checked;
        private void CheckBox_LucesDelanteras_CheckedChanged(object sender, EventArgs e)  => this.HeadlightsOn = CheckBox_LucesDelanteras.Checked;
        private void Button_Detener_Click(object sender, EventArgs e) => Detener();
        private void Button_Retroceder_Click(object sender, EventArgs e) => Retroceder();
        private void Button_Izquierda_Click(object sender, EventArgs e) => Izquierda();
        private void Button_Derecha_Click(object sender, EventArgs e) => Derecha();
        private void Button_Avanzar_Click(object sender, EventArgs e) => Avanzar();
        private void CheckBox_CamionOnOff_CheckedChanged(object sender, EventArgs e) => TurnOn = CheckBox_CamionOnOff.Checked;

        private void Button_Copiar_Click(object sender, EventArgs e) => Clipboard.SetText(RichTextBox_EntradaSerial.Text);

        private void Button_Limpiar_Click(object sender, EventArgs e){ RichTextBox_EntradaSerial.Clear(); this.cadena = ""; }

        private void Button_GuardarComo_Click(object sender, EventArgs e){
            string documentName = "Entrada Serial " + string.Format("{0:dd-MM-yy}", DateTime.Now);
            PDFGenerator docpdf;
            SaveFileDialog svd = new SaveFileDialog {
                Title = "Documentos - Guardar Como",
                Filter = "Archivo Documentos|*.txt;*.pdf;*.doc;*.docx",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                FileName = documentName,
                AddExtension = true,
            };
            try {
                if (svd.ShowDialog() == DialogResult.OK) {
                    if (svd.FileName.EndsWith(".pdf")){
                        docpdf = new PDFGenerator(RichTextBox_EntradaSerial.Text, svd.FileName);
                        docpdf.Font(RichTextBox_EntradaSerial.Font);
                        docpdf.Landscape(false);
                        docpdf.Print();
                    }
                    else {
                        StreamWriter saveText = new StreamWriter(svd.FileName, false, Encoding.GetEncoding(1252));
                        if (File.Exists(svd.FileName)){
                            saveText.Write(RichTextBox_EntradaSerial.Text);
                            saveText.Flush();
                            saveText.Close();
                        }
                        else{
                            saveText.Write(RichTextBox_EntradaSerial.Text);
                            saveText.Flush();
                            saveText.Close();
                        }
                    }
                }
            } catch(Exception) { }
        }

        private void CommandControl_FormClosing(object sender, FormClosingEventArgs e) {
            hilo.Abort();
            if (puertoArduino.IsOpen) puertoArduino.Close(); 
        }

        private void Panel_BarraDesplazamieto_MouseDown(object sender, MouseEventArgs e) => window.MoveWindow();

        private void Button_EntradaSerial_Click(object sender, EventArgs e){
            controller.DropdownMenuVertical(this, Panel_EntradaSerial, Panel_EntradaSerialContenedor,30,174,24, "ambos");
        }

        #region METODOS
        private void EscucharSerial(){
            while (!IsClosed){
                try{
                    string cadena = puertoArduino.ReadLine();
                    RichTextBox_EntradaSerial.Invoke(new MethodInvoker(
                        delegate{
                            this.cadena += cadena + "\n";
                            RichTextBox_EntradaSerial.Text = this.cadena;
                            RichTextBox_EntradaSerial.SelectionStart = RichTextBox_EntradaSerial.TextLength;
                            RichTextBox_EntradaSerial.ScrollToCaret();
                            string[] datos = cadena.Split('-');
                            if (datos.Length > 2){
                                situacionFuego = datos[0];
                                situacionHumo = datos[1];
                                situacionObstaculo = datos[2];

                                if (situacionFuego == "fval:1"){
                                    Label_DeteccionFlama.BackColor = situacionActiva;
                                    Label_DeteccionFlama.Font = new Font(Label_DeteccionFlama.Font, FontStyle.Bold);
                                    alarmOn = true;

                                    if (headlightOn == true && taillightsOn == true){
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LE;
                                    }
                                    else if (headlightOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LDE;
                                    }
                                    else if (taillightsOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LTE;
                                    }
                                    else{
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LA;
                                    }
                                }
                                if (situacionFuego == "fval:0"){
                                    Label_DeteccionFlama.BackColor = Color.Transparent;
                                    Label_DeteccionFlama.Font = new Font(Label_DeteccionFlama.Font, FontStyle.Regular);
                                    alarmOn = false;

                                    if (headlightOn == true && taillightsOn == true){
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LE;
                                    }
                                    else if (headlightOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LDE;
                                    }
                                    else if (taillightsOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LTE;
                                    }
                                    else{
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LA;
                                    }
                                }

                                if (situacionHumo == "sval:1"){
                                    Label_DeteccionHumo.BackColor = situacionActiva;
                                    Label_DeteccionHumo.Font = new Font(Label_DeteccionHumo.Font, FontStyle.Bold);
                                    alarmOn = true;

                                    if (headlightOn == true && taillightsOn == true){
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LE;
                                    }
                                    else if (headlightOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LDE;
                                    }
                                    else if (taillightsOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LTE;
                                    }
                                    else{
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LA;
                                    }
                                }
                                if (situacionHumo == "sval:0"){
                                    Label_DeteccionHumo.BackColor = Color.Transparent;
                                    Label_DeteccionHumo.Font = new Font(Label_DeteccionHumo.Font, FontStyle.Regular);
                                    alarmOn = false;

                                    if (headlightOn == true && taillightsOn == true){
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LE;
                                    }
                                    else if (headlightOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LDE;
                                    }
                                    else if (taillightsOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LTE;
                                    }
                                    else{
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LA;
                                    }
                                }

                                if (situacionObstaculo == "obst:1"){
                                    Label_DeteccionObstaculos.BackColor = situacionActiva;
                                    Label_DeteccionObstaculos.Font = new Font(Label_DeteccionObstaculos.Font, FontStyle.Bold);
                                    alarmOn = true;

                                    if (headlightOn == true && taillightsOn == true){
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LE_O;
                                    }
                                    else if (headlightOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LDE_O;
                                    }
                                    else if (taillightsOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LTE_O;
                                    }
                                    else{
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LA_O;
                                    }
                                    voz.SpeakAsync("Evadiendo");
                                }
                                if (situacionObstaculo == "obst:0"){
                                    Label_DeteccionObstaculos.BackColor = Color.Transparent;
                                    Label_DeteccionObstaculos.Font = new Font(Label_DeteccionObstaculos.Font, FontStyle.Regular);
                                    alarmOn = false;

                                    if (headlightOn == true && taillightsOn == true){
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LE;
                                    }
                                    else if (headlightOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LDE;
                                    }
                                    else if (taillightsOn) {
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LTE;
                                    }
                                    else{
                                        PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LA;
                                    }
                                    voz.Pause();
                                }
                            }
                        }));
                }
                catch
                {

                }
            }

        }

        private void Detener() { 
            if (encendido){ 
                puertoArduino.Write("z"); //Envia el caracter al puerto del arduino por bluetooth
            }
            else MessageBox.Show("Se debe encender el carro primero.");
        }

        private void Avanzar() { 
            if (encendido){
                puertoArduino.Write("w"); //Envia el caracter al puerto del arduino por bluetooth
            }
            else MessageBox.Show("Se debe encender el carro primero.");
        }

        private void Retroceder() {
            if (encendido){
                puertoArduino.Write("s"); //Envia el caracter al puerto del arduino por bluetooth
                using (var soundPlayer = new SoundPlayer()){
                    soundPlayer.Stream = Properties.Resources.carInReverse;
                    soundPlayer.Play();
                }
            }
            else MessageBox.Show("Se debe encender el carro primero.");
        }

        private void Izquierda() { 
            if (encendido){
                puertoArduino.Write("d"); //Envia el caracter al puerto del arduino por bluetooth
            }
            else MessageBox.Show("Se debe encender el carro primero.");
        }

        private void Derecha() { 
            if (encendido){
                puertoArduino.Write("a"); //Envia el caracter al puerto del arduino por bluetooth
            }
            else MessageBox.Show("Se debe encender el carro primero.");
        }
        #endregion


        #region PROPIEDADES
        private bool modeDark = false, headlightOn = false, taillightsOn = false, alarmOn = false, encendido = false;

        private Color windowColor, titleBar, estadosCamion, textColor, buttonTitlebar, buttonTitlebarMD, buttonTitlebarMO,
            buttonControl, buttonControlMD, buttonControlMO, entradaSerial, buttonEntradaSerial, buttonEntradaSerialMD, 
            buttonEntradaSerialMO, situacionActiva = Color.Aqua, opcionesEntradaSerial;

        public bool ModeDark {
            get => modeDark;
            set {
                modeDark = value;

                if (modeDark) {
                    windowColor = Color.FromArgb(16, 16, 16);
                    titleBar = Color.FromArgb(8, 8, 8);
                    estadosCamion = Color.FromArgb(24, 24, 24);
                    entradaSerial = Color.FromArgb(27, 27, 27);

                    opcionesEntradaSerial = Color.FromArgb(10, 255, 255, 255);
                    buttonEntradaSerial = Color.FromArgb(20, 255, 255, 255);
                    buttonEntradaSerialMD = Color.FromArgb(40, 255, 255, 255);
                    buttonEntradaSerialMO = Color.FromArgb(30, 255, 255, 255);
                    buttonControl = Color.FromArgb(10, 255, 255, 255);
                    buttonControlMD = Color.FromArgb(35, 255, 255, 255);
                    buttonControlMO = Color.FromArgb(25, 255, 255, 255);
                    buttonTitlebarMD = Color.FromArgb(30, 255, 255, 255);
                    buttonTitlebarMO = Color.FromArgb(20, 255, 255, 255);
                    buttonTitlebar = Color.FromArgb(5, 255, 255, 255);
                    textColor = Color.FromArgb(250, 250, 250);

                    CheckBox_ModoOscuro.Image = Properties.Resources.modoClaro;
                }
                else {
                    windowColor = Color.FromArgb(250, 250, 250);
                    titleBar = Color.FromArgb(252, 252, 252);
                    estadosCamion = Color.FromArgb(247, 247, 247);
                    entradaSerial = Color.FromArgb(245, 245, 245);

                    opcionesEntradaSerial = Color.FromArgb(10, 0, 0, 0);
                    buttonEntradaSerial = Color.FromArgb(20, 0, 0, 0);
                    buttonEntradaSerialMD = Color.FromArgb(40, 0, 0, 0);
                    buttonEntradaSerialMO = Color.FromArgb(30, 0, 0, 0);
                    buttonControl = Color.FromArgb(10, 0, 0, 0);
                    buttonControlMD = Color.FromArgb(35, 0, 0, 0);
                    buttonControlMO = Color.FromArgb(25, 0, 0, 0);
                    buttonTitlebarMD = Color.FromArgb(30, 0, 0, 0);
                    buttonTitlebarMO = Color.FromArgb(20, 0, 0, 0);
                    buttonTitlebar = Color.FromArgb(5, 0, 0, 0);
                    textColor = Color.FromArgb(16, 16, 16);

                    CheckBox_ModoOscuro.Image = Properties.Resources.modoOscuro;
                }

                this.BackColor = windowColor;
                this.Panel_BarraTitulo.BackColor = titleBar;

                this.Panel_EstadosCamionAuxilio.BackColor = estadosCamion;

                this.Button_Menu.BackColor =
                this.Button_Minimizar.BackColor =
                this.CheckBox_ModoOscuro.BackColor =
                this.CheckBox_CamionOnOff.BackColor =
                this.CheckBox_CamionOnOff.FlatAppearance.CheckedBackColor =
                this.CheckBox_ModoOscuro.FlatAppearance.CheckedBackColor =
                this.Button_Limpiar.BackColor =
                this.Button_Copiar.BackColor =
                this.Button_GuardarComo.BackColor = buttonTitlebar;

                this.Button_Menu.FlatAppearance.MouseDownBackColor =
                this.Button_Minimizar.FlatAppearance.MouseDownBackColor =
                this.CheckBox_CamionOnOff.FlatAppearance.MouseDownBackColor =
                this.CheckBox_ModoOscuro.FlatAppearance.MouseDownBackColor =
                this.Button_Limpiar.FlatAppearance.MouseDownBackColor =
                this.Button_Copiar.FlatAppearance.MouseDownBackColor =
                this.Button_GuardarComo.FlatAppearance.MouseDownBackColor = buttonTitlebarMD;

                this.Button_Menu.FlatAppearance.MouseOverBackColor =
                this.Button_Minimizar.FlatAppearance.MouseOverBackColor =
                this.CheckBox_CamionOnOff.FlatAppearance.MouseOverBackColor =
                this.CheckBox_ModoOscuro.FlatAppearance.MouseOverBackColor =
                this.Button_Limpiar.FlatAppearance.MouseOverBackColor =
                this.Button_Copiar.FlatAppearance.MouseOverBackColor =
                this.Button_GuardarComo.FlatAppearance.MouseOverBackColor = buttonTitlebarMO;

                this.CheckBox_LucesDelanteras.BackColor =
                this.CheckBox_LucesTraseras.BackColor =
                this.Button_Avanzar.BackColor =
                this.Button_Retroceder.BackColor =
                this.Button_Izquierda.BackColor =
                this.Button_Derecha.BackColor =
                this.Button_Detener.BackColor = buttonControl;

                this.Button_Avanzar.FlatAppearance.MouseOverBackColor =
                this.Button_Retroceder.FlatAppearance.MouseOverBackColor =
                this.Button_Izquierda.FlatAppearance.MouseOverBackColor =
                this.Button_Derecha.FlatAppearance.MouseOverBackColor =
                this.Button_Detener.FlatAppearance.MouseOverBackColor = buttonControlMO;

                this.Button_Avanzar.FlatAppearance.MouseDownBackColor =
                this.Button_Retroceder.FlatAppearance.MouseDownBackColor =
                this.Button_Izquierda.FlatAppearance.MouseDownBackColor =
                this.Button_Derecha.FlatAppearance.MouseDownBackColor =
                this.Button_Detener.FlatAppearance.MouseDownBackColor = buttonControlMD;

                this.Panel_EntradaSerial.BackColor =
                this.RichTextBox_EntradaSerial.BackColor = entradaSerial;

                this.Button_EntradaSerial.BackColor = buttonEntradaSerial;
                this.Button_EntradaSerial.FlatAppearance.MouseOverBackColor = buttonEntradaSerialMO;
                this.Button_EntradaSerial.FlatAppearance.MouseDownBackColor = buttonEntradaSerialMD;

                this.FlowLayoutPanel_OpcionesEntradaSerial.BackColor = opcionesEntradaSerial;

                this.ForeColor = textColor;
            }
        }

        public bool HeadlightsOn {
            get => headlightOn;
            set {
                if (encendido) {
                    headlightOn = value;
                    if (headlightOn) {
                        this.CheckBox_LucesDelanteras.Image = Properties.Resources.luzOn;
                        puertoArduino.Write("p");
                        if (taillightsOn) { //Cuando las luces traseras están encendidas
                            if (alarmOn) this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LE; //Alarma encendida
                            else this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LE; //Alarma apagada
                        }
                        else{
                            if (alarmOn) this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LDE;
                            else this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LDE;
                        }

                    }
                    else{
                        this.CheckBox_LucesDelanteras.Image = Properties.Resources.luzOff;
                        puertoArduino.Write("o");
                        if (taillightsOn) { //Cuando las luces traseras están encendidas
                            if (alarmOn) this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LTE; //Alarma encendida
                            else this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LTE; //Alarma apagada
                        }
                        else{
                            if (alarmOn) this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LA;
                            else this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LA;
                        }
                    }
                }
                else {
                    if (CheckBox_LucesDelanteras.Checked) MessageBox.Show("Para encender las luces delanteras es necesario tener encendido el camión.", "No se encendieron las luces delanteras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.CheckBox_LucesDelanteras.Checked = false;
                }
            }
        }

        public bool TaillightsOn {
            get => taillightsOn;
            set {
                if (encendido) {
                    taillightsOn = value;

                    if (taillightsOn) {
                        this.CheckBox_LucesTraseras.Image = Properties.Resources.luzOn;
                        puertoArduino.Write("i");
                        if (headlightOn) { //Cuando las luces traseras están encendidas
                            if (alarmOn) this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LE; //Alarma encendida
                            else this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LE; //Alarma apagada
                        }
                        else{
                            if (alarmOn) this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LTE;
                            else this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LTE;
                        }

                    }
                    else{
                        this.CheckBox_LucesTraseras.Image = Properties.Resources.luzOff;
                        puertoArduino.Write("u");
                        if (headlightOn) { //Cuando las luces traseras están encendidas
                            if (alarmOn) this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LDE; //Alarma encendida
                            else this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LDE; //Alarma apagada
                        }
                        else{
                            if (alarmOn) this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AE_LA;
                            else this.PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LA;
                        }
                    }
                }
                else {
                    if (CheckBox_LucesTraseras.Checked) MessageBox.Show("Para encender las luces traseras es necesario tener encendido el camión.", "No se encendieron las luces traseras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.CheckBox_LucesTraseras.Checked = false;
                }            
            }
        }

        public bool TurnOn {
            get => encendido;
            set {
                encendido = value;
                if (encendido){
                    if (!puertoArduino.IsOpen) puertoArduino.Open(); //Se abre conexión al puerto
                    MessageBox.Show("Carro Encendido");
                    CheckBox_CamionOnOff.Text = "Apagar";
                    CheckBox_CamionOnOff.Image = Properties.Resources.apagar;
                }
                else{
                    puertoArduino.Write("z");
                    RichTextBox_EntradaSerial.Text = "";
                    this.cadena = "";
                    Label_DeteccionFlama.BackColor = Label_DeteccionHumo.BackColor = Label_DeteccionObstaculos.BackColor = Color.Transparent;
                    puertoArduino.Write("o");
                    CheckBox_LucesDelanteras.Checked = false;
                    puertoArduino.Write("u");
                    CheckBox_LucesTraseras.Checked = false;
                    if (puertoArduino.IsOpen) puertoArduino.Close(); //Se cierra la conexión serial con el arduino
                    MessageBox.Show("Carro Apagado");
                    CheckBox_CamionOnOff.Image = Properties.Resources.enceder;
                    PictureBox_CamionAuxilio.Image = Properties.Resources.carroAuxilio_AA_LA;
                }
            }
        }
        #endregion

        /*
         ----Cambiar botones por swicht
         MEJORAS
         Menu de configuración
         Menu adicional: modoOscuro, cerrar, desconectar, apagar, configuracion, acerca de
         Diseño de logo de WreckerCar
         Habilitar comandos por teclado
         Agregar más sonidos
         Comandos por voz
         */
    }
}
