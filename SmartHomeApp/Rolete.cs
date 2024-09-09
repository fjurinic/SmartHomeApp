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
    public partial class Rolete : Form
    {
        public MqttClient mqttClient;

        private const string TopicRolete = "rolete/nacin_rada";
        public Rolete()
        {
            InitializeComponent();
            mqttClient = MqttClientSingleton.Instance;

            MqttClientSingleton.Instance.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string topic = e.Topic;
            string value = Encoding.UTF8.GetString(e.Message);

            if (topic == TopicRolete)
            {
                pictureBox1.Invoke(new Action(() =>
                {
                    switch (value)
                    {
                        case "ON":
                            pictureBox1.Image = Properties.Resources.ON;
                            lblNacinRadaRoleta.Invoke(new Action(() => lblNacinRadaRoleta.Text = "Automatski način\nrada ISKLJUČEN."));
                            break;
                        case "OFF":
                            pictureBox1.Image = Properties.Resources.OFF;
                            lblNacinRadaRoleta.Invoke(new Action(() => lblNacinRadaRoleta.Text = "Automatski način\nrada ISKLJUČEN."));
                            break;
                        case "HALF":
                            pictureBox1.Image = Properties.Resources.HALF;
                            lblNacinRadaRoleta.Invoke(new Action(() => lblNacinRadaRoleta.Text = "Automatski način\nrada ISKLJUČEN."));
                            break;
                        case "AUTO":
                            lblNacinRadaRoleta.Invoke(new Action(() => lblNacinRadaRoleta.Text = "Automatski način\nrada UKLJUČEN."));
                            break;
                    }
                }));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MqttClientSingleton.Instance.MqttMsgPublishReceived -= MqttClient_MqttMsgPublishReceived;
            this.Close();
        }

        private void btnAutoRolete_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicRolete, Encoding.UTF8.GetBytes("AUTO"), 1, true);
        }

        private void btnDigni_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicRolete, Encoding.UTF8.GetBytes("OFF"), 1, true);

        }

        private void btnSredina_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicRolete, Encoding.UTF8.GetBytes("HALF"), 1, true);

        }

        private void btnSpusti_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(TopicRolete, Encoding.UTF8.GetBytes("ON"), 1, true);

        }

        private void Rolete_Load(object sender, EventArgs e)
        {
            mqttClient.Subscribe(MqttTopics.DefaultTopics, MqttTopics.DefaultQosLevels);
        }
    }
}
