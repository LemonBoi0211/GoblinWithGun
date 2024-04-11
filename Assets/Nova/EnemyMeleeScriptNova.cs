using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeScriptNova : MonoBehaviour
{
    public Transform Player;
    public int Health = 100;
    public float Speed = 5f;
    public float knockbackForce = 10f;
    public Rigidbody2D rb;

    void FixedUpdate()
    {
        if (Player != null)
        {
            float distance = Vector3.Distance(transform.position, Player.position);
            Vector2 direction = (Player.position - transform.position).normalized;
          
            if (distance > 2)
            {
                rb.AddForce(direction * Speed, ForceMode2D.Force);
            }
        }

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Health -= 20;
            Destroy(other.gameObject);
            Vector2 knockbackDirection = (transform.position - other.transform.position).normalized;
            rb.AddForce(knockbackDirection * knockbackForce, ForceMode2D.Impulse);

        }
    }

    private void Update()
    {
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
}