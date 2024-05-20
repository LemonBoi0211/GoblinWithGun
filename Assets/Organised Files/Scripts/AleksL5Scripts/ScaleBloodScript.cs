using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBloodScript : MonoBehaviour
{
    public Vector3 Scale = new Vector3(2f, 2f, 2f); 
    public float duration = 2f;

    private Vector3 initialScale;
    private float timer;

    void Start()
    {
        initialScale = transform.localScale;
        timer = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        transform.localScale = Vector3.Lerp(initialScale, Scale, timer / duration);

        if (timer >= duration)
        {
            transform.localScale = Scale;
            enabled = false; 
        }
    }
}
