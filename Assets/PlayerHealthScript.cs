using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public float Health = 1f;
    void Start()
    {

    }

    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
   
}
