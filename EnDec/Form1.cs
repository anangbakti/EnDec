using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Microsoft.VisualBasic; 

namespace EnDec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdEncResult_Click(object sender, EventArgs e)
        {
            txtEncResult.Text = Decrypt(txtToEnc.Text.Trim(), "&%#@?,:*");
        }

        private void cmdToEnc_Click(object sender, EventArgs e)
        {
            txtToEnc.Text = Encrypt(txtEncResult.Text.Trim(), "&%#@?,:*");
        }

        public string Decrypt(string pText, string pDecrKey)
        {
            string str = "";
            byte[] rgbIV = new byte[] { 0x12, 0x34, 0x56, 120, 0x90, 0xab, 0xcd, 0xef };
            byte[] buffer = new byte[pText.Length + 1];
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(Strings.Left(pDecrKey, 8));
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                buffer = Convert.FromBase64String(pText);
                MemoryStream stream2 = new MemoryStream();
                CryptoStream stream = new CryptoStream(stream2, provider.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Write);
                stream.Write(buffer, 0, buffer.Length);
                stream.FlushFinalBlock();
                str = Encoding.UTF8.GetString(stream2.ToArray());
            }
            catch (Exception exception1)
            {
                str = "Decrypt error" + exception1.StackTrace; 
            }
            return str;
        }
         
        public string Encrypt(string pText, string pEncrKey)
        {
            string message = "";
            byte[] rgbIV = new byte[] { 0x12, 0x34, 0x56, 120, 0x90, 0xab, 0xcd, 0xef };
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(  Strings.Left(pEncrKey, 8));
                byte[] buffer = Encoding.UTF8.GetBytes(pText);
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                MemoryStream stream2 = new MemoryStream();
                CryptoStream stream = new CryptoStream(stream2, provider.CreateEncryptor(bytes, rgbIV), CryptoStreamMode.Write);
                stream.Write(buffer, 0, buffer.Length);
                stream.FlushFinalBlock();
                message = Convert.ToBase64String(stream2.ToArray());
            }
            catch (Exception exception1)
            {
                message = "Encrypt error" + exception1.StackTrace; 
            }
            return message;
        }

    }
}
