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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_main = new System.Windows.Forms.TabPage();
            this.groupBox_Time = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_setTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage_settings = new System.Windows.Forms.TabPage();
            this.button_PortScan = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.comboBox_PortList = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer_Serial = new System.Windows.Forms.Timer(this.components);
            this.timer_ping = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_main.SuspendLayout();
            this.groupBox_Time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Connection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 186);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(242, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Connection
            // 
            this.toolStripStatusLabel_Connection.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel_Connection.Name = "toolStripStatusLabel_Connection";
            this.toolStripStatusLabel_Connection.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel_Connection.Text = "NOT CONNECTED";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_main);
            this.tabControl1.Controls.Add(this.tabPage_settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 186);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_main
            // 
            this.tabPage_main.Controls.Add(this.groupBox_Time);
            this.tabPage_main.Location = new System.Drawing.Point(4, 22);
            this.tabPage_main.Name = "tabPage_main";
            this.tabPage_main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_main.Size = new System.Drawing.Size(234, 160);
            this.tabPage_main.TabIndex = 0;
            this.tabPage_main.Text = "Main";
            this.tabPage_main.UseVisualStyleBackColor = true;
            // 
            // groupBox_Time
            // 
            this.groupBox_Time.Controls.Add(this.label1);
            this.groupBox_Time.Controls.Add(this.button_setTime);
            this.groupBox_Time.Controls.Add(this.label2);
            this.groupBox_Time.Controls.Add(this.numericUpDown3);
            this.groupBox_Time.Controls.Add(this.label3);
            this.groupBox_Time.Controls.Add(this.numericUpDown2);
            this.groupBox_Time.Controls.Add(this.numericUpDown1);
            this.groupBox_Time.Enabled = false;
            this.groupBox_Time.Location = new System.Drawing.Point(8, 6);
            this.groupBox_Time.Name = "groupBox_Time";
            this.groupBox_Time.Size = new System.Drawing.Size(131, 120);
            this.groupBox_Time.TabIndex = 4;
            this.groupBox_Time.TabStop = false;
            this.groupBox_Time.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lane 1:";
            // 
            // button_setTime
            // 
            this.button_setTime.Location = new System.Drawing.Point(9, 91);
            this.button_setTime.Name = "button_setTime";
            this.button_setTime.Size = new System.Drawing.Size(115, 23);
            this.button_setTime.TabIndex = 3;
            this.button_setTime.Text = "Set";
            this.button_setTime.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lane 2:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(55, 65);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lane 3:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(55, 39);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(55, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage_settings
            // 
            this.tabPage_settings.Controls.Add(this.button_PortScan);
            this.tabPage_settings.Controls.Add(this.button_Disconnect);
            this.tabPage_settings.Controls.Add(this.button_Connect);
            this.tabPage_settings.Controls.Add(this.comboBox_PortList);
            this.tabPage_settings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_settings.Name = "tabPage_settings";
            this.tabPage_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_settings.Size = new System.Drawing.Size(234, 160);
            this.tabPage_settings.TabIndex = 1;
            this.tabPage_settings.Text = "Settings";
            this.tabPage_settings.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 208);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage_settings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Connection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_main;
        private System.Windows.Forms.Button button_setTime;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_settings;
        private System.Windows.Forms.Button button_PortScan;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.ComboBox comboBox_PortList;
        private System.Windows.Forms.GroupBox groupBox_Time;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer_Serial;
        private System.Windows.Forms.Timer timer_ping;
    }
}

