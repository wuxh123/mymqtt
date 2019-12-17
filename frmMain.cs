using System;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace Mqtt_Client
{
    public partial class Form1 : Form
    {
        private MqttClient client;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 接收事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //获取当前时间
            string tradeTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);

            //处理接收到的消息
            string msg = System.Text.Encoding.UTF8.GetString(e.Message);

            //以下增加了接收到的消息内容颜色不同的功能
            receiveTxtBox.SelectionColor = Color.Red;
            receiveTxtBox.SelectedText = tradeTime + "," + e.Topic + "：";
            receiveTxtBox.SelectionColor = Color.DarkCyan;
            receiveTxtBox.AppendText(msg + "\r\n");
            this.receiveTxtBox.Focus();//让文本框获取焦点 
            this.receiveTxtBox.Select(this.receiveTxtBox.TextLength, 0);//设置光标的位置到文本尾
            this.receiveTxtBox.ScrollToCaret();//滚动到控件光标处
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                client.Disconnect();
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 获取AppSettings中某一节点值
        /// </summary>
        /// <param name="key"></param>
        public static string GetConfigValue(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] != null)
                return config.AppSettings.Settings[key].Value;
            else

                return string.Empty;
        }

        /// <summary>
        /// 修改AppSettings中配置
        /// </summary>
        /// <param name="key">key值</param>
        /// <param name="value">相应值</param>
        public static bool SetConfigValue(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings[key] != null)
                    config.AppSettings.Settings[key].Value = value;
                else
                    config.AppSettings.Settings.Add(key, value);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 连接服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;

                string tradeTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
                receiveTxtBox.ForeColor = Color.Red;

                string clientId = "";
                if (checkBox1.Checked)
                {
                    //使用指定ID
                    clientId = txtClientID.Text;
                }
                else
                {
                    //生成ID
                    clientId = System.Guid.NewGuid().ToString(); //Guid.NewGuid().ToString();
                }


                if (checkBox2.Checked)
                {
                    //使用证书
                    receiveTxtBox.AppendText(tradeTime + " 使用证书连接服务器……\r\n");
                    X509Certificate caCert = new X509Certificate(txtCa.Text);
                    //单向SSL通信
                    client = new MqttClient(txtHost.Text.ToString(), int.Parse(txtPort.Text), true, caCert, null, MqttSslProtocols.TLSv1_2, new RemoteCertificateValidationCallback(cafileValidCallback));
                    // 注册消息接收处理事件，还可以注册消息订阅成功、取消订阅成功、与服务器断开等事件处理函数
                    client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                }
                else
                {
                    //创建客户端实例
                    client = new MqttClient(txtHost.Text.ToString(), int.Parse(txtPort.Text), false, null, null, MqttSslProtocols.None);
                    // 注册消息接收处理事件，还可以注册消息订阅成功、取消订阅成功、与服务器断开等事件处理函数
                    client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                    //不使用证书
                    receiveTxtBox.AppendText(tradeTime + " 不使用证书连接服务器……\r\n");                    
                }
                client.Connect(clientId, txtUser.Text, txtPass.Text);

                //启动button
                tradeTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
                if (client.IsConnected)
                {
                    receiveTxtBox.SelectionColor = Color.Blue;
                    receiveTxtBox.AppendText(tradeTime + " 成功连接服务器。\r\n");
                    unSubScribe.Enabled = true;
                    unSubScribe1.Enabled = true;
                    unSubScribe2.Enabled = true;
                    unSubScribe3.Enabled = true;
                    subscribe.Enabled = true;
                    subscribe1.Enabled = true;
                    subscribe2.Enabled = true;
                    subscribe3.Enabled = true;
                    publish.Enabled = true;
                    publish1.Enabled = true;
                    btnPublish2.Enabled = true;
                    btnPublish3.Enabled = true;
                    btnClose.Enabled = true;
                }
                else
                    receiveTxtBox.AppendText(tradeTime + " 连接服务器失败！\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 取消订阅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unSubScribe_click(object sender, EventArgs e)
        {
            client.Unsubscribe(new string[] { txtSubscribe.Text });
            receiveTxtBox.AppendText("取消订阅" + txtSubscribe.Text + "\r\n");
        }

        /// <summary>
        /// 订阅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subscribe_Click(object sender, EventArgs e)
        {
            try
            {
                // 订阅主题"/home/temperature" 消息质量为 0 
                client.Subscribe(new string[] { txtSubscribe.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                receiveTxtBox.AppendText("订阅" + txtSubscribe.Text + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 发布
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void publish_Click(object sender, EventArgs e)
        {
            try
            {
                if ((chkPublish1.Checked) && (((Button)sender).Text == "发布"))
                {
                    ((Button)sender).Text = "停止";
                    timer1.Interval = int.Parse(txtInterval.Text);
                    timer1.Enabled = true;
                }
                else if (((Button)sender).Text == "停止")
                {
                    ((Button)sender).Text = "发布";
                    timer1.Enabled = false;
                }
                else
                {
                    client.Publish(txtPublish.Text, Encoding.UTF8.GetBytes(sendTxtBox.Text.Trim()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SetConfigValue("host", txtHost.Text);
            SetConfigValue("port", txtPort.Text);
            SetConfigValue("user", txtUser.Text);
            SetConfigValue("password", txtPass.Text);
            SetConfigValue("subscribe", txtSubscribe.Text);
            SetConfigValue("subscribe1", txtSubscribe1.Text);
            SetConfigValue("subscribe2", txtSubscribe2.Text);
            SetConfigValue("subscribe3", txtSubscribe3.Text);
            SetConfigValue("publish", txtPublish.Text);
            SetConfigValue("lastMsg", sendTxtBox.Text);
            SetConfigValue("publish1", txtPublish1.Text);
            SetConfigValue("lastMsg1", sendTxtBox1.Text);
            SetConfigValue("publish2", txtPublish2.Text);
            SetConfigValue("lastMsg2", sendTxtBox2.Text);
            SetConfigValue("publish3", txtPublish3.Text);
            SetConfigValue("lastMsg3", sendTxtBox3.Text);
            SetConfigValue("txtInterval", txtInterval.Text);
            SetConfigValue("txtInterval2", txtInterval2.Text);
            SetConfigValue("txtInterval3", txtInterval3.Text);
            SetConfigValue("txtInterval4", txtInterval4.Text);
            SetConfigValue("clientid", txtInterval.Text);
            SetConfigValue("CA", txtCa.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHost.Text = GetConfigValue("host");
            txtPort.Text = GetConfigValue("port");
            txtUser.Text = GetConfigValue("user");
            txtPass.Text = GetConfigValue("password");
            txtSubscribe.Text = GetConfigValue("subscribe");
            txtSubscribe1.Text = GetConfigValue("subscribe1");
            txtSubscribe2.Text = GetConfigValue("subscribe2");
            txtSubscribe3.Text = GetConfigValue("subscribe3");
            txtPublish.Text = GetConfigValue("publish");
            sendTxtBox.Text = GetConfigValue("lastMsg");
            txtPublish1.Text = GetConfigValue("publish1");
            sendTxtBox1.Text = GetConfigValue("lastMsg1");
            txtPublish2.Text = GetConfigValue("publish2");
            sendTxtBox2.Text = GetConfigValue("lastMsg2");
            txtPublish3.Text = GetConfigValue("publish3");
            sendTxtBox3.Text = GetConfigValue("lastMsg3");
            txtInterval.Text = GetConfigValue("txtInterval");
            txtInterval2.Text = GetConfigValue("txtInterval2");
            txtInterval3.Text = GetConfigValue("txtInterval3");
            txtInterval4.Text = GetConfigValue("txtInterval4");
            txtClientID.Text = GetConfigValue("clientid");
            txtCa.Text = GetConfigValue("CA");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            receiveTxtBox.Text = "";
        }

        private void unSubScribe1_Click(object sender, EventArgs e)
        {
            client.Unsubscribe(new string[] { txtSubscribe1.Text });
            receiveTxtBox.AppendText("取消订阅" + txtSubscribe1.Text + "\r\n");
        }

        private void unSubScribe2_Click(object sender, EventArgs e)
        {
            client.Unsubscribe(new string[] { txtSubscribe2.Text });
            receiveTxtBox.AppendText("取消订阅" + txtSubscribe2.Text + "\r\n");
        }

        private void subscribe1_Click(object sender, EventArgs e)
        {
            try
            {
                // 订阅主题"/home/temperature" 消息质量为 0 
                client.Subscribe(new string[] { txtSubscribe1.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                receiveTxtBox.AppendText("订阅" + txtSubscribe1.Text + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void subscribe2_Click(object sender, EventArgs e)
        {
            try
            {
                // 订阅主题"/home/temperature" 消息质量为 0 
                client.Subscribe(new string[] { txtSubscribe2.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                receiveTxtBox.AppendText("订阅" + txtSubscribe2.Text + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void publish1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((chkPublish2.Checked) && (((Button)sender).Text == "发布"))
                {
                    ((Button)sender).Text = "停止";
                    timer2.Interval = int.Parse(txtInterval2.Text);
                    timer2.Enabled = true;
                }
                else if (((Button)sender).Text == "停止")
                {
                    ((Button)sender).Text = "发布";
                    timer2.Enabled = false;
                }
                else
                {
                    client.Publish(txtPublish1.Text, Encoding.UTF8.GetBytes(sendTxtBox1.Text.Trim()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void unSubScribe3_Click(object sender, EventArgs e)
        {
            client.Unsubscribe(new string[] { txtSubscribe3.Text });
            receiveTxtBox.AppendText("取消订阅" + txtSubscribe3.Text + "\r\n");
        }

        private void subscribe3_Click(object sender, EventArgs e)
        {
            try
            {
                // 订阅主题"/home/temperature" 消息质量为 0 
                client.Subscribe(new string[] { txtSubscribe3.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                receiveTxtBox.AppendText("订阅" + txtSubscribe3.Text + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void publish2_Click(object sender, EventArgs e)
        {
            try
            {
                if ((chkPublish3.Checked) && (((Button)sender).Text == "发布"))
                {
                    ((Button)sender).Text = "停止";
                    timer3.Interval = int.Parse(txtInterval3.Text);
                    timer3.Enabled = true;
                }
                else if (((Button)sender).Text == "停止")
                {
                    ((Button)sender).Text = "发布";
                    timer3.Enabled = false;
                }
                else
                {
                    client.Publish(txtPublish2.Text, Encoding.UTF8.GetBytes(sendTxtBox2.Text.Trim()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void publish3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((chkPublish4.Checked) && (((Button)sender).Text == "发布"))
                {
                    ((Button)sender).Text = "停止";
                    timer4.Interval = int.Parse(txtInterval4.Text);
                    timer4.Enabled = true;
                }
                else if (((Button)sender).Text == "停止")
                {
                    ((Button)sender).Text = "发布";
                    timer4.Enabled = false;
                }
                else
                {
                    client.Publish(txtPublish3.Text, Encoding.UTF8.GetBytes(sendTxtBox3.Text.Trim()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string tradeTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            client.Disconnect();
            receiveTxtBox.AppendText(tradeTime + " 服务器已断开！\r\n");
            unSubScribe.Enabled = false;
            unSubScribe1.Enabled = false;
            unSubScribe2.Enabled = false;
            unSubScribe3.Enabled = false;
            subscribe.Enabled = false;
            subscribe1.Enabled = false;
            subscribe2.Enabled = false;
            subscribe3.Enabled = false;
            publish.Enabled = false;
            publish1.Enabled = false;
            btnPublish2.Enabled = false;
            btnPublish3.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txtClientID.Enabled = true;
            }
            else
            {
                txtClientID.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txtCa.Enabled = true;
                btnSelCA.Enabled = true;
            }
            else
            {
                txtCa.Enabled = false;
                btnSelCA.Enabled = false;
            }
        }

        private void chkPublish1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txtInterval.Enabled = true;
            }
            else
            {
                txtInterval.Enabled = false;
            }
        }

        private void chkPublish2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txtInterval2.Enabled = true;
            }
            else
            {
                txtInterval2.Enabled = false;
            }
        }

        private void chkPublish3_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txtInterval3.Enabled = true;
            }
            else
            {
                txtInterval3.Enabled = false;
            }
        }

        private void chkPublish4_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txtInterval4.Enabled = true;
            }
            else
            {
                txtInterval4.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            client.Publish(txtPublish.Text, Encoding.UTF8.GetBytes(sendTxtBox.Text.Trim()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            client.Publish(txtPublish1.Text, Encoding.UTF8.GetBytes(sendTxtBox1.Text.Trim()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            client.Publish(txtPublish2.Text, Encoding.UTF8.GetBytes(sendTxtBox2.Text.Trim()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            client.Publish(txtPublish3.Text, Encoding.UTF8.GetBytes(sendTxtBox3.Text.Trim()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }

        private void btnSelCA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "证书文件|*.cer|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fName = openFileDialog.FileName;
                txtCa.Text = fName;
            }
        }

        static bool cafileValidCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            string msg = "X509 链状态:";
            foreach (X509ChainStatus status in chain.ChainStatus)
            {
                msg += status.StatusInformation + "\n";
            }
            msg += "SSL策略问题：" + (int)sslPolicyErrors;

            Console.WriteLine(msg);

            if (sslPolicyErrors != SslPolicyErrors.None)
                return false;
            return true;
        }
    }
}
