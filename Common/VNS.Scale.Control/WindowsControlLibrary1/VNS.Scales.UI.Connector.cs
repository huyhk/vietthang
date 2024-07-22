using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.IO.Ports;
using System.Timers;
using System.Windows.Forms;
using VNS.Utils;


namespace VNS.Scales.UI
{
    public partial class Connector : Component
    {
        Scales.Helper.ScaleHelper helper = new VNS.Scales.Helper.ScaleHelper();
        public Connector()
        {
            InitializeComponent();
            helper.DataReceived += new VNS.Scales.Helper.ScaleHelper.ScaleDataReceivedEventHandler(helper_DataReceived);
            helper.Open();
        }

        public Connector(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            helper.DataReceived += new VNS.Scales.Helper.ScaleHelper.ScaleDataReceivedEventHandler(helper_DataReceived);          
            helper.Open();
          
        }
              
                
        void helper_DataReceived(object sender, string data)
        {
            System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex(this.dataPattern);
            //Write2Log.WriteLogs("Connector", "DataReceived", data);
            if (re.IsMatch(data))
            {
                result = int.Parse(re.Match(data).Groups[1].Value);                       
               
                
            }
        }

        public event DataReceiveHandler DataReceived;        
        public event DataReceiveHandler DataReceiving;
        public delegate void DataReceiveHandler(object sender, int result);
        public delegate void OnDataReceivedDelegate();
        public virtual void OnDataReceived()
        {
            if (DataReceived != null)
                DataReceived(this, result);
        }

        public virtual void OnDataReceiving()
        {
            if (DataReceiving != null)
                DataReceiving(this, result);
        }

        private int result = 0;
        public int Result
        {
            get { return result; }
            
        }

        private Handshake handshake = Handshake.XOnXOff;

        public Handshake Handshake
        {
            get { return handshake; }
            set { handshake = value; }
        }
        private string portname = "COM1";

        public string PortName
        {
            get { return portname; }
            set { portname = value; }
        }

        private int baudrate = 1200;

        public int BaudRate
        {
            get { return baudrate; }
            set { baudrate = value; }
        }
        private StopBits stopbits = StopBits.One;

        public StopBits StopBits
        {
            get { return stopbits; }
            set { stopbits = value; }
        }
        private string dataPattern = "(\\d{5,})";
        public string DataPattern
        {
            get { return dataPattern; }
            set { dataPattern = value; }
        }
    }
}
