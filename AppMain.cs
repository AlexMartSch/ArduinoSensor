using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace RITASensor
{
    public partial class RitaPanel : MetroFramework.Forms.MetroForm
    {
        private String[] Ports;
        private bool isConnected = false;
        private bool ConnectionEnable = false;
        private bool DMEStart = false;
        Thread TimerX;

        public RitaPanel()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            GetAvailablePorts();
        }

        private void GetCommand(string Command)
        {
            if (Command.Contains("[C:"))
            {
                int StrFrom = Command.IndexOf("[C:") + "[C:".Length;
                int StrTo = Command.LastIndexOf("]");
                String Result = Command.Substring(StrFrom, StrTo - StrFrom);

                switch (Result)
                {
                    case "CAN_CONNECT":
                        AddNodeLine($"Paquete: {Result}");
                        if(!ConnectionEnable)
                        {
                            ConnectionEnable = true;
                            SendData("STS");
                        }
                        break;
                    case "EDM_CONNECT":
                        MessageBox.Show("DME Connected!");
                        DMEStart = true;
                        btnIniciar.Text = "DETENER EDM";
                        break;
                    case "EDM_DISCONNECT":
                        MessageBox.Show("DME Disconnected!");
                        btnIniciar.Text = "INICIAR EDM";
                        DMEStart = false;
                        break;
                }
            }
        }

        private void SendData(string data)
        {
            SerialPorts.Write(data);
        }

        private void GetAvailablePorts()
        {
            Ports = SerialPort.GetPortNames();
            foreach (string port in Ports)
            {
                PortsDisplay.Items.Add(port);
                if (Ports[0] != null)
                    PortsDisplay.SelectedItem = Ports[0];
            }
        }

        private void ConnectToNode()
        {
            string SelectedPort = PortsDisplay.GetItemText(PortsDisplay.SelectedItem);
            try
            {
                SerialPorts.DataReceived += new SerialDataReceivedEventHandler(SerialPorts_DataReceived);
                SerialPorts.Open();
                AddNodeLine("== CONEXIÓN ESTABLECIDA ==");
                AddLogLine("== CONEXIÓN ESTABLECIDA ==");

                isConnected = true;
                BtnOn.Enabled = false;
                btnOff.Enabled = true;
                ConnectData.Enabled = true;
                PortsDisplay.Enabled = false;
                AddLogLine("Puerto en uso:" + PortsDisplay.GetItemText(PortsDisplay.SelectedItem));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex);
            }
        }

        void ReadDDataThread()
        {
            ConnectData.Enabled = false;
            btnIniciar.Visible = true;
            btnIniciar.Enabled = true;
            TimerX = new Thread(new ThreadStart(ReadingData));
            TimerX.Start();
        }

        void ReadingData()
        {
            while(true)
            {
                Thread.Sleep(300);
                if (!isConnected)
                {
                    TimerX.Suspend();
                    break;
                }
                    
                try
                {
                    string TextToRead = SerialPorts.ReadExisting();
                    AddNodeLine("Listening: " + TextToRead);
                    AddRealLine(TextToRead);

                    GetCommand(TextToRead);
                    Thread.Sleep(250);
                }
                catch(Exception ex){}
            }
        }

        private void DisconnectNode()
        {
            if (SerialPorts.IsOpen)
            {
                SendData("STOP");
                AddNodeLine("Ya no se escucha la conexión.");
                AddLogLine("CONEXIÓN ELIMINADA.");
                BtnOn.Enabled = true;
                btnOff.Enabled = false;
                PortsDisplay.Enabled = true;
                ConnectData.Enabled = false;
                isConnected = false;
                ConnectionEnable = false;
                btnIniciar.Visible = false;
                btnIniciar.Enabled = false;
                SerialPorts.Close();
            }
  
        }

        private void AddLogLine(string Text)
        {
            TxTLogs.Text = $"{Text} {Environment.NewLine} {TxTLogs.Text}";
        }

        private void AddNodeLine(string Text)
        {
            DateTime now = DateTime.Now;
            TxTNode.Text = $"{string.Format("{0:HH:mm:ss}", now)} => {Text} {Environment.NewLine} {TxTNode.Text}";
        }

        private void AddRealLine(string Text)
        {
            DateTime now = DateTime.Now;
            if (Text != String.Empty)
                TxTRealData.Text = $"{string.Format("{0:HH:mm:ss}", now)} => {Text} {Environment.NewLine} {TxTRealData.Text}";
        }

        private void BtnOn_Click(object sender, EventArgs e)
        {
            ConnectToNode();
        }

        private void BtnOff_Click(object sender, EventArgs e)
        {
            DisconnectNode();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            DisconnectNode();
            Application.Exit();
        }

        private void SerialPorts_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
        }

        private void ConnectData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escuchando conexión");
            if(isConnected)
                ReadDDataThread();

        }

        private void BtnClearLogs_Click(object sender, EventArgs e)
        {
            TxTRealData.Text = "";
            TxTNode.Text = "";
            TxTLogs.Text = "";
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (!DMEStart)
                SendData("ST_EDM");
            else
                SendData("STOP_EDM");

        }
    }
}
