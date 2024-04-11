using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardProjectileScript : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public PlayerHealthScript PlayerHealthScript;


    void Update()
    {

        transform.Translate(Vector3.right * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Hit");
            PlayerHealthScript.Health = -0.25f;
        }
    }
}
