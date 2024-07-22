using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Configuration;

namespace VNS.Scales.Helper
{
    public class HelperSetting
    {
        public static HelperSetting FromConfig()
        {
            HelperSetting setting = new HelperSetting();
            try
            {
                setting.portname = ConfigurationManager.AppSettings["ComPort"].ToString();
                setting.baudrate = int.Parse(ConfigurationManager.AppSettings["BaudRate"].ToString());
                setting.stopbits = (StopBits)Enum.Parse(typeof(StopBits), ConfigurationManager.AppSettings["StopBit"].ToString());
                setting.parity = (Parity)Enum.Parse(typeof(Parity), ConfigurationManager.AppSettings["Parity"].ToString());
                setting.handshake = (Handshake)Enum.Parse(typeof(Handshake), ConfigurationManager.AppSettings["HandShake"].ToString());
                setting.endOfLine = ConfigurationManager.AppSettings["EndOfLine"].ToString();
            }
            catch
            { }
            return setting;
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
        private int dataBits = 7;
        public int DataBits
        {
            get { return dataBits; }
            set { dataBits = value; }
        }
        private Parity parity = Parity.Odd;
        public Parity Parity
        {
            get { return parity; }
            set { parity = value; }
        }

        private string endOfLine = "\r\n";

        public string EndOfLine
        {
            get { return endOfLine; }
            set { endOfLine = value; }
        }
    }
}
