using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Stoppwatch
{
    public partial class Form1 : Form
    {
        //Stoppwatch Variables
        double time_1;
        double time_2;
        double time_3;
        string status;
        Color status_color = Color.Blue;

        bool ping = true;
        //Validation Bytes
        const byte start_byte = 0xF5;
        const byte stop_byte = 0x0D;

        //Bus Message code
        const byte C_mode = 0x02;   //Counter-Value
        const byte C_ping = 0x01;   //send ping
        const byte C_pTime1 = 0x11;   //preview Time1
        const byte C_pTime2 = 0x12;   //preview Time2
        const byte C_pTime3 = 0x13;   //preview Time3
        const byte C_oTime1 = 0x21;   //official Time1
        const byte C_oTime2 = 0x22;   //official Time2
        const byte C_oTime3 = 0x23;   //official Time3


        // Mode code
        const byte M_disarm = 0x0000;
        const byte M_arm = 0x0001;
        const byte M_stop = 0x0002;
        const byte M_start = 0x0003;
        const byte M_startHorn = 0x0004;
        const byte M_finish = 0x0005;   //for every line finish
        const byte M_cancled = 0x0006;




        public Form1()
        {
            this.TopMost=true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
            if (comboBox_PortList.Text != "")
            {
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
            if (serialPort1.BytesToRead >= msg_l)
            {
                byte[] data = new byte[msg_l];
                serialPort1.Read(data, 0, msg_l);
                if (data[0] == start_byte)
                {
                    if (data[msg_l - 1] == stop_byte)
                    {
                        Code = (data[1] & 0xFF);
                        Value = ((data[2] << 8) | (data[3]));
                        switch (Code)
                        {
                            case C_ping:
                                ping = true;
                                break;
                            case C_mode:
                                switch (Value)
                                {
                                    case M_arm:
                                        status = "!ARMED!";
                                        status_color = Color.Yellow;
                                        break;
                                    case M_disarm:
                                        status = "DISARMED";
                                        status_color = Color.Green;
                                        break;
                                    case M_startHorn:
                                        status = "RACE IS GOING!!";
                                        status_color = Color.Red;
                                        break;
                                    /*
                                    case M_finish:
                                        status = "FINISH";
                                        status_color = Color.Blue;
                                        break;
                                    */
                                    default:
                                        break;
                                }
                                toolStripStatusLabel1.Text = status;
                                toolStripStatusLabel1.BackColor = status_color;
                                break;
                            case C_pTime1:
                                time_1 = Convert.ToDouble(Value) / 100;
                                update_Time();
                                break;
                            case C_pTime2:
                                time_2 = Convert.ToDouble(Value) / 100;
                                update_Time();
                                break;
                            case C_pTime3:
                                time_3 = Convert.ToDouble(Value) / 100;
                                update_Time();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void update_Time()
        {
            textBox_time_1.Text = time_1.ToString();
            textBox_time_3.Text = time_3.ToString();
            textBox_time_2.Text = time_2.ToString();

            //calc place Lane 1
            if (time_1 <= time_2 && time_1 <= time_3) label_place1.Text = "1.";
            else if (time_1 <= time_2 || time_1 <= time_3) label_place1.Text = "2.";
            else label_place1.Text = "3.";
            //calc place Lane 2
            if (time_2 <= time_1 && time_2 <= time_3) label_place2.Text = "1.";
            else if (time_2 <= time_1 || time_2 <= time_3) label_place2.Text = "2.";
            else label_place2.Text = "3.";
            //calc place Lane 3
            if (time_3 <= time_1 && time_3 <= time_2) label_place3.Text = "1.";
            else if (time_3 <= time_1 || time_3 <= time_2) label_place3.Text = "2.";
            else label_place3.Text = "3.";


        }

        private void button_setTime_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_time_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_AllwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox_AllwaysOnTop.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/MFTechnologieDE");
        }
    }
}

