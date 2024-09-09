using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace SmartHomeApp
{
    public partial class SenzorPokreta : Form
    {
        public MqttClient mqttClient;

        private DateTime zadnjePoslaniMailVrijeme;
        private const int mailPeriodCekanja = 300; // 5 minuta

        private const string TopicSenzorPokretaTrenutno = "sigurnost/senzor_pokreta/trenutno";
        private const string TopicSenzorPokretaDatum = "sigurnost/senzor_pokreta/datum";
        private const string TopicSenzorPokretaVrijeme = "sigurnost/senzor_pokreta/vrijeme";
        public SenzorPokreta()
        {
            InitializeComponent();

            mqttClient = MqttClientSingleton.Instance;

            MqttClientSingleton.Instance.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;

            zadnjePoslaniMailVrijeme = DateTime.MinValue;
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string topic = e.Topic;
            string value = Encoding.UTF8.GetString(e.Message);

            if (topic == TopicSenzorPokretaTrenutno)
            {
                if(value == "ON")
                {
                    lblStanjeSenzoraPokreta.Invoke(new Action(() => lblStanjeSenzoraPokreta.Text = "Netko se kreće!"));
                    posaljiMail();
                }
                else
                {
                    lblStanjeSenzoraPokreta.Invoke(new Action(() => lblStanjeSenzoraPokreta.Text = "Nema pokreta"));
                }
            }

            if (topic == TopicSenzorPokretaDatum)
            {
                lblDatumOcitanja.Invoke(new Action(() => lblDatumOcitanja.Text = value));
            }

            if (topic == TopicSenzorPokretaVrijeme)
            {
                lblVrijemeOcitanja.Invoke(new Action(() => lblVrijemeOcitanja.Text = value));
            }
        }

        private void posaljiMail()
        {
            if ((DateTime.Now - zadnjePoslaniMailVrijeme).TotalSeconds < mailPeriodCekanja)
            {
                return;
            }

            try
            {
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                mm.From = new MailAddress("fjurinic@gmail.com");
                mm.To.Add("fjurinic@gmail.com");
                mm.Subject = "Upozorenje!";
                mm.Body = "Netko se kretao u vašem dvorištu!";
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential("fjurinic@gmail.com", "jswh gydj iizz hogn");
                sc.EnableSsl = true;
                sc.Send(mm);

                zadnjePoslaniMailVrijeme = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "ERROR");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MqttClientSingleton.Instance.MqttMsgPublishReceived -= MqttClient_MqttMsgPublishReceived;
            this.Close();
        }

        private void SenzorPokreta_Load(object sender, EventArgs e)
        {
            mqttClient.Subscribe(MqttTopics.DefaultTopics, MqttTopics.DefaultQosLevels);
        }
    }
}
