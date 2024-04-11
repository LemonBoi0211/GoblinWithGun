using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWizardScript : MonoBehaviour
{
    public Transform Player;
    public float direction;
    public float Health = 1f;
    public float Speed = 5f;
    public float detectionRange = 5f;
    public float knockbackForce = 10f;
    public Rigidbody2D rb;





    void Update()
    {

    

         if (Health <= 0)
         {
            Destroy(gameObject);
         }

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Player.position.x < transform.position.x)
        {
            this.transform.localScale = new Vector3(-1.2f, 1.2f, 1.2f);
        }
        if (Player.position.x >= transform.position.x)
        {
            this.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }


    }
    


  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Health -= 0.2f;
            Destroy(other.gameObject);

            Vector2 knockbackDirection = (transform.position - other.transform.position).normalized;
            rb.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);
        }
    }



}
