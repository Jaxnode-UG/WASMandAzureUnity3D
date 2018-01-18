using UnityEngine;
using System.Collections;
using System;

public class EchoTest : MonoBehaviour
{

    // Use this for initialization
    WebSocket w;
    string reply;
    void Start()
    {

            w = new WebSocket(new Uri("ws://40.71.23.187:8080"));
            StartCoroutine(w.Connect());

        
    }

    void Update()
    {

            try
            {
                reply = w.RecvString();
            }
            catch (Exception e)
            {
                Debug.LogError("Error: " + e.ToString());
               // break;
            }

            if (reply != null)
            {
                Debug.Log("Received: " + reply);

            }
            if (w.error != null)
            {
                Debug.LogError("Error: " + w.error.ToString());

            }             
             
        
    }

    public void SendData()
    {
        w.SendString("Sending Data");
    }


    public void CloseConnection()
    {
        w.Close();
    }
}
