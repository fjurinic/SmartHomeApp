using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartHomeApp
{
    public static class MqttTopics
    {
        // Definiranje topica u statičkim svojstvima
        public static readonly string[] DefaultTopics = new string[]
        {
        "rasvjeta/kuhinja",
        "rasvjeta/dnevna_soba",
        "rasvjeta/spavaca_soba",
        "rasvjeta/kupaonica",
        "senzor/temperatura",
        "senzor/vlaga",
        "grijanje/nacin_rada",
        "klima/nacin_rada",
        "rolete/nacin_rada",
        "sigurnost/senzor_pokreta/trenutno",
        "sigurnost/senzor_pokreta/datum",
        "sigurnost/senzor_pokreta/vrijeme",
        "cvijece/zalijevanje/1",
        "cvijece/zalijevanje/2",
        "cvijece/zalijevanje/3",
        "cvijece/senzor_vlage/1",
        "cvijece/senzor_vlage/2",
        "cvijece/senzor_vlage/3",
        "cvijece/nacin_rada"

        // Dodaj ostale topice ovdje
    };

        // Definiranje QoS nivoa za svaki topic
        public static readonly byte[] DefaultQosLevels = new byte[]
        {
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, // QoS za "filip/tag1"
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
        MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE

        };
    }
}
