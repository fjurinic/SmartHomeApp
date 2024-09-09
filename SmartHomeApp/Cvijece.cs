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
    public partial class Cvijece : Form
    {

        public MqttClient mqttClient;

        private const string TopicCvijeceZalijevanje1 = "cvijece/zalijevanje/1";
        private const string TopicCvijeceZalijevanje2 = "cvijece/zalijevanje/2";
        private const string TopicCvijeceZalijevanje3 = "cvijece/zalijevanje/3";

        private const string TopicCvijeceSenzorVlage1 = "cvijece/senzor_vlage/1";
        private const string TopicCvijeceSenzorVlage2 = "cvijece/senzor_vlage/2";
        private const string TopicCvijeceSenzorVlage3 = "cvijece/senzor_vlage/3";

        private const string TopicCvijeceNacinRada = "cvijece/nacin_rada";

        bool auto_nacin_rada;
        float vlaga1;
        float vlaga2;
        float vlaga3;

        public Cvijece()
        {
            InitializeComponent();
            mqttClient = MqttClientSingleton.Instance;

            MqttClientSingleton.Instance.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string topic = e.Topic;
            string value = Encoding.UTF8.GetString(e.Message);

            if (topic == TopicCvijeceNacinRada)
            {
                if (value == "AUTO")
                {
                    lblCvijeceNacinRada.Invoke(new Action(() => lblCvijeceNacinRada.Text = "Automatski način\nrada UKLJUČEN."));
                    btnZalij1.Invoke(new Action(() => btnZalij1.Enabled = false));
                    btnZalij2.Invoke(new Action(() => btnZalij2.Enabled = false));
                    btnZalij3.Invoke(new Action(() => btnZalij3.Enabled = false));
                    auto_nacin_rada = true;
                }
                else
                {
                    lblCvijeceNacinRada.Invoke(new Action(() => lblCvijeceNacinRada.Text = "Automatski način\nrada ISKLJUČEN."));
                    btnZalij1.Invoke(new Action(() => btnZalij1.Enabled = true));
                    btnZalij2.Invoke(new Action(() => btnZalij2.Enabled = true));
                    btnZalij3.Invoke(new Action(() => btnZalij3.Enabled = true));
                    auto_nacin_rada = false;
                }
            }


            if (topic == TopicCvijeceZalijevanje1)
            {
                if (value == "ON")
                {
                    lblZalijevanje1.Invoke(new Action(() => lblZalijevanje1.Text = "Zalijevam"));
                    btnAutoNacinRada.Invoke(new Action(() => btnAutoNacinRada.Enabled = false));
                }
                else
                {
                    lblZalijevanje1.Invoke(new Action(() => lblZalijevanje1.Text = ""));
                    btnAutoNacinRada.Invoke(new Action(() => btnAutoNacinRada.Enabled = true));
                }
            }

            if (topic == TopicCvijeceZalijevanje2)
            {
                if (value == "ON")
                {
                    lblZalijevanje2.Invoke(new Action(() => lblZalijevanje2.Text = "Zalijevam"));
                    btnAutoNacinRada.Invoke(new Action(() => btnAutoNacinRada.Enabled = false));
                }
                else
                {
                    lblZalijevanje2.Invoke(new Action(() => lblZalijevanje2.Text = ""));
                    btnAutoNacinRada.Invoke(new Action(() => btnAutoNacinRada.Enabled = true));
                }
            }

            if (topic == TopicCvijeceZalijevanje3)
            {
                if (value == "ON")
                {
                    lblZalijevanje3.Invoke(new Action(() => lblZalijevanje3.Text = "Zalijevam"));
                    btnAutoNacinRada.Invoke(new Action(() => btnAutoNacinRada.Enabled = false));
                }
                else
                {
                    lblZalijevanje3.Invoke(new Action(() => lblZalijevanje3.Text = ""));
                    btnAutoNacinRada.Invoke(new Action(() => btnAutoNacinRada.Enabled = true));
                }
            }

            if (topic == TopicCvijeceSenzorVlage1)
            {
                lblVlaga1.Invoke(new Action(() => lblVlaga1.Text = value + "%"));
                vlaga1 = float.Parse(value);
            }
            if (topic == TopicCvijeceSenzorVlage2)
            {
                lblVlaga2.Invoke(new Action(() => lblVlaga2.Text = value + "%"));
                vlaga2 = float.Parse(value);
            }
            if (topic == TopicCvijeceSenzorVlage3)
            {
                lblVlaga3.Invoke(new Action(() => lblVlaga3.Text = value + "%"));
                vlaga3 = float.Parse(value);
            }
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            MqttClientSingleton.Instance.MqttMsgPublishReceived -= MqttClient_MqttMsgPublishReceived;
            this.Close();
        }

        private void Cvijece_Load(object sender, EventArgs e)
        {
            mqttClient.Subscribe(MqttTopics.DefaultTopics, MqttTopics.DefaultQosLevels);
        }

        private void btnAutoNacinRada_Click(object sender, EventArgs e)
        {
            if(auto_nacin_rada)
            {
                mqttClient.Publish(TopicCvijeceNacinRada, Encoding.UTF8.GetBytes("OFF"), 1, true);
            }
            else
            {
                mqttClient.Publish(TopicCvijeceNacinRada, Encoding.UTF8.GetBytes("AUTO"), 1, true);
            }
        }

        private void btnZalij1_Click(object sender, EventArgs e)
        {
            if(vlaga1 < 80)
            {
                mqttClient.Publish(TopicCvijeceZalijevanje1, Encoding.UTF8.GetBytes("ON"), 1, true);
            }
            else
            {
                MessageBox.Show("Nije moguće zalijati!\nVlaga preko 80%!");
            }
        }

        private void btnZalij2_Click(object sender, EventArgs e)
        {
            if (vlaga2 < 80)
            {
                mqttClient.Publish(TopicCvijeceZalijevanje2, Encoding.UTF8.GetBytes("ON"), 1, true);
            }
            else
            {
                MessageBox.Show("Nije moguće zalijati!\nVlaga preko 80%!");
            }
        }

        private void btnZalij3_Click(object sender, EventArgs e)
        {
            if (vlaga3 < 80)
            {
                mqttClient.Publish(TopicCvijeceZalijevanje3, Encoding.UTF8.GetBytes("ON"), 1, true);
            }
            else
            {
                MessageBox.Show("Nije moguće zalijati!\nVlaga preko 80%!");
            }
        }
    }
}
