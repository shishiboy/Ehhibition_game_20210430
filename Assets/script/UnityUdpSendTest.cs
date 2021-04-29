using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

public class UnityUdpSendTest : MonoBehaviour
{
    string localIpString = "192.168.2.100";
    int localPort = 8887;
    string ArduinoIpString = "192.168.2.101";
    int ArduinoPort = 8888;
    private UdpClient udp;

    void Start()
    {
        IPAddress localAddress = IPAddress.Parse(localIpString);
        IPEndPoint localEP = new IPEndPoint(localAddress, localPort);
        udp = new UdpClient(localEP);
        udp.Client.ReceiveTimeout = 3000;
        IPAddress ArduinoAddress = IPAddress.Parse(ArduinoIpString);
        IPEndPoint ArduinoEP = new IPEndPoint(ArduinoAddress, ArduinoPort);
        udp.Connect(ArduinoEP);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            byte[] dgram = Encoding.UTF8.GetBytes("1");
            udp.Send(dgram, 1);
            Debug.Log("Send_1");
        }
        if (Input.GetKey(KeyCode.S))
        {
            byte[] dgram = Encoding.UTF8.GetBytes("0");
            udp.Send(dgram, 1);
            Debug.Log("Send_0");
        }
    }
    void OnApplicationQuit()
    {
        if (udp != null) udp.Close();
    }
}