using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using Timer = System.Timers.Timer;
using System.Globalization;

namespace GSM
{
    class GSMsms
    {
        private readonly string AT = "AT" + Environment.NewLine;
        private readonly string GSM_TE_SET = "AT+CSCS=\"GSM\"" + Environment.NewLine;
        private SerialPort gsmPort;
        public bool isConnected { get; private set; } = false;

        private static GSMsms instance = null;

        public static GSMsms getInstance()
        {
            if (instance == null)
            {
                // creating instance of GSMsms
                Console.WriteLine("Creating new instance");
                instance = new GSMsms();
            }
            return instance;
        }

        public bool Connect()
        {
            if (gsmPort == null || !isConnected || !gsmPort.IsOpen)
            {
                Console.WriteLine("Connecting");
                string gsmPortConfig = ConfigurationManager.AppSettings["gsmPortNumber"];
                if (gsmPortConfig == null || gsmPortConfig == "")
                {
                    Console.WriteLine("Connected");
                    MessageBox.Show("No port specified, please edit the config file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                try
                {
                    gsmPort = new SerialPort();
                    gsmPort.PortName = gsmPortConfig;
                    gsmPort.Open();
                    isConnected = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    isConnected = false;
                }

            }

            return isConnected;
        }

        public void Disconnect()
        {
            if (gsmPort != null || isConnected || gsmPort.IsOpen)
            {
                gsmPort.Close();
                gsmPort.Dispose();
                isConnected = false;
            }
        }

        public bool Send(string toAddress, string message)
        {
            Console.WriteLine("Sending..");

            gsmPort.WriteLine("AT+CMGF=1"); // Set mode to Text(1) or PDU(0)
            Thread.Sleep(200);
            gsmPort.WriteLine($"AT+CMGS=\"{toAddress}\"");
            Thread.Sleep(200);
            gsmPort.WriteLine(message + char.ConvertFromUtf32(26));
            Thread.Sleep(1000);

            string response = gsmPort.ReadExisting();

            if (response.EndsWith("\r\nOK\r\n") && response.Contains("+CMGS:")) // IF CMGS IS MISSING IT MEANS THE MESSAGE WAS NOT SENT!
            {
                Console.WriteLine(response);
                // add more code here to manipulate reponse string.
                return true;
            }
            else
            {
                // add more code here to handle error.
                Console.WriteLine(response);
                return false;
            }
        }
    }
}
