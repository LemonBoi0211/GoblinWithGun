 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeScript : MonoBehaviour
{
    public Transform Player;
    public float Speed = 5f;
    public int Health = 100;
    public float knockbackForce = 10f;
    public Rigidbody2D rb;
    public Animator Animator;
    public MeleeAreaOfAttackScript AttackScript;
    public PlayerHealthScript PlayerHealthScript;
    public GameObject[] consumables;
    public int randonConsumable;

    public GameObject consumableA;
    public GameObject consumableB;
    public GameObject consumableC;
    public GameObject consumableD;
    public GameObject consumableE;


    void Start()
    {
        consumables = new GameObject[5];
        consumables[0] = consumableA;
        consumables[1] = consumableB;
        consumables[2] = consumableC;
        consumables[3] = consumableD;
        consumables[4] = consumableE;


        foreach (GameObject obj in consumables)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }

    }

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
                this.transform.localScale = new Vector3(-1.3f, 1.3f, 1.3f);
            }
            if (Player.position.x >= transform.position.x)
            {
                this.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
            }


        if (Health <= 0.1)
        {
            Instantiate(consumables[4], transform.position, Quaternion.identity);
            randonConsumable = Random.Range(6, 10);

            if (randonConsumable <= 5)
            {

            }
            else if (randonConsumable == 6)
            {
                Instantiate(consumables[0], transform.position, Quaternion.identity);
            }
            else if (randonConsumable == 7)
            {
                Instantiate(consumables[1], transform.position, Quaternion.identity);
            }
            else if (randonConsumable == 8)
            {
                Instantiate(consumables[2], transform.position, Quaternion.identity);
            }
            else if (randonConsumable == 9)
            {
                Instantiate(consumables[3], transform.position, Quaternion.identity);
            }
            
            Destroy(gameObject);
        }

    }

    void Hit()
        {
           if (AttackScript.canDoDamage == true)
           {
             Debug.Log("Hit");
            PlayerHealthScript.Health -= 0.25f;
           }
        }
   } 