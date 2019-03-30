namespace Mqtt_Client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sendTxtBox = new System.Windows.Forms.TextBox();
            this.receiveTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubscribe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPublish = new System.Windows.Forms.TextBox();
            this.subscribe = new System.Windows.Forms.Button();
            this.publish = new System.Windows.Forms.Button();
            this.unSubScribe = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubscribe1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubscribe2 = new System.Windows.Forms.TextBox();
            this.subscribe1 = new System.Windows.Forms.Button();
            this.unSubScribe1 = new System.Windows.Forms.Button();
            this.subscribe2 = new System.Windows.Forms.Button();
            this.unSubScribe2 = new System.Windows.Forms.Button();
            this.sendTxtBox1 = new System.Windows.Forms.TextBox();
            this.publish1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPublish1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendTxtBox
            // 
            this.sendTxtBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendTxtBox.Location = new System.Drawing.Point(1, 399);
            this.sendTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.sendTxtBox.Multiline = true;
            this.sendTxtBox.Name = "sendTxtBox";
            this.sendTxtBox.Size = new System.Drawing.Size(441, 80);
            this.sendTxtBox.TabIndex = 1;
            // 
            // receiveTxtBox
            // 
            this.receiveTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.receiveTxtBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.receiveTxtBox.Location = new System.Drawing.Point(11, 28);
            this.receiveTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.receiveTxtBox.Name = "receiveTxtBox";
            this.receiveTxtBox.ReadOnly = true;
            this.receiveTxtBox.Size = new System.Drawing.Size(644, 329);
            this.receiveTxtBox.TabIndex = 3;
            this.receiveTxtBox.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(820, 118);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接服务器";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "接收端:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "服务器:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "端口:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(732, 10);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(163, 21);
            this.txtHost.TabIndex = 6;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(732, 37);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(163, 21);
            this.txtPort.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "用户名:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(732, 64);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 21);
            this.txtUser.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "密码:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(732, 91);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(163, 21);
            this.txtPass.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "订阅主题:";
            // 
            // txtSubscribe
            // 
            this.txtSubscribe.Location = new System.Drawing.Point(732, 157);
            this.txtSubscribe.Name = "txtSubscribe";
            this.txtSubscribe.Size = new System.Drawing.Size(163, 21);
            this.txtSubscribe.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "发布主题:";
            // 
            // txtPublish
            // 
            this.txtPublish.Location = new System.Drawing.Point(75, 373);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.Size = new System.Drawing.Size(270, 21);
            this.txtPublish.TabIndex = 6;
            // 
            // subscribe
            // 
            this.subscribe.Location = new System.Drawing.Point(820, 184);
            this.subscribe.Name = "subscribe";
            this.subscribe.Size = new System.Drawing.Size(75, 23);
            this.subscribe.TabIndex = 4;
            this.subscribe.Text = "订阅";
            this.subscribe.UseVisualStyleBackColor = true;
            this.subscribe.Click += new System.EventHandler(this.subscribe_Click);
            // 
            // publish
            // 
            this.publish.Location = new System.Drawing.Point(366, 368);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(41, 28);
            this.publish.TabIndex = 4;
            this.publish.Text = "发布";
            this.publish.UseVisualStyleBackColor = true;
            this.publish.Click += new System.EventHandler(this.publish_Click);
            // 
            // unSubScribe
            // 
            this.unSubScribe.Location = new System.Drawing.Point(739, 184);
            this.unSubScribe.Name = "unSubScribe";
            this.unSubScribe.Size = new System.Drawing.Size(75, 23);
            this.unSubScribe.TabIndex = 4;
            this.unSubScribe.Text = "取消订阅";
            this.unSubScribe.UseVisualStyleBackColor = true;
            this.unSubScribe.Click += new System.EventHandler(this.unSubScribe_click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(671, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(224, 22);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(580, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "订阅主题:";
            // 
            // txtSubscribe1
            // 
            this.txtSubscribe1.Location = new System.Drawing.Point(732, 212);
            this.txtSubscribe1.Name = "txtSubscribe1";
            this.txtSubscribe1.Size = new System.Drawing.Size(163, 21);
            this.txtSubscribe1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(669, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "订阅主题:";
            // 
            // txtSubscribe2
            // 
            this.txtSubscribe2.Location = new System.Drawing.Point(732, 268);
            this.txtSubscribe2.Name = "txtSubscribe2";
            this.txtSubscribe2.Size = new System.Drawing.Size(163, 21);
            this.txtSubscribe2.TabIndex = 6;
            // 
            // subscribe1
            // 
            this.subscribe1.Location = new System.Drawing.Point(820, 239);
            this.subscribe1.Name = "subscribe1";
            this.subscribe1.Size = new System.Drawing.Size(75, 23);
            this.subscribe1.TabIndex = 4;
            this.subscribe1.Text = "订阅";
            this.subscribe1.UseVisualStyleBackColor = true;
            this.subscribe1.Click += new System.EventHandler(this.subscribe1_Click);
            // 
            // unSubScribe1
            // 
            this.unSubScribe1.Location = new System.Drawing.Point(739, 239);
            this.unSubScribe1.Name = "unSubScribe1";
            this.unSubScribe1.Size = new System.Drawing.Size(75, 23);
            this.unSubScribe1.TabIndex = 4;
            this.unSubScribe1.Text = "取消订阅";
            this.unSubScribe1.UseVisualStyleBackColor = true;
            this.unSubScribe1.Click += new System.EventHandler(this.unSubScribe1_Click);
            // 
            // subscribe2
            // 
            this.subscribe2.Location = new System.Drawing.Point(820, 295);
            this.subscribe2.Name = "subscribe2";
            this.subscribe2.Size = new System.Drawing.Size(75, 23);
            this.subscribe2.TabIndex = 4;
            this.subscribe2.Text = "订阅";
            this.subscribe2.UseVisualStyleBackColor = true;
            this.subscribe2.Click += new System.EventHandler(this.subscribe2_Click);
            // 
            // unSubScribe2
            // 
            this.unSubScribe2.Location = new System.Drawing.Point(739, 295);
            this.unSubScribe2.Name = "unSubScribe2";
            this.unSubScribe2.Size = new System.Drawing.Size(75, 23);
            this.unSubScribe2.TabIndex = 4;
            this.unSubScribe2.Text = "取消订阅";
            this.unSubScribe2.UseVisualStyleBackColor = true;
            this.unSubScribe2.Click += new System.EventHandler(this.unSubScribe2_Click);
            // 
            // sendTxtBox1
            // 
            this.sendTxtBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendTxtBox1.Location = new System.Drawing.Point(446, 399);
            this.sendTxtBox1.Margin = new System.Windows.Forms.Padding(2);
            this.sendTxtBox1.Multiline = true;
            this.sendTxtBox1.Name = "sendTxtBox1";
            this.sendTxtBox1.Size = new System.Drawing.Size(449, 80);
            this.sendTxtBox1.TabIndex = 1;
            // 
            // publish1
            // 
            this.publish1.Location = new System.Drawing.Point(798, 368);
            this.publish1.Name = "publish1";
            this.publish1.Size = new System.Drawing.Size(41, 28);
            this.publish1.TabIndex = 4;
            this.publish1.Text = "发布";
            this.publish1.UseVisualStyleBackColor = true;
            this.publish1.Click += new System.EventHandler(this.publish1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(444, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "发布主题:";
            // 
            // txtPublish1
            // 
            this.txtPublish1.Location = new System.Drawing.Point(509, 373);
            this.txtPublish1.Name = "txtPublish1";
            this.txtPublish1.Size = new System.Drawing.Size(268, 21);
            this.txtPublish1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 491);
            this.Controls.Add(this.txtPublish1);
            this.Controls.Add(this.txtPublish);
            this.Controls.Add(this.txtSubscribe2);
            this.Controls.Add(this.txtSubscribe1);
            this.Controls.Add(this.txtSubscribe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.publish1);
            this.Controls.Add(this.publish);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.unSubScribe2);
            this.Controls.Add(this.unSubScribe1);
            this.Controls.Add(this.unSubScribe);
            this.Controls.Add(this.subscribe2);
            this.Controls.Add(this.subscribe1);
            this.Controls.Add(this.subscribe);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.receiveTxtBox);
            this.Controls.Add(this.sendTxtBox1);
            this.Controls.Add(this.sendTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mqtt客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //void client_mqttmsgpublishreceived(object sender, mqttmsgpublisheventargs e)
        //{
        //    //处理接收到的消息
        //    string msg = system.text.encoding.default.getstring(e.message);
        //    receivetxtbox.appendtext("收到消息：" + msg + "\r\n");
        //}
        private System.Windows.Forms.TextBox sendTxtBox;
        private System.Windows.Forms.RichTextBox receiveTxtBox;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubscribe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPublish;
        private System.Windows.Forms.Button subscribe;
        private System.Windows.Forms.Button publish;
        private System.Windows.Forms.Button unSubScribe;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubscribe1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubscribe2;
        private System.Windows.Forms.Button subscribe1;
        private System.Windows.Forms.Button unSubScribe1;
        private System.Windows.Forms.Button subscribe2;
        private System.Windows.Forms.Button unSubScribe2;
        private System.Windows.Forms.TextBox sendTxtBox1;
        private System.Windows.Forms.Button publish1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPublish1;
    }
}

