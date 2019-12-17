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
            this.components = new System.ComponentModel.Container();
            this.sendTxtBox = new System.Windows.Forms.TextBox();
            this.receiveTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.sendTxtBox2 = new System.Windows.Forms.TextBox();
            this.sendTxtBox3 = new System.Windows.Forms.TextBox();
            this.btnPublish2 = new System.Windows.Forms.Button();
            this.btnPublish3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPublish2 = new System.Windows.Forms.TextBox();
            this.txtPublish3 = new System.Windows.Forms.TextBox();
            this.subscribe3 = new System.Windows.Forms.Button();
            this.unSubScribe3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSubscribe3 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnSelCA = new System.Windows.Forms.Button();
            this.txtInterval2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtInterval4 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtInterval3 = new System.Windows.Forms.TextBox();
            this.chkPublish2 = new System.Windows.Forms.CheckBox();
            this.chkPublish4 = new System.Windows.Forms.CheckBox();
            this.chkPublish3 = new System.Windows.Forms.CheckBox();
            this.chkPublish1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // sendTxtBox
            // 
            this.sendTxtBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendTxtBox.Location = new System.Drawing.Point(1, 399);
            this.sendTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.sendTxtBox.Multiline = true;
            this.sendTxtBox.Name = "sendTxtBox";
            this.sendTxtBox.Size = new System.Drawing.Size(532, 84);
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
            this.receiveTxtBox.Size = new System.Drawing.Size(848, 329);
            this.receiveTxtBox.TabIndex = 3;
            this.receiveTxtBox.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(934, 138);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(864, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "端口:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(927, 37);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(163, 21);
            this.txtHost.TabIndex = 6;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(927, 61);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(163, 21);
            this.txtPort.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(864, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "用户名:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(927, 85);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 21);
            this.txtUser.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(864, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "密码:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(927, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(163, 21);
            this.txtPass.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(864, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "订阅主题:";
            // 
            // txtSubscribe
            // 
            this.txtSubscribe.Location = new System.Drawing.Point(927, 163);
            this.txtSubscribe.Name = "txtSubscribe";
            this.txtSubscribe.Size = new System.Drawing.Size(163, 21);
            this.txtSubscribe.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "主题:";
            // 
            // txtPublish
            // 
            this.txtPublish.Location = new System.Drawing.Point(30, 372);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.Size = new System.Drawing.Size(258, 21);
            this.txtPublish.TabIndex = 6;
            // 
            // subscribe
            // 
            this.subscribe.Enabled = false;
            this.subscribe.Location = new System.Drawing.Point(1015, 186);
            this.subscribe.Name = "subscribe";
            this.subscribe.Size = new System.Drawing.Size(75, 23);
            this.subscribe.TabIndex = 4;
            this.subscribe.Text = "订阅";
            this.subscribe.UseVisualStyleBackColor = true;
            this.subscribe.Click += new System.EventHandler(this.subscribe_Click);
            // 
            // publish
            // 
            this.publish.Enabled = false;
            this.publish.Location = new System.Drawing.Point(465, 367);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(62, 28);
            this.publish.TabIndex = 4;
            this.publish.Text = "发布";
            this.publish.UseVisualStyleBackColor = true;
            this.publish.Click += new System.EventHandler(this.publish_Click);
            // 
            // unSubScribe
            // 
            this.unSubScribe.Enabled = false;
            this.unSubScribe.Location = new System.Drawing.Point(934, 186);
            this.unSubScribe.Name = "unSubScribe";
            this.unSubScribe.Size = new System.Drawing.Size(75, 23);
            this.unSubScribe.TabIndex = 4;
            this.unSubScribe.Text = "取消订阅";
            this.unSubScribe.UseVisualStyleBackColor = true;
            this.unSubScribe.Click += new System.EventHandler(this.unSubScribe_click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Location = new System.Drawing.Point(936, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(66, 5);
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
            this.label1.Location = new System.Drawing.Point(864, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "订阅主题:";
            // 
            // txtSubscribe1
            // 
            this.txtSubscribe1.Location = new System.Drawing.Point(927, 212);
            this.txtSubscribe1.Name = "txtSubscribe1";
            this.txtSubscribe1.Size = new System.Drawing.Size(163, 21);
            this.txtSubscribe1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(864, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "订阅主题:";
            // 
            // txtSubscribe2
            // 
            this.txtSubscribe2.Location = new System.Drawing.Point(927, 261);
            this.txtSubscribe2.Name = "txtSubscribe2";
            this.txtSubscribe2.Size = new System.Drawing.Size(163, 21);
            this.txtSubscribe2.TabIndex = 6;
            // 
            // subscribe1
            // 
            this.subscribe1.Enabled = false;
            this.subscribe1.Location = new System.Drawing.Point(1015, 235);
            this.subscribe1.Name = "subscribe1";
            this.subscribe1.Size = new System.Drawing.Size(75, 23);
            this.subscribe1.TabIndex = 4;
            this.subscribe1.Text = "订阅";
            this.subscribe1.UseVisualStyleBackColor = true;
            this.subscribe1.Click += new System.EventHandler(this.subscribe1_Click);
            // 
            // unSubScribe1
            // 
            this.unSubScribe1.Enabled = false;
            this.unSubScribe1.Location = new System.Drawing.Point(934, 235);
            this.unSubScribe1.Name = "unSubScribe1";
            this.unSubScribe1.Size = new System.Drawing.Size(75, 23);
            this.unSubScribe1.TabIndex = 4;
            this.unSubScribe1.Text = "取消订阅";
            this.unSubScribe1.UseVisualStyleBackColor = true;
            this.unSubScribe1.Click += new System.EventHandler(this.unSubScribe1_Click);
            // 
            // subscribe2
            // 
            this.subscribe2.Enabled = false;
            this.subscribe2.Location = new System.Drawing.Point(1015, 285);
            this.subscribe2.Name = "subscribe2";
            this.subscribe2.Size = new System.Drawing.Size(75, 23);
            this.subscribe2.TabIndex = 4;
            this.subscribe2.Text = "订阅";
            this.subscribe2.UseVisualStyleBackColor = true;
            this.subscribe2.Click += new System.EventHandler(this.subscribe2_Click);
            // 
            // unSubScribe2
            // 
            this.unSubScribe2.Enabled = false;
            this.unSubScribe2.Location = new System.Drawing.Point(934, 285);
            this.unSubScribe2.Name = "unSubScribe2";
            this.unSubScribe2.Size = new System.Drawing.Size(75, 23);
            this.unSubScribe2.TabIndex = 4;
            this.unSubScribe2.Text = "取消订阅";
            this.unSubScribe2.UseVisualStyleBackColor = true;
            this.unSubScribe2.Click += new System.EventHandler(this.unSubScribe2_Click);
            // 
            // sendTxtBox1
            // 
            this.sendTxtBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendTxtBox1.Location = new System.Drawing.Point(540, 398);
            this.sendTxtBox1.Margin = new System.Windows.Forms.Padding(2);
            this.sendTxtBox1.Multiline = true;
            this.sendTxtBox1.Name = "sendTxtBox1";
            this.sendTxtBox1.Size = new System.Drawing.Size(550, 85);
            this.sendTxtBox1.TabIndex = 1;
            // 
            // publish1
            // 
            this.publish1.Enabled = false;
            this.publish1.Location = new System.Drawing.Point(1023, 367);
            this.publish1.Name = "publish1";
            this.publish1.Size = new System.Drawing.Size(65, 28);
            this.publish1.TabIndex = 4;
            this.publish1.Text = "发布";
            this.publish1.UseVisualStyleBackColor = true;
            this.publish1.Click += new System.EventHandler(this.publish1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(538, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "主题:";
            // 
            // txtPublish1
            // 
            this.txtPublish1.Location = new System.Drawing.Point(573, 370);
            this.txtPublish1.Name = "txtPublish1";
            this.txtPublish1.Size = new System.Drawing.Size(271, 21);
            this.txtPublish1.TabIndex = 6;
            // 
            // sendTxtBox2
            // 
            this.sendTxtBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendTxtBox2.Location = new System.Drawing.Point(0, 516);
            this.sendTxtBox2.Margin = new System.Windows.Forms.Padding(2);
            this.sendTxtBox2.Multiline = true;
            this.sendTxtBox2.Name = "sendTxtBox2";
            this.sendTxtBox2.Size = new System.Drawing.Size(531, 89);
            this.sendTxtBox2.TabIndex = 1;
            // 
            // sendTxtBox3
            // 
            this.sendTxtBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendTxtBox3.Location = new System.Drawing.Point(540, 518);
            this.sendTxtBox3.Margin = new System.Windows.Forms.Padding(2);
            this.sendTxtBox3.Multiline = true;
            this.sendTxtBox3.Name = "sendTxtBox3";
            this.sendTxtBox3.Size = new System.Drawing.Size(550, 87);
            this.sendTxtBox3.TabIndex = 1;
            // 
            // btnPublish2
            // 
            this.btnPublish2.Enabled = false;
            this.btnPublish2.Location = new System.Drawing.Point(465, 484);
            this.btnPublish2.Name = "btnPublish2";
            this.btnPublish2.Size = new System.Drawing.Size(60, 28);
            this.btnPublish2.TabIndex = 4;
            this.btnPublish2.Text = "发布";
            this.btnPublish2.UseVisualStyleBackColor = true;
            this.btnPublish2.Click += new System.EventHandler(this.publish2_Click);
            // 
            // btnPublish3
            // 
            this.btnPublish3.Enabled = false;
            this.btnPublish3.Location = new System.Drawing.Point(1032, 484);
            this.btnPublish3.Name = "btnPublish3";
            this.btnPublish3.Size = new System.Drawing.Size(56, 28);
            this.btnPublish3.TabIndex = 4;
            this.btnPublish3.Text = "发布";
            this.btnPublish3.UseVisualStyleBackColor = true;
            this.btnPublish3.Click += new System.EventHandler(this.publish3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-2, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "主题:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(533, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "主题:";
            // 
            // txtPublish2
            // 
            this.txtPublish2.Location = new System.Drawing.Point(29, 489);
            this.txtPublish2.Name = "txtPublish2";
            this.txtPublish2.Size = new System.Drawing.Size(257, 21);
            this.txtPublish2.TabIndex = 6;
            // 
            // txtPublish3
            // 
            this.txtPublish3.Location = new System.Drawing.Point(571, 488);
            this.txtPublish3.Name = "txtPublish3";
            this.txtPublish3.Size = new System.Drawing.Size(271, 21);
            this.txtPublish3.TabIndex = 6;
            // 
            // subscribe3
            // 
            this.subscribe3.Enabled = false;
            this.subscribe3.Location = new System.Drawing.Point(1015, 338);
            this.subscribe3.Name = "subscribe3";
            this.subscribe3.Size = new System.Drawing.Size(75, 23);
            this.subscribe3.TabIndex = 4;
            this.subscribe3.Text = "订阅";
            this.subscribe3.UseVisualStyleBackColor = true;
            this.subscribe3.Click += new System.EventHandler(this.subscribe3_Click);
            // 
            // unSubScribe3
            // 
            this.unSubScribe3.Enabled = false;
            this.unSubScribe3.Location = new System.Drawing.Point(934, 338);
            this.unSubScribe3.Name = "unSubScribe3";
            this.unSubScribe3.Size = new System.Drawing.Size(75, 23);
            this.unSubScribe3.TabIndex = 4;
            this.unSubScribe3.Text = "取消订阅";
            this.unSubScribe3.UseVisualStyleBackColor = true;
            this.unSubScribe3.Click += new System.EventHandler(this.unSubScribe3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(864, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "订阅主题:";
            // 
            // txtSubscribe3
            // 
            this.txtSubscribe3.Location = new System.Drawing.Point(927, 314);
            this.txtSubscribe3.Name = "txtSubscribe3";
            this.txtSubscribe3.Size = new System.Drawing.Size(163, 21);
            this.txtSubscribe3.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(1013, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "断开服务器";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(864, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "服务器:";
            // 
            // txtClientID
            // 
            this.txtClientID.Enabled = false;
            this.txtClientID.Location = new System.Drawing.Point(228, 3);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(163, 21);
            this.txtClientID.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(150, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "ClientID";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtCa
            // 
            this.txtCa.Enabled = false;
            this.txtCa.Location = new System.Drawing.Point(462, 5);
            this.txtCa.Name = "txtCa";
            this.txtCa.Size = new System.Drawing.Size(335, 21);
            this.txtCa.TabIndex = 6;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(408, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "证书";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnSelCA
            // 
            this.btnSelCA.Location = new System.Drawing.Point(803, 3);
            this.btnSelCA.Name = "btnSelCA";
            this.btnSelCA.Size = new System.Drawing.Size(41, 23);
            this.btnSelCA.TabIndex = 8;
            this.btnSelCA.Text = "选取";
            this.btnSelCA.UseVisualStyleBackColor = true;
            this.btnSelCA.Click += new System.EventHandler(this.btnSelCA_Click);
            // 
            // txtInterval2
            // 
            this.txtInterval2.Enabled = false;
            this.txtInterval2.Location = new System.Drawing.Point(900, 372);
            this.txtInterval2.Name = "txtInterval2";
            this.txtInterval2.Size = new System.Drawing.Size(84, 21);
            this.txtInterval2.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(990, 374);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 5;
            this.label20.Text = "毫秒";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(989, 491);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 5;
            this.label21.Text = "毫秒";
            // 
            // txtInterval4
            // 
            this.txtInterval4.Enabled = false;
            this.txtInterval4.Location = new System.Drawing.Point(902, 486);
            this.txtInterval4.Name = "txtInterval4";
            this.txtInterval4.Size = new System.Drawing.Size(80, 21);
            this.txtInterval4.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(423, 377);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 5;
            this.label23.Text = "毫秒";
            // 
            // txtInterval
            // 
            this.txtInterval.Enabled = false;
            this.txtInterval.Location = new System.Drawing.Point(348, 372);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(67, 21);
            this.txtInterval.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(432, 494);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 5;
            this.label25.Text = "毫秒";
            // 
            // txtInterval3
            // 
            this.txtInterval3.Enabled = false;
            this.txtInterval3.Location = new System.Drawing.Point(347, 491);
            this.txtInterval3.Name = "txtInterval3";
            this.txtInterval3.Size = new System.Drawing.Size(79, 21);
            this.txtInterval3.TabIndex = 6;
            // 
            // chkPublish2
            // 
            this.chkPublish2.AutoSize = true;
            this.chkPublish2.Location = new System.Drawing.Point(851, 374);
            this.chkPublish2.Name = "chkPublish2";
            this.chkPublish2.Size = new System.Drawing.Size(48, 16);
            this.chkPublish2.TabIndex = 9;
            this.chkPublish2.Text = "间隔";
            this.chkPublish2.UseVisualStyleBackColor = true;
            this.chkPublish2.CheckedChanged += new System.EventHandler(this.chkPublish2_CheckedChanged);
            // 
            // chkPublish4
            // 
            this.chkPublish4.AutoSize = true;
            this.chkPublish4.Location = new System.Drawing.Point(848, 491);
            this.chkPublish4.Name = "chkPublish4";
            this.chkPublish4.Size = new System.Drawing.Size(48, 16);
            this.chkPublish4.TabIndex = 9;
            this.chkPublish4.Text = "间隔";
            this.chkPublish4.UseVisualStyleBackColor = true;
            this.chkPublish4.CheckedChanged += new System.EventHandler(this.chkPublish4_CheckedChanged);
            // 
            // chkPublish3
            // 
            this.chkPublish3.AutoSize = true;
            this.chkPublish3.Location = new System.Drawing.Point(298, 494);
            this.chkPublish3.Name = "chkPublish3";
            this.chkPublish3.Size = new System.Drawing.Size(48, 16);
            this.chkPublish3.TabIndex = 9;
            this.chkPublish3.Text = "间隔";
            this.chkPublish3.UseVisualStyleBackColor = true;
            this.chkPublish3.CheckedChanged += new System.EventHandler(this.chkPublish3_CheckedChanged);
            // 
            // chkPublish1
            // 
            this.chkPublish1.AutoSize = true;
            this.chkPublish1.Location = new System.Drawing.Point(299, 376);
            this.chkPublish1.Name = "chkPublish1";
            this.chkPublish1.Size = new System.Drawing.Size(48, 16);
            this.chkPublish1.TabIndex = 9;
            this.chkPublish1.Text = "间隔";
            this.chkPublish1.UseVisualStyleBackColor = true;
            this.chkPublish1.CheckedChanged += new System.EventHandler(this.chkPublish1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 616);
            this.Controls.Add(this.chkPublish1);
            this.Controls.Add(this.chkPublish3);
            this.Controls.Add(this.chkPublish4);
            this.Controls.Add(this.chkPublish2);
            this.Controls.Add(this.btnSelCA);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtInterval3);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtInterval4);
            this.Controls.Add(this.txtInterval2);
            this.Controls.Add(this.txtPublish3);
            this.Controls.Add(this.txtPublish1);
            this.Controls.Add(this.txtPublish2);
            this.Controls.Add(this.txtPublish);
            this.Controls.Add(this.txtSubscribe3);
            this.Controls.Add(this.txtSubscribe2);
            this.Controls.Add(this.txtSubscribe1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtSubscribe);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCa);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPublish3);
            this.Controls.Add(this.publish1);
            this.Controls.Add(this.btnPublish2);
            this.Controls.Add(this.publish);
            this.Controls.Add(this.unSubScribe3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.unSubScribe2);
            this.Controls.Add(this.unSubScribe1);
            this.Controls.Add(this.subscribe3);
            this.Controls.Add(this.unSubScribe);
            this.Controls.Add(this.subscribe2);
            this.Controls.Add(this.subscribe1);
            this.Controls.Add(this.subscribe);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.receiveTxtBox);
            this.Controls.Add(this.sendTxtBox3);
            this.Controls.Add(this.sendTxtBox2);
            this.Controls.Add(this.sendTxtBox1);
            this.Controls.Add(this.sendTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox sendTxtBox2;
        private System.Windows.Forms.TextBox sendTxtBox3;
        private System.Windows.Forms.Button btnPublish2;
        private System.Windows.Forms.Button btnPublish3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPublish2;
        private System.Windows.Forms.TextBox txtPublish3;
        private System.Windows.Forms.Button subscribe3;
        private System.Windows.Forms.Button unSubScribe3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSubscribe3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtCa;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnSelCA;
        private System.Windows.Forms.TextBox txtInterval2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtInterval4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtInterval3;
        private System.Windows.Forms.CheckBox chkPublish2;
        private System.Windows.Forms.CheckBox chkPublish4;
        private System.Windows.Forms.CheckBox chkPublish3;
        private System.Windows.Forms.CheckBox chkPublish1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

