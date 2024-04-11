using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardProjectileScript : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
   
    void Update()
    {

        transform.Translate(Vector3.right * speed * Time.deltaTime);

    }

  
}
