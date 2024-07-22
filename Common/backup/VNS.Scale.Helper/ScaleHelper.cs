using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Timers;
using System.Text.RegularExpressions;
using VNS.Scales.Data;
using System.Windows.Forms;


namespace VNS.Scales.Helper
{
    public class ScaleHelper
    {
        private System.IO.Ports.SerialPort comport;

        private string _data = string.Empty;
        private bool isSettingLoaded = false;
        public ScaleHelper()
        {
            this.config = HelperSetting.FromConfig();         

        }

     
        public void Open()
        {
            if (comport == null)
            {
                comport = new SerialPort();
                comport.DataReceived += new SerialDataReceivedEventHandler(comport_DataReceived);
                comport.ErrorReceived += new SerialErrorReceivedEventHandler(comport_ErrorReceived);
                
            }
           
            try
            {
                comport.PortName = config.PortName;
                comport.Handshake = config.Handshake;
                comport.BaudRate = config.BaudRate;
                comport.Parity = config.Parity;
                comport.StopBits = config.StopBits;
                comport.DataBits = config.DataBits;          
                comport.Open();
                if (comport.IsOpen)
                    status = HelperStatus.OPEN;
            }
            catch (Exception exception)
            {
                status = HelperStatus.ERROR;
                OnErrorReceived(exception.Message);
            }
        }
        public void Close()
        {
            try
            {
                comport.Close();
                if (!comport.IsOpen)
                    status = HelperStatus.CLOSED;
            }
            catch (Exception exception)
            {
                status = HelperStatus.ERROR;
                OnErrorReceived(exception.Message);
                MessageBox.Show(exception.Message);
            }

        }

        private HelperStatus status = HelperStatus.CLOSED;
        public HelperStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        private HelperSetting config = new HelperSetting();
        public HelperSetting Config
        {
            get { return config; }
            set { config = value; }
        }

        void comport_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            
        }

        void comport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!comport.IsOpen)
                comport.Open();
            string data = (sender as SerialPort).ReadExisting();

            _data += data;
            ProcessData();

        }

        private void ProcessData()
        {
            Regex reg = new Regex(@"[" + config.EndOfLine + "]+");

            if (reg.IsMatch(_data))
            {
                Match m = reg.Match(_data);
                string data = _data.Substring(m.Index + m.Length);
                _data = _data.Substring(0, m.Index);
                OnDataReceived(_data);
                _data = data;
            }
        }
        public delegate void ScaleDataReceivedEventHandler(object sender, string data);
        public event ScaleDataReceivedEventHandler DataReceived;
        public virtual void OnDataReceived(string data)
        {
            if (DataReceived != null)
                DataReceived(this, data);
        }

        public delegate void ScaleErrorEventHandler(object sender, string data);
        public event ScaleErrorEventHandler ErrorReceived;
        public virtual void OnErrorReceived(string data)
        {
            if (ErrorReceived != null)
                ErrorReceived(this, data);
            MessageBox.Show(data);
        }

        public int SendData(string data)
        {
            if (!comport.IsOpen)
                comport.Open();
            comport.WriteLine(data);
            return 0;
        }

        public void SetConfig(string portname, int baudrate, int dataBits, StopBits stopBits, Handshake handshake, Parity parity, string endOfLine)
        {
            config.PortName = portname;
            config.Handshake = handshake;
            config.BaudRate = baudrate;
            config.Parity = parity;
            config.StopBits = stopBits;
            config.DataBits = dataBits;
            config.EndOfLine = endOfLine;
        }
    }

    public enum HelperStatus
    { 
        CLOSED,
        OPEN,
        ERROR

    }
}



