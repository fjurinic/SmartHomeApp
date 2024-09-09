using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace SmartHomeApp
{
    public partial class TemperaturaVlaga : Form
    {
        public MqttClient mqttClient;

        private const string TopicTemperatura = "senzor/temperatura";
        private const string TopicVlaga = "senzor/vlaga";
        public TemperaturaVlaga()
        {
            InitializeComponent();
            mqttClient = MqttClientSingleton.Instance;

            MqttClientSingleton.Instance.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string topic = e.Topic;
            string value = Encoding.UTF8.GetString(e.Message);

            if (topic == TopicTemperatura)
            {
                pbTemperatura.Invoke(new Action(() => pbTemperatura.Value = int.Parse(value.Split('.')[0]) + 40));
                lblTemp.Invoke(new Action(() => lblTemp.Text = value + " °C"));
            }

            if (topic == TopicVlaga)
            {
                pbVlaga.Invoke(new Action(() => pbVlaga.Value = int.Parse(value.Split('.')[0])));
                lblVlaga.Invoke(new Action(() => lblVlaga.Text = value + "%"));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MqttClientSingleton.Instance.MqttMsgPublishReceived -= MqttClient_MqttMsgPublishReceived;
            this.Close();
        }

        private void TemperaturaVlaga_Load(object sender, EventArgs e)
        {
            mqttClient.Subscribe(MqttTopics.DefaultTopics, MqttTopics.DefaultQosLevels);
        }
    }
}
