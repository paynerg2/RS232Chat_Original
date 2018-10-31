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
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace RS232
{
    public partial class Form1 : Form
    {
        //Local variables
        private string Port { get; set; }

        public delegate void RS232Handler(SerialPort mySerialPort);

        public event RS232Handler RS232EventOccurred;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbSerialPorts.Items.AddRange(ports);

            //Set default selected index to the first item
            cmbSerialPorts.SelectedIndex = 0;

            Port = cmbSerialPorts.SelectedItem.ToString();

            serialPort1.PortName = Port;

            rtbChatEntry.Clear();
            rtbReceivedText.Clear();
            rtbChatEntry.Focus();


        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //use this to invoke the event delagate and pass it the method to update the box.
            BeginInvoke(RS232EventOccurred, serialPort1);

        }

        private void UpdateTextBox(SerialPort mySerialPort)
        {
            try
            {
                //serialPort1.Open();
                string all = serialPort1.ReadExisting();
                rtbReceivedText.Text += all;
                rtbChatEntry.Clear();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            Run();
        }
        
        private void Run()
        {
            
            //Add event handler
            RS232EventOccurred += UpdateTextBox;
            //RS232EventOccurred += new RS232Handler(UpdateTextBox);
            try
            {
                serialPort1.Open();
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                throw;
            }

            rtbChatEntry.Focus();

        }

        private void cmbSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port = cmbSerialPorts.SelectedItem.ToString();
            serialPort1.PortName = Port;
        }

        private void rtbChatEntry_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void rtbChatEntry_KeyDown(object sender, KeyEventArgs e)
        {
            //Proceed if an enter has been received
            if (e.KeyValue != (char) 13) return;

            string text = rtbChatEntry.Text + Environment.NewLine;

            try
            {
                serialPort1.Write(text);
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void rtbReceivedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
