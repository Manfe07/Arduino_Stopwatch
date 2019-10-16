namespace Stoppwatch
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Connection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_split_unit = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_main = new System.Windows.Forms.TabPage();
            this.groupBox_Time = new System.Windows.Forms.GroupBox();
            this.textBox_time_3 = new System.Windows.Forms.TextBox();
            this.textBox_time_2 = new System.Windows.Forms.TextBox();
            this.textBox_time_1 = new System.Windows.Forms.TextBox();
            this.label_Lane1 = new System.Windows.Forms.Label();
            this.label_Lane2 = new System.Windows.Forms.Label();
            this.label_Lane3 = new System.Windows.Forms.Label();
            this.tabPage_settings = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox_AllwaysOnTop = new System.Windows.Forms.CheckBox();
            this.button_PortScan = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.comboBox_PortList = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer_Serial = new System.Windows.Forms.Timer(this.components);
            this.timer_ping = new System.Windows.Forms.Timer(this.components);
            this.label_place1 = new System.Windows.Forms.Label();
            this.label_place2 = new System.Windows.Forms.Label();
            this.label_place3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_main.SuspendLayout();
            this.groupBox_Time.SuspendLayout();
            this.tabPage_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Connection,
            this.toolStripStatusLabel_split_unit,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 176);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(223, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Connection
            // 
            this.toolStripStatusLabel_Connection.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel_Connection.Name = "toolStripStatusLabel_Connection";
            this.toolStripStatusLabel_Connection.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel_Connection.Text = "NOT CONNECTED";
            // 
            // toolStripStatusLabel_split_unit
            // 
            this.toolStripStatusLabel_split_unit.Name = "toolStripStatusLabel_split_unit";
            this.toolStripStatusLabel_split_unit.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel_split_unit.Text = "   ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel1.Text = "Status Pending";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_main);
            this.tabControl1.Controls.Add(this.tabPage_settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(223, 176);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_main
            // 
            this.tabPage_main.Controls.Add(this.groupBox_Time);
            this.tabPage_main.Location = new System.Drawing.Point(4, 22);
            this.tabPage_main.Name = "tabPage_main";
            this.tabPage_main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_main.Size = new System.Drawing.Size(215, 150);
            this.tabPage_main.TabIndex = 0;
            this.tabPage_main.Text = "Main";
            this.tabPage_main.UseVisualStyleBackColor = true;
            // 
            // groupBox_Time
            // 
            this.groupBox_Time.Controls.Add(this.label_place3);
            this.groupBox_Time.Controls.Add(this.label_place2);
            this.groupBox_Time.Controls.Add(this.label_place1);
            this.groupBox_Time.Controls.Add(this.textBox_time_3);
            this.groupBox_Time.Controls.Add(this.textBox_time_2);
            this.groupBox_Time.Controls.Add(this.textBox_time_1);
            this.groupBox_Time.Controls.Add(this.label_Lane1);
            this.groupBox_Time.Controls.Add(this.label_Lane2);
            this.groupBox_Time.Controls.Add(this.label_Lane3);
            this.groupBox_Time.Enabled = false;
            this.groupBox_Time.Location = new System.Drawing.Point(8, 6);
            this.groupBox_Time.Name = "groupBox_Time";
            this.groupBox_Time.Size = new System.Drawing.Size(199, 124);
            this.groupBox_Time.TabIndex = 4;
            this.groupBox_Time.TabStop = false;
            this.groupBox_Time.Text = "Time";
            // 
            // textBox_time_3
            // 
            this.textBox_time_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_time_3.Location = new System.Drawing.Point(71, 83);
            this.textBox_time_3.Name = "textBox_time_3";
            this.textBox_time_3.ReadOnly = true;
            this.textBox_time_3.Size = new System.Drawing.Size(96, 26);
            this.textBox_time_3.TabIndex = 1;
            this.textBox_time_3.Text = "123,45";
            this.textBox_time_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_time_2
            // 
            this.textBox_time_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_time_2.Location = new System.Drawing.Point(71, 51);
            this.textBox_time_2.Name = "textBox_time_2";
            this.textBox_time_2.ReadOnly = true;
            this.textBox_time_2.Size = new System.Drawing.Size(96, 26);
            this.textBox_time_2.TabIndex = 1;
            this.textBox_time_2.Text = "123,45";
            this.textBox_time_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_time_2.TextChanged += new System.EventHandler(this.textBox_time_2_TextChanged);
            // 
            // textBox_time_1
            // 
            this.textBox_time_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_time_1.Location = new System.Drawing.Point(71, 19);
            this.textBox_time_1.Name = "textBox_time_1";
            this.textBox_time_1.ReadOnly = true;
            this.textBox_time_1.Size = new System.Drawing.Size(96, 26);
            this.textBox_time_1.TabIndex = 1;
            this.textBox_time_1.Text = "123,45";
            this.textBox_time_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Lane1
            // 
            this.label_Lane1.AutoSize = true;
            this.label_Lane1.Location = new System.Drawing.Point(6, 27);
            this.label_Lane1.Name = "label_Lane1";
            this.label_Lane1.Size = new System.Drawing.Size(59, 13);
            this.label_Lane1.TabIndex = 0;
            this.label_Lane1.Text = "Lane 1: (X)";
            // 
            // label_Lane2
            // 
            this.label_Lane2.AutoSize = true;
            this.label_Lane2.Location = new System.Drawing.Point(6, 59);
            this.label_Lane2.Name = "label_Lane2";
            this.label_Lane2.Size = new System.Drawing.Size(59, 13);
            this.label_Lane2.TabIndex = 0;
            this.label_Lane2.Text = "Lane 2: (X)";
            // 
            // label_Lane3
            // 
            this.label_Lane3.AutoSize = true;
            this.label_Lane3.Location = new System.Drawing.Point(6, 91);
            this.label_Lane3.Name = "label_Lane3";
            this.label_Lane3.Size = new System.Drawing.Size(59, 13);
            this.label_Lane3.TabIndex = 0;
            this.label_Lane3.Text = "Lane 3: (X)";
            // 
            // tabPage_settings
            // 
            this.tabPage_settings.Controls.Add(this.linkLabel1);
            this.tabPage_settings.Controls.Add(this.checkBox_AllwaysOnTop);
            this.tabPage_settings.Controls.Add(this.button_PortScan);
            this.tabPage_settings.Controls.Add(this.button_Disconnect);
            this.tabPage_settings.Controls.Add(this.button_Connect);
            this.tabPage_settings.Controls.Add(this.comboBox_PortList);
            this.tabPage_settings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_settings.Name = "tabPage_settings";
            this.tabPage_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_settings.Size = new System.Drawing.Size(214, 150);
            this.tabPage_settings.TabIndex = 1;
            this.tabPage_settings.Text = "Settings";
            this.tabPage_settings.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(8, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "© Manuel Fehren [MF-Technologie.de]";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox_AllwaysOnTop
            // 
            this.checkBox_AllwaysOnTop.AutoSize = true;
            this.checkBox_AllwaysOnTop.Checked = true;
            this.checkBox_AllwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AllwaysOnTop.Location = new System.Drawing.Point(9, 64);
            this.checkBox_AllwaysOnTop.Name = "checkBox_AllwaysOnTop";
            this.checkBox_AllwaysOnTop.Size = new System.Drawing.Size(98, 17);
            this.checkBox_AllwaysOnTop.TabIndex = 2;
            this.checkBox_AllwaysOnTop.Text = "Allways on Top";
            this.checkBox_AllwaysOnTop.UseVisualStyleBackColor = true;
            this.checkBox_AllwaysOnTop.CheckedChanged += new System.EventHandler(this.checkBox_AllwaysOnTop_CheckedChanged);
            // 
            // button_PortScan
            // 
            this.button_PortScan.Location = new System.Drawing.Point(163, 4);
            this.button_PortScan.Name = "button_PortScan";
            this.button_PortScan.Size = new System.Drawing.Size(43, 23);
            this.button_PortScan.TabIndex = 1;
            this.button_PortScan.Text = "Scan";
            this.button_PortScan.UseVisualStyleBackColor = true;
            this.button_PortScan.Click += new System.EventHandler(this.button_PortScan_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(85, 34);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(72, 23);
            this.button_Disconnect.TabIndex = 1;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(7, 34);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(72, 23);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // comboBox_PortList
            // 
            this.comboBox_PortList.FormattingEnabled = true;
            this.comboBox_PortList.Location = new System.Drawing.Point(8, 6);
            this.comboBox_PortList.Name = "comboBox_PortList";
            this.comboBox_PortList.Size = new System.Drawing.Size(149, 21);
            this.comboBox_PortList.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // timer_Serial
            // 
            this.timer_Serial.Interval = 50;
            this.timer_Serial.Tick += new System.EventHandler(this.timer_Serial_Tick);
            // 
            // timer_ping
            // 
            this.timer_ping.Interval = 3500;
            this.timer_ping.Tick += new System.EventHandler(this.timer_ping_Tick);
            // 
            // label_place1
            // 
            this.label_place1.AutoSize = true;
            this.label_place1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_place1.Location = new System.Drawing.Point(167, 19);
            this.label_place1.Name = "label_place1";
            this.label_place1.Size = new System.Drawing.Size(32, 24);
            this.label_place1.TabIndex = 2;
            this.label_place1.Text = "(x)";
            // 
            // label_place2
            // 
            this.label_place2.AutoSize = true;
            this.label_place2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_place2.Location = new System.Drawing.Point(167, 51);
            this.label_place2.Name = "label_place2";
            this.label_place2.Size = new System.Drawing.Size(32, 24);
            this.label_place2.TabIndex = 3;
            this.label_place2.Text = "(x)";
            // 
            // label_place3
            // 
            this.label_place3.AutoSize = true;
            this.label_place3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_place3.Location = new System.Drawing.Point(167, 83);
            this.label_place3.Name = "label_place3";
            this.label_place3.Size = new System.Drawing.Size(32, 24);
            this.label_place3.TabIndex = 4;
            this.label_place3.Text = "(x)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 198);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Stoppwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_main.ResumeLayout(false);
            this.groupBox_Time.ResumeLayout(false);
            this.groupBox_Time.PerformLayout();
            this.tabPage_settings.ResumeLayout(false);
            this.tabPage_settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Connection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_main;
        private System.Windows.Forms.Label label_Lane3;
        private System.Windows.Forms.Label label_Lane2;
        private System.Windows.Forms.Label label_Lane1;
        private System.Windows.Forms.TabPage tabPage_settings;
        private System.Windows.Forms.Button button_PortScan;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.ComboBox comboBox_PortList;
        private System.Windows.Forms.GroupBox groupBox_Time;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer_Serial;
        private System.Windows.Forms.Timer timer_ping;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_split_unit;
        private System.Windows.Forms.TextBox textBox_time_3;
        private System.Windows.Forms.TextBox textBox_time_2;
        private System.Windows.Forms.TextBox textBox_time_1;
        private System.Windows.Forms.CheckBox checkBox_AllwaysOnTop;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_place3;
        private System.Windows.Forms.Label label_place2;
        private System.Windows.Forms.Label label_place1;
    }
}

