namespace RS232
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtbChatEntry = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.rtbReceivedText = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbChatEntry
            // 
            this.rtbChatEntry.Location = new System.Drawing.Point(23, 107);
            this.rtbChatEntry.Name = "rtbChatEntry";
            this.rtbChatEntry.Size = new System.Drawing.Size(166, 157);
            this.rtbChatEntry.TabIndex = 0;
            this.rtbChatEntry.Text = "";
            this.rtbChatEntry.TextChanged += new System.EventHandler(this.rtbChatEntry_TextChanged);
            this.rtbChatEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbChatEntry_KeyDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(222, 65);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(121, 24);
            this.cmbSerialPorts.TabIndex = 1;
            this.cmbSerialPorts.SelectedIndexChanged += new System.EventHandler(this.cmbSerialPorts_SelectedIndexChanged);
            // 
            // rtbReceivedText
            // 
            this.rtbReceivedText.Location = new System.Drawing.Point(213, 107);
            this.rtbReceivedText.Name = "rtbReceivedText";
            this.rtbReceivedText.Size = new System.Drawing.Size(166, 157);
            this.rtbReceivedText.TabIndex = 0;
            this.rtbReceivedText.Text = "";
            this.rtbReceivedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbReceivedText_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 294);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 369);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbReceivedText);
            this.Controls.Add(this.cmbSerialPorts);
            this.Controls.Add(this.rtbChatEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbChatEntry;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.RichTextBox rtbReceivedText;
        private System.Windows.Forms.Button btnStart;
    }
}

