using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO.Ports;

namespace VNS.Scales.Data
{
    public  class Setting
    {       
        public static string ComPort = ConfigurationManager.AppSettings["ComPort"].ToString();
        public static string BaudRate = ConfigurationManager.AppSettings["BaudRate"].ToString();
        public static string DataBit = ConfigurationManager.AppSettings["DataBit"].ToString();
        public static string StopBit = ConfigurationManager.AppSettings["StopBit"].ToString();
        public static string ParityType = ConfigurationManager.AppSettings["ParityType"].ToString();
        public static string HandShake = ConfigurationManager.AppSettings["HandShake"].ToString();
        public static string Min = ConfigurationManager.AppSettings["Min"].ToString();                
        public static string EndOfLine = ConfigurationManager.AppSettings["EndOfLine"].ToString();

        //private static List<Comports> lstComports = new List<Comports>();
        //public static List<Comports> ListComport
        //{
        //    get 
        //    {
        //        if (lstComports.Count == 0)
        //        {
        //            Comports c = new Comports();
        //            c.ComportName = "COM1";
        //            lstComports.Add(c);
        //            c = new Comports();
        //            c.ComportName = "COM2";
        //            lstComports.Add(c);
        //        }
        //        return lstComports;
        //    }
        //}

        //private static List<Handshakes> lstHandshakes = new List<Handshakes>();
        //public static List<Handshakes> ListHandshakes
        //{
        //    get
        //    {
        //        if (lstHandshakes.Count == 0)
        //        {
        //            Handshakes c = new Handshakes();
        //            c.HandshakeName = Handshake.None.ToString();
        //            lstHandshakes.Add(c);

        //            c = new Handshakes();
        //            c.HandshakeName = Handshake.RequestToSend.ToString();
        //            lstHandshakes.Add(c);

        //            c = new Handshakes();
        //            c.HandshakeName = Handshake.RequestToSendXOnXOff.ToString();
        //            lstHandshakes.Add(c);

        //            c = new Handshakes();
        //            c.HandshakeName = Handshake.XOnXOff.ToString();
        //            lstHandshakes.Add(c);
        //        }
        //        return lstHandshakes;
        //    }
        //}

        //private static List<ParityTypes> lstParityTypes = new List<ParityTypes>();
        //public static List<ParityTypes> ListParityTypes
        //{
        //    get
        //    {
        //        if (lstHandshakes.Count == 0)
        //        {
        //            ParityTypes c = new ParityTypes();
        //            c.ParityName = Parity.None.ToString();
        //            lstParityTypes.Add(c);

        //            c = new ParityTypes();
        //            c.ParityName = Parity.Mark.ToString();
        //            lstParityTypes.Add(c);

        //            c = new ParityTypes();
        //            c.ParityName = Parity.Even.ToString();
        //            lstParityTypes.Add(c);

        //            c = new ParityTypes();
        //            c.ParityName = Parity.Odd.ToString();
        //            lstParityTypes.Add(c);

        //            c = new ParityTypes();
        //            c.ParityName = Parity.Space.ToString();
        //            lstParityTypes.Add(c);
        //        }
        //        return lstParityTypes;
        //    }
        //}
    }
}
