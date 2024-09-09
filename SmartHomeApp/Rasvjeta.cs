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
    public partial class Rasvjeta : Form
    {
        public MqttClient mqttClient;

        // Definišite varijable za topike
        private const string TopicKuhinja = "rasvjeta/kuhinja";
        private const string TopicDnevnaSoba = "rasvjeta/dnevna_soba";
        private const string TopicSpavacaSoba = "rasvjeta/spavaca_soba";
        private const string TopicKupaonica = "rasvjeta/kupaonica";

        public Rasvjeta()
        {
            InitializeComponent();

            mqttClient = MqttClientSingleton.Instance;
            // Pretplatiti se na događaj samo jednom, kada se klijent prvi put koristi
            MqttClientSingleton.Instance.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string topic = e.Topic;
            string value = Encoding.UTF8.GetString(e.Message);

            // Izaberite odgovarajući PictureBox na osnovu topic-a i postavite sliku
            if (topic == TopicKuhinja)
            {
                pictureBox1.Invoke(new Action(() =>
                {
                    pictureBox1.Image = value == "ON"
                        ? Properties.Resources.LampON
                        : Properties.Resources.LampOFF;
                }));
            }
            if (topic == TopicDnevnaSoba)
            {
                pictureBox2.Invoke(new Action(() =>
                {
                    pictureBox2.Image = value == "ON"
                        ? Properties.Resources.LampON
                        : Properties.Resources.LampOFF;
                }));
            }
            if (topic == TopicSpavacaSoba)
            {
                pictureBox3.Invoke(new Action(() =>
                {
                    pictureBox3.Image = value == "ON"
                        ? Properties.Resources.LampON
                        : Properties.Resources.LampOFF;
                }));
            }
            if (topic == TopicKupaonica)
            {
                pictureBox4.Invoke(new Action(() =>
                {
                    pictureBox4.Image = value == "ON"
                        ? Properties.Resources.LampON
                        : Properties.Resources.LampOFF;
                }));
            }
        }

        private void btnUpali1_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicKuhinja, Encoding.UTF8.GetBytes("ON"), 1, true);
        }

        private void btnUpali2_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicDnevnaSoba, Encoding.UTF8.GetBytes("ON"), 1, true);
        }

        private void btnUpali3_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicSpavacaSoba, Encoding.UTF8.GetBytes("ON"), 1, true);
        }

        private void btnUpali4_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicKupaonica, Encoding.UTF8.GetBytes("ON"), 1, true);
        }

        private void btnUgasi1_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicKuhinja, Encoding.UTF8.GetBytes("OFF"), 1, true);
        }

        private void btnUgasi2_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicDnevnaSoba, Encoding.UTF8.GetBytes("OFF"), 1, true);
        }

        private void btnUgasi3_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicSpavacaSoba, Encoding.UTF8.GetBytes("OFF"), 1, true);
        }

        private void btnUgasi4_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicKupaonica, Encoding.UTF8.GetBytes("OFF"), 1, true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MqttClientSingleton.Instance.MqttMsgPublishReceived -= MqttClient_MqttMsgPublishReceived;
            this.Close();
        }

        private void Rasvjeta_Load(object sender, EventArgs e)
        {
            mqttClient.Subscribe(MqttTopics.DefaultTopics, MqttTopics.DefaultQosLevels);
        }

        private void Rasvjeta_FormClosing(object sender, FormClosingEventArgs e)
        {
            MqttClientSingleton.Instance.MqttMsgPublishReceived -= MqttClient_MqttMsgPublishReceived;
        }
    }
}
