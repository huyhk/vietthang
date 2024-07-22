using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace VNS.Security
{
    public class Crypto
    {
        private static byte[] _tdesKey = {15, 234, 123, 155, 216, 65, 79, 11,  188, 32,
										  45, 54,  222, 124, 66,  98, 80, 243, 250, 20,
								          78, 83,  23, 24};
        private static byte[] _tdesIV = { 69, 77, 246, 99, 165, 200, 191, 0 };


        public static string Encrypt(string text,bool isDecryptable)
        {
            return "";

        }
        public static string Decrypt(string text)
        {
            return "";
        }

        public static string EncryptString(string inStr)
        {
            if (inStr == null)
                inStr = "";
            byte[] inBytes = Encoding.UTF7.GetBytes(inStr);
            TripleDESCryptoServiceProvider enc = new TripleDESCryptoServiceProvider(); ;

            MemoryStream outStream = new MemoryStream();
            CryptoStream encStream = new CryptoStream(outStream, enc.CreateEncryptor(_tdesKey, _tdesIV), CryptoStreamMode.Write);
            encStream.Write(inBytes, 0, inBytes.Length);
            encStream.FlushFinalBlock();
            int l = (int)outStream.Length;
            encStream.Close();
            byte[] outBytes = outStream.GetBuffer();
            return Convert.ToBase64String(outBytes, 0, l);
        }

        public static string DecryptString(string inStr)
        {
            if (inStr == null)
                inStr = "";
            try
            {
                byte[] inBytes = Convert.FromBase64String(inStr);
                TripleDESCryptoServiceProvider enc = new TripleDESCryptoServiceProvider(); ;
            
                MemoryStream outStream = new MemoryStream();
                CryptoStream decStream = new CryptoStream(outStream, enc.CreateDecryptor(_tdesKey, _tdesIV), CryptoStreamMode.Write);
                decStream.Write(inBytes, 0, inBytes.Length);
                decStream.FlushFinalBlock();
                int l = (int)outStream.Length;
                decStream.Close();
                return Encoding.UTF7.GetString(outStream.GetBuffer(), 0, l);
            }
            catch (Exception e)
            {
                return (new Random().ToString());
            }
        }

        public static string EncryptStringWithKey(string inStr, byte[] tdesKey, byte[] tdesIV)
        {
            byte[] inBytes = Encoding.UTF7.GetBytes(inStr);
            TripleDESCryptoServiceProvider enc = new TripleDESCryptoServiceProvider(); ;

            MemoryStream outStream = new MemoryStream();
            CryptoStream encStream = new CryptoStream(outStream, enc.CreateEncryptor(tdesKey, tdesIV), CryptoStreamMode.Write);
            encStream.Write(inBytes, 0, inBytes.Length);
            encStream.FlushFinalBlock();
            int l = (int)outStream.Length;
            encStream.Close();
            byte[] outBytes = outStream.GetBuffer();
            return Convert.ToBase64String(outBytes, 0, l);
        }

        public static string DecryptStringWithKey(string inStr, byte[] tdesKey, byte[] tdesIV)
        {
            byte[] inBytes = Convert.FromBase64String(inStr);
            TripleDESCryptoServiceProvider enc = new TripleDESCryptoServiceProvider(); ;

            MemoryStream outStream = new MemoryStream();
            CryptoStream decStream = new CryptoStream(outStream, enc.CreateDecryptor(tdesKey, tdesIV), CryptoStreamMode.Write);
            decStream.Write(inBytes, 0, inBytes.Length);
            decStream.FlushFinalBlock();
            decStream.Close();
            return Encoding.UTF7.GetString(outStream.GetBuffer());
        }
    }
}
