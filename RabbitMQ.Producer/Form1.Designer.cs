
namespace RabbitMQ.Producer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.btnDeclareExchange = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeclareExchangeName = new System.Windows.Forms.TextBox();
            this.cmbDeclareExchangeType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeclareQueue = new System.Windows.Forms.Button();
            this.txtDeclareQueueName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBindQueue = new System.Windows.Forms.Button();
            this.txtDeclareRoutingKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbUseCounter = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudRepeat = new System.Windows.Forms.NumericUpDown();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbExclusive = new System.Windows.Forms.CheckBox();
            this.cbAutoDelete = new System.Windows.Forms.CheckBox();
            this.cbDurable = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtConnection);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(261, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtConnection
            // 
            this.txtConnection.Location = new System.Drawing.Point(6, 22);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(249, 23);
            this.txtConnection.TabIndex = 1;
            this.txtConnection.Text = "amqp://admin:123456@192.168.10.14:5672";
            // 
            // btnDeclareExchange
            // 
            this.btnDeclareExchange.Location = new System.Drawing.Point(58, 80);
            this.btnDeclareExchange.Name = "btnDeclareExchange";
            this.btnDeclareExchange.Size = new System.Drawing.Size(278, 23);
            this.btnDeclareExchange.TabIndex = 4;
            this.btnDeclareExchange.Text = "Declare Exchange";
            this.btnDeclareExchange.UseVisualStyleBackColor = true;
            this.btnDeclareExchange.Click += new System.EventHandler(this.btnDeclareExchange_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDeclareExchangeName);
            this.groupBox2.Controls.Add(this.cmbDeclareExchangeType);
            this.groupBox2.Controls.Add(this.btnDeclareExchange);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Declare Exchange";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name :";
            // 
            // txtDeclareExchangeName
            // 
            this.txtDeclareExchangeName.Location = new System.Drawing.Point(58, 22);
            this.txtDeclareExchangeName.Name = "txtDeclareExchangeName";
            this.txtDeclareExchangeName.Size = new System.Drawing.Size(278, 23);
            this.txtDeclareExchangeName.TabIndex = 6;
            // 
            // cmbDeclareExchangeType
            // 
            this.cmbDeclareExchangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeclareExchangeType.FormattingEnabled = true;
            this.cmbDeclareExchangeType.Location = new System.Drawing.Point(58, 51);
            this.cmbDeclareExchangeType.Name = "cmbDeclareExchangeType";
            this.cmbDeclareExchangeType.Size = new System.Drawing.Size(278, 23);
            this.cmbDeclareExchangeType.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbAutoDelete);
            this.groupBox3.Controls.Add(this.cbDurable);
            this.groupBox3.Controls.Add(this.cbExclusive);
            this.groupBox3.Controls.Add(this.btnDeclareQueue);
            this.groupBox3.Controls.Add(this.txtDeclareQueueName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 111);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Declare Queue";
            // 
            // btnDeclareQueue
            // 
            this.btnDeclareQueue.Location = new System.Drawing.Point(58, 76);
            this.btnDeclareQueue.Name = "btnDeclareQueue";
            this.btnDeclareQueue.Size = new System.Drawing.Size(280, 23);
            this.btnDeclareQueue.TabIndex = 8;
            this.btnDeclareQueue.Text = "Declare Queue";
            this.btnDeclareQueue.UseVisualStyleBackColor = true;
            this.btnDeclareQueue.Click += new System.EventHandler(this.btnDeclareQueue_Click);
            // 
            // txtDeclareQueueName
            // 
            this.txtDeclareQueueName.Location = new System.Drawing.Point(58, 22);
            this.txtDeclareQueueName.Name = "txtDeclareQueueName";
            this.txtDeclareQueueName.Size = new System.Drawing.Size(278, 23);
            this.txtDeclareQueueName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBindQueue);
            this.groupBox4.Controls.Add(this.txtDeclareRoutingKey);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(361, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 83);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bind Queue & Exchange";
            // 
            // btnBindQueue
            // 
            this.btnBindQueue.Location = new System.Drawing.Point(57, 51);
            this.btnBindQueue.Name = "btnBindQueue";
            this.btnBindQueue.Size = new System.Drawing.Size(280, 23);
            this.btnBindQueue.TabIndex = 8;
            this.btnBindQueue.Text = "Bind Queue";
            this.btnBindQueue.UseVisualStyleBackColor = true;
            this.btnBindQueue.Click += new System.EventHandler(this.btnBindQueue_Click);
            // 
            // txtDeclareRoutingKey
            // 
            this.txtDeclareRoutingKey.Location = new System.Drawing.Point(58, 22);
            this.txtDeclareRoutingKey.Name = "txtDeclareRoutingKey";
            this.txtDeclareRoutingKey.Size = new System.Drawing.Size(279, 23);
            this.txtDeclareRoutingKey.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.cbUseCounter);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.nudRepeat);
            this.groupBox5.Controls.Add(this.txtMessage);
            this.groupBox5.Controls.Add(this.txtRoutingKey);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtExchangeName);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(361, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 204);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Publish";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Publish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbUseCounter
            // 
            this.cbUseCounter.AutoSize = true;
            this.cbUseCounter.Location = new System.Drawing.Point(163, 172);
            this.cbUseCounter.Name = "cbUseCounter";
            this.cbUseCounter.Size = new System.Drawing.Size(91, 19);
            this.cbUseCounter.TabIndex = 16;
            this.cbUseCounter.Text = "Use Counter";
            this.cbUseCounter.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Repeat :";
            // 
            // nudRepeat
            // 
            this.nudRepeat.Location = new System.Drawing.Point(70, 171);
            this.nudRepeat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRepeat.Name = "nudRepeat";
            this.nudRepeat.Size = new System.Drawing.Size(81, 23);
            this.nudRepeat.TabIndex = 14;
            this.nudRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 80);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(320, 83);
            this.txtMessage.TabIndex = 13;
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(124, 51);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(212, 23);
            this.txtRoutingKey.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Routing Key :";
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(124, 22);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(212, 23);
            this.txtExchangeName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Exchange Name :";
            // 
            // cbExclusive
            // 
            this.cbExclusive.AutoSize = true;
            this.cbExclusive.Location = new System.Drawing.Point(58, 51);
            this.cbExclusive.Name = "cbExclusive";
            this.cbExclusive.Size = new System.Drawing.Size(74, 19);
            this.cbExclusive.TabIndex = 9;
            this.cbExclusive.Text = "Exclusive";
            this.cbExclusive.UseVisualStyleBackColor = true;
            // 
            // cbAutoDelete
            // 
            this.cbAutoDelete.AutoSize = true;
            this.cbAutoDelete.Location = new System.Drawing.Point(248, 51);
            this.cbAutoDelete.Name = "cbAutoDelete";
            this.cbAutoDelete.Size = new System.Drawing.Size(88, 19);
            this.cbAutoDelete.TabIndex = 10;
            this.cbAutoDelete.Text = "Auto Delete";
            this.cbAutoDelete.UseVisualStyleBackColor = true;
            // 
            // cbDurable
            // 
            this.cbDurable.AutoSize = true;
            this.cbDurable.Location = new System.Drawing.Point(151, 51);
            this.cbDurable.Name = "cbDurable";
            this.cbDurable.Size = new System.Drawing.Size(67, 19);
            this.cbDurable.TabIndex = 9;
            this.cbDurable.Text = "Durable";
            this.cbDurable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 316);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.Button btnDeclareExchange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeclareExchangeName;
        private System.Windows.Forms.ComboBox cmbDeclareExchangeType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeclareQueue;
        private System.Windows.Forms.TextBox txtDeclareQueueName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBindQueue;
        private System.Windows.Forms.TextBox txtDeclareRoutingKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtExchangeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbUseCounter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudRepeat;
        private System.Windows.Forms.CheckBox cbAutoDelete;
        private System.Windows.Forms.CheckBox cbExclusive;
        private System.Windows.Forms.CheckBox cbDurable;
    }
}

