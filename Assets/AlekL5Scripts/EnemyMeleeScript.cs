using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeScript : MonoBehaviour
{
    public Transform Player;
    public float Speed = 5f;
    public float knockbackForce = 10f;
    public Rigidbody2D rb;
    public Animator Animator;
    public MeleeAreaOfAttackScript AttackScript;

    void FixedUpdate()
    {
       
            if (Player != null)
            {
                float distance = Vector3.Distance(transform.position, Player.position);
                Vector2 direction = (Player.position - transform.position).normalized;

                if (distance > 1)
                {
                    Animator.SetBool("IsAttacking", false);
                    rb.AddForce(direction * Speed, ForceMode2D.Force);
                }
                else
                {
                    Animator.SetBool("IsAttacking", true);

                    if (Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
                    {

                    }
                }
            }

         

        
    }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Bullet"))
            {
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

        void Hit()
        {
           if (AttackScript.canDoDamage == true)
           {
            Debug.Log("Hit");
           }
        }
   } 