using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;

namespace SmartHomeApp
{
    public class MqttClientSingleton
    {
        private static MqttClient instance;

        private MqttClientSingleton() { }

        public static MqttClient Instance
        {
            get
            {
                if (instance == null)
                {
                    X509Certificate serverCert = new X509Certificate(@"C:\Users\Filip\server.pem");
                    instance = new MqttClient("82e01f116a1e4ba5b3c40e8dfee15fdc.s1.eu.hivemq.cloud", 8883, true, serverCert, serverCert, MqttSslProtocols.TLSv1_2);
                    instance.Connect("SmartHomeAppClient", "fjurinic", "********");
                }
                return instance;
            }
        }
    }
}
