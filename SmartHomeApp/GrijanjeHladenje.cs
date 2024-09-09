using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartHomeApp
{

    public partial class GrijanjeHladenje : Form
    {
        public MqttClient mqttClient;

        private const string TopicTemperatura = "senzor/temperatura";
        private const string TopicGrijanje = "grijanje/nacin_rada";
        private const string TopicKlima = "klima/nacin_rada";

        string textGrijanje;
        string textHlađenje;

        public GrijanjeHladenje()
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

            if (topic == TopicKlima)
            {
                switch (value)
                {
                    case "ON":
                        textHlađenje = "upaljeno";
                        break;
                    case "OFF":
                        textHlađenje = "ugašeno";
                        break;
                    case "AUTO":
                        textHlađenje = "auto";
                        break;
                }
                        lblStanjeHladenje.Invoke(new Action(() => lblStanjeHladenje.Text = textHlađenje));
            }
            if (topic == TopicGrijanje)
            {
                switch (value)
                {
                    case "ON":
                        textGrijanje = "upaljeno";
                        break;
                    case "OFF":
                        textGrijanje = "ugašeno";
                        break;
                    case "AUTO":
                        textGrijanje = "auto";
                        break;
                }
                lblStanjeGrijanje.Invoke(new Action(() => lblStanjeGrijanje.Text = textGrijanje));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MqttClientSingleton.Instance.MqttMsgPublishReceived -= MqttClient_MqttMsgPublishReceived;
            this.Close();
        }

        private void GrijanjeHladenje_Load(object sender, EventArgs e)
        {
            mqttClient.Subscribe(MqttTopics.DefaultTopics, MqttTopics.DefaultQosLevels);
        }

        private void btnUpaliHladenje_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicKlima, Encoding.UTF8.GetBytes("ON"), 1, true);
            mqttClient.Publish(TopicGrijanje, Encoding.UTF8.GetBytes("OFF"), 1, true);
        }

        private void btnUgasiHladenje_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicKlima, Encoding.UTF8.GetBytes("OFF"), 1, true);
        }

        private void btnUpaliGrijanje_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicGrijanje, Encoding.UTF8.GetBytes("ON"), 1, true);
            mqttClient.Publish(TopicKlima, Encoding.UTF8.GetBytes("OFF"), 1, true);
        }

        private void btnUgasiGrijanje_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicGrijanje, Encoding.UTF8.GetBytes("OFF"), 1, true);
        }

        private void btnAutoGrijanjeHladenje_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicGrijanje, Encoding.UTF8.GetBytes("AUTO"), 1, true);
            mqttClient.Publish(TopicKlima, Encoding.UTF8.GetBytes("AUTO"), 1, true);
        }
    }
}
