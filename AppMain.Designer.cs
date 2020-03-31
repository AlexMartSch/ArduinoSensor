namespace RITASensor
{
    partial class RitaPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RitaPanel));
            this.BtnOn = new MetroFramework.Controls.MetroButton();
            this.btnOff = new MetroFramework.Controls.MetroButton();
            this.btnClearLogs = new MetroFramework.Controls.MetroButton();
            this.TxTNode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuit = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxTLogs = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PortsDisplay = new MetroFramework.Controls.MetroComboBox();
            this.SerialPorts = new System.IO.Ports.SerialPort(this.components);
            this.ConnectData = new MetroFramework.Controls.MetroButton();
            this.TxTRealData = new MetroFramework.Controls.MetroTextBox();
            this.txtToPrint = new MetroFramework.Controls.MetroTextBox();
            this.btnPrintLCD = new MetroFramework.Controls.MetroButton();
            this.btnIniciar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOn
            // 
            this.BtnOn.Location = new System.Drawing.Point(23, 63);
            this.BtnOn.Name = "BtnOn";
            this.BtnOn.Size = new System.Drawing.Size(126, 30);
            this.BtnOn.TabIndex = 4;
            this.BtnOn.Text = "ENCENDER";
            this.BtnOn.Click += new System.EventHandler(this.BtnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Enabled = false;
            this.btnOff.Location = new System.Drawing.Point(23, 168);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(126, 30);
            this.btnOff.Style = MetroFramework.MetroColorStyle.Green;
            this.btnOff.TabIndex = 5;
            this.btnOff.Text = "APAGAR";
            this.btnOff.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnOff.Click += new System.EventHandler(this.BtnOff_Click);
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(23, 291);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(126, 30);
            this.btnClearLogs.TabIndex = 6;
            this.btnClearLogs.Text = "REINICIAR LOGS";
            this.btnClearLogs.Click += new System.EventHandler(this.BtnClearLogs_Click);
            // 
            // TxTNode
            // 
            this.TxTNode.Location = new System.Drawing.Point(454, 63);
            this.TxTNode.Multiline = true;
            this.TxTNode.Name = "TxTNode";
            this.TxTNode.ReadOnly = true;
            this.TxTNode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxTNode.Size = new System.Drawing.Size(335, 294);
            this.TxTNode.Style = MetroFramework.MetroColorStyle.Black;
            this.TxTNode.TabIndex = 7;
            this.TxTNode.Text = "Esperando...";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 236);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Desarrollado por";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 255);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = " Alejandro Martínez";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(547, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(23, 327);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(126, 30);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "SALIR";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(441, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // TxTLogs
            // 
            this.TxTLogs.Location = new System.Drawing.Point(795, 63);
            this.TxTLogs.Multiline = true;
            this.TxTLogs.Name = "TxTLogs";
            this.TxTLogs.ReadOnly = true;
            this.TxTLogs.Size = new System.Drawing.Size(242, 294);
            this.TxTLogs.Style = MetroFramework.MetroColorStyle.Black;
            this.TxTLogs.TabIndex = 13;
            this.TxTLogs.Text = "Inicio de Aplicación.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(335, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // PortsDisplay
            // 
            this.PortsDisplay.FormattingEnabled = true;
            this.PortsDisplay.ItemHeight = 23;
            this.PortsDisplay.Location = new System.Drawing.Point(23, 204);
            this.PortsDisplay.Name = "PortsDisplay";
            this.PortsDisplay.Size = new System.Drawing.Size(126, 29);
            this.PortsDisplay.TabIndex = 15;
            // 
            // SerialPorts
            // 
            this.SerialPorts.BaudRate = 115200;
            this.SerialPorts.PortName = "COM3";
            this.SerialPorts.WriteTimeout = 20;
            this.SerialPorts.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPorts_DataReceived);
            // 
            // ConnectData
            // 
            this.ConnectData.Enabled = false;
            this.ConnectData.Location = new System.Drawing.Point(23, 99);
            this.ConnectData.Name = "ConnectData";
            this.ConnectData.Size = new System.Drawing.Size(126, 30);
            this.ConnectData.TabIndex = 16;
            this.ConnectData.Text = "CONECTAR";
            this.ConnectData.Click += new System.EventHandler(this.ConnectData_Click);
            // 
            // TxTRealData
            // 
            this.TxTRealData.Location = new System.Drawing.Point(156, 63);
            this.TxTRealData.Multiline = true;
            this.TxTRealData.Name = "TxTRealData";
            this.TxTRealData.ReadOnly = true;
            this.TxTRealData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxTRealData.Size = new System.Drawing.Size(292, 294);
            this.TxTRealData.Style = MetroFramework.MetroColorStyle.Black;
            this.TxTRealData.TabIndex = 17;
            this.TxTRealData.Text = "Esperando...";
            // 
            // txtToPrint
            // 
            this.txtToPrint.Location = new System.Drawing.Point(653, 21);
            this.txtToPrint.Name = "txtToPrint";
            this.txtToPrint.Size = new System.Drawing.Size(202, 23);
            this.txtToPrint.TabIndex = 18;
            this.txtToPrint.Visible = false;
            // 
            // btnPrintLCD
            // 
            this.btnPrintLCD.Location = new System.Drawing.Point(861, 21);
            this.btnPrintLCD.Name = "btnPrintLCD";
            this.btnPrintLCD.Size = new System.Drawing.Size(99, 23);
            this.btnPrintLCD.TabIndex = 19;
            this.btnPrintLCD.Text = "Print";
            this.btnPrintLCD.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Location = new System.Drawing.Point(23, 132);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(126, 30);
            this.btnIniciar.TabIndex = 20;
            this.btnIniciar.Text = "INICIAR EDM";
            this.btnIniciar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnIniciar.Visible = false;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // RitaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 380);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnPrintLCD);
            this.Controls.Add(this.txtToPrint);
            this.Controls.Add(this.TxTRealData);
            this.Controls.Add(this.ConnectData);
            this.Controls.Add(this.PortsDisplay);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TxTLogs);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxTNode);
            this.Controls.Add(this.btnClearLogs);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.BtnOn);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RitaPanel";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Rita Sensor Control";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnOn;
        private MetroFramework.Controls.MetroButton btnOff;
        private MetroFramework.Controls.MetroButton btnClearLogs;
        private MetroFramework.Controls.MetroTextBox TxTNode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnQuit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox TxTLogs;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroComboBox PortsDisplay;
        private System.IO.Ports.SerialPort SerialPorts;
        private MetroFramework.Controls.MetroButton ConnectData;
        private MetroFramework.Controls.MetroTextBox TxTRealData;
        private MetroFramework.Controls.MetroTextBox txtToPrint;
        private MetroFramework.Controls.MetroButton btnPrintLCD;
        private MetroFramework.Controls.MetroButton btnIniciar;
    }
}

