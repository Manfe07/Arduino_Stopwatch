using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Stoppwatch
{
    public partial class Form1 : Form
    {

        bool ping = true;
        //Validation Bytes
        byte start_byte = 0xF5;
        byte stop_byte  = 0x0D;

        //Bus Message code
        byte C_mode     = 0x02;   //Counter-Value
        byte C_pTime1   = 0x11;   //preview Time1
        byte C_ping     = 0x01;   //send ping
        byte C_pTime2   = 0x12;   //preview Time2
        byte C_pTime3   = 0x13;  //preview Time3
        byte C_oTime1   = 0x21;  //official Time1
        byte C_oTime2   = 0x22;   //official Time2
        byte C_oTime3   = 0x23;   //official Time3


        // Mode code
        byte M_disarm   = 0x0000;
        byte M_arm      = 0x0001;
        byte M_stop     = 0x0002;
        byte M_start    = 0x0003;
        byte M_startHorn= 0x0004;
        byte M_finish   = 0x0005;   //for every line finish
        byte M_cancled  = 0x0006;




        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getPortNames();
        }

        private void getPortNames()
        {
            comboBox_PortList.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBox_PortList.Items.AddRange(ports);
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (comboBox_PortList.Text != "") {
                serialPort1.PortName = comboBox_PortList.Text; 
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    button_Connect.Enabled = false;
                    button_PortScan.Enabled = false;
                    button_Disconnect.Enabled = true;
                    groupBox_Time.Enabled = true;
                    tabControl1.SelectedIndex = 0;
                    timer_ping.Start();
                    timer_Serial.Start();
                }
            }
        }

        private void button_PortScan_Click(object sender, EventArgs e)
        {
            getPortNames();
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen)
            {
                button_Connect.Enabled = true;
                button_PortScan.Enabled = true;
                button_Disconnect.Enabled = false;
                groupBox_Time.Enabled = false;
                timer_ping.Stop();
                timer_Serial.Stop();
            }
        }

        private void timer_ping_Tick(object sender, EventArgs e)
        {
            if (!ping)
            {
                toolStripStatusLabel_Connection.Text = "NO CONNECTION";
                toolStripStatusLabel_Connection.BackColor = Color.Red; 
            }
            else
            {
                toolStripStatusLabel_Connection.Text = "Connected";
                toolStripStatusLabel_Connection.BackColor = Color.Green;
            }
            ping = false;
        }

        private void timer_Serial_Tick(object sender, EventArgs e)
        {
            int Code;
            int Value;
            int msg_l = 5;
            if(serialPort1.BytesToRead >= msg_l)
            { 
                byte[] data = new byte[msg_l];
                serialPort1.Read(data,0,msg_l);
                if (data[0] == start_byte)
                {
                    if (data[msg_l - 1] == stop_byte)
                    {
                        Code = (data[1] & 0xFF);
                        Value = ((data[2] << 8) | (data[3]));
                        if(Code == C_ping)
                        {
                            ping = true;
                        }
                    }
                }                
            }
        }
    }
}
