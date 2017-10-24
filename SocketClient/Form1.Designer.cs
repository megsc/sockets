namespace SocketClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1_connection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_server = new System.Windows.Forms.TextBox();
            this.textBox2_client = new System.Windows.Forms.TextBox();
            this.label4_EOF = new System.Windows.Forms.Label();
            this.label5_showText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 629);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Message Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1_connection
            // 
            this.label1_connection.AutoSize = true;
            this.label1_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_connection.Location = new System.Drawing.Point(93, 54);
            this.label1_connection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_connection.Name = "label1_connection";
            this.label1_connection.Size = new System.Drawing.Size(64, 25);
            this.label1_connection.TabIndex = 1;
            this.label1_connection.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type Message below:";
            // 
            // textBox1_server
            // 
            this.textBox1_server.Location = new System.Drawing.Point(93, 191);
            this.textBox1_server.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1_server.Multiline = true;
            this.textBox1_server.Name = "textBox1_server";
            this.textBox1_server.Size = new System.Drawing.Size(481, 152);
            this.textBox1_server.TabIndex = 4;
            // 
            // textBox2_client
            // 
            this.textBox2_client.Location = new System.Drawing.Point(98, 418);
            this.textBox2_client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2_client.Multiline = true;
            this.textBox2_client.Name = "textBox2_client";
            this.textBox2_client.Size = new System.Drawing.Size(476, 152);
            this.textBox2_client.TabIndex = 5;
            this.textBox2_client.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShowKeyUp);
            // 
            // label4_EOF
            // 
            this.label4_EOF.AutoSize = true;
            this.label4_EOF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4_EOF.Location = new System.Drawing.Point(352, 586);
            this.label4_EOF.Name = "label4_EOF";
            this.label4_EOF.Size = new System.Drawing.Size(225, 20);
            this.label4_EOF.TabIndex = 6;
            this.label4_EOF.Text = "End the message with: <EOF>";
            // 
            // label5_showText
            // 
            this.label5_showText.AutoSize = true;
            this.label5_showText.Location = new System.Drawing.Point(93, 586);
            this.label5_showText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5_showText.Name = "label5_showText";
            this.label5_showText.Size = new System.Drawing.Size(0, 20);
            this.label5_showText.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 732);
            this.Controls.Add(this.label5_showText);
            this.Controls.Add(this.label4_EOF);
            this.Controls.Add(this.textBox2_client);
            this.Controls.Add(this.textBox1_server);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1_connection);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1_connection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_server;
        private System.Windows.Forms.TextBox textBox2_client;
        private System.Windows.Forms.Label label4_EOF;
        private System.Windows.Forms.Label label5_showText;
    }
}