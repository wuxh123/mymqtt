using System;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

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
            receiveTxtBox.SelectedText = tradeTime+ " 收到消息：";
            receiveTxtBox.SelectionColor = Color.DarkCyan;
            receiveTxtBox.AppendText(msg + "\r\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                client.Disconnect();
            }
            catch (Exception ex) {
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
                receiveTxtBox.AppendText(tradeTime + " 正在连接服务器……\r\n");
                //创建客户端实例
                client = new MqttClient(txtHost.Text.ToString(), int.Parse(txtPort.Text), false, null, null, MqttSslProtocols.None);

                // 注册消息接收处理事件，还可以注册消息订阅成功、取消订阅成功、与服务器断开等事件处理函数
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                //生成客户端ID并连接服务器
                string clientId = System.Guid.NewGuid().ToString(); //Guid.NewGuid().ToString();
                client.Connect(clientId, txtUser.Text, txtPass.Text);

                tradeTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
                if (client.IsConnected)
                {
                    receiveTxtBox.SelectionColor = Color.Blue;
                    receiveTxtBox.AppendText(tradeTime + " 成功连接服务器。\r\n");
                }
                else
                    receiveTxtBox.AppendText(tradeTime + " 连接服务器失败！\r\n");
            }
            catch (Exception ex) {
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
            receiveTxtBox.AppendText("取消订阅" + txtSubscribe.Text);
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
                receiveTxtBox.AppendText("订阅" + txtSubscribe.Text);
            }
            catch (Exception ex) {
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
                client.Publish(txtPublish.Text, Encoding.UTF8.GetBytes(sendTxtBox.Text.Trim()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
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
            SetConfigValue("publish", txtPublish.Text);
            SetConfigValue("lastMsg", sendTxtBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHost.Text = GetConfigValue("host");
            txtPort.Text = GetConfigValue("port");
            txtUser.Text = GetConfigValue("user");
            txtPass.Text = GetConfigValue("password");
            txtSubscribe.Text = GetConfigValue("subscribe");
            txtPublish.Text = GetConfigValue("publish");
            sendTxtBox.Text = GetConfigValue("lastMsg"); 
        }
    }
}
