using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace SmartHomeApp
{
    public partial class Pocetna : Form
    {
        public MqttClient mqttClient;

        public Pocetna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rasvjeta rasvjeta = new Rasvjeta();
            rasvjeta.ShowDialog();
        }

        private void Pocetna_FormClosing(object sender, FormClosingEventArgs e)
        {
            MqttClientSingleton.Instance.Disconnect();
        }

        private void btnSenzori_Click(object sender, EventArgs e)
        {
            TemperaturaVlaga temperaturaVlaga = new TemperaturaVlaga();
            temperaturaVlaga.ShowDialog();
        }

        private void btnGrijanjeHladenje_Click(object sender, EventArgs e)
        {
            GrijanjeHladenje grijanjeHladenje = new GrijanjeHladenje();
            grijanjeHladenje.ShowDialog();
        }

        private void btnRolete_Click(object sender, EventArgs e)
        {
            Rolete rolete = new Rolete();
            rolete.ShowDialog();
        }

        private void btnPokreti_Click(object sender, EventArgs e)
        {
            SenzorPokreta senzorPokreta = new SenzorPokreta();
            senzorPokreta.ShowDialog();
        }

        private void btnCvijece_Click(object sender, EventArgs e)
        {
            Cvijece cvijece = new Cvijece();
            cvijece.ShowDialog();
        }
    }        
}
