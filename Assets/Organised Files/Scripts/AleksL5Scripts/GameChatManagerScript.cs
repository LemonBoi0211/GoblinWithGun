using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class GameChatManagerScript : MonoBehaviour
{
    public bool NewText = false;
    public GameObject ChatText;
    public float Countdown = 2;
    void Start()
    {
        NewText = true;
        Countdown = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Countdown -= Time.deltaTime;
        if (Countdown < 0)
        {
            ResetTimer();
            NewText = true;

        }
        if (NewText == true)
        {
            Instantiate(ChatText, new Vector3(-33.39f, -20.9f, 0f), transform.rotation, transform);
            Invoke("Delay", 0f);
        }
    }
    public void Delay()
    {
        NewText = false;
    }
    public void ResetTimer()
    {
        Countdown = Random.Range(3f, 10f);
    }
}
