
namespace WreckerCar
{
    partial class CommandControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandControl));
            this.Panel_EntradaSerial = new System.Windows.Forms.Panel();
            this.Panel_EntradaSerialContenedor = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_OpcionesEntradaSerial = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Limpiar = new System.Windows.Forms.Button();
            this.Button_Copiar = new System.Windows.Forms.Button();
            this.Button_GuardarComo = new System.Windows.Forms.Button();
            this.RichTextBox_EntradaSerial = new System.Windows.Forms.RichTextBox();
            this.Button_EntradaSerial = new System.Windows.Forms.Button();
            this.Panel_BarraTitulo = new System.Windows.Forms.Panel();
            this.Panel_BarraDesplazamieto = new System.Windows.Forms.Panel();
            this.CheckBox_ModoOscuro = new System.Windows.Forms.CheckBox();
            this.CheckBox_CamionOnOff = new System.Windows.Forms.CheckBox();
            this.Label_TitleApp = new System.Windows.Forms.Label();
            this.Button_Menu = new System.Windows.Forms.Button();
            this.Button_Minimizar = new System.Windows.Forms.Button();
            this.Button_Cerrar = new System.Windows.Forms.Button();
            this.Panel_ContenedorPrincipal = new System.Windows.Forms.Panel();
            this.Panel_CamionAuxilio = new System.Windows.Forms.Panel();
            this.PictureBox_CamionAuxilio = new System.Windows.Forms.PictureBox();
            this.Panel_EstadosCamionAuxilio = new System.Windows.Forms.Panel();
            this.Label_DeteccionFlama = new System.Windows.Forms.Label();
            this.Label_DeteccionObstaculos = new System.Windows.Forms.Label();
            this.Label_DeteccionHumo = new System.Windows.Forms.Label();
            this.Panel_Control = new System.Windows.Forms.Panel();
            this.CheckBox_LucesTraseras = new System.Windows.Forms.CheckBox();
            this.CheckBox_LucesDelanteras = new System.Windows.Forms.CheckBox();
            this.Button_Izquierda = new System.Windows.Forms.Button();
            this.Button_Derecha = new System.Windows.Forms.Button();
            this.Button_Detener = new System.Windows.Forms.Button();
            this.Button_Retroceder = new System.Windows.Forms.Button();
            this.Button_Avanzar = new System.Windows.Forms.Button();
            this.Panel_EntradaSerial.SuspendLayout();
            this.Panel_EntradaSerialContenedor.SuspendLayout();
            this.FlowLayoutPanel_OpcionesEntradaSerial.SuspendLayout();
            this.Panel_BarraTitulo.SuspendLayout();
            this.Panel_ContenedorPrincipal.SuspendLayout();
            this.Panel_CamionAuxilio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CamionAuxilio)).BeginInit();
            this.Panel_EstadosCamionAuxilio.SuspendLayout();
            this.Panel_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_EntradaSerial
            // 
            this.Panel_EntradaSerial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_EntradaSerial.Controls.Add(this.Panel_EntradaSerialContenedor);
            this.Panel_EntradaSerial.Controls.Add(this.Button_EntradaSerial);
            this.Panel_EntradaSerial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_EntradaSerial.Location = new System.Drawing.Point(0, 426);
            this.Panel_EntradaSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_EntradaSerial.Name = "Panel_EntradaSerial";
            this.Panel_EntradaSerial.Size = new System.Drawing.Size(1100, 174);
            this.Panel_EntradaSerial.TabIndex = 0;
            // 
            // Panel_EntradaSerialContenedor
            // 
            this.Panel_EntradaSerialContenedor.BackColor = System.Drawing.Color.Transparent;
            this.Panel_EntradaSerialContenedor.Controls.Add(this.FlowLayoutPanel_OpcionesEntradaSerial);
            this.Panel_EntradaSerialContenedor.Controls.Add(this.RichTextBox_EntradaSerial);
            this.Panel_EntradaSerialContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_EntradaSerialContenedor.Location = new System.Drawing.Point(0, 30);
            this.Panel_EntradaSerialContenedor.Name = "Panel_EntradaSerialContenedor";
            this.Panel_EntradaSerialContenedor.Size = new System.Drawing.Size(1100, 144);
            this.Panel_EntradaSerialContenedor.TabIndex = 4;
            // 
            // FlowLayoutPanel_OpcionesEntradaSerial
            // 
            this.FlowLayoutPanel_OpcionesEntradaSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FlowLayoutPanel_OpcionesEntradaSerial.Controls.Add(this.Button_Limpiar);
            this.FlowLayoutPanel_OpcionesEntradaSerial.Controls.Add(this.Button_Copiar);
            this.FlowLayoutPanel_OpcionesEntradaSerial.Controls.Add(this.Button_GuardarComo);
            this.FlowLayoutPanel_OpcionesEntradaSerial.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowLayoutPanel_OpcionesEntradaSerial.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel_OpcionesEntradaSerial.Name = "FlowLayoutPanel_OpcionesEntradaSerial";
            this.FlowLayoutPanel_OpcionesEntradaSerial.Size = new System.Drawing.Size(30, 144);
            this.FlowLayoutPanel_OpcionesEntradaSerial.TabIndex = 3;
            // 
            // Button_Limpiar
            // 
            this.Button_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Limpiar.FlatAppearance.BorderSize = 0;
            this.Button_Limpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Limpiar.Image = global::WreckerCar.Properties.Resources.limpiar;
            this.Button_Limpiar.Location = new System.Drawing.Point(0, 0);
            this.Button_Limpiar.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Limpiar.Name = "Button_Limpiar";
            this.Button_Limpiar.Size = new System.Drawing.Size(30, 30);
            this.Button_Limpiar.TabIndex = 18;
            this.Button_Limpiar.UseVisualStyleBackColor = false;
            this.Button_Limpiar.Click += new System.EventHandler(this.Button_Limpiar_Click);
            // 
            // Button_Copiar
            // 
            this.Button_Copiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Copiar.FlatAppearance.BorderSize = 0;
            this.Button_Copiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Copiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Copiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Copiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Copiar.Image = global::WreckerCar.Properties.Resources.copiar;
            this.Button_Copiar.Location = new System.Drawing.Point(0, 30);
            this.Button_Copiar.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Copiar.Name = "Button_Copiar";
            this.Button_Copiar.Size = new System.Drawing.Size(30, 30);
            this.Button_Copiar.TabIndex = 20;
            this.Button_Copiar.UseVisualStyleBackColor = false;
            this.Button_Copiar.Click += new System.EventHandler(this.Button_Copiar_Click);
            // 
            // Button_GuardarComo
            // 
            this.Button_GuardarComo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_GuardarComo.FlatAppearance.BorderSize = 0;
            this.Button_GuardarComo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_GuardarComo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_GuardarComo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_GuardarComo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_GuardarComo.Image = global::WreckerCar.Properties.Resources.guardarComo;
            this.Button_GuardarComo.Location = new System.Drawing.Point(0, 60);
            this.Button_GuardarComo.Margin = new System.Windows.Forms.Padding(0);
            this.Button_GuardarComo.Name = "Button_GuardarComo";
            this.Button_GuardarComo.Size = new System.Drawing.Size(30, 30);
            this.Button_GuardarComo.TabIndex = 19;
            this.Button_GuardarComo.UseVisualStyleBackColor = false;
            this.Button_GuardarComo.Click += new System.EventHandler(this.Button_GuardarComo_Click);
            // 
            // RichTextBox_EntradaSerial
            // 
            this.RichTextBox_EntradaSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox_EntradaSerial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RichTextBox_EntradaSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_EntradaSerial.Location = new System.Drawing.Point(42, 9);
            this.RichTextBox_EntradaSerial.Name = "RichTextBox_EntradaSerial";
            this.RichTextBox_EntradaSerial.ReadOnly = true;
            this.RichTextBox_EntradaSerial.Size = new System.Drawing.Size(1044, 126);
            this.RichTextBox_EntradaSerial.TabIndex = 0;
            this.RichTextBox_EntradaSerial.Text = "";
            // 
            // Button_EntradaSerial
            // 
            this.Button_EntradaSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_EntradaSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_EntradaSerial.FlatAppearance.BorderSize = 0;
            this.Button_EntradaSerial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_EntradaSerial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_EntradaSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_EntradaSerial.Location = new System.Drawing.Point(0, 0);
            this.Button_EntradaSerial.Name = "Button_EntradaSerial";
            this.Button_EntradaSerial.Size = new System.Drawing.Size(1100, 30);
            this.Button_EntradaSerial.TabIndex = 2;
            this.Button_EntradaSerial.Text = "Entrada Serial";
            this.Button_EntradaSerial.UseVisualStyleBackColor = false;
            this.Button_EntradaSerial.Click += new System.EventHandler(this.Button_EntradaSerial_Click);
            // 
            // Panel_BarraTitulo
            // 
            this.Panel_BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Panel_BarraTitulo.Controls.Add(this.Panel_BarraDesplazamieto);
            this.Panel_BarraTitulo.Controls.Add(this.CheckBox_ModoOscuro);
            this.Panel_BarraTitulo.Controls.Add(this.CheckBox_CamionOnOff);
            this.Panel_BarraTitulo.Controls.Add(this.Label_TitleApp);
            this.Panel_BarraTitulo.Controls.Add(this.Button_Menu);
            this.Panel_BarraTitulo.Controls.Add(this.Button_Minimizar);
            this.Panel_BarraTitulo.Controls.Add(this.Button_Cerrar);
            this.Panel_BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.Panel_BarraTitulo.Name = "Panel_BarraTitulo";
            this.Panel_BarraTitulo.Size = new System.Drawing.Size(1100, 30);
            this.Panel_BarraTitulo.TabIndex = 1;
            // 
            // Panel_BarraDesplazamieto
            // 
            this.Panel_BarraDesplazamieto.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Panel_BarraDesplazamieto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_BarraDesplazamieto.Location = new System.Drawing.Point(145, 0);
            this.Panel_BarraDesplazamieto.Name = "Panel_BarraDesplazamieto";
            this.Panel_BarraDesplazamieto.Size = new System.Drawing.Size(738, 30);
            this.Panel_BarraDesplazamieto.TabIndex = 17;
            this.Panel_BarraDesplazamieto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_BarraDesplazamieto_MouseDown);
            // 
            // CheckBox_ModoOscuro
            // 
            this.CheckBox_ModoOscuro.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckBox_ModoOscuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckBox_ModoOscuro.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBox_ModoOscuro.Dock = System.Windows.Forms.DockStyle.Right;
            this.CheckBox_ModoOscuro.FlatAppearance.BorderSize = 0;
            this.CheckBox_ModoOscuro.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckBox_ModoOscuro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckBox_ModoOscuro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckBox_ModoOscuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBox_ModoOscuro.Image = global::WreckerCar.Properties.Resources.modoOscuro;
            this.CheckBox_ModoOscuro.Location = new System.Drawing.Point(883, 0);
            this.CheckBox_ModoOscuro.Name = "CheckBox_ModoOscuro";
            this.CheckBox_ModoOscuro.Size = new System.Drawing.Size(40, 30);
            this.CheckBox_ModoOscuro.TabIndex = 16;
            this.CheckBox_ModoOscuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBox_ModoOscuro.UseVisualStyleBackColor = false;
            this.CheckBox_ModoOscuro.CheckedChanged += new System.EventHandler(this.CheckBox_ModoOscuro_CheckedChanged);
            // 
            // CheckBox_CamionOnOff
            // 
            this.CheckBox_CamionOnOff.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckBox_CamionOnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckBox_CamionOnOff.Dock = System.Windows.Forms.DockStyle.Right;
            this.CheckBox_CamionOnOff.FlatAppearance.BorderSize = 0;
            this.CheckBox_CamionOnOff.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckBox_CamionOnOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckBox_CamionOnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckBox_CamionOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBox_CamionOnOff.Image = global::WreckerCar.Properties.Resources.enceder;
            this.CheckBox_CamionOnOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckBox_CamionOnOff.Location = new System.Drawing.Point(923, 0);
            this.CheckBox_CamionOnOff.Name = "CheckBox_CamionOnOff";
            this.CheckBox_CamionOnOff.Size = new System.Drawing.Size(97, 30);
            this.CheckBox_CamionOnOff.TabIndex = 15;
            this.CheckBox_CamionOnOff.Text = "Encender";
            this.CheckBox_CamionOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBox_CamionOnOff.UseVisualStyleBackColor = false;
            this.CheckBox_CamionOnOff.CheckedChanged += new System.EventHandler(this.CheckBox_CamionOnOff_CheckedChanged);
            // 
            // Label_TitleApp
            // 
            this.Label_TitleApp.BackColor = System.Drawing.Color.Transparent;
            this.Label_TitleApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_TitleApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_TitleApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_TitleApp.Location = new System.Drawing.Point(30, 0);
            this.Label_TitleApp.Name = "Label_TitleApp";
            this.Label_TitleApp.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Label_TitleApp.Size = new System.Drawing.Size(115, 30);
            this.Label_TitleApp.TabIndex = 14;
            this.Label_TitleApp.Text = "Comand Control";
            this.Label_TitleApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button_Menu
            // 
            this.Button_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Menu.BackgroundImage")));
            this.Button_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Menu.FlatAppearance.BorderSize = 0;
            this.Button_Menu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Menu.Location = new System.Drawing.Point(0, 0);
            this.Button_Menu.Name = "Button_Menu";
            this.Button_Menu.Size = new System.Drawing.Size(30, 30);
            this.Button_Menu.TabIndex = 13;
            this.Button_Menu.UseVisualStyleBackColor = false;
            // 
            // Button_Minimizar
            // 
            this.Button_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Minimizar.FlatAppearance.BorderSize = 0;
            this.Button_Minimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Minimizar.Image = global::WreckerCar.Properties.Resources.minimizar;
            this.Button_Minimizar.Location = new System.Drawing.Point(1020, 0);
            this.Button_Minimizar.Name = "Button_Minimizar";
            this.Button_Minimizar.Size = new System.Drawing.Size(40, 30);
            this.Button_Minimizar.TabIndex = 12;
            this.Button_Minimizar.UseVisualStyleBackColor = false;
            this.Button_Minimizar.Click += new System.EventHandler(this.Button_Minimizar_Click);
            // 
            // Button_Cerrar
            // 
            this.Button_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Cerrar.FlatAppearance.BorderSize = 0;
            this.Button_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cerrar.Image = global::WreckerCar.Properties.Resources.cerrar;
            this.Button_Cerrar.Location = new System.Drawing.Point(1060, 0);
            this.Button_Cerrar.Name = "Button_Cerrar";
            this.Button_Cerrar.Size = new System.Drawing.Size(40, 30);
            this.Button_Cerrar.TabIndex = 11;
            this.Button_Cerrar.UseVisualStyleBackColor = false;
            this.Button_Cerrar.Click += new System.EventHandler(this.Button_Cerrar_Click);
            // 
            // Panel_ContenedorPrincipal
            // 
            this.Panel_ContenedorPrincipal.Controls.Add(this.Panel_CamionAuxilio);
            this.Panel_ContenedorPrincipal.Controls.Add(this.Panel_Control);
            this.Panel_ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_ContenedorPrincipal.Location = new System.Drawing.Point(0, 30);
            this.Panel_ContenedorPrincipal.Name = "Panel_ContenedorPrincipal";
            this.Panel_ContenedorPrincipal.Size = new System.Drawing.Size(1100, 396);
            this.Panel_ContenedorPrincipal.TabIndex = 2;
            // 
            // Panel_CamionAuxilio
            // 
            this.Panel_CamionAuxilio.BackColor = System.Drawing.Color.Transparent;
            this.Panel_CamionAuxilio.Controls.Add(this.PictureBox_CamionAuxilio);
            this.Panel_CamionAuxilio.Controls.Add(this.Panel_EstadosCamionAuxilio);
            this.Panel_CamionAuxilio.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_CamionAuxilio.Location = new System.Drawing.Point(491, 0);
            this.Panel_CamionAuxilio.Name = "Panel_CamionAuxilio";
            this.Panel_CamionAuxilio.Size = new System.Drawing.Size(609, 396);
            this.Panel_CamionAuxilio.TabIndex = 5;
            // 
            // PictureBox_CamionAuxilio
            // 
            this.PictureBox_CamionAuxilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_CamionAuxilio.Image = global::WreckerCar.Properties.Resources.carroAuxilio_AA_LA;
            this.PictureBox_CamionAuxilio.Location = new System.Drawing.Point(0, 35);
            this.PictureBox_CamionAuxilio.Name = "PictureBox_CamionAuxilio";
            this.PictureBox_CamionAuxilio.Size = new System.Drawing.Size(609, 361);
            this.PictureBox_CamionAuxilio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_CamionAuxilio.TabIndex = 1;
            this.PictureBox_CamionAuxilio.TabStop = false;
            // 
            // Panel_EstadosCamionAuxilio
            // 
            this.Panel_EstadosCamionAuxilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Panel_EstadosCamionAuxilio.Controls.Add(this.Label_DeteccionFlama);
            this.Panel_EstadosCamionAuxilio.Controls.Add(this.Label_DeteccionObstaculos);
            this.Panel_EstadosCamionAuxilio.Controls.Add(this.Label_DeteccionHumo);
            this.Panel_EstadosCamionAuxilio.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_EstadosCamionAuxilio.Location = new System.Drawing.Point(0, 0);
            this.Panel_EstadosCamionAuxilio.Name = "Panel_EstadosCamionAuxilio";
            this.Panel_EstadosCamionAuxilio.Size = new System.Drawing.Size(609, 35);
            this.Panel_EstadosCamionAuxilio.TabIndex = 0;
            // 
            // Label_DeteccionFlama
            // 
            this.Label_DeteccionFlama.BackColor = System.Drawing.Color.Transparent;
            this.Label_DeteccionFlama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_DeteccionFlama.Image = global::WreckerCar.Properties.Resources.fuego;
            this.Label_DeteccionFlama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_DeteccionFlama.Location = new System.Drawing.Point(203, 0);
            this.Label_DeteccionFlama.Name = "Label_DeteccionFlama";
            this.Label_DeteccionFlama.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.Label_DeteccionFlama.Size = new System.Drawing.Size(203, 35);
            this.Label_DeteccionFlama.TabIndex = 1;
            this.Label_DeteccionFlama.Text = "Detección de Flama";
            this.Label_DeteccionFlama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_DeteccionObstaculos
            // 
            this.Label_DeteccionObstaculos.BackColor = System.Drawing.Color.Transparent;
            this.Label_DeteccionObstaculos.Dock = System.Windows.Forms.DockStyle.Right;
            this.Label_DeteccionObstaculos.Image = global::WreckerCar.Properties.Resources.obstaculos;
            this.Label_DeteccionObstaculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_DeteccionObstaculos.Location = new System.Drawing.Point(406, 0);
            this.Label_DeteccionObstaculos.Name = "Label_DeteccionObstaculos";
            this.Label_DeteccionObstaculos.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.Label_DeteccionObstaculos.Size = new System.Drawing.Size(203, 35);
            this.Label_DeteccionObstaculos.TabIndex = 2;
            this.Label_DeteccionObstaculos.Text = "Detección de Obstáculo";
            this.Label_DeteccionObstaculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_DeteccionHumo
            // 
            this.Label_DeteccionHumo.BackColor = System.Drawing.Color.Transparent;
            this.Label_DeteccionHumo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_DeteccionHumo.Image = global::WreckerCar.Properties.Resources.humo;
            this.Label_DeteccionHumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_DeteccionHumo.Location = new System.Drawing.Point(0, 0);
            this.Label_DeteccionHumo.Name = "Label_DeteccionHumo";
            this.Label_DeteccionHumo.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.Label_DeteccionHumo.Size = new System.Drawing.Size(203, 35);
            this.Label_DeteccionHumo.TabIndex = 0;
            this.Label_DeteccionHumo.Text = "Detección de Humo";
            this.Label_DeteccionHumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel_Control
            // 
            this.Panel_Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Control.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Control.Controls.Add(this.CheckBox_LucesTraseras);
            this.Panel_Control.Controls.Add(this.CheckBox_LucesDelanteras);
            this.Panel_Control.Controls.Add(this.Button_Izquierda);
            this.Panel_Control.Controls.Add(this.Button_Derecha);
            this.Panel_Control.Controls.Add(this.Button_Detener);
            this.Panel_Control.Controls.Add(this.Button_Retroceder);
            this.Panel_Control.Controls.Add(this.Button_Avanzar);
            this.Panel_Control.Location = new System.Drawing.Point(12, 18);
            this.Panel_Control.MinimumSize = new System.Drawing.Size(400, 274);
            this.Panel_Control.Name = "Panel_Control";
            this.Panel_Control.Size = new System.Drawing.Size(462, 360);
            this.Panel_Control.TabIndex = 4;
            // 
            // CheckBox_LucesTraseras
            // 
            this.CheckBox_LucesTraseras.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckBox_LucesTraseras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckBox_LucesTraseras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CheckBox_LucesTraseras.FlatAppearance.BorderSize = 0;
            this.CheckBox_LucesTraseras.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.CheckBox_LucesTraseras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.CheckBox_LucesTraseras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.CheckBox_LucesTraseras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBox_LucesTraseras.Image = ((System.Drawing.Image)(resources.GetObject("CheckBox_LucesTraseras.Image")));
            this.CheckBox_LucesTraseras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckBox_LucesTraseras.Location = new System.Drawing.Point(0, 325);
            this.CheckBox_LucesTraseras.Name = "CheckBox_LucesTraseras";
            this.CheckBox_LucesTraseras.Padding = new System.Windows.Forms.Padding(160, 0, 175, 0);
            this.CheckBox_LucesTraseras.Size = new System.Drawing.Size(462, 35);
            this.CheckBox_LucesTraseras.TabIndex = 10;
            this.CheckBox_LucesTraseras.Text = "Luces traseras";
            this.CheckBox_LucesTraseras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBox_LucesTraseras.UseVisualStyleBackColor = false;
            this.CheckBox_LucesTraseras.CheckedChanged += new System.EventHandler(this.CheckBox_LucesTraseras_CheckedChanged);
            // 
            // CheckBox_LucesDelanteras
            // 
            this.CheckBox_LucesDelanteras.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckBox_LucesDelanteras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CheckBox_LucesDelanteras.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckBox_LucesDelanteras.FlatAppearance.BorderSize = 0;
            this.CheckBox_LucesDelanteras.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.CheckBox_LucesDelanteras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.CheckBox_LucesDelanteras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.CheckBox_LucesDelanteras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBox_LucesDelanteras.Image = ((System.Drawing.Image)(resources.GetObject("CheckBox_LucesDelanteras.Image")));
            this.CheckBox_LucesDelanteras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckBox_LucesDelanteras.Location = new System.Drawing.Point(0, 0);
            this.CheckBox_LucesDelanteras.Name = "CheckBox_LucesDelanteras";
            this.CheckBox_LucesDelanteras.Padding = new System.Windows.Forms.Padding(160, 0, 160, 0);
            this.CheckBox_LucesDelanteras.Size = new System.Drawing.Size(462, 35);
            this.CheckBox_LucesDelanteras.TabIndex = 5;
            this.CheckBox_LucesDelanteras.Text = "Luces delanteras";
            this.CheckBox_LucesDelanteras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBox_LucesDelanteras.UseVisualStyleBackColor = false;
            this.CheckBox_LucesDelanteras.CheckedChanged += new System.EventHandler(this.CheckBox_LucesDelanteras_CheckedChanged);
            // 
            // Button_Izquierda
            // 
            this.Button_Izquierda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Izquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Izquierda.FlatAppearance.BorderSize = 0;
            this.Button_Izquierda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Izquierda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Izquierda.Image = global::WreckerCar.Properties.Resources.izquierda;
            this.Button_Izquierda.Location = new System.Drawing.Point(0, 41);
            this.Button_Izquierda.Name = "Button_Izquierda";
            this.Button_Izquierda.Size = new System.Drawing.Size(119, 278);
            this.Button_Izquierda.TabIndex = 9;
            this.Button_Izquierda.UseVisualStyleBackColor = false;
            this.Button_Izquierda.Click += new System.EventHandler(this.Button_Izquierda_Click);
            // 
            // Button_Derecha
            // 
            this.Button_Derecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Derecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Derecha.FlatAppearance.BorderSize = 0;
            this.Button_Derecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Derecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Derecha.Image = global::WreckerCar.Properties.Resources.derecha;
            this.Button_Derecha.Location = new System.Drawing.Point(343, 41);
            this.Button_Derecha.Name = "Button_Derecha";
            this.Button_Derecha.Size = new System.Drawing.Size(119, 278);
            this.Button_Derecha.TabIndex = 5;
            this.Button_Derecha.UseVisualStyleBackColor = false;
            this.Button_Derecha.Click += new System.EventHandler(this.Button_Derecha_Click);
            // 
            // Button_Detener
            // 
            this.Button_Detener.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Detener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Detener.FlatAppearance.BorderSize = 0;
            this.Button_Detener.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Detener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Detener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Detener.Image = global::WreckerCar.Properties.Resources.stop;
            this.Button_Detener.Location = new System.Drawing.Point(125, 125);
            this.Button_Detener.Name = "Button_Detener";
            this.Button_Detener.Size = new System.Drawing.Size(212, 110);
            this.Button_Detener.TabIndex = 8;
            this.Button_Detener.UseVisualStyleBackColor = false;
            this.Button_Detener.Click += new System.EventHandler(this.Button_Detener_Click);
            // 
            // Button_Retroceder
            // 
            this.Button_Retroceder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Retroceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Retroceder.FlatAppearance.BorderSize = 0;
            this.Button_Retroceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Retroceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Retroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Retroceder.Image = global::WreckerCar.Properties.Resources.abajo;
            this.Button_Retroceder.Location = new System.Drawing.Point(125, 241);
            this.Button_Retroceder.Name = "Button_Retroceder";
            this.Button_Retroceder.Size = new System.Drawing.Size(212, 78);
            this.Button_Retroceder.TabIndex = 7;
            this.Button_Retroceder.UseVisualStyleBackColor = false;
            this.Button_Retroceder.Click += new System.EventHandler(this.Button_Retroceder_Click);
            // 
            // Button_Avanzar
            // 
            this.Button_Avanzar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Avanzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Avanzar.FlatAppearance.BorderSize = 0;
            this.Button_Avanzar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Avanzar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Avanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Avanzar.Image = global::WreckerCar.Properties.Resources.arriba;
            this.Button_Avanzar.Location = new System.Drawing.Point(125, 41);
            this.Button_Avanzar.Name = "Button_Avanzar";
            this.Button_Avanzar.Size = new System.Drawing.Size(212, 78);
            this.Button_Avanzar.TabIndex = 5;
            this.Button_Avanzar.UseVisualStyleBackColor = false;
            this.Button_Avanzar.Click += new System.EventHandler(this.Button_Avanzar_Click);
            // 
            // CommandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.Panel_ContenedorPrincipal);
            this.Controls.Add(this.Panel_BarraTitulo);
            this.Controls.Add(this.Panel_EntradaSerial);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CommandControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommandControl_FormClosing);
            this.Load += new System.EventHandler(this.CommandControl_Load);
            this.Panel_EntradaSerial.ResumeLayout(false);
            this.Panel_EntradaSerialContenedor.ResumeLayout(false);
            this.FlowLayoutPanel_OpcionesEntradaSerial.ResumeLayout(false);
            this.Panel_BarraTitulo.ResumeLayout(false);
            this.Panel_ContenedorPrincipal.ResumeLayout(false);
            this.Panel_CamionAuxilio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CamionAuxilio)).EndInit();
            this.Panel_EstadosCamionAuxilio.ResumeLayout(false);
            this.Panel_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_EntradaSerial;
        private System.Windows.Forms.Panel Panel_BarraTitulo;
        private System.Windows.Forms.Button Button_EntradaSerial;
        private System.Windows.Forms.RichTextBox RichTextBox_EntradaSerial;
        private System.Windows.Forms.Panel Panel_ContenedorPrincipal;
        private System.Windows.Forms.Panel Panel_Control;
        private System.Windows.Forms.Button Button_Izquierda;
        private System.Windows.Forms.Button Button_Derecha;
        private System.Windows.Forms.Button Button_Detener;
        private System.Windows.Forms.Button Button_Retroceder;
        private System.Windows.Forms.CheckBox CheckBox_LucesDelanteras;
        private System.Windows.Forms.Panel Panel_CamionAuxilio;
        private System.Windows.Forms.PictureBox PictureBox_CamionAuxilio;
        private System.Windows.Forms.Panel Panel_EstadosCamionAuxilio;
        private System.Windows.Forms.CheckBox CheckBox_LucesTraseras;
        private System.Windows.Forms.Label Label_DeteccionObstaculos;
        private System.Windows.Forms.Label Label_DeteccionFlama;
        private System.Windows.Forms.Label Label_DeteccionHumo;
        private System.Windows.Forms.Button Button_Minimizar;
        private System.Windows.Forms.Button Button_Cerrar;
        private System.Windows.Forms.Button Button_Avanzar;
        private System.Windows.Forms.Label Label_TitleApp;
        private System.Windows.Forms.Button Button_Menu;
        private System.Windows.Forms.CheckBox CheckBox_CamionOnOff;
        private System.Windows.Forms.CheckBox CheckBox_ModoOscuro;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_OpcionesEntradaSerial;
        private System.Windows.Forms.Panel Panel_BarraDesplazamieto;
        private System.Windows.Forms.Button Button_Limpiar;
        private System.Windows.Forms.Button Button_GuardarComo;
        private System.Windows.Forms.Button Button_Copiar;
        private System.Windows.Forms.Panel Panel_EntradaSerialContenedor;
    }
}