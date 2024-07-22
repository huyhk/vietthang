using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace VNS.Scales.UI
{
    
    public partial class Receiver : UserControl
    {
        Scales.Helper.ScaleHelper helper = null;
        public Receiver()
        {
            InitializeComponent();
            helper = new VNS.Scales.Helper.ScaleHelper();
            helper.DataReceived += new VNS.Scales.Helper.ScaleHelper.ScaleDataReceivedEventHandler(helper_DataReceived);
            helper.ErrorReceived += new VNS.Scales.Helper.ScaleHelper.ScaleErrorEventHandler(helper_ErrorReceived);
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Interval = 100;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            if (result > 0)
                OnDataReceiving();
        }

        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (autoOpen && !DesignMode)
                Open();
        }
        public void Open()
        {
            tmr.Start();
            helper.SetConfig(this.portname, this.baudrate, this.dataBits, this.stopbits, this.handshake, this.parity, this.endOfLine);                        
            helper.Open();
        }
        public void Close()
        {
            tmr.Stop();
            if (helper != null && helper.Status == VNS.Scales.Helper.HelperStatus.OPEN)
                helper.Close();
        }
        void helper_ErrorReceived(object sender, string data)
        {
            
            if (MessageBox.Show("Error opening port, retry?", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                helper.Open();
        }
        /// <summary>
        /// Data received from serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        void helper_DataReceived(object sender, string data)
        {
            if (this.CanRaiseEvents)
            {
                System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex(this.dataPattern);
                if (re.IsMatch(data))
                {
                    int num = int.Parse(re.Match(data).Groups[1].Value);
                    if (num > 0)
                    {
                        if (num == result) count++;
                        else
                        {
                            count = 1;
                            result = num;
                        }
                        if (count >= this.stableCount)
                        {
                            this.Invoke(new OnDataReceivedDelegate(OnDataReceived));
                            count = 0;
                        }
                        //else
                        //    this.Invoke(new OnDataReceivedDelegate(OnDataReceiving));
                    }
                }
            }
        }
       
        Timer tmr = new Timer();

        public delegate void DataReceiveHandler(object sender, int result);
        
        public delegate void OnDataReceivedDelegate();
                
        int count = 0;
        /// <summary>
        /// Raise when stable data received
        /// </summary>
        [Category("VNS")]        
        public event DataReceiveHandler DataReceived;            
        public virtual void OnDataReceived()
        {
            if (DataReceived != null && this.CanRaiseEvents)
                DataReceived(this, result);
        }
        /// <summary>
        /// Raise when data received
        /// </summary>        
        [Category("VNS")]
        public event DataReceiveHandler DataReceiving;
        public virtual void OnDataReceiving()
        {
            if (DataReceiving != null && this.CanRaiseEvents)
                DataReceiving(this, result);
        }
        /// <summary>
        /// Raise when error occured
        /// </summary>        
        [Category("VNS")]
        public event EventHandler Error;
        public virtual void OnError()
        {
            if (Error != null)
                Error(this,  new EventArgs());
        }

        private int result = 0;
        /// <summary>
        /// Result received from serial port
        /// </summary>
        public int Result
        {
            get { return result; }

        }


        private Handshake handshake = Handshake.XOnXOff;
        [Category("VNS")]
        public Handshake Handshake
        {
            get { return handshake; }
            set { handshake = value; }
        }
        private string portname = "COM1";
        [Category("VNS")]
        public string PortName
        {
            get { return portname; }
            set { portname = value; }
        }

        private int baudrate = 9600;
        [Category("VNS")]
        public int BaudRate
        {
            get { return baudrate; }
            set { baudrate = value; }
        }
        private StopBits stopbits = StopBits.None;
        [Category("VNS")]
        public StopBits StopBits
        {
            get { return stopbits; }
            set { stopbits = value; }
        }
        private int dataBits = 8;
        [Category("VNS")]
        public int DataBits
        {
            get { return dataBits; }
            set { dataBits = value; }
        }

        private Parity parity = Parity.Odd;
        [Category("VNS")]
        public Parity Parity
        {
            get { return parity; }
            set { parity = value; }
        }

        private string dataPattern = "(\\d+)KG";
        [Category("VNS")]
        public string DataPattern
        {
            get { return dataPattern; }
            set { dataPattern = value; }
        }
        private int stableCount = 10;
       
        [Category("VNS")]        
        public int StableCount
        {
            get { return stableCount; }
            set { stableCount = value; }
        }

        private bool autoOpen = false;
        [Category("VNS")]
        public bool AutoOpen
        {
            get { return autoOpen; }
            set { autoOpen = value; }
        }

        private string endOfLine = "\r\n";
        [Category("VNS")]
        public string EndOfLine
        {
            get { return endOfLine; }
            set { endOfLine = value; }
        }
    }
}