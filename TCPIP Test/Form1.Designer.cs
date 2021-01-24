
namespace TCPIP_Test
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
            this.label_IP = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label_Port = new System.Windows.Forms.Label();
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_SendMsg = new System.Windows.Forms.TextBox();
            this.label_SendMsg = new System.Windows.Forms.Label();
            this.textBox_RecMsg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(202, 23);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(28, 17);
            this.label_IP.TabIndex = 1;
            this.label_IP.Text = "IP :";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(236, 22);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(139, 22);
            this.textBox_IP.TabIndex = 2;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(392, 21);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 3;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(202, 58);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(42, 17);
            this.label_Port.TabIndex = 4;
            this.label_Port.Text = "Port :";
            // 
            // TextBox_Port
            // 
            this.TextBox_Port.Location = new System.Drawing.Point(259, 55);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(116, 22);
            this.TextBox_Port.TabIndex = 5;
            // 
            // textBox_SendMsg
            // 
            this.textBox_SendMsg.Location = new System.Drawing.Point(27, 126);
            this.textBox_SendMsg.Multiline = true;
            this.textBox_SendMsg.Name = "textBox_SendMsg";
            this.textBox_SendMsg.Size = new System.Drawing.Size(348, 74);
            this.textBox_SendMsg.TabIndex = 7;
            this.textBox_SendMsg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label_SendMsg
            // 
            this.label_SendMsg.AutoSize = true;
            this.label_SendMsg.Location = new System.Drawing.Point(24, 106);
            this.label_SendMsg.Name = "label_SendMsg";
            this.label_SendMsg.Size = new System.Drawing.Size(102, 17);
            this.label_SendMsg.TabIndex = 6;
            this.label_SendMsg.Text = "Send Message";
            // 
            // textBox_RecMsg
            // 
            this.textBox_RecMsg.Location = new System.Drawing.Point(27, 243);
            this.textBox_RecMsg.Multiline = true;
            this.textBox_RecMsg.Name = "textBox_RecMsg";
            this.textBox_RecMsg.Size = new System.Drawing.Size(348, 74);
            this.textBox_RecMsg.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Receive Message";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(392, 126);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 10;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 364);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_RecMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_SendMsg);
            this.Controls.Add(this.label_SendMsg);
            this.Controls.Add(this.TextBox_Port);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label_IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.TextBox TextBox_Port;
        private System.Windows.Forms.TextBox textBox_SendMsg;
        private System.Windows.Forms.Label label_SendMsg;
        private System.Windows.Forms.TextBox textBox_RecMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Send;
    }
}

